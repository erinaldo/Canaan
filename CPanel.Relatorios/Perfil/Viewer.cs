using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPanel.Relatorios.Perfil
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public List<CPanel.Lib.PerfilOperacional> Perfil { get; set; }
        
        #endregion

        #region CONSTRUTORES

        public Viewer(List<CPanel.Lib.PerfilOperacional> p_Perfil)
        {
            //inicializa as propriedades
            Perfil = p_Perfil;

            //inicializa a tela
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Viewer_Load(object sender, EventArgs e)
        {
            CarregaRelatorio();
        }

        #endregion

        #region METODOS

        public void CarregaRelatorio()
        {
            //configura o relatorio
            Relatorio report = new Relatorio();

            //carrega dados
            report.SetDataSource(Perfil);

            //carrega o report viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Zoom(100);
        }

        #endregion
    }
}
