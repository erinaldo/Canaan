using System;
using System.Drawing;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Properties;
using DevExpress.XtraEditors;
using Usuario = Canaan.Dados.Usuario;

namespace Canaan.Telas.Autenticacao
{
    public partial class Login : XtraForm
    {

        public Session Session 
        { 
            get
            {
                return Session.Instance;
            }
        }

        public bool ExitApp { get; set; }
        public Usuario Usuario { get; set; }

        public Login()
        {
            ExitApp = false;

            InitializeComponent();
        }

        public Login(string bg)
        {
            ExitApp = false;

            InitializeComponent();
            //BackgroundImage = (Bitmap)Resources.ResourceManager.GetObject(bg);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair da aplicação", "", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                ExitApp = true;
                Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        
        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            Autenticar();
        }

        private void Autenticar()
        {
            try
            {
                Usuario = new Lib.Usuario().GetByLogin(usernameTextBox.Text, senhaTextBox.Text);
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void senhaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                Autenticar();
            }
        }
    }
}
