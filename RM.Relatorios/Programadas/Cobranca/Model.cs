using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Relatorios.Programadas.Cobranca
{
    public class Model
    {
        public short CodColigada { get; set; }
        public short CodFilial { get; set; }
        public int CodLancamento { get; set; }
        public int CodVenda { get; set; }
        public string CodClasse { get; set; }
        public string CodVendedor { get; set; }
        public string CodCliente { get; set; }
        public int CodCmaster { get; set; }
        public string NomeVendedor { get; set; }
        public string NomeCliente { get; set; }
        public string TelFixo { get; set; }
        public string TelCelular { get; set; }
        public string TelFax { get; set; }
        public string TelComercial { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal Valor { get; set; }
        public int NumParcelas { get; set; }
        public int NumPagas { get; set; }
        public int NumRestantes { get; set; }
        public int StatusLan { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorVenda { get; set; }
    }
}
