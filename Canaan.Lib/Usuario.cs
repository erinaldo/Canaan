using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class Usuario : IBase<Dados.Usuario>
    {
        private Dados.CanaanModelContainer db;

        public Usuario()
        {

        }

        public Usuario(Dados.CanaanModelContainer db)
        {
            // TODO: Complete member initialization
            this.db = db;
        }

        public List<Dados.Usuario> Get()
        {
            using (var conn = new Dados.CanaanModelContainer()) 
            {
                return conn.Usuario
                           .OrderBy(a => a.Nome)
                           .ToList();
            }
        }

        public List<Dados.Usuario> GetByNome(string nome)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Usuario
                           .Where(a => a.Nome.Contains(nome) ||
                                       a.Sobrenome.Contains(nome) ||
                                       a.Username.Contains(nome) ||
                                       a.Email.Contains(nome))
                           .OrderBy(a => a.Nome)
                           .ToList();
            }
        }

        public List<Dados.Usuario> GetByFilialAndMktGrupo(int idFilial)
        {
            using (var conn = new  Dados.CanaanModelContainer())
            {
                return conn.Usuario.Include("CupomTele")
                                   .Include("CupomTele.Parceria")
                                   .Include("CupomTele.TelemarketingMov")
                                   .Where(a => a.UsuarioFilial.Any(b => b.UsuarioGrupo.IsMarketing && b.IdFilial == idFilial) && a.IsAtivo)
                                   .OrderBy(a => a.Nome)
                                   .ToList();
            }
        }

        public List<Dados.Usuario> GetByFilialAndMktGrupoContext(int idFilial)
        {
                return db.Usuario.Where(a => a.UsuarioFilial.Any(b => b.UsuarioGrupo.IsMarketing && b.IdFilial == idFilial) && a.IsAtivo)
                                 .OrderBy(a => a.Nome)
                                 .ToList();           
        }

        public List<Dados.Usuario> GetByFilialAndComercialGrupo(int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Usuario.Include("CupomTele")
                                   .Include("CupomTele.Parceria")
                                   .Include("CupomTele.TelemarketingMov")
                                   .Where(a => a.UsuarioFilial.Any(b => b.UsuarioGrupo.IsComercial && b.IdFilial == idFilial) && a.IsAtivo)
                                   .ToList();
            }
        }

        public List<Dados.Usuario> GetVendedoras(int idFilial) {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Usuario.Where(a => a.UsuarioFilial.Any(b => b.UsuarioGrupo.IsComercial && b.IdFilial == idFilial) && a.IsAtivo)
                                   .OrderBy(a => a.Nome)
                                   .ToList();
            }
        }

        public Dados.Usuario GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Usuario
                           .FirstOrDefault(a => a.IdUsuario == id);
            }
        }

        public Dados.Usuario GetByLogin(string username, string password) 
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Nome de usuário e senha sao obrigatórios");
            }
            else
            {
                using (var conn = new Dados.CanaanModelContainer())
                {
                    var usuario = conn.Usuario.Include(a => a.UsuarioFilial)
                                              .FirstOrDefault(a => a.Username == username && a.Password == password);

                    if (usuario != null)
                    {
                        return usuario;
                    }
                    else 
                    {
                        throw new Exception("Não foi possivel efetuar o login.\nUsuário ou senha inválidos.");
                    }
                }
            }
            
        }

        public Dados.Usuario Insert(Dados.Usuario item)
        {
            //inicializa a senha padrao
            item.Password = "canaan";

                try
                {
                    using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                    {
                        //salva no banco de dados
                        conn.Usuario.Add(item);

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
                        return GetById(item.IdUsuario);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
        }

        public Dados.Usuario Update(Dados.Usuario item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Usuario
                                      .FirstOrDefault(a => a.IdUsuario == item.IdUsuario);

                    //atualiza dados
                    updated.IdUsuario = item.IdUsuario;
                    updated.Nome = item.Nome;
                    updated.Sobrenome = item.Sobrenome;
                    updated.Email = item.Email;
                    updated.Telefone = item.Telefone;
                    updated.Celular = item.Celular;
                    updated.Username = item.Username;
                    updated.Password = item.Password;
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
                    return GetById(updated.IdUsuario);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Usuario Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.Usuario.FirstOrDefault(a => a.IdUsuario == id);

                    //salva no banco de dados
                    conn.Usuario.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.Usuario> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdUsuario,
                Nome = string.Format("{0} {1}", a.Nome, a.Sobrenome),
                Email = a.Email,
                Username = a.Username,
                Ativo = a.IsAtivo
            }).ToList();
        }

        public Dados.Usuario SendPassword(int id) 
        {
            throw new NotImplementedException();
        }

        public Dados.Usuario ChangePassword(Dados.Usuario usuario, string senha, string confirmacao) 
        {
            if (string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(confirmacao))
            {
                throw new Exception("Os campos senha se confirmação de senha são obrigatórios");
            }
            else
            {
                if (senha == confirmacao)
                {
                    try
                    {
                        using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                        {
                            //recupera item do banco
                            var updated = conn.Usuario.FirstOrDefault(a => a.IdUsuario == usuario.IdUsuario);

                            //salva no banco de dados
                            updated.Password = senha;
                            conn.SaveChanges();

                            //retorna
                            return updated;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                else
                {
                    throw new Exception("A senha e a confirmação da senha devem ser iguais");
                }
            }
        }

        public List<Dados.Usuario> Filter(string filtro, object[] parameters)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Usuario.Where(filtro, parameters).ToList();
            }
        }
    }
}
