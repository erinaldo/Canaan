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
    
    public partial class PEVENTO
    {
        public PEVENTO()
        {
            this.PEVENTO1 = new HashSet<PEVENTO>();
            this.PEVENTO11 = new HashSet<PEVENTO>();
            this.PFFINANC = new HashSet<PFFINANC>();
            this.PFUNC = new HashSet<PFUNC>();
        }
    
        public short CODCOLIGADA { get; set; }
        public string CODIGO { get; set; }
        public string TOTALIZADOR { get; set; }
        public string CHAVE { get; set; }
        public Nullable<short> COMPOECOMISSAO { get; set; }
        public string PROVDESCBASE { get; set; }
        public string VALHORDIAREF { get; set; }
        public Nullable<decimal> PORCINCID { get; set; }
        public Nullable<short> CODIGOCALCULO { get; set; }
        public Nullable<short> PRIORIDADE { get; set; }
        public string FORMULAVALOR { get; set; }
        public string FORMULAHORA { get; set; }
        public string FORMULAREF { get; set; }
        public string FORMULACRITICA { get; set; }
        public Nullable<short> INCINSS { get; set; }
        public Nullable<short> INCIRRF { get; set; }
        public Nullable<short> INCFGTS { get; set; }
        public Nullable<short> INCRAIS { get; set; }
        public Nullable<short> INCINFREND { get; set; }
        public Nullable<short> INCDSR { get; set; }
        public Nullable<short> INCVALETRANSP { get; set; }
        public Nullable<short> INCIRRFFERIAS { get; set; }
        public Nullable<short> INCTERCOFERIAS { get; set; }
        public Nullable<short> INCSALFAMILIA { get; set; }
        public Nullable<short> INCINSS13 { get; set; }
        public Nullable<short> INCIRRF13 { get; set; }
        public string INCACUMULADOR { get; set; }
        public Nullable<short> INCSALARIO { get; set; }
        public Nullable<short> PROPORCADMISSAO { get; set; }
        public Nullable<short> PROPORCLICENCA { get; set; }
        public Nullable<short> PROPORCFERIAS { get; set; }
        public Nullable<short> DEDUTIVELIRRF { get; set; }
        public Nullable<short> ESTCALCULO { get; set; }
        public Nullable<short> ESTCALCFERIAS { get; set; }
        public Nullable<short> ESTCALCSALFAM { get; set; }
        public Nullable<short> ESTCALCVALETR { get; set; }
        public Nullable<short> ESTINSS13 { get; set; }
        public Nullable<short> GRUPOAAS { get; set; }
        public string EVTALANCAR { get; set; }
        public string CONTACREDITO { get; set; }
        public string CONTADEBITO { get; set; }
        public string NROHISTPADRAO { get; set; }
        public string COMPLHISTORICO { get; set; }
        public string APLICACAO { get; set; }
        public string CGCREDITO { get; set; }
        public string CGDEBITO { get; set; }
        public string CODEVENTODIF { get; set; }
        public string CODRATEIO { get; set; }
        public string DESCRICAO { get; set; }
        public string BASESALCOMPOSTO { get; set; }
        public Nullable<short> DESCONTOPERDOADO { get; set; }
        public Nullable<short> PROPPORTOMADOR { get; set; }
        public Nullable<short> PAGOBRIGATORIO { get; set; }
        public Nullable<short> TEMINTCONTCC { get; set; }
        public Nullable<short> TEMINTCONTCD { get; set; }
        public Nullable<short> TEMINTCONTGC { get; set; }
        public Nullable<short> TEMINTCONTGD { get; set; }
        public Nullable<short> TEMINTFUNCCC { get; set; }
        public Nullable<short> TEMINTFUNCCD { get; set; }
        public Nullable<short> TEMINTFUNCGC { get; set; }
        public Nullable<short> TEMINTFUNCGD { get; set; }
        public Nullable<short> CONTPARCIAL { get; set; }
        public Nullable<short> INCSUBSTITUICAO { get; set; }
        public Nullable<short> ESTIRRFFERIAS { get; set; }
        public Nullable<short> ESTFGTS13 { get; set; }
        public Nullable<short> ESTIRRF13 { get; set; }
        public string CODEVENTOINSUF { get; set; }
        public string CCUSTO { get; set; }
        public Nullable<short> INCPENSAO { get; set; }
        public Nullable<short> INCPENSAOFERIAS { get; set; }
        public Nullable<short> INCPENSAO13SAL { get; set; }
        public Nullable<short> INCPENSAOPARTICIP { get; set; }
        public Nullable<int> IDANOTACAO { get; set; }
        public string FORMCOMPLHIST { get; set; }
        public Nullable<short> PERCALCRATEIO { get; set; }
        public Nullable<short> ESTINSS { get; set; }
        public Nullable<short> ESTIRRF { get; set; }
        public Nullable<short> ESTFGTS { get; set; }
        public Nullable<short> INCFGTS13 { get; set; }
        public Nullable<short> PROPORCDEMISSAO { get; set; }
        public Nullable<short> SEGUERATEIOSALCMP { get; set; }
        public string CONTAREVERSAO { get; set; }
        public string FORMULAEVTRELAC { get; set; }
        public string NATREM { get; set; }
        public string QUADROREM { get; set; }
        public short EVENTOEXIBIDOENTRADADADOSWEB { get; set; }
        public int ORDEMCALCULO { get; set; }
        public Nullable<short> DEDUTIVELIRRF13 { get; set; }
        public Nullable<short> DEDUTIVELIRRFFERIAS { get; set; }
        public string CODRUBRICA { get; set; }
        public int ID { get; set; }
        public Nullable<short> SEGUERATEIOMOVENSINO { get; set; }
        public string RECCREATEDBY { get; set; }
        public Nullable<System.DateTime> RECCREATEDON { get; set; }
        public string RECMODIFIEDBY { get; set; }
        public Nullable<System.DateTime> RECMODIFIEDON { get; set; }
        public string NATRUBRICA { get; set; }
        public Nullable<short> INCINSSSUSPENSA { get; set; }
        public Nullable<short> INCIRRFSUSPENSA { get; set; }
        public Nullable<short> INCFGTSSUSPENSA { get; set; }
        public Nullable<short> INATIVO { get; set; }
        public string NRPROCESSOINSS { get; set; }
        public string TPPROCESSOINSS { get; set; }
        public Nullable<short> EXTDECISAOINSS { get; set; }
        public string NRPROCESSOIRRF { get; set; }
        public string TPPROCESSOIRRF { get; set; }
        public string NRPROCESSOFGTS { get; set; }
        public string TPPROCESSOFGTS { get; set; }
        public Nullable<short> INCSINDSUSPENSA { get; set; }
        public string NRPROCESSOSIND { get; set; }
        public string TPPROCESSOSIND { get; set; }
        public Nullable<short> INCSALMATERNSUSPENSA { get; set; }
        public string NRPROCESSOSALMATERN { get; set; }
        public string TPPROCESSOSALMATERN { get; set; }
    
        public virtual GCOLIGADA GCOLIGADA { get; set; }
        public virtual ICollection<PEVENTO> PEVENTO1 { get; set; }
        public virtual PEVENTO PEVENTO2 { get; set; }
        public virtual ICollection<PEVENTO> PEVENTO11 { get; set; }
        public virtual PEVENTO PEVENTO3 { get; set; }
        public virtual ICollection<PFFINANC> PFFINANC { get; set; }
        public virtual ICollection<PFUNC> PFUNC { get; set; }
    }
}
