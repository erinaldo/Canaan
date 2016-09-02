using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CPanel.Lib
{
    public class Lancamento
    {
        public static int GetDiaInicio(int idPeriodo, int diaInicio) 
        {
            using (var conn = new CPanel.Dados.CPanelEntities()) 
            {
                var lanc = conn.lancamentos
                               .OrderBy(a => a.dia)
                               .FirstOrDefault(a => a.id_periodo == idPeriodo && a.bloqueado == false && a.dia >= diaInicio);

                if (lanc != null)
                    return lanc.dia.GetValueOrDefault();
                else
                    return 0;
            }
        }

        public static int GetDiaFim(int idPeriodo, int diaFim)
        {
            using (var conn = new CPanel.Dados.CPanelEntities())
            {
                var lanc = conn.lancamentos
                               .OrderByDescending(a => a.dia)
                               .FirstOrDefault(a => a.id_periodo == idPeriodo && a.bloqueado == false && a.dia <= diaFim);

                if (lanc != null)
                    return lanc.dia.GetValueOrDefault();
                else
                    return 0;
            }
        }

        public static int GetDiasTrabalhados(int idPeriodo, int diaInicio, int diaFim) 
        {
            using (var conn = new CPanel.Dados.CPanelEntities())
            {
                return conn.lancamentos
                           .Where(a => a.id_periodo == idPeriodo &&
                                       a.dia >= diaInicio &&
                                       a.dia <= diaFim &&
                                       a.bloqueado == false)
                           .Count();
            }
        }

        public static List<CPanel.Dados.lancamentos> GetByPeriodoDias(int idPeriodo, int diaInicio, int diaFim) 
        {
            using (var conn = new CPanel.Dados.CPanelEntities()) 
            {
                return conn.lancamentos
                           .Where(a => a.id_periodo == idPeriodo &&
                                       a.dia >= diaInicio &&
                                       a.dia <= diaFim &&
                                       a.bloqueado == false)
                           .ToList();
            }
        }

        public static List<CPanel.Dados.lancamentos> GetByPeriodo(int idPeriodo)
        {
            using (var conn = new CPanel.Dados.CPanelEntities())
            {
                return conn.lancamentos
                           .Where(a => a.id_periodo == idPeriodo &&
                                       a.bloqueado == false)
                           .ToList();
            }
        }

        public static CPanel.Dados.lancamentos GetCurrent(int idFilial, int ano, int mes) 
        {
            using (var conn = new Dados.CPanelEntities()) 
            {
                //pega o periodo atual
                var periodo = Periodo.GetPeriodo(ano, mes, idFilial);

                //verifica se periodo existe
                if (periodo != null)
                {
                    var atual = conn.lancamentos.FirstOrDefault(a => a.id_periodo == periodo.id_periodo && a.faturamento == 0 && a.faturamento_bruto == 0 && a.fluxo_caixa == 0 && a.fotografados == 0 && a.recebimento_rm == 0 && a.recebimento_caixa == 0 && a.bloqueado == false);

                    if (atual != null)
                    {
                        return atual;
                    }
                    else 
                    {
                        throw new Exception("Nenhum lançamento encontrado");
                    }
                }
                else 
                {
                    throw new Exception("Nenhum periodo de lançamento encontrado");
                }
            }
        }

        public static CPanel.Dados.lancamentos GetById(int idLancamento)
        {
            using (var conn = new Dados.CPanelEntities())
            {
                var atual = conn.lancamentos
                                .Include(a => a.filiais)
                                .FirstOrDefault(a => a.id_lancamento == idLancamento);

                if (atual != null)
                {
                    return atual;
                }
                else
                {
                    throw new Exception("Nenhum lançamento encontrado");
                }
            }
        }

        public static CPanel.Dados.lancamentos Update(CPanel.Dados.lancamentos lanc) 
        {
            using (var conn = new Dados.CPanelEntities())
            {
                //carrega o registro do banco
                var update = conn.lancamentos.FirstOrDefault(a => a.id_lancamento == lanc.id_lancamento);

                //atualiza registro
                update.venda_entradas = lanc.venda_entradas;
                update.venda_entrada_cartao = lanc.venda_entrada_cartao;
                update.venda_entrada_depositada = lanc.venda_entrada_depositada;
                update.venda_prazo = lanc.venda_prazo;
                update.venda_vista = lanc.venda_vista;
                update.venda_vista_cartao = lanc.venda_vista_cartao;
                update.venda_devolvidas = lanc.venda_devolvidas;
                update.faturamento = lanc.faturamento;
                update.faturamento_bruto = lanc.faturamento_bruto;
                update.comissao = lanc.comissao;
                update.recebimento = lanc.recebimento;
                update.recebimento_rm = lanc.recebimento_rm;
                update.recebimento_caixa = lanc.recebimento_caixa;
                update.fluxo_caixa = lanc.fluxo_caixa;
                update.ponto_equilibrio = (lanc.faturamento + lanc.fluxo_caixa) / 2;
                update.fotografados = lanc.fotografados;
                update.condicional = lanc.condicional;
                update.vendas = lanc.vendas;
                update.brindes = lanc.brindes;
                update.atendidos = lanc.atendidos;
                update.bloqueado = lanc.bloqueado;

                //grava no banco de dados
                conn.SaveChanges();

                //atualiza acumuladores
                UpdateDepenencias(update);

                //retorna lancamento atualizado
                return update;
            }
        }

        private static void UpdateDepenencias(CPanel.Dados.lancamentos lanc) 
        {
            using (var conn = new Dados.CPanelEntities())
            {
                var semanas = conn.periodos_semanas.Where(a => a.id_periodo == lanc.id_periodo).ToList();

                decimal fotogMedia = 0;
                decimal fotogAcum = 0;
                decimal progMedia = 0;
                decimal progAcum = 0;
                decimal vendaMedia = 0;
                decimal vendaAcum = 0;
                decimal vendaPerc = 0;
                
                int i = 0;

                foreach (var semana in semanas)
                {
                    decimal fluxoSemana = 0;
                    decimal faturaSemana = 0;
                    decimal fotogSemana = 0;
                    decimal entradaSemana = 0;
                    decimal recebSemana = 0;

                    var lancamentos = conn.lancamentos.Where(a => a.id_periodo_semana == semana.id_periodo_semana).ToList();
                    foreach (var item in lancamentos)
                    {
                        //acumulo semanal
                        fluxoSemana += item.fluxo_caixa.GetValueOrDefault();
                        faturaSemana += item.faturamento.GetValueOrDefault();
                        fotogSemana += item.fotografados.GetValueOrDefault();
                        entradaSemana += item.comissao.GetValueOrDefault();
                        recebSemana += item.recebimento.GetValueOrDefault();

                        //calcula acumulo geral
                        fotogAcum += item.fotografados.GetValueOrDefault();
                        progAcum += item.condicional.GetValueOrDefault();
                        vendaAcum += item.vendas.GetValueOrDefault();

                        //calcula media geral
                        i++;
                        fotogMedia = fotogAcum / i;
                        progMedia = progAcum / i;
                        vendaMedia = vendaAcum / i;

                        //atualiza percentual de venda
                        if (item.fotografados > 0)
                            vendaPerc = (item.vendas.GetValueOrDefault() * 100) / item.fotografados.GetValueOrDefault();
                        else
                            vendaPerc = 0;

                        //altera item
                        item.fotografados_media = (int)fotogMedia;
                        item.fotografados_acumulo = (int)fotogAcum;
                        item.condicional_media = (int)progMedia;
                        item.condicional_acumulo = (int)progAcum;
                        item.vendas_media = (int)vendaMedia;
                        item.vendas_acumulo = (int)vendaAcum;
                        item.vendas_perc = vendaPerc;
                    }

                    //salva alteracoes do item
                    conn.SaveChanges();

                    //atualiza faturamento da semana
                    if (faturaSemana > 0) 
                    {
                        var metaFaturamento = conn.metas_faturamento.FirstOrDefault(a => a.id_periodo_semana == semana.id_periodo_semana);
                        metaFaturamento.valor_alcancado = faturaSemana;
                        metaFaturamento.perc_alcancado = (faturaSemana * 100) / metaFaturamento.valor_meta.GetValueOrDefault();

                        conn.SaveChanges();
                    }

                    //atualiza fluxo da semana
                    if (fluxoSemana > 0)
                    {
                        var metaFluxo = conn.metas_fluxo.FirstOrDefault(a => a.id_periodo_semana == semana.id_periodo_semana);
                        metaFluxo.valor_alcancado = fluxoSemana;
                        metaFluxo.perc_alcancado = (fluxoSemana * 100) / metaFluxo.valor_meta.GetValueOrDefault();
                        
                        conn.SaveChanges();
                    }

                    //atualiza fotografados da semana
                    if (fotogSemana > 0)
                    {
                        var metaFotog = conn.metas_fotografados.FirstOrDefault(a => a.id_periodo_semana == semana.id_periodo_semana);
                        metaFotog.total_alcancado = (int)fotogSemana;
                        metaFotog.perc_alcancado = (fotogSemana * 100) / metaFotog.meta_semanal.GetValueOrDefault();

                        conn.SaveChanges();
                    }

                    //atualiza entradas da semana
                    if (entradaSemana > 0)
                    {
                        var metaEntrada = conn.metas_entradas.FirstOrDefault(a => a.id_periodo_semana == semana.id_periodo_semana);
                        metaEntrada.valor_alcancado = entradaSemana;
                        metaEntrada.perc_alcancado = (entradaSemana * 100) / metaEntrada.valor_meta.GetValueOrDefault();

                        conn.SaveChanges();
                    }

                    //atualiza recebimento da semana
                    if (recebSemana > 0)
                    {
                        var metaReceb = conn.metas_recebimento.FirstOrDefault(a => a.id_periodo_semana == semana.id_periodo_semana);
                        metaReceb.valor_alcancado = recebSemana;
                        metaReceb.perc_alcancado = (recebSemana * 100) / metaReceb.valor_meta.GetValueOrDefault();
                        
                        conn.SaveChanges();
                    }
                }
            }
        }
    }
}
