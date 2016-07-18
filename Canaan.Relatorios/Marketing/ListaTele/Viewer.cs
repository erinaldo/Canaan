using Canaan.Dados;
using Canaan.Relatorios.ViewModel.Marketing.ListaTele;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Canaan.Lib.Componentes;
using Canaan.Relatorios.Marketing.ListaTele.Cartas;

namespace Canaan.Relatorios.Marketing.ListaTele
{
    public partial class Viewer : Base.Viewer
    {
        public ListaTeleViewModel Model { get; set; }

        public Model DataSet { get; set; }

        public Lib.Venda LibVenda
        {
            get
            {
                return new Lib.Venda();
            }
        }

        public Viewer()
        {
            InitializeComponent();
        }

        public Viewer(ViewModel.Marketing.ListaTele.ListaTeleViewModel model)
            : this()
        {
            this.Model = model;
        }

        private void Viewer_Load(object sender, EventArgs e)
        {

            if (DataSet == null)
            {
                DataSet = new Model();

                switch (Model.TipoRelatorio)
                {
                    case Canaan.Lib.Componentes.TipoRelatorioTele.FichaPronta:
                        GenerateRelFicha();
                        break;
                    case Canaan.Lib.Componentes.TipoRelatorioTele.NaoViu:
                        GenerateRelNaoViu();
                        break;
                    case Canaan.Lib.Componentes.TipoRelatorioTele.NaoComprou:
                        GenerateRelNaoComprou();
                        break;
                    case Canaan.Lib.Componentes.TipoRelatorioTele.PegouBrinde:
                        GenerateRelPegouBrinde();
                        break;
                    case Canaan.Lib.Componentes.TipoRelatorioTele.AguardandoFinalizacao:
                        GenerateRelAguardando();
                        break;
                    case Canaan.Lib.Componentes.TipoRelatorioTele.Programadas:
                        GenerateRelProgramadas();
                        break;
                    case Canaan.Lib.Componentes.TipoRelatorioTele.Devolvidas:
                        GenerateRelDevolvidas();
                        break;
                    case Canaan.Lib.Componentes.TipoRelatorioTele.Vendidos:
                        GenerateRelVendidos();
                        break;
                    case Canaan.Lib.Componentes.TipoRelatorioTele.ListaOuro:
                        GenerateRelListaOuro();
                        break;
                    case Canaan.Lib.Componentes.TipoRelatorioTele.Aniversario:
                        GenerateRelAniversariantes();
                        break;
                    default:
                        GenerateRelFicha();
                        break;
                }
            }
        }

        private void GenerateRelAniversariantes()
        {
            var dtFinal = Model.DataFinal.AddHours(23);

            using (var conn = new Dados.CanaanModelContainer())
            {

                var clientes = conn.Atendimento.Include("CliFor")
                            .Include("CliFor.CliForReferencia")
                            .Include("Sessao")
                            .Where(a => ((a.CliFor as PessoaFisica).Nascimento.Day >= Model.DataInicial.Day &&
                                         (a.CliFor as PessoaFisica).Nascimento.Day <= dtFinal.Day) &&
                                        ((a.CliFor as PessoaFisica).Nascimento.Month >= Model.DataInicial.Month &&
                                         (a.CliFor as PessoaFisica).Nascimento.Month <= dtFinal.Month));

                //Atendimento do anterior
                var anoAnterior = DateTime.Today.AddYears(-1).Year;
                clientes = clientes.Where(a => a.Data.Year == anoAnterior);

                //Não Comprou // Não Viu //Não Pegou Brinde
                clientes = clientes.GroupBy(a => a.CliFor)
                                   .Select(a => a.FirstOrDefault())
                                   .Where(a => a.Sessao.Count > 0 && a.Venda.All(b => b.IsLiberado == false && b.IsConfirmado));


                CarregaDataSet(clientes.ToList().GroupBy(a => a.IdCliFor).Select(a => a.First()).ToList());
                CarregaRelatorio("Aniversariantes");
            }
        }

