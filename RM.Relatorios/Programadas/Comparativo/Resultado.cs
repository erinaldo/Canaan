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

namespace RM.Relatorios.Programadas.Comparativo
{
    public partial class Resultado : Form
    {
        //propriedades
        List<Model> result { get; set; }
        DateTime dtInicio { get; set; }
        DateTime dtFim { get; set; }


        //construtores
        public Resultado(List<Model> p_result, DateTime p_dtInicio, DateTime p_dtFim)
        {
            result = p_result;
            dtInicio = p_dtInicio;
            dtFim = p_dtFim;

            InitializeComponent();
        }

        //metodos
        public void CarregaRelatorio()
        {
            //configura o relatorio
            Relatorio report = new Relatorio();

            //carrega dados
            ((TextObject)report.Section2.ReportObjects["txtPeriodo"]).Text = string.Format("Período: {0} a {1}", dtInicio.ToShortDateString(), dtFim.ToShortDateString());
            report.SetDataSource(result);

            //carrega o report viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Zoom(100);
        }

        //eventos
        private void Resultado_Load(object sender, EventArgs e)
        {
            CarregaRelatorio();
        }
    }
}
