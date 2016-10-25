using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;
using System.Data.Entity;

namespace Canaan.Lib
{
    public class Produto : IBase<Dados.Produto>
    {

        public List<Dados.Produto> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Produto.ToList();
            }
        }

        public List<Dados.Produto> GetByNome(string nome)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Produto.Where(a => a.Nome.Contains(nome)).ToList();
            }
        }

        public List<Dados.Produto> Filter(string filtro, object[] parameters)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Produto.Where(filtro, parameters).ToList();
            }
        }

        public Dados.Produto GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Produto.Include(a => a.Tabela).FirstOrDefault(a => a.IdProduto == id);
            }
        }

        public Dados.Produto Insert(Dados.Produto item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Produto.Add(item);

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
                    return GetById(item.IdProduto);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Produto Update(Dados.Produto item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Produto
                                      .FirstOrDefault(a => a.IdProduto == item.IdProduto);

                    //atualiza dados
                    updated.IdTabela = item.IdTabela;
                    updated.Nome = item.Nome;
                    updated.Descricao = item.Descricao;
                    updated.Valor = item.Valor;
                    updated.Custo = item.Custo;
                    updated.IsAtivo = item.IsAtivo;

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
                    return GetById(updated.IdProduto);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Produto Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.Produto.FirstOrDefault(a => a.IdProduto == id);

                    //salva no banco de dados
                    conn.Produto.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.Produto> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdProduto,
                Produto = a.Nome,
                Tabela = a.Tabela.Nome,
                Valor = a.Valor.Value.ToString("c"),
                Custo = a.Custo.Value.ToString("c"),
                Status = a.IsAtivo
            }).ToList();
        }

        public List<Dados.Produto> GetByTabela(int idTabela)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Produto.Include(a => a.Tabela).Where(a => a.IdTabela == idTabela && a.IsAtivo == true).OrderBy(a => a.Nome).ToList();
            }
        }

        public List<Dados.Produto> GetByTabelaAndNome(int idTabela, string nome)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Produto.Include(a => a.Tabela)
                                   .Include(a => a.ProdutoServico)
                                   .Include("ProdutoServico.Servico")
                                   .Where(a => a.IdTabela == idTabela && a.Nome.Contains(nome) && a.IsAtivo)
                                   .ToList();
            }
        }

        public List<Model.Produto> CarregaGridModel(List<Dados.Produto> lista)
        {
            return lista.Select(a => new Model.Produto
            {
                Codigo = a.IdProduto,
                Nome = a.Nome,
                Tabela = a.Tabela.Nome,
                Valor = a.Valor.Value.ToString("c"),
                Status = a.IsAtivo,
                Prod = a,
            }).ToList();
        }

        public Dados.VendaItem GetByOrdem(int idOrdemServico)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.VendaItem.FirstOrDefault(a => a.VendaItemOrdemServico.Any(b => b.IdOrdemServico == idOrdemServico));
            }
        }
    }
}
