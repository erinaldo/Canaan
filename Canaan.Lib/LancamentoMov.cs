using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class LancamentoMov : IBase<Dados.LancamentoMov>
    {
        public List<Dados.LancamentoMov> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer()) 
            {
                return conn.LancamentoMov
                           .Include(a => a.Lancamento)
                           .Include(a => a.Usuario)
                           .ToList();
            }
        }

        public List<Dados.LancamentoMov> GetByNome(string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.LancamentoMov
                           .Include(a => a.Lancamento)
                           .Include(a => a.Usuario)
                           .Include(a => a.Usuario.Username == nome)
                           .ToList();
            }
        }

        public List<Dados.LancamentoMov> GetByLancamento(int idLancamento)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.LancamentoMov
                           .Include(a => a.Lancamento)
                           .Include(a => a.Usuario)
                           .Include(a => a.IdLancamento == idLancamento)
                           .ToList();
            }
        }

        public List<Dados.LancamentoMov> Filter(string filtro, object[] parameters)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.LancamentoMov.Where(filtro, parameters).ToList();
            }
        }

        public Dados.LancamentoMov GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.LancamentoMov
                           .Include(a => a.Lancamento)
                           .Include(a => a.Usuario)
                           .FirstOrDefault(a => a.IdMov == id);
            }
        }

        public Dados.LancamentoMov Insert(Dados.LancamentoMov item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.LancamentoMov.Add(item);

                    //valida e salva
                    if (Validacao.IsValid(conn))
                    {
                        //salva o lancamento
                        conn.SaveChanges();
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return GetById(item.IdMov);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.LancamentoMov Update(Dados.LancamentoMov item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.LancamentoMov.FirstOrDefault(a => a.IdMov == item.IdMov);

                    //atualiza dados
                    updated.IdLancamento = item.IdLancamento;
                    updated.IdUsuario = item.IdUsuario;
                    updated.Status = item.Status;
                    updated.Data = item.Data;

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
                    return GetById(updated.IdMov);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.LancamentoMov Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.LancamentoMov.FirstOrDefault(a => a.IdMov == id);

                    //salva no banco de dados
                    conn.LancamentoMov.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.LancamentoMov> lista)
        {
            if (lista != null)
            {
                return lista.Select(a => new
                {
                    Codigo = a.IdMov,
                    Lancamento = a.IdLancamento,
                    Status = a.Status,
                    Data = a.Data.ToShortDateString(),
                    Usuario = a.Usuario.Username
                })
                .ToList();
            }
            else
            {
                return null;
            }
        }
    }
}
