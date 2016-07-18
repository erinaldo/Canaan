using System;
using System.Windows.Forms;
using Canaan.Telas.Base;

namespace Canaan.Telas.Financeiro.ContaCaixa
{
    public partial class Edita : FormEdita
    {
        #region PROPRIEDADES

        public Lib.ContaCaixa objLib { get; set; }
        private Dados.ContaCaixa ContaCaixa { get; set; }

        #endregion

        #region CONSTRUTORES

        public Edita()
        {
            //carrega as propriedades
            IsNovo = true;
            objLib = new Lib.ContaCaixa();
            ContaCaixa = new Dados.ContaCaixa();

            //carrega os componentes
            InitializeComponent();
        }

        public Edita(int id)
        {
            //carrega as propriedades
            IsNovo = false;
            objLib = new Lib.ContaCaixa();
            ContaCaixa = objLib.GetById(id);

            //carrega os componentes
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Edita_Load(object sender, EventArgs e)
        {
            SetTitle();
            CarregaForm();
        }

        private void filialLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new Configuracoes.Geral.Filiais.Seleciona();
            frm.ShowDialog();

            if (frm.objItem != null)
            {
                idFilialTextEdit.Text = frm.objItem.IdFilial.ToString();
                filialLinkLabel.Text = frm.objItem.NomeFantasia;
            }
        }

        private void contaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new Conta.Seleciona();
            frm.ShowDialog();

            if (frm.objItem != null)
            {
                idContaTextEdit.Text = frm.objItem.IdConta.ToString();
                contaLinkLabel.Text = frm.objItem.Nome;
            }
        }

        #endregion

        #region METODOS

        protected override void SetTitle()
        {
            if (IsNovo)
                Text = "Nova Conta Caixa";
            else
                Text = "Editando Conta Caixa: " + ContaCaixa.Nome;
        }

        protected override void CarregaForm()
        {
            if (IsNovo)
            {
                idFilialTextEdit.Text = "";
                filialLinkLabel.Text = "Selecione uma filial";
                idContaTextEdit.Text = "";
                contaLinkLabel.Text = "Selecione uma conta bancária";
                nomeTextEdit.Text = "";
                isCaixaCheckEdit.Checked = false;
                isPadraoCheckEdit.Checked = false;
                isAtivoCheckEdit.Checked = true;
            }
            else
            {
                idFilialTextEdit.Text = ContaCaixa.IdFilial.ToString();
                filialLinkLabel.Text = ContaCaixa.Filial.NomeFantasia;
                idContaTextEdit.Text = ContaCaixa.IdConta.ToString();
                contaLinkLabel.Text = ContaCaixa.Conta.Nome;
                nomeTextEdit.Text = ContaCaixa.Nome;
                isCaixaCheckEdit.Checked = ContaCaixa.IsCaixa;
                isPadraoCheckEdit.Checked = ContaCaixa.IsPadrao;
                isAtivoCheckEdit.Checked = ContaCaixa.IsAtivo;
            }
        }

        protected override void CarregaItem()
        {
            //configura objeto
            if (!string.IsNullOrEmpty(idFilialTextEdit.Text))
                ContaCaixa.IdFilial = int.Parse(idFilialTextEdit.Text);
            if (!string.IsNullOrEmpty(idContaTextEdit.Text))
                ContaCaixa.IdConta = int.Parse(idContaTextEdit.Text);
            ContaCaixa.Nome = nomeTextEdit.Text;
            ContaCaixa.IsCaixa = isCaixaCheckEdit.Checked;
            ContaCaixa.IsPadrao = isPadraoCheckEdit.Checked;
            ContaCaixa.IsAtivo = isAtivoCheckEdit.Checked;
        }

        protected override void Incluir()
        {
            try
            {
                //configura objeto
                CarregaItem();

                //envia para metodo de update
                ContaCaixa = objLib.Insert(ContaCaixa);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' incluido com sucesso", ContaCaixa.Nome));

                //marca para edicao
                IsNovo = false;
                SetTitle();
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
                ContaCaixa = objLib.Update(ContaCaixa);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' alterado com sucesso", ContaCaixa.Nome));

                //marca para edicao
                IsNovo = false;
                SetTitle();
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
