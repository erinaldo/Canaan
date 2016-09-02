using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CPanel.Lib
{
    public class Setores
    {
        public static List<CPanel.Dados.setores> Get() 
        {
            using (var conn = new CPanel.Dados.CPanelEntities()) 
            {
                return conn.setores.OrderBy(a => a.nome).ToList();
            }
        }
    }
}
