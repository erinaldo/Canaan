using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class Config : IBase<Dados.Config>
    {
        public List<Dados.Config> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer()) 
            {
                return conn.Config.ToList();
            }
        }

        public Dados.Config GetByFilial(int idFilial)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Config.FirstOrDefault(a => a.IdFilial == idFilial);
            }
        }

        public List<Dados.Config> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.Config> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.Config GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Dados.Config Insert(Dados.Config item)
        {
            throw new NotImplementedException();
        }

        public Dados.Config Update(Dados.Config item)
        {
            throw new NotImplementedException();
        }

        public Dados.Config Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.Config> lista)
        {
            throw new NotImplementedException();
        }
    }
}
