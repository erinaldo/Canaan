using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Marketing.Parceria.Auditoria
{
    public partial class Filtro : Form
    {

        private ModelFiltro _model;

        public Filtro()
        {
            InitializeComponent();
            _model = new ModelFiltro();
        }
        private void Filtro_Load(object sender, EventArgs e)
        {

        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            _model = new ModelFiltro
            {
                Aberta = rbAbertura.Checked,
                Fechada = rbFechamento.Checked,
                DataFinal = dtFinal.Value,
                DataInicial = dtInicial.Value
            };


            var frm = new Viewer(_model);
            frm.ShowDialog();
        }

    }
}
