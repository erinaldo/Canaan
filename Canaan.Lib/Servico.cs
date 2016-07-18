using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;
using System.Data.Entity;

namespace Canaan.Lib
{
    public class Servico : IBase<Dados.Servico>
    {
        public List<Dados.Servico> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Servico.ToList();
            }
        }

        public List<Dados.Servico> GetByNome(string nome)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Servico.Where(a => a.Nome.Contains(nome) && a.IsAtivo).ToList();
            }
        }

        public List<Dados.Servico> Filter(string filtro, object[] parameters)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Servico.Where(filtro, parameters).ToList();
            }
        }

        public Dados.Servico GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Servico.FirstOrDefault(a => a.IdServico == id);
            }
        }

        public Dados.Servico Insert(Dados.Servico item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Servico.Add(item);

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
                    return GetById(item.IdServico);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Servico Update(Dados.Servico item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Servico
                                      .FirstOrDefault(a => a.IdServico == item.IdServico);

                    updated.IdServico = item.IdServico;
                    updated.Nome = item.Nome;
                    updated.Descricao = item.Descricao;
                    updated.PrevisaoEntrega = item.PrevisaoEntrega;
                    updated.HasAlbum = item.HasAlbum;
                    updated.HasMoldura = item.HasMoldura;
                    updated.HasVoltagem = item.HasVoltagem;
                    updated.IsBrindeCpc = item.IsBrindeCpc;
                    updated.IsAtivo = item.IsAtivo;
                    updated.IsEnvio = item.IsEnvio;



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
                    return GetById(updated.IdServico);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Servico Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.Servico.FirstOrDefault(a => a.IdServico == id);

                    //salva no banco de dados
                    conn.Servico.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.Servico> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdServico,
                Servico = a.Nome,
                Album = a.HasAlbum,
                Moldura = a.HasMoldura,
                Voltagem = a.HasVoltagem,
                Status = a.IsAtivo
            }).ToList();
        }

        public List<Model.Servico> CarregaGridModel(List<Dados.Servico> lista, int idProduto)
        {
            return lista.Select(a => new Model.Servico
            {
                IdServico = a.IdServico,
                Nome = a.Nome,
                Previsao = a.PrevisaoEntrega,
                Album = a.HasAlbum,
                Moldura = a.HasMoldura,
                Voltagem = a.HasVoltagem,
                Brinde = a.IsBrindeCpc,
                Ativo = a.IsAtivo
            }).ToList();
        }

        public List<Dados.Servico> GetByStatus(bool status)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Servico.Where(a => a.IsAtivo == status).ToList();
            }
        }

        public List<Model.ProdutoServico> GetByProduto(int idProduto)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.ProdutoServico.Where(a => a.IdProduto == idProduto).Select(a => new Model.ProdutoServico
                {
                    Codigo = a.IdComposicao,
                    IdProduto = a.IdProduto,
                    IdServico = a.IdServico,
                    Servico = a.Servico.Nome,
                    Produto = a.Produto.Nome,
                    Previsao = a.Servico.PrevisaoEntrega,
                    Quantidade = a.Quantidade,
                }).ToList();
            }
        }
    }
}
