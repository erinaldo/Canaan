using System;
using System.Collections.Generic;
using System.Linq;

namespace RM.Telas.Ferramentas.Quantum.Remessa
{
    public class Model
    {
        public string MatrizCnpj { get; set; }
        public string FilialCnpj { get; set; }
        public string FilialNome { get; set; }
        public string Cgc { get; set; }
        public string RazaoSocial { get; set; }
        
        public string EndRua { get; set; }
        public string EndNum { get; set; }
        public string EndComp { get; set; }
        public string EndBairro { get; set; }
        public string EndCidade { get; set; }
        public string EndUf { get; set; }
        public string EndCep { get; set; }

        public string Fone1DDD { get; set; }
        public string Fone1Num { get; set; }
        public string Fone2DDD { get; set; }
        public string Fone2Num { get; set; }

        public string CodCliente { get; set; }
        public string CodDocumento { get; set; }
        public string CodVenda { get; set; }

        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }

        public decimal ValorLiquido { get; set; }
        public decimal ValorCustas { get; set; }

        public string Email { get; set; }
        public string Obs { get; set; }

        public static List<Model> GetLista(short coligada, short filial, DateTime dtInicio, DateTime dtFim) 
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities()) 
            {
                //pega vendas com ultimo lancamento a receber, em aberto com vencimento no periodo
                var query = conn.TMOV
                                .Where(a => a.CODCOLIGADA == coligada &&
                                            a.CODFILIAL == filial &&
                                            a.STATUS != "C" &&
                                            a.FLAN.OrderByDescending(b => b.IDLAN).Take(1).Where(b => b.STATUSLAN == 0 && b.PAGREC == 1 && b.DATAVENCIMENTO >= dtInicio.Date && b.DATAVENCIMENTO <= dtFim.Date).Count() > 0);

                //cria lista
                List<Model> lista = new List<Model>();

                //carrega a lista
                foreach (var venda in query)
                {
                    //pega lancamentos em aberto
                    var lanc = conn.FLAN.Where(a => a.CODCOLIGADA == coligada && a.CODFILIAL == filial && a.IDMOV == venda.IDMOV && a.STATUSLAN == 0);

                    //carrega lancamentos na lista
                    foreach (var doc in lanc)
                    {
                        //adiciona novo registro na lista
                        lista.Add(new Model { 
                            MatrizCnpj = doc.GCOLIGADA.CGC,
                            FilialCnpj = doc.GFILIAL.CGC,
                            FilialNome = doc.GFILIAL.NOMEFANTASIA,
                            Cgc = doc.FCFO.CGCCFO,
                            RazaoSocial = doc.FCFO.NOMEFANTASIA,
                            
                            EndRua = string.Format("{0}", doc.FCFO.RUA),
                            EndNum = doc.FCFO.NUMERO,
                            EndComp = doc.FCFO.COMPLEMENTO,
                            EndBairro = string.Format("{0}", doc.FCFO.BAIRRO),
                            EndCidade = doc.FCFO.CIDADE,
                            EndUf = doc.FCFO.CODETD,
                            EndCep = doc.FCFO.CEP,

                            Fone1DDD = "",
                            Fone1Num = doc.FCFO.TELEFONE,
                            Fone2DDD = "",
                            Fone2Num = doc.FCFO.TELEX,

                            CodCliente = doc.CODCFO,
                            CodVenda = doc.IDMOV.ToString(),
                            CodDocumento = doc.IDLAN.ToString(),

                            DataEmissao = doc.DATAEMISSAO,
                            DataVencimento = doc.DATAVENCIMENTO,

                            ValorLiquido = doc.VALORORIGINAL,
                            ValorCustas = 0,

                            Email = doc.FCFO.EMAIL,
                            Obs = venda.CODTMV
                        });
                    }
                }

                //retorna a lista
                return lista;
            }
        }

        public static void ExportaLista(List<Model> lista, string filename) 
        {
            
        }

        public static void BloqueiaLancamentos(short codColigada, short codFilial, short numBloqueio,List<Model> lista, decimal comissao) 
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities()) 
            {
                foreach (var item in lista)
                {
                    //encontra registro do lancamento no banco de dados
                    int idlan = int.Parse(item.CodDocumento);
                    var lanc = conn.FLAN.FirstOrDefault(a => a.CODCOLIGADA == codColigada && a.CODFILIAL == codFilial && a.IDLAN == idlan);
                    
                    //marca como bloqueado / desbloqueado
                    lanc.NUMBLOQUEIOS = numBloqueio;
                    lanc.CODTB1FLX = "2.027";
                    lanc.FLANCOMPL.PERCQUANTUM = comissao;
                }

                //grava dados no banco de dados
                conn.SaveChanges();
            }
        }
    }
}
