using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;


namespace RM.Lib
{
	public class Lancamento
	{
		public static List<Dados.FLAN> GetEntradas(Dados.TMOV venda)
		{
			List<Dados.FLAN> entradas = new List<Dados.FLAN>();
			decimal libera = Movimento.GetValorLiberacao(venda);
			decimal soma = 0;

			foreach (Dados.FLAN lanc in venda.FLAN)
			{
				if (soma < libera)
				{
					entradas.Add(lanc);
					soma += lanc.VALORORIGINAL;
				}
			}

			return entradas;
		}

		public static List<Dados.FLAN> GetByVenda(Dados.TMOV venda)
		{
			using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
			{
				return conn.FLAN.Where(a => a.IDMOV == venda.IDMOV && a.CODCOLIGADA == venda.CODCOLIGADA).ToList();
			}
		}

        public static List<Dados.FLAN> GetByCliente(int codColigada, string codCliente)
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                return conn.FLAN.Where(a => a.CODCOLIGADA == codColigada && a.CODCFO == codCliente && a.PAGREC == 1).ToList();
            }
        }

        public static Dados.FLAN GetById(short codColigada, int idLan)
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                return conn.FLAN.FirstOrDefault(a => a.IDLAN == idLan && a.CODCOLIGADA == codColigada);
            }
        }

		public static List<Dados.FLAN> GetEntradasByFilial(short codColigada, short codFilial, DateTime dtInicio, DateTime dtFim)
		{
			using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
			{
				return conn.FLAN
						   .Include(a => a.GFILIAL)
						   .Include(a => a.FLANCOMPL)
						   .Include(a => a.FCFO)
						   .Include(a => a.FCFO.FCFOCOMPL)
						   .Include(a => a.TVEN)
						   .Include(a => a.TMOV)
						   .Where(a => a.CODTB1FLX == "2.019" &&
									   a.CODCOLIGADA == codColigada &&
									   a.CODFILIAL == codFilial &&
									   a.DATAVENCIMENTO >= dtInicio.Date &&
									   a.DATAVENCIMENTO <= dtFim.Date)
							.ToList();
			}
		}

		public static List<Dados.FLAN> GetEntradasByVendedora(Dados.GFILIAL filial, Dados.TVEN vendedora, DateTime dtInicio, DateTime dtFim)
		{
			using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
			{
				return conn.FLAN
						   .Include(a => a.GFILIAL)
						   .Include(a => a.FLANCOMPL)
						   .Include(a => a.FCFO)
						   .Include(a => a.FCFO.FCFOCOMPL)
						   .Include(a => a.TVEN)
						   .Include(a => a.TMOV)
						   .Where(a => a.CODTB1FLX == "2.019" &&
									   a.CODCOLIGADA == filial.CODCOLIGADA &&
									   a.CODFILIAL == filial.CODFILIAL &&
									   a.TMOV.CODVEN1 == vendedora.CODVEN &&
									   a.TMOV.CODTB1FLX == "2.005" &&
									   a.TMOV.TMOVCOMPL.DTLIBERACAO >= dtInicio.Date && 
                                       a.TMOV.TMOVCOMPL.DTLIBERACAO <= dtFim.Date.Date &&
									   a.STATUSLAN == (short)Lib.Enums.StatusLan.Baixada)
							.ToList();
			}
		}

		public static List<Dados.FLAN> GetEntradasByGerente(Dados.GFILIAL filial, DateTime dtInicio, DateTime dtFim)
		{
			using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
			{
				return conn.FLAN
						   .Include(a => a.GFILIAL)
						   .Include(a => a.FLANCOMPL)
						   .Include(a => a.FCFO)
						   .Include(a => a.FCFO.FCFOCOMPL)
						   .Include(a => a.TVEN)
						   .Include(a => a.TMOV)
						   .Where(a => a.TMOV.TMOVCOMPL.DTLIBERACAO >= dtInicio.Date && 
                                       a.TMOV.TMOVCOMPL.DTLIBERACAO <= dtFim.Date &&
									   a.CODCOLIGADA == filial.CODCOLIGADA &&
									   a.CODFILIAL == filial.CODFILIAL &&
									   a.TMOV.CODTB1FLX == "2.005" &&
									   a.CODTB1FLX == "2.019" &&
									   a.STATUSLAN == (short)Lib.Enums.StatusLan.Baixada)
							.ToList();
			}
		}

		public static List<Dados.FLAN> GetParcialByVendedora(Dados.GFILIAL filial, Dados.TVEN vendedora)
		{
			using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
			{
				List<Dados.TMOV> vendas = Lib.Movimento.GetPendentesByVendedora(filial, vendedora);
				List<Dados.FLAN> lancamentos = new List<Dados.FLAN>();

				foreach (Dados.TMOV venda in vendas)
				{
					lancamentos.AddRange(venda.FLAN.Where(a => a.CODTB1FLX == "2.019" && a.STATUSLAN == 1));
				}

				return lancamentos;
			}
		}

		public static List<Dados.FLAN> GetParcialByFilial(Dados.GFILIAL filial)
		{
			using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
			{
				List<Dados.TMOV> vendas = Lib.Movimento.GetPendentesByFilial(filial);
				List<Dados.FLAN> lancamentos = new List<Dados.FLAN>();

				foreach (Dados.TMOV venda in vendas)
				{
					lancamentos.AddRange(venda.FLAN.Where(a => a.CODTB1FLX == "2.019" && a.STATUSLAN == 1));
				}

				return lancamentos;
			}
		}

		public static List<Dados.FLAN> GetEntradas_AbertoByVencimento(short codColigada, short codFilial, DateTime dtInicio, DateTime dtFim)
		{
			using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
			{
				return conn.FLAN
						   .Include(a => a.GFILIAL)
						   .Include(a => a.FLANCOMPL)
						   .Include(a => a.FCFO)
						   .Include(a => a.FCFO.FCFOCOMPL)
						   .Include(a => a.TVEN)
						   .Include(a => a.TMOV)
						   .Where(a => a.CODTB1FLX == "2.019" &&
									   a.CODCOLIGADA == codColigada &&
									   a.CODFILIAL == codFilial &&
									   a.DATAVENCIMENTO >= dtInicio.Date &&
									   a.DATAVENCIMENTO <= dtFim.Date &&
                                       a.PAGREC == 1 &&
									   a.STATUSLAN == 0)
							.ToList();
			}

		}

		public static List<Dados.FLAN> GetEntradas_PagasByVencimento(DateTime dtInicio, DateTime dtFim)
		{
			using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
			{
				return conn.FLAN
						   .Where(a => a.CODTB1FLX == "2.019" &&
									   a.DATAVENCIMENTO >= dtInicio.Date &&
									   a.DATAVENCIMENTO <= dtFim.Date &&
									   a.STATUSLAN == 1)
							.ToList();
			}

		}

		public static List<Dados.FLAN> GetLancamentosByBaixa(DateTime dtInicio, DateTime dtFim)
		{
			using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
			{
				var classe = new string[] { "2.005", "2.019" };

				return conn.FLAN
						   .Where(a => a.GFILIAL != (conn.GFILIAL.Where(b => b.CODFILIAL == 1 && b.CODCOLIGADA == 1).FirstOrDefault()) &&
									   a.DATABAIXA >= dtInicio.Date &&
									   a.DATABAIXA <= dtInicio.Date &&
									   a.TMOV != null &&
									   a.TMOV.CODTMV.Contains("2.2.") &&
									   a.TMOV.TMOVCOMPL.DTLIBERACAO == null &&
									   classe.Contains(a.CODTB1FLX) &&
									   a.TMOV.STATUS != "C")
							.ToList();
			}
		}

        public static List<Dados.FLAN> GetEntradasByVenda(short codColigada, int idMov)
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                return conn.FLAN
                           .Where(a => a.IDMOV == idMov &&
                                       a.CODCOLIGADA == codColigada &&
                                       a.CODTB1FLX == "2.019")
                           .ToList();
            }
        }

        public static decimal GetFluxoByFilial(short codColigada, short codFilial, DateTime dtInicio, DateTime dtFim) {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities()) 
            {
                var classes = new string[] { "2.020", "2.021", "2.022", "2.023" };
                var valor = conn.FLAN
                                .Where(a => a.CODCOLIGADA == codColigada &&
                                            a.CODFILIAL == codFilial &&
                                            a.DATABAIXA >= dtInicio.Date &&
                                            a.DATABAIXA <= dtFim.Date &&
                                            a.PAGREC == 1 &&
                                            !classes.Contains(a.CODTB1FLX) &&
                                            a.STATUSLAN == 1);
                                

                return valor.Count() == 0 ? 0 : valor.Sum(a => a.VALORBAIXADO);
            }
        }

        public static decimal GetFluxoByFilialTransferida(short codColigada, short codFilial, DateTime dtInicio, DateTime dtFim)
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                var classes = new string[] { "2.020", "2.021", "2.022", "2.023" };
                var valor = conn.FLAN
                                .Where(a => a.CODCOLIGADA == codColigada &&
                                            a.CODFILIAL == codFilial &&
                                            a.DATABAIXA >= dtInicio.Date &&
                                            a.DATABAIXA <= dtFim.Date &&
                                            a.PAGREC == 1 &&
                                            classes.Contains(a.CODTB1FLX) &&
                                            a.STATUSLAN == 1);


                return valor.Count() == 0 ? 0 : valor.Sum(a => a.VALORBAIXADO);
            }
        }


        #region SPC
        
        public static List<Dados.FLAN> SPC_Registro(CPanel.Dados.filiais filial, DateTime dtInicio, DateTime dtFim) 
        {
            //dtInicio = dtInicio.AddDays(-1);
            int p_coligada = filial.rm_coligada.GetValueOrDefault();
            int p_filial = filial.rm_filial.GetValueOrDefault();
            Dados.GFILIAL rm_filial = Lib.Filiais.GetById((short)p_coligada, (short)p_filial);
            List<Dados.FLAN> lanc = new List<Dados.FLAN>();
            
            switch (filial.spc_consulta)
            {
                case CPanel.Dados.SpcTipoConsulta.Padrao:
                    lanc = SPC_Registro_Padrao(rm_filial, dtInicio, dtFim);
                    break;
                case CPanel.Dados.SpcTipoConsulta.UsaProgramada:
                    lanc = SPC_Registro_UsaProgramada(rm_filial, dtInicio, dtFim);
                    break;
                case CPanel.Dados.SpcTipoConsulta.Tranferido:
                    lanc = SPC_Registro_Transferido(rm_filial, dtInicio, dtFim);
                    break;
                default:
                    lanc = SPC_Registro_Padrao(rm_filial, dtInicio, dtFim);
                    break;
            }
                
            //retorna lancamentos
            return lanc;
        }

        public static List<Dados.FLAN> SPC_Registro_Padrao(Dados.GFILIAL filial, DateTime dtInicio, DateTime dtFim)
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                return conn.FLAN
                           .Include(a => a.FCFO)
                           .Include(a => a.TMOV)
                           .Include(a => a.TMOV.FLAN)
                           .Include(a => a.FCFO.FCFOCOMPL)
                           .Include(a => a.FCFO.DTIPOBAIRRO)
                           .Include(a => a.FCFO.DTIPORUA)
                           .Where(a => a.PAGREC == 1 &&
                                       a.STATUSLAN == 0 &&
                                       a.CODFILIAL == filial.CODFILIAL &&
                                       a.CODCOLIGADA == filial.CODCOLIGADA &&
                                       a.DATAVENCIMENTO >= dtInicio.Date &&
                                       a.DATAVENCIMENTO <= dtFim.Date &&
                                       a.FCFO.ATIVO == 1 &&
                                       (a.FCFO.FCFOCOMPL == null || a.FCFO.FCFOCOMPL.GFC == null || a.FCFO.FCFOCOMPL.GFC == "" || a.FCFO.FCFOCOMPL.GFC == "0") &&
                                       a.TMOV.FLAN.Count(b => b.DATAVENCIMENTO < dtInicio.Date && b.STATUSLAN == 0) == 0)
                           .ToList();
            }
        }

        public static List<Dados.FLAN> SPC_Registro_UsaProgramada(Dados.GFILIAL filial, DateTime dtInicio, DateTime dtFim)
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                return conn.FLAN
                           .Include(a => a.FCFO)
                           .Include(a => a.TMOV)
                           .Include(a => a.TMOV.FLAN)
                           .Include(a => a.FCFO.FCFOCOMPL)
                           .Include(a => a.FCFO.DTIPOBAIRRO)
                           .Include(a => a.FCFO.DTIPORUA)
                           .Where(a => a.PAGREC == 1 &&
                                       a.STATUSLAN == 0 &&
                                       a.CODFILIAL == filial.CODFILIAL &&
                                       a.CODCOLIGADA == filial.CODCOLIGADA &&
                                       a.DATAVENCIMENTO >= dtInicio.Date &&
                                       a.DATAVENCIMENTO <= dtFim.Date &&
                                       a.TMOV.CODTB1FLX != "2.019" &&
                                       a.CODTB1FLX != "2.019" &&
                                       a.FCFO.ATIVO == 1 &&
                                       (a.FCFO.FCFOCOMPL == null || a.FCFO.FCFOCOMPL.GFC == null || a.FCFO.FCFOCOMPL.GFC == "" || a.FCFO.FCFOCOMPL.GFC == "0") &&
                                       a.TMOV.FLAN.Count(b => b.DATAVENCIMENTO < dtInicio.Date && b.STATUSLAN == 0) == 0)
                           .ToList();
            }
        }

        public static List<Dados.FLAN> SPC_Registro_Transferido(Dados.GFILIAL filial, DateTime dtInicio, DateTime dtFim)
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                var classes = new string[] { "2.020", "2.021", "2.022", "2.023" };
                return conn.FLAN
                           .Include(a => a.FCFO)
                           .Include(a => a.TMOV)
                           .Include(a => a.TMOV.FLAN)
                           .Include(a => a.FCFO.FCFOCOMPL)
                           .Include(a => a.FCFO.DTIPOBAIRRO)
                           .Include(a => a.FCFO.DTIPORUA)
                           .Where(a => a.PAGREC == 1 &&
                                       a.STATUSLAN == 0 &&
                                       a.CODFILIAL == filial.CODFILIAL &&
                                       a.CODCOLIGADA == filial.CODCOLIGADA &&
                                       a.DATAVENCIMENTO >= dtInicio.Date &&
                                       a.DATAVENCIMENTO <= dtFim.Date &&
                                       a.TMOV.CODTB1FLX != "2.019" &&
                                       classes.Contains(a.CODTB1FLX) == true &&
                                       a.FCFO.ATIVO == 1 &&
                                       (a.FCFO.FCFOCOMPL == null || a.FCFO.FCFOCOMPL.GFC == null || a.FCFO.FCFOCOMPL.GFC == "" || a.FCFO.FCFOCOMPL.GFC == "0") &&
                                       a.TMOV.FLAN.Count(b => b.DATAVENCIMENTO < dtInicio.Date && b.STATUSLAN == 0) == 0)
                           .ToList();
            }
        }

        public static List<Dados.FLAN> SPC_Reabilitar(CPanel.Dados.filiais filial, DateTime dtInicio, DateTime dtFim) 
        {
            int p_coligada = filial.rm_coligada.GetValueOrDefault();
            int p_filial = filial.rm_filial.GetValueOrDefault();
            Dados.GFILIAL rm_filial = Lib.Filiais.GetById((short)p_coligada, (short)p_filial);

            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                return conn.FLAN
                           .Include(a => a.FCFO)
                           .Include(a => a.TMOV)
                           .Include(a => a.TMOV.FLAN)
                           .Include(a => a.FCFO.FCFOCOMPL)
                           .Include(a => a.FCFO.DTIPOBAIRRO)
                           .Include(a => a.FCFO.DTIPORUA)
                           .Where(a => a.PAGREC == 1 &&
                                       a.STATUSLAN == 1 &&
                                       a.FCFO.CFOIMOB == 0 &&
                                       a.CODFILIAL == rm_filial.CODFILIAL &&
                                       a.CODCOLIGADA == rm_filial.CODCOLIGADA &&
                                       DbFunctions.DiffDays(a.DATAVENCIMENTO, a.DATAPAG) >= 30 &&
                                       a.DATAPAG >= dtInicio.Date &&
                                       a.DATAPAG <= dtFim.Date &&
                                       (a.FCFO.FCFOCOMPL.GFC == null || a.FCFO.FCFOCOMPL.GFC == "0"))
                           .ToList();
            }
        }
        
        #endregion

        public static void UpdateClasseEntradas(Dados.TMOV venda)
		{
			decimal libera = Movimento.GetValorLiberacao(venda);
			decimal soma = 0;

			using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
			{
				IQueryable<Dados.FLAN> lancamentos = conn.FLAN.Where(a => a.IDMOV == venda.IDMOV && a.CODCOLIGADA == venda.CODCOLIGADA).OrderBy(a => a.DATAVENCIMENTO);

				foreach (Dados.FLAN lanc in lancamentos)
				{
					if (libera == 0)
					{
						//classe de venda
						lanc.CODTB1FLX = "2.005";
					}
					else
					{
						if (soma < libera)
						{
							//classe de entrada
							lanc.CODTB1FLX = "2.019";

							//incrementa contador
							soma += lanc.VALORORIGINAL;
						}
						else
						{
							//classe de venda
							lanc.CODTB1FLX = "2.005";

							//incrementa contador
							soma += lanc.VALORORIGINAL;
						}
					}

				}

				conn.SaveChanges();

				//ATUALIZA STATUS DA ENTRADA
				Movimento.UpdateStatusLancamentos(venda);
			}
		}

        public static void UpdateClasseContabil(Dados.FLAN lanc) 
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities()) 
            {
                //recupera registro
                Dados.FLAN updated = conn.FLAN.FirstOrDefault(a => a.CODCOLIGADA == lanc.CODCOLIGADA && a.IDLAN == lanc.IDLAN);

                //atualiza a classe contabil
                updated.CODTB1FLX = lanc.CODTB1FLX;

                //salva o registro
                conn.SaveChanges();
            }
        }

        public static string GetStatus(short status)
        {
            string retorno;
            switch (status)
            {
                case 0:
                    retorno = "Em Aberto";
                    break;
                case 1:
                    retorno = "Baixado";
                    break;
                case 2:
                    retorno = "Cancelada";
                    break;
                case 3:
                    retorno = "Baixa Parcial";
                    break;
                default:
                    retorno = "Não Definida";
                    break;
            }

            return retorno;
        }


        #region PROGRAMADAS

        public static void Programada_UpdateClasseEntradas(Dados.TMOV venda)
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                //pega parcelas da venda
                IQueryable<Dados.FLAN> lancamentos = conn.FLAN.Where(a => a.IDMOV == venda.IDMOV && a.CODCOLIGADA == venda.CODCOLIGADA).OrderBy(a => a.DATAVENCIMENTO);

                if (lancamentos.Count() > 0) 
                {
                    if (venda.TMOVCOMPL.SEMENTRADA == "1")
                    {
                        //coloca todas as parcelas com a classe 2.005
                        foreach (var item in lancamentos)
                        {
                            item.CODTB1FLX = "2.005";
                        }

                        //libera venda
                        if (Lib.Movimento.Programada_VerificaLiberacao(venda) == true)
                        {
                            Lib.Movimento.UpdateVendaLiberada(venda);
                        }
                    }
                    else
                    {
                        //1ª parcelas = 2.019
                        lancamentos.FirstOrDefault().CODTB1FLX = "2.019";

                        //parcelas restantes = 2.005
                        if (lancamentos.Count() > 1)
                        {
                            foreach (var item in lancamentos.Skip(1))
                            {
                                item.CODTB1FLX = "2.005";
                            }
                        }
                        
                    }

                    conn.SaveChanges();
                }

                //ATUALIZA STATUS DA ENTRADA
                Movimento.UpdateStatusLancamentos(venda);
            }
        }

        #endregion
    }
}
