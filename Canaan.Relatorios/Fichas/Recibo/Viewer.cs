using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Fichas.Recibo
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public int IdPedido { get; set; }
        public Model Dataset { get; set; }

        #endregion

        #region CONSTRUTORES

        public Viewer(int idPedido)
        {
            this.IdPedido = idPedido;
            this.Dataset = new Model();

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
            //recupera dados do banco
            using (var conn = new Dados.CanaanModelContainer())
            {
                var venda = conn.Pedido.OfType<Dados.Venda>().FirstOrDefault(a => a.IdPedido == this.IdPedido);

                if (venda != null)
                {
                    //venda
                    var rowVenda = Dataset.Venda.NewVendaRow();
                    rowVenda.IdVenda = venda.IdPedido;
                    rowVenda.DataVenda = venda.DataVenda.GetValueOrDefault();
                    rowVenda.Cliente = venda.CliFor.Nome;
                    rowVenda.Documento = Lib.Utilitarios.Comum.FormataCpf(venda.CliFor.Documento);
                    rowVenda.Endereco = string.Format("{0}, {1} {2} - {3}", venda.CliFor.Endereco, venda.CliFor.Numero, venda.CliFor.Complemento, venda.CliFor.Bairro);
                    rowVenda.Cidade = venda.CliFor.Cidade.Nome;
                    rowVenda.Descricao = venda.EventoEspecificacao;
                    rowVenda.Valor = venda.ValorLiquido.GetValueOrDefault();
                    rowVenda.NumParcelas = venda.Lancamento.Count;
                    rowVenda.Logo = Lib.Session.Instance.LogoReport;

                    Dataset.Venda.AddVendaRow(rowVenda);

                    //produtos
                    foreach (var prod in venda.VendaItem)
                    {
                        var rowProd = Dataset.Produtos.NewProdutosRow();
                        rowProd.IdProduto = prod.IdItem;
                        rowProd.IdVenda = prod.IdPedido;
                        rowProd.Nome = prod.Produto.Nome;
                        rowProd.Quant = (int)prod.Quant;
                        rowProd.ValorUnitario = prod.ValorUnitario.GetValueOrDefault();
                        rowProd.ValorTotal = prod.ValorTotal.GetValueOrDefault();

                        Dataset.Produtos.AddProdutosRow(rowProd);
                    }

                    //lancamentos
                    foreach (var lanc in venda.Lancamento)
                    {
                        var rowLanc = Dataset.Parcelas.NewParcelasRow();
                        rowLanc.IdParcela = lanc.IdLancamento;
                        rowLanc.IdVenda = lanc.IdPedido.GetValueOrDefault();
                        rowLanc.DataVendimento = lanc.DataVencimento;
                        rowLanc.DataBaixa = lanc.DataBaixa.GetValueOrDefault();
                        rowLanc.Valor = lanc.ValorLiquido;

                        Dataset.Parcelas.AddParcelasRow(rowLanc);
                    }
                }
            }
        }

        private void CarregaRelatorio()
        {
            try
            {
                //configura o relatorio
                Relatorio report = new Relatorio();
                report.SetDataSource(Dataset);

                //carrega o report viewer
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Zoom(100);
            }
            catch (Exception ex)
            {
                Lib.MessageBoxUtilities.MessageError(null, ex);
            }
        }

        #endregion
    }
}
