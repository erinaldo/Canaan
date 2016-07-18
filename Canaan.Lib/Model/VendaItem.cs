using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib.Model
{
    public class VendaItem
    {
        public int Codigo { get; set; }
        public int IdVenda { get; set; }
        public string Produto { get; set; }
        public int IdProduto { get; set; }
        public string Valor { get; set; }
        public decimal Quantidade { get; set; }
        public DateTime Data { get; set; }
        public Dados.Produto Prod { get; set; }
        public Dados.EnumStatusVenda Status { get; set; }
        public List<Dados.Servico> Servicos { get; set; }
    }
}
