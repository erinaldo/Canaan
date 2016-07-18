using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class Telefone
    {
        public int IdTelefone { get; set; }
        public string Prefixo { get; set; }
        public string DDD { get; set; }
        public string Numero { get; set; }
        public string Operadora { get; set; }
        public bool IsMobile { get; set; }
        public bool IsWhatsApp { get; set; }
    }
}
