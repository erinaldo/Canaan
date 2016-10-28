using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class VendaEvento : IBase<Dados.VendaEvento>
    {
        public List<Dados.VendaEvento> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.VendaEvento
                           .Include(a => a.Venda)
                           .Include(a => a.Evento)
                           .Include(a => a.Evento.Parceria)
                           .ToList();
            }
        }

        public Dados.VendaEvento GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.VendaEvento
                           .Include(a => a.Venda)
                           .Include(a => a.Evento)
                           .Include(a => a.Evento.Parceria)
                           .FirstOrDefault(a => a.IdVendaEvento == id);
            }
        }

        public List<Dados.VendaEvento> GetByNome(string nome)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.VendaEvento
                           .Include(a => a.Venda)
                           .Include(a => a.Evento)
                           .Include(a => a.Evento.Parceria)
                           .Where(a => a.Evento.Nome.Contains(nome))
                           .ToList();
            }
        }

        public List<Dados.VendaEvento> GetByVenda(int idPedido)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.VendaEvento
                           .Include(a => a.Venda)
                           .Include(a => a.Evento)
                           .Include(a => a.Evento.Parceria)
                           .Where(a => a.IdPedido == idPedido)
                           .ToList();
            }
        }

        public Dados.VendaEvento Insert(Dados.VendaEvento item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.VendaEvento.Add(item);

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
                    return GetById(item.IdVendaEvento);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.VendaEvento Update(Dados.VendaEvento item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.VendaEvento.FirstOrDefault(a => a.IdVendaEvento == item.IdVendaEvento);

                    //atualiza dados
                    updated.IdEvento = item.IdEvento;
                    updated.IdPedido = item.IdPedido;
                    updated.DataInicio = item.DataInicio;
                    updated.DataFim = item.DataFim;
                    updated.Descricao = item.Descricao;
                    updated.IsAgendamento = item.IsAgendamento;

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
                    return GetById(updated.IdVendaEvento);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.VendaEvento Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.VendaEvento.FirstOrDefault(a => a.IdVendaEvento == id);

                    //salva no banco de dados
                    conn.VendaEvento.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.VendaEvento> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdVendaEvento,
                IdEvento = a.IdEvento,
                IdVenda = a.IdPedido,
                Evento = a.Evento.Nome,
                Parceria = a.Evento.Parceria.Nome,
                DataInicio = a.DataInicio,
                DataFim = a.DataFim,
                Descricao = a.Descricao.Replace(Environment.NewLine, " - ")
            }).ToList();
        }

        public List<Dados.VendaEvento> Filter(string filtro, object[] parameters)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.VendaEvento.Where(filtro, parameters).ToList();
            }
        }
    }
}
