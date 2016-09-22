using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Telas.Financeiro.ContaCaixa;
using DevExpress.XtraEditors;
using Extrato = Canaan.Lib.Extrato;

namespace Canaan.Telas.Financeiro.Lancamento
{
    public partial class Baixa : XtraForm
    {
        #region PROPRIEDADES

        public Lib.Lancamento objLib { get; set; }
        public Extrato objLibExtrato { get; set; }
        public List<Dados.Lancamento> Lancamentos { get; set; }
        public BindingList<Lib.Model.Baixa> BindList { get; set; }
        public Session Session 
        { 
            get 
            {
                return Session.Instance;
            }
        }
        public Dados.Extrato Extrato { get; set; }
        
        #endregion

        #region CONSTRUTORES

        public Baixa(int[] ids)
        {
            //inicializa as propriedades
            objLib = new Lib.Lancamento();
            objLibExtrato = new Extrato();
            Lancamentos = objLib.Get(ids);

            //incializa os componentes
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Baixa_Load(object sender, EventArgs e)
        {
            SetTitle();
            CarregaFormaPgto();
            CarregaGrid();
            InitForm();
        }

        private void btnEfetuaBaixa_Click(object sender, EventArgs e)
        {
            EfetuaBaixa();
        }

        private void btnCalculaValores_Click(object sender, EventArgs e)
        {
            var confirm = "Tem certeza que deseja executar o recalculo?\nTodos os valores alterados manualmente serão perdidos";

            if (MessageBoxUtilities.MessageQuestion(confirm) == DialogResult.Yes) 
            {
                CarregaBindList();
                CarregaGrid();
                UpdateValores();
            }
        }

        private void contaCaixaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarregaContaCaixa();
        }

        private void valorPagoTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            valorTrocoLabel.Text = string.Format("{0:c}", CalculaTroco());
        }
        
