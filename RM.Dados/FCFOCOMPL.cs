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
    
    public partial class FCFOCOMPL
    {
        public short CODCOLIGADA { get; set; }
        public string CODCFO { get; set; }
        public string CONTATOCOB { get; set; }
        public string CLASSIFICACAO { get; set; }
        public Nullable<int> TIPO { get; set; }
        public string RECCREATEDBY { get; set; }
        public Nullable<System.DateTime> RECCREATEDON { get; set; }
        public string RECMODIFIEDBY { get; set; }
        public Nullable<System.DateTime> RECMODIFIEDON { get; set; }
        public string GFC { get; set; }
        public string RECIBOMANUAL { get; set; }
        public Nullable<int> PERCLIBERACAO { get; set; }
        public Nullable<int> CODCMASTER { get; set; }
        public string CODCOLIG { get; set; }
        public Nullable<System.DateTime> DATACOBRANCA { get; set; }
        public string OBSERVACOES { get; set; }
    
        public virtual FCFO FCFO { get; set; }
    }
}
