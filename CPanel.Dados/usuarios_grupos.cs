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
    
    public partial class usuarios_grupos
    {
        public usuarios_grupos()
        {
            this.usuarios = new HashSet<usuarios>();
        }
    
        public int id_usuario_grupo { get; set; }
        public string nome { get; set; }
        public Nullable<bool> lanc_periodo { get; set; }
        public Nullable<bool> lanc_lancamento { get; set; }
        public Nullable<bool> lanc_checklist { get; set; }
        public Nullable<bool> rel_lanc { get; set; }
        public Nullable<bool> rel_metas { get; set; }
        public Nullable<bool> rel_ranking { get; set; }
        public Nullable<bool> rel_perfil_rede { get; set; }
        public Nullable<bool> rel_perfil_indiv { get; set; }
        public Nullable<bool> rel_perfil_franquia { get; set; }
        public Nullable<bool> rel_checklist { get; set; }
        public Nullable<bool> rel_checklist_branco { get; set; }
        public Nullable<bool> config_filiais { get; set; }
        public Nullable<bool> config_setores { get; set; }
        public Nullable<bool> config_usuarios { get; set; }
        public Nullable<bool> config_usuarios_grupos { get; set; }
        public Nullable<bool> config_checklist_tipo { get; set; }
        public Nullable<bool> config_checklist_cat { get; set; }
        public Nullable<bool> config_checklist_item { get; set; }
    
        public virtual ICollection<usuarios> usuarios { get; set; }
    }
}