        private void GenerateRelListaOuro()
        {
            var dtFinal = Model.DataFinal.AddHours(23);

            using (var conn = new Dados.CanaanModelContainer())
            {
                //modificado puxando da venda
                //var clientes = conn.Atendimento.Include("CliFor")
                //                               .Include("CliFor.CliForReferencia")
                //                               .Include("Sessao")
                //                               .Where(a => a.Venda.Any(b => b.Data >= Model.DataInicial) &&
                //                                           a.Venda.Any(b => b.Data <= dtFinal) &&
                //                                           a.Sessao.Count > 0 &&
                //                                           a.Venda.Count > 0 &&
                //                                           a.Venda.Any(v => v.ValorLiquido > 0) &&
                //                                           a.Venda.Any(v => LibVenda.ClienteVendido.Contains(v.Status)) &&
                //                                           a.Venda.Any(v => v.IsLiberado == true)
                //                                      )
                //                               .ToList();

                var vendas = conn.Pedido
                              .Where(a =>
                                        (a as Dados.Venda).Data >= Model.DataInicial &&
                                        (a as Dados.Venda).Data <= dtFinal &&
                                        (a as Dados.Venda).Atendimento.Sessao.Count > 0 &&
                                        (a as Dados.Venda).ValorLiquido > 0 &&
                                        LibVenda.ClienteVendido.Contains((a as Dados.Venda).Status) &&
                                        (a as Dados.Venda).IsLiberado == true);

                var atendimentos = vendas.Select(a => (a as Dados.Venda).Atendimento)
                                         .Include(a => a.CliFor)
                                         .Include(a => a.CliFor.CliForReferencia)
                                         .Include(a => a.Sessao);

                CarregaDataSet(atendimentos.ToList().GroupBy(a => a.IdCliFor).Select(a => a.First()).ToList());
                CarregaRelatorio("Clientes Vendidos");
            }
        }

        private void GenerateRelVendidos()
        {
            var dtFinal = Model.DataFinal.AddHours(23);

            using (var conn = new Dados.CanaanModelContainer())
            {
                //modificado puxando da venda
                //var clientes = conn.Atendimento.Include("CliFor")
                //                               .Include("CliFor.CliForReferencia")
                //                               .Include("Sessao")
                //                               .Where(a => a.Data >= Model.DataInicial &&
                //                                           a.Data <= dtFinal &&
                //                                           a.Sessao.Count > 0 &&
                //                                           a.Venda.Count > 0 &&
                //                                           a.Venda.Any(v => v.ValorLiquido > 0) &&
                //                                           a.Venda.Any(v => LibVenda.ClienteVendido.Contains(v.Status)) &&
                //                                           a.Venda.Any(v => v.IsLiberado == true)
                //                                      )
                //                               .ToList();

                var vendas = conn.Pedido
                                 .Where(a =>
                                        (a as Dados.Venda).Atendimento.Data >= Model.DataInicial &&
                                        (a as Dados.Venda).Atendimento.Data <= dtFinal &&
                                        (a as Dados.Venda).Atendimento.Sessao.Count > 0 &&
                                        (a as Dados.Venda).ValorLiquido > 0 &&
                                        LibVenda.ClienteVendido.Contains((a as Dados.Venda).Status) &&
                                        (a as Dados.Venda).IsLiberado == true);

                var atendimentos = vendas.Select(a => (a as Dados.Venda).Atendimento)
                                         .Include(a => a.CliFor)
                                         .Include(a => a.CliFor.CliForReferencia)
                                         .Include(a => a.Sessao);

                CarregaDataSet(atendimentos.ToList().GroupBy(a => a.IdCliFor).Select(a => a.First()).ToList());
                CarregaRelatorio("Clientes Vendidos");
            }
        }

