using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Fichas.Contrato
{
    public partial class Viewer : Base.Viewer
    {
        public Model Dataset { get; set; }

        public int IdVenda { get; set; }

        public Viewer(int idVenda)
        {
            this.IdVenda = idVenda;
            InitializeComponent();
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            if (Dataset == null)
            {
                Dataset = new Model();
                CarregaDataSet();
                CarregaRelatorio();
            }
        }

        private void CarregaDataSet()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                var venda = conn.Pedido.OfType<Dados.Venda>().FirstOrDefault(a => a.IdPedido == IdVenda);
                var cupom = conn.Cupom.FirstOrDefault(a => a.IdCupom == venda.Atendimento.Agendamento.IdCupom);
                var indicacao = conn.Indicacao.FirstOrDefault(a => a.IdCupom == cupom.IdCupom);
                var empresa = conn.Filial.FirstOrDefault(a => a.IdFilial == Lib.Session.Instance.Contexto.IdFilial);
                var libIndicacao = new Lib.Indicacao();
                var libVendaEvento = new Lib.VendaEvento();

                var rowAtendimento = Dataset.Atendimento.NewAtendimentoRow();
                var rowCliente = Dataset.Cliente.NewClienteRow();
                var rowEmpresa = Dataset.Empresa.NewEmpresaRow();
                var rowVenda = Dataset.Venda.NewVendaRow();

                //Atendimento
                rowAtendimento.IdAtendimento = venda.Atendimento.IdAtendimento;
                rowAtendimento.Data = venda.Atendimento.Data;
                rowAtendimento.Estudio = venda.Atendimento.Filial.NomeFantasia;
                rowAtendimento.CodigoReduzido = venda.Atendimento.CodigoReduzido;
                rowAtendimento.Logo = Utilitarios.Comum.GetLogoReport();
                rowAtendimento.QtdeIndicacoes = libIndicacao.GetByAtendimento(venda.IdAtendimento).Where(a => a.Cupom.Parceria.Convenio.Tipo == Dados.EnumConvenioTipo.PosVenda).Count();

                Dataset.Atendimento.AddAtendimentoRow(rowAtendimento);

                //Cliente
                var cliente = venda.CliFor as Dados.PessoaFisica;

                rowCliente.Nome = cliente.Nome;
                rowCliente.Nascimento = cliente == null ? string.Empty : cliente.Nascimento.ToShortDateString();
                rowCliente.RG = cliente == null ? string.Empty : cliente.Rg;
                rowCliente.Endereco = cliente.Endereco;
                rowCliente.Bairro = cliente.Bairro;
                rowCliente.Cep = cliente.Cep;
                rowCliente.Telefone = Lib.Utilitarios.Comum.FormataTelefone(cliente.Telefone);
                rowCliente.EstadoCivil = cliente == null ? string.Empty : cliente.EstadoCivil.ToString();
                rowCliente.Conjuje = cliente == null ? string.Empty : cliente.Conjuge;
                rowCliente.Filiacao = cliente == null ? string.Empty : string.Format("{0} {1} {2}", cliente.NomeMae, string.IsNullOrEmpty(cliente.NomePai) ? string.Empty : "-", cliente.NomePai);
                rowCliente.Sexo = cliente.Sexo.ToString();
                rowCliente.CPF = Lib.Utilitarios.Comum.FormataCpf(cliente.Documento);
                rowCliente.Cidade = cliente.Cidade.Nome;
                rowCliente.Estado = cliente.Cidade.Estado.Nome;
                rowCliente.Celular = Lib.Utilitarios.Comum.FormataTelefone(cliente.Celular);
                rowCliente.IdCliente = cliente.IdCliFor;
                rowCliente.IdAtendimento = venda.IdAtendimento;
                rowCliente.IndicacaoDe = indicacao == null ? string.Empty : indicacao.Atendimento.CliFor.Nome;
                rowCliente.NomeCliFinanc = venda.Atendimento.CliFor.Nome;
                rowCliente.Email = venda.Atendimento.CliFor.Email;

                Dataset.Cliente.AddClienteRow(rowCliente);

                //Empresa
                rowEmpresa.RazaoSocial = empresa.RazaoSocial;
                rowEmpresa.NomsFantasia = empresa.NomeFantasia;
                rowEmpresa.CNPJ = Lib.Utilitarios.Comum.FormataCNPJ(empresa.Cnpj);
                rowEmpresa.InscricaoEstadual = string.Empty; // Verificar
                rowEmpresa.Endereço = empresa.Endereco;
                rowEmpresa.Bairro = empresa.Bairro;
                rowEmpresa.Uf = empresa.Cidade.Estado.Abreviatura;
                rowEmpresa.Cidade = empresa.Cidade.Nome;
                rowEmpresa.Telefone = Lib.Utilitarios.Comum.FormataTelefone(empresa.Telefone);
                rowEmpresa.IdAtendimento = venda.Atendimento.IdAtendimento;
                rowEmpresa.IdEmpresa = venda.Filial.IdFilial;

                Dataset.Empresa.AddEmpresaRow(rowEmpresa);

                //Venda
                rowVenda.IdAtendimento = venda.IdAtendimento;
                rowVenda.ValorBruto = venda.ValorBruto.GetValueOrDefault().ToString("c");

                var entrada = venda.Lancamento.FirstOrDefault(a => a.IsEntrada);
                rowVenda.DataEntrada = string.Format("{0} {1} {2}", venda.FormaEntrada.Nome, entrada == null ? string.Empty : "-", entrada == null ? string.Empty : entrada.DataVencimento.ToShortDateString());
                rowVenda.ValorEntrada = venda.ValorEntrada.GetValueOrDefault().ToString("c");
                rowVenda.ValorDesconto = venda.ValorDesconto.GetValueOrDefault().ToString("c");
                rowVenda.ValorAcressimo = venda.ValorAcrescimo.GetValueOrDefault().ToString("c");
                rowVenda.ValorTotal = venda.ValorLiquido.GetValueOrDefault().ToString("c");
                rowVenda.FormPagamento = venda.FormaPgto.Nome;
                rowVenda.TotalParcelas = venda.Lancamento.Count.ToString();
                rowVenda.EspacoParcelas = venda.FormaPgto.DistParcela.ToString();
                rowVenda.IdVenda = venda.IdPedido;
                rowVenda.ValorCanaan = venda.ValorLiquido.GetValueOrDefault() - venda.ValorCrediario.GetValueOrDefault();
                rowVenda.ValorCrediario = venda.ValorCrediario.GetValueOrDefault();

                Dataset.Venda.AddVendaRow(rowVenda);


                //Fichas
                foreach (var item in venda.Atendimento.AtendimentoModelo)
                {
                    var rowModelos = Dataset.Modelo.NewModeloRow();

                    rowModelos.Nome = item.Modelo.NomeCompleto;
                    rowModelos.Nascimento = item.Modelo.Nascimento.ToShortDateString();
                    rowModelos.Idade = Lib.Utilitarios.Comum.CalculaIdade(item.Modelo.Nascimento);
                    rowModelos.CPF = Lib.Utilitarios.Comum.FormataCpf(item.Modelo.Cpf);
                    rowModelos.IdAtendimento = venda.Atendimento.IdAtendimento;
                    rowModelos.IdModelo = item.IdModelo;

                    Dataset.Modelo.AddModeloRow(rowModelos);
                }

                // Lançamentos
                foreach (var item in venda.Lancamento.Select((item, i) => new {item, i}))
                {
                    var rowParcela = Dataset.Parcelas.NewParcelasRow();

                    rowParcela.IdLancamento = item.item.IdLancamento;
                    rowParcela.IdVenda = venda.IdPedido;
                    rowParcela.Parcela = item.i + 1;
                    rowParcela.Vencimento = item.item.DataVencimento.ToShortDateString();
                    rowParcela.Entrada = item.item.IsEntrada ? "Sim" : "Não";
                    rowParcela.Valor = item.item.ValorLiquido.ToString("c");

                    Dataset.Parcelas.AddParcelasRow(rowParcela);
                }

                //Produtos
                var produtosText = "";
                foreach (var item in venda.VendaItem)
                {
                    var rowProdutos = Dataset.Produtos.NewProdutosRow();

                    rowProdutos.IdVenda = venda.IdPedido;
                    rowProdutos.IdProduto = item.IdItem;
                    rowProdutos.Nome = item.Produto.Nome;
                    rowProdutos.Descricao = item.Produto.Descricao;
                    Dataset.Produtos.AddProdutosRow(rowProdutos);

                    produtosText += string.Format("{0}\n", item.Produto.Nome);
                }

                //Servicos
                var servicosText = "";
                foreach (var item in venda.OrdemServico)
                {
                    var rowServicos = Dataset.Servicos.NewServicosRow();

                    rowServicos.IdVenda = venda.IdPedido;
                    rowServicos.IdOrdemServico = item.IdOrdemServico;
                    rowServicos.Nome = item.Servico.Nome;
                    rowServicos.Fotos = item.OrdemServicoItem.Count;
                    Dataset.Servicos.AddServicosRow(rowServicos);

                    servicosText += string.Format("{0} - {1} fotos\n", item.Servico.Nome, item.OrdemServicoItem.Count.ToString());
                }

                //indicacoes
                foreach (var ind in libIndicacao.GetByAtendimento(venda.IdAtendimento).Where(a => a.Cupom.Parceria.Convenio.Tipo == Dados.EnumConvenioTipo.PosVenda))
                {
                    var rowIndicacao = Dataset.Indicacoes.NewIndicacoesRow();

                    rowIndicacao.IdIndicacao = ind.idIndicacao;
                    rowIndicacao.IdAtendimento = ind.IdAtendimento;
                    rowIndicacao.Nome = ind.Cupom.Nome;
                    rowIndicacao.Telefone = ind.Cupom.Telefone;
                    rowIndicacao.Celular = ind.Cupom.Celular;
                    rowIndicacao.Email = ind.Cupom.Email;
                    rowIndicacao.Parceria = ind.Cupom.Parceria.Nome;

                    //adiciona no dataset
                    Dataset.Indicacoes.AddIndicacoesRow(rowIndicacao);
                }

                //eventos
                var eventos = libVendaEvento.GetByVenda(venda.IdPedido);
                var txtEvento = "";

                if (!string.IsNullOrEmpty(venda.TipoEvento) && !string.IsNullOrEmpty(venda.NomeModelo))
                {
                    txtEvento += string.Format("Tipo de Evento: {0}", venda.TipoEvento);
                    txtEvento += Environment.NewLine;
                    txtEvento += string.Format("Nome: {0}", venda.NomeModelo);
                    txtEvento += Environment.NewLine;
                }
                else
                {
                    txtEvento += produtosText;
                }
                
                

                foreach (var evento in eventos)
                {
                    txtEvento += string.Format("{0}:", evento.Evento.Nome);
                    txtEvento += Environment.NewLine;
                    txtEvento += string.Format("Data: {0}", evento.DataInicio.ToShortDateString());
                    txtEvento += Environment.NewLine;
                    txtEvento += string.Format("{0}", evento.Descricao);
                    txtEvento += Environment.NewLine;
                    txtEvento += Environment.NewLine;
                }

                rowVenda.Eventos = txtEvento;
                rowVenda.Contrato = new Lib.Config().GetByFilial(Lib.Session.Instance.Contexto.IdFilial).TextoContrato;

                if (!string.IsNullOrEmpty(venda.EventoEspecificacao))
                {
                    rowVenda.Servicos = venda.EventoEspecificacao;
                }
                else
                {
                    rowVenda.Servicos = servicosText;
                }
                
            }
        }

        private void CarregaRelatorio()
        {
            try
            {
                //configura o relatorio
                Relatorio report = new Relatorio();

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
    }
}
