using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;
using System.Data.Entity;
using System.ComponentModel;

namespace Canaan.Lib
{
    public class Venda : IBase<Dados.Venda>
    {
        #region ARRAYS

        public Dados.EnumStatusVenda[] NaoFinalizou
        {
            get
            {
                return new Dados.EnumStatusVenda[] { Dados.EnumStatusVenda.Cancelado, Dados.EnumStatusVenda.Devolvido, Dados.EnumStatusVenda.NaoFinalizado };
            }
        }

        public Dados.EnumStatusVenda[] ClienteVendido
        {
            get
            {
                return new Dados.EnumStatusVenda[] { Dados.EnumStatusVenda.Faturado, Dados.EnumStatusVenda.Programada, Dados.EnumStatusVenda.Quitado };
            }
        }

        public Dados.EnumStatusVenda[] Atendidos
        {
            get
            {
                return new Dados.EnumStatusVenda[] 
                { 
                    Dados.EnumStatusVenda.AFaturar,
                    Dados.EnumStatusVenda.Devolvido,
                    Dados.EnumStatusVenda.Faturado, 
                    Dados.EnumStatusVenda.ParcialmenteQuitado,
                    Dados.EnumStatusVenda.Programada, 
                    Dados.EnumStatusVenda.Quitado 
                };
            }
        }

        #endregion

        #region METODOS GET

