using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.CService.Lib.Integracao
{
    public class Envelope
    {
        #region PROPRIEDADES

        public int IdEnvelope { get; set; }
        public int IdFilial { get; set; }
        public int IdStatus { get; set; }
        public int IdVenda { get; set; }
        public string IdPedido { get; set; }
        public string IdCliente { get; set; }
        public string IdVendedor { get; set; }
        public int IdServico { get; set; }
        public int IdItem { get; set; }
        public DateTime DataImportacao { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime DataPrevista { get; set; }
        public DateTime DataStatus { get; set; }
        public DateTime DataStatusPrevista { get; set; }
        public string NomeCliente { get; set; }
        public string NomeAbertura { get; set; }
        public string NomeVendedor { get; set; }
        public string Cidade { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Servico { get; set; }
        public string StatusAtual { get; set; }
        public int NumFoto { get; set; }
        public string Tipo { get; set; }
        public string Linha { get; set; }
        public string Laminacao { get; set; }
        public string RecorteLateral { get; set; }
        public string Maleta { get; set; }
        public string Tecido { get; set; }
        public string Embalagem { get; set; }
        public string Observacao { get; set; }
        public bool IsBloco { get; set; }
        public bool IsCapa { get; set; }
        public bool IsEmbalagem { get; set; }
        public bool IsInox { get; set; }
        public bool IsAcrilico { get; set; }
        public bool IsMadeira { get; set; }
        public string FormaPagamento { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorDescontoPerc 
        { 
            get 
            {
                if (this.ValorBruto > 0)
                    return (100 * this.ValorDesconto) / this.ValorBruto;
                else
                    return 0;
            } 
        }
        public decimal ValorAcrescimo { get; set; }
        public decimal ValorAcrescimoPerc 
        {  
            get 
            {
                if (this.ValorBruto > 0)
                    return (100 * this.ValorAcrescimo) / this.ValorBruto;
                else
                    return 0;
            } 
        }
        public decimal ValorLiquido { get; set; }
        public bool IsAutorizado { get; set; }
        public string UsuarioAutorizacao { get; set; }
        public DateTime DataAutorizacao { get; set; }

        #endregion

        #region METODOS

        public static List<Envelope> GetByVendaRM(int idColigada, int idVenda) 
        {
            var lista = new List<Envelope>();

            using (var conn = new RM.Dados.CorporeEntities()) 
            {
                //carrega os itens
                var itens = conn.TITMMOV.Where(a => a.IDMOV == idVenda && a.CODCOLIGADA == idColigada);

                foreach (var item in itens)
                {
                    if (item.TPRODUTO.NOMEFANTASIA != "PRESTAÇÃO DE SERVIÇO")
                    {
                        if (!VerificaComposto(item.TPRODUTO))
                        {
                            //cria item simples
                            lista.Add(GetByItemRM(item.CODCOLIGADA, item.IDMOV, item.NUMEROSEQUENCIAL));
                        }
                        else
                        {
                            //cria item composto
                            if (item.TPRODUTO.TPRDCOMPL.FirstOrDefault().HASBLOCO == "1")
                                lista.Add(GetByItemRM(item.CODCOLIGADA, item.IDMOV, item.NUMEROSEQUENCIAL, "Bloco"));

                            if (item.TPRODUTO.TPRDCOMPL.FirstOrDefault().HACAPA == "1")
                                lista.Add(GetByItemRM(item.CODCOLIGADA, item.IDMOV, item.NUMEROSEQUENCIAL, "Capa"));

                            if (item.TPRODUTO.TPRDCOMPL.FirstOrDefault().HASEMBALAGEM == "1")
                                lista.Add(GetByItemRM(item.CODCOLIGADA, item.IDMOV, item.NUMEROSEQUENCIAL, "Embalagem"));

                            if (item.TPRODUTO.TPRDCOMPL.FirstOrDefault().HASINOX == "1")
                                lista.Add(GetByItemRM(item.CODCOLIGADA, item.IDMOV, item.NUMEROSEQUENCIAL, "Inox"));

                            if (item.TPRODUTO.TPRDCOMPL.FirstOrDefault().HASACRILICO == "1")
                                lista.Add(GetByItemRM(item.CODCOLIGADA, item.IDMOV, item.NUMEROSEQUENCIAL, "Acrílico"));

                            if (item.TPRODUTO.TPRDCOMPL.FirstOrDefault().HASMADEIRA == "1")
                                lista.Add(GetByItemRM(item.CODCOLIGADA, item.IDMOV, item.NUMEROSEQUENCIAL, "Madeira"));
                        }
                    }
                }
            }

            return lista;
        }

        public static Envelope GetByItemRM(int idColigada, int idMov, int idItem, string sufix = "") 
        {
            using (var conn = new RM.Dados.CorporeEntities()) 
            {
                var item = conn.TITMMOV.FirstOrDefault(a => a.IDMOV == idMov && a.NUMEROSEQUENCIAL == idItem && a.CODCOLIGADA == idColigada);

                return new Envelope
                {
                    IdVenda = item.IDMOV,
                    IdPedido = string.IsNullOrEmpty(item.TITMMOVCOMPL.CODSIGI) ? "0" : item.TITMMOVCOMPL.CODSIGI,
                    IdCliente = item.TMOV.CODCFO,
                    IdVendedor = item.TMOV.CODVEN1,
                    IdServico = item.IDPRD.GetValueOrDefault(),
                    IdItem = item.NUMEROSEQUENCIAL,
                    DataVenda = item.TITMMOVCOMPL.DATASIGI == null ? item.TMOV.DATAEMISSAO.GetValueOrDefault() : item.TITMMOVCOMPL.DATASIGI.GetValueOrDefault(),
                    NomeCliente = item.TMOV.FCFO.NOMEFANTASIA,
                    NomeAbertura = item.TITMMOVCOMPL.NOMECLIENTE,
                    NomeVendedor = item.TMOV.TVEN != null ? item.TMOV.TVEN.NOME : "Não Informado",
                    Cidade = item.TMOV.FCFO.CIDADE,
                    Telefone = item.TMOV.FCFO.TELEFONE,
                    Email = item.TMOV.FCFO.EMAIL,
                    Servico = !string.IsNullOrEmpty(sufix) ? string.Format("{0} - {1}", item.TPRODUTO.NOMEFANTASIA, sufix) : item.TPRODUTO.NOMEFANTASIA,
                    NumFoto = item.TITMMOVCOMPL.NUMLAMINA.GetValueOrDefault(),
                    Tipo = conn.GDINAM.FirstOrDefault(a => a.CODIGO == "TIPOSERV").GCONSIST.FirstOrDefault(a => a.CODCLIENTE == item.TITMMOVCOMPL.TIPOSERV).DESCRICAO,
                    Linha = conn.GDINAM.FirstOrDefault(a => a.CODIGO == "LINHAPROD").GCONSIST.FirstOrDefault(a => a.CODCLIENTE == item.TITMMOVCOMPL.LINHAPROD).DESCRICAO,
                    Laminacao = conn.GDINAM.FirstOrDefault(a => a.CODIGO == "TIPOLAMINA").GCONSIST.FirstOrDefault(a => a.CODCLIENTE == item.TITMMOVCOMPL.TIPOLAMINA).DESCRICAO,
                    RecorteLateral = conn.GDINAM.FirstOrDefault(a => a.CODIGO == "TIPORECORT").GCONSIST.FirstOrDefault(a => a.CODCLIENTE == item.TITMMOVCOMPL.TIPORECORT).DESCRICAO,
                    Maleta = conn.GDINAM.FirstOrDefault(a => a.CODIGO == "TIPOMALETA").GCONSIST.FirstOrDefault(a => a.CODCLIENTE == item.TITMMOVCOMPL.TIPOMALETA).DESCRICAO,
                    Tecido = conn.GDINAM.FirstOrDefault(a => a.CODIGO == "TIPOTECIDO").GCONSIST.FirstOrDefault(a => a.CODCLIENTE == item.TITMMOVCOMPL.TIPOTECIDO).DESCRICAO,
                    Embalagem = conn.GDINAM.FirstOrDefault(a => a.CODIGO == "TIPOEMBALA").GCONSIST.FirstOrDefault(a => a.CODCLIENTE == item.TITMMOVCOMPL.TIPOEMBALA).DESCRICAO,
                    Observacao = string.Format("{0}\n\n************************************************\n\n{1}", item.TITMMOVCOMPL.OUTRAOBS, item.TMOV.FCFO.FCFOCOMPL.OBSERVACOES),
                    IsBloco = item.TPRODUTO.TPRDCOMPL.FirstOrDefault(a => a.IDPRD == item.IDPRD).HASBLOCO == "1" ? true : false,
                    IsCapa = item.TPRODUTO.TPRDCOMPL.FirstOrDefault(a => a.IDPRD == item.IDPRD).HACAPA == "1" ? true : false,
                    IsEmbalagem = item.TPRODUTO.TPRDCOMPL.FirstOrDefault(a => a.IDPRD == item.IDPRD).HASEMBALAGEM == "1" ? true : false,
                    IsInox = item.TPRODUTO.TPRDCOMPL.FirstOrDefault(a => a.IDPRD == item.IDPRD).HASINOX == "1" ? true : false,
                    IsAcrilico = item.TPRODUTO.TPRDCOMPL.FirstOrDefault(a => a.IDPRD == item.IDPRD).HASACRILICO == "1" ? true : false,
                    IsMadeira = item.TPRODUTO.TPRDCOMPL.FirstOrDefault(a => a.IDPRD == item.IDPRD).HASMADEIRA == "1" ? true : false,
                    FormaPagamento = item.TMOV.TCPG.NOME,
                    ValorBruto = item.PRECOUNITARIO.GetValueOrDefault(),
                    ValorDesconto = item.VALORDESC.GetValueOrDefault(),
                    ValorAcrescimo = item.VALORDESP.GetValueOrDefault(),
                    ValorLiquido = item.VALORBRUTOITEM.GetValueOrDefault()
                };
            }
        }

        public static Envelope GetById(int idColigada, int idEnvelope) 
        {
            var item = Lib.Envelope.GetById(idEnvelope);

            //pega o item do pedido na rm
            var envelope = GetByItemRM(idColigada, item.cod_pacote.GetValueOrDefault(), item.cod_envelope.GetValueOrDefault());

            if (envelope != null) 
            {
                envelope.IdEnvelope = item.id_envelope;
                envelope.IdStatus = item.id_status.GetValueOrDefault();
                envelope.IdFilial = item.id_studio.GetValueOrDefault();
                envelope.IdPedido = item.cod_pacote.GetValueOrDefault().ToString();
                envelope.IdVenda = item.cod_venda.GetValueOrDefault();
                envelope.DataImportacao = item.data_venda.GetValueOrDefault();
                envelope.DataPrevista = item.data_prevista.GetValueOrDefault();
                envelope.DataStatus = item.data_status.GetValueOrDefault();
                envelope.DataStatusPrevista = item.data_status_prevista.GetValueOrDefault();
                envelope.StatusAtual = Lib.Status.GetById(item.id_status.GetValueOrDefault()).nome;
                envelope.Servico = item.servico;
                envelope.Observacao = item.obs;
            }

            //retorna o envelope
            return envelope;
        }

        private static bool VerificaComposto(RM.Dados.TPRODUTO prod) 
        {
            var result = false;

            if (prod.TPRDCOMPL.FirstOrDefault().HASBLOCO == "1")
                result = true;

            if (prod.TPRDCOMPL.FirstOrDefault().HACAPA == "1")
                result = true;

            if (prod.TPRDCOMPL.FirstOrDefault().HASEMBALAGEM == "1")
                result = true;

            if (prod.TPRDCOMPL.FirstOrDefault().HASINOX == "1")
                result = true;

            if (prod.TPRDCOMPL.FirstOrDefault().HASACRILICO == "1")
                result = true;

            if (prod.TPRDCOMPL.FirstOrDefault().HASMADEIRA == "1")
                result = true;

            return result;
        }

        public static void UpdateSync(int idColigada, int idMov, int idItem) 
        {
            using (var conn = new RM.Dados.CorporeEntities())
            {
                var item = conn.TITMMOV.FirstOrDefault(a => a.IDMOV == idMov && a.CODCOLIGADA == idColigada && a.NUMEROSEQUENCIAL == idItem);
                item.TITMMOVCOMPL.ISSYNC = 1;
                conn.SaveChanges();
            }
        }

        #endregion

    }
}
