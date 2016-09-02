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

namespace RM.Relatorios.Entradas.ParcialGerente
{
    public partial class Resultado : Form
    {
        //propriedades
        List<Model> result { get; set; }
        string NomeEstudio { get; set; }
        string NomeGerente { get; set; }
        
        //construtores
        public Resultado(List<Model> p_result, string p_nomeEstudio, string p_nomeGerente)
        {
            result = p_result;
            NomeEstudio = p_nomeEstudio;
            NomeGerente = p_nomeGerente;

            InitializeComponent();
        }

        //metodos
        public void CarregaRelatorio()
        {
            //configura o relatorio
            Relatorio report = new Relatorio();

            //carrega dados
            ((TextObject)report.Section2.ReportObjects["txtEstudio"]).Text = NomeEstudio;
            ((TextObject)report.Section2.ReportObjects["txtGerente"]).Text = NomeGerente;
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
