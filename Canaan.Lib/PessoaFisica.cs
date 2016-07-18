using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Canaan.Lib
{
    public class PessoaFisica : IBase<Dados.PessoaFisica>
    {

        public List<Dados.PessoaFisica> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.CliFor
                           .OfType<Dados.PessoaFisica>()
                           .ToList();
            }
        }

        public List<Dados.PessoaFisica> GetByNome(string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.CliFor.OfType<Dados.PessoaFisica>()
                           .Where(a => a.Nome.Contains(nome))
                           .ToList();
            }
        }

        public List<Dados.PessoaFisica> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.PessoaFisica GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.CliFor
                           .Include(a => a.CliForReferencia)
                           .FirstOrDefault(a => a.IdCliFor == id) as Dados.PessoaFisica;
            }
        }

        public bool IsValid(Dados.PessoaFisica item)
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

        public Dados.PessoaFisica Insert(Dados.PessoaFisica item)
        {
            
            throw new NotImplementedException();
        }

        public Dados.PessoaFisica Update(Dados.PessoaFisica item)
        {
            
            throw new NotImplementedException();
        }

        public Dados.PessoaFisica Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.PessoaFisica> lista)
        {
            throw new NotImplementedException();
        }
    }
}
