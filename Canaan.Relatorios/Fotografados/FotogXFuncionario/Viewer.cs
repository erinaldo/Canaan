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

namespace Canaan.Relatorios.Fotografados.FotogXFuncionario
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
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
        public Viewer(DateTime pInicio, DateTime pFim)
        {
            this.DataInicio = pInicio;
            this.DataFim = pFim;
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
                var sessoes = conn.Sessao.Where(a => a.Atendimento.IdFilial == Filial.IdFilial && a.Data >= DataInicio && a.Data <= DataFim && a.Tipo == Dados.EnumSessaoTipo.Normal).OrderBy(a => a.Data);

                foreach (var item in sessoes)
                {
                    //cria registro
                    var rw = DataModel.Sessao.NewSessaoRow();

                    //configura o registro
                    rw.IdSessao = item.IdSessao;
                    rw.CodigoReduzido = item.Atendimento.CodigoReduzido;
                    rw.DataSessao = item.Data.Date;
                    rw.TipoSessao = item.Tipo.ToString();
                    rw.Genero = item.Genero.ToString();
                    rw.NomeCliente = item.Atendimento.CliFor.Nome;
                    rw.NomeFotografa = string.Format("{0} {1}", item.Usuario.Nome, item.Usuario.Sobrenome);
                    rw.Telefone = item.Atendimento.CliFor.Telefone;
                    rw.Celular = item.Atendimento.CliFor.Celular;
                    rw.NumFotos = item.Foto.Count;
                    rw.Logo = Utilitarios.Comum.GetLogoReport();

                    //adiciona no model
                    DataModel.Sessao.AddSessaoRow(rw);
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
