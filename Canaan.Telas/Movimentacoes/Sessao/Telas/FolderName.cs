using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Telas.Movimentacoes.Sessao.Telas
{
    public partial class FolderName : Form
    {
        //propriedades
        public string Caminho { get; set; }
        public string Folder { get; set; }

        //construtores
        public FolderName(string pCaminho, string pFolder)
        {
            this.Folder = pFolder;
            this.Caminho = pCaminho;

            InitializeComponent();
        }

        public FolderName()
        {
            this.Folder = "";

            InitializeComponent();
        }


        //eventos
        private void FolderName_Load(object sender, EventArgs e)
        {
            SetForm();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            UpdateName();

            //verifica se a pasta existe
            var pasta = string.Format("{0}/{1}", this.Caminho, this.Folder);
            if (!System.IO.Directory.Exists(pasta))
            {
                System.IO.Directory.CreateDirectory(pasta);
                this.Close();
            }
            else
            {
                MessageBox.Show("Já existe uma pasta com esse nome. Por favor informe outro nome para a pasta.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Folder = string.Empty;

            this.Close();
        }

        //metodos
        private void SetForm()
        {
            folderNameTextBox.Text = this.Folder;
        }

        private void UpdateName()
        {
            this.Folder = folderNameTextBox.Text;
        }
    }
}
