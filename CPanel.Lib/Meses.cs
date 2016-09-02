using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPanel.Lib
{
    public class Meses
    {
        public static List<CPanel.Dados.meses> Get() 
        {
            using (var conn = new CPanel.Dados.CPanelEntities()) 
            {
                return conn.meses.ToList();
            }
        }
    }
}
