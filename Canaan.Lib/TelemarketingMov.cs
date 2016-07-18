using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Canaan.Lib
{
    public class TelemarketingMov : IBase<Dados.TelemarketingMov>
    {
        public List<Dados.TelemarketingMov> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.TelemarketingMov.ToList();
            }
        }

        public List<Dados.TelemarketingMov> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.TelemarketingMov> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.TelemarketingMov GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.TelemarketingMov.FirstOrDefault(a => a.IdTelemarketingMov == id);
            }
        }

        public Dados.TelemarketingMov Insert(Dados.TelemarketingMov item)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                //salva no banco de dados
                conn.TelemarketingMov.Add(item);

                //valida e salva
                if (Validacao.IsValid(conn))
                {
                    conn.SaveChanges();

                    //verifica se cupom foi agendado ou descartado
                    //var libCupom = new Cupom();
                    //var cupom = libCupom.GetById(item.IdCupom);
                    //libCupom.UpdateCondicao(cupom, item.IdStatus.GetValueOrDefault());

                }
                else
                {
                    throw new Exception(Validacao.GetErrors(conn));
                }

                //retorna
                return GetById(item.IdTelemarketingMov);
            }

        }

        public Dados.TelemarketingMov Update(Dados.TelemarketingMov item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.TelemarketingMov
                                      .FirstOrDefault(a => a.IdTelemarketingMov == item.IdTelemarketingMov);

                    //atualiza dados
                    updated.IdCupom = item.IdCupom;
                    updated.IdUsuario = item.IdUsuario;
                    updated.IdStatus = item.IdStatus;
                    updated.Data = item.Data;

                    //valida e salva
                    if (Validacao.IsValid(conn))
                    {
                        conn.SaveChanges();

                        //verifica se cupom foi agendado ou descartado
                        //var libCupom = new Cupom();
                        //var cupom = libCupom.GetById(item.IdCupom);
                        //libCupom.UpdateCondicao(cupom, item.IdStatus.GetValueOrDefault());
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return GetById(updated.IdTelemarketingMov);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.TelemarketingMov Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.TelemarketingMov> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdTelemarketingMov,
                Nome = a.Cupom.Nome,
                Usuario = a.Usuario != null ? a.Usuario.Nome : string.Empty,
                Data = a.Data,
                Pontuacao = a.TelemarketingStatus.Pontos,
                Status = a.TelemarketingStatus.Nome

            }).ToList();
        }

        public List<Dados.TelemarketingMov> GetByCupom(int idCupom)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.TelemarketingMov.Include(a => a.TelemarketingStatus)
                                            .Include(a => a.Usuario)
                                            .Include(a => a.Cupom)
                                            .Where(a => a.IdCupom == idCupom).ToList();
            }
        }
    }
}
