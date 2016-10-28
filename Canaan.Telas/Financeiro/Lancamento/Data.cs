using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Telas.Financeiro.Lancamento
{
    public partial class Data : Form
    {
        public DateTime? DataLancamento { get; set; }

        public Data()
        {
            InitializeComponent();
        }

        private void btnCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataLancamento = null;
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DataLancamento = lancamentoDateTimePicker.Value.Date;
            this.Close();
        }

        private void Data_Load(object sender, EventArgs e)
        {

        }
    }
}
