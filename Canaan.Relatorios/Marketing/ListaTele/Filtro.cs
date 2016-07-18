using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Marketing.ListaTele
{
    public partial class Filtro : Base.FiltroBase
    {
        public Filtro()
        {
            InitializeComponent();
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            var cRadioButtonTeleFilter = gBox.Controls.OfType<Lib.Componentes.CRadioButtonTeleFilter>().FirstOrDefault(a => a.Checked);

            if (cRadioButtonTeleFilter != null)
            {
                var model = new ViewModel.Marketing.ListaTele.ListaTeleViewModel
                {
                    DataInicial = dtInicial.Value.Date,
                    DataFinal = dtFinal.Value.Date,
                    IdFilial = Session.Contexto.IdFilial,
                    TipoRelatorio = cRadioButtonTeleFilter.Tipo,
                    Etiquetas = ckEtiquetas.Checked,
                    Cartas = ckCartas.Checked
                };

                var frmrel = new Viewer(model);
                frmrel.Show();
            }
        }
    }
}
