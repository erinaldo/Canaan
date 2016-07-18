using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class AtendimentoHist : IBase<Dados.AtendimentoHist>
    {

        public List<Dados.AtendimentoHist> Get()
        {
            throw new NotImplementedException();
        }

        public List<Dados.AtendimentoHist> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.AtendimentoHist> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.AtendimentoHist GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.AtendimentoHist.FirstOrDefault(a => a.IdHist == id);
            }
        }

        public Dados.AtendimentoHist Insert(Dados.AtendimentoHist item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.AtendimentoHist.Add(item);

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
                    return GetById(item.IdHist);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.AtendimentoHist Update(Dados.AtendimentoHist item)
        {
            throw new NotImplementedException();
        }

        public Dados.AtendimentoHist Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.AtendimentoHist> lista)
        {
            throw new NotImplementedException();
        }
    }
}
