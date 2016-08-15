using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.CService.Lib
{
    public class Estudio
    {
        public static List<Dados.env_studios> Get() 
        {
            using (var conn = new Dados.CServicosEntities())
            {
                return conn.env_studios.ToList();
            }
        }

        public static Dados.env_studios GetById(int id)
        {
            using (var conn = new Dados.CServicosEntities())
            {
                return conn.env_studios.FirstOrDefault(a => a.id_studio == id);
            }
        }
    }
}
