using System;
using System.Windows.Forms;
using Canaan.Telas.Base;

namespace Canaan.Telas.Configuracoes.Seguranca.UsuarioGrupo
{
    public partial class Edita : FormEdita
    {
        //
        //PROPRIEDADES
        public Lib.UsuarioGrupo objLib { get; set; }
        private Dados.UsuarioGrupo UsuarioGrupo { get; set; }

        //
        //CONSTRUTORES
        public Edita()
        {
            //carrega as propriedades
            IsNovo = true;
            objLib = new Lib.UsuarioGrupo();
            UsuarioGrupo = new Dados.UsuarioGrupo();


            //carrega os componentes
            InitializeComponent();
        }

        public Edita(int id)
        {
            //carrega as propriedades
            IsNovo = false;
            objLib = new Lib.UsuarioGrupo();
            UsuarioGrupo = objLib.GetById(id);

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
                Text = "Novo Grupo de Usuário";
            else
                Text = "Editando Grupo de Usuário: " + UsuarioGrupo.Nome;
        }

        protected override void CarregaForm()
        {
            //carrega o data source
            usuarioGrupoBindingSource.DataSource = UsuarioGrupo;

            //inicializa para inclusao
            if (IsNovo)
            {
                isAtivoCheckBox.Checked = true;
                usuarioGrupoBindingSource.EndEdit();
            }
        }

        protected override void Incluir()
        {
            try
            {
                //para a edicao do datasource
                usuarioGrupoBindingSource.EndEdit();

                //envia para metodo de update
                UsuarioGrupo = objLib.Insert((Dados.UsuarioGrupo)usuarioGrupoBindingSource.Current);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' incluido com sucesso", UsuarioGrupo.Nome));

                //marca para edicao
                IsNovo = false;
                SetTitle();

                //recarrega o datasource
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
                //para a edicao do datasource
                usuarioGrupoBindingSource.EndEdit();

                //envia para metodo de update
                UsuarioGrupo = objLib.Update((Dados.UsuarioGrupo)usuarioGrupoBindingSource.Current);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' alterado com sucesso", UsuarioGrupo.Nome));

                //marca para edicao
                IsNovo = false;
                SetTitle();

                //recarrega o datasource
                CarregaForm();
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
