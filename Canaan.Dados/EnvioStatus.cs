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
    
    public partial class EnvioStatus
    {
        public EnvioStatus()
        {
            this.Envio = new HashSet<Envio>();
        }
    
        public EnumEnvioStatus IdStatus { get; set; }
        public string Descricao { get; set; }
    
        public virtual ICollection<Envio> Envio { get; set; }
    }
}
