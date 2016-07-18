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

namespace Canaan.Relatorios.Atendimento.AtendidosPeriodo
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public Lib.Session Session
        {
            get
            {
                return Lib.Session.Instance;
            }
        }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Model DataSetAtend { get; set; }

        #endregion

        #region CONSTRUTORES

        public Viewer(DateTime pInicio, DateTime pFim)
        {
            DataSetAtend = new Model();
            DataInicio = pInicio;
            DataFim = pFim;

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Viewer_Load(object sender, EventArgs e)
        {
            CarregaDados();
            CarregaRelatorio();
        }

        #endregion

        #region METODOS

        private void CarregaDados()
        {
            //recupera dados do banco
            var atend = new Lib.Venda()
                               .GetAtendidosByPeriodo(DataInicio.Date, DataFim.Date.AddDays(1), Session.Contexto.IdFilial)
                               .Select(a => new
                               {
                                   IdAtendimento = a.IdAtendimento,
                                   CodPacote = a.Atendimento.CodigoReduzido,
                                   Cliente = a.CliFor.Nome,
                                   Data = a.Data.ToShortDateString(),
                                   Sessao = new Lib.Sessao().GetByCliente(a.IdCliFor).LastOrDefault().Data.ToShortDateString()  //a.Atendimento.Sessao.LastOrDefault().Data.ToShortDateString()
                               })
                               .Distinct()
                               .ToList();

            foreach (var item in atend)
            {
                var row = DataSetAtend.Atendidos.NewAtendidosRow();
                row.IdAtendimento = item.IdAtendimento;
                row.CodReduzido = item.CodPacote;
                row.Cliente = item.Cliente;
                row.Data = item.Data;
                row.Sessao = item.Sessao;
                row.Logo = Utilitarios.Comum.GetLogoReport();

                DataSetAtend.Atendidos.AddAtendidosRow(row);
            }
        }

        private void CarregaRelatorio()
        {
            try
            {
                //configura o relatorio
                Relatorio report = new Relatorio();
                TextObject txtPeriodo = (TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["txtPeriodo"];
                
                //carrega dados
                txtPeriodo.Text = string.Format("{0} - {1} a {2}", Session.Contexto.Filial.NomeFantasia, DataInicio.ToShortDateString(), DataFim.ToShortDateString());
                report.SetDataSource(DataSetAtend);

                //carrega o report viewer
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Zoom(100);
            }
            catch (Exception ex)
            {
                Lib.MessageBoxUtilities.MessageError(null, ex);
            }
        }

        #endregion

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
