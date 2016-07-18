using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Canaan.Lib
{
    public class Sessao : IBase<Dados.Sessao>
    {
        #region PROPRIEDADES

        public AtendimentoHist LibAtendimentoHist
        {
            get
            {
                return new AtendimentoHist();
            }
        }

        #endregion

        public List<Dados.Sessao> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Sessao.Include(a => a.Usuario).ToList();
            }
        }

        public List<Dados.Sessao> GetByPeriodo(DateTime dtInicio, DateTime dtFim, int idFilial) 
        {
            var dtFim2 = dtFim.AddDays(1);

            using (var conn = new Dados.CanaanModelContainer())
            {
                var result = conn.Sessao
                                 .Include(a => a.Atendimento)
                                 .Include(a => a.Atendimento.CliFor)
                                 .Include(a => a.Usuario)
                                 .Include(a => a.Foto)
                                 .Where(a => a.Data >= dtInicio &&
                                             a.Data <= dtFim2 &&
                                             a.Atendimento.IdFilial == idFilial);


                return result.ToList();
            }
        }

        public List<Dados.Sessao> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.Sessao> GetByCliente(int idCliFor)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Sessao.Include(a => a.Usuario).Where(a => a.Atendimento.CliFor.IdCliFor == idCliFor).ToList();
            }
        }

        public List<Dados.Sessao> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.Sessao GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Sessao.Include(a => a.Usuario)
                                  .Include(a => a.Atendimento)
                                  .Include(a => a.Atendimento.Agendamento)
                                  .Include(a => a.Atendimento.Agendamento.Cupom)
                                  .Include(a => a.Atendimento.CliFor)
                                  .Include(a => a.Foto)
                                  .FirstOrDefault(a => a.IdSessao == id);
            }
        }

        public Dados.Sessao Insert(Dados.Sessao item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Sessao.Add(item);

                    //valida e salva
                    if (Validacao.IsValid(conn))
                    {
                        conn.SaveChanges();

                        //Adiciona historico
                        AdicionarHistorico(item, Utilitarios.EnumTipoMov.Insert);
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return GetById(item.IdSessao);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Sessao Update(Dados.Sessao item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Sessao
                                      .FirstOrDefault(a => a.IdSessao == item.IdSessao);

                    //atualiza dados
                    updated.IdAtendimento = item.IdAtendimento;
                    updated.IdUsuario = item.IdUsuario;
                    updated.QuantidadeFoto = item.QuantidadeFoto;
                    updated.TempoSessao = item.TempoSessao;
                    updated.Data = item.Data;
                    updated.Tipo = item.Tipo;
                    updated.Genero = item.Genero;
                    updated.NumSessao = item.NumSessao;
                    updated.IsAtivo = item.IsAtivo;
                    updated.Tamanho = item.Tamanho;
                    updated.HasBackup = item.HasBackup;


                    //valida e salva
                    if (Validacao.IsValid(conn))
                    {
                        conn.SaveChanges();

                        //Adiciona historico
                        AdicionarHistorico(updated, Utilitarios.EnumTipoMov.Update);
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return GetById(updated.IdSessao);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Sessao Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.Sessao.Include(a => a.Usuario).FirstOrDefault(a => a.IdSessao == id);

                    //salva no banco de dados
                    conn.Sessao.Remove(deleted);
                    conn.SaveChanges();

                    //Adiciona historico
                    AdicionarHistorico(deleted, Utilitarios.EnumTipoMov.Delete);

                    //retorna
                    return deleted;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public dynamic CarregaGrid(List<Dados.Sessao> lista)
        {
            return lista.Select(a => new
                {
                    Codigo = a.IdSessao,
                    Atendimento = a.IdAtendimento,
                    Fotografa = a.Usuario.Nome,
                    Data = a.Data,
                    Sessao = a.NumSessao
                }).ToList();
        }

        public int GetNumSessao(int idAtendimento)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var sessoes = conn.Sessao.Where(a => a.Atendimento.IdAtendimento == idAtendimento)
                                .OrderByDescending(a => a.NumSessao);


                if (sessoes.Count() <= 0 || sessoes == null)
                {
                    return 1;
                }

                return sessoes.FirstOrDefault().NumSessao + 1;
            }
        }

        public TimeSpan CalcularTempo(int idSessao)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var firstImage = conn.Foto.Where(a => a.IdSessao == idSessao)
                                          .OrderBy(a => a.Hora)
                                          .ToList()
                                          .FirstOrDefault();

                var lastImage = conn.Foto.Where(a => a.IdSessao == idSessao)
                                         .OrderBy(a => a.Hora)
                                         .ToList()
                                         .LastOrDefault();

                if (firstImage == null || lastImage == null)
                    return new TimeSpan(0, 0, 0);

                return lastImage.Hora - lastImage.Hora;
            }
        }

        public List<Dados.Sessao> GetByClienteAndFilial(int idCliFor, int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Sessao.Include(a => a.Usuario).Where(a => a.Atendimento.CliFor.IdCliFor == idCliFor && a.Atendimento.IdFilial == idFilial).ToList();
            }
        }


        #region UTILITARIO

        private void AdicionarHistorico(Dados.Sessao item, Utilitarios.EnumTipoMov enumTipoMov)
        {
            var his = new Dados.AtendimentoHist
            {
                IdAtendimento = item.IdAtendimento,
                IdUsuario = Session.Instance.Usuario.IdUsuario,
                Data = DateTime.Now,
            };


            switch (enumTipoMov)
            {
                case Utilitarios.EnumTipoMov.Insert:
                    his.Observacao = string.Format("Sessão {0} adicionado ao atendimento {1} com sucesso.", item.IdSessao, item.IdAtendimento);
                    break;
                case Utilitarios.EnumTipoMov.Update:
                    his.Observacao = string.Format("Sessão {0} atualizada do atendimento {1} com sucesso.", item.IdSessao, item.IdAtendimento);
                    break;
                case Utilitarios.EnumTipoMov.Delete:
                    his.Observacao = string.Format("Sessão {0} deletada do atendimento {1} com sucesso.", item.IdSessao, item.IdAtendimento);
                    break;
                default:
                    his.Observacao = string.Format("Sessão {0} adicionado ao atendimento {1} com sucesso.", item.IdSessao, item.IdAtendimento);
                    break;
            }

            LibAtendimentoHist.Insert(his);
        }

        #endregion

        public System.ComponentModel.BindingList<Model.SessaoBackup> GetModelBackup(int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var result = conn.Sessao.Where(a => a.Atendimento.IdFilial == idFilial && !a.HasBackup)
                                        .Select(a => new Model.SessaoBackup
                                                     {
                                                         IdSessao = a.IdSessao,
                                                         IdAtendimento = a.IdAtendimento,
                                                         Atendimento = a.Atendimento.CodigoReduzido,
                                                         Data = a.Data,
                                                         NumSessao = a.NumSessao,
                                                         QuantidadeFotos = a.QuantidadeFoto,
                                                         Tempo = a.TempoSessao,
                                                         Tamanho = a.Tamanho
                                                     }).ToList();

                return new System.ComponentModel.BindingList<Model.SessaoBackup>(result);


            }
        }

        public List<Dados.Sessao> GetByAtendimentoAndFilial(int idAtendimento, int idFIlial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Sessao.Include(a => a.Usuario).Where(a => a.Atendimento.IdAtendimento == idAtendimento && a.Atendimento.IdFilial == idFIlial).ToList();
            }
        }

        public Dados.Sessao GetByIdFoto(int idFoto)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Sessao.Include(a => a.Atendimento).FirstOrDefault(a => a.Foto.Any(b => b.IdFoto == idFoto));
            }
        }
    }
}

