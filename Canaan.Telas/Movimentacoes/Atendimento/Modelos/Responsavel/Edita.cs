using System;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Base;
using Canaan.Telas.Movimentacoes.Atendimento.Modelos.Responsavel.Tipo;
using Modelo = Canaan.Dados.Modelo;
using ModeloResp = Canaan.Dados.ModeloResp;
using PessoaFisica = Canaan.Dados.PessoaFisica;

namespace Canaan.Telas.Movimentacoes.Atendimento.Modelos.Responsavel
{
    public partial class Edita : FormEdita
    {
        public ModeloResp Responsavel { get; set; }
        public Lib.ModeloResp LibResponsavel 
        {
            get
            {
                return new Lib.ModeloResp();
            }
        }

        public Modelo Modelo { get; set; }
        public Lib.Modelo LibModel 
        {
            get
            {
                return new Lib.Modelo();
            }
        }

        public Edita(Modelo modelo)
        {
            //carrega as propriedades
            IsNovo = true;
            Responsavel = new ModeloResp
            {
                IdModelo = modelo.IdModelo
            };
            Modelo = modelo;

            //carrega os componentes
            InitializeComponent();
        }

        public Edita(int id)
        {
            //carrega as propriedades
            IsNovo = false;

            Responsavel = LibResponsavel.GetById(id);
            Modelo = LibModel.GetById(Responsavel.IdModelo);


            //carrega os componentes
            InitializeComponent();
        }

        private void Edita_Load(object sender, EventArgs e)
        {
            SetTitle();
            CarregaForm();
        }

        protected override void SetTitle()
        {
            if (IsNovo)
                Text = "Novo Responsável";
            else
                Text = "Editando Responsável: " + Responsavel.Nome;
        }

        protected override void CarregaForm()
        {
            //carrega o data source
            modeloRespBindingSource.DataSource = Responsavel;

            CarregaTipos();

            SetModeloName();

            //inicializa para inclusao
            if (IsNovo)
            {
                if (MessageBox.Show("Deseja importar os dados do cliente?", "", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                {
                    nomeTextEdit.Text = Modelo.CliFor.Nome;
                    cpfTextEdit.Text = Modelo.CliFor.Documento;
                    rgTextEdit.Text = Modelo.CliFor as PessoaFisica != null ? ((PessoaFisica)Modelo.CliFor).Rg : "";
                    celularTextEdit.Text = Modelo.CliFor.Celular;
                    telefoneTextEdit.Text = Modelo.CliFor.Telefone;
                }
            }
        }

        private void SetModeloName()
        {
            lkModelo.Text = Modelo.NomeCompleto;
        }

        private void CarregaTipos()
        {

        }

        protected override void Incluir()
        {
            try
            {
                //para a edicao do datasource
                modeloRespBindingSource.EndEdit();

                //envia para metodo de update
                Responsavel = LibResponsavel.Insert((ModeloResp)modeloRespBindingSource.Current);

                //mensagem de retorno
                MessageBoxUtilities.MessageInfo(string.Format("Registro '{0}' incluido com sucesso", Responsavel.Nome));

                //marca para edicao
                IsNovo = false;
                SetTitle();

                //recarrega o datasource
                CarregaForm();
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBoxUtilities.MessageError(this, ex);
            }
        }

        protected override void Editar()
        {
            try
            {
                //para a edicao do datasource
                modeloRespBindingSource.EndEdit();

                //envia para metodo de update
                Responsavel = LibResponsavel.Update((ModeloResp)modeloRespBindingSource.Current);

                //mensagem de retorno
                MessageBoxUtilities.MessageInfo(string.Format("Registro '{0}' alterado com sucesso", Responsavel.Nome));

                //marca para edicao
                IsNovo = false;
                SetTitle();

                //recarrega o datasource
                CarregaForm();
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBoxUtilities.MessageError(this, ex);
            }
        }

        private void lkTipo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var seleciona = new Seleciona();
            seleciona.ShowDialog();

            if (seleciona.ResponsavelTipo != null)
            {
                //atualiza item bindado
                tipoTextBox.Text = seleciona.ResponsavelTipo.ToString();
                ;//tipoConvenioLabel.Text = seleciona.ResponsavelTipo.ToString();
            }
        }
    }
}
