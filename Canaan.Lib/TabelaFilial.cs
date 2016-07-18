using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class TabelaFilial : IBase<Dados.TabelaFilial>
    {
        public List<Dados.TabelaFilial> Get()
        {
            throw new NotImplementedException();
        }

        public List<Dados.TabelaFilial> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.TabelaFilial> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.TabelaFilial GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.TabelaFilial.FirstOrDefault(a => a.IdTabelaFilial == id);
            }
        }

        public Dados.TabelaFilial Insert(Dados.TabelaFilial item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.TabelaFilial.Add(item);

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
                    return GetById(item.IdTabelaFilial);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.TabelaFilial Update(Dados.TabelaFilial item)
        {
            throw new NotImplementedException();
        }

        public Dados.TabelaFilial Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.TabelaFilial> lista)
        {
            throw new NotImplementedException();
        }

        public void Delete(int idFilial, int idTabela)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.TabelaFilial.FirstOrDefault(a => a.IdFilial == idFilial && a.IdTabela == idTabela);

                    //salva no banco de dados
                    conn.TabelaFilial.Remove(deleted);
                    conn.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Tabela GetByFilial(int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.TabelaFilial.Where(a => a.IdFilial == idFilial && a.Tabela.IsAtivo).Select(a => a.Tabela).FirstOrDefault();
            }
        }
    }
}
