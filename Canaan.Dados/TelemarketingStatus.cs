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
    
    public partial class TelemarketingStatus
    {
        public TelemarketingStatus()
        {
            this.Cupom = new HashSet<Cupom>();
            this.TelemarketingMov = new HashSet<TelemarketingMov>();
        }
    
        public EnumTelemarketingStatus IdStatus { get; set; }
        public string Nome { get; set; }
        public int Pontos { get; set; }
    
        public virtual ICollection<Cupom> Cupom { get; set; }
        public virtual ICollection<TelemarketingMov> TelemarketingMov { get; set; }
    }
}
