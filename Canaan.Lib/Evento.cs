using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Canaan.Dados;
using System.Data.Entity;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class Evento : IBase<Dados.Evento>
    {
        public List<Dados.Evento> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Evento
                           .Include(a => a.Parceria)
                           .Include(a => a.Parceria.Convenio)
                           .ToList();
            }
        }

        public Dados.Evento GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Evento
                           .Include(a => a.Parceria)
                           .Include(a => a.Parceria.Convenio)
                           .FirstOrDefault(a => a.IdEvento == id);
            }
        }

        public List<Dados.Evento> GetByFilial(int idFilial)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Evento
                           .Include(a => a.Parceria)
                           .Include(a => a.Parceria.Convenio)
                           .Where(a => a.Parceria.IdFilial == idFilial)
                           .ToList();
            }
        }

        public List<Dados.Evento> GetByNome(string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Evento
                           .Include(a => a.Parceria)
                           .Include(a => a.Parceria.Convenio)
                           .Where(a => a.Nome.Contains(nome))
                           .ToList();
            }
        }

        public Dados.Evento Insert(Dados.Evento item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Evento.Add(item);

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
                    return GetById(item.IdEvento);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Evento Update(Dados.Evento item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Evento.FirstOrDefault(a => a.IdEvento == item.IdEvento);

                    //atualiza dados
                    updated.IdParceria = item.IdParceria;
                    updated.Nome = item.Nome;
                    updated.Descricao = item.Descricao;

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
                    return GetById(updated.IdEvento);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Evento Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.Evento.FirstOrDefault(a => a.IdEvento == id);

                    //salva no banco de dados
                    conn.Evento.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.Evento> lista)
        {
            if (lista != null)
            {
                return lista.Select(a => new {
                    Codigo = a.IdEvento,
                    Nome = a.Nome,
                    Parceria = a.Parceria.Nome
                }).ToList();
            }
            else
            {
                return null;
            }
        }

        public List<Dados.Evento> Filter(string filtro, object[] parameters)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Evento.Where(filtro, parameters).ToList();
            }
        }
    }
}
