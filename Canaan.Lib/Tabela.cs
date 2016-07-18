using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class Tabela : IBase<Dados.Tabela>
    {
        public List<Dados.Tabela> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Tabela.ToList();
            }
        }

        public List<Dados.Tabela> GetByStatus(bool status)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Tabela.Where(a => a.IsAtivo == status).ToList();
            }
        }

        public List<Dados.Tabela> GetByNome(string nome)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Tabela.Where(a => a.Nome.Contains(nome)).ToList();
            }
        }

        public List<Dados.Tabela> GetByNome(string nome, int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Tabela.Where(a => a.Nome.Contains(nome) && a.TabelaFilial.Any(b => b.IdFilial == idFilial)).ToList();
            }
        }

        public List<Dados.Tabela> GetByNome(string nome, int idFilial, int competencia)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Tabela.Where(a => a.Nome.Contains(nome) && a.TabelaFilial.Any(b => b.IdFilial == idFilial) && a.Competencia == competencia).ToList();
            }
        }

        public List<Dados.Tabela> GetByNome(string nome, int idFilial, int competencia, bool status)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Tabela.Where(a => a.Nome.Contains(nome) && a.TabelaFilial.Any(b => b.IdFilial == idFilial) && a.IsAtivo == status && a.Competencia == competencia).ToList();
            }
        }

        public List<Dados.Tabela> GetByFilial(int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Tabela.Where(a => a.TabelaFilial.Any(b => b.IdFilial == idFilial)).ToList();
            }
        }

        public List<Dados.Tabela> GetByFilial(int idFilial, int competencia)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Tabela.Where(a => a.TabelaFilial.Any(b => b.IdFilial == idFilial) && a.IsAtivo && a.Competencia == competencia).ToList();
            }
        }

        public List<Dados.Tabela> GetByFilial(int idFilial, int competencia, bool status)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Tabela.Where(a => a.TabelaFilial.Any(b => b.IdFilial == idFilial) && a.IsAtivo == status && a.Competencia == competencia).ToList();
            }
        }

        public List<Dados.Tabela> Filter(string filtro, object[] parameters)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Tabela.Where(filtro, parameters).ToList();
            }
        }

        public Dados.Tabela GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Tabela.FirstOrDefault(a => a.IdTabela == id);
            }
        }

        public Dados.Tabela Insert(Dados.Tabela item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Tabela.Add(item);

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
                    return GetById(item.IdTabela);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Tabela Update(Dados.Tabela item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Tabela
                                      .FirstOrDefault(a => a.IdTabela == item.IdTabela);

                    //atualiza dados

                    updated.Nome = item.Nome;
                    updated.Competencia = item.Competencia;
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
                    return GetById(updated.IdTabela);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Tabela Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.Tabela.FirstOrDefault(a => a.IdTabela == id);

                    //salva no banco de dados
                    conn.Tabela.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.Tabela> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdTabela,
                Descrica = a.Nome,
                Status = a.IsAtivo
            }).ToList();
        }
    }
}
