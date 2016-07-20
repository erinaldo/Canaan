using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Canaan.Dados;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class Pasta : IBase<Dados.Pasta>
    {
        public List<Dados.Pasta> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Pasta.ToList();
            }
        }

        public Dados.Pasta GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Pasta.FirstOrDefault(a => a.IdPasta == id);
            }
        }

        public List<Dados.Pasta> GetByNome(string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Pasta.Where(a => a.Nome.Contains(nome)).ToList();
            }
        }
        

        public Dados.Pasta Insert(Dados.Pasta item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Pasta.Add(item);

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
                    return GetById(item.IdPasta);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Pasta Update(Dados.Pasta item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Pasta
                                      .FirstOrDefault(a => a.IdPasta == item.IdPasta);

                    //atualiza dados
                    updated.IdPasta = item.IdPasta;
                    updated.Nome = item.Nome;
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
                    return GetById(updated.IdPasta);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Pasta Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.Pasta.FirstOrDefault(a => a.IdPasta == id);

                    //salva no banco de dados
                    conn.Pasta.Remove(deleted);
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

        
        public dynamic CarregaGrid(List<Dados.Pasta> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdPasta,
                Nome = a.Nome,
                Padrao = a.IsDefault
            }).ToList();
        }

        public List<Dados.Pasta> Filter(string filtro, object[] parameters)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Pasta.Where(filtro, parameters).ToList();
            }
        }
    }
}
