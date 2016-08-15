using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.CService.Telas.Integracao.Fechamento
{
    public class PedidoProducao
    {
        public int Codigo { get; set; }
        public string Cliente { get; set; }
        public string Cidade { get; set; }
        public List<PedidoProducaoItem> Itens { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorAcrescimo { get; set; }
        public decimal ValorTotal
        {
            get
            {
                return this.Itens.Sum(a => a.ValorTotal) - this.ValorDesconto + this.ValorAcrescimo;
            }
        }

        public PedidoProducao()
        {
            this.ValorAcrescimo = 0;
            this.ValorDesconto = 0;
            this.Itens = new List<PedidoProducaoItem>();
        }
    }

    public class PedidoProducaoItem
    {
        public int Codigo { get; set; }
        public decimal Quantidade { get; set; }
        public string Produto { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }

        public PedidoProducaoItem()
        {
            this.Quantidade = 0;
            this.ValorUnitario = 0;
            this.ValorTotal = 0;
        }
    }
}
