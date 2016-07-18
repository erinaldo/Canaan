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
    
    public partial class Venda : Pedido
    {
        public Venda()
        {
            this.VendaItem = new HashSet<VendaItem>();
            this.VendaMov = new HashSet<VendaMov>();
            this.VendaFoto = new HashSet<VendaFoto>();
            this.OrdemServico = new HashSet<OrdemServico>();
            this.Envio = new HashSet<Envio>();
        }
    
        public int IdAtendimento { get; set; }
        public Nullable<int> IdFormaEntrada { get; set; }
        public EnumStatusVenda Status { get; set; }
        public Nullable<decimal> ValorEntrada { get; set; }
        public Nullable<System.DateTime> DataVenda { get; set; }
        public Nullable<bool> IsFaturado { get; set; }
        public Nullable<System.DateTime> DataFaturamento { get; set; }
        public Nullable<bool> IsLiberado { get; set; }
        public Nullable<System.DateTime> DataLiberacao { get; set; }
        public bool IsDevolvida { get; set; }
        public Nullable<System.DateTime> DataDevolucao { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public bool IsConfirmado { get; set; }
        public Nullable<System.DateTime> DataConfirmacao { get; set; }
        public Nullable<decimal> EntradaDinheiro { get; set; }
        public Nullable<decimal> EntradaCartao { get; set; }
        public Nullable<decimal> EntradaDepositada { get; set; }
        public Nullable<decimal> VendaDinheiro { get; set; }
        public Nullable<decimal> VendaCartao { get; set; }
        public Nullable<int> TipoVenda { get; set; }
        public Nullable<decimal> ValorCrediario { get; set; }
    
        public virtual Atendimento Atendimento { get; set; }
        public virtual ICollection<VendaItem> VendaItem { get; set; }
        public virtual ICollection<VendaMov> VendaMov { get; set; }
        public virtual ICollection<VendaFoto> VendaFoto { get; set; }
        public virtual FormaEntrada FormaEntrada { get; set; }
        public virtual ICollection<OrdemServico> OrdemServico { get; set; }
        public virtual VendaStatus VendaStatus { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<Envio> Envio { get; set; }
    }
}
