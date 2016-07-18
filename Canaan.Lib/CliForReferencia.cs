using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class CliForReferencia : IBase<Dados.CliForReferencia>
    {
        public List<Dados.CliForReferencia> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer()) 
            {
                return conn.CliForReferencia.ToList();
            }
        }

        public List<Dados.CliForReferencia> GetByCliente(int idCliente)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.CliForReferencia.Where(a => a.IdCliFor == idCliente).ToList();
            }
        }

        public List<Dados.CliForReferencia> GetByNome(string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.CliForReferencia.Where(a => a.Nome.Contains(nome)).ToList();
            }
        }

        public List<Dados.CliForReferencia> Filter(string filtro, object[] parameters)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.CliForReferencia.Where(filtro, parameters).ToList();
            }
        }

        public Dados.CliForReferencia GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.CliForReferencia.FirstOrDefault(a => a.IdReferencia == id);
            }
        }

        public Dados.CliForReferencia Insert(Dados.CliForReferencia item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.CliForReferencia.Add(item);

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
                    return GetById(item.IdReferencia);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.CliForReferencia Update(Dados.CliForReferencia item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.CliForReferencia.FirstOrDefault(a => a.IdReferencia == item.IdReferencia);

                    //atualiza dados
                    updated.IdCliFor = item.IdCliFor;
                    updated.Tipo = item.Tipo;
                    updated.Nome = item.Nome;
                    updated.Endereco = item.Endereco;
                    updated.Telefone = item.Telefone;
                    updated.Celular = item.Celular;

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
                    return GetById(updated.IdReferencia);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.CliForReferencia Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.CliForReferencia.FirstOrDefault(a => a.IdReferencia == id);

                    //salva no banco de dados
                    conn.CliForReferencia.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.CliForReferencia> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdReferencia,
                Nome = a.Nome,
                Telefone = a.Telefone,
                Celular = a.Celular
            }).ToList();
        }
    }
}
