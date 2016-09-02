using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Relatorios.Cobranca.UltimaParcela
{
    public partial class frmReport : Form
    {
        #region PROPRIEDADES

        public dsReport DataReport { get; set; }
        public string TipoRelatorio { get; set; }

        #endregion

        #region CONSTRUTOR

        public frmReport(dsReport p_DataReport, string p_tipo)
        {
            TipoRelatorio = p_tipo;
            DataReport = p_DataReport;
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void frmReport_Load(object sender, EventArgs e)
        {
            switch (TipoRelatorio) 
            {
                case "Analitico":
                    PrintAnalitico();
                    break;
                case "Etiqueta":
                    PrintEtiqueta();
                    break;
                default:
                    PrintAnalitico();
                    break;
            }
        }

        #endregion

        #region METODOS

        private void PrintAnalitico() 
        {
            //configura o relatorio
            relAnalitico report = new relAnalitico();

            //carrega dados
            report.SetDataSource(DataReport);

            //carrega o report viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Zoom(100);
        }

        private void PrintEtiqueta()
        {
            //configura o relatorio
            relEtiqueta report = new relEtiqueta();

            //carrega dados
            var dados = DataReport.Lancamento.Select(a => new
            {
                IdLan = a.IdMov,
                Cliente = a.Cliente,
                EndRua = a.EndRua,
                EndBairro = a.EndBairro,
                EndNum = a.EndNum,
                EndCompl = a.EndCompl,
                EndCidade = a.EndCidade,
                EndEstado = a.EndEstado,
                EndCep = a.EndCep
            })
            .OrderBy(a => a.EndCep)
            .Distinct();

            report.SetDataSource(dados);

            //carrega o report viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Zoom(100);
        }

        #endregion
    }
}
