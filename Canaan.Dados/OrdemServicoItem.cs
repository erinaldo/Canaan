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
    
    public partial class OrdemServicoItem
    {
        public int IdItem { get; set; }
        public int IdOrdemServico { get; set; }
        public int IdFoto { get; set; }
        public Nullable<int> IdEfeito { get; set; }
        public int Quantidade { get; set; }
        public string Observacao { get; set; }
    
        public virtual EfeitoDigital EfeitoDigital { get; set; }
        public virtual Foto Foto { get; set; }
        public virtual OrdemServico OrdemServico { get; set; }
    }
}