        private void GenerateRelDevolvidas()
        {
            var dtFinal = Model.DataFinal.AddHours(23);

            using (var conn = new Dados.CanaanModelContainer())
            {
                var clientes = conn.Atendimento
                                   .Where(a => a.Data >= Model.DataInicial &&
                                               a.Data <= dtFinal &&
                                               a.Sessao.Count > 0 &&
                                               a.Venda.Count > 0 &&
                                               a.Venda.Any(b => b.Status == EnumStatusVenda.Devolvido) &&
                                               a.Venda.Any(b => b.VendaMov.OrderByDescending(c => c.Data).FirstOrDefault().MotivoDevolucao.Any(d => d.Motivo.Descricao.Contains("SPC"))))
                                   .ToList();


                CarregaDataSet(clientes.ToList().GroupBy(a => a.IdCliFor).Select(a => a.First()).ToList());
                CarregaRelatorio("Vendas Devolvidas SPC");
            }
        }

        private void GenerateRelProgramadas()
        {
            var dtFinal = Model.DataFinal.AddHours(23);

            using (var conn = new Dados.CanaanModelContainer())
            {
                var clientes = conn.Atendimento.Include("CliFor")
                                               .Include("CliFor.CliForReferencia")
                                               .Include("Sessao")
                                               .Where(a => a.Data >= Model.DataInicial &&
                                                           a.Data <= dtFinal &&
                                                           a.Sessao.Count > 0 &&
                                                           a.Venda.Count > 0 &&
                                                           a.Venda.Any(v => v.Status == Dados.EnumStatusVenda.Programada)
                                                      )
                                               .ToList();


                CarregaDataSet(clientes.ToList().GroupBy(a => a.IdCliFor).Select(a => a.First()).ToList());
                CarregaRelatorio("Atendimento Não Finazado");
            }
        }

        private void GenerateRelAguardando()
        {
            var dtFinal = Model.DataFinal.AddHours(23);

            using (var conn = new Dados.CanaanModelContainer())
            {
                var clientes = conn.Atendimento.Include("CliFor")
                                               .Include("CliFor.CliForReferencia")
                                               .Include("Sessao")
                                               .Where(a => a.Data >= Model.DataInicial &&
                                                           a.Data <= dtFinal &&
                                                           a.Sessao.Count > 0 &&
                                                           a.Venda.Count > 0 &&
                                                           a.Venda.Any(v => v.Status == Dados.EnumStatusVenda.NaoFinalizado)
                                                      )
                                               .ToList();


                CarregaDataSet(clientes.ToList().GroupBy(a => a.IdCliFor).Select(a => a.First()).ToList());
                CarregaRelatorio("Atendimento Não Finazado");
            }
        }

        private void GenerateRelPegouBrinde()
        {
            var dtFinal = Model.DataFinal.AddHours(23);

            using (var conn = new Dados.CanaanModelContainer())
            {
                var clientes = conn.Atendimento.Include("CliFor")
                                               .Include("CliFor.CliForReferencia")
                                               .Include("Sessao")
                                               .Where(a => a.Data >= Model.DataInicial &&
                                                           a.Data <= dtFinal &&
                                                           a.Sessao.Count > 0 &&
                                                           a.Venda.Count > 0 &&
                                                           a.Venda.Any(v => v.OrdemServico.Count >= 0) &&
                                                           a.Venda.All(v => v.ValorLiquido == 0) &&
                                                           a.Venda.All(v => v.IsLiberado == true) &&
                                                           a.Venda.All(v => LibVenda.ClienteVendido.Contains(v.Status))
                                                      )
                                               .ToList();


                CarregaDataSet(clientes.ToList().GroupBy(a => a.IdCliFor).Select(a => a.First()).ToList());
                CarregaRelatorio("Cliente Pegou Brinde");
            }
        }

        private void GenerateRelNaoComprou()
        {
            var dtFinal = Model.DataFinal.AddHours(23);

            using (var conn = new Dados.CanaanModelContainer())
            {
                var clientes = conn.Atendimento.Include("CliFor")
                                               .Include("CliFor.CliForReferencia")
                                               .Include("Sessao")
                                               .Where(a => a.Data >= Model.DataInicial &&
                                                           a.Data <= dtFinal &&
                                                           a.Sessao.Count > 0 &&
                                                           a.Venda.Count > 0 &&
                                                           a.Venda.Any(b => b.OrdemServico.Count <= 0) &&
                                                           a.Venda.All(v => LibVenda.NaoFinalizou.Contains(v.Status)))
                                               .ToList();



                CarregaDataSet(clientes.ToList().GroupBy(a => a.IdCliFor).Select(a => a.First()).ToList());
                CarregaRelatorio("Cliente Não Comprou");
            }
        }

