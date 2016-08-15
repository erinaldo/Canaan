using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.CService.Lib.Model
{
    public class ConsultaModel
    {
        public int ? CodPacote { get; set; }
        public string Cliente { get; set; }
        public int ? Quantidade { get; set; }
        public string Servico { get; set; }
        public string Status { get; set; }
        public DateTime?  DataStatus { get; set; }
        public DateTime? EntradaCPC { get; set; }
        public DateTime? Previsao { get; set; }

    }
}
