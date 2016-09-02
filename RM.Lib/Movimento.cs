using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RM.Lib
{
	public class Movimento
	{
		public static Dados.TMOV GetById(int idMov, short codColigada)
		{
			using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
			{
				//retorna todas as vendas programadas com baixas de parcelas em um periodo
				return conn.TMOV
						   .Include(a => a.TMOVCOMPL)
						   .Include(a => a.FCFO)
						   .Include(a => a.GFILIAL)
						   .Include(a => a.FCFO.FCFOCOMPL)
						   .Include(a => a.FLAN)
						   .Include(a => a.TVEN)
						   .Where(a => a.IDMOV == idMov && a.CODCOLIGADA == codColigada)
						   .FirstOrDefault();
			}
		}

		public static List<Dados.TMOV> GetPendentes(DateTime dtInicio, DateTime dtFim)
		{
			using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
			{
				//retorna todas as vendas programadas com baixas de parcelas em um periodo
				return conn.TMOV
						   .Include(a => a.TMOVCOMPL)
						   .Include(a => a.FCFO)
						   .Include(a => a.FCFO.FCFOCOMPL)
						   .Include(a => a.FLAN)
						   .Include(a => a.TVEN)
						   .Where(a => a.CODTB1FLX == "2.019" &&
									   a.STATUS != "C" &&
									   a.FLAN.Where(b => b.DATABAIXA >= dtInicio.Date && b.DATABAIXA <= dtFim.Date).Count() > 0)
						   .ToList();
			}
		}

		public static List<Dados.TMOV> GetPendentesByFilial(Dados.GFILIAL filial)
		{
			using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
			{
				//retorna todas as vendas programadas com baixas de parcelas em um periodo
				return conn.TMOV
						   .Include(a => a.TMOVCOMPL)
						   .Include(a => a.FCFO)
						   .Include(a => a.FCFO.FCFOCOMPL)
						   .Include(a => a.FLAN)
						   .Include(a => a.TVEN)
						   .Where(a => a.CODCOLIGADA == filial.CODCOLIGADA &&
									   a.CODFILIAL == filial.CODFILIAL &&
									   a.CODTB1FLX == "2.019" &&
									   a.STATUS != "C")
						   .ToList();
			}
		}

		public static List<Dados.TMOV> GetPendentesByVendedora(Dados.GFILIAL filial, Dados.TVEN vendedora)
		{
			using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
			{
				//retorna todas as vendas programadas com baixas de parcelas em um periodo
				return conn.TMOV
						   .Include(a => a.TMOVCOMPL)
						   .Include(a => a.FCFO)
						   .Include(a => a.FCFO.FCFOCOMPL)
						   .Include(a => a.FLAN)
						   .Include(a => a.TVEN)
						   .Where(a => a.CODCOLIGADA == filial.CODCOLIGADA &&
									   a.CODFILIAL == filial.CODFILIAL &&
									   a.CODTB1FLX == "2.019" &&
									   a.STATUS != "C" &&
									   a.CODVEN1 == vendedora.CODVEN)
						   .ToList();
			}
		}

		public static List<Dados.TMOV> GetVendasByPeriodo(DateTime dtInicio, DateTime dtFim)
		{
			using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
			{
				var classe = new string[] { "2.005", "2.019" };

				//retorna todas de um periodo
				return conn.TMOV
						   .Include(a => a.TMOVCOMPL)
						   .Include(a => a.FCFO)
						   .Include(a => a.FCFO.FCFOCOMPL)
						   .Include(a => a.FLAN)
						   .Include(a => a.TVEN)
						   .Include(a => a.GFILIAL)
						   .Where(a => a.GFILIAL != (conn.GFILIAL.Where(b => b.CODFILIAL == 1 && b.CODCOLIGADA == 1).FirstOrDefault()) &&
									   a.DATAEMISSAO >= dtInicio.Date &&
									   a.DATAEMISSAO <= dtFim.Date &&
									   a.CODTMV.Contains("2.2.") &&
									   classe.Contains(a.CODTB1FLX) &&
									   a.STATUS != "C")
						   .ToList();
			}
		}

		public static List<Dados.TMOV> GetVendasByBaixa(DateTime dtInicio, DateTime dtFim)
		{
			using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
			{
				List<Dados.FLAN> lanc = Lancamento.GetLancamentosByBaixa(dtInicio, dtFim);
				List<Dados.TMOV> vendas = new List<Dados.TMOV>();

				foreach (var item in lanc) 
				{
					vendas.Add(GetById((int)item.IDMOV, item.CODCOLIGADA));
				}

				return vendas;
			}
		}

		public static List<Dados.TMOV> GetVendasLiberadas(Dados.GFILIAL filial, DateTime dtInicio, DateTime dtFim)
		{
			using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
			{
                //return conn.TMOV
                //           .Include(a => a.TMOVCOMPL)
                //           .Include(a => a.FCFO)
                //           .Include(a => a.FCFO.FCFOCOMPL)
                //           .Include(a => a.FLAN)
                //           .Include(a => a.TVEN)
                //           .Where(a => a.CODCOLIGADA == filial.CODCOLIGADA &&
                //                       a.CODFILIAL == filial.CODFILIAL &&
                //                       a.CODTB1FLX == "2.005" &&
                //                       a.CODTMV.Contains("2.2.") &&
                //                       a.TVEN != null &&
                //                       a.STATUS != "C" &&
                //                       ((a.DATAEMISSAO >= dtInicio.Date && a.DATAEMISSAO <= dtFim.Date) ||
                //                        (a.TMOVCOMPL.DTLIBERACAO >= dtInicio.Date && a.TMOVCOMPL.DTLIBERACAO <= dtFim.Date)))
                //           .ToList();
                return conn.TMOV
                           .Include(a => a.TMOVCOMPL)
                           .Include(a => a.FCFO)
                           .Include(a => a.FCFO.FCFOCOMPL)
                           .Include(a => a.FLAN)
                           .Include(a => a.TVEN)
                           .Where(a => a.CODCOLIGADA == filial.CODCOLIGADA &&
                                       a.CODFILIAL == filial.CODFILIAL &&
                                       a.CODTB1FLX == "2.005" &&
                                       a.CODTMV.Contains("2.2.") &&
                                       a.TVEN != null &&
                                       a.STATUS != "C" &&
                                       a.TMOVCOMPL.DTLIBERACAO >= dtInicio.Date && 
                                       a.TMOVCOMPL.DTLIBERACAO <= dtFim.Date)
                           .ToList();
			}
		}

		public static List<Dados.TMOV> GetVendasByEmissao(Dados.GFILIAL filial, DateTime dtInicio, DateTime dtFim)
		{
			using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
			{
				var classe = new string[] { "2.005", "2.019" };

				return conn.TMOV
						   .Include(a => a.TMOVCOMPL)
						   .Include(a => a.FCFO)
						   .Include(a => a.FCFO.FCFOCOMPL)
						   .Include(a => a.FLAN)
						   .Include(a => a.TVEN)
						   .Where(a => a.CODCOLIGADA == filial.CODCOLIGADA &&
									   a.CODFILIAL == filial.CODFILIAL &&
									   a.CODTMV.Contains("2.2.") &&
									   a.TVEN != null &&
									   a.STATUS != "C" &&
									   classe.Contains(a.CODTB1FLX) &&
									   a.DATAEMISSAO >= dtInicio.Date &&
									   a.DATAEMISSAO <= dtFim.Date)
						   .ToList();
			}
		}

        public static List<Dados.TMOV> GetVendasByCliente(Dados.GFILIAL filial, string codCliente)
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                return conn.TMOV
                           .Include(a => a.TMOVCOMPL)
                           .Include(a => a.FCFO)
                           .Include(a => a.FCFO.FCFOCOMPL)
                           .Include(a => a.FLAN)
                           .Include(a => a.TVEN)
                           .Where(a => a.CODCOLIGADA == filial.CODCOLIGADA &&
                                       a.CODFILIAL == filial.CODFILIAL &&
                                       a.CODTMV.Contains("2.2.") &&
                                       a.CODCFO.Contains(codCliente))
                           .ToList();
            }
        }

		public static decimal GetValorLiberacao(Dados.TMOV venda)
		{
			return decimal.Floor(((venda.VALORLIQUIDO * venda.FCFO.FCFOCOMPL.PERCLIBERACAO) / 100).Value);
		}

		public static decimal GetTotalPago(Dados.TMOV venda)
		{
			return venda.FLAN.Where(a => a.STATUSLAN == (short)Enums.StatusLan.Baixada).Sum(a => a.VALORORIGINAL);
		}

		public static bool VerificaLiberacao(Dados.TMOV venda)
		{
			if (GetValorLiberacao(venda) == 0)
			{
				return true;
			}
			else
			{
				if (GetTotalPago(venda) >= GetValorLiberacao(venda))
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}

        public static bool Programada_VerificaLiberacao(Dados.TMOV venda)
        {
            if (venda.FLAN.Where(a => a.CODTB1FLX == "2.019" && a.STATUSLAN == 0).Count() == 0)
            {
                if (venda.TMOVCOMPL.DTLIBERACAO == null)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            else 
            {
                return false;
            }
        }

		public static string GetTipoVenda(string classe)
		{
			string tipo;

			switch (classe)
			{
				case "2.005":
					tipo = "V";
					break;
				case "2.019":
					tipo = "P";
					break;
				default:
					tipo = "N/D";
					break;
			}

			return tipo;
		}

        public static string GetStatus(string status) 
        {
            string retorno;
            switch (status)
            {
                case "N":
                    retorno = "Normal";
                    break;
                case "R":
                    retorno = "Não Processado";
                    break;
                case "A":
                    retorno = "A Faturar";
                    break;
                case "F":
                    retorno = "Faturado";
                    break;
                case "P":
                    retorno = "Parcialmente Quitado";
                    break;
                case "Q":
                    retorno = "Quitado";
                    break;
                case "C":
                    retorno = "Cancelado";
                    break;
                case "D":
                    retorno = "Perda";
                    break;
                case "I":
                    retorno = "Inativo";
                    break;
                case "T":
                    retorno = "Cotação";
                    break;
                case "B":
                    retorno = "Baixado";
                    break;
                case "L":
                    retorno = "Liberado";
                    break;
                case "U":
                    retorno = "Em Faturamento";
                    break;
                default:
                    retorno = "Normal";
                    break;
            }

            return retorno;
        }

        public static Dados.TMOVCOMPL InsertCompl(Dados.TMOV venda) {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities()) 
            {
                var compl = new Dados.TMOVCOMPL();
                compl.CODCOLIGADA = venda.CODCOLIGADA;
                compl.IDMOV = venda.IDMOV;
                compl.DTLIBERACAO = null;
                compl.MOTIVOLIB = null;
                compl.MOTIVSPC = null;
                compl.SEMENTRADA = "0";
                compl.STATUSUPDATE = 1;
                compl.RECCREATEDBY = "mestre";
                compl.RECCREATEDON = DateTime.Now;
                compl.RECMODIFIEDBY = "mestre";
                compl.RECMODIFIEDON = DateTime.Now;

                conn.TMOVCOMPL.Add(compl);
                conn.SaveChanges();

                return compl;
            }
        }

		public static void UpdateVendaLiberada(Dados.TMOV venda)
		{
			using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
			{
				//recupera dados da venda
				Dados.TMOV update = conn.TMOV.Where(a => a.IDMOV == venda.IDMOV && a.CODCOLIGADA == venda.CODCOLIGADA).FirstOrDefault();

                update.CODTB1FLX = "2.005";
                update.TMOVCOMPL.DTLIBERACAO = DateTime.Now.Date;

				//salva alterações
				conn.SaveChanges();
			}
		}

		public static void UpdateStatusLancamentos(Dados.TMOV venda)
		{
			using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
			{
				//recupera dados da venda
				Dados.TMOV update = conn.TMOV.Where(a => a.IDMOV == venda.IDMOV && a.CODCOLIGADA == venda.CODCOLIGADA).FirstOrDefault();

				//altera dados da venda
				update.TMOVCOMPL.STATUSUPDATE = 1;

				//salva alterações
				conn.SaveChanges();
			}
		}

        public static void UpdateRetiraCaderno(Dados.TMOV venda)
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                //recupera dados da venda
                Dados.TMOV update = conn.TMOV.Where(a => a.IDMOV == venda.IDMOV && a.CODCOLIGADA == venda.CODCOLIGADA).FirstOrDefault();

                update.CODTB1FLX = "2.019";
                update.TMOVCOMPL.DTLIBERACAO = null;

                //salva alterações
                conn.SaveChanges();
            }
        }

        public static void UpdateIncluiCaderno(Dados.TMOV venda, DateTime data)
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                //recupera dados da venda
                Dados.TMOV update = conn.TMOV.Where(a => a.IDMOV == venda.IDMOV && a.CODCOLIGADA == venda.CODCOLIGADA).FirstOrDefault();

                update.CODTB1FLX = "2.005";
                update.TMOVCOMPL.DTLIBERACAO = data;

                //salva alterações
                conn.SaveChanges();
            }
        }
	}
}
