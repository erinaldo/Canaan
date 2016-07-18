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
    
    public partial class Retorno
    {
        public Retorno()
        {
            this.RetornoLog = new HashSet<RetornoLog>();
        }
    
        public int IdRetorno { get; set; }
        public int IdFilial { get; set; }
        public int IdContaCaixa { get; set; }
        public int IdUsuario { get; set; }
        public System.DateTime Data { get; set; }
        public string Arquivo { get; set; }
    
        public virtual ContaCaixa ContaCaixa { get; set; }
        public virtual Filial Filial { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<RetornoLog> RetornoLog { get; set; }
    }
}
