using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Canaan.Lib
{
    public class OrdemServicoItem : IBase<Dados.OrdemServicoItem>
    {
        public List<Dados.OrdemServicoItem> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.OrdemServicoItem.ToList();
            }
        }

        public List<Dados.OrdemServicoItem> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.OrdemServicoItem> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.OrdemServicoItem GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.OrdemServicoItem.Include(a => a.EfeitoDigital).Include(a => a.Foto).FirstOrDefault(a => a.IdItem == id);
            }
        }

        public Dados.OrdemServicoItem Insert(Dados.OrdemServicoItem item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.OrdemServicoItem.Add(item);

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
                    return GetById(item.IdItem);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.OrdemServicoItem Update(Dados.OrdemServicoItem item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.OrdemServicoItem
                                      .FirstOrDefault(a => a.IdItem == item.IdItem);

                   updated.IdItem = item.IdItem;
                   updated.IdOrdemServico = item.IdOrdemServico;
                   updated.IdFoto = item.IdFoto;
                   updated.IdEfeito = item.IdEfeito;
                   updated.Quantidade = item.Quantidade;
                   updated.Observacao = item.Observacao;

                    //validaupdated.imal Custo {  e salva
                    if (Validacao.IsValid(conn))
                    {
                        conn.SaveChanges();
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return GetById(updated.IdOrdemServico);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.OrdemServicoItem Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.OrdemServicoItem.FirstOrDefault(a => a.IdItem == id);

                    //salva no banco de dados
                    conn.OrdemServicoItem.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.OrdemServicoItem> lista)
        {
            throw new NotImplementedException();
        }

        public Dados.OrdemServicoItem GetByImgAndOrdemServico(int idFoto, int idOrdemServico)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.OrdemServicoItem.Include(a => a.Foto).FirstOrDefault(a => a.IdFoto == idFoto && a.IdOrdemServico == idOrdemServico);
            }
        }

        public List<Dados.OrdemServicoItem> GetByOrdemServico(int idOrdemServico)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.OrdemServicoItem.Include(a => a.Foto)
                    .Include(a => a.Foto.OrdemServicoItem)
                    .Where(a => a.IdOrdemServico == idOrdemServico)
                    .ToList();
            }
        }

        public int GetCountArquivos(int[] listaVendas)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.OrdemServicoItem.Where(a => listaVendas.Contains(a.OrdemServico.Pedido_Venda.IdPedido))
                                            .GroupBy(a => a.Foto).Select(a => a.FirstOrDefault())
                                            .Count();
            }
        }

        public List<IGrouping<Dados.Venda, Dados.OrdemServicoItem>> GetByListVendaGroupAtendimento(int[] listaVenda)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var result = conn.OrdemServicoItem
                                  .Include(a => a.Foto)
                                  .Include(a => a.OrdemServico.Pedido_Venda.Atendimento)
                                  .Where(a => listaVenda.Contains(a.OrdemServico.IdPedido))
                                  .ToList()
                                  .GroupBy(a => a.OrdemServico.Pedido_Venda)
                                  .ToList();


                //var result = conn.OrdemServicoItem.Where(a => listaVenda.Contains(a.OrdemServico.IdPedido))                                                    
                //                                  .Include(a => a.Foto)
                //                                  .ToList()
                //                                  .GroupBy(a => a.OrdemServico.Pedido_Venda.Atendimento)
                //                                  .ToList();

                return result;
            }
        }

        public int GetCountPacotes(int[] listaVenda)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var result = conn.OrdemServicoItem
                                            .Include(a => a.Foto)
                                            .Where(a => listaVenda.Contains(a.OrdemServico.IdPedido))
                                            .ToList()
                                            .GroupBy(a => a.OrdemServico)
                                            .ToList();

                return result.Count;
            }
        }

        public int GetTotalImagensEnvio(int[] listaVenda)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var result = conn.OrdemServicoItem.Where(a => listaVenda.Contains(a.OrdemServico.IdPedido)).GroupBy(a => a.Foto).Select(a => a.FirstOrDefault()).Count();
                return result;
            }
        }
    }
}
