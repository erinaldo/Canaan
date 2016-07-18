using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class Banco : IBase<Dados.Banco>
    {
        public List<Dados.Banco> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Banco.ToList();
            }
        }

        public List<Dados.Banco> GetByNome(string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Banco.Where(a => a.Nome.Contains(nome)).ToList();
            }
        }

        public List<Dados.Banco> Filter(string filtro, object[] parameters)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Banco.Where(filtro, parameters).ToList();
            }
        }
        
        public Dados.Banco GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Banco.FirstOrDefault(a => a.IdBanco == id);
            }
        }

        public Dados.Banco Insert(Dados.Banco item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Banco.Add(item);

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
                    return GetById(item.IdBanco);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Banco Update(Dados.Banco item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Banco.FirstOrDefault(a => a.IdBanco == item.IdBanco);

                    //atualiza dados
                    updated.Nome = item.Nome;
                    updated.Abreviacao = item.Abreviacao;
                    updated.Numero = item.Numero;
                    updated.Digito = item.Digito;
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
                    return GetById(updated.IdBanco);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Banco Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.Banco.FirstOrDefault(a => a.IdBanco == id);

                    //salva no banco de dados
                    conn.Banco.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.Banco> lista)
        {
            if (lista != null)
            {
                return lista.Select(a => new { 
                    Codigo = a.IdBanco,
                    Nome = a.Nome,
                    Abreviacao = a.Abreviacao,
                    Numero = a.Numero,
                    Digito = a.Digito,
                    Ativo = a.IsAtivo
                }).ToList();
            }
            else 
            {
                return null;
            }
        }
    }
}
