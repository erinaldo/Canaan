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
    
    public partial class Servico
    {
        public Servico()
        {
            this.ProdutoServico = new HashSet<ProdutoServico>();
            this.OrdemServico = new HashSet<OrdemServico>();
        }
    
        public int IdServico { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int PrevisaoEntrega { get; set; }
        public bool HasAlbum { get; set; }
        public bool HasMoldura { get; set; }
        public bool HasVoltagem { get; set; }
        public bool IsBrindeCpc { get; set; }
        public bool IsAtivo { get; set; }
        public Nullable<bool> IsEnvio { get; set; }
    
        public virtual ICollection<ProdutoServico> ProdutoServico { get; set; }
        public virtual ICollection<OrdemServico> OrdemServico { get; set; }
    }
}
