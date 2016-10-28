using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.CService.Lib.Integracao
{
    public class Venda
    {
        #region PROPRIEDADES

        public int IdVenda { get; set; }
        public string IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string NomeVendedor { get; set; }
        public DateTime DataEmissao { get; set; }
        public string Status { get; set; }
        public int QtdeItem 
        { 
            get 
            {
                if (Envelopes == null)
                    return 0;
                else
                    return Envelopes.Count;
            } 
        }
        public decimal ValorBruto { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorAcrescimo { get; set; }
        public decimal ValorLiquido { get; set; }
        public bool IsSync { get; set; }
        public DateTime? DataSync { get; set; }
        public List<Envelope> Envelopes { get; set; }

        #endregion

        #region CONSTRUTOR

        public Venda()
        {
            this.Envelopes = new List<Envelope>();
        }

        #endregion

        #region METODOS

        public static List<Venda> GetPendentes(int codColigada, string codMovimento) 
        {
            var lista = new List<Venda>();

            using (var conn = new RM.Dados.CorporeEntities()) 
            {
                //pega vendas a faturar que nao foram syncronizadas
                var vendas = conn.TMOV.Where(a => a.CODCOLIGADA == codColigada && a.CODTMV == codMovimento && a.STATUS == "A" && a.TMOVCOMPL.ISSYNC != 1);

                //faz loop nas vendas
                foreach (var item in vendas)
                {
                    var envelopes = Envelope.GetByVendaRM(codColigada ,item.IDMOV);

                    if (envelopes.Count > 0) 
                    {
                        //adiciona venda na lista
                        lista.Add(new Venda
                        {
                            IdVenda = item.IDMOV,
                            IdCliente = item.CODCFO,
                            NomeCliente = item.FCFO.NOMEFANTASIA,
                            NomeVendedor = item.TVEN != null ? item.TVEN.NOME : "Não Informado",
                            DataEmissao = item.DATAEMISSAO.GetValueOrDefault(),
                            Status = item.STATUS,
                            ValorBruto = item.VALORBRUTO.GetValueOrDefault(),
                            ValorDesconto = item.VALORDESC.GetValueOrDefault(),
                            ValorAcrescimo = item.VALORDESP.GetValueOrDefault(),
                            ValorLiquido = item.VALORLIQUIDO.GetValueOrDefault(),
                            IsSync = item.TMOVCOMPL.ISSYNC == 1 ? true : false,
                            DataSync = item.TMOVCOMPL.DATASYNC,
                            Envelopes = envelopes
                        });
                    }
                    
                }
            }

            return lista;
        }

        public static void SincronizarVenda(Venda venda, int codColigada, int qtdeDias ,bool isAdmin = false) 
        { 
            //verifica pendencia financeiro
            try
            {
                //se nao for administrador efetua conferencia de pendencia financeira
                if (isAdmin == false) 
                {
                    var pendencias = RM.Lib.Cliente.PendenciaFinanceiro(venda.IdCliente, codColigada);
                    if (pendencias.Count > 0)
                    {
                        var errMessage = string.Format("O cliente {0} - {1} possuí {2} parcela(s) em atraso", venda.IdCliente, venda.NomeCliente, pendencias.Count);

                        throw new Exception(errMessage);
                    }
                }

                //efetua o sincronismo
                foreach (var env in venda.Envelopes) 
                {
                    //inclui envelope no cservice
                    Lib.Envelope.InsertFromRM(env, qtdeDias);

                    //atualiza sincronismo RM
                    Lib.Integracao.Envelope.UpdateSync(codColigada, env.IdVenda, env.IdItem);
                }

                //atualiza sincronismo da venda
                UpdateSincronismo(venda, codColigada);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateSincronismo(Venda venda, int codColigada) 
        {
            using (var conn = new RM.Dados.CorporeEntities())
            {
                var vendaRM = conn.TMOV.FirstOrDefault(a => a.IDMOV == venda.IdVenda && a.CODCOLIGADA == codColigada);

                venda.DataEmissao = venda.DataEmissao;
                
                //pega vendas a faturar que nao foram syncronizadas
                var update = conn.TMOVCOMPL.FirstOrDefault(a => a.CODCOLIGADA == codColigada && a.IDMOV == venda.IdVenda);

                update.ISSYNC = 1;
                update.DATASYNC = DateTime.Today.Date;

                conn.SaveChanges();
            }
        }

        #endregion
    }
}
