using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPanel.Lib
{
    public class Meta
    {
        #region PROPRIEDADES

        public int IdMeta { get; set; }
        public int IdFilial { get; set; }
        public string Studio { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public int Dias { get; set; }
        public decimal ObjFotografado { get; set; }
        public decimal ObjConversao { get; set; }
        public decimal ObjTicket { get; set; }
        public decimal ObjFaturamento { get; set; }
        public decimal ObjFluxo { get; set; }
        public decimal ObjEntrada { get; set; }
        public decimal ObjRecebimento { get; set; }
        public List<MetaFotografado> ResultFotografado { get; set; }
        public List<MetaFaturamento> ResultFaturamento { get; set; }
        public List<MetaEntrada> ResultEntrada { get; set; }
        public List<MetaFluxo> ResultFluxo { get; set; }
        public List<MetaRecebimento> ResultRecebimento { get; set; }

        #endregion

        #region CONSTRUTORES

        public Meta() 
        {
            IdMeta = 1;
            Studio = "Não Informado";
            ObjFotografado = 0;
            ObjConversao = 50;
            ObjTicket = 0;
            ObjFaturamento = 0;
            ObjFluxo = 0;
            ObjEntrada = 0;
            ObjRecebimento = 0;

            ResultFotografado = new List<MetaFotografado>();
            ResultFaturamento = new List<MetaFaturamento>();
            ResultEntrada = new List<MetaEntrada>();
            ResultFluxo = new List<MetaFluxo>();
            ResultRecebimento = new List<MetaRecebimento>();
        }

        #endregion

        #region METODOS

        public static Meta CalculaMeta(int ano, int mes, CPanel.Dados.filiais filial) 
        {
            //inicializa variaveis
            var meta = new Meta();
            var periodo = CPanel.Lib.Periodo.GetPeriodo(ano, mes, filial.id_filial);
            var objetivo = periodo.periodos_objetivos.FirstOrDefault();

            //calculo da meta
            meta.IdMeta = periodo.id_periodo;
            meta.IdFilial = filial.id_filial;
            meta.Studio = filial.nome;
            meta.Mes = mes;
            meta.Ano = ano;
            meta.Dias = periodo.dias.GetValueOrDefault();
            meta.ObjFotografado = objetivo.obj_fotografar.GetValueOrDefault();
            meta.ObjConversao = objetivo.obj_vender.GetValueOrDefault();
            meta.ObjTicket = objetivo.obj_preco_medio.GetValueOrDefault();
            meta.ObjFaturamento = objetivo.meta_faturamento.GetValueOrDefault();
            meta.ObjFluxo = objetivo.meta_fluxo.GetValueOrDefault();
            meta.ObjEntrada = objetivo.meta_entrada.GetValueOrDefault();
            meta.ObjRecebimento = objetivo.meta_recebimento.GetValueOrDefault();

            //calcula resultados
            CalculaFotografado(periodo, meta.ResultFotografado);
            CalculaFaturamento(periodo, meta.ResultFaturamento);
            CalculaEntrada(periodo, meta.ResultEntrada);
            CalculaFluxo(periodo, meta.ResultFluxo);
            CalculaRecebimento(periodo, meta.ResultRecebimento);

            //retorna meta
            return meta;
        }

        private static void CalculaFotografado(Dados.periodos periodo, List<MetaFotografado> lista)
        {
            //inicializa variaveis
            var i = 1;
            var semanas = periodo.periodos_semanas;
            var objetivo = periodo.periodos_objetivos.FirstOrDefault();
            

            //loop nas semanas
            foreach (var semana in semanas)
            {
                //variaveis
                var lancamentos = CPanel.Lib.Lancamento.GetByPeriodoDias(periodo.id_periodo, semana.data_inicio.GetValueOrDefault().Day, semana.data_fim.GetValueOrDefault().Day);
                
                //preenche dados da semana
                var metaFotog = new MetaFotografado();
                metaFotog.IdFotografado = i;
                metaFotog.IdMeta = periodo.id_periodo;
                metaFotog.DiaInicio = semana.data_inicio.GetValueOrDefault().Day;
                metaFotog.DiaFim = semana.data_fim.GetValueOrDefault().Day;
                metaFotog.MetaDiaria = objetivo.obj_fotografar.GetValueOrDefault();
                metaFotog.MetaSemana = objetivo.obj_fotografar.GetValueOrDefault() * semana.num_dias.GetValueOrDefault();
                metaFotog.Alcancado = lancamentos.Sum(a => a.fotografados.GetValueOrDefault());
                metaFotog.Produtividade = metaFotog.MetaSemana > 0 ? (metaFotog.Alcancado * 100) / metaFotog.MetaSemana : 0;

                //adiciona na lista
                lista.Add(metaFotog);

                //incrementa o contador
                i++;
            }
        }

        private static void CalculaFaturamento(Dados.periodos periodo, List<MetaFaturamento> lista)
        {
            //inicializa variaveis
            var i = 1;
            var semanas = periodo.periodos_semanas;
            var objetivo = periodo.periodos_objetivos.FirstOrDefault();

            //loop nas semanas
            foreach (var semana in semanas)
            {
                //variaveis
                var lancamentos = CPanel.Lib.Lancamento.GetByPeriodoDias(periodo.id_periodo, semana.data_inicio.GetValueOrDefault().Day, semana.data_fim.GetValueOrDefault().Day);

                //preenche dados da semana
                var metaFat = new MetaFaturamento();
                metaFat.IdFaturamento = i;
                metaFat.IdMeta = periodo.id_periodo;
                metaFat.DiaInicio = semana.data_inicio.GetValueOrDefault().Day;
                metaFat.DiaFim = semana.data_fim.GetValueOrDefault().Day;
                metaFat.Percentual = semana.participacao.GetValueOrDefault();
                metaFat.Meta = (objetivo.meta_faturamento.GetValueOrDefault() * metaFat.Percentual) / 100;               
                metaFat.Alcancado = lancamentos.Sum(a => a.faturamento.GetValueOrDefault());
                metaFat.Produtividade = metaFat.Meta > 0 ? (metaFat.Alcancado * 100) / metaFat.Meta : 0;

                //adiciona na lista
                lista.Add(metaFat);

                //incrementa o contador
                i++;
            }
        }

        private static void CalculaEntrada(Dados.periodos periodo, List<MetaEntrada> lista)
        {
            //inicializa variaveis
            var i = 1;
            var semanas = periodo.periodos_semanas;
            var objetivo = periodo.periodos_objetivos.FirstOrDefault();

            //loop nas semanas
            foreach (var semana in semanas)
            {
                //variaveis
                var lancamentos = CPanel.Lib.Lancamento.GetByPeriodoDias(periodo.id_periodo, semana.data_inicio.GetValueOrDefault().Day, semana.data_fim.GetValueOrDefault().Day);

                //preenche dados da semana
                var metaEntrada = new MetaEntrada();
                metaEntrada.IdEntrada = i;
                metaEntrada.IdMeta = periodo.id_periodo;
                metaEntrada.DiaInicio = semana.data_inicio.GetValueOrDefault().Day;
                metaEntrada.DiaFim = semana.data_fim.GetValueOrDefault().Day;
                metaEntrada.Percentual = semana.participacao.GetValueOrDefault();
                metaEntrada.Meta = (objetivo.meta_entrada.GetValueOrDefault() * metaEntrada.Percentual) / 100;
                metaEntrada.Alcancado = lancamentos.Sum(a => a.comissao.GetValueOrDefault());
                metaEntrada.Produtividade = metaEntrada.Meta > 0 ? (metaEntrada.Alcancado * 100) / metaEntrada.Meta : 0;

                //adiciona na lista
                lista.Add(metaEntrada);

                //incrementa o contador
                i++;
            }
        }

        private static void CalculaFluxo(Dados.periodos periodo, List<MetaFluxo> lista)
        {
            //inicializa variaveis
            var i = 1;
            var semanas = periodo.periodos_semanas;
            var objetivo = periodo.periodos_objetivos.FirstOrDefault();

            //loop nas semanas
            foreach (var semana in semanas)
            {
                //variaveis
                var lancamentos = CPanel.Lib.Lancamento.GetByPeriodoDias(periodo.id_periodo, semana.data_inicio.GetValueOrDefault().Day, semana.data_fim.GetValueOrDefault().Day);

                //preenche dados da semana
                var metaFluxo = new MetaFluxo();
                metaFluxo.IdFluxo = i;
                metaFluxo.IdMeta = periodo.id_periodo;
                metaFluxo.DiaInicio = semana.data_inicio.GetValueOrDefault().Day;
                metaFluxo.DiaFim = semana.data_fim.GetValueOrDefault().Day;
                metaFluxo.Percentual = semana.participacao_financ.GetValueOrDefault();
                metaFluxo.Meta = (objetivo.meta_fluxo.GetValueOrDefault() * metaFluxo.Percentual) / 100;
                metaFluxo.Alcancado = lancamentos.Sum(a => a.fluxo_caixa.GetValueOrDefault());
                metaFluxo.Produtividade = metaFluxo.Meta > 0 ? (metaFluxo.Alcancado * 100) / metaFluxo.Meta : 0;

                //adiciona na lista
                lista.Add(metaFluxo);

                //incrementa o contador
                i++;
            }
        }

        private static void CalculaRecebimento(Dados.periodos periodo, List<MetaRecebimento> lista)
        {
            //inicializa variaveis
            var i = 1;
            var semanas = periodo.periodos_semanas;
            var objetivo = periodo.periodos_objetivos.FirstOrDefault();

            //loop nas semanas
            foreach (var semana in semanas)
            {
                //variaveis
                var lancamentos = CPanel.Lib.Lancamento.GetByPeriodoDias(periodo.id_periodo, semana.data_inicio.GetValueOrDefault().Day, semana.data_fim.GetValueOrDefault().Day);

                //preenche dados da semana
                var metaReceb = new MetaRecebimento();
                metaReceb.IdRecebimento = i;
                metaReceb.IdMeta = periodo.id_periodo;
                metaReceb.DiaInicio = semana.data_inicio.GetValueOrDefault().Day;
                metaReceb.DiaFim = semana.data_fim.GetValueOrDefault().Day;
                metaReceb.Percentual = semana.participacao_financ.GetValueOrDefault();
                metaReceb.Meta = (objetivo.meta_recebimento.GetValueOrDefault() * metaReceb.Percentual) / 100;
                metaReceb.Alcancado = lancamentos.Sum(a => a.recebimento.GetValueOrDefault());
                metaReceb.Produtividade = metaReceb.Meta > 0 ? (metaReceb.Alcancado * 100) / metaReceb.Meta : 0;

                //adiciona na lista
                lista.Add(metaReceb);

                //incrementa o contador
                i++;
            }
        }

        
        public static Meta CalculaMetaGeral(int ano, int mes, List<CPanel.Dados.filiais> filiais, string nome) 
        {
            //inicializa variaveis
            var metas = new List<Meta>();

            //loop nas filiais
            foreach (var filial in filiais)
            {
                metas.Add(CalculaMeta(ano, mes, filial));
            }

            //calcula meta global
            var metaGlobal = new Meta();
            metaGlobal.IdMeta = 1;
            metaGlobal.IdFilial = 0;
            metaGlobal.Studio = nome;
            metaGlobal.Mes = mes;
            metaGlobal.Ano = ano;
            metaGlobal.Dias = metas.Count > 0 ? metas.Sum(a => a.Dias) / metas.Count : 0;
            metaGlobal.ObjFotografado = metas.Sum(a => a.ObjFotografado);
            metaGlobal.ObjConversao = metas.Sum(a => a.ObjConversao);
            metaGlobal.ObjTicket = metas.Count > 0 ? metas.Sum(a => a.ObjTicket) / metas.Count : 0;
            metaGlobal.ObjFaturamento = metas.Sum(a => a.ObjFaturamento);
            metaGlobal.ObjFluxo = metas.Sum(a => a.ObjFluxo);
            metaGlobal.ObjEntrada = metas.Sum(a => a.ObjEntrada);
            metaGlobal.ObjRecebimento = metas.Sum(a => a.ObjRecebimento);
            
            //calcula os resultados
            CalculaMetaGeral_Fotografado(metas, metaGlobal);
            CalculaMetaGeral_Faturamento(metas, metaGlobal);
            CalculaMetaGeral_Entrada(metas, metaGlobal);
            CalculaMetaGeral_Fluxo(metas, metaGlobal);
            CalculaMetaGeral_Recebimento(metas, metaGlobal);

            //retorna
            return metaGlobal;
        }

        private static void CalculaMetaGeral_Fotografado(List<Meta> metas, Meta metaGlobal)
        {
            for (int i = 1; i <= 4; i++)
            {
                //seleciona somente itens da semana
                var lista = metas.GroupBy(a => a.ResultFotografado).Select(a => a.Key[i - 1]);

                //configura item global
                var fotogResult = new MetaFotografado();
                fotogResult.IdFotografado = i;
                fotogResult.IdMeta = metaGlobal.IdMeta;
                fotogResult.DiaInicio = lista.Count() > 0 ? lista.Sum(a => a.DiaInicio) / lista.Count() : 0;
                fotogResult.DiaFim = lista.Count() > 0 ? lista.Sum(a => a.DiaFim) / lista.Count() : 0;
                fotogResult.MetaDiaria = lista.Sum(a => a.MetaDiaria);
                fotogResult.MetaSemana = lista.Sum(a => a.MetaSemana);
                fotogResult.Alcancado = lista.Sum(a => a.Alcancado);
                fotogResult.Produtividade = fotogResult.MetaSemana > 0 ? (fotogResult.Alcancado * 100) / fotogResult.MetaSemana : 0;

                //adiciona na lista
                metaGlobal.ResultFotografado.Add(fotogResult);
            }

        }

        private static void CalculaMetaGeral_Faturamento(List<Meta> metas, Meta metaGlobal)
        {
            for (int i = 1; i <= 4; i++)
            {
                //seleciona somente itens da semana
                var lista = metas.GroupBy(a => a.ResultFaturamento).Select(a => a.Key[i - 1]);

                //configura item global
                var fatResult = new MetaFaturamento();
                fatResult.IdFaturamento = i;
                fatResult.IdMeta = metaGlobal.IdMeta;
                fatResult.DiaInicio = lista.Count() > 0 ? lista.Sum(a => a.DiaInicio) / lista.Count() : 0;
                fatResult.DiaFim = lista.Count() > 0 ? lista.Sum(a => a.DiaFim) / lista.Count() : 0;
                fatResult.Percentual = lista.Count() > 0 ? lista.Sum(a => a.Percentual) / lista.Count() : 0;
                fatResult.Meta = lista.Sum(a => a.Meta);
                fatResult.Alcancado = lista.Sum(a => a.Alcancado);
                fatResult.Produtividade = fatResult.Meta > 0 ? (fatResult.Alcancado * 100) / fatResult.Meta : 0;

                //adiciona na lista
                metaGlobal.ResultFaturamento.Add(fatResult);

            }
        }

        private static void CalculaMetaGeral_Entrada(List<Meta> metas, Meta metaGlobal)
        {
            for (int i = 1; i <= 4; i++)
            {
                //seleciona somente itens da semana
                var lista = metas.GroupBy(a => a.ResultEntrada).Select(a => a.Key[i - 1]);

                //configura item global
                var entradaResult = new MetaEntrada();
                entradaResult.IdEntrada = i;
                entradaResult.IdMeta = metaGlobal.IdMeta;
                entradaResult.DiaInicio = lista.Count() > 0 ? lista.Sum(a => a.DiaInicio) / lista.Count() : 0;
                entradaResult.DiaFim = lista.Count() > 0 ? lista.Sum(a => a.DiaFim) / lista.Count() : 0;
                entradaResult.Percentual = lista.Count() > 0 ? lista.Sum(a => a.Percentual) / lista.Count() : 0;
                entradaResult.Meta = lista.Sum(a => a.Meta);
                entradaResult.Alcancado = lista.Sum(a => a.Alcancado);
                entradaResult.Produtividade = entradaResult.Meta > 0 ? (entradaResult.Alcancado * 100) / entradaResult.Meta : 0;

                //adiciona na lista
                metaGlobal.ResultEntrada.Add(entradaResult);
            }
        }

        private static void CalculaMetaGeral_Fluxo(List<Meta> metas, Meta metaGlobal)
        {
            for (int i = 1; i <= 4; i++)
            {
                //seleciona somente itens da semana
                var lista = metas.GroupBy(a => a.ResultFluxo).Select(a => a.Key[i - 1]);

                //configura item global
                var fluxoResult = new MetaFluxo();
                fluxoResult.IdFluxo = i;
                fluxoResult.IdMeta = metaGlobal.IdMeta;
                fluxoResult.DiaInicio = lista.Count() > 0 ? lista.Sum(a => a.DiaInicio) / lista.Count() : 0;
                fluxoResult.DiaFim = lista.Count() > 0 ? lista.Sum(a => a.DiaFim) / lista.Count() : 0;
                fluxoResult.Percentual = lista.Count() > 0 ? lista.Sum(a => a.Percentual) / lista.Count() : 0;
                fluxoResult.Meta = lista.Sum(a => a.Meta);
                fluxoResult.Alcancado = lista.Sum(a => a.Alcancado);
                fluxoResult.Produtividade = fluxoResult.Meta > 0 ? (fluxoResult.Alcancado * 100) / fluxoResult.Meta : 0;

                //adiciona na lista
                metaGlobal.ResultFluxo.Add(fluxoResult);
            }
        }

        private static void CalculaMetaGeral_Recebimento(List<Meta> metas, Meta metaGlobal)
        {
            for (int i = 1; i <= 4; i++)
            {
                //seleciona somente itens da semana
                var lista = metas.GroupBy(a => a.ResultRecebimento).Select(a => a.Key[i - 1]);

                //configura item global
                var recebResult = new MetaRecebimento();
                recebResult.IdRecebimento = i;
                recebResult.IdMeta = metaGlobal.IdMeta;
                recebResult.DiaInicio = lista.Count() > 0 ? lista.Sum(a => a.DiaInicio) / lista.Count() : 0;
                recebResult.DiaFim = lista.Count() > 0 ? lista.Sum(a => a.DiaFim) / lista.Count() : 0;
                recebResult.Percentual = lista.Count() > 0 ? lista.Sum(a => a.Percentual) / lista.Count() : 0;
                recebResult.Meta = lista.Sum(a => a.Meta);
                recebResult.Alcancado = lista.Sum(a => a.Alcancado);
                recebResult.Produtividade = recebResult.Meta > 0 ? (recebResult.Alcancado * 100) / recebResult.Meta : 0;

                //adiciona na lista
                metaGlobal.ResultRecebimento.Add(recebResult);
            }
        }

        #endregion
    }

    /// <summary>
    /// Meta semanal de Fotografados
    /// </summary>
    public class MetaFotografado
    {
        #region PROPRIEDADES

        public int IdFotografado { get; set; }
        public int IdMeta { get; set; }
        public int DiaInicio { get; set; }
        public int DiaFim { get; set; }
        public decimal MetaDiaria { get; set; }
        public decimal MetaSemana { get; set; }
        public decimal Alcancado { get; set; }
        public decimal Produtividade { get; set; }

        #endregion
    }

    /// <summary>
    /// Meta semanal de faturamento
    /// </summary>
    public class MetaFaturamento
    {
        #region PROPRIEDADES

        public int IdFaturamento { get; set; }
        public int IdMeta { get; set; }
        public int DiaInicio { get; set; }
        public int DiaFim { get; set; }
        public decimal Meta { get; set; }
        public decimal Percentual { get; set; }
        public decimal Alcancado { get; set; }
        public decimal Produtividade { get; set; }

        #endregion
    }

    /// <summary>
    /// Meta semanal de entrada
    /// </summary>
    public class MetaEntrada
    {
        #region PROPRIEDADES

        public int IdEntrada { get; set; }
        public int IdMeta { get; set; }
        public int DiaInicio { get; set; }
        public int DiaFim { get; set; }
        public decimal Meta { get; set; }
        public decimal Percentual { get; set; }
        public decimal Alcancado { get; set; }
        public decimal Produtividade { get; set; }

        #endregion
    }

    public class MetaFluxo
    {
        #region PROPRIEDADES

        public int IdFluxo { get; set; }
        public int IdMeta { get; set; }
        public int DiaInicio { get; set; }
        public int DiaFim { get; set; }
        public decimal Meta { get; set; }
        public decimal Percentual { get; set; }
        public decimal Alcancado { get; set; }
        public decimal Produtividade { get; set; }

        #endregion
    }

    public class MetaRecebimento
    {
        #region PRPRIEDADES

        public int IdRecebimento { get; set; }
        public int IdMeta { get; set; }
        public int DiaInicio { get; set; }
        public int DiaFim { get; set; }
        public decimal Meta { get; set; }
        public decimal Percentual { get; set; }
        public decimal Alcancado { get; set; }
        public decimal Produtividade { get; set; }

        #endregion
    }
}
