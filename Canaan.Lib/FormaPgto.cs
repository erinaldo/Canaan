using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class FormaPgto : IBase<Dados.FormaPgto>
    {
        public List<Dados.FormaPgto> Get()
        {
            using (var conn =  new Dados.CanaanModelContainer())
            {
                return conn.FormaPgto.ToList();
            }
        }

        public List<Dados.FormaPgto> GetByStatus(bool status)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.FormaPgto.Where(a => a.IsAtivo).ToList();
            }
        }

        public List<Dados.FormaPgto> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.FormaPgto> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.FormaPgto GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.FormaPgto.FirstOrDefault(a => a.IdFormaPgto == id);
            }
        }

        public Dados.FormaPgto Insert(Dados.FormaPgto item)
        {
            throw new NotImplementedException();
        }

        public Dados.FormaPgto Update(Dados.FormaPgto item)
        {
            throw new NotImplementedException();
        }

        public Dados.FormaPgto Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.FormaPgto> lista)
        {
            throw new NotImplementedException();
        }
    }
}
