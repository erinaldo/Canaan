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
    
    public partial class FCFO
    {
        public FCFO()
        {
            this.TMOV = new HashSet<TMOV>();
            this.TMOV1 = new HashSet<TMOV>();
            this.TMOV2 = new HashSet<TMOV>();
            this.TMOV3 = new HashSet<TMOV>();
            this.FLAN = new HashSet<FLAN>();
            this.FLAN1 = new HashSet<FLAN>();
            this.FACORDO = new HashSet<FACORDO>();
            this.PFUNC = new HashSet<PFUNC>();
        }
    
        public short CODCOLIGADA { get; set; }
        public string CODCFO { get; set; }
        public string NOMEFANTASIA { get; set; }
        public string NOME { get; set; }
        public string CGCCFO { get; set; }
        public string INSCRESTADUAL { get; set; }
        public short PAGREC { get; set; }
        public string RUA { get; set; }
        public string NUMERO { get; set; }
        public string COMPLEMENTO { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string CODETD { get; set; }
        public string CEP { get; set; }
        public string TELEFONE { get; set; }
        public string RUAPGTO { get; set; }
        public string NUMEROPGTO { get; set; }
        public string COMPLEMENTOPGTO { get; set; }
        public string BAIRROPGTO { get; set; }
        public string CIDADEPGTO { get; set; }
        public string CODETDPGTO { get; set; }
        public string CEPPGTO { get; set; }
        public string TELEFONEPGTO { get; set; }
        public string RUAENTREGA { get; set; }
        public string NUMEROENTREGA { get; set; }
        public string COMPLEMENTREGA { get; set; }
        public string BAIRROENTREGA { get; set; }
        public string CIDADEENTREGA { get; set; }
        public string CODETDENTREGA { get; set; }
        public string CEPENTREGA { get; set; }
        public string TELEFONEENTREGA { get; set; }
        public string FAX { get; set; }
        public string TELEX { get; set; }
        public string EMAIL { get; set; }
        public string CONTATO { get; set; }
        public string CODTCF { get; set; }
        public short ATIVO { get; set; }
        public Nullable<decimal> LIMITECREDITO { get; set; }
        public Nullable<decimal> VALORULTIMOLAN { get; set; }
        public Nullable<short> TIPOINSCRCNAB { get; set; }
        public string SIMBMOEDAINDEX { get; set; }
        public Nullable<System.DateTime> DATAULTALTERACAO { get; set; }
        public Nullable<System.DateTime> DATACRIACAO { get; set; }
        public Nullable<System.DateTime> DATAULTMOVIMENTO { get; set; }
        public Nullable<short> CONTEVENTOCONTAB { get; set; }
        public string CAMPOLIVRE { get; set; }
        public string CAMPOALFAOP1 { get; set; }
        public string CAMPOALFAOP2 { get; set; }
        public string CAMPOALFAOP3 { get; set; }
        public Nullable<decimal> VALOROP1 { get; set; }
        public Nullable<decimal> VALOROP2 { get; set; }
        public Nullable<decimal> VALOROP3 { get; set; }
        public Nullable<System.DateTime> DATAOP1 { get; set; }
        public Nullable<System.DateTime> DATAOP2 { get; set; }
        public Nullable<System.DateTime> DATAOP3 { get; set; }
        public string CODTRA { get; set; }
        public string CHAPA { get; set; }
        public string STATUSCOTACAO { get; set; }
        public Nullable<System.DateTime> DTINICATIVIDADES { get; set; }
        public Nullable<decimal> PATRIMONIO { get; set; }
        public Nullable<int> NUMFUNCIONARIOS { get; set; }
        public Nullable<short> CODCOLCHAVESESTRANG { get; set; }
        public Nullable<short> CODCOLTCF { get; set; }
        public Nullable<short> FAXDEDICADO { get; set; }
        public string CODMUNICIPIO { get; set; }
        public Nullable<short> CODCOLCONTAGER { get; set; }
        public string CODCONTAGER { get; set; }
        public Nullable<short> FORMAPAGAMENTO { get; set; }
        public Nullable<short> IDENTPORCNPJ { get; set; }
        public string INSCRMUNICIPAL { get; set; }
        public string PESSOAFISOUJUR { get; set; }
        public string CONTATOPGTO { get; set; }
        public string CONTATOENTREGA { get; set; }
        public string PAIS { get; set; }
        public string PAISPAGTO { get; set; }
        public string PAISENTREGA { get; set; }
        public string ULTIMODOCUMENTO { get; set; }
        public Nullable<short> CONTRIBUINTE { get; set; }
        public Nullable<short> CFOIMOB { get; set; }
        public string TIPODOC { get; set; }
        public Nullable<short> CODFINALIDADE { get; set; }
        public string AGRUPCOB { get; set; }
        public string CODCARGO { get; set; }
        public string CODVINCULO { get; set; }
        public string ENDCOBC { get; set; }
        public string CIDENTIDADE { get; set; }
        public string CI_ORGAO { get; set; }
        public string CI_UF { get; set; }
        public Nullable<int> CODPROF { get; set; }
        public string CODPAGTOGPS { get; set; }
        public string FAXENTREGA { get; set; }
        public string EMAILENTREGA { get; set; }
        public string FAXPGTO { get; set; }
        public string EMAILPGTO { get; set; }
        public Nullable<int> SATISFACAO { get; set; }
        public Nullable<decimal> VALFRETE { get; set; }
        public Nullable<short> TPTOMADOR { get; set; }
        public Nullable<short> CONTRIBUINTEISS { get; set; }
        public Nullable<int> NUMDEPENDENTES { get; set; }
        public string EMPRESA { get; set; }
        public string ESTADOCIVIL { get; set; }
        public Nullable<short> CODCOLCXA { get; set; }
        public string CODCXA { get; set; }
        public string PRODUTORRURAL { get; set; }
        public string USUARIOALTERACAO { get; set; }
        public string SUFRAMA { get; set; }
        public string CODMUNICIPIOPGTO { get; set; }
        public string CODMUNICIPIOENTREGA { get; set; }
        public Nullable<short> ORGAOPUBLICO { get; set; }
        public string TELEFONECOMERCIAL { get; set; }
        public string CAIXAPOSTAL { get; set; }
        public string CAIXAPOSTALENTREGA { get; set; }
        public string CAIXAPOSTALPAGAMENTO { get; set; }
        public Nullable<short> CATEGORIAAUTONOMO { get; set; }
        public string CBOAUTONOMO { get; set; }
        public string CIAUTONOMO { get; set; }
        public int IDCFO { get; set; }
        public string CODIGOINSS { get; set; }
        public Nullable<decimal> VROUTRASDEDUCOESIRRF { get; set; }
        public string CODRECEITA { get; set; }
        public string CEI { get; set; }
        public Nullable<short> OPTANTEPELOSIMPLES { get; set; }
        public Nullable<short> TIPORUA { get; set; }
        public Nullable<short> TIPOBAIRRO { get; set; }
        public string REGIMEISS { get; set; }
        public Nullable<short> RETENCAOISS { get; set; }
        public Nullable<System.DateTime> DTNASCIMENTO { get; set; }
        public string USUARIOCRIACAO { get; set; }
        public Nullable<short> TIPOOPCOMBUSTIVEL { get; set; }
        public string INSCRESTADUALST { get; set; }
        public string LOCALIDADE { get; set; }
        public string LOCALIDADEPGTO { get; set; }
        public string LOCALIDADEENTREGA { get; set; }
        public Nullable<short> TIPORUAPGTO { get; set; }
        public Nullable<short> TIPORUAENTREGA { get; set; }
        public Nullable<short> TIPOBAIRROPGTO { get; set; }
        public Nullable<short> TIPOBAIRROENTREGA { get; set; }
        public Nullable<short> PORTE { get; set; }
        public int RAMOATIV { get; set; }
        public string NIT { get; set; }
        public string CEPCAIXAPOSTAL { get; set; }
        public Nullable<int> NUMDIASATRASO { get; set; }
        public Nullable<short> IDPAIS { get; set; }
        public Nullable<short> IDPAISPGTO { get; set; }
        public Nullable<short> IDPAISENTREGA { get; set; }
        public short TIPOCONTRIBUINTEINSS { get; set; }
        public short NACIONALIDADE { get; set; }
        public Nullable<short> CODCOLCFOFISCAL { get; set; }
        public Nullable<int> IDCFOFISCAL { get; set; }
        public string EMAILFISCAL { get; set; }
        public short CALCULAAVP { get; set; }
        public string CODUSUARIOACESSO { get; set; }
        public string RECCREATEDBY { get; set; }
        public Nullable<System.DateTime> RECCREATEDON { get; set; }
        public string RECMODIFIEDBY { get; set; }
        public Nullable<System.DateTime> RECMODIFIEDON { get; set; }
        public string IDINTEGRACAO { get; set; }
        public Nullable<short> USARCUMULATRETENCAOPAGAR { get; set; }
        public string NIF { get; set; }
        public Nullable<short> SITUACAONIF { get; set; }
        public string TIPORENDIMENTO { get; set; }
        public string FORMATRIBUTACAO { get; set; }
        public string DOCUMENTOESTRANGEIRO { get; set; }
        public string INDNATRET { get; set; }
    
        public virtual GCOLIGADA GCOLIGADA { get; set; }
        public virtual FCFOCOMPL FCFOCOMPL { get; set; }
        public virtual ICollection<TMOV> TMOV { get; set; }
        public virtual ICollection<TMOV> TMOV1 { get; set; }
        public virtual ICollection<TMOV> TMOV2 { get; set; }
        public virtual ICollection<TMOV> TMOV3 { get; set; }
        public virtual TVEN TVEN { get; set; }
        public virtual GETD GETD { get; set; }
        public virtual GETD GETD1 { get; set; }
        public virtual GETD GETD2 { get; set; }
        public virtual GPAIS GPAIS { get; set; }
        public virtual GPAIS GPAIS1 { get; set; }
        public virtual GPAIS GPAIS2 { get; set; }
        public virtual DTIPOBAIRRO DTIPOBAIRRO { get; set; }
        public virtual DTIPOBAIRRO DTIPOBAIRRO1 { get; set; }
        public virtual DTIPOBAIRRO DTIPOBAIRRO2 { get; set; }
        public virtual DTIPORUA DTIPORUA { get; set; }
        public virtual DTIPORUA DTIPORUA1 { get; set; }
        public virtual DTIPORUA DTIPORUA2 { get; set; }
        public virtual ICollection<FLAN> FLAN { get; set; }
        public virtual ICollection<FLAN> FLAN1 { get; set; }
        public virtual ICollection<FACORDO> FACORDO { get; set; }
        public virtual ICollection<PFUNC> PFUNC { get; set; }
    }
}
