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
    
    public partial class TVEN
    {
        public TVEN()
        {
            this.FCFO = new HashSet<FCFO>();
            this.TMOV = new HashSet<TMOV>();
            this.TMOV1 = new HashSet<TMOV>();
            this.TMOV2 = new HashSet<TMOV>();
            this.TMOV3 = new HashSet<TMOV>();
            this.FLAN = new HashSet<FLAN>();
            this.TITMMOV = new HashSet<TITMMOV>();
        }
    
        public short CODCOLIGADA { get; set; }
        public string CODVEN { get; set; }
        public string NOME { get; set; }
        public string CARGO { get; set; }
        public Nullable<short> CODFILIAL { get; set; }
        public string CODLOC { get; set; }
        public Nullable<decimal> COMISSAO1 { get; set; }
        public Nullable<decimal> COMISSAO2 { get; set; }
        public Nullable<decimal> COMISSAO3 { get; set; }
        public Nullable<int> CODPESSOA { get; set; }
        public Nullable<short> VENDECOMPRA { get; set; }
        public string CODUSUARIO { get; set; }
        public string SENHA { get; set; }
        public Nullable<short> INATIVO { get; set; }
        public Nullable<short> PFVENDEDOR { get; set; }
        public Nullable<short> PFCAIXA { get; set; }
        public Nullable<short> PFSUPERVISOR { get; set; }
        public Nullable<short> PFGERENTE { get; set; }
        public int IDFUNCIONARIO { get; set; }
        public Nullable<decimal> COMISSAO4 { get; set; }
        public Nullable<decimal> DESCMAXIMO { get; set; }
        public string RECCREATEDBY { get; set; }
        public Nullable<System.DateTime> RECCREATEDON { get; set; }
        public string RECMODIFIEDBY { get; set; }
        public Nullable<System.DateTime> RECMODIFIEDON { get; set; }
    
        public virtual ICollection<FCFO> FCFO { get; set; }
        public virtual GCOLIGADA GCOLIGADA { get; set; }
        public virtual GFILIAL GFILIAL { get; set; }
        public virtual ICollection<TMOV> TMOV { get; set; }
        public virtual ICollection<TMOV> TMOV1 { get; set; }
        public virtual ICollection<TMOV> TMOV2 { get; set; }
        public virtual ICollection<TMOV> TMOV3 { get; set; }
        public virtual ICollection<FLAN> FLAN { get; set; }
        public virtual ICollection<TITMMOV> TITMMOV { get; set; }
        public virtual PPESSOA PPESSOA { get; set; }
    }
}
