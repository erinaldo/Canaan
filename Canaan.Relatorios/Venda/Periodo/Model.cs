using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Relatorios.Venda.Periodo
{
    public class Model
    {
        public int IdVenda { get; set; }
        public int CodigoReduzido { get; set; }
        public string Cliente { get; set; }
        public string Produtos { get; set; }
        public string Vendedor { get; set; }
        public DateTime Data { get; set; }
        public string DataEntrada { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorAcrescimo { get; set; }
        public decimal ValorEntrada { get; set; }
        public decimal ValorLiquido { get; set; }
        public string FormaPgto  { get; set; }
        public byte[] Logo { get; set; }
    }
}
