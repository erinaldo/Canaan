using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.CService.Lib
{
    public class Status
    {
        public static Dados.env_status GetById(int idStatus) 
        {
            using (var conn = new Dados.CServicosEntities()) 
            {
                return conn.env_status.FirstOrDefault(a => a.id_status == idStatus);
            }
        }
    }
}
