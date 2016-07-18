using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class UsuarioFilial : IBase<Dados.UsuarioFilial>
    {
        public List<Dados.UsuarioFilial> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.UsuarioFilial
                           .Include(a => a.Usuario)
                           .Include(a => a.Filial)
                           .Include(a => a.UsuarioGrupo)
                           .ToList();
            }
        }

        public List<Dados.UsuarioFilial> GetByFilial(int idfilial)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.UsuarioFilial
                           .Include(a => a.Usuario)
                           .Include(a => a.Filial)
                           .Include(a => a.UsuarioGrupo)
                           .Where(a => a.IdFilial == idfilial)
                           .ToList();
            }
        }

        public List<Dados.UsuarioFilial> GetByUsuario(int idusuario)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.UsuarioFilial
                           .Include(a => a.Usuario)
                           .Include(a => a.Filial)
                           .Include(a => a.UsuarioGrupo)
                           .Where(a => a.IdUsuario == idusuario)
                           .ToList();
            }
        }

        public Dados.UsuarioFilial GetByUsuarioFilial(int idusuario,  int idFilial)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.UsuarioFilial
                           .Include(a => a.Usuario)
                           .Include(a => a.Filial)
                           .Include(a => a.UsuarioGrupo)
                           .FirstOrDefault(a => a.IdUsuario == idusuario && a.IdFilial == idFilial);
            }
        }

        public List<Dados.UsuarioFilial> GetByGrupo(int idugrupo)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.UsuarioFilial
                           .Include(a => a.Usuario)
                           .Include(a => a.Filial)
                           .Include(a => a.UsuarioGrupo)
                           .Where(a => a.IdUsuarioGrupo == idugrupo)
                           .ToList();
            }
        }

        public List<Dados.UsuarioFilial> GetByNome(string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.UsuarioFilial
                           .Include(a => a.Usuario)
                           .Include(a => a.Filial)
                           .Include(a => a.UsuarioGrupo)
                           .Where(a => a.Usuario.Nome.Contains(nome))
                           .ToList();
            }
        }

        public Dados.UsuarioFilial GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.UsuarioFilial
                           .Include(a => a.Usuario)
                           .Include(a => a.Filial)
                           .Include(a => a.UsuarioGrupo)
                           .FirstOrDefault(a => a.IdUsuarioFilial == id);
            }
        }

        public Dados.UsuarioFilial Insert(Dados.UsuarioFilial item)
        {
            //verifica se ja existe um registro do usuario na filial
            if (GetByUsuario(item.IdUsuario).Where(a => a.IdFilial == item.IdFilial).Count() > 0)
            {
                var atual = GetByUsuario(item.IdUsuario).FirstOrDefault(a => a.IdFilial == item.IdFilial);
                throw new Exception("Já existe um registro do usuario '" + atual.Usuario.Nome + "' na filial '" + atual.Filial.NomeFantasia + "'");
            }
            else 
            {
                try
                {
                    using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                    {
                        //salva no banco de dados
                        conn.UsuarioFilial.Add(item);

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
                        return GetById(item.IdUsuarioFilial);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                
            }
        }

        public Dados.UsuarioFilial Update(Dados.UsuarioFilial item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.UsuarioFilial
                                      .Include(a => a.Usuario)
                                      .Include(a => a.Filial)
                                      .Include(a => a.UsuarioGrupo)
                                      .FirstOrDefault(a => a.IdUsuarioFilial == item.IdUsuarioFilial);

                    //atualiza dados
                    updated.IdUsuario = item.IdUsuario;
                    updated.IdFilial = item.IdFilial;
                    updated.IdUsuarioGrupo = item.IdUsuarioGrupo;

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
                    return GetById(updated.IdUsuarioFilial);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.UsuarioFilial Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.UsuarioFilial
                           .Include(a => a.Usuario)
                           .Include(a => a.Filial)
                           .Include(a => a.UsuarioGrupo)
                           .FirstOrDefault(a => a.IdUsuarioFilial == id);

                    //salva no banco de dados
                    conn.UsuarioFilial.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.UsuarioFilial> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdUsuarioFilial,
                Usuario = a.Usuario.Username,
                Filial = a.Filial.NomeFantasia,
                Permissao = a.UsuarioGrupo.Nome
            }).ToList();
        }

        public List<Dados.UsuarioFilial> Filter(string filtro, object[] parameters)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.UsuarioFilial
                           .Include(a => a.Usuario)
                           .Include(a => a.Filial)
                           .Include(a => a.UsuarioGrupo)
                           .Where(filtro, parameters).ToList();
            }
        }


    }
}
