using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Canaan.Lib
{
    public class AgendamentoMov : IBase<Dados.AgendamentoMov>, IEnum<Dados.AgendamentoMov>
    {
        public List<Dados.AgendamentoMov> Get()
        {
            throw new NotImplementedException();
        }

        public List<Dados.AgendamentoMov> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }


        public List<Dados.AgendamentoMov> GetByAgendamento(int idAgendamento)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.AgendamentoMov.Include(a => a.Agendamento).Where(a => a.IdAgendamento == idAgendamento).ToList();
            }
        }

        public List<Dados.AgendamentoMov> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.AgendamentoMov GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.AgendamentoMov.Include(a => a.Agendamento).FirstOrDefault(a => a.IdAgendamentoMov == id);
            }
        }

        public Dados.AgendamentoMov Insert(Dados.AgendamentoMov item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.AgendamentoMov.Add(item);

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
                    return GetById(item.IdAgendamentoMov);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.AgendamentoMov Insert(Dados.Agendamento item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    var agendamentoMov = new Dados.AgendamentoMov
                    {
                        IdAgendamento = item.IdAgendamento,
                        Data = DateTime.Today,
                        Hora = DateTime.Now.TimeOfDay,
                        IdUsuario = Session.Instance.Usuario.IdUsuario,
                        Status = item.Status
                    };

                    //salva no banco de dados
                    conn.AgendamentoMov.Add(agendamentoMov);

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
                    return GetById(agendamentoMov.IdAgendamentoMov);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.AgendamentoMov Update(Dados.AgendamentoMov item)
        {
            throw new NotImplementedException();
        }

        public Dados.AgendamentoMov Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.AgendamentoMov.FirstOrDefault(a => a.IdAgendamentoMov == id);

                    //deleta no banco de dados
                    conn.AgendamentoMov.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.AgendamentoMov> lista)
        {
            throw new NotImplementedException();
        }


        //
        //Enumerators

        public Dictionary<int, string> GetValuesFromEnum()
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, string> GetValuesFromEnum(string descricao)
        {
            throw new NotImplementedException();
        }

        public Dados.AgendamentoMov GetEnumForKey(int key)
        {
            throw new NotImplementedException();
        }

    }
}
