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

namespace Canaan.Relatorios.Fichas.Boleto
{
    public partial class Viewer : Form
    {
        //propriedades
        public int CodVenda { get; set; }
        public Model DsModel { get; set; }

        //construtor
        public Viewer(int pCodVenda)
        {
            //inicializa as propriedades
            CodVenda = pCodVenda;
            DsModel = new Model();
            
            InitializeComponent();
        }

        //eventos
        private void Viewer_Load(object sender, EventArgs e)
        {
            CarregaDados();
            CarregaRelatorio();
        }

        //metodos
        private void CarregaDados()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer()) 
            {
                //recupera venda no banco de dados
                var item = conn.Pedido.OfType<Dados.Venda>().FirstOrDefault(a => a.IdPedido == CodVenda);

                //cria venda row
                var venda = DsModel.Venda.NewVendaRow();

                //dados da venda
                venda.CodVenda = item.IdPedido;
                venda.CodAtendimento = item.IdAtendimento;
                venda.CodReduzido = item.Atendimento.CodigoReduzido;
                venda.CodCliente = item.IdCliFor;
                venda.Vendedora = item.Usuario.Nome;
                venda.DataEmissao = item.DataEmissao.GetValueOrDefault();
                venda.ValorBruto = item.ValorBruto.GetValueOrDefault();
                venda.ValorAcrescimo = item.ValorAcrescimo.GetValueOrDefault();
                venda.ValorDesconto = item.ValorDesconto.GetValueOrDefault();
                venda.ValorLiquido = item.ValorLiquido.GetValueOrDefault();
                venda.ValorEntrada = item.ValorEntrada.GetValueOrDefault();
                venda.FormaEntrada = item.FormaEntrada.Nome;
                venda.FormaPgto = item.FormaPgto.Nome;

                //dados do cliente
                venda.NomeCompleto = item.CliFor.Nome;
                venda.Rg = item.CliFor is Dados.PessoaFisica ? ((Dados.PessoaFisica)item.CliFor).Rg : ((Dados.PessoaJuridica)item.CliFor).InscSocial;
                venda.Cpf = item.CliFor.Documento;
                venda.Idade = item.CliFor is Dados.PessoaFisica ? Lib.Utilitarios.Comum.CalculaIdade(((Dados.PessoaFisica)item.CliFor).Nascimento) : 0;
                venda.DataNascimento = item.CliFor is Dados.PessoaFisica ? ((Dados.PessoaFisica)item.CliFor).Nascimento : DateTime.Today;
                venda.Email = item.CliFor.Email;
                venda.Conjuge = item.CliFor is Dados.PessoaFisica ? ((Dados.PessoaFisica)item.CliFor).Conjuge : "";
                venda.Endereco = string.Format("{0}, {1} {2}", item.CliFor.Endereco, item.CliFor.Numero, item.CliFor.Complemento);
                venda.Cidade = item.CliFor.Cidade.Nome;
                venda.Bairro = item.CliFor.Bairro;
                venda.Estado = item.CliFor.Cidade.Estado.Nome;
                venda.Cep = item.CliFor.Cep;
                venda.Telefone = item.CliFor.Telefone;
                venda.Celular = item.CliFor.Celular;
                venda.NomeMae = item.CliFor is Dados.PessoaFisica ? ((Dados.PessoaFisica)item.CliFor).NomeMae : "";
                venda.NomePai = item.CliFor is Dados.PessoaFisica ? ((Dados.PessoaFisica)item.CliFor).NomePai : "";
                venda.Autorizado = item.Atendimento.CliFor.Nome;
                venda.TrabEmpresa = "";
                venda.TrabEndereco = "";
                venda.TrabCidade = "";
                venda.TrabTelefone = "";
                venda.Logo = Utilitarios.Comum.GetLogoReport();
                venda.NomeFantasia = Lib.Session.Instance.Contexto.Filial.NomeFantasia;

                //adiciona no dataset
                DsModel.Venda.AddVendaRow(venda);

                //referencias
                foreach (var refItem in item.CliFor.CliForReferencia)
                {
                    var referencia = DsModel.Referencia.NewReferenciaRow();
                    referencia.CodReferencia = refItem.IdReferencia;
                    referencia.CodCliente = refItem.IdCliFor;
                    referencia.Tipo = refItem.Tipo.ToString();
                    referencia.Nome = refItem.Nome;
                    referencia.Telefone = refItem.Telefone;
                    referencia.Celular = refItem.Celular;

                    //adiciona no dataset
                    DsModel.Referencia.AddReferenciaRow(referencia);
                }

                //produtos
                foreach (var refProd in item.VendaItem)
                {
                    var prod = DsModel.Produto.NewProdutoRow();
                    prod.CodProduto = refProd.IdProduto;
                    prod.CodVenda = refProd.IdPedido;
                    prod.Nome = refProd.Produto.Nome;
                    prod.Quantidade = refProd.Quant;
                    prod.ValorUnitario = refProd.ValorUnitario.GetValueOrDefault();
                    prod.ValorTotal = refProd.ValorTotal.GetValueOrDefault();

                    //adiciona no dataset
                    DsModel.Produto.AddProdutoRow(prod);
                }

                //lancamentos
                var countLanc = 0;
                foreach (var refLanc in item.Lancamento)
                {
                    countLanc++;
                    var lanc = DsModel.Lancamento.NewLancamentoRow();
                    lanc.CodLancamento = refLanc.IdLancamento;
                    lanc.CodVenda = refLanc.IdPedido.GetValueOrDefault();
                    lanc.NumParcela = countLanc;
                    lanc.Vencimento = refLanc.DataVencimento;
                    lanc.Valor = refLanc.ValorLiquido;
                    lanc.IsEntrada = refLanc.IsEntrada;

                    //adiciona no dataset
                    DsModel.Lancamento.AddLancamentoRow(lanc);
                }
                
            }
        }

        private void CarregaRelatorio() {
            try
            {
                //configura o relatorio
                Relatorio report = new Relatorio();

                //carrega dados
                report.SetDataSource(DsModel);

                //carrega o report viewer
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Zoom(100);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
