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
    
    public partial class Extrato
    {
        public Extrato()
        {
            this.Lancamento = new HashSet<Lancamento>();
        }
    
        public int IdExtrato { get; set; }
        public int IdContaCaixa { get; set; }
        public int IdUsuario { get; set; }
        public EnumPgtoTipo TipoPgto { get; set; }
        public EnumStatusExtrato Status { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorTroco { get; set; }
        public decimal ValorBaixado { get; set; }
        public System.DateTime Data { get; set; }
        public System.TimeSpan Hora { get; set; }
    
        public virtual ContaCaixa ContaCaixa { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<Lancamento> Lancamento { get; set; }
    }
}
