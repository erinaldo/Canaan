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
    
    public partial class cadernos_devolucoes
    {
        public int id_devolvida { get; set; }
        public int id_venda { get; set; }
        public int id_motivo { get; set; }
        public string observacao { get; set; }
    
        public virtual cadernos_devolucoes_motivos cadernos_devolucoes_motivos { get; set; }
        public virtual cadernos_vendas cadernos_vendas { get; set; }
    }
}