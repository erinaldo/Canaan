using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPanel.Relatorios.Caderno.VendasXVendedora
{
    public partial class frmFiltro : Form
    {
        #region PROPRIEDADES

        public Dados.filiais Filial { get; set; }

        #endregion
        
        #region CONSTRUTORES

        public frmFiltro()
        {
            InitializeComponent();
        }

        public frmFiltro(Dados.filiais pFilial)
        {
            Filial = pFilial;
            InitializeComponent();
        }
        
        #endregion

        #region EVENTOS
        
        private void frmFiltro_Load(object sender, EventArgs e)
        {

        }
        
        #endregion

        #region METODOS

        #endregion
    }
}
