using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Telas.Movimentacoes.Venda.Documentacao.Caderno
{
    public partial class SelecionaData : Form
    {
        public DateTime? DataSelecionada { get; set; }

        public SelecionaData()
        {
            DataSelecionada = null;

            InitializeComponent();
        }

        private void SelecionaData_Load(object sender, EventArgs e)
        {
            cadernoDateTimePicker.Value = DateTime.Today;
        }

        private void salvaButton_Click(object sender, EventArgs e)
        {
            DataSelecionada = cadernoDateTimePicker.Value;
            this.Close();
        }
    }
}
