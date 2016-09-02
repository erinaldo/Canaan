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

namespace RM.Relatorios.Vendas.VendasAVista
{
    public partial class frmReport : Form
    {
        #region PROPRIEDADES

        public dsModel DataReport { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        #endregion

        #region CONSTRUTOR

        public frmReport(DateTime pInicio, DateTime pFim)
        {
            this.DataInicio = pInicio;
            this.DataFim = pFim;
            this.DataReport = new dsModel();

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void frmReport_Load(object sender, EventArgs e)
        {
            CarregaDados();
            CarregaReport();
        }

        #endregion

        #region METODOS

        private void CarregaDados() 
        {
            using (var conn = new Dados.CorporeEntities()) 
            {
                var coligadas = new int[] { 1, 2, 3, 4, 6 };

                //consulta
                var query = conn.TMOV
                                .Where(a => coligadas.Contains(a.CODCOLIGADA) &&
                                            a.CODTMV.Contains("2.2") &&
                                            a.CODTB1FLX == "2.005" &&
                                            a.STATUS != "C" &&
                                            a.DATAEMISSAO >= this.DataInicio.Date &&
                                            a.DATAEMISSAO <= this.DataFim.Date &&
                                            a.VALORLIQUIDO > 200 &&
                                            a.GFILIAL.NOMEFANTASIA != ("CANAAN - CPC") &&
                                            a.FLAN.Count == 1 &&
                                            a.FLAN.Where(b => b.STATUSLAN == 1 && b.DATAEMISSAO == b.DATABAIXA).Count() == 1
                                );

                foreach (var venda in query)
                {
                    var rw = DataReport.Venda.NewVendaRow();
                    rw.IdVenda = venda.IDMOV;
                    rw.Estudio = venda.GFILIAL.NOMEFANTASIA;
                    rw.Vendedora = venda.TVEN.NOME;
                    rw.CodCliente = venda.CODCFO;
                    rw.Cliente = venda.FCFO.NOMEFANTASIA;
                    rw.Data = venda.DATAEMISSAO.GetValueOrDefault();
                    rw.Valor = venda.VALORLIQUIDO.GetValueOrDefault();


                    DataReport.Venda.AddVendaRow(rw);
                }
            }
        }


        private void CarregaReport() 
        {
            //configura o relatorio
            relReport report = new relReport();

            //carrega dados
            ((TextObject)report.Section2.ReportObjects["txtPeriodo"]).Text = string.Format("Período: {0} a {1}", DataInicio.ToShortDateString(), DataFim.ToShortDateString());
            report.SetDataSource(DataReport);

            //carrega o report viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Zoom(100);
        }
        #endregion
    }
}
