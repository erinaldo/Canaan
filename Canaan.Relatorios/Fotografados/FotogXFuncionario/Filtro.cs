using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Fotografados.FotogXFuncionario
{
    public partial class Filtro : Form
    {
        public Filtro()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var frm = new Viewer(inicioDateTimePicker.Value.Date, fimDateTimePicker.Value.Date.AddHours(23));
            frm.Show();
        }
    }
}
