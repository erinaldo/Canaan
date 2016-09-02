using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Lib
{
    public class Vendedora
    {
        public static Dados.TVEN GetByVenda(int idMov, short codColigada) 
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities()) 
            {
                return conn.TMOV.Where(a => a.IDMOV == idMov && a.CODCOLIGADA == codColigada).Select(a => a.TVEN).FirstOrDefault();
            }
        }

        public static List<Dados.TVEN> GetByFilial(short codColigada, short codFilial) 
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities()) 
            {
                return conn.TVEN.Where(a => a.CODCOLIGADA == codColigada && a.CODFILIAL == codFilial).ToList();
            }
        }

        public static Dados.TVEN GetById(Dados.GFILIAL filial, string codigo)
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                return conn.TVEN.Where(a => a.CODCOLIGADA == filial.CODCOLIGADA && 
                                            a.CODFILIAL == filial.CODFILIAL &&
                                            a.CODVEN  == codigo)
                                .FirstOrDefault();
            }
        }
    }
}
