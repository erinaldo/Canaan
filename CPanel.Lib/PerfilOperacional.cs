using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CPanel.Lib
{
    public class PerfilOperacional
    {
        #region PROPRIEDADES

        public int IdFilial { get; set; }
        public string Filial { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public int DiaInicio { get; set; }
        public int DiaFim { get; set; }
        public int DiasMes { get; set; }
        public int DiasTrab { get; set; }
        public int DiasRestantes 
        { 
            get 
            {
                return DiasMes - DiasTrab;
            } 
        }
        public decimal Produtividade { get; set; }

        public decimal MetaFotog { get; set; }
        public decimal MetaVend { get; set; }
        public decimal MetaAprov { get; set; }
        public decimal MetaFatura { get; set; }
        public decimal MetaFluxo { get; set; }
        public decimal MetaEntrada { get; set; }
        public decimal MetaReceb { get; set; }
        public decimal MetaTicket { get; set; }
        public decimal MetaAtend { get; set; }
        public decimal MetaPherfil { get; set; }

        public decimal PerFatura { get; set; }
        public decimal PerFotog { get; set; }
        public decimal PerVend { get; set; }
        public decimal PerAprov { get; set; }
        public decimal PerTicket { get; set; }
        public decimal PerFluxo { get; set; }
        public decimal PerReceb { get; set; }
        public decimal PerEntrada { get; set; }
        public decimal PerAtend { get; set; }
        public decimal PerPherfil { get; set; }

        public decimal RealFatura { get; set; }
        public decimal RealFotog { get; set; }
        public decimal RealVend { get; set; }
        public decimal RealAprov { get; set; }
        public decimal RealTicket { get; set; }
        public decimal RealFluxo { get; set; }
        public decimal RealReceb { get; set; }
        public decimal RealEntrada { get; set; }
        public decimal RealAtend { get; set; }
        public decimal RealPherfil { get; set; }

        public decimal DifFatura { get; set; }
        public decimal DifFotog { get; set; }
        public decimal DifVend { get; set; }
        public decimal DifAprov { get; set; }
        public decimal DifTicket { get; set; }
        public decimal DifFluxo { get; set; }
        public decimal DifReceb { get; set; }
        public decimal DifEntrada { get; set; }
        public decimal DifAtend { get; set; }
        public decimal DifPherfil { get; set; }

        public decimal PendFatura { get; set; }
        public decimal PendFotog { get; set; }
        public decimal PendVend { get; set; }
        public decimal PendAprov { get; set; }
        public decimal PendTicket { get; set; }
        public decimal PendFluxo { get; set; }
        public decimal PendReceb { get; set; }
        public decimal PendEntrada { get; set; }
        public decimal PendAtend { get; set; }
        public decimal PendPherfil { get; set; }

        public decimal SitFatura { get; set; }
        public decimal SitFotog { get; set; }
        public decimal SitVend { get; set; }
        public decimal SitAprov { get; set; }
        public decimal SitTicket { get; set; }
        public decimal SitFluxo { get; set; }
        public decimal SitReceb { get; set; }
        public decimal SitEntrada { get; set; }
        public decimal SitAtend { get; set; }
        public decimal SitPherfil { get; set; }

        public decimal CorFatMeta { get; set; }
        public decimal CorFatMetaMin { get; set; }
        public decimal CorFatReal { get; set; }
        public decimal CorFatMediaDiaria { get; set; }
        public decimal CorFatPrevisto { get; set; }
        public decimal CorFatMedia100 { get; set; }
        public decimal CorFatMediaMin { get; set; }

        public decimal CorFotogMeta { get; set; }
        public decimal CorFotogMetaMin { get; set; }
        public decimal CorFotogReal { get; set; }
        public decimal CorFotogMediaDiaria { get; set; }
        public decimal CorFotogPrevisto { get; set; }
        public decimal CorFotogMedia100 { get; set; }
        public decimal CorFotogMediaMin { get; set; }

        public decimal CorFluxoMeta { get; set; }
        public decimal CorFluxoMetaMin { get; set; }
        public decimal CorFluxoReal { get; set; }
        public decimal CorFluxoMediaDiaria { get; set; }
        public decimal CorFluxoPrevisto { get; set; }
        public decimal CorFluxoMedia100 { get; set; }
        public decimal CorFluxoMediaMin { get; set; }

        public decimal CorEntradaMeta { get; set; }
        public decimal CorEntradaMetaMin { get; set; }
        public decimal CorEntradaReal { get; set; }
        public decimal CorEntradaMediaDiaria { get; set; }
        public decimal CorEntradaPrevisto { get; set; }
        public decimal CorEntradaMedia100 { get; set; }
        public decimal CorEntradaMediaMin { get; set; }

        #endregion

        #region CONSTRUTORES

        public PerfilOperacional() 
        {
            Produtividade = 0;
            
            MetaFotog = 0;
            MetaVend = 0;
            MetaAprov = 0;
            MetaFatura = 0;
            MetaFluxo = 0;
            MetaEntrada = 0;
            MetaReceb = 0;
            MetaTicket = 0;
            MetaAtend = 0;

            PerFatura = 0;
            PerFotog = 0;
            PerVend = 0;
            PerAprov = 0;
            PerTicket = 0;
            PerFluxo = 0;
            PerReceb = 0;
            PerEntrada = 0;
            PerAtend = 0;

            RealFatura = 0;
            RealFotog = 0;
            RealVend = 0;
            RealAprov = 0;
            RealTicket = 0;
            RealFluxo = 0;
            RealReceb = 0;
            RealEntrada = 0;
            RealAtend = 0;

            DifFatura = 0;
            DifFotog = 0;
            DifVend = 0;
            DifAprov = 0;
            DifTicket = 0;
            DifFluxo = 0;
            DifReceb = 0;
            DifEntrada = 0;
            DifAtend = 0;

            PendFatura = 0;
            PendFotog = 0;
            PendVend = 0;
            PendAprov = 0;
            PendTicket = 0;
            PendFluxo = 0;
            PendReceb = 0;
            PendEntrada = 0;
            PendAtend = 0;

            SitFatura = 0;
            SitFotog = 0;
            SitVend = 0;
            SitAprov = 0;
            SitTicket = 0;
            SitFluxo = 0;
            SitReceb = 0;
            SitEntrada = 0;
            SitAtend = 0;

            CorFatMeta = 0;
            CorFatMetaMin = 0;
            CorFatReal = 0;
            CorFatMediaDiaria = 0;
            CorFatPrevisto = 0;
            CorFatMedia100 = 0;
            CorFatMediaMin = 0;

            CorFotogMeta = 0;
            CorFotogMetaMin = 0;
            CorFotogReal = 0;
            CorFotogMediaDiaria = 0;
            CorFotogPrevisto = 0;
            CorFotogMedia100 = 0;
            CorFotogMediaMin = 0;

            CorFluxoMeta = 0;
            CorFluxoMetaMin = 0;
            CorFluxoReal = 0;
            CorFluxoMediaDiaria = 0;
            CorFluxoPrevisto = 0;
            CorFluxoMedia100 = 0;
            CorFluxoMediaMin = 0;

            CorEntradaMeta = 0;
            CorEntradaMetaMin = 0;
            CorEntradaReal = 0;
            CorEntradaMediaDiaria = 0;
            CorEntradaPrevisto = 0;
            CorEntradaMedia100 = 0;
            CorEntradaMediaMin = 0;
        }

        #endregion

        #region METODOS


        /// <summary>
        /// Executa o calculo do perfil operacional
        /// </summary>
        /// <param name="ano">Ano do periodo de meta</param>
        /// <param name="mes">Mes do periodo de meta</param>
        /// <param name="diaInicio">Dia inicial para calculo</param>
        /// <param name="diaFim">Dia final para o calculo</param>
        /// <param name="idFilial">Filial para calculo</param>
        /// <returns>Retorna Perfil Operacional do periodo</returns>
        public static PerfilOperacional CalculaPerfil(int ano, int mes, int diaInicio, int diaFim, int idFilial)
        {
            //inicializa as variaveis
            var perfil = new PerfilOperacional();
            var filial = Filiais.GetById(idFilial);
            var periodo = Periodo.GetPeriodo(ano, mes, idFilial);
            var lancamentos = new List<CPanel.Dados.lancamentos>();

            //executa o calculo
            if (periodo != null) 
            {
                //dados da filial
                perfil.IdFilial = filial.id_filial;
                perfil.Filial = filial.nome;
                perfil.Ano = ano;
                perfil.Mes = mes;

                //calcula as datas do perfil
                CalculaDatas(diaInicio, diaFim, perfil, periodo);

                //carrega o lancamento
                CarregaLancamentos(perfil, periodo, lancamentos);

                //calcula valores das metas
                CalculaMetas(perfil, periodo);

                //calcula metas do periodo
                CalculaMetasPeriodo(perfil, periodo, lancamentos);

                //calcula realizado no periodo
                CalculaRealizado(perfil, lancamentos);

                //calcula diferenca
                CalculaDiferenca(perfil);

                //calcula porcentagem
                CalculaPorcentagem(perfil);

                //calcula produtividade
                CalculaProdutividade(perfil);

                //calcula valores de correcao
                CalculaCorrecao(perfil);

                //calcula valores da Pherfil
                CalculaCobrancaPherfil(perfil);
            }
            
            //retorna o perfil operacional
            return perfil;
        }

        /// <summary>
        /// Calcula a média de uma lista de perfil operacional
        /// </summary>
        /// <param name="lista">Lista de prefil operacional</param>
        /// <returns>Perfil Operacional</returns>
        public static PerfilOperacional CalculaPerfilGeral(List<PerfilOperacional> lista, string nome) 
        {
            //inicializa as variaveis
            var perfil = new PerfilOperacional();
            perfil.Filial = nome;

            //loop na lista
            foreach (var item in lista)
            {
                //datas
                perfil.DiasMes += item.DiasMes;
                perfil.DiasTrab += item.DiasTrab;

                //meta geral
                perfil.MetaFotog += item.MetaFotog;
                perfil.MetaVend += item.MetaVend;
                perfil.MetaFatura += item.MetaFatura;
                perfil.MetaFluxo += item.MetaFluxo;
                perfil.MetaAprov += item.MetaAprov;
                perfil.MetaTicket += item.MetaTicket;
                perfil.MetaEntrada += item.MetaEntrada;
                perfil.MetaReceb += item.MetaReceb;
                perfil.MetaAtend += item.MetaAtend;
                perfil.MetaPherfil += item.MetaPherfil;

                //meta do periodo
                perfil.PerFotog += item.PerFotog;
                perfil.PerVend += item.PerVend;
                perfil.PerFatura += item.PerFatura;
                perfil.PerFluxo += item.PerFluxo;
                perfil.PerAprov += item.PerAprov;
                perfil.PerTicket += item.PerTicket;
                perfil.PerEntrada += item.PerEntrada;
                perfil.PerReceb += item.PerReceb;
                perfil.PerAtend += item.PerAtend;
                perfil.PerPherfil += item.PerPherfil;

                //realizado
                perfil.RealFotog += item.RealFotog;
                perfil.RealVend += item.RealVend;
                perfil.RealFatura += item.RealFatura;
                perfil.RealFluxo += item.RealFluxo;
                perfil.RealAprov += item.RealAprov;
                perfil.RealTicket += item.RealTicket;
                perfil.RealEntrada += item.RealEntrada;
                perfil.RealReceb += item.RealReceb;
                perfil.RealAtend += item.RealAtend;
                perfil.RealPherfil += item.RealPherfil;
            }

            //media de dias
            perfil.DiasMes = (int)Math.Ceiling((double)perfil.DiasMes / lista.Count);
            perfil.DiasTrab = (int)Math.Ceiling((double)perfil.DiasTrab / lista.Count);

            //ajusta valores de conversao e ticket
            perfil.MetaAprov = (perfil.MetaVend * 100) / perfil.MetaFotog;
            perfil.MetaTicket = perfil.MetaFatura / perfil.MetaVend;

            perfil.PerAprov = (perfil.PerVend * 100) / perfil.MetaFotog;
            perfil.PerTicket = perfil.PerFatura / perfil.PerVend;

            perfil.RealAprov = (perfil.RealVend * 100) / perfil.RealFotog;
            perfil.RealTicket = perfil.RealFatura / perfil.RealVend;

            //calcula a diferenca
            perfil.DifFotog = perfil.RealFotog - perfil.PerFotog;
            perfil.DifVend = perfil.RealVend - perfil.PerVend;
            perfil.DifFatura = perfil.RealFatura - perfil.PerFatura;
            perfil.DifFluxo = perfil.RealFluxo - perfil.PerFluxo;
            perfil.DifAprov = perfil.RealAprov - perfil.PerAprov;
            perfil.DifTicket = perfil.RealTicket - perfil.PerTicket;
            perfil.DifEntrada = perfil.RealEntrada - perfil.PerEntrada;
            perfil.DifReceb = perfil.RealReceb - perfil.PerReceb;
            perfil.DifAtend = perfil.RealAtend - perfil.PerAtend;
            perfil.DifPherfil = perfil.RealPherfil - perfil.PerPherfil;

            //calcula situacao da meta
            perfil.PendFotog = (perfil.RealFotog * 100) / perfil.MetaFotog;
            perfil.PendVend = (perfil.RealVend * 100) / perfil.MetaVend;
            perfil.PendFatura = (perfil.RealFatura * 100) / perfil.MetaFatura;
            perfil.PendFluxo = (perfil.RealFluxo * 100) / perfil.MetaFluxo;
            perfil.PendAprov = perfil.RealAprov - perfil.PerAprov;
            perfil.PendTicket = (perfil.RealTicket * 100) / perfil.MetaTicket;
            perfil.PendEntrada = (perfil.RealEntrada * 100) / perfil.MetaEntrada;
            perfil.PendReceb = (perfil.RealReceb * 100) / perfil.MetaReceb;
            perfil.PendAtend = (perfil.RealAtend * 100) / perfil.MetaAtend;
            perfil.PendPherfil = (perfil.RealPherfil * 100) / perfil.MetaPherfil;

            //calcula situacao do periodo
            perfil.SitFotog = (perfil.RealFotog * 100) / perfil.PerFotog;
            perfil.SitVend = (perfil.RealVend * 100) / perfil.PerVend;
            perfil.SitFatura = (perfil.RealFatura * 100) / perfil.PerFatura;
            perfil.SitFluxo = (perfil.RealFluxo * 100) / perfil.PerFluxo;
            perfil.SitAprov = perfil.RealFotog / perfil.PerAprov;
            perfil.SitTicket = ((perfil.RealTicket * 100) / perfil.PerTicket) - 100;
            perfil.SitEntrada = (perfil.RealEntrada * 100) / perfil.PerEntrada;
            perfil.SitReceb = (perfil.RealReceb * 100) / perfil.PerReceb;
            perfil.SitAtend = (perfil.RealAtend * 100) / perfil.PerAtend;
            perfil.SitPherfil = (perfil.RealPherfil * 100) / perfil.PerPherfil;

            //calcula produtividade
            CalculaProdutividade(perfil);

            //calcula correcao do perfil
            CalculaCorrecao(perfil);

            //retorna o perfil operacional
            return perfil;
        }

        /// <summary>
        /// Calcula das datas do perfil operacional
        /// </summary>
        /// <param name="diaInicio">Dia inicio da pesquisa</param>
        /// <param name="diaFim">Dia final da pesquisa</param>
        /// <param name="perfil">Perfil operacional a ser alterado</param>
        /// <param name="periodo">Periodo de meta da pesquisa</param>
        private static void CalculaDatas(int diaInicio, int diaFim, PerfilOperacional perfil, Dados.periodos periodo)
        {
            perfil.DiaInicio = Lancamento.GetDiaInicio(periodo.id_periodo, diaInicio);
            perfil.DiaFim = Lancamento.GetDiaFim(periodo.id_periodo, diaFim);
            perfil.DiasMes = periodo.dias.GetValueOrDefault();
            perfil.DiasTrab = Lancamento.GetDiasTrabalhados(periodo.id_periodo, diaInicio, diaFim);
        }

        /// <summary>
        /// Carrega lancamentos de um periodo
        /// </summary>
        /// <param name="perfil">Perfil operacional relativo</param>
        /// <param name="periodo">Periodo a ser consultado</param>
        /// <param name="lancamentos">Lista de lancamentos a ser carregada</param>
        private static void CarregaLancamentos(PerfilOperacional perfil, Dados.periodos periodo, List<Dados.lancamentos> lancamentos)
        {
            foreach (var item in Lancamento.GetByPeriodoDias(periodo.id_periodo, perfil.DiaInicio, perfil.DiaFim)) 
            {
                lancamentos.Add(item);
            }
        }

        /// <summary>
        /// Calcula valores das metas
        /// </summary>
        /// <param name="perfil">Perfil operacional a ser alterado</param>
        /// <param name="periodo">Periodo da pesquisa</param>
        private static void CalculaMetas(PerfilOperacional perfil, Dados.periodos periodo)
        {
            var objetivo = periodo.periodos_objetivos.FirstOrDefault();
            perfil.MetaFotog = objetivo.obj_fotografar.Value * perfil.DiasMes;
            perfil.MetaVend = (objetivo.obj_vender.Value * perfil.MetaFotog) / 100;
            if (perfil.MetaFotog > 0)
                perfil.MetaAprov = (perfil.MetaVend * 100) / perfil.MetaFotog;
            else
                perfil.MetaAprov = 0;
            perfil.MetaFatura = objetivo.meta_faturamento.GetValueOrDefault();
            perfil.MetaFluxo = objetivo.meta_fluxo.GetValueOrDefault();
            perfil.MetaTicket = objetivo.obj_preco_medio.GetValueOrDefault();
            perfil.MetaEntrada = objetivo.meta_entrada.GetValueOrDefault();
            perfil.MetaReceb = objetivo.meta_recebimento.GetValueOrDefault();
            perfil.MetaAtend = objetivo.obj_fotografar.Value * perfil.DiasMes;
        }

        /// <summary>
        /// Calcula metas do periodo
        /// </summary>
        /// <param name="perfil">Perfil operacional a ser preenchido</param>
        /// <param name="periodo">Periodo da pesquisa</param>
        private static void CalculaMetasPeriodo(PerfilOperacional perfil, Dados.periodos periodo, List<Dados.lancamentos> lancamentos)
        {
            //inicializa variaveis
            var objetivo = periodo.periodos_objetivos.FirstOrDefault();
            var semanas = periodo.periodos_semanas.ToList();
            decimal faturaPerc = 0;
            decimal fluxoPerc = 0;
            decimal entradaPerc = 0;
            decimal recebPerc = 0;

            //calcula periodo
            perfil.PerFotog = objetivo.obj_fotografar.GetValueOrDefault() * perfil.DiasTrab;
            perfil.PerVend = (objetivo.obj_vender.GetValueOrDefault() * perfil.PerFotog) / 100;
            if (perfil.PerFotog > 0)
                perfil.PerAprov = (perfil.PerVend * 100) / perfil.PerFotog;
            else
                perfil.PerAprov = 0;

            //loop nos lancamentos do periodo
            foreach (var lanc in lancamentos)
            {
                //pega a semana
                var semana = semanas.FirstOrDefault(a => a.id_periodo_semana == lanc.id_periodo_semana);

                //calcula percentuais
                if (semana != null)
                {
                    faturaPerc = faturaPerc + (semana.participacao.GetValueOrDefault() / semana.num_dias.GetValueOrDefault());
                    fluxoPerc = fluxoPerc + (semana.participacao_financ.GetValueOrDefault() / semana.num_dias.GetValueOrDefault());
                    entradaPerc = entradaPerc + (semana.participacao.GetValueOrDefault() / semana.num_dias.GetValueOrDefault());
                    recebPerc = recebPerc + (semana.participacao_financ.GetValueOrDefault() / semana.num_dias.GetValueOrDefault());
                }
            }

            //calcula periodo
            perfil.PerFatura = (perfil.MetaFatura * faturaPerc) / 100;
            perfil.PerFluxo = (perfil.MetaFluxo * fluxoPerc) / 100;
            perfil.PerEntrada = (perfil.MetaEntrada * entradaPerc) / 100;
            perfil.PerReceb = (perfil.MetaReceb * recebPerc) / 100;
            if (perfil.PerVend > 0)
                perfil.PerTicket = perfil.PerFatura / perfil.PerVend;
            else
                perfil.PerTicket = 0;
            perfil.PerAtend = objetivo.obj_fotografar.GetValueOrDefault() * perfil.DiasTrab;
        }

        /// <summary>
        /// Calcula valores realizado no periodo
        /// </summary>
        /// <param name="perfil">Perfil operacional a ser preenchido</param>
        /// <param name="lancamentos">Lançamentos do periodo</param>
        private static void CalculaRealizado(PerfilOperacional perfil, List<Dados.lancamentos> lancamentos)
        {
            //calcula valores
            foreach (var lanc in lancamentos)
            {
                perfil.RealFotog = perfil.RealFotog + lanc.fotografados.GetValueOrDefault();
                perfil.RealVend = perfil.RealVend + lanc.vendas.GetValueOrDefault();
                perfil.RealFatura = perfil.RealFatura + lanc.faturamento.GetValueOrDefault();
                perfil.RealFluxo = perfil.RealFluxo + lanc.fluxo_caixa.GetValueOrDefault();
                perfil.RealEntrada = perfil.RealEntrada + lanc.comissao.GetValueOrDefault();
                perfil.RealReceb = perfil.RealReceb + lanc.recebimento.GetValueOrDefault();
                perfil.RealAtend = perfil.RealAtend + lanc.atendidos.GetValueOrDefault();
            }

            if (perfil.RealFotog > 0)
                perfil.RealAprov = (100 * perfil.RealVend) / perfil.RealFotog;
            else
                perfil.RealAprov = 0;

            if (perfil.RealVend > 0)
                perfil.RealTicket = perfil.RealFatura / perfil.RealVend;
            else
                perfil.RealTicket = 0;

            //atualiza valor da meta do periodo de vendidos
            perfil.PerVend = perfil.RealAtend;
        }

        /// <summary>
        /// Calcula a diferença entre a meta e o realizado no periodo
        /// </summary>
        /// <param name="perfil">Perfil para atualizacao</param>
        private static void CalculaDiferenca(PerfilOperacional perfil)
        {
            perfil.DifFotog = perfil.RealFotog - perfil.PerFotog;
            perfil.DifVend = perfil.RealVend - perfil.RealAtend;
            perfil.DifFatura = perfil.RealFatura - perfil.PerFatura;
            perfil.DifFluxo = perfil.RealFluxo - perfil.PerFluxo;
            perfil.DifAprov = perfil.RealAprov - perfil.PerAprov;
            perfil.DifTicket = perfil.RealTicket - perfil.PerTicket;
            perfil.DifEntrada = perfil.RealEntrada - perfil.PerEntrada;
            perfil.DifReceb = perfil.RealReceb - perfil.PerReceb;
            perfil.DifAtend = perfil.RealAtend - perfil.PerAtend;
        }

        /// <summary>
        /// Calcula percentual do perfil operacional
        /// </summary>
        /// <param name="perfil">Perfil operacional a ser alterado</param>
        private static void CalculaPorcentagem(PerfilOperacional perfil)
        {
            perfil.PendFotog = perfil.MetaFotog > 0 ? (perfil.RealFotog * 100) / perfil.MetaFotog : 0;
            perfil.PendAprov = perfil.MetaAprov > 0 ? (perfil.RealAprov * 100) / perfil.MetaAprov : 0;
            perfil.PendFatura = perfil.MetaFatura > 0 ? (perfil.RealFatura * 100) / perfil.MetaFatura : 0;
            perfil.PendFluxo = perfil.MetaFluxo > 0 ? (perfil.RealFluxo * 100) / perfil.MetaFluxo : 0;
            perfil.PendVend = perfil.MetaVend > 0 ? (perfil.RealVend * 100) / perfil.MetaVend : 0;
            perfil.PendTicket = perfil.MetaTicket > 0 ? (perfil.RealTicket * 100) / perfil.MetaTicket : 0;
            perfil.PendEntrada = perfil.MetaEntrada > 0 ? (perfil.RealEntrada * 100) / perfil.MetaEntrada : 0;
            perfil.PendReceb = perfil.MetaReceb > 0 ? (perfil.RealReceb * 100) / perfil.MetaReceb : 0;
            perfil.PendAtend = perfil.MetaAtend > 0 ? (perfil.RealAtend * 100) / perfil.MetaAtend : 0;

            perfil.SitFotog = perfil.PerFotog > 0 ? (perfil.RealFotog * 100) / perfil.PerFotog : 0;
            perfil.SitAprov = perfil.PerAprov > 0 ? (perfil.RealAprov * 100) / perfil.PerAprov : 0;
            perfil.SitFatura = perfil.PerFatura > 0 ? (perfil.RealFatura * 100) / perfil.PerFatura : 0;
            perfil.SitFluxo = perfil.PerFluxo > 0 ? (perfil.RealFluxo * 100) / perfil.PerFluxo : 0;
            perfil.SitVend = perfil.PerVend > 0 ? (perfil.RealVend * 100) / perfil.PerVend : 0;
            perfil.SitTicket = perfil.PerTicket > 0 ? (perfil.RealTicket * 100) / perfil.PerTicket : 0;
            perfil.SitEntrada = perfil.PerEntrada > 0 ? (perfil.RealEntrada * 100) / perfil.PerEntrada : 0;
            perfil.SitReceb = perfil.PerReceb > 0 ? (perfil.RealReceb * 100) / perfil.PerReceb : 0;
            perfil.SitAtend = perfil.PerAtend > 0 ? (perfil.RealAtend * 100) / perfil.PerAtend : 0;
        }

        /// <summary>
        /// Calcula a produtividade do perfil
        /// </summary>
        /// <param name="perfil">Perfil operacional a ser alterado</param>
        private static void CalculaProdutividade(PerfilOperacional perfil)
        {
            //verifica faturamento
            if (decimal.Round(perfil.SitFatura, 1) < 80)
                perfil.Produtividade = 0;
            else
                perfil.Produtividade = decimal.Round(perfil.SitFatura, 0);

            //verifica entrada
            if (decimal.Round(perfil.SitEntrada, 1) < 100)
                perfil.Produtividade = 0;           
        }

        /// <summary>
        /// Calcula valores para corrigir o perfil
        /// </summary>
        /// <param name="perfil">Perfil operacional a ser alterado</param>
        private static void CalculaCorrecao(PerfilOperacional perfil)
        {
            var dias_restantes = perfil.DiasRestantes;

            if (perfil.DiasRestantes == 0) {
                dias_restantes = 1;
            }

            perfil.CorFatMeta = perfil.MetaFatura;
            perfil.CorFatMetaMin = (perfil.MetaFatura * 80) / 100;
            perfil.CorFatReal = perfil.RealFatura;
            perfil.CorFatMediaDiaria = decimal.Round(perfil.RealFatura / perfil.DiasTrab, 0);
            perfil.CorFatPrevisto = perfil.RealFatura + (perfil.CorFatMediaDiaria * dias_restantes);
            perfil.CorFatMedia100 = perfil.CorFatMeta - (perfil.RealFatura / dias_restantes);
            perfil.CorFatMediaMin = perfil.CorFatMetaMin - (perfil.RealFatura / dias_restantes);

            perfil.CorFotogMeta = perfil.MetaFotog;
            perfil.CorFotogMetaMin = (perfil.MetaFotog * 80) / 100;
            perfil.CorFotogReal = perfil.RealFotog;
            perfil.CorFotogMediaDiaria = decimal.Round(perfil.RealFotog / perfil.DiasTrab, 0);
            perfil.CorFotogPrevisto = perfil.RealFotog + (perfil.CorFotogMediaDiaria * dias_restantes);
            perfil.CorFotogMedia100 = perfil.CorFotogMeta - (perfil.RealFotog / dias_restantes);
            perfil.CorFotogMediaMin = perfil.CorFotogMetaMin - (perfil.RealFotog / dias_restantes);

            perfil.CorFluxoMeta = perfil.MetaFluxo;
            perfil.CorFluxoMetaMin = (perfil.MetaFluxo * 80) / 100;
            perfil.CorFluxoReal = perfil.RealFluxo;
            perfil.CorFluxoMediaDiaria = decimal.Round(perfil.RealFluxo / perfil.DiasTrab, 0);
            perfil.CorFluxoPrevisto = perfil.RealFluxo + (perfil.CorFluxoMediaDiaria * dias_restantes);
            perfil.CorFluxoMedia100 = perfil.CorFluxoMeta - (perfil.RealFluxo / dias_restantes);
            perfil.CorFluxoMediaMin = perfil.CorFluxoMetaMin - (perfil.RealFluxo / dias_restantes);

            perfil.CorEntradaMeta = perfil.MetaEntrada;
            perfil.CorEntradaMetaMin = (perfil.MetaEntrada * 80) / 100;
            perfil.CorEntradaReal = perfil.RealEntrada;
            perfil.CorEntradaMediaDiaria = decimal.Round(perfil.RealEntrada / perfil.DiasTrab, 0);
            perfil.CorEntradaPrevisto = perfil.RealEntrada + (perfil.CorEntradaMediaDiaria * dias_restantes);
            perfil.CorEntradaMedia100 = perfil.CorEntradaMeta - (perfil.RealEntrada / dias_restantes);
            perfil.CorEntradaMediaMin = perfil.CorEntradaMetaMin - (perfil.RealEntrada / dias_restantes);

        }

        /// <summary>
        /// Calcula valores de cobranca da Pherfil
        /// </summary>
        /// <param name="perfil"></param>
        private static void CalculaCobrancaPherfil(PerfilOperacional perfil)
        {
            var classe = "2.027";
            var status = new int[] { 0, 1 };
            var coligada = Lib.Filiais.GetById(perfil.IdFilial).rm_coligada.GetValueOrDefault();
            var filial = Lib.Filiais.GetById(perfil.IdFilial).rm_filial.GetValueOrDefault();
            var dataInicio = new DateTime(perfil.Ano, perfil.Mes, perfil.DiaInicio);
            var dataFim = new DateTime(perfil.Ano, perfil.Mes, perfil.DiaFim);

            using (var conn = new RM.Dados.CorporeEntities()) 
            {
                var meta = conn.FLAN.Where(a => a.CODCOLIGADA == coligada && a.CODFILIAL == filial && a.CODTB1FLX == classe && status.Contains(a.STATUSLAN) && a.PAGREC == 1 && a.DATAVENCIMENTO.Month == perfil.Mes && a.DATAVENCIMENTO.Year == perfil.Ano);
                var periodo = conn.FLAN.Where(a => a.CODCOLIGADA == coligada && a.CODFILIAL == filial && a.CODTB1FLX == classe && status.Contains(a.STATUSLAN) && a.PAGREC == 1 && a.DATAVENCIMENTO >= dataInicio && a.DATAVENCIMENTO <= dataFim);
                var realizado = conn.FLAN.Where(a => a.CODCOLIGADA == coligada && a.CODFILIAL == filial && a.CODTB1FLX == classe && a.STATUSLAN == 1 && a.PAGREC == 1 && a.DATABAIXA >= dataInicio && a.DATABAIXA <= dataFim);

                perfil.MetaPherfil = meta.Count() > 0 ? meta.Sum(a => a.VALORORIGINAL) : 0;
                perfil.PerPherfil = periodo.Count() > 0 ? periodo.Sum(a => a.VALORORIGINAL) : 0;
                perfil.RealPherfil = realizado.Count() > 0 ? realizado.Sum(a => a.VALORBAIXADO) : 0;
                perfil.PendPherfil = perfil.MetaPherfil > 0 ? (perfil.RealPherfil * 100) / perfil.MetaPherfil : 0;
                perfil.SitPherfil = perfil.PerPherfil > 0 ? (perfil.RealPherfil * 100) / perfil.PerPherfil : 0;
                perfil.DifPherfil = perfil.RealPherfil - perfil.PerPherfil;
            }
        }


        #endregion
    }
}
