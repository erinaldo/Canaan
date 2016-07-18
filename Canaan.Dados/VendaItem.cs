//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Canaan.Dados
{
    using System;
    using System.Collections.Generic;
    
    public partial class VendaItem
    {
        public VendaItem()
        {
            this.VendaItemOrdemServico = new HashSet<VendaItemOrdemServico>();
        }
    
        public int IdItem { get; set; }
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public decimal Quant { get; set; }
        public Nullable<decimal> ValorUnitario { get; set; }
        public Nullable<decimal> ValorTotal { get; set; }
    
        public virtual Venda Venda { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual ICollection<VendaItemOrdemServico> VendaItemOrdemServico { get; set; }
    }
}
