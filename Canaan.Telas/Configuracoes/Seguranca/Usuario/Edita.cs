using System;
using System.Windows.Forms;
using Canaan.Telas.Base;

namespace Canaan.Telas.Configuracoes.Seguranca.Usuario
{
    public partial class Edita : FormEdita
    {
        //
        //PROPRIEDADES
        public Lib.Usuario objLib { get; set; }
        private Dados.Usuario Usuario { get; set; }

        //
        //CONSTRUTORES
        public Edita()
        {
            //carrega as propriedades
            IsNovo = true;
            objLib = new Lib.Usuario();
            Usuario = new Dados.Usuario();


            //carrega os componentes
            InitializeComponent();
        }

        public Edita(int id)
        {
            //carrega as propriedades
            IsNovo = false;
            objLib = new Lib.Usuario();
            Usuario = objLib.GetById(id);

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
                Text = "Novo Usuário";
            else
                Text = "Editando Usuário: " + Usuario.Nome;
        }

        protected override void CarregaForm()
        {
            //carrega o data source
            usuarioBindingSource.DataSource = Usuario;

            //inicializa para inclusao
            if (IsNovo)
            {
                isAtivoCheckBox.Checked = true;
                usuarioBindingSource.EndEdit();
            }
        }

        protected override void Incluir()
        {
            try
            {
                //para a edicao do datasource
                usuarioBindingSource.EndEdit();

                //envia para metodo de update
                Usuario = objLib.Insert((Dados.Usuario)usuarioBindingSource.Current);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' incluido com sucesso", Usuario.Username));

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
                usuarioBindingSource.EndEdit();

                //envia para metodo de update
                Usuario = objLib.Update((Dados.Usuario)usuarioBindingSource.Current);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' alterado com sucesso", Usuario.Nome));

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
