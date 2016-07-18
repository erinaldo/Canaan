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
    
    public partial class Lancamento
    {
        public Lancamento()
        {
            this.LancamentoMov = new HashSet<LancamentoMov>();
            this.LancamentoHist = new HashSet<LancamentoHist>();
            this.RenegociacaoItem = new HashSet<RenegociacaoItem>();
        }
    
        public int IdLancamento { get; set; }
        public int IdCliFor { get; set; }
        public int IdFilial { get; set; }
        public int IdContaCaixa { get; set; }
        public EnumLancTipo Tipo { get; set; }
        public EnumStatusLanc Status { get; set; }
        public EnumClasseContabil ClasseContabil { get; set; }
        public System.DateTime DataEmissao { get; set; }
        public System.DateTime DataVencimento { get; set; }
        public Nullable<System.DateTime> DataBaixa { get; set; }
        public Nullable<System.DateTime> DataAgendamento { get; set; }
        public decimal ValorOriginal { get; set; }
        public decimal ValorJuros { get; set; }
        public decimal ValorMulta { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorAcrescimo { get; set; }
        public decimal ValorLiquido { get; set; }
        public Nullable<decimal> ValorBaixado { get; set; }
        public string NossoNumero { get; set; }
        public string Ipte { get; set; }
        public string CodigoBarras { get; set; }
        public bool IsEntrada { get; set; }
        public Nullable<int> IdPedido { get; set; }
        public string NossoNumeroDac { get; set; }
        public Nullable<int> IdExtrato { get; set; }
        public string Descricao { get; set; }
        public string Observacoes { get; set; }
    
        public virtual CliFor CliFor { get; set; }
        public virtual Filial Filial { get; set; }
        public virtual ContaCaixa ContaCaixa { get; set; }
        public virtual ICollection<LancamentoMov> LancamentoMov { get; set; }
        public virtual ICollection<LancamentoHist> LancamentoHist { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual Extrato Extrato { get; set; }
        public virtual ICollection<RenegociacaoItem> RenegociacaoItem { get; set; }
    }
}
