using System;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Telas.Base;
using CliFor = Canaan.Dados.CliFor;
using CliForReferencia = Canaan.Lib.CliForReferencia;

namespace Canaan.Telas.Cadastros.ClienteFornecedor
{
    public partial class Referencia : FormEdita
    {
        //
        //PROPRIEDADES
        public bool IsSaved { get; set; }
        public CliForReferencia objLib { get; set; }
        public Dados.CliForReferencia CliForRef { get; set; }
        public CliFor CliFor { get; set; }

        //
        //CONTRUTORES
        public Referencia(CliFor pCliFor)
        {
            //inicializa as propriedades
            IsSaved = false;
            IsNovo = true;
            objLib = new CliForReferencia();
            CliFor = pCliFor;
            CliForRef = new Dados.CliForReferencia();
            
            //inicializa os componentes
            InitializeComponent();
        }

        public Referencia(CliFor pCliFor, Dados.CliForReferencia pCliForRef)
        {
            //inicializa as propriedades
            IsSaved = false;
            IsNovo = false;

            objLib = new CliForReferencia();
            CliFor = pCliFor;
            CliForRef = pCliForRef;           

            //inicializa os componentes
            InitializeComponent();
        }

        //
        //EVENTOS
        private void Referencia_Load(object sender, EventArgs e)
        {
            SetTitle();
            CarregaComboTipo();
            CarregaForm();
        }


        //
        //METODOS
        protected override void SetTitle()
        {
            if (IsNovo)
                Text = "Nova Referência";
            else
                Text = "Editando Referência: " + CliForRef.Nome;
        }

        protected override void CarregaForm()
        {
            //inicializa para inclusao
            if (IsNovo)
            {
                tipoComboBox.SelectedIndex = 0;
                nomeTextEdit.Text = "";
                enderecoTextEdit.Text = "";
                telefoneTextEdit.Text = "";
                celularTextEdit.Text = "";
            }
            else
            {
                tipoComboBox.SelectedItem = CliForRef.Tipo;
                nomeTextEdit.Text = CliForRef.Nome;
                enderecoTextEdit.Text = CliForRef.Endereco;
                telefoneTextEdit.Text = CliForRef.Telefone;
                celularTextEdit.Text = CliForRef.Celular;
            }
        }

        private void CarregaComboTipo()
        {
            tipoComboBox.DataSource = Enum.GetValues(typeof(EnumCliForTipoRef));
        }

        protected override void Incluir()
        {
            //atualiza objeto com os dados do formulario
            SetReferencia();

            //marca como salvo
            IsSaved = true;

            //fecha a tela
            Close();
        }

        protected override void Editar()
        {
            try
            {
                //atualiza objeto com os dados do formulario
                SetReferencia();

                //marca como salvo
                IsSaved = true;

                //fecha a tela
                Close();
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBox.Show(ex.Message);
            }
        }

        private void SetReferencia()
        {
            //seta valores ao item
            CliForRef.IdCliFor = CliFor.IdCliFor;
            CliForRef.Tipo = (EnumCliForTipoRef)tipoComboBox.SelectedValue;
            CliForRef.Nome = nomeTextEdit.Text;
            CliForRef.Endereco = enderecoTextEdit.Text;
            CliForRef.Telefone = telefoneTextEdit.Text;
            CliForRef.Celular = celularTextEdit.Text;
        }
    }
}