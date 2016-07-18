using System;
using System.Windows.Forms;

namespace Canaan.Telas.Configuracoes.Seguranca.Usuario
{
    public partial class ChangePassword : Form
    {
        //
        //PROPRIEDADES
        public Lib.Usuario objLib { get; set; }
        public Dados.Usuario Usuario { get; set; }

        //
        //CONSTRUTORES
        public ChangePassword(int id)
        {
            //inicializa propriedades
            objLib = new Lib.Usuario();
            Usuario = objLib.GetById(id);

            //inicializa componentes
            InitializeComponent();
        }


        //
        //EVENTOS
        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ExecutaUpdate();
        }

        //
        //METODOS
        private void ExecutaUpdate() 
        {
            try
            {
                Usuario = objLib.ChangePassword(Usuario, senhaTextBox.Text, repitaTextBox.Text);
                MessageBox.Show("Senha do usuário '" + Usuario.Nome + "' alterada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }       
    }
}
