using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Telas.Laboratorio.Pendentes
{
    public class GridModel
    {
        public int IdEnvio { get; set; }
        public int IdPedido { get; set; }
        public int CodigoReduzido { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
