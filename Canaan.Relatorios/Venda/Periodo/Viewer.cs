using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Venda.Periodo
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool Agrupado { get; set; }
        public List<Model> Lista { get; set; }
        public Lib.Venda LibVenda
        {
            get
            {
                return new Lib.Venda();
            }
        }
        public Dados.Filial Filial
        {
            get
            {
                return new Lib.Filial().GetById(Lib.Session.Instance.Contexto.IdFilial);
            }
        }
        public Lib.Session Session
        {
            get
            {
                return Lib.Session.Instance;
            }
        }

        #endregion

        #region CONSTRUTORES

        public Viewer(DateTime pDataInicio, DateTime pDataFim, bool pAgrupado)
        {
            this.DataInicio = pDataInicio;
            this.DataFim = pDataFim;
            this.Agrupado = pAgrupado;
            this.Lista = new List<Model>();

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

        private void CarregaDados()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var vendas = new List<Dados.Venda>();

                //faz a consulta
                vendas = conn.Pedido.OfType<Dados.Venda>()
                             .Where(a => a.Status == Dados.EnumStatusVenda.Faturado &&
                                         !a.IsDevolvida &&
                                         a.IdFilial == this.Filial.IdFilial &&
                                         DbFunctions.TruncateTime(a.DataVenda) >= this.DataInicio.Date &&
                                         DbFunctions.TruncateTime(a.DataVenda) <= this.DataFim.Date)
                             .OrderBy(a => a.DataVenda)
                             .ToList();

                //carrega a lista
                foreach (var venda in vendas)
                {
                    var produto = "";
                    foreach (var prod in venda.VendaItem)
                    {
                        produto += prod.Produto.Nome + Environment.NewLine;
                    }

                    var entrada = venda.Lancamento.FirstOrDefault(a => a.ClasseContabil == Dados.EnumClasseContabil.Entrada);
                    
                    var item = new Model();
                    item.IdVenda = venda.IdPedido;
                    item.CodigoReduzido = venda.Atendimento.CodigoReduzido;
                    item.Cliente = venda.CliFor.Nome;
                    item.Produtos = produto;
                    item.Vendedor = venda.Usuario.Nome;
                    item.Data = venda.Data.Date;
                    item.DataEntrada = entrada != null ? entrada.DataVencimento.ToShortDateString() : "";
                    item.ValorBruto = venda.ValorBruto.GetValueOrDefault();
                    item.ValorDesconto = venda.ValorDesconto.GetValueOrDefault();
                    item.ValorAcrescimo = venda.ValorAcrescimo.GetValueOrDefault();
                    item.ValorEntrada = entrada != null ? entrada.ValorLiquido : 0;
                    item.ValorLiquido = venda.ValorLiquido.GetValueOrDefault();
                    item.FormaPgto = venda.FormaPgto.Nome;
                    item.Logo = Session.LogoReport;

                    Lista.Add(item);
                }
            }

        }

        public void CarregaRelatorio()
        {
            //carrega dados do relatorio
            CarregaDados();

            //carrega o relatorio
            var report = new Relatorio();
            var txtData = (TextObject)report.ReportDefinition.Sections["Section2"].ReportObjects["txtData"];

            txtData.Text = string.Format("{0} - {1} / {2}", Filial.NomeFantasia, DataInicio.ToShortDateString(), DataFim.ToShortDateString());

            //carrega dados
            report.SetDataSource(Lista);

            //carrega o report viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Zoom(100);
        }

        #endregion
    }
}
