using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Venda.Liberacao
{
    public partial class Filtro : Form
    {
        #region PRORPIEDADES
        #endregion

        #region CONSTRUTORES

        public Filtro()
        {
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Filtro_Load(object sender, EventArgs e)
        {
            rbGerencial.Checked = true;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            GeraRelatorio();
        }

        #endregion

        #region METODOS

        public void GeraRelatorio() 
        {
            TipoRelatorio tipo;

            if (rbGerencial.Checked)
            {
                tipo = TipoRelatorio.Gerencial;
            }
            else 
            {
                if (rbEscritorio.Checked)
                {
                    tipo = TipoRelatorio.Escritorio;
                }
                else 
                { 
                    tipo = TipoRelatorio.Programada;
                }
            }
             
            var frm = new Viewer(tipo);
            frm.Show();
        }

        #endregion
    }
}
