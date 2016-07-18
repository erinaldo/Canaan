using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Relatorios.Venda.Devolvida
{
    public class Model
    {
        public int CodigoReduzido { get; set; }
        public string Cliente { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime DataDevolucao { get; set; }
        public decimal Valor { get; set; }
    }

}
