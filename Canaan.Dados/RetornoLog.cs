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
    
    public partial class RetornoLog
    {
        public int IdLog { get; set; }
        public int IdRetorno { get; set; }
        public EnumRetornoLog StatusLog { get; set; }
        public string Documento { get; set; }
        public string NossoNumero { get; set; }
        public decimal ValorPago { get; set; }
        public string Informacao { get; set; }
        public bool IsErro { get; set; }
    
        public virtual Retorno Retorno { get; set; }
    }
}