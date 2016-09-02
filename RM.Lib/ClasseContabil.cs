using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Lib
{
    public class ClasseContabil
    {
        public static List<Dados.FTB1> Get(short codcoligada) 
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities()) 
            {
                return conn.FTB1.Where(a => a.CODCOLIGADA == codcoligada).ToList();
            }
        }

        public static Dados.FTB1 Get(short codcoligada, string codclasse)
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                return conn.FTB1
                           .FirstOrDefault(a => a.CODCOLIGADA == codcoligada &&
                                                a.CODTB1FLX == codclasse);
            }
        }
    }
}
