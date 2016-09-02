using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Relatorios.Programadas.Comparativo
{
    public class Model
    {
        public string NomeEstudio { get; set; }
        public decimal Receber { get; set; }
        public decimal Recebido { get; set; }
        public decimal Aberto { get; set; }
        public decimal Percentual { get; set; }
    }
}
