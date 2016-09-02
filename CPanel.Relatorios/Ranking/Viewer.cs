using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPanel.Relatorios.Ranking
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public List<CPanel.Lib.PerfilOperacional> Perfil { get; set; }
        public string TipoRanking { get; set; }
        public bool ExibeValor { get; set; }
        public Model DsModel { get; set; }

        #endregion

        #region CONSTRUTORES

        public Viewer(List<CPanel.Lib.PerfilOperacional> pPerfil, string pTipoRanking, bool pExibeValor)
        {
            //incializa propriedades
            Perfil = pPerfil;
            TipoRanking = pTipoRanking;
            ExibeValor = pExibeValor;
            DsModel = new Model();
            
            //inicializa tela
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Viewer_Load(object sender, EventArgs e)
        {
            CarregaDados();
            CarregaRelatorio();
        }

        #endregion

        #region METODOS

        private void CarregaDados()
        {
            //inicializa variaveis
            var i = 1;

            //cria ranking
            var ranking = DsModel.Ranking.NewRankingRow();
            ranking.IdRanking = 1;
            ranking.Tipo = TipoRanking;
            ranking.Mes = Perfil.FirstOrDefault().Mes;
            ranking.Ano = Perfil.FirstOrDefault().Ano;
            ranking.DiaInicio = Perfil.FirstOrDefault().DiaInicio;
            ranking.DiaFim = Perfil.FirstOrDefault().DiaFim;

            //adiciona do dataset
            DsModel.Ranking.AddRankingRow(ranking);

            //cria ranking de faturamento
            i = 1;
            foreach (var item in Perfil.Where(a => a.MetaFatura > 0).OrderByDescending(a => a.SitFatura))
            {
                //configura objeto
                var fat = DsModel.Faturamento.NewFaturamentoRow();
                fat.IdFat = i;
                fat.IdRanking = ranking.IdRanking;
                fat.Filial = item.Filial;

                if (ExibeValor)
                {
                    fat.Meta = item.PerFatura;
                    fat.Realizado = item.RealFatura;
                }

                fat.Produtividade = item.SitFatura;

                //adiciona do dataset
                DsModel.Faturamento.AddFaturamentoRow(fat);
                
                //incrementa
                i++;
            }

            //cria ranking de fotografados
            i = 1;
            foreach (var item in Perfil.Where(a => a.MetaFotog > 0).OrderByDescending(a => a.SitFotog))
            {
                //configura objeto
                var fotog = DsModel.Fotografados.NewFotografadosRow();
                fotog.IdFotog = i;
                fotog.IdRanking = ranking.IdRanking;
                fotog.Filial = item.Filial;

                if (ExibeValor)
                {
                    fotog.Meta = item.PerFotog;
                    fotog.Realizado = item.RealFotog;
                }

                fotog.Produtividade = item.SitFotog;

                //adiciona do dataset
                DsModel.Fotografados.AddFotografadosRow(fotog);

                //incrementa
                i++;
            }

            //cria ranking de entradas
            i = 1;
            foreach (var item in Perfil.Where(a => a.MetaEntrada > 0).OrderByDescending(a => a.SitEntrada))
            {
                //configura objeto
                var entrada = DsModel.Entradas.NewEntradasRow();
                entrada.IdEntrada = i;
                entrada.IdRanking = ranking.IdRanking;
                entrada.Filial = item.Filial;

                if (ExibeValor)
                {
                    entrada.Meta = item.PerEntrada;
                    entrada.Realizado = item.RealEntrada;
                }

                entrada.Produtividade = item.SitEntrada;

                //adiciona do dataset
                DsModel.Entradas.AddEntradasRow(entrada);

                //incrementa
                i++;
            }

            //cria ranking do fluxo
            i = 1;
            foreach (var item in Perfil.Where(a => a.MetaFluxo > 0).OrderByDescending(a => a.SitFluxo))
            {
                //configura objeto
                var fluxo = DsModel.Fluxo.NewFluxoRow();
                fluxo.IdFluxo = i;
                fluxo.IdRanking = ranking.IdRanking;
                fluxo.Filial = item.Filial;

                if (ExibeValor)
                {
                    fluxo.Meta = item.PerFluxo;
                    fluxo.Realizado = item.RealFluxo;
                }

                fluxo.Produtividade = item.SitFluxo;

                //adiciona do dataset
                DsModel.Fluxo.AddFluxoRow(fluxo);

                //incrementa
                i++;
            }

            //cria ranking do recebimento
            i = 1;
            foreach (var item in Perfil.Where(a => a.MetaReceb > 0).OrderByDescending(a => a.SitReceb))
            {
                //configura objeto
                var receb = DsModel.Recebimento.NewRecebimentoRow();
                receb.IdReceb = i;
                receb.IdRanking = ranking.IdRanking;
                receb.Filial = item.Filial;

                if (ExibeValor) 
                {
                    receb.Meta = item.PerReceb;
                    receb.Realizado = item.RealReceb;
                }

                receb.Produtividade = item.SitReceb;

                //adiciona do dataset
                DsModel.Recebimento.AddRecebimentoRow(receb);

                //incrementa
                i++;
            }
        }

        private void CarregaRelatorio()
        {
            //configura o relatorio
            Relatorio report = new Relatorio();

            //carrega dados
            report.SetDataSource(DsModel);

            //carrega o report viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Zoom(100);
        }

        

        #endregion
    }
}
