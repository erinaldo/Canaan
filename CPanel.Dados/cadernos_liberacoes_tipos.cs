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
    
    public partial class cadernos_liberacoes_tipos
    {
        public cadernos_liberacoes_tipos()
        {
            this.cadernos_liberacoes = new HashSet<cadernos_liberacoes>();
        }
    
        public int id_tipo { get; set; }
        public string descricao { get; set; }
    
        public virtual ICollection<cadernos_liberacoes> cadernos_liberacoes { get; set; }
    }
}
