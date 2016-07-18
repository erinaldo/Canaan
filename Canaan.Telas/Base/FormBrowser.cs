using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Telas.Base
{
    public partial class FormBrowser : Form
    {
        public string URL { get; set; }

        public FormBrowser(string pUrl)
        {
            this.URL = pUrl;
            InitializeComponent();
        }

        private void FormBrowser_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(this.URL);
        }
    }
}
