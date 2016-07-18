using System;
using System.Windows.Forms;
using Canaan.Telas.Base;

namespace Canaan.Telas.Configuracoes.Geral.GrupoEmpresa
{
    public partial class Edita : FormEdita
    {
        //
        //PROPRIEDADES
        public Lib.GrupoEmpresa objLib { get; set; }
        private Dados.GrupoEmpresa GrupoEmpresa { get; set; }

        //
        //CONSTRUTORES
        public Edita()
        {
            //carrega as propriedades
            IsNovo = true;
            objLib = new Lib.GrupoEmpresa();
            GrupoEmpresa = new Dados.GrupoEmpresa();
            

            //carrega os componentes
            InitializeComponent();
        }

        public Edita(int id)
        {
            //carrega as propriedades
            IsNovo = false;
            objLib = new Lib.GrupoEmpresa();
            GrupoEmpresa = objLib.GetById(id);
            Title = "Editando Grupo de Empresa: " + GrupoEmpresa.Nome;

            //carrega os componentes
            InitializeComponent();
        }
        
        //
        //EVENTOS
        private void Edita_Load(object sender, EventArgs e)
        {
            SetTitle();
            CarregaForm();
        }

        //
        //METODOS
        protected override void SetTitle()
        {
            if (IsNovo)
                Text = "Novo Grupo de Empresa";
            else
                Text = "Editando Grupo de Empresa: " + GrupoEmpresa.Nome;
        }

        protected override void CarregaForm()
        {
            ctrlNome.Text = GrupoEmpresa.Nome;
            ctrlDescricao.Text = GrupoEmpresa.Descricao;
            ctrlFranquia.Checked = GrupoEmpresa.IsFranquia;
            ctrlAtivo.Checked = GrupoEmpresa.IsAtivo;
        }

        protected override void CarregaItem()
        {
            //configura objeto
            GrupoEmpresa.Nome = ctrlNome.Text;
            GrupoEmpresa.Descricao = ctrlDescricao.Text;
            GrupoEmpresa.IsFranquia = ctrlFranquia.Checked;
            GrupoEmpresa.IsAtivo = ctrlAtivo.Checked;
        }

        protected override void Incluir()
        {
            try
            {
                //configura objeto
                CarregaItem();

                //envia para metodo de update
                GrupoEmpresa = objLib.Insert(GrupoEmpresa);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' incluido com sucesso", GrupoEmpresa.Nome));

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
                GrupoEmpresa = objLib.Update(GrupoEmpresa);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' alterado com sucesso", GrupoEmpresa.Nome));

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
    }
}
