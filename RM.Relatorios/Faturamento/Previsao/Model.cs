using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Relatorios.Faturamento.Previsao
{
    public class Model
    {
        public string CodCMaster { get; set; }
        public string CodRm { get; set; }
        public int CodVenda { get; set; }
        public string NomeCliente { get; set; }
        public string NomeVendedora { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal ValorEntrada { get; set; }

        public static List<Model> GetResult(short codColigada, short codFilial, DateTime dtInicio, DateTime dtFim)
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                var consulta = conn.FLAN
                                   .Where(a => a.CODCOLIGADA == codColigada &&
                                               a.CODFILIAL == codFilial &&
                                               a.STATUSLAN == 0 &&
                                               a.DATAVENCIMENTO >= dtInicio.Date &&
                                               a.DATAVENCIMENTO <= dtFim.Date &&
                                               a.TMOV.CODTB1FLX == "2.019" &&
                                               a.CODTB1FLX == "2.019" &&
                                               a.TMOV.FLAN.Where(b => b.CODTB1FLX == "2.019" && b.STATUSLAN == 0).Count() == 1)
                                    .ToList()
                                    .Select(a => new Model()
                                    {
                                        CodCMaster = a.FCFO.FCFOCOMPL.CODCMASTER.ToString(),
                                        CodRm = a.FCFO.CODCFO,
                                        CodVenda = (int)a.IDMOV,
                                        NomeCliente = a.FCFO.NOME,
                                        NomeVendedora = a.TMOV.TVEN.NOME,
                                        DataVenda = (DateTime)a.TMOV.DATAEMISSAO,
                                        DataVencimento = a.DATAVENCIMENTO,
                                        ValorLiquido = (decimal)a.TMOV.VALORLIQUIDO,
                                        ValorEntrada = (decimal)a.TMOV.FLAN.Where(b => b.CODTB1FLX == "2.019").Sum(b => b.VALORORIGINAL)
                                    })
                                    .Distinct(new ResultComparer());

                return consulta.ToList();
            }
        }
    }

    public class ResultComparer : IEqualityComparer<Model>
    {
        public bool Equals(Model a, Model b)
        {
            return a.CodVenda == b.CodVenda;
        }

        public int GetHashCode(Model resultado)
        {
            return resultado.CodVenda.GetHashCode();
        }
    }
}
