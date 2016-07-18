using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class Carta : IBase<Dados.Carta>
    {
        public List<Dados.Carta> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Carta.ToList();
            }
        }

        public List<Dados.Carta> GetByNome(string nome)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Carta.Where(a => a.Nome.Contains(nome)).ToList();
            }
        }

        public List<Dados.Carta> Filter(string filtro, object[] parameters)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Carta.Where(filtro, parameters).ToList();
            }
        }

        public List<Dados.Carta> GetByAtivo(bool status)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Carta.Where(a => a.IsAtivo == status).ToList();
            }
        }

        public Dados.Carta GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Carta.FirstOrDefault(a => a.IdCarta == id);
            }
        }

        public Dados.Carta Insert(Dados.Carta item)
        {
            throw new NotImplementedException();
        }

        public Dados.Carta Update(Dados.Carta item)
        {
            throw new NotImplementedException();
        }

        public Dados.Carta Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.Carta> lista)
        {
            throw new NotImplementedException();
        }

        public Dados.Carta GetDefault()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Carta.FirstOrDefault(a => a.IsDefault);
            }
        }
    }
}
