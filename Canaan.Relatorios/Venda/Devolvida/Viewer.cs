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

namespace Canaan.Relatorios.Venda.Devolvida
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public List<Model> Lista { get; set; }
        public Lib.Venda LibVenda { get; set; }
        public Dados.Filial Filial 
        {
            get 
            {
                return new Lib.Filial().GetById(Lib.Session.Instance.Contexto.IdFilial);
            }
        }
        public Lib.Session Session
        {
            get
            {
                return Lib.Session.Instance;
            }
        }

        #endregion

        #region CONSTRUTOR

        public Viewer(DateTime pDataInicio, DateTime pDataFim)
        {
            this.DataInicio = pDataInicio;
            this.DataFim = pDataFim;
            this.Lista = new List<Model>();
            this.LibVenda = new Lib.Venda();

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

        private void CarregaDados() 
        {
            var vendas = LibVenda.GetVendasDevolvidasPeriodo(this.Filial.IdFilial, this.DataInicio.Date, this.DataFim.Date);

            foreach (var item in vendas)
            {
                Lista.Add(new Model { 
                    CodigoReduzido = item.Atendimento.CodigoReduzido,
                    Cliente = item.CliFor.Nome,
                    DataVenda = item.DataVenda.GetValueOrDefault(),
                    DataDevolucao = item.DataDevolucao.GetValueOrDefault(),
                    Valor = item.ValorLiquido.GetValueOrDefault()
                });
            }
        }

        public void CarregaRelatorio() 
        {
            //carrega dados do relatorio
            CarregaDados();

            //carrega o relatorio
            var report = new Relatorio();
            var txtData = (TextObject)report.ReportDefinition.Sections["Section2"].ReportObjects["txtData"];

            txtData.Text = string.Format("{0} - {1} / {2}", Filial.NomeFantasia, DataInicio.ToShortDateString(), DataFim.ToShortDateString());

            //carrega dados
            report.SetDataSource(Lista);

            //carrega o report viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Zoom(100);
        }

        #endregion
    }
}
