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

namespace Canaan.Relatorios.Marketing.CupomFunc
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public Model DataSetCupom { get; set; }
        public int IdUsuario { get; set; }

        #endregion


        #region CONSTRUTORES

        public Viewer(int pUsuario)
        {
            DataSetCupom = new Model();
            IdUsuario = pUsuario;

            InitializeComponent();
        }

        #endregion

        #region METODOS

        private void CarregaDados()
        {
            //recupera dados do banco
            var cupom = new Lib.Cupom().GetByUsuario(IdUsuario, Lib.Session.Instance.Contexto.IdFilial);

            foreach (var item in cupom)
            {
                var row = DataSetCupom.Cupom.NewCupomRow();
                row.IdCupom = item.IdCupom;
                row.Nome = item.Nome;
                row.Telefone = item.Telefone;
                row.Celular = item.Celular;
                row.Parceria = item.Parceria.Nome;
                row.Logo = Utilitarios.Comum.GetLogoReport();

                DataSetCupom.Cupom.AddCupomRow(row);
            }
        }

        private void CarregaRelatorio()
        {
            try
            {
                var usuario = new Lib.Usuario().GetById(IdUsuario);

                //configura o relatorio
                Relatorio report = new Relatorio();
                TextObject txtFunc = (TextObject)report.ReportDefinition.Sections["Section2"].ReportObjects["txtFunc"];

                //carrega dados
                txtFunc.Text = string.Format("{0} {1}", usuario.Nome, usuario.Sobrenome);
                report.SetDataSource(DataSetCupom);

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

        #region EVENTOS

        private void Viewer_Load(object sender, EventArgs e)
        {
            CarregaDados();
            CarregaRelatorio();
        }

        #endregion
    }
}
