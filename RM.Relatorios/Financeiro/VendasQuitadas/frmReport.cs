using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using CrystalDecisions.CrystalReports.Engine;

namespace RM.Relatorios.Financeiro.VendasQuitadas
{
    public partial class frmReport : Form
    {
        //PROPRIEDADES
        public Dados.GFILIAL Filial { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        //CONSTRUTORES
        public frmReport(Dados.GFILIAL p_Filial, DateTime p_DataInicio, DateTime p_DataFim)
        {
            Filial = p_Filial;
            DataInicio = p_DataInicio;
            DataFim = p_DataFim;

            InitializeComponent();
        }

        //EVENTOS
        private void frmReport_Load(object sender, EventArgs e)
        {
            CarregaReport();
        }

        //METODOS
        private dsReport CarregaDados() 
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities()) 
            {
                var ds = new dsReport();
                var lanc = conn.TMOV
                               .Where(a => a.CODCOLIGADA == Filial.CODCOLIGADA &&
                                           a.CODFILIAL == Filial.CODFILIAL &&
                                           a.CODTMV.Contains("2.2") &&
                                           a.STATUS == "Q" &&
                                           a.FLAN.Where(b => b.PAGREC == 1).Count() > 0 &&
                                           a.DATAEMISSAO >= DataInicio &&
                                           a.DATAEMISSAO <= DataFim);

                foreach (var item in lanc)
                {
                    var row = ds.Lancamentos.NewLancamentosRow();
                    row.Codigo = item.FCFO.CODCFO;
                    row.Cliente = item.FCFO.NOMEFANTASIA;
                    row.Telefone = item.FCFO.TELEFONE;
                    row.Celular = item.FCFO.TELEX;
                    row.DataVenda = item.DATAEMISSAO.GetValueOrDefault();
                    row.ValorVenda = item.VALORLIQUIDO.GetValueOrDefault();

                    ds.Lancamentos.AddLancamentosRow(row);
                }

                return ds;
            }
        }

        private void CarregaReport()
        {
            //configura o relatorio
            relReport report = new relReport();

            //carrega dados
            ((TextObject)report.Section1.ReportObjects["txtPeriodo"]).Text = string.Format("Período: {0} a {1}", DataInicio.ToShortDateString(), DataFim.ToShortDateString());
            report.SetDataSource(CarregaDados());

            //carrega o report viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Zoom(100);
        }
    }
}
