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
    
    public partial class periodos_feriados
    {
        public int id_periodo_feriado { get; set; }
        public Nullable<int> id_periodo { get; set; }
        public Nullable<System.DateTime> data { get; set; }
        public string descricao { get; set; }
        public bool aberto { get; set; }
    
        public virtual periodos periodos { get; set; }
    }
}
