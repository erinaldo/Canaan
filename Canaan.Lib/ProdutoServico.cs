using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Canaan.Lib
{
    public class ProdutoServico : IBase<Dados.ProdutoServico>
    {
        public List<Dados.ProdutoServico> Get()
        {
            throw new NotImplementedException();
        }

        public List<Dados.ProdutoServico> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.ProdutoServico> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.ProdutoServico GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.ProdutoServico.FirstOrDefault(a => a.IdComposicao == id);
            }
        }

        public Dados.ProdutoServico Insert(Dados.ProdutoServico item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {

                    if (GetByProdutoServico(item.IdServico, item.IdProduto).Count <= 0)
                    {
                        //salva no banco de dados
                        conn.ProdutoServico.Add(item);

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
                        return GetById(item.IdComposicao);
                    }
                    else
                    {
                        throw new Exception("Este serviço já está vinculado a este produto");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.ProdutoServico Update(Dados.ProdutoServico item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.ProdutoServico
                                      .FirstOrDefault(a => a.IdServico == item.IdServico);

                    updated.IdServico = item.IdServico;
                    updated.IdProduto = item.IdProduto;

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
                    return GetById(updated.IdComposicao);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.ProdutoServico Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.ProdutoServico.FirstOrDefault(a => a.IdComposicao == id);

                    //salva no banco de dados
                    conn.ProdutoServico.Remove(deleted);
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

        public List<Dados.ProdutoServico> GetByProdutoServico(int idServico, int idProduto)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.ProdutoServico.Include(a => a.Servico).Where(a => a.IdProduto == idProduto && a.IdServico == idServico).ToList();
            }
        }

        public dynamic CarregaGrid(List<Dados.ProdutoServico> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdComposicao,
                Produto = a.Servico.Nome,
                Quantidade = a.Quantidade
            }).ToList();
        }

        public List<Model.ProdutoServico> CarregaGridModel(List<Dados.ProdutoServico> lista)
        {
            return lista.Select(a => new Model.ProdutoServico
            {
                Codigo = a.IdComposicao,
                Servico = a.Servico.Nome,
                IdProduto = a.IdProduto,
                IdServico = a.IdServico,
                Quantidade = a.Quantidade
            }).ToList();
        }

        public List<Dados.ProdutoServico> GetByProduto(int idProduto)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.ProdutoServico.Include(a => a.Servico).Where(a => a.IdProduto == idProduto).ToList();
            }
        }
    }
}
