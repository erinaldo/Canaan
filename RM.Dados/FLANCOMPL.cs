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
    
    public partial class FLANCOMPL
    {
        public short CODCOLIGADA { get; set; }
        public int IDLAN { get; set; }
        public string HISTORICO { get; set; }
        public Nullable<System.DateTime> DTAGENDAMENTO { get; set; }
        public string RECCREATEDBY { get; set; }
        public Nullable<System.DateTime> RECCREATEDON { get; set; }
        public string RECMODIFIEDBY { get; set; }
        public Nullable<System.DateTime> RECMODIFIEDON { get; set; }
        public string ISRENEGOCIACAO { get; set; }
        public string RENEGOCIACAO { get; set; }
        public Nullable<decimal> PERCQUANTUM { get; set; }
    
        public virtual FLAN FLAN { get; set; }
    }
}
