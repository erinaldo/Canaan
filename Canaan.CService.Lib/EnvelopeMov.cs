using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.CService.Lib
{
    public class EnvelopeMov
    {
        public void Insert(int idEnvelope, Canaan.Lib.Model.Envio.EnumStatusEnvio status)
        {
            using (var conn = new Dados.CServicosEntities())
            {
                var mov = new Dados.env_envelopes_mov
                {
                     id_envelope = idEnvelope,
                     id_status = (int)status,
                     id_usuario = 1,
                     data = DateTime.Today
                };

                conn.env_envelopes_mov.Add(mov);
                conn.SaveChanges();
            }
        }

        public static void Insert(int idEnvelope, int status)
        {
            using (var conn = new Dados.CServicosEntities())
            {
                var mov = new Dados.env_envelopes_mov
                {
                    id_envelope = idEnvelope,
                    id_status = status,
                    id_usuario = 1,
                    data = DateTime.Today
                };

                conn.env_envelopes_mov.Add(mov);
                conn.SaveChanges();
            }
        }
    }
}
