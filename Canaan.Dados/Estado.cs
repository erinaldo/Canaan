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
    
    public partial class Estado
    {
        public Estado()
        {
            this.Cidade = new HashSet<Cidade>();
        }
    
        public int IdEstado { get; set; }
        public int IdPais { get; set; }
        public string Nome { get; set; }
        public string Abreviatura { get; set; }
    
        public virtual Pais Pais { get; set; }
        public virtual ICollection<Cidade> Cidade { get; set; }
    }
}
