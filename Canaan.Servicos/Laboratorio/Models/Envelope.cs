using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class Envelope
    {
        public int IdEnvelope { get; set; }
        public int IdPedido { get; set; }
        public int IdStatus { get; set; }
        public string Descricao { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataPrevista { get; set; }
        public DateTime? DataFinalizado { get; set; }
        public bool IsPendente { get; set; }

        //relacionamentos
        public Pedido Pedido { get; set; }
        public Status Status { get; set; }
    }
}
