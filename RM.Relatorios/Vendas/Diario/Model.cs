using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Relatorios.Vendas.Diario
{
    public class Model
    {
        public short CodColigada { get; set; }
        public short CodFilial { get; set; }
        public int CodVenda { get; set; }
        public string CodRm { get; set; }
        public int CodCmaster { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataLiberacao { get; set; }
        public string NomeCliente { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorDespesa { get; set; }
        public decimal ValorLiquido { get; set; }
        public string TipoVenda { get; set; }
    }
}
