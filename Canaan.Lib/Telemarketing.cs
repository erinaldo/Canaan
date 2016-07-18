using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class Telemarketing : IBase<Dados.Telemarketing>
    {
        public List<Dados.Telemarketing> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Telemarketing.ToList();
            }
        }

        public List<Dados.Telemarketing> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.Telemarketing> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.Telemarketing GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Telemarketing.FirstOrDefault(a => a.IdTelemarketing == id);
            }
        }

        public Dados.Telemarketing Insert(Dados.Telemarketing item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //Verifica se cupom ja foi distribuido
                    if (CupomDistribuido(item))
                       item = Update(item);
                    else
                    {
                        //salva no banco de dados
                        conn.Telemarketing.Add(item);

                        //valida e salva
                        if (Validacao.IsValid(conn))
                        {
                            conn.SaveChanges();
                        }
                        else
                        {
                            throw new Exception(Validacao.GetErrors(conn));
                        }

                    }
                    //retorna
                    return GetById(item.IdTelemarketing);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Telemarketing Update(Dados.Telemarketing item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Telemarketing
                                      .FirstOrDefault(a => a.IdCupom == item.IdCupom);

                    //atualiza dados
                    updated.IdCupom = item.IdCupom;
                    updated.IdUsuario = item.IdUsuario;
                    updated.DataLimite = item.DataLimite;
                    updated.IdUsuario = item.IdUsuario;
                    updated.IdUsuarioDistribuicao = item.IdUsuarioDistribuicao;

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
                    return GetById(updated.IdTelemarketing);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Telemarketing Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.Telemarketing> lista)
        {
            throw new NotImplementedException();
        }

        private bool CupomDistribuido(Dados.Telemarketing item)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Telemarketing.Any(a => a.IdCupom == item.IdCupom);
            }
        }

        public List<Dados.Telemarketing> GetExpirados()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var hoje = DateTime.Today;
                return conn.Telemarketing.Where(a => a.DataLimite < hoje && a.TelemarketingMov.Any(b => b.IdStatus == 2)).ToList();
            }
        }
    }
}
