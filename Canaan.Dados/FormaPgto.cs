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
    
    public partial class FormaPgto
    {
        public FormaPgto()
        {
            this.Pedido = new HashSet<Pedido>();
        }
    
        public int IdFormaPgto { get; set; }
        public string Nome { get; set; }
        public int NumParcela { get; set; }
        public int DistParcela { get; set; }
        public int DistEntrada { get; set; }
        public decimal Juros { get; set; }
        public decimal Desconto { get; set; }
        public bool IsAtivo { get; set; }
    
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
