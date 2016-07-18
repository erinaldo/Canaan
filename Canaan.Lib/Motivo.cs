using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class Motivo
    {

        public List<Dados.Motivo> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Motivo.ToList();
            }
        }

        public List<Dados.Motivo> GetMotivos(Dados.VendaMov devolucao)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.MotivoDevolucao
                           .Where(a => a.IdVendaMov == devolucao.IdMov)
                           .Select(a => a.Motivo).ToList();
            }
        }
    }
}
