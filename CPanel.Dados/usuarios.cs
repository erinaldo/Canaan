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
    
    public partial class usuarios
    {
        public usuarios()
        {
            this.lancamentos = new HashSet<lancamentos>();
        }
    
        public int id_usuario { get; set; }
        public Nullable<int> id_usuario_grupo { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    
        public virtual usuarios_grupos usuarios_grupos { get; set; }
        public virtual ICollection<lancamentos> lancamentos { get; set; }
    }
}