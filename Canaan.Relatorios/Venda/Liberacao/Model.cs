using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Relatorios.Venda.Liberacao
{
    public class Model
    {
        public int CodigoReduzido { get; set; }
        public string Cliente { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
    }

    public enum TipoRelatorio 
    { 
        Gerencial,
        Escritorio,
        Programada
    }
}
