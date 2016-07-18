using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Dynamic;
using BoletoNet;
using System.ComponentModel;


namespace Canaan.Lib
{
    public class Lancamento
    {
        #region CONSULTAS

        public List<Dados.Lancamento> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Lancamento
                           .Include(a => a.CliFor)
                           .Include(a => a.Filial)
                           .Include(a => a.ContaCaixa)
                           .Include(a => a.Pedido)
                           .ToList();
            }
        }

        public List<Dados.Lancamento> Get(int[] ids)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Lancamento
                           .Include(a => a.CliFor)
                           .Include(a => a.Filial)
                           .Include(a => a.ContaCaixa)
                           .Include(a => a.Pedido)
                           .Where(a => ids.Contains(a.IdLancamento))
                           .ToList();
            }
        }

        public List<Dados.Lancamento> GetByFilial(int IdFilial)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Lancamento
                           .Include(a => a.CliFor)
                           .Include(a => a.Filial)
                           .Include(a => a.ContaCaixa)
                           .Include(a => a.Pedido)
                           .Where(a => a.IdFilial == IdFilial)
                           .ToList();
            }
        }

        public Dados.Lancamento GetByNossoNumero(int IdFilial, string nossoNumero)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Lancamento
                           .Include(a => a.CliFor)
                           .Include(a => a.Filial)
                           .Include(a => a.ContaCaixa)
                           .Include(a => a.Pedido)
                           .FirstOrDefault(a => a.IdFilial == IdFilial && a.NossoNumero == nossoNumero);
            }
        }

        public List<Dados.Lancamento> GetByEmissao(DateTime Emissao)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Lancamento
                           .Include(a => a.CliFor)
                           .Include(a => a.Filial)
                           .Include(a => a.ContaCaixa)
                           .Include(a => a.Pedido)
                           .Where(a => a.DataEmissao == Emissao)
                           .ToList();
            }
        }

        public List<Dados.Lancamento> GetByPedido(int IdPedido)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Lancamento
                           .Include(a => a.CliFor)
                           .Include(a => a.Filial)
                           .Where(a => a.IdPedido == IdPedido)
                           .ToList();
            }
        }

        public List<Dados.Lancamento> GetByNome(string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Lancamento
                           .Include(a => a.CliFor)
                           .Include(a => a.Filial)
                           .Include(a => a.ContaCaixa)
                           .Include(a => a.Pedido)
                           .Where(a => a.CliFor.Nome.Contains(nome))
                           .ToList();
            }
        }

        public List<Dados.Lancamento> Filter(string filtro, object[] parameters)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                var lanc = new List<Dados.Lancamento>();
                var vendas = conn.Pedido.OfType<Dados.Venda>().Where(filtro, parameters);

                foreach (var venda in vendas)
                {
                    var lancamentos = conn.Lancamento
                                          .Include(a => a.Filial)
                                          .Include(a => a.CliFor)
                                          .Where(a => a.IdPedido == venda.IdPedido);

                    foreach (var item in lancamentos)
                    {
                        lanc.Add(item);
                    }
                }

                return lanc;
            }
        }

        public Dados.Lancamento GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Lancamento
                           .Include(a => a.CliFor)
                           .Include(a => a.Filial)
                           .Include(a => a.ContaCaixa)
                           .Include(a => a.Pedido)
                           .FirstOrDefault(a => a.IdLancamento == id);
            }
        }

        public int[] GetIds(List<Dados.Lancamento> lista)
        {
            //cria lista de items para excluir
            List<int> ids = new List<int>();

            //faz loop preenchendo a lista
            foreach (var item in lista)
            {
                ids.Add(item.IdLancamento);
            }

            return ids.ToArray();
        }

        public List<LancamentoGridModel> CarregaGrid(List<Dados.Lancamento> lista)
        {
            if (lista != null && lista.Count > 0)
            {
                var result = lista.Select(a => new LancamentoGridModel
                {
                    Codigo = a.IdLancamento,
                    Tipo = GetTipoImage(a.Tipo),
                    Status = GetStatusImage(a.Status),
                    StatusVenc = GetVencimentoImage(a),
                    Filial = a.Filial.NomeFantasia,
                    Nome = a.CliFor.Nome,
                    Emissao = a.DataEmissao.ToShortDateString(),
                    Vencimento = a.DataVencimento.ToShortDateString(),
                    Baixa = a.DataBaixa.HasValue ? a.DataBaixa.GetValueOrDefault().ToShortDateString() : "",
                    Original = a.ValorOriginal,
                    Baixado = a.ValorBaixado.GetValueOrDefault(),
                    Entrada = a.IsEntrada
                }).ToList();

                return result;
            }
            else
            {
                return new List<LancamentoGridModel>();
            }
        }

        private System.Drawing.Bitmap GetStatusImage(Dados.EnumStatusLanc status)
        {
            System.Drawing.Bitmap img;
            switch (status)
            {
                case Dados.EnumStatusLanc.EmAberto:
                    img = Properties.Resources.data_new;
                    break;
                case Dados.EnumStatusLanc.Baixado:
                    img = Properties.Resources.data_ok;
                    break;
                case Dados.EnumStatusLanc.BaixadoAcordo:
                    img = Properties.Resources.data_replace;
                    break;
                case Dados.EnumStatusLanc.Cancelado:
                    img = Properties.Resources.data_forbidden;
                    break;
                default:
                    img = Properties.Resources.data_unknown;
                    break;
            }

            return img;
        }

        private System.Drawing.Bitmap GetTipoImage(Dados.EnumLancTipo tipo)
        {
            System.Drawing.Bitmap img;

            switch (tipo)
            {
                case Dados.EnumLancTipo.Pagar:
                    img = Properties.Resources.flag_red;
                    break;
                case Dados.EnumLancTipo.Receber:
                    img = Properties.Resources.flag_green;
                    break;
                default:
                    img = Properties.Resources.flag_yellow;
                    break;
            }

            return img;
        }

        private System.Drawing.Bitmap GetVencimentoImage(Dados.Lancamento lanc)
        {
            if (lanc.DataBaixa != null)
            {
                return Properties.Resources.document_ok;
            }
            else
            {
                if (lanc.DataVencimento == DateTime.Today.Date)
                {
                    return Properties.Resources.document_out;
                }
                else
                {
                    if (lanc.DataVencimento <= DateTime.Today.Date)
                    {
                        return Properties.Resources.document_stop;
                    }
                    else
                    {
                        return Properties.Resources.document_plain;
                    }
                }

            }
        }

        public BindingList<Model.Lancamento> GetModelParcelas(List<Dados.Lancamento> result)
        {
            return new BindingList<Model.Lancamento>(result.Select(a => new Model.Lancamento
            {
                ClasseContabil = a.ClasseContabil,
                IdFilial = a.IdFilial,
                Filial = a.Filial.NomeFantasia,
                IdCliFor = a.IdCliFor,
                Cliente = a.CliFor.Nome,
                DataVencimento = a.DataVencimento,
                DataEmissao = a.DataEmissao,
                IdLan = a.IdLancamento,
                IdPedido = a.IdPedido.GetValueOrDefault(),
                DataAgendamento = a.DataAgendamento.GetValueOrDefault(),
                Tipo = Dados.EnumLancTipo.Receber,
                TipoParcela = a.IsEntrada ? Properties.Resources.money2 : Properties.Resources.money_envelope,
                ValorAcrescimo = a.ValorAcrescimo,
                ValorDesconto = a.ValorDesconto,
                ValorLiquido = a.ValorLiquido,
                ValorOriginal = a.ValorOriginal

            }).ToList());
        }

        #endregion

        #region INSERT / UPDATE / DELETE

        public Dados.Lancamento Insert(Dados.Lancamento item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Lancamento.Add(item);

                    //valida e salva
                    if (Validacao.IsValid(conn))
                    {
                        //salva o lancamento
                        conn.SaveChanges();
                        
                        //atualiza dados da integração bancaria
                        UpdateIntegracao(item);

                        //salva a movimentacao
                        InsertMov(item);
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return GetById(item.IdLancamento);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void InsertMov(Dados.Lancamento item)
        {
            //cria movimentacao
            var mov = new Dados.LancamentoMov();
            mov.IdLancamento = item.IdLancamento;
            mov.IdUsuario = Session.Instance.Usuario.IdUsuario;
            mov.Status = item.Status;
            mov.Data = DateTime.Today.Date;

            var libMov = new LancamentoMov();
            libMov.Insert(mov);
        }

        public Dados.Lancamento Update(Dados.Lancamento item, bool refazIntegracao = false)
        {
            if (item.Status == Dados.EnumStatusLanc.Cancelado && item.IdPedido != null)
            {
                throw new Exception("Lançamentos originados do modulo de COMPRA/VENDA não podem ser cancelados no módulo financeiro.");
            }
            else
            {
                try
                {
                    using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                    {
                        //recupera item do banco
                        var updated = conn.Lancamento.FirstOrDefault(a => a.IdLancamento == item.IdLancamento);
                        var updateMov = false;

                        //verifica se houve alteração no status
                        if (updated.Status != item.Status)
                        {
                            updateMov = true;
                        }

                        //atualiza dados
                        updated.IdCliFor = item.IdCliFor;
                        updated.IdFilial = item.IdFilial;
                        updated.IdContaCaixa = item.IdContaCaixa;
                        updated.IdPedido = item.IdPedido;
                        updated.IdExtrato = item.IdExtrato;
                        updated.Tipo = item.Tipo;
                        updated.Status = item.Status;
                        updated.ClasseContabil = item.ClasseContabil;
                        updated.IsEntrada = item.IsEntrada;

                        updated.DataEmissao = item.DataEmissao;
                        updated.DataVencimento = item.DataVencimento;
                        updated.DataBaixa = item.DataBaixa;
                        updated.DataAgendamento = item.DataAgendamento;

                        updated.ValorOriginal = item.ValorOriginal;
                        updated.ValorJuros = item.ValorJuros;
                        updated.ValorMulta = item.ValorMulta;
                        updated.ValorDesconto = item.ValorDesconto;
                        updated.ValorAcrescimo = item.ValorAcrescimo;
                        updated.ValorLiquido = item.ValorLiquido;
                        updated.ValorBaixado = item.ValorBaixado;

                        //valida e salva
                        if (Validacao.IsValid(conn))
                        {
                            //salva alteracoes
                            conn.SaveChanges();

                            //atualiza a integracao
                            if (refazIntegracao)
                                UpdateIntegracao(updated);

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
                        return GetById(updated.IdLancamento);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

        }

        public void Delete(int[] ids, Utilitarios.EnumModulo modulo = Utilitarios.EnumModulo.Financeiro)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                bool hasErros = false;
                string msgErros = "Ocorreram erros ao excluir os lançamentos.\n\n";

                foreach (var id in ids)
                {
                    //recupera item do banco
                    var deleted = conn.Lancamento.FirstOrDefault(a => a.IdLancamento == id);


                    if (deleted.Pedido == null || modulo == Utilitarios.EnumModulo.Venda)
                    {
                        if (deleted.Status == Dados.EnumStatusLanc.EmAberto || deleted.Status == Dados.EnumStatusLanc.Cancelado || deleted.Status == Dados.EnumStatusLanc.AguardandoLiberacao)
                        {
                            //deleta no banco de dados
                            conn.Lancamento.Remove(deleted);

                            //salva as alterações
                            conn.SaveChanges();
                        }
                        else
                        {
                            hasErros = true;
                            msgErros += string.Format("Lançamento {0} - Lançamento com o status {1} não pode ser excluído\n", deleted.IdLancamento, deleted.Status);
                        }
                    }
                    else
                    {
                        hasErros = true;
                        msgErros += string.Format("Lançamento {0} - {1}\n", deleted.IdLancamento, "Lançamento originado do módulo de vendas");
                    }
                }


                //se existir erros retorna uma exception
                if (hasErros)
                {
                    throw new Exception(msgErros);
                }

            }
        }

        public void Cancela(int[] ids)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                bool hasErros = false;
                string msgErros = "Ocorreram erros ao cancelar os lançamentos.\n\n";

                foreach (var id in ids)
                {
                    //recupera item do banco
                    var deleted = conn.Lancamento.FirstOrDefault(a => a.IdLancamento == id);


                    if (deleted.Pedido == null)
                    {
                        if (deleted.Status == Dados.EnumStatusLanc.EmAberto)
                        {
                            //deleta no banco de dados
                            deleted.Status = Dados.EnumStatusLanc.Cancelado;

                            //salva no banco a alteração de status
                            Update(deleted, false);
                        }
                        else
                        {
                            hasErros = true;
                            msgErros += string.Format("Lançamento {0} - Lançamento com o status {1} não pode ser cancelados\n", deleted.IdLancamento, deleted.Status);
                        }
                    }
                    else
                    {
                        hasErros = true;
                        msgErros += string.Format("Lançamento {0} - {1}\n", deleted.IdLancamento, "Lançamento originado do módulo de vendas");
                    }
                }


                //se existir erros retorna uma exception
                if (hasErros)
                {
                    throw new Exception(msgErros);
                }

            }
        }

        public void Estorna(int[] ids)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                bool hasErros = false;
                string msgErros = "Ocorreram erros ao estornar os lançamentos.\n\n";

                foreach (var id in ids)
                {
                    //recupera item do banco
                    var libExtrato = new Extrato();
                    var deleted = conn.Lancamento.FirstOrDefault(a => a.IdLancamento == id);

                    if (deleted.Status == Dados.EnumStatusLanc.Baixado)
                        {
                            //deleta no banco de dados
                            deleted.ValorBaixado = null;
                            deleted.DataBaixa = null;
                            deleted.Status = Dados.EnumStatusLanc.EmAberto;

                            //salva no banco a alteração de status
                            Update(deleted, false);

                            //cria extrato de estorno
                            if (deleted.IdExtrato != null) 
                            {
                                var extrato = libExtrato.GetById(deleted.IdExtrato.GetValueOrDefault());
                                var novo = new Dados.Extrato();

                                novo.IdContaCaixa = extrato.IdContaCaixa;
                                novo.IdUsuario = extrato.IdUsuario;
                                novo.TipoPgto = extrato.TipoPgto;
                                novo.Status = Dados.EnumStatusExtrato.Estornado;
                                novo.ValorLiquido = extrato.ValorLiquido;
                                novo.ValorPago = extrato.ValorPago;
                                novo.ValorTroco = extrato.ValorTroco;
                                novo.ValorBaixado = extrato.ValorBaixado;
                                novo.Data = extrato.Data;
                                novo.Hora = extrato.Hora;

                                libExtrato.Insert(novo);
                            }
                        }
                        else
                        {
                            hasErros = true;
                            msgErros += string.Format("Lançamento {0} - Lançamento com o status {1} não pode ser cancelados\n", deleted.IdLancamento, deleted.Status);
                        }
                }


                //se existir erros retorna uma exception
                if (hasErros)
                {
                    throw new Exception(msgErros);
                }

            }
        }

        #endregion

        #region BANCO

        public BoletoBancario Boleto(Dados.Lancamento lanc)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                //resgata a conta
                var conta = conn.ContaCaixa.FirstOrDefault(a => a.IdContaCaixa == lanc.IdContaCaixa);

                //configura o cedente
                var cedente = new Cedente(conta.Conta.CedenteCnjp, conta.Conta.CedenteNome, conta.Conta.Agencia.Nome, "0", conta.Conta.ContaNumero, conta.Conta.ContaDigito);

                //configura o boleto
                Boleto boleto = new Boleto(lanc.DataVencimento, lanc.ValorLiquido, conta.Conta.CarteiraNumero, lanc.IdLancamento.ToString(), cedente);
                boleto.NumeroDocumento = lanc.IdLancamento.ToString();

                //configura o boleto bancario
                var boletoBancario = new BoletoBancario();
                boletoBancario.CodigoBanco = short.Parse(conta.Conta.Agencia.Banco.Numero);
                boletoBancario.Boleto = boleto;

                boletoBancario.Boleto.Valida();

                return boletoBancario;

            }
        }

        public void UpdateIntegracao(Dados.Lancamento lanc)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                var config = conn.Config.FirstOrDefault(a => a.IdFilial == lanc.IdFilial);
                var item = conn.Lancamento.FirstOrDefault(a => a.IdLancamento == lanc.IdLancamento);

                //atualiza a integracao bancaria
                if (config.UsaFinanceiro == true)
                {
                    var boleto = Boleto(item);
                    item.NossoNumero = item.IdLancamento.ToString().PadLeft(8, '0');
                    item.NossoNumeroDac = boleto.Boleto.NossoNumero.LastOrDefault().ToString();
                    item.CodigoBarras = boleto.Boleto.CodigoBarra.Codigo;
                    item.Ipte = boleto.Boleto.CodigoBarra.LinhaDigitavel;

                    conn.SaveChanges();
                }
                
            }
        }

        public System.Drawing.Bitmap GeraBarcode(Dados.Lancamento lanc)
        {
            return new C2of5i(lanc.CodigoBarras, 1, 50, lanc.CodigoBarras.Length).ToBitmap();
        }

        #endregion

        #region FINANCEIRO

        public decimal CalculaMulta(Dados.Lancamento lanc)
        {
            if (lanc.DataVencimento.Date < DateTime.Today)
            {
                var config = new Config().GetByFilial(lanc.IdFilial);

                return (lanc.ValorOriginal * config.Financ_Multa) / 100;
            }
            else
            {
                return 0;
            }
        }

        public decimal CalculaJuros(Dados.Lancamento lanc)
        {
            if (lanc.DataVencimento.Date < DateTime.Today)
            {
                var config = new Config().GetByFilial(lanc.IdFilial);
                var atraso = ((TimeSpan)(DateTime.Today - lanc.DataVencimento)).Days;

                return (lanc.ValorOriginal * (config.Financ_Juros * atraso)) / 100;
            }
            else
            {
                return 0;
            }
        }

        public decimal CalculaLiquido(Dados.Lancamento lanc)
        {
            return lanc.ValorOriginal + CalculaMulta(lanc) + CalculaJuros(lanc) + lanc.ValorAcrescimo - lanc.ValorDesconto;
        }

        #endregion

        #region CALCULO


        public static decimal CalculaPorcentagemOfValue(decimal valor, decimal valorBruto)
        {
            if (valorBruto == 0)
                return 0;

            return (valor * 100) / valorBruto;
        }

        public static decimal CalculaValorOfPorcentagem(decimal valor, decimal porcentagem)
        {
            return (valor * porcentagem) / 100;
        }

        #endregion
    }

    public class LancamentoGridModel
    {
        public int Codigo { get; set; }
        public System.Drawing.Bitmap Tipo { get; set; }
        public System.Drawing.Bitmap Status { get; set; }
        public System.Drawing.Bitmap StatusVenc { get; set; }
        public string Filial { get; set; }
        public string Nome { get; set; }
        public string Emissao { get; set; }
        public string Vencimento { get; set; }
        public string Baixa { get; set; }
        public decimal Original { get; set; }
        public decimal Baixado { get; set; }
        public bool Entrada { get; set; }
    }
}
