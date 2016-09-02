using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class Agendamento : IBase<Dados.Agendamento>
    {
        public List<Dados.Agendamento> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Agendamento.Include(a => a.Cupom).ToList();
            }
        }

        public Dados.Agendamento GetByVendaEvento(int idVendaEvento)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Agendamento
                           .Include(a => a.Cupom)
                           .FirstOrDefault(a => a.Cupom.IdCupomWeb == idVendaEvento);
            }
        }

        public List<Dados.Agendamento> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.Agendamento> Filter(string filtro, object[] parameters)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Agendamento
                           .Include(a => a.Cupom)
                           .Include(a => a.Agenda)
                           .Include(a => a.Cupom.Usuario)
                           .Where(filtro, parameters).ToList();
            }
        }

        public Dados.Agendamento GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var result = conn.Agendamento
                                       .Include(a => a.Usuario)
                                       .Include(a => a.Cupom)
                                       .Include(a => a.Cupom.Parceria)
                                       .Include(a => a.Atendimento)
                                       .Include(a => a.Cupom.UsuarioTele)
                                       .FirstOrDefault(a => a.IdAgendamento == id);

                return result;
            }
        }

        public Dados.Agendamento Insert(Dados.Agendamento item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //Seta numero de confirmacoes para 0
                    item.NumConfirmacao = 0;
                    item.IdUsuario = Lib.Session.Instance.Usuario.IdUsuario;

                    //salva no banco de dados
                    conn.Agendamento.Add(item);

                    //valida e salva
                    if (Validacao.IsValid(conn))
                    {
                        //salva o agendamento
                        conn.SaveChanges();

                        //salva a movimentacao
                        var LibAgendamentoMov = new AgendamentoMov();
                        LibAgendamentoMov.Insert(item);
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return GetById(item.IdAgendamento);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ValidaSalvarCupom(Dados.Cupom item)
        {

            if (new Cupom().ValidacaoCupomTel(item) == false)
                throw new Exception("Telefone ou Celular é obrigatório");

            //if (item.IdCupom > 0)
            //{
            //    var result = GetAgendamentoByCupom(item.IdCupom);
            //    if (result != null)
            //    {
            //        if (MessageBoxUtilities.MessageQuestion("Já existe outros agendamentos para este cupom. Você deseja reagendá-lo?") == DialogResult.No)
            //            return false;
            //        else
            //            return true;
            //    }
            //}

            return true;
        }


        public Dados.Agendamento Update(Dados.Agendamento item)
        {
            try
            {
                using (var conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Agendamento
                                      .FirstOrDefault(a => a.IdAgendamento == item.IdAgendamento);

                    //atualiza dados
                    if (updated != null)
                    {
                        //se for faltante atualiza a o id do usuario e zera as confirmacoes
                        if (updated.Status == Dados.EnumAgendamentoStatus.Faltante)
                        {
                            updated.IdUsuario = Lib.Session.Instance.Usuario.IdUsuario;
                            updated.NumConfirmacao = 0;
                        }

                        updated.IdCupom = item.IdCupom;
                        updated.Inicio = item.Inicio;
                        updated.Termino = item.Termino;
                        updated.Status = item.Status;
                        updated.IdAgenda = item.IdAgenda;
                        updated.Modelo = item.Modelo;
                        updated.Observacao = item.Observacao;
                        updated.NumConfirmacao = item.NumConfirmacao;

                        

                        //valida e salva
                        if (Validacao.IsValid(conn))
                        {
                            conn.SaveChanges();

                            //salva a movimentacao
                            var libAgendamentoMov = new AgendamentoMov();
                            libAgendamentoMov.Insert(updated);
                        }
                        else
                        {
                            throw new Exception(Validacao.GetErrors(conn));
                        }

                        //retorna
                        return GetById(updated.IdAgendamento);
                    }
                    else
                    {
                        throw new Exception("O objeto a ser atualizado não foi encontrado");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Agendamento UpdateCarta(Dados.Agendamento item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Agendamento
                                      .FirstOrDefault(a => a.IdAgendamento == item.IdAgendamento);

                    //atualiza dados
                    updated.IdCarta = item.IdCarta;

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
                    return GetById(updated.IdAgendamento);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateConfirmadoFaltante(int idFilial) 
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var dataHoje = DateTime.Today;
                var dataInicio = dataHoje.AddDays(-5).Date;
                var dataFim = dataHoje.Date;

                var confirmados = conn.Agendamento.Where(a => a.Inicio >= dataInicio &&
                                                              a.Inicio < dataFim &&
                                                              (a.Status == Dados.EnumAgendamentoStatus.Agendado || a.Status == Dados.EnumAgendamentoStatus.Confirmado));

                foreach (var item in confirmados)
                {
                    SalvaFaltante(item);
                }
            }
        }

        public void SalvaFaltante(Dados.Agendamento item)
        {
            //Atualiza Status do Agendamento
            item.Status = Dados.EnumAgendamentoStatus.Faltante;
            Update(item);

            //Salva Movimentação do Agendamento
            var LibAgedamentoMov = new AgendamentoMov();
            LibAgedamentoMov.Insert(new Dados.AgendamentoMov
            {
                IdAgendamento = item.IdAgendamento,
                IdUsuario = Session.Instance.Usuario.IdUsuario,
                Status = Dados.EnumAgendamentoStatus.Faltante,
                Data = DateTime.Today,
                Hora = DateTime.Now.TimeOfDay
            });

            //Atualiza Status do Cupom para Faltante
            var libCupom = new Cupom();
            var cupom = libCupom.GetById(item.IdCupom);

            cupom.Status = Dados.EnumCupomStatus.Faltante;
            cupom.IdUsuarioTele = null;
            cupom.IdStatusTele = Dados.EnumTelemarketingStatus.Faltante;
            cupom.IsAgendado = false;
            cupom.DataAgendado = null;

            libCupom.Update(cupom);
        }

        public Dados.Agendamento Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.Agendamento.FirstOrDefault(a => a.IdAgendamento == id);

                    //deleta todas as referencias
                    AgendamentoMov refLib = new AgendamentoMov();
                    foreach (var item in refLib.GetByAgendamento(deleted.IdAgendamento))
                    {
                        refLib.Delete(item.IdAgendamentoMov);
                    }

                    //deleta no banco de dados
                    conn.Agendamento.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.Agendamento> lista)
        {
            return lista.Select(a => new
                    {
                        a.IdAgendamento,
                        a.Cupom.Nome,
                        a.Inicio,
                        a.Termino,
                        a.Status
                    }).ToList();
        }

        public List<Dados.Agendamento> GetPossiveisFaltante(DateTime start, DateTime end, int idFilial)
        {
            //Retorna uma lista de tadas entre start e end e filtra apenas as menores que hoje
            //var dates = Enumerable.Range(0, 1 + end.Subtract(start).Days)
            //                      .Select(offset => start.AddDays(offset))
            //                      .Where(a => a.Date <= DateTime.Now.Date)
            //                      .ToList();

            var hoje = DateTime.Now;

            using (var conn = new Dados.CanaanModelContainer())
            {
                //Possiveis faltantes
                return conn.Agendamento.Include(a => a.Agenda)
                                       .Include(a => a.Cupom)
                                       .Where(a => a.Status != Dados.EnumAgendamentoStatus.Fotografado &&
                                                   a.Status != Dados.EnumAgendamentoStatus.Faltante &&
                                                   a.Status != Dados.EnumAgendamentoStatus.Atendido &&
                                                   a.Inicio <= hoje &&
                                                   a.Inicio >= start &&
                                                   a.Inicio <= end)
                                       .ToList();
            }
        }

        public Dados.Agendamento GetAgendamentoByCupom(int idCupom)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Agendamento.OrderByDescending(a => a.Inicio).FirstOrDefault(a => a.IdCupom == idCupom);
            }
        }

        public List<Dados.Agendamento> GetPossivesConfirmados(DateTime start, DateTime end, int idFilial)
        {
            var hoje = DateTime.Now;

            using (var conn = new Dados.CanaanModelContainer())
            {
                //Possiveis faltantes
                return conn.Agendamento.Include(a => a.Agenda)
                                       .Include(a => a.Cupom)
                                       .Where(a => a.Status != Dados.EnumAgendamentoStatus.Fotografado &&
                                                   a.Status != Dados.EnumAgendamentoStatus.Faltante &&
                                                   a.Status != Dados.EnumAgendamentoStatus.Atendido &&
                                                   a.Status != Dados.EnumAgendamentoStatus.Confirmado &&
                                                   a.Inicio >= hoje &&
                                                   a.Inicio >= start &&
                                                   a.Inicio <= end &&
                                                   a.Cupom.Parceria.IdFilial == idFilial
                                             )
                                       .ToList();
            }
        }

        public List<Dados.Agendamento> GetFaltantes(int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Agendamento.Include(a => a.Cupom).Where(a => a.Status == Dados.EnumAgendamentoStatus.Faltante && a.Cupom.Parceria.IdFilial == idFilial).ToList();
            }
        }

        public List<Dados.Agendamento> GetConfirmados(int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Agendamento.Include(a => a.Cupom).Where(a => a.Status == Dados.EnumAgendamentoStatus.Confirmado && a.Cupom.Parceria.IdFilial == idFilial).ToList();
            }
        }

        public List<Dados.Agendamento> Get(int IdFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var result = conn.Agendamento.Where(a => a.Cupom.Parceria.IdFilial == IdFilial).ToList();
                return result;
            }
        }

        public List<Dados.Agendamento> Get(int idFilial, int mes, int ano)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {

                var datainicial = new DateTime(ano, mes, 1);
                var datafinal = new DateTime(datainicial.Year, datainicial.Month, DateTime.DaysInMonth(datainicial.Year, datainicial.Month));
                datafinal = datafinal.AddHours(23);

                var result = conn.Agendamento
                                 .Where(a => a.Cupom.Parceria.IdFilial == idFilial && 
                                             a.Inicio >= datainicial && 
                                             a.Inicio <= datafinal && 
                                             a.Cupom.Status != Dados.EnumCupomStatus.Descartado)
                                 .ToList();
                return result;
            }
        }
    }
}

