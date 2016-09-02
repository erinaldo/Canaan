using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Relatorios.Entradas.Recebimento
{
    public class Model
    {
        public string CodCMaster { get; set; }
        public string CodRm { get; set; }
        public string NomeCliente { get; set; }
        public string NomeVendedora { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataBaixa { get; set; }
        public int ParcelaAtual { get; set; }
        public int NumParcelas { get; set; }
        public string ContaCaixa { get; set; }
        public decimal ValorBaixado { get; set; }
    }
}
