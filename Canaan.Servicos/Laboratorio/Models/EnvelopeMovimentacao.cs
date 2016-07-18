using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class EnvelopeMovimentacao
    {
        public int IdMovimentacao { get; set; }
        public int IdEnvelope { get; set; }
        public int IdStatus { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
    }
}
