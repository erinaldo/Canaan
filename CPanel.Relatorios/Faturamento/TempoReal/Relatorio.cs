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

namespace CPanel.Relatorios.Faturamento.TempoReal
{
    public partial class Relatorio : Form
    {
        public DateTime dtInicio { get; set; }
        public DateTime dtFim { get; set; }
        public FaturamentoDataSet Data { get; set; }

        public Relatorio(FaturamentoDataSet p_Data, DateTime p_dtInicio, DateTime p_dtFim)
        {
            dtInicio = p_dtInicio;
            dtFim = p_dtFim;
            Data = p_Data;
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            //configura o relatorio
            FaturamentoReport report = new FaturamentoReport();

            //carrega dados
            ((TextObject)report.Section1.ReportObjects["txtPeriodo"]).Text = string.Format("Período: {0} a {1}", dtInicio.ToShortDateString(), dtFim.ToShortDateString());
            report.SetDataSource(Data);

            //carrega o report viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Zoom(100);
        }
    }
}
