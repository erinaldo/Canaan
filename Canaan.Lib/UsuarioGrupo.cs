using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class UsuarioGrupo : IBase<Dados.UsuarioGrupo>
    {
        public List<Dados.UsuarioGrupo> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.UsuarioGrupo.ToList();
            }
        }

        public List<Dados.UsuarioGrupo> GetByNome(string nome)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.UsuarioGrupo.Where(a => a.Nome.Contains(nome)).ToList();
            }
        }

        public Dados.UsuarioGrupo GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.UsuarioGrupo.FirstOrDefault(a => a.IdUsuarioGrupo == id);
            }
        }

        public Dados.UsuarioGrupo Insert(Dados.UsuarioGrupo item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.UsuarioGrupo.Add(item);

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
                    return item;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.UsuarioGrupo Update(Dados.UsuarioGrupo item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.UsuarioGrupo.FirstOrDefault(a => a.IdUsuarioGrupo == item.IdUsuarioGrupo);

                    //atualiza dados
                    updated.Nome = item.Nome;
                    updated.IsAdmin = item.IsAdmin;
                    updated.IsGerente = item.IsGerente;
                    updated.IsSupervisor = item.IsSupervisor;
                    updated.IsFinanceiro = item.IsFinanceiro;
                    updated.IsComercial = item.IsComercial;
                    updated.IsProducao = item.IsProducao;
                    updated.IsMarketing = item.IsMarketing;
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
                    return updated;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.UsuarioGrupo Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.UsuarioGrupo.FirstOrDefault(a => a.IdUsuarioGrupo == id);

                    //salva no banco de dados
                    conn.UsuarioGrupo.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.UsuarioGrupo> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdUsuarioGrupo,
                Nome = a.Nome,
                Administrador = a.IsAdmin,
                Gerente = a.IsGerente,
                Supervisor = a.IsSupervisor,
                Ativo = a.IsAtivo
            }).ToList();
        }

        public List<Dados.UsuarioGrupo> Filter(string filtro, object[] parameters)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.UsuarioGrupo.Where(filtro, parameters).ToList();
            }
        }
    }
}
