using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Venda.Liberacao
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public List<Model> Lista { get; set; }
        public TipoRelatorio Tipo { get; set; }
        public Lib.Venda LibVenda { get; set; }
        public Lib.Session Session
        {
            get
            {
                return Lib.Session.Instance;
            }
        }

        #endregion

        #region CONSTRUTOR

        public Viewer(TipoRelatorio pTipo)
        {
            this.Tipo = pTipo;
            this.Lista = new List<Model>();
            this.LibVenda = new Lib.Venda();

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Viewer_Load(object sender, EventArgs e)
        {
            CarregaRelatorio();
        }

        #endregion

        #region METODOS

        public void CarregaDados() 
        {
            switch (this.Tipo)
            {
                case TipoRelatorio.Gerencial:
                    CarregaGerencial();
                    break;
                case TipoRelatorio.Escritorio:
                    CarregaEscritorio();
                    break;
                case TipoRelatorio.Programada:
                    CarregaProgramada();
                    break;
                default:
                    CarregaGerencial();
                    break;
            }
        }

        public void CarregaGerencial() 
        {
            var vendas = LibVenda.GetVendasConfirmacoes(Session.Contexto.IdFilial);

            foreach (var item in vendas)
            {
                Lista.Add(new Model
                {
                    CodigoReduzido = item.Atendimento.CodigoReduzido,
                    Cliente = item.CliFor.Nome,
                    Data = item.DataVenda.GetValueOrDefault(),
                    Valor = item.ValorLiquido.GetValueOrDefault()
                });
            }
        }

        public void CarregaEscritorio()
        {
            var vendas = LibVenda.GetVendasLiberacaoFilial(Session.Contexto.IdFilial);

            foreach (var item in vendas)
            {
                Lista.Add(new Model
                {
                    CodigoReduzido = item.Atendimento.CodigoReduzido,
                    Cliente = item.CliFor.Nome,
                    Data = item.DataVenda.GetValueOrDefault(),
                    Valor = item.ValorLiquido.GetValueOrDefault()
                });
            }
        }

        public void CarregaProgramada()
        {
            var vendas = LibVenda.GetProgramadasLiberacaoFilial(Session.Contexto.IdFilial);

            foreach (var item in vendas)
            {
                Lista.Add(new Model
                {
                    CodigoReduzido = item.Atendimento.CodigoReduzido,
                    Cliente = item.CliFor.Nome,
                    Data = item.DataVenda.GetValueOrDefault(),
                    Valor = item.ValorLiquido.GetValueOrDefault()
                });
            }
        }

        public string GetTitle() 
        {
            var msg = "";

            switch (this.Tipo)
            {
                case TipoRelatorio.Gerencial:
                    msg = "Pendencias de Liberação Gerencial";
                    break;
                case TipoRelatorio.Escritorio:
                    msg = "Pendencias de Liberação Escritório";
                    break;
                case TipoRelatorio.Programada:
                    msg = "Programadas para Liberação";
                    break;
                default:
                    msg = "Pendencias de Liberação Gerencial";
                    break;
            }

            return msg;
        }

        public void CarregaRelatorio() 
        { 
            //carrega dados do relatorio
            CarregaDados();

            //carrega o relatorio
            var report = new Relatorio();
            var filial = new Lib.Filial().GetById(Lib.Session.Instance.Contexto.IdFilial);
            var txtTitle = (TextObject)report.ReportDefinition.Sections["Section2"].ReportObjects["txtTitle"];
            var txtData = (TextObject)report.ReportDefinition.Sections["Section2"].ReportObjects["txtData"];

            txtTitle.Text = GetTitle();
            txtData.Text = string.Format("{0} - {1}", filial.NomeFantasia, DateTime.Now.ToShortDateString());

            //carrega dados
            report.SetDataSource(Lista);

            //carrega o report viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Zoom(100);
        }

        #endregion
    }
}
