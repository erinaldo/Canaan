using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Canaan.Dados;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class SessaoPasta : IBase<Dados.SessaoPasta>
    {
        public List<Dados.SessaoPasta> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.SessaoPasta.ToList();
            }
        }

        public Dados.SessaoPasta GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.SessaoPasta.FirstOrDefault(a => a.IdSessaoPasta == id);
            }
        }

        public List<Dados.SessaoPasta> GetBySessao(int idSessao)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.SessaoPasta.Where(a => a.IdSessao == idSessao).ToList();
            }
        }

        public List<Dados.SessaoPasta> GetByNome(string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.SessaoPasta.Where(a => a.Nome.Contains(nome)).ToList();
            }
        }

        public List<Dados.SessaoPasta> GetByNome(int idSessao, string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.SessaoPasta.Where(a => a.IdSessao == idSessao && a.Nome.Contains(nome)).ToList();
            }
        }



        public Dados.SessaoPasta Insert(Dados.SessaoPasta item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.SessaoPasta.Add(item);

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
                    return GetById(item.IdSessaoPasta);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.SessaoPasta Update(Dados.SessaoPasta item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.SessaoPasta.FirstOrDefault(a => a.IdSessaoPasta == item.IdSessaoPasta);

                    //atualiza dados
                    updated.IdSessao = item.IdSessao;
                    updated.IdPastaPai = item.IdPastaPai;
                    updated.Nome = item.Nome;
                    updated.Caminho = item.Caminho;
                    updated.IsDefault = item.IsDefault;

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
                    return GetById(updated.IdSessaoPasta);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.SessaoPasta Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.SessaoPasta.FirstOrDefault(a => a.IdSessaoPasta == id);

                    //salva no banco de dados
                    conn.SessaoPasta.Remove(deleted);
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



        public dynamic CarregaGrid(List<Dados.SessaoPasta> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdSessaoPasta,
                Sessao = a.IdSessao,
                Pai = a.IdPastaPai,
                Nome = a.Nome,
                Padrao = a.IsDefault
            }).ToList();
        }

        public List<Dados.SessaoPasta> Filter(string filtro, object[] parameters)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.SessaoPasta.Where(filtro, parameters).ToList();
            }
        }        
    }
}
