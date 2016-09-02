using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Relatorios.Faturamento.Vendedora
{
    public class Model
    {
        public string CodCMaster { get; set; }
        public string CodRm { get; set; }
        public int CodVenda { get; set; }
        public string NomeCliente { get; set; }
        public string NomeVendedora { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal ValorEntrada { get; set; }
        public int QuantEntradas { get; set; }

        public static List<Model> GetAll(short codColigada, short codFilial, DateTime dtInicio, DateTime dtFim) 
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                var consulta = conn.TMOV
                                    .Where(a => a.TMOVCOMPL.DTLIBERACAO >= dtInicio &&
                                                a.TMOVCOMPL.DTLIBERACAO <= dtFim &&
                                                a.CODCOLIGADA == codColigada &&
                                                a.CODFILIAL == codFilial &&
                                                a.CODTB1FLX == "2.005")
                                    .ToList()
                                    .Select(a => new Model()
                                    {
                                        CodCMaster = a.FCFO.FCFOCOMPL.CODCMASTER.ToString(),
                                        CodRm = a.FCFO.CODCFO,
                                        CodVenda = (int)a.IDMOV,
                                        NomeCliente = a.FCFO.NOME,
                                        NomeVendedora = a.TVEN.NOME,
                                        DataVenda = (DateTime)a.TMOVCOMPL.DTLIBERACAO,
                                        ValorLiquido = (decimal)a.VALORLIQUIDO,
                                        ValorEntrada = (decimal)a.FLAN.Where(b => b.CODTB1FLX == "2.019").Sum(b => b.VALORORIGINAL),
                                        QuantEntradas = (int)a.FLAN.Where(b => b.CODTB1FLX == "2.019").Count()
                                    });

                return consulta.ToList();
            }
        }

        public static List<Model> GetByVendedora(short codColigada, short codFilial, string vendedora, DateTime dtInicio, DateTime dtFim)
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                var consulta = conn.TMOV
                                    .Where(a => a.TMOVCOMPL.DTLIBERACAO >= dtInicio &&
                                                a.TMOVCOMPL.DTLIBERACAO <= dtFim &&
                                                a.CODCOLIGADA == codColigada &&
                                                a.CODFILIAL == codFilial &&
                                                a.TVEN.CODVEN == vendedora &&
                                                a.CODTB1FLX == "2.005")
                                    .ToList()
                                    .Select(a => new Model()
                                    {
                                        CodCMaster = a.FCFO.FCFOCOMPL.CODCMASTER.ToString(),
                                        CodRm = a.FCFO.CODCFO,
                                        CodVenda = (int)a.IDMOV,
                                        NomeCliente = a.FCFO.NOME,
                                        NomeVendedora = a.TVEN.NOME,
                                        DataVenda = (DateTime)a.TMOVCOMPL.DTLIBERACAO,
                                        ValorLiquido = (decimal)a.VALORLIQUIDO,
                                        ValorEntrada = (decimal)a.FLAN.Where(b => b.CODTB1FLX == "2.019").Sum(b => b.VALORORIGINAL),
                                        QuantEntradas = (int)a.FLAN.Where(b => b.CODTB1FLX == "2.019").Count()
                                    });

                return consulta.ToList();
            }
        }
    }
}
