using System;
using DevExpress;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Telas.Base;
using Canaan.Telas.Cadastros.ClienteFornecedor;
using Canaan.Telas.Configuracoes.Geral.Filiais;
using Canaan.Telas.Movimentacoes.Venda.Principal;

namespace Canaan.Telas.Financeiro.Lancamento
{
    public partial class Edita : FormEdita
    {
        #region PROPRIEDADES

        public Lib.Lancamento objLib { get; set; }
        public Dados.Lancamento Lancamento { get; set; }

        #endregion

        #region CONSTRUTORES

        public Edita()
        {
            //carrega as propriedades
            IsNovo = true;
            objLib = new Lib.Lancamento();
            //Lancamento = new Dados.Lancamento();

            //carrega os componentes
            InitializeComponent();
        }

        public Edita(int id)
        {
            //carrega as propriedades
            IsNovo = false;
            objLib = new Lib.Lancamento();
            Lancamento = objLib.GetById(id);

            //carrega os componentes
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Edita_Load(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[0];
            SetTitle();
            CarregaTipoLancamento();
            CarregaStatus();
            CarregaClasseContabil();
            CarregaForm();
        }
        
        private void cliForLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarregaCliFor();
        }
      
        private void filialLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarregaFilial();
        }

        private void contaCaixaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarregaContaCaixa();
        }

        private void pedidoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarregaVenda();
        }

        

        private void valorOriginalTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            valorLiquidoLabelControl.Text = string.Format("{0:c}", CalculaValorLiquido());
        }

        private void valorJurosTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            valorLiquidoLabelControl.Text = string.Format("{0:c}", CalculaValorLiquido());
        }

        private void valorMultaTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            valorLiquidoLabelControl.Text = string.Format("{0:c}", CalculaValorLiquido());
        }

        private void valorDescontoTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            valorLiquidoLabelControl.Text = string.Format("{0:c}", CalculaValorLiquido());
        }

        private void valorAcrescimoTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            valorLiquidoLabelControl.Text = string.Format("{0:c}", CalculaValorLiquido());
        }

        #endregion

        #region METODOS

        protected override void SetTitle()
        {
            if (IsNovo)
                Text = "Novo Lançamento";
            else
                Text = "Editando Lancamento: " + Lancamento.IdLancamento;
        }

        private void CarregaTipoLancamento()
        {
            tipoComboBox.DataSource = Enum.GetValues(typeof(EnumLancTipo));
        }

        private void CarregaStatus()
        {
            statusComboBox.DataSource = Enum.GetValues(typeof(EnumStatusLanc));
        }

        private void CarregaClasseContabil()
        {
            classeContabilComboBox.DataSource = Enum.GetValues(typeof(EnumClasseContabil));
        }

        private void CarregaCliFor()
        {
            Wizard frm;

            if (string.IsNullOrEmpty(idCliForTextEdit.Text))
            {
                frm = new Wizard();
                frm.ShowDialog();
            }
            else
            {
                frm = new Wizard(int.Parse(idCliForTextEdit.Text));
                frm.ShowDialog();
            }



            if (frm.CliFor != null)
            {
                idCliForTextEdit.Text = frm.CliFor.IdCliFor.ToString();
                cliForLinkLabel.Text = frm.CliFor.Nome;
            }
        }

        private void CarregaFilial()
        {
            var frm = new Seleciona();
            frm.ShowDialog();

            if (frm.objItem != null)
            {
                idFilialTextEdit.Text = frm.objItem.IdFilial.ToString();
                filialLinkLabel.Text = frm.objItem.NomeFantasia;
            }
        }

        private void CarregaContaCaixa()
        {
            var frm = new ContaCaixa.Seleciona();
            frm.ShowDialog();

            if (frm.objItem != null)
            {
                idContaCaixaTextEdit.Text = frm.objItem.IdContaCaixa.ToString();
                contaCaixaLinkLabel.Text = frm.objItem.Nome;
            }
        }

        private decimal CalculaValorLiquido() 
        {
            try
            {
                decimal original = valorOriginalTextEdit.EditValue == null ? 0 : decimal.Parse(valorOriginalTextEdit.EditValue.ToString().Replace('.',','));
                decimal juros = valorJurosTextEdit.EditValue == null ? 0 : decimal.Parse(valorJurosTextEdit.EditValue.ToString().Replace('.', ','));
                decimal multa = valorMultaTextEdit.EditValue == null ? 0 : decimal.Parse(valorMultaTextEdit.EditValue.ToString().Replace('.', ','));
                decimal desconto = valorDescontoTextEdit.EditValue == null ? 0 : decimal.Parse(valorDescontoTextEdit.EditValue.ToString().Replace('.', ','));
                decimal acrescimo = valorAcrescimoTextEdit.EditValue == null ? 0 : decimal.Parse(valorAcrescimoTextEdit.EditValue.ToString().Replace('.', ','));

                return original + juros + multa + acrescimo - desconto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
                       
        }

        protected override void CarregaForm()
        {
            //verifica se lancamento veio por meio de um movimento
            if (IsNovo)
            {
                //dados gerais
                pedidoLinkLabel.Visible = false;
                idLancamentoLabelControl.Text = "0";

                idCliForTextEdit.Text = null;
                cliForLinkLabel.Text = "Selecione um cliente / fornecedor";
                
                idFilialTextEdit.Text = Session.Contexto.Filial.IdFilial.ToString();
                filialLinkLabel.Text = Session.Contexto.Filial.NomeFantasia;
                
                tipoComboBox.SelectedIndex = 0;
                statusComboBox.SelectedItem = EnumStatusLanc.EmAberto;
                classeContabilComboBox.SelectedIndex = 0;
                isEntradaCheckEdit.Checked = false;

                //datas
                dataEmissaoDateEdit.EditValue = DateTime.Today;
                dataVencimentoDateEdit.EditValue = DateTime.Today;
                dataBaixaDateEdit.EditValue = null;
                dataAgendamentoDateEdit.EditValue = null;

                //valores
                valorOriginalTextEdit.Text = "0";
                valorJurosTextEdit.Text = "0";
                valorMultaTextEdit.Text = "0";
                valorDescontoTextEdit.Text = "0";
                valorAcrescimoTextEdit.Text = "0";
                valorBaixadoTextEdit.Text = null;
                valorLiquidoLabelControl.Text = string.Format("{0:c}", 0);

                //banco
                idContaCaixaTextEdit.Text = null;
                contaCaixaLinkLabel.Text = "Selecione uma conta caixa";
                nossoNumeroTextEdit.Text = null;
                ipteTextEdit.Text = null;
                codigoBarrasTextEdit.Text = null;

                //detalhes
                descricaoTextBox.Text = "";
                observacaoTextBox.Text = "";
            }
            else
            {
                if (Lancamento.Pedido != null)
                {
                    pedidoLinkLabel.Visible = true;
                }
                else
                {
                    pedidoLinkLabel.Visible = false;
                }

                //dados gerais
                idLancamentoLabelControl.Text = Lancamento.IdLancamento.ToString();
                idCliForTextEdit.Text = Lancamento.IdCliFor.ToString();
                cliForLinkLabel.Text = Lancamento.CliFor.Nome;
                idFilialTextEdit.Text = Lancamento.IdFilial.ToString();
                
                filialLinkLabel.Text = Lancamento.Filial.NomeFantasia;
                tipoComboBox.SelectedItem = Lancamento.Tipo;
                statusComboBox.SelectedItem = Lancamento.Status;
                classeContabilComboBox.SelectedItem= Lancamento.ClasseContabil;
                isEntradaCheckEdit.Checked = Lancamento.IsEntrada;

                //datas
                dataEmissaoDateEdit.EditValue = Lancamento.DataEmissao;
                dataVencimentoDateEdit.EditValue = Lancamento.DataVencimento;
                dataBaixaDateEdit.EditValue = Lancamento.DataBaixa;
                dataAgendamentoDateEdit.EditValue = Lancamento.DataAgendamento;

                //valores
                valorOriginalTextEdit.Text = Lancamento.ValorOriginal.ToString();
                valorJurosTextEdit.Text = Lancamento.ValorJuros.ToString();
                valorMultaTextEdit.Text = Lancamento.ValorMulta.ToString();
                valorDescontoTextEdit.Text = Lancamento.ValorDesconto.ToString();
                valorAcrescimoTextEdit.Text = Lancamento.ValorAcrescimo.ToString();
                valorBaixadoTextEdit.Text = Lancamento.ValorBaixado.ToString();
                valorLiquidoLabelControl.Text = string.Format("{0:c}", Lancamento.ValorLiquido);

                //banco
                idContaCaixaTextEdit.Text = Lancamento.IdContaCaixa.ToString();
                contaCaixaLinkLabel.Text = Lancamento.ContaCaixa.Nome;
                nossoNumeroTextEdit.Text = Lancamento.NossoNumero;
                ipteTextEdit.Text = Lancamento.Ipte;
                codigoBarrasTextEdit.Text = Lancamento.CodigoBarras;

                //detalhes
                descricaoTextBox.Text = Lancamento.Descricao;
                observacaoTextBox.Text = Lancamento.Observacoes;
            }

            
        }

        protected override void CarregaItem()
        {
            //dados gerais
            if (!string.IsNullOrEmpty(idCliForTextEdit.Text))
                Lancamento.IdCliFor = int.Parse(idCliForTextEdit.Text);
            if (!string.IsNullOrEmpty(idFilialTextEdit.Text))
                Lancamento.IdFilial = int.Parse(idFilialTextEdit.Text);
            Lancamento.Tipo = (EnumLancTipo)tipoComboBox.SelectedItem;
            Lancamento.Status = (EnumStatusLanc)statusComboBox.SelectedItem;
            Lancamento.ClasseContabil = (EnumClasseContabil)classeContabilComboBox.SelectedItem;
            Lancamento.IsEntrada = isEntradaCheckEdit.Checked;

            //datas
            Lancamento.DataEmissao = (DateTime)dataEmissaoDateEdit.EditValue;
            Lancamento.DataVencimento = (DateTime)dataVencimentoDateEdit.EditValue;
            if (!string.IsNullOrEmpty(dataBaixaDateEdit.Text))
                Lancamento.DataBaixa = (DateTime)dataBaixaDateEdit.EditValue;
            if (!string.IsNullOrEmpty(dataAgendamentoDateEdit.Text))
                Lancamento.DataAgendamento = (DateTime)dataAgendamentoDateEdit.EditValue;

            //valores
            Lancamento.ValorOriginal = decimal.Parse(valorOriginalTextEdit.EditValue.ToString().Replace('.', ','));
            Lancamento.ValorJuros = decimal.Parse(valorJurosTextEdit.EditValue.ToString().Replace('.', ','));
            Lancamento.ValorMulta = decimal.Parse(valorMultaTextEdit.EditValue.ToString().Replace('.', ','));
            Lancamento.ValorDesconto = decimal.Parse(valorDescontoTextEdit.EditValue.ToString().Replace('.', ','));
            Lancamento.ValorAcrescimo = decimal.Parse(valorAcrescimoTextEdit.EditValue.ToString().Replace('.', ','));
            if (!string.IsNullOrEmpty(valorBaixadoTextEdit.Text))
                Lancamento.ValorBaixado = decimal.Parse(valorBaixadoTextEdit.EditValue.ToString().Replace('.', ','));
            Lancamento.ValorLiquido = CalculaValorLiquido();

            //banco
            if (!string.IsNullOrEmpty(idContaCaixaTextEdit.Text))
                Lancamento.IdContaCaixa = int.Parse(idContaCaixaTextEdit.Text);
            Lancamento.NossoNumero = nossoNumeroTextEdit.Text;
            Lancamento.Ipte = ipteTextEdit.Text;
            Lancamento.CodigoBarras = codigoBarrasTextEdit.Text;

            //detalhes
            Lancamento.Descricao = descricaoTextBox.Text;
            Lancamento.Observacoes = observacaoTextBox.Text;
        }

        protected override void Incluir()
        {
            try
            {
                //inicializa o lancamento
                Lancamento = new Dados.Lancamento();

                //configura objeto
                CarregaItem();

                //envia para metodo de update
                Lancamento = objLib.Insert(Lancamento);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' incluido com sucesso", Lancamento.IdLancamento));

                //marca para edicao
                IsNovo = false;
                SetTitle();
                CarregaForm();
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBox.Show(ex.Message);
            }
        }

        protected override void Editar()
        {
            try
            {
                //configura objeto
                CarregaItem();

                //envia para metodo de update
                if (string.IsNullOrEmpty(Lancamento.NossoNumero))
                {
                    Lancamento = objLib.Update(Lancamento, true);
                }
                else 
                {
                    Lancamento = objLib.Update(Lancamento, false);
                }
                

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' alterado com sucesso", Lancamento.IdLancamento));

                //marca para edicao
                IsNovo = false;
                SetTitle();
                CarregaForm();
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregaVenda()
        {
            var frm = new Principal(Lancamento.IdPedido.GetValueOrDefault());
            frm.ShowDialog();
        }

        #endregion    
    }
}
