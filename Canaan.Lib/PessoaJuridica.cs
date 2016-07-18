using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class PessoaJuridica : IBase<Dados.PessoaJuridica>
    {
        public List<Dados.PessoaJuridica> Get()
        {
            throw new NotImplementedException();
        }

        public List<Dados.PessoaJuridica> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.PessoaJuridica> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.PessoaJuridica GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsValid(Dados.PessoaJuridica item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.CliFor.Add(item);

                    //valida e salva
                    if (Validacao.IsValid(conn))
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.PessoaJuridica Insert(Dados.PessoaJuridica item)
        {
            throw new NotImplementedException();
        }

        public Dados.PessoaJuridica Update(Dados.PessoaJuridica item)
        {
            throw new NotImplementedException();
        }

        public Dados.PessoaJuridica Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.PessoaJuridica> lista)
        {
            throw new NotImplementedException();
        }
    }
}
