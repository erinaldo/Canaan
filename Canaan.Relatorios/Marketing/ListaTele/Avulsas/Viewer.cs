using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Marketing.ListaTele.Avulsas
{
    public partial class Viewer : Base.Viewer
    {
        private readonly List<int> _listAtendimentos;

        public Model DataSet { get; set; }

        public Lib.Atendimento LibAtendimento
        {
            get { return new Lib.Atendimento(); }

        }

        public Viewer(List<int> listAtendimentos)
        {
            InitializeComponent();
            _listAtendimentos = listAtendimentos;
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            if (DataSet == null)
            {
                DataSet = new Model();
                GerarRelatorio();
            }
        }

        private void GerarRelatorio()
        {
            var listItens = _listAtendimentos.ToArray();

            using (var conn = new Dados.CanaanModelContainer())
            {
                var clientes = conn.Atendimento.Include("CliFor")
                                               .Include("CliFor.CliForReferencia")
                                               .Include("Sessao")
                                               .Where(a => listItens.Contains(a.CodigoReduzido))
                                               .ToList();

                CarregaDataSet(clientes.ToList().GroupBy(a => a.IdCliFor).Select(a => a.First()).ToList());
                CarregaRelatorio();
            }
        }

        private void CarregaRelatorio()
        {
            var report = new Etiquetas();

            //carrega dados
            report.SetDataSource(DataSet);

            //carrega o report viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Zoom(100);
        }

        private void CarregaDataSet(List<Dados.Atendimento> atendimentos)
        {
            foreach (var atendimento in atendimentos.OrderBy(a => a.CliFor.Cep))
            {
                var rowCli = DataSet.Cliente.NewClienteRow();

                rowCli.Codigo = atendimento.CodigoReduzido;
                rowCli.DataAtendimento = atendimento.Data;
                rowCli.Cliente = atendimento.CliFor.Nome;
                rowCli.Telefone = Lib.Utilitarios.Comum.FormataTelefone(atendimento.CliFor.Telefone);
                rowCli.Celular = Lib.Utilitarios.Comum.FormataTelefone(atendimento.CliFor.Celular);
                rowCli.Endereco = string.Format("{0} {1} {2}", atendimento.CliFor.Endereco, atendimento.CliFor.Numero, atendimento.CliFor.Bairro);
                rowCli.Cidade = string.Format("{0}-{1}", atendimento.CliFor.Cidade.Nome, atendimento.CliFor.Cidade.Estado.Abreviatura);
                rowCli.Cep = atendimento.CliFor.Cep;
                rowCli.Email = atendimento.CliFor.Email;
                rowCli.Atendimento = atendimento.CodigoReduzido.ToString();
                rowCli.Logo = Utilitarios.Comum.GetLogoReport();

                DataSet.Cliente.AddClienteRow(rowCli);
            }
        }
    }
}