        private void GenerateRelNaoViu()
        {
            var dtFinal = Model.DataFinal.AddHours(23);

            using (var conn = new Dados.CanaanModelContainer())
            {
                var clientes = conn.Atendimento.Include("CliFor")
                                               .Include("CliFor.CliForReferencia")
                                               .Include("Sessao")
                                               .Where(a => a.Data >= Model.DataInicial &&
                                                           a.Data <= dtFinal &&
                                                           a.Sessao.Count > 0 &&
                                                           a.Venda.Count <= 0
                                                           ).ToList();



                CarregaDataSet(clientes.ToList().GroupBy(a => a.IdCliFor).Select(a => a.First()).ToList());
                CarregaRelatorio("Cliente Não Viu");
            }
        }

        private void GenerateRelFicha()
        {
            var dtFinal = Model.DataFinal.AddHours(23);

            using (var conn = new Dados.CanaanModelContainer())
            {
                var clientes = conn.Atendimento.Include("CliFor")
                                               .Include("CliFor.CliForReferencia")
                                               .Include("Sessao")
                                               .Where(a => a.Data >= Model.DataInicial &&
                                                           a.Data <= dtFinal &&
                                                           a.Sessao.Count <= 0
                                                           ).ToList();



                CarregaDataSet(clientes.ToList().GroupBy(a => a.IdCliFor).Select(a => a.First()).ToList());
                CarregaRelatorio("Cliente Ficha Pronta");
            }


        }

        private void CarregaRelatorio(string nomeReltorio)
        {
            try
            {
                if (!Model.Etiquetas && !Model.Cartas)
                {
                    //configura o relatorio
                    var report = new Relatorio();

                    var dtInicial = (TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["dtInicial"];
                    var dtFinal = (TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["dtFinal"];
                    var txtStatus = (TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["txtStatus"];

                    if (dtInicial != null)
                        dtInicial.Text = Model.DataInicial.ToShortDateString();

                    if (dtFinal != null)
                        dtFinal.Text = Model.DataFinal.ToShortDateString();

                    if (txtStatus != null)
                        txtStatus.Text = nomeReltorio;


                    //carrega dados
                    report.SetDataSource(DataSet);

                    //carrega o report viewer
                    crystalReportViewer1.ReportSource = report;
                    crystalReportViewer1.Zoom(100);

                }
                else if (Model.Cartas)
                {
                    switch (Model.TipoRelatorio)
                    {
                        case TipoRelatorioTele.Aniversario:
                            CarregaRelatorioCarta(new CartaAniversariante());
                            break;
                        case TipoRelatorioTele.Devolvidas:
                            CarregaRelatorioCarta(new CartaSPC());
                            break;
                        default:
                            Lib.MessageBoxUtilities.MessageWarning("Este tipo de relatorio não possui cartas");
                            break;
                    }
                }
                else
                {
                    var report = new Etiquetas();

                    //carrega dados
                    report.SetDataSource(DataSet);

                    //carrega o report viewer
                    crystalReportViewer1.ReportSource = report;
                    crystalReportViewer1.Zoom(100);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void CarregaRelatorioCarta(ReportDocument relatorio)
        {
            relatorio.SetDataSource(DataSet);
            crystalReportViewer1.ReportSource = relatorio;
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

                //foreach (var reff in atendimento.CliFor.CliForReferencia)
                //{
                //    var rowReferencia = DataSet.Referencia.NewReferenciaRow();

                //    rowReferencia.Codigo = reff.IdReferencia;
                //    rowReferencia.CodigoCliente = atendimento.CliFor.IdCliFor;
                //    rowReferencia.Local = reff.Tipo.ToString();
                //    rowReferencia.Contato = reff.Nome;
                //    rowReferencia.Telefone = reff.Telefone;

                //    DataSet.Referencia.AddReferenciaRow(rowReferencia);
                //}

                DataSet.Cliente.AddClienteRow(rowCli);
            }
        }
    }
}

