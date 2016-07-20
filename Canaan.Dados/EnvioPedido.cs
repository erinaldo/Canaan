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
    
    public partial class EnvioPedido
    {
        public EnvioPedido()
        {
            this.EnvioImagem = new HashSet<EnvioImagem>();
        }
    
        public int IdEnvioPedido { get; set; }
        public Nullable<int> IdEnvio { get; set; }
        public string Cliente { get; set; }
        public string Categoria { get; set; }
        public string Produto { get; set; }
        public string Tamanho { get; set; }
        public string Detalhes { get; set; }
        public string Observacoes { get; set; }
        public bool IsPendente { get; set; }
        public bool IsEnviado { get; set; }
    
        public virtual Envio Envio { get; set; }
        public virtual ICollection<EnvioImagem> EnvioImagem { get; set; }
    }
}