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
    
    public partial class env_usuarios_grupos
    {
        public env_usuarios_grupos()
        {
            this.env_usuarios = new HashSet<env_usuarios>();
        }
    
        public int id_usuario_grupo { get; set; }
        public string nome { get; set; }
        public Nullable<bool> mov { get; set; }
        public Nullable<bool> mov_cadastro { get; set; }
        public Nullable<bool> mov_impressao { get; set; }
        public Nullable<bool> mov_consulta { get; set; }
        public Nullable<bool> mov_status { get; set; }
        public Nullable<bool> mov_log { get; set; }
        public Nullable<bool> mov_cad_vol { get; set; }
        public Nullable<bool> mov_consult_vol { get; set; }
        public Nullable<bool> mov_serv_lab { get; set; }
        public Nullable<bool> mov_ctrl_qual { get; set; }
        public Nullable<bool> mov_finaliza_ped { get; set; }
        public Nullable<bool> mov_quant_ped { get; set; }
        public Nullable<bool> rel { get; set; }
        public Nullable<bool> rel_env { get; set; }
        public Nullable<bool> rel_env_prev { get; set; }
        public Nullable<bool> rel_env_status { get; set; }
        public Nullable<bool> rel_env_rota { get; set; }
        public Nullable<bool> rel_lab { get; set; }
        public Nullable<bool> rel_print_env { get; set; }
        public Nullable<bool> rel_print_vol { get; set; }
        public Nullable<bool> rel_rota { get; set; }
        public Nullable<bool> rel_fatura { get; set; }
        public Nullable<bool> rel_fatura_virtual { get; set; }
        public Nullable<bool> rel_fatura_dif { get; set; }
        public Nullable<bool> config { get; set; }
        public Nullable<bool> config_grupos { get; set; }
        public Nullable<bool> config_user { get; set; }
        public Nullable<bool> config_rotas { get; set; }
        public Nullable<bool> config_studios { get; set; }
        public Nullable<bool> config_tamanho { get; set; }
        public Nullable<bool> config_status { get; set; }
        public Nullable<bool> config_lab { get; set; }
        public Nullable<bool> config_server { get; set; }
        public Nullable<bool> config_album { get; set; }
        public Nullable<bool> config_moldura { get; set; }
        public Nullable<bool> config_qualidade { get; set; }
    
        public virtual ICollection<env_usuarios> env_usuarios { get; set; }
    }
}
