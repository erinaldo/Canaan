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
    
    public partial class VendaStatus
    {
        public VendaStatus()
        {
            this.Pedido_Venda = new HashSet<Venda>();
            this.VendaMov = new HashSet<VendaMov>();
        }
    
        public EnumStatusVenda IdStatus { get; set; }
        public string Descricao { get; set; }
    
        public virtual ICollection<Venda> Pedido_Venda { get; set; }
        public virtual ICollection<VendaMov> VendaMov { get; set; }
    }
}
