//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RM.Dados
{
    using System;
    using System.Collections.Generic;
    
    public partial class PFFINANC
    {
        public short CODCOLIGADA { get; set; }
        public string CHAPA { get; set; }
        public short ANOCOMP { get; set; }
        public short MESCOMP { get; set; }
        public short NROPERIODO { get; set; }
        public string CODEVENTO { get; set; }
        public Nullable<System.DateTime> DTPAGTO { get; set; }
        public Nullable<short> HORA { get; set; }
        public Nullable<decimal> REF { get; set; }
        public Nullable<decimal> VALOR { get; set; }
        public Nullable<decimal> VALORORIGINAL { get; set; }
        public Nullable<short> ALTERADOMANUAL { get; set; }
        public Nullable<short> VERBAFERIAS { get; set; }
        public Nullable<short> ORIGEMMOV { get; set; }
        public string RECCREATEDBY { get; set; }
        public Nullable<System.DateTime> RECCREATEDON { get; set; }
        public string RECMODIFIEDBY { get; set; }
        public Nullable<System.DateTime> RECMODIFIEDON { get; set; }
    
        public virtual PEVENTO PEVENTO { get; set; }
    }
}
