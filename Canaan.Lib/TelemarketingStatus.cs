using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class TelemarketingStatus : IBase<Dados.TelemarketingStatus>
    {
        public List<Dados.TelemarketingStatus> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.TelemarketingStatus.ToList();
            }
        }

        public List<Dados.TelemarketingStatus> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.TelemarketingStatus> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.TelemarketingStatus GetById(Dados.EnumTelemarketingStatus status)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.TelemarketingStatus.FirstOrDefault(a => a.IdStatus == status);
            }
        }

        public Dados.TelemarketingStatus GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Dados.TelemarketingStatus Insert(Dados.TelemarketingStatus item)
        {
            throw new NotImplementedException();
        }

        public Dados.TelemarketingStatus Update(Dados.TelemarketingStatus item)
        {
            throw new NotImplementedException();
        }

        public Dados.TelemarketingStatus Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.TelemarketingStatus> lista)
        {
            throw new NotImplementedException();
        }

  
    }
}
