using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPanel.Relatorios.Meta
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public List<CPanel.Lib.Meta> Meta { get; set; }
        public Model DsModel { get; set; }

        #endregion

        #region CONSTRUTORES

        public Viewer(List<CPanel.Lib.Meta> pMeta)
        {
            //inicializa propriedades
            Meta = pMeta;
            DsModel = new Model();

            //inicializa a tela
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Viewer_Load(object sender, EventArgs e)
        {
            CarregaDados();
            CarregaRelatorios();
        }

        #endregion

        #region METODOS

        private void CarregaDados()
        {
            foreach (var item in Meta)
            {
                CarregaMeta(item);
                CarregaFotografado(item);
                CarregaFaturamento(item);
                CarregaEntrada(item);
                CarregaFluxo(item);
                CarregaRecebimento(item);
            }
        }

        private void CarregaMeta(Lib.Meta item)
        {
            //carrega informacoes basicas da meta
            var meta = DsModel.Meta.NewMetaRow();
            meta.IdMeta = item.IdMeta;
            meta.Studio = item.Studio;
            meta.Mes = item.Mes;
            meta.Ano = item.Ano;
            meta.Dias = item.Dias;
            meta.Fotografado = item.ObjFotografado;
            meta.Conversao = item.ObjConversao;
            meta.Ticket = item.ObjTicket;
            meta.Faturamento = item.ObjFaturamento;
            meta.Fluxo = item.ObjFluxo;
            meta.Entrada = item.ObjEntrada;
            meta.Recebimento = item.ObjRecebimento;

            //adiciona no dataset
            DsModel.Meta.AddMetaRow(meta);
        }

        private void CarregaFotografado(Lib.Meta item)
        {
            //loop nas semanas
            foreach (var fotog in item.ResultFotografado)
            {
                //carrega informacoes da semana
                var result = DsModel.Fotografado.NewFotografadoRow();
                result.IdFotografado = fotog.IdFotografado;
                result.IdMeta = fotog.IdMeta;
                result.DiaInicio = fotog.DiaInicio;
                result.DiaFim = fotog.DiaFim;
                result.MetaDiaria = fotog.MetaDiaria;
                result.MetaSemana = fotog.MetaSemana;
                result.Alcancado = fotog.Alcancado;
                result.Produtividade = fotog.Produtividade;

                //adiciona no dataset
                DsModel.Fotografado.AddFotografadoRow(result);
            }
        }

        private void CarregaFaturamento(Lib.Meta item)
        {
            //loop nas semanas
            foreach (var fat in item.ResultFaturamento)
            {
                //carrega informacoes da semana
                var result = DsModel.Faturamento.NewFaturamentoRow();
                result.IdFaturamento = fat.IdFaturamento;
                result.IdMeta = fat.IdMeta;
                result.DiaInicio = fat.DiaInicio;
                result.DiaFim = fat.DiaFim;
                result.Meta = fat.Meta;
                result.Percentual = fat.Percentual;
                result.Alcancado = fat.Alcancado;
                result.Produtividade = fat.Produtividade;

                //adiciona no dataset
                DsModel.Faturamento.AddFaturamentoRow(result);
            }
        }

        private void CarregaEntrada(Lib.Meta item)
        {
            //loop nas semanas
            foreach (var ent in item.ResultEntrada)
            {
                //carrega informacoes da semana
                var result = DsModel.Entrada.NewEntradaRow();
                result.IdEntrada = ent.IdEntrada;
                result.IdMeta = ent.IdMeta;
                result.DiaInicio = ent.DiaInicio;
                result.DiaFim = ent.DiaFim;
                result.Meta = ent.Meta;
                result.Percentual = ent.Percentual;
                result.Alcancado = ent.Alcancado;
                result.Produtividade = ent.Produtividade;

                //adiciona no dataset
                DsModel.Entrada.AddEntradaRow(result);
            }
        }

        private void CarregaFluxo(Lib.Meta item)
        {
            //loop nas semanas
            foreach (var fluxo in item.ResultFluxo)
            {
                //carrega informacoes da semana
                var result = DsModel.Fluxo.NewFluxoRow();
                result.IdFluxo = fluxo.IdFluxo;
                result.IdMeta = fluxo.IdMeta;
                result.DiaInicio = fluxo.DiaInicio;
                result.DiaFim = fluxo.DiaFim;
                result.Meta = fluxo.Meta;
                result.Percentual = fluxo.Percentual;
                result.Alcancado = fluxo.Alcancado;
                result.Produtividade = fluxo.Produtividade;

                //adiciona no dataset
                DsModel.Fluxo.AddFluxoRow(result);
            }
        }

        private void CarregaRecebimento(Lib.Meta item)
        {
            //loop nas semanas
            foreach (var receb in item.ResultRecebimento)
            {
                //carrega informacoes da semana
                var result = DsModel.Recebimento.NewRecebimentoRow();
                result.IdRecebimento = receb.IdRecebimento;
                result.IdMeta = receb.IdMeta;
                result.DiaInicio = receb.DiaInicio;
                result.DiaFim = receb.DiaFim;
                result.Meta = receb.Meta;
                result.Percentual = receb.Percentual;
                result.Alcancado = receb.Alcancado;
                result.Produtividade = receb.Produtividade;

                //adiciona no dataset
                DsModel.Recebimento.AddRecebimentoRow(result);
            }
        }

        private void CarregaRelatorios()
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
