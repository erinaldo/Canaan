using System;
using System.Windows.Forms;
using Canaan.Relatorios.Marketing.Parceria.ParceriaXResultado;

namespace Canaan.Relatorios.Marketing.Parceria.ParceriaOnlineXPeriodo
{
    public partial class Filtro : Form
    {
        public Filtro()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var frm = new Viewer(inicioDateTimePicker.Value.Date, fimDateTimePicker.Value.Date);
            frm.Show();
        }
    }
}
