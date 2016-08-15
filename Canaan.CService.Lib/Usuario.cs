using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Canaan.CService.Lib
{
    public class Usuario
    {
        public static Dados.env_usuarios GetByLogin(string username, string password) 
        {
            using (var conn = new Dados.CServicosEntities())
            {
                return conn.env_usuarios
                           .Include(a => a.env_usuarios_grupos)
                           .FirstOrDefault(a => a.username == username && a.password == password);
            }
        }
    }
}
