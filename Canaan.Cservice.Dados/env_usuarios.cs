//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Canaan.CService.Dados
{
    using System;
    using System.Collections.Generic;
    
    public partial class env_usuarios
    {
        public env_usuarios()
        {
            this.env_envelopes_mov = new HashSet<env_envelopes_mov>();
        }
    
        public int id_usuario { get; set; }
        public Nullable<int> id_usuario_grupo { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    
        public virtual ICollection<env_envelopes_mov> env_envelopes_mov { get; set; }
        public virtual env_usuarios_grupos env_usuarios_grupos { get; set; }
    }
}
