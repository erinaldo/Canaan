using System;
using System.Windows.Forms;
using Canaan.Telas.Base;

namespace Canaan.Telas.Financeiro.Agencia
{
    public partial class Edita : FormEdita
    {
        #region PROPRIEDADES

        public Lib.Agencia objLib { get; set; }
        private Dados.Agencia Agencia { get; set; }

        #endregion

        #region CONSTRUTORES

        public Edita()
        {
            //carrega as propriedades
            IsNovo = true;
            objLib = new Lib.Agencia();
            Agencia = new Dados.Agencia();

            //carrega os componentes
            InitializeComponent();
        }

        public Edita(int id)
        {
            //carrega as propriedades
            IsNovo = false;
            objLib = new Lib.Agencia();
            Agencia = objLib.GetById(id);

            //carrega os componentes
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Edita_Load(object sender, EventArgs e)
        {
            SetTitle();
            CarregaBanco();
            CarregaForm();
        }

        private void cidadeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new Configuracoes.Geral.Cidade.Seleciona();
            frm.ShowDialog();

            if (frm.Cidade != null)
            {
                idCidadeTextEdit.Text = frm.Cidade.IdCidade.ToString();
                cidadeLinkLabel.Text = frm.Cidade.Nome;
            }
        }

        #endregion

        #region METODOS

        protected override void SetTitle()
        {
            if (IsNovo)
                Text = "Nova Agência";
            else
                Text = "Editando Agência: " + Agencia.Nome;
        }

        private void CarregaBanco() 
        {
            bancoComboBox.ValueMember = "IdBanco";
            bancoComboBox.DisplayMember = "Nome";
            bancoComboBox.DataSource = new Lib.Banco().Get();
        }

        protected override void CarregaForm()
        {
            if (IsNovo)
            {
                bancoComboBox.SelectedIndex = 0;
                idCidadeTextEdit.Text = "";
                cidadeLinkLabel.Text = "Selecione uma cidade";
                isAtivoCheckEdit.Checked = true;
            }
            else
            {
                bancoComboBox.SelectedValue = Agencia.IdBanco;
                idCidadeTextEdit.Text = Agencia.IdCidade.ToString();
                cidadeLinkLabel.Text = Agencia.Cidade.Nome;
                isAtivoCheckEdit.Checked = Agencia.IsAtivo;
            }
            
            nomeTextEdit.Text = Agencia.Nome;
            telefoneTextEdit.Text = Agencia.Telefone;
            celularTextEdit.Text = Agencia.Celular;
            gerenteTextEdit.Text = Agencia.Gerente;
            emailTextEdit.Text = Agencia.Email;
        }

        protected override void CarregaItem()
        {
            //configura objeto
            Agencia.IdBanco = int.Parse(bancoComboBox.SelectedValue.ToString());
            if (!string.IsNullOrEmpty(idCidadeTextEdit.Text))
                Agencia.IdCidade = int.Parse(idCidadeTextEdit.Text);
            Agencia.Nome = nomeTextEdit.Text;
            Agencia.Telefone = telefoneTextEdit.Text;
            Agencia.Celular = celularTextEdit.Text;
            Agencia.Gerente = gerenteTextEdit.Text;
            Agencia.Email = emailTextEdit.Text;
            Agencia.IsAtivo = isAtivoCheckEdit.Checked;
        }

        protected override void Incluir()
        {
            try
            {
                //configura objeto
                CarregaItem();

                //envia para metodo de update
                Agencia = objLib.Insert(Agencia);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' incluido com sucesso", Agencia.Nome));

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
                Agencia = objLib.Update(Agencia);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' alterado com sucesso", Agencia.Nome));

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
