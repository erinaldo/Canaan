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

namespace Canaan.Relatorios.Financeiro.Lancamento.Shared
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public string Titulo { get; set; }
        public string Filial { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Periodo { get; set; }
        public string Data1Titulo { get; set; }
        public string Data2Titulo { get; set; }
        public string Valor1Titulo { get; set; }
        public string Valor2Titulo { get; set; }
        public Model Dados { get; set; }

        #endregion

        #region CONSTRUTOR

        public Viewer(string pTitulo, string pFilial, DateTime pDataInicio, DateTime pDataFim, string pData1Titulo, string pData2Titulo, string pValor1Titulo, string pValor2Titulo, Model pDados)
        {
            //inicializa as propriedades
            this.Titulo = pTitulo;
            this.Filial = pFilial;
            this.DataInicio = pDataInicio;
            this.DataFim = pDataFim;
            this.Periodo = string.Format("Período: {0} à {1}", this.DataInicio.ToShortDateString(), this.DataFim.ToShortDateString());
            this.Data1Titulo = pData1Titulo;
            this.Data2Titulo = pData2Titulo;
            this.Valor1Titulo = pValor1Titulo;
            this.Valor2Titulo = pValor2Titulo;
            this.Dados = pDados;

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

        private void CarregaRelatorio() 
        {
            try
            {
                //configura o relatorio
                var report = new Relatorio();

                //configura os campos
                var txtTitle = (TextObject)report.Section2.ReportObjects["txtTitle"];
                var txtFilial = (TextObject)report.Section2.ReportObjects["txtFilial"];
                var txtPeriodo = (TextObject)report.Section2.ReportObjects["txtPeriodo"];
                var txtData1 = (TextObject)report.Section2.ReportObjects["txtData1"];
                var txtData2 = (TextObject)report.Section2.ReportObjects["txtData2"];
                var txtValor1 = (TextObject)report.Section2.ReportObjects["txtValor1"];
                var txtValor2 = (TextObject)report.Section2.ReportObjects["txtValor2"];

                txtTitle.Text = this.Titulo;
                txtFilial.Text = this.Filial;
                txtPeriodo.Text = this.Periodo;
                txtData1.Text = this.Data1Titulo;
                txtData2.Text = this.Data2Titulo;
                txtValor1.Text = this.Valor1Titulo;
                txtValor2.Text = this.Valor2Titulo;

                //carrega dados
                report.SetDataSource(this.Dados);

                //carrega o report viewer
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Zoom(100);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}
