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
    
    public partial class GMUNICIPIO
    {
        public GMUNICIPIO()
        {
            this.GFILIAL = new HashSet<GFILIAL>();
            this.TMOV = new HashSet<TMOV>();
            this.TITMMOV = new HashSet<TITMMOV>();
            this.PPESSOA = new HashSet<PPESSOA>();
        }
    
        public string CODMUNICIPIO { get; set; }
        public string CODETDMUNICIPIO { get; set; }
        public string NOMEMUNICIPIO { get; set; }
        public string RECCREATEDBY { get; set; }
        public Nullable<System.DateTime> RECCREATEDON { get; set; }
        public string RECMODIFIEDBY { get; set; }
        public Nullable<System.DateTime> RECMODIFIEDON { get; set; }
    
        public virtual GETD GETD { get; set; }
        public virtual ICollection<GFILIAL> GFILIAL { get; set; }
        public virtual ICollection<TMOV> TMOV { get; set; }
        public virtual ICollection<TITMMOV> TITMMOV { get; set; }
        public virtual ICollection<PPESSOA> PPESSOA { get; set; }
    }
}