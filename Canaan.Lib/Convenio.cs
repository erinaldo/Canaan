using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class Convenio : IEnum<Dados.EnumConvenioTipo>, IBase<Dados.Convenio>
    {
        public List<Dados.Convenio> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Convenio.ToList();
            }
        }

        public List<Dados.Convenio> GetByNome(string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Convenio.Where(a => a.Nome.Contains(nome)).ToList();
            }
        }

        public List<Dados.Convenio> GetByNome(string nome, bool status)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Convenio.Where(a => a.Nome.Contains(nome) && a.IsAtivo == status)
                                    .ToList();
            }
        }

        public List<Dados.Convenio> GetByTipo(Dados.EnumConvenioTipo tipo)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Convenio.Where(a => a.Tipo == tipo)
                                    .ToList();
            }
        }

        public Dados.Convenio GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Convenio.FirstOrDefault(a => a.IdConvenio == id);
            }
        }

        public Dados.Convenio Insert(Dados.Convenio item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Convenio.Add(item);

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
                    return GetById(item.IdConvenio);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Convenio Update(Dados.Convenio item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Convenio
                                      .FirstOrDefault(a => a.IdConvenio == item.IdConvenio);

                    //atualiza dados
                    updated.IdConvenio = item.IdConvenio;
                    updated.Nome = item.Nome;
                    updated.Tipo = item.Tipo;
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
                    return GetById(updated.IdConvenio);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Convenio Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.Convenio.FirstOrDefault(a => a.IdConvenio == id);

                    //salva no banco de dados
                    conn.Convenio.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.Convenio> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdConvenio,
                Nome = a.Nome,
                Tipo = ((Dados.EnumConvenioTipo)a.Tipo).ToString(),
                Status = a.IsAtivo
            }).ToList();
        }

        public List<Dados.Convenio> GetByAtivo(bool status)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Convenio.Where(a => a.IsAtivo == status).ToList();
            }
        }

        public Dictionary<int, string> GetValuesFromEnum()
        {
            return Enum.GetValues(typeof(Dados.EnumConvenioTipo)).Cast<Dados.EnumConvenioTipo>()
                                                                 .ToDictionary(e => (int)e, e => e.ToString());
        }

        public Dictionary<int, string> GetValuesFromEnum(string descricao)
        {
            return Enum.GetValues(typeof(Dados.EnumConvenioTipo)).Cast<Dados.EnumConvenioTipo>()
                                                                 .Where(a => a.ToString().ToLower().Contains(descricao.ToLower()))
                                                                 .ToDictionary(e => (int)e, e => e.ToString());
        }

        public Dados.EnumConvenioTipo GetEnumForKey(int key)
        {
            return (Dados.EnumConvenioTipo)key;
        }

        public List<Dados.Convenio> Filter(string filtro, object[] parameters)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Convenio.Where(filtro, parameters).ToList();
            }
        }
    }
}