        public List<Dados.Venda> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Pedido.OfType<Dados.Venda>().ToList();
            }
        }

        public List<Dados.Venda> GetByStatus(Dados.EnumStatusVenda status)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Pedido.OfType<Dados.Venda>()
                           .Where(a => a.Status == status)
                           .ToList();
            }
        }

        public Dados.Venda GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Pedido.Include(a => a.CliFor)
                                  .Include(a => a.Filial)
                                  .Include(a => a.Lancamento)
                                  .OfType<Dados.Venda>()
                                    .Include(a => a.VendaItem)
                                    .Include(a => a.Atendimento)
                                    .Include(a => a.Atendimento.Usuario)
                                    .Include(a => a.Atendimento.Agendamento)
                                    .Include(a => a.Atendimento.Agendamento.Cupom)
                                    .Include(a => a.Atendimento.Agendamento.Cupom.Parceria)
                                    .Include(a => a.Atendimento.Agendamento.Cupom.Parceria.Convenio)
                                    .Include(a => a.VendaEvento)
                                    .Include(a => a.FormaEntrada)
                                    .Include(a => a.FormaPgto)
                                    .Include(a => a.Usuario)
                                  .FirstOrDefault(a => a.IdPedido == id);
            }
        }

        public List<Dados.Venda> GetByNome(string nome)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Pedido
                           .OfType<Dados.Venda>()
                           .Include(a => a.VendaItem)
                            .Include(a => a.Atendimento)
                            .Include(a => a.FormaEntrada)
                            .Include(a => a.FormaPgto)
                            .Include(a => a.Usuario)
                           .Where(a => a.CliFor.Nome.Contains(nome) || a.Atendimento.CliFor.Nome.Contains(nome))
                           .ToList();
            }
        }

        public List<Dados.Venda> GetAtendidosByPeriodo(DateTime pInicio, DateTime pFim, int pFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Pedido.OfType<Dados.Venda>()
                           .Include(a => a.Atendimento)
                           .Include(a => a.Atendimento.Sessao)
                           .Include(a => a.CliFor)
                           .Where(a => a.Data >= pInicio &&
                                       a.Data <= pFim &&
                                       a.IdFilial == pFilial &&
                                       a.VendaItem.Count > 0 &&
                                       Atendidos.Contains(a.Status) &&
                                       a.Atendimento.Venda.Where(b => b.Data < pInicio && Atendidos.Contains(b.Status) && b.IdFilial == pFilial).Count() == 0)
                           .ToList();
            }
        }

        public List<Dados.Venda> GetByCliente(int idCliFor)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Pedido.OfType<Dados.Venda>()
                                  .Include(a => a.CliFor)
                                  .Include(a => a.Atendimento)
                                  .Where(a => a.IdCliFor == idCliFor).ToList();
            }
        }

        public List<Dados.Venda> GetByAtendimento(int idAtendimento, int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Pedido.OfType<Dados.Venda>().Include(a => a.Atendimento)
                                                        .Include(a => a.CliFor)
                                                        .Where(a => a.IdAtendimento == idAtendimento &&
                                                               a.IdFilial == idFilial).ToList();
            }
        }

        public List<Dados.Venda> GetByCodigoReduzido(int codigoReduzido, int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Pedido.OfType<Dados.Venda>().Include(a => a.Atendimento)
                                                        .Include(a => a.CliFor)
                                                        .Where(a => a.Atendimento.CodigoReduzido == codigoReduzido &&
                                                               a.IdFilial == idFilial).ToList();
            }
        }

        public BindingList<Dados.Venda> GetVendasDevolvidasPeriodo(int idFilial, DateTime dtInicial, DateTime dtFinal)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return new BindingList<Dados.Venda>(conn.Pedido.OfType<Dados.Venda>()
                                                               .Include(a => a.CliFor)
                                                               .Include(a => a.Atendimento)
                                                               .Where(a => (a.Status == Dados.EnumStatusVenda.Devolvido) &&
                                                                           (a.IsLiberado == null || a.IsLiberado == false) &&
                                                                           a.DataLiberacao == null &&
                                                                           a.IdFilial == idFilial &&
                                                                           a.DataDevolucao >= dtInicial &&
                                                                           a.DataDevolucao <= dtFinal)
                                                               .OrderByDescending(a => a.DataDevolucao)
                                                               .ToList());
            }
        }

        public List<Dados.Venda> GetByCodigoReduzidoDesbloqueio(int codigoReduzido, int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Pedido.OfType<Dados.Venda>().Include(a => a.Atendimento)
                                                        .Include(a => a.CliFor)
                                                        .Where(a => a.Atendimento.CodigoReduzido == codigoReduzido &&
                                                               a.IdFilial == idFilial &&
                                                               a.IsConfirmado &&
                                                               a.IsLiberado == true &&
                                                               a.DataLiberacao != null)
                                                        .ToList();
            }
        }

        public List<Dados.Venda> Filter(string filtro, object[] parameters)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Pedido.OfType<Dados.Venda>().Where(filtro, parameters).ToList();
            }
        }

        public List<Dados.Venda> GetByArrayCodigos(int[] vendasId, int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Pedido.OfType<Dados.Venda>()
                    .Include(a => a.Atendimento)
                    .Include(a => a.CliFor)
                    .Where(a => vendasId.Contains(a.IdPedido) && a.IdFilial == idFilial).ToList();
            }
        }

        #endregion

        #region METODOS INSERT / UPDATE / DELETE

        public Dados.Venda Insert(Dados.Venda item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Pedido.Add(item);

                    //valida e salva
                    if (Validacao.IsValid(conn))
                    {
                        conn.SaveChanges();
                        InsertMov(item);
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return GetById(item.IdAtendimento);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void InsertMov(Dados.Venda item)
        {
            //cria movimentacao
            var mov = new Dados.VendaMov();
            mov.IdPedido = item.IdPedido;
            mov.IdUsuario = Session.Instance.Usuario.IdUsuario;
            mov.Status = item.Status;
            mov.Data = DateTime.Now;

            //Insere movimentação
            var libMov = new VendaMov();
            libMov.Insert(mov);
        }

        public Dados.Venda Update(Dados.Venda item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Pedido.OfType<Dados.Venda>().FirstOrDefault(a => a.IdPedido == item.IdPedido);
                    var updateMov = false;

                    //verifica se houve alteração no status
                    if (updated.Status != item.Status)
                    {
                        updateMov = true;
                    }

                    //venda
                    updated.IdAtendimento = item.IdAtendimento;
                    updated.IdFormaEntrada = item.IdFormaEntrada;
                    updated.IdCliFor = item.IdCliFor;
                    updated.Status = item.Status;
                    updated.ValorEntrada = item.ValorEntrada;
                    updated.DataVenda = item.DataVenda;
                    updated.IsFaturado = item.IsFaturado;
                    updated.DataFaturamento = item.DataFaturamento;
                    updated.IsLiberado = item.IsLiberado;
                    updated.DataLiberacao = item.DataLiberacao;
                    updated.IsDevolvida = item.IsDevolvida;
                    updated.DataDevolucao = item.DataDevolucao;
                    updated.IsConfirmado = item.IsConfirmado;
                    updated.IdUsuario = item.IdUsuario;
                    updated.DataConfirmacao = item.DataConfirmacao;
                    updated.EntradaCartao = item.EntradaCartao;
                    updated.EntradaDinheiro = item.EntradaDinheiro;
                    updated.EntradaDepositada = item.EntradaDepositada;
                    updated.VendaCartao = item.VendaCartao;
                    updated.VendaDinheiro = item.VendaDinheiro;
                    updated.TipoVenda = item.TipoVenda;
                    updated.ValorCrediario = item.ValorCrediario;

                    //Pedido
                    updated.IdFormaPgto = item.IdFormaPgto;
                    updated.Data = item.Data;
                    updated.DataEmissao = item.DataEmissao;
                    updated.ClasseContabil = item.ClasseContabil;
                    updated.ValorBruto = item.ValorBruto;
                    updated.ValorDesconto = item.ValorDesconto;
                    updated.ValorAcrescimo = item.ValorAcrescimo;
                    updated.ValorLiquido = item.ValorLiquido;
                    updated.IsAtivo = item.IsAtivo;

                    //evento
                    updated.TipoEvento = item.TipoEvento;
                    updated.NomeModelo = item.NomeModelo;
                    updated.EventoEspecificacao = item.EventoEspecificacao;



                    //validaupdated.imal Custo {  e salva
                    if (Validacao.IsValid(conn))
                    {
                        conn.SaveChanges();

                        //insere movimentação de status
                        if (updateMov)
                        {
                            //movimentacao de status
                            InsertMov(updated);
                        }
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return GetById(updated.IdPedido);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Venda Delete(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region CONFIRMACOES E TELAS

        public dynamic CarregaGrid(List<Dados.Venda> lista)
        {
            //Se não existir nenhuma venda
            if (lista.Count <= 0)
                return new List<Dados.Venda>().Select(a => new Model.Venda
                {
                    Codigo = a.IdPedido,
                    Atendimento = a.Atendimento.CodigoReduzido,
                    Cliente = string.Empty,
                    Data = a.Data,
                    DataDevolucao = a.DataDevolucao == null ? DateTime.MaxValue : a.DataDevolucao.GetValueOrDefault(),
                    Preco = a.ValorLiquido == null ? string.Empty : a.ValorLiquido.ToString(),
                    Status = a.Status
                }).ToList();

            using (var conn = new Dados.CanaanModelContainer())
            {
                //var idCliente = lista[0].IdCliFor;
                //var cliente = conn.CliFor.FirstOrDefault(a => a.IdCliFor == idCliente);

                return lista.Select(a => new Model.Venda
                {
                    Codigo = a.IdPedido,
                    Atendimento = a.Atendimento.CodigoReduzido,
                    Cliente = a.CliFor.Nome,
                    Preco = a.ValorLiquido.GetValueOrDefault().ToString("c"),
                    DataDevolucao = a.DataDevolucao == null ? DateTime.MaxValue : a.DataDevolucao.GetValueOrDefault(),
                    Data = a.Data,
                    Status = a.Status
                }).ToList();
            }
        }

        public List<Model.Venda> CarregaGridModel(List<Dados.Venda> lista)
        {
            //Se não existir nenhuma venda
            if (lista.Count <= 0)
                return new List<Dados.Venda>().Select(a => new Model.Venda
                {
                    Codigo = a.IdPedido,
                    Atendimento = a.Atendimento.CodigoReduzido,
                    Cliente = string.Empty,
                    Data = a.Data,
                    Status = a.Status,                    
                }).ToList();

            using (var conn = new Dados.CanaanModelContainer())
            {
                var idCliente = lista[0].IdCliFor;
                var cliente = conn.CliFor.FirstOrDefault(a => a.IdCliFor == idCliente);

                return lista.Select(a => new Model.Venda
                {
                    Codigo = a.IdPedido,
                    Atendimento = a.Atendimento.CodigoReduzido,
                    Cliente = cliente.Nome,
                    Preco = a.ValorLiquido.GetValueOrDefault().ToString("c"),
                    Data = a.Data,
                    Status = a.Status
                }).ToList();
            }
        }

        public bool CanUpdate(Dados.EnumStatusVenda enumStatusVenda)
        {
            switch (enumStatusVenda)
            {
                case Dados.EnumStatusVenda.AFaturar:
                    return true;
                case Dados.EnumStatusVenda.Faturado:
                    return false;
                case Dados.EnumStatusVenda.Cancelado:
                    return false;
                case Dados.EnumStatusVenda.Programada:
                    return false;
                case Dados.EnumStatusVenda.ParcialmenteQuitado:
                    return false;
                case Dados.EnumStatusVenda.Quitado:
                    return false;
                case Dados.EnumStatusVenda.NaoFinalizado:
                    return true;
                case Dados.EnumStatusVenda.Devolvido:
                    return true;
                default:
                    return false;
            }
        }

        public bool ExisteOrdensServico(Dados.Venda Venda)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.VendaItem.Where(a => a.IdPedido == Venda.IdPedido).Any(a => a.VendaItemOrdemServico.Count > 0);
            }
        }

        #endregion

        #region LIBERACAO VENDA

        public BindingList<Dados.Venda> GetVendasLiberacaoFilial(int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return new BindingList<Dados.Venda>(conn.Pedido.OfType<Dados.Venda>()
                                                               .Include(a => a.CliFor)
                                                               .Include(a => a.Atendimento)
                                                               .Where(a => (a.Status == Dados.EnumStatusVenda.AFaturar || a.Status == Dados.EnumStatusVenda.Faturado) &&
                                                                           (a.IsLiberado == null || a.IsLiberado == false) &&
                                                                           a.DataLiberacao == null && a.IsConfirmado && a.IdFilial == idFilial)
                                                               .OrderBy(a => a.DataVenda)
                                                               .ToList());
            }
        }

        public BindingList<Dados.Venda> GetVendasLiberacaoFilialAndCod(int idFilial, int codigoReduzido)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return new BindingList<Dados.Venda>(conn.Pedido.OfType<Dados.Venda>()
                                                               .Include(a => a.CliFor)
                                                               .Include(a => a.Atendimento)
                                                               .Where(a => (a.Status == Dados.EnumStatusVenda.AFaturar || a.Status == Dados.EnumStatusVenda.Faturado) &&
                                                                           (a.IsLiberado == null || a.IsLiberado == false) &&
                                                                           a.DataLiberacao == null && a.IsConfirmado &&
                                                                           a.Atendimento.CodigoReduzido == codigoReduzido &&
                                                                           a.IdFilial == idFilial)
                                                               .OrderBy(a => a.DataVenda)
                                                               .ToList());
            }
        }

        public BindingList<Dados.Venda> GetVendasLiberacaoByCpfAndFilial(string cpf, int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return new BindingList<Dados.Venda>(conn.Pedido.OfType<Dados.Venda>()
                                                               .Include(a => a.CliFor)
                                                               .Include(a => a.Atendimento)
                                                               .Where(a => (a.Status == Dados.EnumStatusVenda.AFaturar || a.Status == Dados.EnumStatusVenda.Faturado) &&
                                                                           (a.IsLiberado == null || a.IsLiberado == false) &&
                                                                           a.DataLiberacao == null && a.IsConfirmado &&
                                                                           a.IdFilial == idFilial &&
                                                                           a.CliFor.Documento.Contains(cpf))
                                                               .OrderBy(a => a.DataVenda)
                                                               .ToList());
            }
        }

        public BindingList<Dados.Venda> GetVendasLiberacaoByNome(string nome, int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return new BindingList<Dados.Venda>(conn.Pedido.OfType<Dados.Venda>()
                                                               .Include(a => a.CliFor)
                                                               .Include(a => a.Atendimento)
                                                               .Where(a => (a.Status == Dados.EnumStatusVenda.AFaturar || a.Status == Dados.EnumStatusVenda.Faturado) &&
                                                                           (a.IsLiberado == null || a.IsLiberado == false) &&
                                                                           a.DataLiberacao == null && a.IsConfirmado &&
                                                                           a.IdFilial == idFilial &&
                                                                           a.CliFor.Nome.Contains(nome))
                                                               .OrderBy(a => a.DataVenda)
                                                               .ToList());
            }
        }

        #endregion

        #region LIBERACAO PROGRAMDAS

        public BindingList<Dados.Venda> GetProgramadasLiberacaoFilial(int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return new BindingList<Dados.Venda>(conn.Pedido.OfType<Dados.Venda>()
                                                               .Include(a => a.CliFor)
                                                               .Include(a => a.Atendimento)
                                                               .Where(a => a.Status == Dados.EnumStatusVenda.Programada &&
                                                                          (a.IsLiberado == null || a.IsLiberado == false) &&
                                                                           a.DataLiberacao == null &&
                                                                           !a.IsDevolvida &&
                                                                           a.IsConfirmado &&
                                                                           a.IdFilial == idFilial)
                                                               .OrderBy(a => a.Data)
                                                               .ToList());
            }
        }

        public BindingList<Dados.Venda> GetProgramadasLiberacaoFilialAndCod(int idFilial, int codigoReduzido)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return new BindingList<Dados.Venda>(conn.Pedido.OfType<Dados.Venda>()
                                                               .Include(a => a.CliFor)
                                                               .Include(a => a.Atendimento)
                                                               .Where(a => a.Status == Dados.EnumStatusVenda.Programada &&
                                                                          (a.IsLiberado == null || a.IsLiberado == false) &&
                                                                           a.DataLiberacao == null &&
                                                                           !a.IsDevolvida &&
                                                                           a.IsConfirmado &&
                                                                           a.IdFilial == idFilial &&
                                                                           a.Atendimento.CodigoReduzido == codigoReduzido)
                                                               .OrderBy(a => a.Data)
                                                               .ToList());
            }
        }

        public BindingList<Dados.Venda> GetProgramadasLiberacaoByCpfAndFilial(string cpf, int IdFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return new BindingList<Dados.Venda>(conn.Pedido.OfType<Dados.Venda>()
                                                               .Include(a => a.CliFor)
                                                               .Include(a => a.Atendimento)
                                                               .Where(a => a.Status == Dados.EnumStatusVenda.Programada &&
                                                                          (a.IsLiberado == null || a.IsLiberado == false) &&
                                                                           a.DataLiberacao == null &&
                                                                           !a.IsDevolvida &&
                                                                           a.IsConfirmado &&
                                                                           a.IdFilial == IdFilial &&
                                                                           a.CliFor.Documento.Contains(cpf))
                                                               .OrderBy(a => a.Data)
                                                               .ToList());
            }
        }

        public BindingList<Dados.Venda> GetProgramadasLiberacaoByNome(string nome, int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return new BindingList<Dados.Venda>(conn.Pedido.OfType<Dados.Venda>()
                                                               .Include(a => a.CliFor)
                                                               .Include(a => a.Atendimento)
                                                               .Where(a => a.Status == Dados.EnumStatusVenda.Programada &&
                                                                          (a.IsLiberado == null || a.IsLiberado == false) &&
                                                                           a.DataLiberacao == null &&
                                                                           !a.IsDevolvida &&
                                                                           a.IsConfirmado &&
                                                                           a.IdFilial == idFilial &&
                                                                           a.CliFor.Nome.Contains(nome))
                                                               .OrderBy(a => a.Data)
                                                               .ToList());
            }
        }

        #endregion

        #region CONFIRMAÇÃO GERENTE

        public BindingList<Dados.Venda> GetVendasConfirmacoes(int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return new BindingList<Dados.Venda>(conn.Pedido.OfType<Dados.Venda>()
                                                               .Include(a => a.CliFor)
                                                               .Include(a => a.Atendimento)
                                                               .Where(a => (a.Status == Dados.EnumStatusVenda.Programada || a.Status == Dados.EnumStatusVenda.Faturado || a.Status == Dados.EnumStatusVenda.AFaturar) &&
                                                                          (a.IsLiberado == null || a.IsLiberado == false) &&
                                                                           a.DataLiberacao == null &&
                                                                           !a.IsDevolvida &&
                                                                           !a.IsConfirmado &&
                                                                           a.IdFilial == idFilial)
                                                               .OrderBy(a => a.Data)
                                                               .ToList());
            }
        }

        public BindingList<Dados.Venda> GetConferenciaLiberacaoFilialAndCod(int idFilial, int codigoReduzido)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return new BindingList<Dados.Venda>(conn.Pedido.OfType<Dados.Venda>()
                                                               .Include(a => a.CliFor)
                                                               .Include(a => a.Atendimento)
                                                               .Where(a => (a.Status == Dados.EnumStatusVenda.Programada || a.Status == Dados.EnumStatusVenda.Faturado || a.Status == Dados.EnumStatusVenda.AFaturar) &&
                                                                          (a.IsLiberado == null || a.IsLiberado == false) &&
                                                                           a.DataLiberacao == null &&
                                                                           a.IsDevolvida == false &&
                                                                           a.IsConfirmado == false &&
                                                                           a.IdFilial == idFilial &&
                                                                           a.Atendimento.CodigoReduzido == codigoReduzido)
                                                               .OrderBy(a => a.Data)
                                                               .ToList());
            }
        }

        public BindingList<Dados.Venda> GetConferenciaLiberacaoByCpfAndFilial(string cpf, int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return new BindingList<Dados.Venda>(conn.Pedido.OfType<Dados.Venda>()
                                                               .Include(a => a.CliFor)
                                                               .Include(a => a.Atendimento)
                                                               .Where(a => (a.Status == Dados.EnumStatusVenda.Programada || a.Status == Dados.EnumStatusVenda.Faturado || a.Status == Dados.EnumStatusVenda.AFaturar) &&
                                                                          (a.IsLiberado == null || a.IsLiberado == false) &&
                                                                           a.DataLiberacao == null &&
                                                                           !a.IsDevolvida &&
                                                                           !a.IsConfirmado &&
                                                                           a.IdFilial == idFilial &&
                                                                           a.CliFor.Documento.Contains(cpf))
                                                               .OrderBy(a => a.Data)
                                                               .ToList());
            }
        }

        public BindingList<Dados.Venda> GetConferenciaLiberacaoByNome(string nome, int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return new BindingList<Dados.Venda>(conn.Pedido.OfType<Dados.Venda>()
                                                               .Include(a => a.CliFor)
                                                               .Include(a => a.Atendimento)
                                                               .Where(a => (a.Status == Dados.EnumStatusVenda.Programada || a.Status == Dados.EnumStatusVenda.Faturado || a.Status == Dados.EnumStatusVenda.AFaturar) &&
                                                                          (a.IsLiberado == null || a.IsLiberado == false) &&
                                                                           a.DataLiberacao == null &&
                                                                           !a.IsDevolvida &&
                                                                           !a.IsConfirmado &&
                                                                           a.IdFilial == idFilial &&
                                                                           a.CliFor.Nome.Contains(nome))
                                                               .OrderBy(a => a.Data)
                                                               .ToList());
            }
        }

        #endregion

        #region DEVOLUCOES

        public BindingList<Dados.Venda> GetVendasDevolvidas(int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return new BindingList<Dados.Venda>(conn.Pedido.OfType<Dados.Venda>()
                                                               .Include(a => a.CliFor)
                                                               .Include(a => a.Atendimento)
                                                               .Where(a => (a.Status == Dados.EnumStatusVenda.Devolvido) &&
                                                                           (a.IsLiberado == null || a.IsLiberado == false) &&
                                                                           a.DataLiberacao == null && a.IdFilial == idFilial)
                                                               .OrderByDescending(a => a.DataDevolucao)
                                                               .ToList());
            }
        }

        #endregion

        public bool ValidaPedidos(Dados.Venda venda)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var vd = conn.Pedido.OfType<Dados.Venda>().FirstOrDefault(a => a.IdPedido == venda.IdPedido);
                return vd != null && vd.OrdemServico.All(a => a.OrdemServicoItem.Count > 0);
            }
        }
    }
}
