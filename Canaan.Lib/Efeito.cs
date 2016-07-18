using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class EfeitoDigital : IBase<Dados.EfeitoDigital>
    {

        public List<Dados.EfeitoDigital> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.EfeitoDigital.OrderBy(a => a.Nome).ToList();
            }
        }

        public List<Dados.EfeitoDigital> GetByNome(string nome)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.EfeitoDigital.Where(a => a.Nome.Contains(nome)).OrderBy(a => a.Nome).ToList();
            }
        }

        public List<Dados.EfeitoDigital> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.EfeitoDigital GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Dados.EfeitoDigital Insert(Dados.EfeitoDigital item)
        {
            throw new NotImplementedException();
        }

        public Dados.EfeitoDigital Update(Dados.EfeitoDigital item)
        {
            throw new NotImplementedException();
        }

        public Dados.EfeitoDigital Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.EfeitoDigital> lista)
        {
            throw new NotImplementedException();
        }
    }
}
