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
    
    public partial class EnvioImagem
    {
        public int IdEnvioImagem { get; set; }
        public int IdEnvioPedido { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Caminho { get; set; }
        public string Observacoes { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    
        public virtual EnvioPedido EnvioPedido { get; set; }
    }
}
