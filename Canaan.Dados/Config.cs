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
    
    public partial class Config
    {
        public int IdConfig { get; set; }
        public string ServImagem { get; set; }
        public string Folder { get; set; }
        public bool IsCriptogradado { get; set; }
        public decimal Financ_Juros { get; set; }
        public decimal Financ_Multa { get; set; }
        public int IdFilial { get; set; }
        public string FtpHost { get; set; }
        public string FtpUser { get; set; }
        public string FtpPass { get; set; }
        public Nullable<int> FtpPort { get; set; }
        public string FtpFolder { get; set; }
        public Nullable<int> CServiceId { get; set; }
        public Nullable<int> CPanelId { get; set; }
        public Nullable<int> RMColigada { get; set; }
        public Nullable<int> RMFilial { get; set; }
        public int CurrentAtendimento { get; set; }
        public int CurrentBackup { get; set; }
        public Nullable<bool> UsaFinanceiro { get; set; }
        public Nullable<int> CMarketingId { get; set; }
        public Nullable<bool> UsaManipulacao { get; set; }
        public string LocalHost { get; set; }
        public string LocalFolder { get; set; }
        public Nullable<bool> PastaUsaAno { get; set; }
        public Nullable<bool> PastaUsaMes { get; set; }
        public Nullable<bool> UsaLiberacao { get; set; }
        public string TextoEvento { get; set; }
        public string TextoContrato { get; set; }
        public Nullable<bool> UsaAtendimentoAutomatico { get; set; }
        public byte[] Logomarca { get; set; }
        public Nullable<bool> UsaBaixaEntrada { get; set; }
    
        public virtual Filial Filial { get; set; }
    }
}
