using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Marketing.Parceria.IndicacoesXPeriodo
{
    public partial class Filtro : Form
    {
        public Filtro()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var inicio = dtInicio.Value.Date;
            var fim = dtFinal.Value.Date;

            var frm = new Viewer(inicio, fim);
            frm.Show();

        }
    }
}
