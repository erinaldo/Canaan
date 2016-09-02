using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Relatorios.Vendas.RankingServicos
{
    public class Model
    {
        public short CodColigada { get; set; }
        public short CodFilial { get; set; }
        public int CodProduto { get; set; }
        public string NomeFilial { get; set; }
        public string NomeProduto { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }

        public static List<Model> Get(DateTime dtInicio, DateTime dtFim) 
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities()) 
            { 
                //filtra items de venda por periodo
                var query = conn.TITMMOV.Where(a => a.TMOV.DATAEMISSAO >= dtInicio &&
											a.TMOV.DATAEMISSAO <= dtFim &&
                                            a.TPRODUTO.TIPO == "S" &&
											a.TMOV.STATUS != "C" &&
											a.TMOV.CODTMV.StartsWith("2.2") &&
											a.TMOV.GFILIAL.NOMEFANTASIA.Contains("CPC") == false);

                //retorna lista de items
                return query.Select(a => new Model
                {
                    CodColigada = a.TMOV.CODCOLIGADA,
                    CodFilial = (short)a.TMOV.CODFILIAL,
                    CodProduto = (int)a.IDPRD,
                    NomeFilial = a.TMOV.GFILIAL.NOMEFANTASIA,
                    NomeProduto = a.TPRODUTO.NOMEFANTASIA,
                    Quantidade = (int)a.QUANTIDADE,
                    ValorUnitario = (decimal)a.VALORUNITARIO,
                    ValorTotal = (decimal)a.VALORTOTALITEM
                })
                .Where(a => a.NomeProduto.Contains("GFC") == false)
                .ToList();
            }
        }
    }
}
