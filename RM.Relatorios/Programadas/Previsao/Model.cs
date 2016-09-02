using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Relatorios.Programadas.Previsao
{
    public class Model
    {
        public string NomeEstudio { get; set; }
        public int Parcelas { get; set; }
        public int ParcelasPagas { get; set; }
        public int ParcelasAberto { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorPagas { get; set; }
        public decimal ValorAberto { get; set; }
    }
}
