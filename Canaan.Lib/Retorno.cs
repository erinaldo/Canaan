using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Dynamic;
using System.IO;

namespace Canaan.Lib
{
    public class Retorno : IBase<Dados.Retorno>
    {
        public List<Dados.Retorno> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer()) 
            {
                return conn.Retorno
                           .Include(a => a.Filial)
                           .Include(a => a.ContaCaixa)
                           .Include(a => a.Usuario)
                           .Include(a => a.RetornoLog)
                           .ToList();
            }
        }

        public List<Dados.Retorno> GetByNome(string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Retorno
                           .Include(a => a.Filial)
                           .Include(a => a.ContaCaixa)
                           .Include(a => a.Usuario)
                           .Include(a => a.RetornoLog)
                           .Where(a => a.Filial.NomeFantasia.Contains(nome))
                           .ToList();
            }
        }

        public List<Dados.RetornoLog> GetLogByRetorno(int idRetorno) 
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.RetornoLog.Where(a => a.IdRetorno == idRetorno).ToList();
            }
        }

        public List<Dados.Retorno> Filter(string filtro, object[] parameters)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Retorno
                           .Include(a => a.Filial)
                           .Include(a => a.ContaCaixa)
                           .Include(a => a.Usuario)
                           .Include(a => a.RetornoLog)
                           .Where(filtro, parameters).ToList();
            }
        }

        public Dados.Retorno GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Retorno
                           .Include(a => a.Filial)
                           .Include(a => a.ContaCaixa)
                           .Include(a => a.Usuario)
                           .Include(a => a.RetornoLog)
                           .FirstOrDefault(a => a.IdRetorno == id);
            }
        }

        public BoletoNet.ArquivoRetornoCNAB400 LerRetorno(int contaCaixa, string filename) 
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                var contacaixa = conn.ContaCaixa.FirstOrDefault(a => a.IdContaCaixa == contaCaixa);
                var banco = int.Parse(contacaixa.Conta.Agencia.Banco.Numero);

                BoletoNet.ArquivoRetornoCNAB400 arquivo = new BoletoNet.ArquivoRetornoCNAB400();
                arquivo.LerArquivoRetorno(new BoletoNet.Banco(banco), File.OpenRead(filename));
                return arquivo;
            }
        }

        public Dados.RetornoLog CriaLog(int filial, Dados.Lancamento lanc, BoletoNet.DetalheRetorno item, Dados.Usuario usuario) 
        {
            Dados.RetornoLog log = new Dados.RetornoLog();

            //verifica se o lancamento existe
            if (lanc != null)
            {
                //verifica status em aberto
                if (lanc.Status == Dados.EnumStatusLanc.EmAberto)
                {
                    var pago = item.ValorPago + item.TarifaCobranca;

                    if (pago >= lanc.ValorOriginal)
                    {
                        //configura log status
                        log.StatusLog = Dados.EnumRetornoLog.Baixado;
                        log.Documento = lanc.IdLancamento.ToString();
                        log.NossoNumero = item.NossoNumero;
                        log.ValorPago = item.ValorPago;
                        log.Informacao = string.Format("Lancamento {0} baixado", lanc.IdLancamento);
                        log.IsErro = false;
                    }
                    else
                    {
                        var confirm = string.Format(@"O valor pago é menor que o valor do lançamento.\nValor pago: {0:c}\nValor lancamento: {1:c}.\n\nDeseja baixar o lancamento?", pago, lanc.ValorOriginal);

                        if (MessageBoxUtilities.MessageQuestion(confirm) == System.Windows.Forms.DialogResult.Yes)
                        {
                            //configura log status
                            log.StatusLog = Dados.EnumRetornoLog.BaixadoPeloUsuario;
                            log.Documento = lanc.IdLancamento.ToString();
                            log.NossoNumero = item.NossoNumero;
                            log.ValorPago = item.ValorPago;
                            log.Informacao = string.Format("Lancamento {0} baixado com autorização do usuario {1}", lanc.IdLancamento, usuario.Nome);
                            log.IsErro = false;
                        }
                        else
                        {
                            //configura log status
                            log.StatusLog = Dados.EnumRetornoLog.ValorPagoMenor;
                            log.Documento = lanc.IdLancamento.ToString();
                            log.NossoNumero = item.NossoNumero;
                            log.ValorPago = item.ValorPago;
                            log.Informacao = string.Format("Valor do lancamento {0} ({1:c}) é maior que o valor pago {2:c}", lanc.IdLancamento, lanc.ValorOriginal, pago);
                            log.IsErro = true;
                        }

                    }
                }
                else
                {
                    //configura log status
                    log.StatusLog = Dados.EnumRetornoLog.LancamentoStatus;
                    log.Documento = lanc.IdLancamento.ToString();
                    log.NossoNumero = item.NossoNumero;
                    log.ValorPago = item.ValorPago;
                    log.Informacao = string.Format("Lancamento {0} está com o status {1}", lanc.IdLancamento, lanc.Status);
                    log.IsErro = true;
                }
            }
            else
            {
                //configura log nao encontrado
                log.StatusLog = Dados.EnumRetornoLog.NaoEncontrado;
                log.Documento = "Nenhum";
                log.NossoNumero = item.NossoNumero;
                log.ValorPago = item.ValorPago;
                log.Informacao = string.Format("Nenhum lancamento encontrado para o nosso numero {0}", item.NossoNumero);
                log.IsErro = true;
            }

            return log;
        }

        public Dados.Retorno Insert(Dados.Retorno item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Retorno.Add(item);

                    //valida e salva
                    if (Validacao.IsValid(conn))
                    {
                        conn.SaveChanges();
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return GetById(item.IdRetorno);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Retorno Update(Dados.Retorno item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Retorno.FirstOrDefault(a => a.IdRetorno == item.IdRetorno);

                    //atualiza dados
                    updated.IdFilial = item.IdFilial;
                    updated.IdContaCaixa = item.IdFilial;
                    updated.IdUsuario = item.IdUsuario;
                    updated.Data = item.Data;
                    updated.Arquivo = item.Arquivo;

                    //valida e salva
                    if (Validacao.IsValid(conn))
                    {
                        conn.SaveChanges();
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return GetById(updated.IdRetorno);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Retorno Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.Retorno.FirstOrDefault(a => a.IdRetorno == id);

                    //salva no banco de dados
                    conn.Retorno.Remove(deleted);
                    conn.SaveChanges();

                    //retorna
                    return deleted;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public dynamic CarregaGrid(List<Dados.Retorno> lista)
        {
            if (lista != null)
            {
                return lista.Select(a => new
                {
                    Codigo = a.IdRetorno,
                    Filial = a.Filial.NomeFantasia,
                    ContaCaixa = a.ContaCaixa.Nome,
                    Usuario = a.Usuario.Nome,
                    Data = a.Data,
                    Arquivo = a.Arquivo,
                    Registros = a.RetornoLog.Count,
                    Erros = a.RetornoLog.Where(b => b.IsErro == true).Count()
                }).ToList();
            }
            else
            {
                return null;
            }
        }
    }
}
