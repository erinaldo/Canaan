using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class Agencia : IBase<Dados.Agencia>
    {
        public List<Dados.Agencia> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer()) 
            {
                return conn.Agencia.Include(a => a.Banco)
                                   .Include(a => a.Cidade)
                                   .ToList();
            }
        }

        public List<Dados.Agencia> GetByBanco(int idBanco)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Agencia.Include(a => a.Banco)
                                   .Include(a => a.Cidade)
                                   .Where(a => a.IdBanco == idBanco)
                                   .ToList();
            }
        }

        public List<Dados.Agencia> GetByNome(string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Agencia.Include(a => a.Banco)
                                   .Include(a => a.Cidade)
                                   .Where(a => a.Nome.Contains(nome))
                                   .ToList();
            }
        }

        public List<Dados.Agencia> Filter(string filtro, object[] parameters)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Agencia.Include(a => a.Cidade).Include(a => a.Banco).Where(filtro, parameters).ToList();
            }
        }

        public Dados.Agencia GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Agencia.Include(a => a.Banco)
                                   .Include(a => a.Cidade)
                                   .FirstOrDefault(a => a.IdAgencia == id);
            }
        }

        public Dados.Agencia Insert(Dados.Agencia item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Agencia.Add(item);

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
                    return GetById(item.IdAgencia);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Agencia Update(Dados.Agencia item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Agencia.FirstOrDefault(a => a.IdAgencia == item.IdAgencia);

                    //atualiza dados
                    updated.IdBanco = item.IdBanco;
                    updated.IdCidade = item.IdCidade;
                    updated.Nome = item.Nome;
                    updated.Telefone = item.Telefone;
                    updated.Celular = item.Celular;
                    updated.Gerente = item.Gerente;
                    updated.Email = item.Email;
                    updated.IsAtivo = item.IsAtivo;

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
                    return GetById(updated.IdAgencia);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Agencia Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.Agencia.FirstOrDefault(a => a.IdAgencia == id);

                    //salva no banco de dados
                    conn.Agencia.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.Agencia> lista)
        {
            if (lista != null)
            {
                return lista.Select(a => new
                {
                    Codigo = a.IdAgencia,
                    Banco = a.Banco.Nome,
                    Nome = a.Nome,
                    Cidade = a.Cidade.Nome,
                    Telefone = a.Telefone,
                    Gerente = a.Gerente,
                    Ativo = a.IsAtivo
                })
                .ToList();
            }
            else
            {
                return null;
            }
        }
    }
}
