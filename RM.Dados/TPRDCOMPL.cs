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
    
    public partial class TPRDCOMPL
    {
        public short CODCOLIGADA { get; set; }
        public int IDPRD { get; set; }
        public Nullable<decimal> ESTOQUEPADRAO { get; set; }
        public Nullable<decimal> ESTOQUEMEGA { get; set; }
        public Nullable<decimal> ESTOQUEFLEX { get; set; }
        public Nullable<decimal> ESTOQUEBABY { get; set; }
        public string ESTOQUECOMPACTO { get; set; }
        public Nullable<decimal> ESTOQUECOMPACT { get; set; }
        public string RECCREATEDBY { get; set; }
        public Nullable<System.DateTime> RECCREATEDON { get; set; }
        public string RECMODIFIEDBY { get; set; }
        public Nullable<System.DateTime> RECMODIFIEDON { get; set; }
        public string USABLOCO { get; set; }
        public string HASBLOCO { get; set; }
        public string HACAPA { get; set; }
        public string HASEMBALAGEM { get; set; }
        public string HASINOX { get; set; }
        public string HASACRILICO { get; set; }
        public string HASMADEIRA { get; set; }
        public string ISMIGACAO { get; set; }
    
        public virtual TPRODUTO TPRODUTO { get; set; }
    }
}
