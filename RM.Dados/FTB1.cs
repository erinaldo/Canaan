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
    
    public partial class FTB1
    {
        public FTB1()
        {
            this.TMOV = new HashSet<TMOV>();
            this.FLAN = new HashSet<FLAN>();
            this.FXCX = new HashSet<FXCX>();
            this.TITMMOV = new HashSet<TITMMOV>();
        }
    
        public short CODCOLIGADA { get; set; }
        public string CODTB1FLX { get; set; }
        public string DESCRICAO { get; set; }
        public string CAMPOLIVRE { get; set; }
        public string CODDEPARTAMENTO { get; set; }
        public string CODCCUSTO { get; set; }
        public Nullable<short> CODFILIAL { get; set; }
        public Nullable<decimal> DESCONTO { get; set; }
        public Nullable<short> CODEVENTO { get; set; }
        public Nullable<short> CODEVENTOBX { get; set; }
        public Nullable<short> CODEVENTOBXCONT { get; set; }
        public Nullable<short> CODEVENTOXCX { get; set; }
        public Nullable<short> PERMITELANC { get; set; }
        public Nullable<short> ATIVO { get; set; }
        public string CODBENEFICIO { get; set; }
        public Nullable<short> CODEVENTOCRT { get; set; }
        public Nullable<short> CODEVENTOBXACORDO { get; set; }
        public Nullable<short> CODEVENTOGERADOACORDO { get; set; }
        public string RECCREATEDBY { get; set; }
        public Nullable<System.DateTime> RECCREATEDON { get; set; }
        public string RECMODIFIEDBY { get; set; }
        public Nullable<System.DateTime> RECMODIFIEDON { get; set; }
    
        public virtual GFILIAL GFILIAL { get; set; }
        public virtual ICollection<TMOV> TMOV { get; set; }
        public virtual GCOLIGADA GCOLIGADA { get; set; }
        public virtual ICollection<FLAN> FLAN { get; set; }
        public virtual ICollection<FXCX> FXCX { get; set; }
        public virtual ICollection<TITMMOV> TITMMOV { get; set; }
        public virtual GCCUSTO GCCUSTO { get; set; }
    }
}