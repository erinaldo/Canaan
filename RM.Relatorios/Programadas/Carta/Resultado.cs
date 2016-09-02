using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Relatorios.Programadas.Carta
{
    public partial class Resultado : Form
    {
        //propriedades
        List<Model> Result { get; set; }
        string TipoRelatorio { get; set; }

        //construtores
        public Resultado(List<Model> p_result, string p_tipo)
        {
            Result = p_result;
            TipoRelatorio = p_tipo;

            InitializeComponent();
        }

        //metodos
        public void CarregaCarta()
        {
            //configura o relatorio
            RelatorioCarta report = new RelatorioCarta();

            //carrega dados
            report.SetDataSource(Result);

            //carrega o report viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Zoom(100);
        }

        //metodos
        public void CarregaEtiquetas()
        {
            //configura o relatorio
            RelatorioEtiqueta2 report = new RelatorioEtiqueta2();

            //carrega dados
            report.SetDataSource(Result);

            //carrega o report viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Zoom(100);
        }


        //eventos
        private void Resultado_Load(object sender, EventArgs e)
        {
            switch (TipoRelatorio)
            {
                case "Carta":
                    CarregaCarta();
                    break;
                default:
                    CarregaEtiquetas();
                    break;
            }
        }
    }
}
