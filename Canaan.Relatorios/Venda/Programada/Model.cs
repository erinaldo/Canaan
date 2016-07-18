using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Relatorios.Venda.Programada
{
    public class Model
    {
        public int CodigoReduzido { get; set; }
        public string Cliente { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime DataEntrada { get; set; }
        public decimal Valor { get; set; }
    }

    public enum EnumTipoData 
    { 
        Venda,
        Entrada
    }
}
