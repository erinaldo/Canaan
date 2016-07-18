using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Venda.Programada
{
    public partial class Filtro : Form
    {
        public Filtro()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            CarregaRelatorio();
        }

        private void CarregaRelatorio() 
        {
            var dataInicio = dtInicio.Value.Date;
            var dataFim = dtFinal.Value.Date;
            EnumTipoData tipo;

            if (vendaRadioButton.Checked)
                tipo = EnumTipoData.Venda;
            else
                tipo = EnumTipoData.Entrada;

            var frm = new Viewer(dataInicio, dataFim, tipo);
            frm.Show();
        }
    }
}
