using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class Agenda : IBase<Dados.Agenda>
    {
        public List<Dados.Agenda> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Agenda.Include(a => a.Filial).ToList();
            }
        }

        public List<Dados.Agenda> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public Dados.Agenda GetByFilial(bool status, int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Agenda.Include(a => a.Filial).FirstOrDefault(a => a.IsAtivo == status && a.IdFilial == idFilial);
            }
        }

        public List<Dados.Agenda> Filter(string filtro, object[] parameters)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Agenda.Include(a => a.Filial).Where(filtro, parameters).ToList();
            }
        }

        public Dados.Agenda GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Agenda.Include(a => a.Filial).FirstOrDefault(a => a.IdAgenda == id);
            }
        }

        public Dados.Agenda Insert(Dados.Agenda item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Agenda.Add(item);

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
                    return GetById(item.IdAgenda);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Agenda Update(Dados.Agenda item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Agenda
                                      .FirstOrDefault(a => a.IdAgenda == item.IdAgenda);

                    //atualiza dados
                    updated.IdAgenda = item.IdAgenda;
                    updated.Distancia = item.Distancia;
                    updated.SegInicio = item.SegInicio;
                    updated.SegFim = item.SegFim;
                    updated.TerInicio = item.TerInicio;
                    updated.TerFim = item.TerFim;
                    updated.QuaInicio = item.QuaInicio;
                    updated.QuaFim = item.QuaFim;
                    updated.QuiInicio = item.QuiInicio;
                    updated.QuiFim = item.QuiFim;
                    updated.SexInicio = item.SexInicio;
                    updated.SexFim = item.SexFim;
                    updated.SabInicio = item.SabInicio;
                    updated.SabFim = item.SabFim;
                    updated.DomInicio = item.DomInicio;
                    updated.DomFim = item.DomFim;
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
                    return GetById(updated.IdAgenda);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Agenda Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.Agenda> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdAgenda,
                Distancia = a.Distancia,
                DataPreenchimento = a.IsAtivo
            }).ToList();
        }
    }
}
