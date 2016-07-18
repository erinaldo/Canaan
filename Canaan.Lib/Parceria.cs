using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class Parceria : IBase<Dados.Parceria>
    {
        private Dados.CanaanModelContainer db;

        public Parceria()
        {

        }

        public Parceria(Dados.CanaanModelContainer db)
        {
            // TODO: Complete member initialization
            this.db = db;
        }

        public List<Dados.Parceria> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Parceria.Include(a => a.Filial)
                                    .Include(a => a.Convenio)
                                    .ToList();
            }
        }

        public List<Dados.Parceria> GetByNome(string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Parceria.Include(a => a.Filial)
                                    .Include(a => a.Convenio)
                                    .Where(a => a.Nome.Contains(nome))
                                    .ToList();
            }
        }

        public Dados.Parceria GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Parceria.Include(a => a.Filial)
                                    .Include(a => a.Convenio)
                                    .FirstOrDefault(a => a.IdParceria == id);
            }
        }

        public List<Dados.Parceria> GetByAtivo(bool status, int idFilial)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Parceria.Include(a => a.Filial)
                                    .Include(a => a.Convenio)
                                    .Where(a => a.IsAtivo == status && a.IdFilial == idFilial)
                                    .ToList();
            }
        }

        public Dados.Parceria GetByTipoConvenioAndFilial(int idFilial, Dados.EnumConvenioTipo tipo)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Parceria.FirstOrDefault(a => a.Convenio.Tipo == tipo && a.IdFilial == idFilial);
            }
        }

        public List<Dados.Parceria> GetByAtivo(int idConvenio, bool status, int idFilial)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Parceria.Include(a => a.Filial)
                                    .Include(a => a.Convenio)
                                    .Where(a => a.IdConvenio == idConvenio && a.IsAtivo == status && a.IdFilial == idFilial)
                                    .ToList();
            }
        }

        public List<Dados.Parceria> GetParceriasSelecaoCupom(int idFilial)
        {
            var hoje = DateTime.Today;

            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Parceria.Include(a => a.Cupom)
                                    .Where(a => a.IdFilial == idFilial &&
                                                a.Cupom.Where(b => b.IsAgendado == false &&
                                                                   b.IsDescartado == false &&
                                                                   b.IsLembrete == false &&
                                                                   (b.IdStatusTele == null || b.IdStatusTele == Dados.EnumTelemarketingStatus.Expirado)).Count() > 0)
                                    .ToList();
            }
        }

        public List<Dados.Parceria> GetParceriasSelecaoCupomContexto(int idFilial)
        {
            var hoje = DateTime.Today;

            return db.Parceria.Where(a => a.IdFilial == idFilial &&
                                            a.Cupom.Where(b => b.IsAgendado == false &&
                                                               b.IsDescartado == false &&
                                                               b.IsLembrete == false &&
                                                               (b.IdStatusTele == null || b.IdStatusTele == Dados.EnumTelemarketingStatus.Expirado)).Count() > 0)
                                .ToList();
        }


        public Dados.Parceria Insert(Dados.Parceria item)
        {
            try
            {
                using (var conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Parceria.Add(item);

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
                    return GetById(item.IdParceria);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Parceria Update(Dados.Parceria item)
        {
            try
            {
                using (var conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Parceria
                                      .FirstOrDefault(a => a.IdParceria == item.IdParceria);

                    //atualiza dados
                    if (updated != null)
                    {
                        updated.IdConvenio = item.IdConvenio;
                        updated.IdFilial = item.IdFilial;
                        updated.Nome = item.Nome;
                        updated.Descricao = item.Descricao;
                        updated.DataInicio = item.DataInicio;
                        updated.DataFim = item.DataFim;
                        updated.DataRetirada = item.DataRetirada;
                        updated.ContatoNome = item.ContatoNome;
                        updated.ContatoTel = item.ContatoTel;
                        updated.ContatoCel = item.ContatoCel;
                        updated.ContatoEmail = item.ContatoEmail;
                        updated.IsRetirada = item.IsRetirada;
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
                        return GetById(updated.IdParceria);
                    }
                    else
                    {
                        throw new Exception("Não foi possivel atualizar cupom. Objeto a set atualizado não foi encontrado");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Parceria Delete(int id)
        {
            try
            {
                using (var conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.Parceria.FirstOrDefault(a => a.IdParceria == id);

                    //salva no banco de dados
                    conn.Parceria.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.Parceria> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdParceria,
                Parceria = a.Nome,
                Convenio = a.Convenio.Nome,
                Filial = a.Filial.NomeFantasia,
                Inicio = a.DataInicio,
                Fim = a.DataFim,
                Retirada = a.DataRetirada,
                Status = a.IsAtivo
            }).ToList();

        }

        public List<Dados.Parceria> Filter(string filtro, object[] parameters)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Parceria.Include(a => a.Filial)
                                    .Include(a => a.Convenio)
                                    .Where(filtro, parameters).ToList();
            }
        }

        public List<Dados.Parceria> GetParceriasSelecaoFaltantes(int idFilial)
        {
            var hoje = DateTime.Today;

            using (var conn = new Dados.CanaanModelContainer())
            {
                var result = conn.Parceria.Include(a => a.Cupom)
                    .Where(a => a.IdFilial == idFilial &&
                                a.Cupom.Any(
                                    b =>
                                        b.Status == Dados.EnumCupomStatus.Faltante &&
                                        b.IsAgendado == false &&
                                        b.IsDescartado == false &&
                                        b.IdUsuarioTele == null)).ToList();

                //(b.IdStatusTele == null || b.IdStatusTele == Dados.EnumTelemarketingStatus.Faltante || b.IdStatusTele == Dados.EnumTelemarketingStatus.Expirado))).ToList();

                return result;
            }
        }

        public List<Dados.Parceria> GetParceriasSelecaoFaltantesContext(int idFilial)
        {
            var hoje = DateTime.Today;
            var result = db.Parceria.Include(a => a.Cupom)
                                      .Where(a => a.IdFilial == idFilial &&
                                                  a.Cupom.Any(b => b.Status == Dados.EnumCupomStatus.Faltante &&
                                                                  (b.IdStatusTele == null || b.IdStatusTele == Dados.EnumTelemarketingStatus.Faltante || b.IdStatusTele == Dados.EnumTelemarketingStatus.Expirado)))
                                      .ToList();
            return result;
        }


        public List<Dados.Parceria> GetByConvenio(int idConvenio)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Parceria.Where(a => a.IdConvenio == idConvenio).ToList();
            }
        }

        public List<Dados.Parceria> GetByPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Parceria.Where(a => a.DataInicio >= dataInicial && a.DataInicio <= dataFinal).ToList();
            }
        }
    }
}
