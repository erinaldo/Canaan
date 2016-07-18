using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib.Utilitarios;
using CrystalDecisions.CrystalReports.Engine;

namespace Canaan.Relatorios.Venda.Produtos
{
    public partial class Viewer : Base.Viewer
    {
        private readonly ModelFiltro _filtro;

        private readonly List<Model> _produtos;

        private Viewer()
        {
            InitializeComponent();
        }

        public Viewer(ModelFiltro filtro)
            : this()
        {
            _filtro = filtro;
            _produtos = new List<Model>();

        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            CarregaDataSet();
            CarregaRelatorio();
        }

        private void CarregaRelatorio()
        {
            try
            {
                //configura o relatorio
                var report = new Relatorio();

                var txt = (TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["txtRelatorio"];
                txt.Text = _filtro.TipoRelatorio.ToString();

                //carrega dados
                report.SetDataSource(_produtos.OrderByDescending(a => a.Total).ToList());

                //carrega o report viewer
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Zoom(100);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void CarregaDataSet()
        {
            if (_filtro.Todos)
            {
                switch (_filtro.TipoRelatorio)
                {
                    case TipoRelatorio.Todas:
                        CarregaDadosTodos(TipoRelatorio.Todas);
                        break;
                    case TipoRelatorio.Devolvidas:
                        CarregaDadosTodos(TipoRelatorio.Devolvidas);
                        break;
                    case TipoRelatorio.Liberadas:
                        CarregaDadosTodos(TipoRelatorio.Liberadas);
                        break;
                    case TipoRelatorio.Programadas:
                        CarregaDadosTodos(TipoRelatorio.Programadas);
                        break;
                }
            }
            else
            {
                switch (_filtro.TipoRelatorio)
                {
                    case TipoRelatorio.Todas:
                        CarregaDadosEspecifico(TipoRelatorio.Todas);
                        break;
                    case TipoRelatorio.Devolvidas:
                        CarregaDadosEspecifico(TipoRelatorio.Devolvidas);
                        break;
                    case TipoRelatorio.Liberadas:
                        CarregaDadosEspecifico(TipoRelatorio.Liberadas);
                        break;
                    case TipoRelatorio.Programadas:
                        CarregaDadosEspecifico(TipoRelatorio.Programadas);
                        break;
                }
            }
        }

        private void CarregaDadosEspecifico(TipoRelatorio tipoRelatorio)
        {
            _produtos.Add(new Model
            {
                IdProduto = _filtro.Produto.IdProduto,
                Nome = _filtro.Produto.Nome,
                Total = GetTotalProd(_filtro.Produto.Nome, _filtro.TipoRelatorio),
                Logo = Utilitarios.Comum.GetLogoReport()
            });
        }

        private void CarregaDadosTodos(TipoRelatorio tipoRelatorio)
        {
            foreach (var produto in _filtro.Produtos)
            {
                _produtos.Add(new Model
                {
                    IdProduto = produto.IdProduto,
                    Nome = produto.Nome,
                    Total = GetTotalProd(produto.Nome, tipoRelatorio),
                    Quantidade = GetQtdade(produto.Nome, tipoRelatorio),
                    Logo = Utilitarios.Comum.GetLogoReport()
                });
            }
        }

        private int GetQtdade(string prod, TipoRelatorio tipo)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var result = conn.VendaItem.Where(a => a.Venda.DataVenda >= _filtro.DataInicial && a.Venda.DataVenda <= _filtro.DataFinal && a.Produto.Nome == prod);

                switch (tipo)
                {
                    case TipoRelatorio.Devolvidas:
                        result = result.Where(a => a.Venda.Status == EnumStatusVenda.Devolvido);
                        break;
                    case TipoRelatorio.Liberadas:
                        result = result.Where(a => a.Venda.IsLiberado == true);
                        break;
                    case TipoRelatorio.Programadas:
                        result = result.Where(a => a.Venda.Status == EnumStatusVenda.Programada);
                        break;
                }

                return result.Count();
            }
        }

        private decimal GetTotalProd(string prod, TipoRelatorio tipo)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var result = conn.VendaItem.Where(a => a.Venda.DataVenda >= _filtro.DataInicial && a.Venda.DataVenda <= _filtro.DataFinal && a.Produto.Nome == prod);

                switch (tipo)
                {
                    case TipoRelatorio.Devolvidas:
                        result = result.Where(a => a.Venda.Status == EnumStatusVenda.Devolvido);
                        break;
                    case TipoRelatorio.Liberadas:
                        result = result.Where(a => a.Venda.IsLiberado == true);
                        break;
                    case TipoRelatorio.Programadas:
                        result = result.Where(a => a.Venda.Status == EnumStatusVenda.Programada);
                        break;
                }

                return result.Sum(a => a.ValorTotal) ?? 0.0m;
            }
        }
    }
}
