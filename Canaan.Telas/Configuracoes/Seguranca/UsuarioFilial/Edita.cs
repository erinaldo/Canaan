using System;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Base;

namespace Canaan.Telas.Configuracoes.Seguranca.UsuarioFilial
{
    public partial class Edita : FormEdita
    {
        //
        //PROPRIEDADES
        public Lib.UsuarioFilial objLib { get; set; }
        public Dados.UsuarioFilial UsuarioFilial { get; set; }
        public Dados.Usuario Usuario { get; set; }


        //
        //CONSTRUTORES
        public Edita(int idusuario)
        {
            //carrega as propriedades
            IsNovo = true;
            objLib = new Lib.UsuarioFilial();
            Usuario = new Lib.Usuario().GetById(idusuario);
            UsuarioFilial = new Dados.UsuarioFilial();

            //carrega os componentes
            InitializeComponent();
        }

        public Edita(int idusuario, int idusuariofilial)
        {
            //carrega as propriedades
            IsNovo = false;
            objLib = new Lib.UsuarioFilial();
            Usuario = new Lib.Usuario().GetById(idusuario);
            UsuarioFilial = objLib.GetById(idusuariofilial);
            

            //carrega os componentes
            InitializeComponent();
        }

        //
        //EVENTOS
        private void Edita_Load(object sender, EventArgs e)
        {
            InitForm();
            CarregaUsuarioInfo();
            CarregaFiliais();
            CarregaGrupos();
            CarregaForm();
        }


        //
        //METODOS
        private void InitForm()
        {
            if (IsNovo)
            {
                Text = "Nova Permissão de '" + Usuario.Nome + "'";
                idFilialComboBox.Enabled = true;
            }
            else
            {
                Text = "Editando Permissão: " + string.Format("{0} - {1}", UsuarioFilial.Usuario.Nome, UsuarioFilial.Filial.NomeFantasia);
                idFilialComboBox.Enabled = false;
            }
        }

        protected override void CarregaForm()
        {
            //inicializa usuario
            UsuarioFilial.IdUsuario = Usuario.IdUsuario;

            //carrega o datasource
            usuarioFilialBindingSource.DataSource = UsuarioFilial;
        }

        protected override void Incluir()
        {
            try
            {
                //para a edicao do datasource
                usuarioFilialBindingSource.EndEdit();

                //envia para metodo de update
                UsuarioFilial = objLib.Insert((Dados.UsuarioFilial)usuarioFilialBindingSource.Current);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0} - {1}' incluido com sucesso", UsuarioFilial.Usuario.Nome, UsuarioFilial.Filial.NomeFantasia));

                //marca para edicao
                IsNovo = false;
                InitForm();

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
                usuarioFilialBindingSource.EndEdit();

                //envia para metodo de update
                UsuarioFilial = objLib.Update((Dados.UsuarioFilial)usuarioFilialBindingSource.Current);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0} - {1}' alterado com sucesso", UsuarioFilial.Usuario.Nome, UsuarioFilial.Filial.NomeFantasia));

                //marca para edicao
                IsNovo = false;
                InitForm();

                //recarrega o datasource
                CarregaForm();
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregaUsuarioInfo()
        {
            //inicializa nome do usuario
            usuarioNomeLabel.Text = string.Format("{0} {1}", Usuario.Nome, Usuario.Sobrenome);
        }

        private void CarregaGrupos()
        {
            usuarioGrupoBindingSource.DataSource = new Lib.UsuarioGrupo().Get();
        }

        private void CarregaFiliais()
        {
            filialBindingSource.DataSource = new Filial().Get();
        }
    }
}
