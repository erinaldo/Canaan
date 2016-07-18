using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Marketing.Parceria.Auditoria
{
    public partial class Viewer : Base.Viewer
    {
        private readonly ModelFiltro _filtro;
        public IEnumerable<ModelParceria> DataModel { get; set; }


        public Viewer(ModelFiltro filtro)
        {
            _filtro = filtro;
            InitializeComponent();
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            CarregaDados();
            CarregaRelatorio();
        }

        private void CarregaDados()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                DataModel = GetParcerias(conn);
            }
        }

        private void CarregaRelatorio()
        {
            try
            {
                //configura o relatorio
                var report = new Relatorio();
                var dataInicial = (TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["dtInicial"];
                var dataFinal = (TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["dtFinal"];

                dataInicial.Text = _filtro.DataInicial.ToShortDateString();
                dataFinal.Text = _filtro.DataFinal.ToShortDateString();

                //carrega dados                
                report.SetDataSource(DataModel);

                //carrega o report viewer
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Zoom(100);
            }
            catch (Exception ex)
            {
                Lib.MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private IEnumerable<ModelParceria> GetParcerias(Dados.CanaanModelContainer conn)
        {
            IEnumerable<Dados.Parceria> parcerias;

            if (_filtro.Aberta)
            {
                parcerias = conn.Parceria.Where(a => DbFunctions.AddDays(a.DataInicio, 30) <= _filtro.DataFinal &&
                                                     DbFunctions.AddDays(a.DataInicio, 30) >= _filtro.DataInicial &&
                                                     !a.IsRetirada &&
                                                     a.IdParceriaWeb == null).ToList().ToList();

                return ModelParceria.ToModel(parcerias);
            }

            parcerias = conn.Parceria.Where(a => a.DataRetirada >= _filtro.DataInicial && a.DataRetirada <= _filtro.DataFinal && a.IdParceriaWeb == null && a.IsRetirada).ToList();
            return ModelParceria.ToModel(parcerias);
        }

    }
}
