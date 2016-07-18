using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class GrupoEmpresa : IBase<Dados.GrupoEmpresa>
    {
        public List<Dados.GrupoEmpresa> Get() 
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer()) 
            {
                return conn.GrupoEmpresa
                           .ToList();
            }
        }

        public List<Dados.GrupoEmpresa> GetByAtivo(bool isativo)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.GrupoEmpresa
                           .Where(a => a.IsAtivo == isativo)
                           .ToList();
            }
        }

        public List<Dados.GrupoEmpresa> GetByFranquia(bool isfranquia)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.GrupoEmpresa
                           .Where(a => a.IsFranquia == isfranquia)
                           .ToList();
            }
        }

        public List<Dados.GrupoEmpresa> GetByNome(string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.GrupoEmpresa
                           .Where(a => a.Nome.Contains(nome))
                           .ToList();
            }
        }

        public Dados.GrupoEmpresa GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.GrupoEmpresa
                           .FirstOrDefault(a => a.IdGrupoEmpresa == id);
            }
        }

        public Dados.GrupoEmpresa Update(Dados.GrupoEmpresa item) 
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.GrupoEmpresa.FirstOrDefault(a => a.IdGrupoEmpresa == item.IdGrupoEmpresa);

                    //atualiza dados
                    updated.Nome = item.Nome;
                    updated.Descricao = item.Descricao;
                    updated.IsFranquia = item.IsFranquia;
                    updated.IsAtivo = item.IsAtivo;

                    //valida e salva no banco de dados
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

        public Dados.GrupoEmpresa Insert(Dados.GrupoEmpresa item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.GrupoEmpresa.Add(item);

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
        
        public dynamic CarregaGrid(List<Dados.GrupoEmpresa> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdGrupoEmpresa,
                Nome = a.Nome,
                Franquia = a.IsFranquia,
                Ativo = a.IsAtivo
            }).ToList();
        }

        public Dados.GrupoEmpresa Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.GrupoEmpresa.FirstOrDefault(a => a.IdGrupoEmpresa == id);

                    //salva no banco de dados
                    conn.GrupoEmpresa.Remove(deleted);
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

        public List<Dados.GrupoEmpresa> Filter(string filtro, object[] parameters)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.GrupoEmpresa.Where(filtro, parameters).ToList();
            }
        }
    }
}
