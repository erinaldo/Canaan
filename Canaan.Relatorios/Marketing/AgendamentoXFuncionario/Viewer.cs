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

namespace Canaan.Relatorios.Marketing.AgendamentoXFuncionario
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Dados.EnumAgendamentoStatus Status { get; set; }
        public bool IsStatus { get; set; }
        public Dados.Filial Filial
        {
            get
            {
                return Lib.Session.Instance.Contexto.Filial;
            }
        }
        public Model DataModel { get; set; }

        #endregion

        #region CONSTRUTORES

        public Viewer(DateTime pInicio, DateTime pFim, Dados.EnumAgendamentoStatus pStatus, bool pIsStatus)
        {
            this.DataInicio = pInicio;
            this.DataFim = pFim;
            this.Status = pStatus;
            this.IsStatus = pIsStatus;
            this.DataModel = new Model();

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

        public void CarregaDados()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var agendamentos = conn.Agendamento.Where(a => a.Cupom.Parceria.IdFilial == Filial.IdFilial && a.Inicio >= DataInicio && a.Inicio <= DataFim);

                if (this.IsStatus)
                    agendamentos = agendamentos.Where(a => a.Status == this.Status);

                foreach (var item in agendamentos.OrderBy(a => a.Inicio))
                {
                    //cria registro
                    var rw = DataModel.Agendamento.NewAgendamentoRow();

                    //configura o registro
                    rw.IdAgendamento = item.IdAgendamento;
                    rw.Estudio = Filial.NomeFantasia;

                    //var mov = item.AgendamentoMov.OrderBy(a => a.Data).LastOrDefault(a => a.Status == Dados.EnumAgendamentoStatus.Agendado);
                    //rw.Usuario = mov != null ? string.Format("{0} {1}", mov.Usuario.Nome, mov.Usuario.Sobrenome) : "Atendimento Direto";
                    rw.Usuario = item.Usuario != null ? string.Format("{0} {1}", item.Usuario.Nome, item.Usuario.Sobrenome) : "Atendimento Direto";
                    rw.Telefone = item.Cupom.Telefone;
                    rw.Celular = item.Cupom.Celular;
                    rw.Data = item.Inicio.Date;
                    rw.Horario = item.Inicio.ToShortTimeString();
                    rw.Nome = item.Cupom.Nome;
                    rw.Status = item.Status.ToString();
                    rw.Logo = Utilitarios.Comum.GetLogoReport();

                    //adiciona no model
                    DataModel.Agendamento.AddAgendamentoRow(rw);
                }
            }
        }

        public void CarregaRelatorio()
        {
            try
            {
                //configura o relatorio
                Relatorio report = new Relatorio();
                TextObject txtPeriodo = (TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["txtPeriodo"];

                //carrega dados
                txtPeriodo.Text = string.Format("{0} à {1}", DataInicio.ToShortDateString(), DataFim.ToShortDateString());
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

        #endregion
    }
}
