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
    
    public partial class FCONTA
    {
        public FCONTA()
        {
            this.FCXA = new HashSet<FCXA>();
        }
    
        public short CODCOLIGADA { get; set; }
        public string NUMBANCO { get; set; }
        public string NUMAGENCIA { get; set; }
        public string NROCONTA { get; set; }
        public Nullable<short> TIPO { get; set; }
        public string CONVENIO { get; set; }
        public string CARTEIRA { get; set; }
        public Nullable<short> TIPOCOB { get; set; }
        public string CEDENTE { get; set; }
        public string CGCCEDENTE { get; set; }
        public Nullable<short> CODCOLCFO { get; set; }
        public string CODCFO { get; set; }
        public string DIGCONTA { get; set; }
        public string DIGCONVENIO { get; set; }
        public string NROOFICIALCONTA { get; set; }
        public Nullable<short> TIPOCARTEIRA { get; set; }
        public string CODCEDENTE { get; set; }
        public string DIGCEDENTE { get; set; }
        public Nullable<short> TIPOCONTA { get; set; }
        public string DIGAGENCIACONTA { get; set; }
        public string RECCREATEDBY { get; set; }
        public Nullable<System.DateTime> RECCREATEDON { get; set; }
        public string RECMODIFIEDBY { get; set; }
        public Nullable<System.DateTime> RECMODIFIEDON { get; set; }
    
        public virtual GCOLIGADA GCOLIGADA { get; set; }
        public virtual ICollection<FCXA> FCXA { get; set; }
    }
}