        private void lancDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (BindList != null)
            {
                UpdateValores();
            }
        }

        #endregion

        #region METODOS

        private void InitForm() 
        {
            dataBaixaDateEdit.EditValue = DateTime.Today;
            idContaCaixaTextEdit.EditValue = Lancamentos.FirstOrDefault().IdContaCaixa;
            contaCaixaLinkLabel.Text = new Lib.ContaCaixa().GetById(Lancamentos.FirstOrDefault().IdContaCaixa).Nome;

            //atualiza valores liquidos
            UpdateValores();
        }

        private void SetTitle() 
        {
            if (Lancamentos.Count > 0) 
            { 
                var first = Lancamentos.FirstOrDefault().CliFor;
                var nome = first.Nome;
                Text = string.Format("Baixa de Lancamentos - {0} - {1}", first.IdCliFor, nome);
            }
        }

        private void CarregaFormaPgto() 
        {
            tipoPgtoComboBox.DataSource = Enum.GetValues(typeof(EnumPgtoTipo));
        }

        private void CarregaContaCaixa()
        {
            var frm = new Seleciona();
            frm.ShowDialog();

            if (frm.objItem != null)
            {
                idContaCaixaTextEdit.Text = frm.objItem.IdContaCaixa.ToString();
                contaCaixaLinkLabel.Text = frm.objItem.Nome;
            }
        }

        private void CarregaBindList() 
        {
            BindList = new BindingList<Lib.Model.Baixa>(Lancamentos.OrderBy(a => a.DataVencimento).Select(a => new Lib.Model.Baixa
            {
                Codigo = a.IdLancamento,
                Vencimento = a.DataVencimento,
                ValorOriginal = a.ValorOriginal,
                ValorJuros = objLib.CalculaJuros(a),
                ValorMulta = objLib.CalculaMulta(a),
                ValorAcrescimo = a.ValorAcrescimo,
                ValorDesconto = a.ValorDesconto,
                ValorLiquido = objLib.CalculaLiquido(a)
            }).ToList());
        }

        private void CarregaGrid() 
        {
            CarregaBindList();
            lancDataGridView.DataSource = BindList;
        }

        private void UpdateValores() 
        {
            //atualiza valores do grid
            foreach (var item in BindList) 
            {
                item.ValorLiquido = item.ValorOriginal + item.ValorMulta + item.ValorJuros + item.ValorAcrescimo - item.ValorDesconto;
            }
            lancDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);

            //atualiza valor liquido do form
            valorLiquidoLabel.Text = string.Format("{0:c}", BindList.Sum(a => a.ValorLiquido));

            //se valor pago estiver informado atualiza o troco
            if (valorPagoTextEdit.EditValue != null) 
                valorTrocoLabel.Text = string.Format("{0:c}", CalculaTroco());
        }

        private decimal CalculaTroco() 
        {
            decimal liquido = BindList.Sum(a => a.ValorLiquido);
            decimal pago = valorPagoTextEdit.EditValue == null ? 0 : decimal.Parse(valorPagoTextEdit.EditValue.ToString().Replace('.', ','));

            return (liquido - pago) * -1;
        }

        private void EfetuaBaixa() 
        {
            //verifica troco
            if (CalculaTroco() < 0)
            {
                MessageBoxUtilities.MessageInfo("Valor pago não pode ser menor que o valor líquido");
            }
            else 
            {
                //confirma informações da baixa
                if (MessageBoxUtilities.MessageQuestion(ConfirmaInfo()) == DialogResult.Yes) 
                {
                    try
                    {
                        //altera dados no banco de dados
                        SalvaExtrato();
                        UpdateLancamentos();

                        //imprime recibo
                        var recibo = new Relatorios.Financeiro.Recibo.Viewer(Extrato.IdExtrato);
                        recibo.ShowDialog();

                        //fecha a janela
                        Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBoxUtilities.MessageError(null, ex);
                    }
                }
            }
        }

        private string ConfirmaInfo()
        {
            var confirm = "Confirme as informações da baixa.\n\n";
            confirm += string.Format("Data do Pagamento: {0}\n", ((DateTime)dataBaixaDateEdit.EditValue).ToShortDateString());
            confirm += string.Format("Conta Caixa: {0}\n", contaCaixaLinkLabel.Text);
            confirm += string.Format("Forma de Pagamento: {0}\n", tipoPgtoComboBox.SelectedItem);
            confirm += string.Format("Valor Líquido: {0:c}\n", BindList.Sum(a => a.ValorLiquido));
            confirm += string.Format("Valor Pago: {0:c}\n", valorPagoTextEdit.EditValue == null ? 0 : decimal.Parse(valorPagoTextEdit.EditValue.ToString().Replace('.', ',')));
            confirm += string.Format("Troco: {0:c}\n", CalculaTroco());
            return confirm;
        }

        private void SalvaExtrato() 
        {
            try
            {
                //cria dados do extrato
                Extrato = new Dados.Extrato();
                Extrato.IdUsuario = Session.Usuario.IdUsuario;
                Extrato.IdContaCaixa = (int)idContaCaixaTextEdit.EditValue;
                Extrato.TipoPgto = (EnumPgtoTipo)tipoPgtoComboBox.SelectedItem;
                Extrato.Status = EnumStatusExtrato.Baixado;
                Extrato.ValorLiquido = BindList.Sum(a => a.ValorLiquido);
                Extrato.ValorPago = valorPagoTextEdit.EditValue == null ? 0 : decimal.Parse(valorPagoTextEdit.EditValue.ToString().Replace('.', ','));
                Extrato.ValorTroco = CalculaTroco();
                Extrato.ValorBaixado = BindList.Sum(a => a.ValorLiquido);
                Extrato.Data = (DateTime)dataBaixaDateEdit.EditValue;
                Extrato.Hora = DateTime.Now.TimeOfDay;

                //salva extrato no banco de dados
                Extrato = objLibExtrato.Insert(Extrato);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void UpdateLancamentos() 
        {
            try
            {
                foreach (var lanc in Lancamentos)
                {
                    //carrega correspondente na bindlist
                    var atual = BindList.FirstOrDefault(a => a.Codigo == lanc.IdLancamento);

                    //atualiza valores da lista
                    lanc.IdExtrato = Extrato.IdExtrato;
                    lanc.ValorOriginal = atual.ValorOriginal;
                    lanc.ValorMulta = atual.ValorMulta;
                    lanc.ValorLiquido = atual.ValorLiquido;
                    lanc.ValorJuros = atual.ValorJuros;
                    lanc.ValorDesconto = atual.ValorDesconto;
                    lanc.ValorBaixado = atual.ValorLiquido;
                    lanc.ValorAcrescimo = atual.ValorAcrescimo;
                    lanc.Status = EnumStatusLanc.Baixado;
                    lanc.DataBaixa = (DateTime)dataBaixaDateEdit.EditValue;

                    //salva no banco de dados
                    objLib.Update(lanc);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        #endregion
        
    }

    
}
