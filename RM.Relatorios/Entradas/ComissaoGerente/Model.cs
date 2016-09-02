using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Relatorios.Entradas.ComissaoGerente
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
        public DateTime DataBaixa { get; set; }
        public decimal Percentual { get; set; }
        public decimal ValorBaixa { get; set; }
        public decimal ValorComissao { get; set; }
        public int StatusLan { get; set; }
    }
}
