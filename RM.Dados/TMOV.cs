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
    
    public partial class TMOV
    {
        public TMOV()
        {
            this.TMOV1 = new HashSet<TMOV>();
            this.TMOV11 = new HashSet<TMOV>();
            this.TMOV12 = new HashSet<TMOV>();
            this.FLAN = new HashSet<FLAN>();
            this.TITMMOV = new HashSet<TITMMOV>();
        }
    
        public short CODCOLIGADA { get; set; }
        public int IDMOV { get; set; }
        public Nullable<short> CODFILIAL { get; set; }
        public string CODLOC { get; set; }
        public string CODLOCENTREGA { get; set; }
        public string CODLOCDESTINO { get; set; }
        public string CODCFO { get; set; }
        public string CODCFONATUREZA { get; set; }
        public string NUMEROMOV { get; set; }
        public string SERIE { get; set; }
        public string CODTMV { get; set; }
        public string TIPO { get; set; }
        public string STATUS { get; set; }
        public Nullable<short> MOVIMPRESSO { get; set; }
        public Nullable<short> DOCIMPRESSO { get; set; }
        public Nullable<short> FATIMPRESSA { get; set; }
        public Nullable<System.DateTime> DATAEMISSAO { get; set; }
        public Nullable<System.DateTime> DATASAIDA { get; set; }
        public Nullable<System.DateTime> DATAEXTRA1 { get; set; }
        public Nullable<System.DateTime> DATAEXTRA2 { get; set; }
        public string CODRPR { get; set; }
        public Nullable<decimal> COMISSAOREPRES { get; set; }
        public string NORDEM { get; set; }
        public string CODCPG { get; set; }
        public Nullable<short> NUMEROTRIBUTOS { get; set; }
        public Nullable<decimal> VALORBRUTO { get; set; }
        public Nullable<decimal> VALORLIQUIDO { get; set; }
        public Nullable<decimal> VALOROUTROS { get; set; }
        public string OBSERVACAO { get; set; }
        public Nullable<decimal> PERCENTUALFRETE { get; set; }
        public Nullable<decimal> VALORFRETE { get; set; }
        public Nullable<decimal> PERCENTUALSEGURO { get; set; }
        public Nullable<decimal> VALORSEGURO { get; set; }
        public Nullable<decimal> PERCENTUALDESC { get; set; }
        public Nullable<decimal> VALORDESC { get; set; }
        public Nullable<decimal> PERCENTUALDESP { get; set; }
        public Nullable<decimal> VALORDESP { get; set; }
        public Nullable<decimal> PERCENTUALEXTRA1 { get; set; }
        public Nullable<decimal> VALOREXTRA1 { get; set; }
        public Nullable<decimal> PERCENTUALEXTRA2 { get; set; }
        public Nullable<decimal> VALOREXTRA2 { get; set; }
        public Nullable<decimal> PERCCOMISSAO { get; set; }
        public string CODMEN { get; set; }
        public string CODMEN2 { get; set; }
        public string VIADETRANSPORTE { get; set; }
        public string PLACA { get; set; }
        public string CODETDPLACA { get; set; }
        public Nullable<decimal> PESOLIQUIDO { get; set; }
        public Nullable<decimal> PESOBRUTO { get; set; }
        public string MARCA { get; set; }
        public Nullable<int> NUMERO { get; set; }
        public Nullable<int> QUANTIDADE { get; set; }
        public string ESPECIE { get; set; }
        public string CODTB1FAT { get; set; }
        public string CODTB2FAT { get; set; }
        public string CODTB3FAT { get; set; }
        public string CODTB4FAT { get; set; }
        public string CODTB5FAT { get; set; }
        public string CODTB1FLX { get; set; }
        public string CODTB2FLX { get; set; }
        public string CODTB3FLX { get; set; }
        public string CODTB4FLX { get; set; }
        public string CODTB5FLX { get; set; }
        public Nullable<int> IDMOVRELAC { get; set; }
        public Nullable<int> IDMOVLCTFLUXUS { get; set; }
        public Nullable<int> IDMOVPEDDESDOBRADO { get; set; }
        public string CODMOEVALORLIQUIDO { get; set; }
        public Nullable<System.DateTime> DATABASEMOV { get; set; }
        public Nullable<System.DateTime> DATAMOVIMENTO { get; set; }
        public Nullable<short> NUMEROLCTGERADO { get; set; }
        public Nullable<short> GEROUFATURA { get; set; }
        public Nullable<short> NUMEROLCTABERTO { get; set; }
        public Nullable<short> FLAGEXPORTACAO { get; set; }
        public string EMITEBOLETA { get; set; }
        public string CODMENDESCONTO { get; set; }
        public string CODMENDESPESA { get; set; }
        public string CODMENFRETE { get; set; }
        public Nullable<short> FRETECIFOUFOB { get; set; }
        public Nullable<short> USADESPFINANC { get; set; }
        public Nullable<short> FLAGEXPORFISC { get; set; }
        public Nullable<short> FLAGEXPORFAZENDA { get; set; }
        public Nullable<decimal> VALORADIANTAMENTO { get; set; }
        public string CODTRA { get; set; }
        public string CODTRA2 { get; set; }
        public Nullable<short> STATUSLIBERACAO { get; set; }
        public string CODCFOAUX { get; set; }
        public Nullable<int> IDLOT { get; set; }
        public Nullable<short> ITENSAGRUPADOS { get; set; }
        public string FLAGIMPRESSAOFAT { get; set; }
        public Nullable<System.DateTime> DATACANCELAMENTOMOV { get; set; }
        public Nullable<decimal> VALORRECEBIDO { get; set; }
        public string SEGUNDONUMERO { get; set; }
        public string CODCCUSTO { get; set; }
        public string CODCXA { get; set; }
        public string CODVEN1 { get; set; }
        public string CODVEN2 { get; set; }
        public string CODVEN3 { get; set; }
        public string CODVEN4 { get; set; }
        public Nullable<decimal> PERCCOMISSAOVEN2 { get; set; }
        public Nullable<short> CODCOLCFO { get; set; }
        public Nullable<short> CODCOLCFONATUREZA { get; set; }
        public string CODUSUARIO { get; set; }
        public Nullable<short> CODFILIALENTREGA { get; set; }
        public Nullable<short> CODFILIALDESTINO { get; set; }
        public Nullable<short> FLAGAGRUPADOFLUXUS { get; set; }
        public Nullable<short> CODCOLCXA { get; set; }
        public Nullable<short> GERADOPORLOTE { get; set; }
        public string CODDEPARTAMENTO { get; set; }
        public string CODCCUSTODESTINO { get; set; }
        public Nullable<short> CODEVENTO { get; set; }
        public Nullable<short> STATUSEXPORTCONT { get; set; }
        public Nullable<int> CODLOTE { get; set; }
        public Nullable<short> STATUSCHEQUE { get; set; }
        public Nullable<System.DateTime> DATAENTREGA { get; set; }
        public Nullable<System.DateTime> DATAPROGRAMACAO { get; set; }
        public Nullable<int> IDNAT { get; set; }
        public Nullable<int> IDNAT2 { get; set; }
        public string CAMPOLIVRE1 { get; set; }
        public string CAMPOLIVRE2 { get; set; }
        public string CAMPOLIVRE3 { get; set; }
        public Nullable<short> GEROUCONTATRABALHO { get; set; }
        public Nullable<short> GERADOPORCONTATRABALHO { get; set; }
        public Nullable<System.DateTime> HORULTIMAALTERACAO { get; set; }
        public string CODLAF { get; set; }
        public Nullable<System.DateTime> DATAFECHAMENTO { get; set; }
        public Nullable<short> NSEQDATAFECHAMENTO { get; set; }
        public string NUMERORECIBO { get; set; }
        public Nullable<int> IDLOTEPROCESSO { get; set; }
        public string IDOBJOF { get; set; }
        public Nullable<int> CODAGENDAMENTO { get; set; }
        public string CHAPARESP { get; set; }
        public Nullable<int> IDLOTEPROCESSOREFAT { get; set; }
        public Nullable<decimal> INDUSOOBJ { get; set; }
        public string SUBSERIE { get; set; }
        public string STSCOMPRAS { get; set; }
        public string CODLOCEXP { get; set; }
        public Nullable<int> IDCLASSMOV { get; set; }
        public string CODENTREGA { get; set; }
        public string CODFAIXAENTREGA { get; set; }
        public Nullable<System.DateTime> DTHENTREGA { get; set; }
        public Nullable<short> CONTABILIZADOPORTOTAL { get; set; }
        public string CODLAFE { get; set; }
        public Nullable<int> IDPRJ { get; set; }
        public Nullable<int> NUMEROCUPOM { get; set; }
        public Nullable<int> NUMEROCAIXA { get; set; }
        public Nullable<short> FLAGEFEITOSALDO { get; set; }
        public Nullable<short> INTEGRADOBONUM { get; set; }
        public string CODMOELANCAMENTO { get; set; }
        public string NAONUMERADO { get; set; }
        public Nullable<short> FLAGPROCESSADO { get; set; }
        public Nullable<decimal> ABATIMENTOICMS { get; set; }
        public Nullable<short> TIPOCONSUMO { get; set; }
        public Nullable<System.DateTime> HORARIOEMISSAO { get; set; }
        public Nullable<System.DateTime> DATARETORNO { get; set; }
        public string USUARIOCRIACAO { get; set; }
        public Nullable<System.DateTime> DATACRIACAO { get; set; }
        public Nullable<int> IDCONTATOENTREGA { get; set; }
        public Nullable<int> IDCONTATOCOBRANCA { get; set; }
        public string STATUSSEPARACAO { get; set; }
        public Nullable<short> STSEMAIL { get; set; }
        public Nullable<decimal> VALORFRETECTRC { get; set; }
        public string PONTOVENDA { get; set; }
        public Nullable<int> PRAZOENTREGA { get; set; }
        public Nullable<decimal> VALORBRUTOINTERNO { get; set; }
        public Nullable<short> IDAIDF { get; set; }
        public Nullable<int> IDSALDOESTOQUE { get; set; }
        public Nullable<short> VINCULADOESTOQUEFL { get; set; }
        public Nullable<int> IDREDUCAOZ { get; set; }
        public Nullable<System.DateTime> HORASAIDA { get; set; }
        public string CODMUNSERVICO { get; set; }
        public string CODETDMUNSERV { get; set; }
        public Nullable<short> APROPRIADO { get; set; }
        public string CODIGOSERVICO { get; set; }
        public Nullable<System.DateTime> DATADEDUCAO { get; set; }
        public string CODDIARIO { get; set; }
        public string SEQDIARIO { get; set; }
        public string SEQDIARIOESTORNO { get; set; }
        public Nullable<decimal> INSSEMOUTRAEMPRESA { get; set; }
        public Nullable<int> IDMOVCTRC { get; set; }
        public Nullable<System.DateTime> DATAPROGRAMACAOANT { get; set; }
        public string CODTDO { get; set; }
        public Nullable<decimal> VALORDESCCONDICIONAL { get; set; }
        public Nullable<decimal> VALORDESPCONDICIONAL { get; set; }
        public string CODIGOIRRF { get; set; }
        public Nullable<decimal> DEDUCAOIRRF { get; set; }
        public Nullable<decimal> PERCENTBASEINSS { get; set; }
        public Nullable<decimal> PERCBASEINSSEMPREGADO { get; set; }
        public Nullable<short> CONTORCAMENTOANTIGO { get; set; }
        public string CODDEPTODESTINO { get; set; }
        public Nullable<System.DateTime> DATACONTABILIZACAO { get; set; }
        public string CODVIATRANSPORTE { get; set; }
        public Nullable<decimal> VALORSERVICO { get; set; }
        public Nullable<int> SEQUENCIALESTOQUE { get; set; }
        public Nullable<int> DISTANCIA { get; set; }
        public string UNCALCULO { get; set; }
        public string FORMACALCULO { get; set; }
        public Nullable<short> INTEGRADOAUTOMACAO { get; set; }
        public string INTEGRAAPLICACAO { get; set; }
        public string CLASSECONSUMO { get; set; }
        public string TIPOASSINANTE { get; set; }
        public string FASE { get; set; }
        public string TIPOUTILIZACAO { get; set; }
        public string GRUPOTENSAO { get; set; }
        public Nullable<System.DateTime> DATALANCAMENTO { get; set; }
        public Nullable<short> EXTENPORANEO { get; set; }
        public string RECIBONFESTATUS { get; set; }
        public Nullable<short> RECIBONFETIPO { get; set; }
        public string RECIBONFENUMERO { get; set; }
        public Nullable<short> RECIBONFESITUACAO { get; set; }
        public Nullable<int> IDMOVCFO { get; set; }
        public Nullable<short> OCAUTONOMO { get; set; }
        public Nullable<decimal> VALORMERCADORIAS { get; set; }
        public string NATUREZAVOLUMES { get; set; }
        public string VOLUMES { get; set; }
        public Nullable<short> CRO { get; set; }
        public Nullable<short> USARATEIOVALORFIN { get; set; }
        public string RECIBONFESERIE { get; set; }
        public Nullable<short> CODCOLCFOORIGEM { get; set; }
        public string CODCFOORIGEM { get; set; }
        public Nullable<decimal> VALORCTRCARATEAR { get; set; }
        public Nullable<short> CODCOLCFOAUX { get; set; }
        public Nullable<decimal> VRBASEINSSOUTRAEMPRESA { get; set; }
        public Nullable<int> IDCEICFO { get; set; }
        public string CHAVEACESSONFE { get; set; }
        public Nullable<decimal> VLRSECCAT { get; set; }
        public Nullable<decimal> VLRDESPACHO { get; set; }
        public Nullable<decimal> VLRPEDAGIO { get; set; }
        public Nullable<decimal> VLRFRETEOUTROS { get; set; }
        public Nullable<decimal> ABATIMENTONAOTRIB { get; set; }
        public Nullable<decimal> RATEIOCCUSTODEPTO { get; set; }
        public Nullable<decimal> VALORRATEIOLAN { get; set; }
        public Nullable<short> CODCOLCFOTRANSFAT { get; set; }
        public string CODCFOTRANSFAT { get; set; }
        public string CODUSUARIOAPROVADESC { get; set; }
        public string IDINTEGRACAO { get; set; }
        public string STATUSANTERIOR { get; set; }
        public Nullable<decimal> VALORBRUTOORIG { get; set; }
        public Nullable<decimal> VALORLIQUIDOORIG { get; set; }
        public Nullable<decimal> VALOROUTROSORIG { get; set; }
        public Nullable<decimal> VALORRATEIOLANORIG { get; set; }
        public Nullable<System.DateTime> DATAPROCESSAMENTO { get; set; }
        public Nullable<int> IDNATFRETE { get; set; }
        public Nullable<int> IDOPERACAO { get; set; }
        public string RECCREATEDBY { get; set; }
        public Nullable<System.DateTime> RECCREATEDON { get; set; }
        public string RECMODIFIEDBY { get; set; }
        public Nullable<System.DateTime> RECMODIFIEDON { get; set; }
    
        public virtual FCFO FCFO { get; set; }
        public virtual FCFO FCFO1 { get; set; }
        public virtual FCFO FCFO2 { get; set; }
        public virtual FCFO FCFO3 { get; set; }
        public virtual FTB1 FTB1 { get; set; }
        public virtual GFILIAL GFILIAL { get; set; }
        public virtual GFILIAL GFILIAL1 { get; set; }
        public virtual ICollection<TMOV> TMOV1 { get; set; }
        public virtual TMOV TMOV2 { get; set; }
        public virtual ICollection<TMOV> TMOV11 { get; set; }
        public virtual TMOV TMOV3 { get; set; }
        public virtual ICollection<TMOV> TMOV12 { get; set; }
        public virtual TMOV TMOV4 { get; set; }
        public virtual TMOVCOMPL TMOVCOMPL { get; set; }
        public virtual TVEN TVEN { get; set; }
        public virtual TVEN TVEN1 { get; set; }
        public virtual TVEN TVEN2 { get; set; }
        public virtual TVEN TVEN3 { get; set; }
        public virtual GETD GETD { get; set; }
        public virtual GMUNICIPIO GMUNICIPIO { get; set; }
        public virtual TCPG TCPG { get; set; }
        public virtual ICollection<FLAN> FLAN { get; set; }
        public virtual FCXA FCXA { get; set; }
        public virtual ICollection<TITMMOV> TITMMOV { get; set; }
        public virtual GCCUSTO GCCUSTO { get; set; }
        public virtual GCCUSTO GCCUSTO1 { get; set; }
        public virtual PFUNC PFUNC { get; set; }
    }
}
