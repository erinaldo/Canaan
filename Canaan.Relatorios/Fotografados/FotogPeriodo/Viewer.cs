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

namespace Canaan.Relatorios.Fotografados.FotogPeriodo
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
        public Model DataSetFotog { get; set; }

        #endregion

        #region CONSTRUTORES

        public Viewer(DateTime pInicio, DateTime pFim)
        {
            DataSetFotog = new Model();
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
            var fotog = new Lib.Sessao().GetByPeriodo(DataInicio, DataFim, Session.Contexto.IdFilial).Where(a => a.Tipo == Dados.EnumSessaoTipo.Normal);

            foreach (var item in fotog)
            {
                var row = DataSetFotog.Fotografado.NewFotografadoRow();
                row.IdSessao = item.IdSessao;
                row.IdPacote = item.Atendimento.CodigoReduzido;
                row.NumSessao = item.NumSessao;
                row.DataSessao = item.Data.ToShortDateString();
                row.NomeCliente = item.Atendimento.CliFor.Nome;
                row.Fotografa = string.Format("{0} {1}", item.Usuario.Nome, item.Usuario.Sobrenome);
                row.Tempo = (int)item.TempoSessao.TotalMinutes;
                row.NumImagens = item.Foto.Count;
                row.Logo = Utilitarios.Comum.GetLogoReport();

                DataSetFotog.Fotografado.AddFotografadoRow(row);
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
                report.SetDataSource(DataSetFotog);

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
