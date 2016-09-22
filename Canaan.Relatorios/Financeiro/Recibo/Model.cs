using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Relatorios.Financeiro.Recibo
{
    public class Model
    {
        public string Cliente { get; set; }
        public string Usuario { get; set; }
        public string Caixa { get; set; }
        public string TipoPagamento { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal ValorBaixado { get; set; }
        public decimal ValorTroco { get; set; }
        public string Lancamentos { get; set; }
        public byte[] Logo { get; set; }
    }
}
