using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Telas.Consultas.Cliente
{
    public partial class Detalhe : Form
    {
        #region PROPRIEDADES

        public int CodColigada { get; set; }
        public string CodCliente { get; set; }
        public RM.Dados.FCFO Cliente { get; set; }
        
        #endregion

        #region CONSTRUTORES

        public Detalhe(int pCodColigada, string pCodCliente)
        {
            this.CodColigada = pCodColigada;
            this.CodCliente = pCodCliente;

            InitializeComponent();
        }

        #endregion

        
        #region EVENTOS

        private void Detalhe_Load(object sender, EventArgs e)
        {
            CarregaCliente();
            CarregaForm();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvaRegistro();
        }

        #endregion
        

        #region METODOS

        private void CarregaCliente() 
        {
            this.Cliente = RM.Lib.Cliente.Get(this.CodCliente, this.CodColigada);
        }

        private void CarregaForm() 
        {
            this.codigoLabel.Text = this.Cliente.CODCFO;
            this.nomeFantasiaTextBox.Text = this.Cliente.NOMEFANTASIA;
            this.razaoSocialTextBox.Text = this.Cliente.NOME;
            this.emailTextBox.Text = this.Cliente.EMAIL;
            this.documentoTextBox.Text = this.Cliente.CGCCFO;
            this.inscEstadualTextBox.Text = this.Cliente.INSCRESTADUAL;
            this.ruaTextBox.Text = this.Cliente.RUA;
            this.numeroTextBox.Text = this.Cliente.NUMERO;
            this.complementoTextBox.Text = this.Cliente.COMPLEMENTO;
            this.bairroRextBox.Text = this.Cliente.BAIRRO;
            this.cepTextBox.Text = this.Cliente.CEP;
            this.cidadeTextBox.Text = this.Cliente.CIDADE;
            this.telefone1TextBox.Text = this.Cliente.TELEFONE;
            this.telefone2TextBox.Text = this.Cliente.TELEX;
            this.telefone3TextBox.Text = this.Cliente.FAX;
            this.telefone4TextBox.Text = this.Cliente.TELEFONECOMERCIAL;
            this.observacoesTextBox.Text = this.Cliente.FCFOCOMPL.OBSERVACOES;
        }

        private void SalvaRegistro() 
        {
            try
            {
                this.Cliente.NOMEFANTASIA = this.nomeFantasiaTextBox.Text;
                this.Cliente.NOME = this.razaoSocialTextBox.Text;
                this.Cliente.EMAIL = this.emailTextBox.Text;
                this.Cliente.CGCCFO = this.documentoTextBox.Text;
                this.Cliente.INSCRESTADUAL = this.inscEstadualTextBox.Text;
                this.Cliente.RUA = this.ruaTextBox.Text;
                this.Cliente.NUMERO = this.numeroTextBox.Text;
                this.Cliente.COMPLEMENTO = this.complementoTextBox.Text;
                this.Cliente.BAIRRO = this.bairroRextBox.Text;
                this.Cliente.CEP = this.cepTextBox.Text;
                this.Cliente.CIDADE = this.cidadeTextBox.Text;
                this.Cliente.TELEFONE = this.telefone1TextBox.Text;
                this.Cliente.TELEX = this.telefone2TextBox.Text;
                this.Cliente.FAX = this.telefone3TextBox.Text;
                this.Cliente.TELEFONECOMERCIAL = this.telefone4TextBox.Text;
                this.Cliente.FCFOCOMPL.OBSERVACOES = this.observacoesTextBox.Text;

                //atualiza no banco
                RM.Lib.Cliente.Update(this.Cliente);

                //mensagem
                MessageBox.Show("Cliente atualizado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados \n\n" + ex.Message);
            }
            
        }

        #endregion
    }
}
