using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class Moldura : IBase<Dados.Moldura>
    {
        public List<Dados.Moldura> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Moldura.ToList();
            }
        }

        public List<Dados.Moldura> GetByNome(string nome)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Moldura.Where(a => a.Nome.Contains(nome)).ToList();
            }
        }

        public List<Dados.Moldura> GetByStatus(bool status)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Moldura.Where(a => a.IsAtivo == status).ToList();
            }
        }

        public List<Dados.Moldura> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.Moldura GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Moldura.FirstOrDefault(a => a.IdMoldura == id);
            }
        }

        public Dados.Moldura Insert(Dados.Moldura item)
        {
            throw new NotImplementedException();
        }

        public Dados.Moldura Update(Dados.Moldura item)
        {
            throw new NotImplementedException();
        }

        public Dados.Moldura Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.Moldura> lista)
        {
            throw new NotImplementedException();
        }
    }
}
