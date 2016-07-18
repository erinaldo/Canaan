using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class ModeloResp : IBase<Dados.ModeloResp>, IEnum<Dados.EnumModeloTipoResp>
    {
        public List<Dados.ModeloResp> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.ModeloResp.ToList();
            }
        }

        public List<Dados.ModeloResp> GetByNome(string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.ModeloResp.Where(a => a.Nome.Contains(nome)).ToList();
            }
        }

        public List<Dados.ModeloResp> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.ModeloResp GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.ModeloResp.FirstOrDefault(a => a.IdModeloResp == id);
            }
        }

        public Dados.ModeloResp Insert(Dados.ModeloResp item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.ModeloResp.Add(item);

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
                    return GetById(item.IdModeloResp);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.ModeloResp Update(Dados.ModeloResp item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.ModeloResp
                                      .FirstOrDefault(a => a.IdModeloResp == item.IdModeloResp);

                    //atualiza dados
                    updated.IdModelo = item.IdModelo;
                    updated.Nome = item.Nome;
                    updated.Tipo = item.Tipo;
                    updated.Rg = item.Rg;
                    updated.Telefone = item.Telefone;
                    updated.Celular = item.Celular;
                    updated.Cpf = item.Cpf;

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
                    return GetById(updated.IdModeloResp);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.ModeloResp Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.ModeloResp> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdModeloResp,
                Nome = a.Nome,
                Tipo = ((Dados.EnumModeloTipoResp)a.Tipo).ToString(),
                Telefone = a.Telefone,
                Celular = a.Celular
            }).ToList();
        }

        public List<Dados.ModeloResp> GetByModelo(int idModelo)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.ModeloResp.Where(a => a.IdModelo == idModelo).ToList();
            }
        }

        public Dictionary<int, string> GetValuesFromEnum()
        {
            return Enum.GetValues(typeof(Dados.EnumModeloTipoResp)).Cast<Dados.EnumModeloTipoResp>()
                                                               .ToDictionary(e => (int)e, e => e.ToString());
        }

        public Dictionary<int, string> GetValuesFromEnum(string descricao)
        {
            return Enum.GetValues(typeof(Dados.EnumModeloTipoResp)).Cast<Dados.EnumModeloTipoResp>()
                                                              .Where(a => a.ToString().ToLower().Contains(descricao.ToLower()))
                                                              .ToDictionary(e => (int)e, e => e.ToString());
        }

        public Dados.EnumModeloTipoResp GetEnumForKey(int key)
        {
            return (Dados.EnumModeloTipoResp)key;
        }

    }
}