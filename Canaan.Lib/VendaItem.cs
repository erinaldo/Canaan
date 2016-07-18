using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Canaan.Lib
{
    public class VendaItem : IBase<Dados.VendaItem>
    {
        public List<Dados.VendaItem> Get()
        {
            throw new NotImplementedException();
        }

        public List<Dados.VendaItem> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.VendaItem> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.VendaItem GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.VendaItem.Include(a => a.Venda)
                                     .Include(a => a.Produto)
                                     .FirstOrDefault(a => a.IdItem == id);
            }
        }

        public Dados.VendaItem Insert(Dados.VendaItem item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.VendaItem.Add(item);

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

        public Dados.VendaItem Update(Dados.VendaItem item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.VendaItem
                                      .FirstOrDefault(a => a.IdItem == item.IdItem);


                    //atualiza dados
                    updated.IdItem = item.IdItem;
                    updated.IdPedido = item.IdPedido;
                    updated.IdProduto = item.IdProduto;
                    updated.Quant = item.Quant;
                    updated.ValorUnitario = item.ValorUnitario;
                    updated.ValorTotal = item.ValorTotal;


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
                    return GetById(updated.IdItem);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.VendaItem Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.VendaItem.FirstOrDefault(a => a.IdItem == id);

                    //salva no banco de dados
                    conn.VendaItem.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.VendaItem> lista)
        {
            return lista.Select(a => new Model.VendaItem
            {
                Codigo = a.IdItem,
                IdProduto = a.IdProduto,
                IdVenda = a.IdPedido,
                Produto = a.Produto.Nome,
                Prod = a.Produto,
                Quantidade = a.Quant,
                Valor = a.ValorTotal.GetValueOrDefault().ToString("c"),
                Data = a.Venda.Data,
                Status = a.Venda.Status,
                Servicos = a.Produto.ProdutoServico.Where(b => b.Produto.IdProduto == b.IdProduto)
                .Select(b => b.Servico).ToList()
            }).ToList();
        }

        public List<Dados.VendaItem> GetByVenda(int idVenda)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.VendaItem
                    .Include(a => a.Venda)
                    .Include(a => a.Produto)
                    .Include(a => a.Produto.ProdutoServico)
                    .Include("Produto.ProdutoServico.Servico")
                    .Where(a => a.IdPedido == idVenda).ToList();
            }
        }

        public bool CanInsert(int idVenda, int idProduto)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return !conn.VendaItem.Any(a => a.IdProduto == idProduto && a.IdPedido == idVenda);
            }
        }
    }
}
