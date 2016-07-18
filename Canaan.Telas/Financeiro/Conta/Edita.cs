using System;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Telas.Base;

namespace Canaan.Telas.Financeiro.Conta
{
    public partial class Edita : FormEdita
    {
        #region PROPRIEDADES

        public Lib.Conta objLib { get; set; }
        private Dados.Conta Conta { get; set; }

        #endregion

        #region CONSTRUTORES

        public Edita()
        {
            //carrega as propriedades
            IsNovo = true;
            objLib = new Lib.Conta();
            Conta = new Dados.Conta();

            //carrega os componentes
            InitializeComponent();
        }

        public Edita(int id)
        {
            //carrega as propriedades
            IsNovo = false;
            objLib = new Lib.Conta();
            Conta = objLib.GetById(id);

            //carrega os componentes
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Edita_Load(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[0];
            SetTitle();
            CarregaTipoConta();
            CarregaTipoCobranca();
            CarregaForm();
        }

        private void agenciaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new Agencia.Seleciona();
            frm.ShowDialog();

            if (frm.Agencia != null)
            {
                idAgenciaTextEdit.Text = frm.Agencia.IdAgencia.ToString();
                agenciaLinkLabel.Text = frm.Agencia.Nome;
            }
        }

        #endregion

        #region METODOS

        protected override void SetTitle()
        {
            if (IsNovo)
                Text = "Nova Conta Bancária";
            else
                Text = "Editando Conta Bancária: " + Conta.Nome;
        }

        private void CarregaTipoConta() 
        {
            tipoContaComboBox.DataSource = Enum.GetValues(typeof(EnumContaTipo));
        }

        private void CarregaTipoCobranca()
        { 
            tipoCobrancaComboBox.DataSource = Enum.GetValues(typeof(EnumCobrancaTipo));
        }

        protected override void CarregaForm()
        {
            if (IsNovo)
            {
                idAgenciaTextEdit.Text = "";
                agenciaLinkLabel.Text = "Selecione uma agência";
                isAtivoCheckEdit.Checked = true;
                tipoContaComboBox.SelectedIndex = 0;
                tipoCobrancaComboBox.SelectedIndex = 0;
                isAtivoCheckEdit.Checked = true;
            }
            else
            {
                idAgenciaTextEdit.Text = Conta.IdAgencia.ToString();
                agenciaLinkLabel.Text = Conta.Agencia.Nome;
                isAtivoCheckEdit.Checked = Conta.IsAtivo;
                tipoContaComboBox.SelectedItem = Conta.TipoConta;
                tipoCobrancaComboBox.SelectedItem = Conta.TipoCobranca;
                isAtivoCheckEdit.Checked = Conta.IsAtivo;
            }

            nomeTextEdit.Text = Conta.Nome;
            contaNumeriTextEdit.Text = Conta.ContaNumero;
            contaDigitoTextEdit.Text = Conta.ContaDigito;
            carteiraNumeriTextEdit.Text = Conta.CarteiraNumero;
            carteiraDigitoTextEdit.Text = Conta.CarteiraDigito;
            cedenteNomeTextEdit.Text = Conta.CedenteNome;
            cedenteCnpjTextEdit.Text = Conta.CedenteCnjp;
            cedenteNumeroTextEdit.Text = Conta.CedenteNumero;
            cedenteDigitoTextEdit.Text = Conta.CedenteDigito;
            convenioNumeroTextEdit.Text = Conta.ConvenioNumero;
            convenioDigitoTextEdit.Text = Conta.ConvenioDigito;
        }

        protected override void CarregaItem()
        {
            //configura objeto
            if (!string.IsNullOrEmpty(idAgenciaTextEdit.Text))
                Conta.IdAgencia = int.Parse(idAgenciaTextEdit.Text);
            Conta.Nome = nomeTextEdit.Text;
            Conta.ContaNumero = contaNumeriTextEdit.Text;
            Conta.ContaDigito = contaDigitoTextEdit.Text;
            Conta.CarteiraNumero = carteiraNumeriTextEdit.Text;
            Conta.CarteiraDigito = carteiraDigitoTextEdit.Text;
            Conta.CedenteNome = cedenteNomeTextEdit.Text;
            Conta.CedenteCnjp = cedenteCnpjTextEdit.Text;
            Conta.CedenteNumero = cedenteNumeroTextEdit.Text;
            Conta.CedenteDigito = cedenteDigitoTextEdit.Text;
            Conta.ConvenioNumero = convenioNumeroTextEdit.Text;
            Conta.ConvenioDigito = convenioDigitoTextEdit.Text;
            Conta.TipoConta = (EnumContaTipo)tipoContaComboBox.SelectedValue;
            Conta.TipoCobranca = (EnumCobrancaTipo)tipoCobrancaComboBox.SelectedValue;
            Conta.IsAtivo = isAtivoCheckEdit.Checked;
        }

        protected override void Incluir()
        {
            try
            {
                //configura objeto
                CarregaItem();

                //envia para metodo de update
                Conta = objLib.Insert(Conta);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' incluido com sucesso", Conta.Nome));

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
                Conta = objLib.Update(Conta);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' alterado com sucesso", Conta.Nome));

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
