//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CPanel.Dados
{
    using System;
    using System.Collections.Generic;
    
    public partial class metas_fluxo
    {
        public int id_meta_fluxo { get; set; }
        public Nullable<int> id_filial { get; set; }
        public Nullable<int> id_periodo { get; set; }
        public Nullable<int> id_periodo_semana { get; set; }
        public Nullable<decimal> valor_meta { get; set; }
        public Nullable<decimal> valor_alcancado { get; set; }
        public Nullable<decimal> perc_meta { get; set; }
        public Nullable<decimal> perc_alcancado { get; set; }
    
        public virtual filiais filiais { get; set; }
        public virtual periodos periodos { get; set; }
        public virtual periodos_semanas periodos_semanas { get; set; }
    }
}