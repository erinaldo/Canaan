using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Relatorios.Financeiro.FluxoCaixa
{
    public partial class frmReport : Form
    {
        public DateTime dtInicio { get; set; }
        public DateTime dtFim { get; set; }
        public dsReport Data { get; set; }

        public frmReport(dsReport p_Data, DateTime p_dtInicio, DateTime p_dtFim)
        {
            dtInicio = p_dtInicio;
            dtFim = p_dtFim;
            Data = p_Data;
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            //configura o relatorio
            relReport report = new relReport();

            //carrega dados
            ((TextObject)report.Section1.ReportObjects["txtPeriodo"]).Text = string.Format("Período: {0} a {1}", dtInicio.ToShortDateString(), dtFim.ToShortDateString());
            report.SetDataSource(Data);

            //carrega o report viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Zoom(100);
        }
    }
}
