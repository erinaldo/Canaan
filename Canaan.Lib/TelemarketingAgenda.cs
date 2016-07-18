using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Canaan.Lib
{
    public class TelemarketingAgenda : IBase<Dados.TelemarketingAgenda>
    {
        private const int AGENDADO = 4;

        public List<Dados.TelemarketingAgenda> Get()
        {
            throw new NotImplementedException();
        }

        public List<Dados.TelemarketingAgenda> Get(int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.TelemarketingAgenda.Where(a => a.Cupom.Parceria.IdFilial == idFilial).ToList();
            }
        }

        public List<Dados.TelemarketingAgenda> GetByUsuarioAndFilial(int idUsuario, int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.TelemarketingAgenda.Include(a => a.Cupom)
                                               .Include(a => a.Usuario)
                                               .Include(a => a.Cupom.TelemarketingStatus)
                                               .Where(a => a.IdUsuario == idUsuario && a.Cupom.Parceria.IdFilial == idFilial && a.Cupom.IdStatusTele != null && a.Cupom.IdStatusTele == Dados.EnumTelemarketingStatus.Agendado && a.Ativo)
                                               .Take(20)
                                               .ToList();
            }
        }

        public List<Dados.TelemarketingAgenda> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.TelemarketingAgenda> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.TelemarketingAgenda GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.TelemarketingAgenda.Include(a => a.Cupom).FirstOrDefault(a => a.IdTelemarketingAgenda == id);
            }

        }

        public Dados.TelemarketingAgenda Insert(Dados.TelemarketingAgenda item)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                //salva no banco de dados
                conn.TelemarketingAgenda.Add(item);

                //valida e salva
                if (Validacao.IsValid(conn))
                {
                    conn.SaveChanges();

                    //marca o cupom como lembrete
                    var cupom = conn.Cupom.FirstOrDefault(a => a.IdCupom == item.IdCupom);
                    cupom.IsLembrete = true;
                    cupom.DataLembrete = DateTime.Now;

                    conn.SaveChanges();
                }
                else
                {
                    throw new Exception(Validacao.GetErrors(conn));
                }

                //retorna
                return GetById(item.IdTelemarketingAgenda);
            }
        }

        public Dados.TelemarketingAgenda Update(Dados.TelemarketingAgenda item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.TelemarketingAgenda
                                      .FirstOrDefault(a => a.IdTelemarketingAgenda == item.IdTelemarketingAgenda);

                    //atualiza dados
                    updated.IdCupom = item.IdCupom;
                    updated.IdUsuario = item.IdUsuario;
                    updated.Data = item.Data;
                    updated.Hora = item.Hora;
                    updated.Observacao = item.Observacao;

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
                    return GetById(updated.IdTelemarketingAgenda);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.TelemarketingAgenda Delete(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var lembrete = conn.TelemarketingAgenda.FirstOrDefault(a => a.IdTelemarketingAgenda == id);

                try
                {
                    lembrete.Ativo = false;
                    conn.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBoxUtilities.MessageError(null, ex);
                }

                return GetById(lembrete.IdTelemarketingAgenda);
            }
        }

        public Dados.TelemarketingAgenda DeleteByCupom(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var lembrete = conn.TelemarketingAgenda.FirstOrDefault(a => a.IdCupom == id);

                if (lembrete == null)
                    return null;

                try
                {
                    lembrete.Ativo = false;
                    conn.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBoxUtilities.MessageError(null, ex);
                }

                return lembrete;
            }
        }

        public dynamic CarregaGrid(List<Dados.TelemarketingAgenda> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdTelemarketingAgenda,
                Nome = a.Cupom.Nome,
                Usuario = a.Usuario.Nome,
                Data = a.Data,
                Status = a.Cupom.TelemarketingStatus.Nome
            }).ToList();
        }

        public void RemoveExceto(int idAgendamento, int idCupom)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var result = conn.TelemarketingAgenda.Where(a => a.IdTelemarketingAgenda != idAgendamento && a.IdCupom == idCupom);

                foreach (var item in result)
                {
                    conn.TelemarketingAgenda.Remove(item);
                }

                conn.SaveChanges();
            }
        }

        public List<Dados.TelemarketingAgenda> GetByFilial(int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.TelemarketingAgenda.Include(a => a.Cupom)
                                               .Include(a => a.Usuario)
                                               .Include(a => a.Cupom.TelemarketingStatus)
                                               .Take(20)
                                               .Where(a => a.Cupom.Parceria.IdFilial == idFilial && a.Cupom.IdStatusTele != null && a.Cupom.IdStatusTele == Dados.EnumTelemarketingStatus.Agendado && a.Ativo).ToList();
            }
        }

        public Dados.TelemarketingAgenda GetByCupom(int idCupom)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.TelemarketingAgenda.Include(a => a.Usuario).FirstOrDefault(a => a.IdCupom == idCupom);
            }
        }

        public List<Dados.TelemarketingAgenda> GetListByCupom(int idCupom)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.TelemarketingAgenda.Include(a => a.Usuario)
                                               .Include(a => a.Cupom)
                                               .Include(a => a.Cupom.TelemarketingStatus)
                                               .Where(a => a.IdCupom == idCupom).ToList();
            }
        }
    }
}
