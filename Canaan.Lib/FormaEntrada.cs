using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class FormaEntrada : IBase<Dados.FormaEntrada>
    {

        public List<Dados.FormaEntrada> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.FormaEntrada.ToList();
            }
        }

        public List<Dados.FormaEntrada> GetByNome(string nome)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.FormaEntrada.Where(a => a.Nome.Contains(nome)).ToList();
            }
        }

        public List<Dados.FormaEntrada> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.FormaEntrada GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Dados.FormaEntrada Insert(Dados.FormaEntrada item)
        {
            throw new NotImplementedException();
        }

        public Dados.FormaEntrada Update(Dados.FormaEntrada item)
        {
            throw new NotImplementedException();
        }

        public Dados.FormaEntrada Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.FormaEntrada> lista)
        {
            throw new NotImplementedException();
        }
    }
}
