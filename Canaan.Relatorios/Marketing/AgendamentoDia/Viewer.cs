using Canaan.Relatorios.ViewModel.Marketing.Agendamento;
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
using System.Data.Entity;

namespace Canaan.Relatorios.Marketing.AgendamentoDia
{
    public partial class Viewer : Base.Viewer
    {
        #region PROPRIEDADES

        private AgendamentoViewModel Model { get; set; }
        private Model Dataset { get; set; }

        public Lib.TelemarketingStatus LibTeleStatus
        {
            get
            {
                return new Lib.TelemarketingStatus();
            }
        }

        #endregion

        #region CONSTRUTOR

        public Viewer(AgendamentoViewModel model)
        {
            Model = model;

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Viewer_Load(object sender, EventArgs e)
        {
            if (Dataset == null)
            {
                Dataset = new Model();
                CarregaDataSet();
                CarregaRelatorio();
            }
        }

        #endregion

        #region METODOS

        private void CarregaRelatorio()
        {
            try
            {
                //configura o relatorio
                Relatorio report = new Relatorio();

                TextObject dtInicial = (TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["dtInicial"];
                TextObject dtFinal = (TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["dtFinal"];
                TextObject txtStatus = (TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["txtStatus"];

                if (dtInicial != null)
                    dtInicial.Text = Model.DataInicial.ToShortDateString();

                if (dtFinal != null)
                    dtFinal.Text = Model.DataFinal.ToShortDateString();

                if (txtStatus != null)
                    txtStatus.Text = Model.Status.ToString();

                //carrega dados
                report.SetDataSource(Dataset);

                //carrega o report viewer
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Zoom(100);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void CarregaDataSet()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                //Carrega Cupons
                var agendamentos = conn.Agendamento
                                       .Include(a => a.Cupom)
                                       .Where(a => a.Status == Model.Status &&
                                                   a.Inicio >= Model.DataInicial &&
                                                   a.Inicio <= Model.DataFinal &&
                                                   a.Agenda.IdFilial == Model.IdFilial)
                                        .OrderBy(a => a.Inicio)
                                        .ThenBy(a => a.Cupom.Nome)
                                        .ToList();

                foreach (var agendamento in agendamentos)
                {
                    
                    var rowAgendamento = Dataset.Agendamento.NewAgendamentoRow();

                    //Cupom
                    if (Dataset.Cupom.All(a => a.IdCupom != agendamento.IdCupom)) 
                    {
                        var rowCupom = Dataset.Cupom.NewCupomRow();

                        rowCupom.IdCupom = agendamento.IdCupom;
                        rowCupom.Parceria = agendamento.Cupom.Parceria.Nome;
                        rowCupom.Nome = agendamento.Cupom.Nome;
                        rowCupom.Email = agendamento.Cupom.Email;
                        rowCupom.Telefone = Lib.Utilitarios.Comum.FormataTelefone(agendamento.Cupom.Telefone);
                        rowCupom.Celular = Lib.Utilitarios.Comum.FormataTelefone(agendamento.Cupom.Celular);

                        Dataset.Cupom.AddCupomRow(rowCupom);
                    }
                  

                    //Agendamento
                    rowAgendamento.IdAgendamento = Guid.NewGuid();
                    rowAgendamento.IdCupom = agendamento.IdCupom;
                    rowAgendamento.StatusTele = agendamento.Cupom.TelemarketingStatus.Nome;
                    rowAgendamento.UsuarioTele = agendamento.Cupom.UsuarioTele != null ? agendamento.Cupom.UsuarioTele.Nome : "Direto";
                    rowAgendamento.DataTele = agendamento.Cupom.DataTele.GetValueOrDefault();
                    rowAgendamento.Inicio = agendamento.Inicio.ToShortDateString();
                    rowAgendamento.Hora = agendamento.Inicio.TimeOfDay;
                    rowAgendamento.Status = agendamento.Status.ToString();
                    rowAgendamento.Logo = Utilitarios.Comum.GetLogoReport();

                    Dataset.Agendamento.AddAgendamentoRow(rowAgendamento);
                    
                }
            }
        }

        #endregion
    }
}
