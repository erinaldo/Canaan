using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Cliente.Listagem
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public Model DataSet { get; set; }

        #endregion

        #region CONSTRUTORES

        public Viewer()
        {
            this.DataSet = new Model();

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
            var clientes = new Lib.CliFor().Get().Where(a => a.Tipo == Dados.EnumCliForTipo.Cliente).OrderBy(a => a.Nome);

            foreach (var item in clientes)
            {
                var row = DataSet.Cliente.NewClienteRow();
                row.IdCliente = item.IdCliFor;
                row.Nome = item.Nome;
                row.Telefone = Lib.Utilitarios.Comum.FormataTelefone(item.Telefone);
                row.Celular = Lib.Utilitarios.Comum.FormataTelefone(item.Celular);
                row.Email = item.Email;
                row.Logo = Lib.Session.Instance.LogoReport;

                DataSet.Cliente.AddClienteRow(row);
            }
        }

        private void CarregaRelatorio()
        {
            try
            {
                //configura o relatorio
                Relatorio report = new Relatorio();
                report.SetDataSource(DataSet);

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
