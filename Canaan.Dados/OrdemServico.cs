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
    
    public partial class OrdemServico
    {
        public OrdemServico()
        {
            this.OrdemServicoMov = new HashSet<OrdemServicoMov>();
            this.VendaItemOrdemServico = new HashSet<VendaItemOrdemServico>();
            this.OrdemServicoItem = new HashSet<OrdemServicoItem>();
        }
    
        public int IdOrdemServico { get; set; }
        public int IdPedido { get; set; }
        public int IdServico { get; set; }
        public Nullable<int> IdAlbum { get; set; }
        public Nullable<int> IdMoldura { get; set; }
        public string NomeAbertura { get; set; }
        public System.DateTime Data { get; set; }
        public System.DateTime DataPrevista { get; set; }
        public string Observacao { get; set; }
        public EnumStatusServico Status { get; set; }
    
        public virtual Album Album { get; set; }
        public virtual Moldura Moldura { get; set; }
        public virtual ICollection<OrdemServicoMov> OrdemServicoMov { get; set; }
        public virtual Servico Servico { get; set; }
        public virtual ICollection<VendaItemOrdemServico> VendaItemOrdemServico { get; set; }
        public virtual Venda Pedido_Venda { get; set; }
        public virtual ICollection<OrdemServicoItem> OrdemServicoItem { get; set; }
        public virtual OrdemStatus OrdemStatus { get; set; }
    }
}
