using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Fichas.ComprovanteEntrada
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public int IdVenda { get; set; }
        public Model DataSet { get; set; }

        #endregion

        #region CONSTRUTORES
        
        public Viewer(int pIdVenda)
        {
            this.IdVenda = pIdVenda;

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Viewer_Load(object sender, EventArgs e)
        {
            CarregaDataSet();
            CarregaRelatorio();
        }

        #endregion

        #region METODOS

        private void CarregaDataSet()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                var venda = conn.Pedido.OfType<Dados.Venda>().FirstOrDefault(a => a.IdPedido == IdVenda);
                var lanc = venda.Lancamento.FirstOrDefault(a => a.ClasseContabil == Dados.EnumClasseContabil.Entrada);

                if (lanc != null)
                {
                    this.DataSet = new Model();

                    var row = this.DataSet.Comprovante.NewComprovanteRow();
                    row.IdComprovante = 0;
                    row.Cidade = venda.Filial.Cidade.Nome;
                    row.Data = DateTime.Today;
                    row.NomeFantasia = venda.Filial.NomeFantasia;
                    row.Valor = lanc.ValorLiquido;
                    row.Cliente = venda.CliFor.Nome;
                    row.Servicos = "";
                    row.Logo = Utilitarios.Comum.GetLogoReport();

                    foreach (var servico in venda.OrdemServico)
                    {
                        row.Servicos += servico.Servico.Nome + "\n";
                    }

                    row.DataEntrada = lanc.DataVencimento;
                    row.TipoEntrada = venda.FormaEntrada.Nome;
                    row.FormaPagamento = venda.FormaPgto.Nome;
                    row.Vendedora = string.Format("{0} {1}", venda.Usuario.Nome.Trim(), venda.Usuario.Sobrenome.Trim());

                    this.DataSet.Comprovante.AddComprovanteRow(row);
                }
                else 
                {
                    MessageBox.Show("Nenhum lançamento de entrada encontrado. Revise os lançamentos financeiros.");
                }
                
            }
        }

        private void CarregaRelatorio()
        {
            try
            {
                if (this.DataSet != null)
                {
                    //configura o relatorio
                    Relatorio report = new Relatorio();

                    //carrega dados
                    report.SetDataSource(DataSet);

                    //carrega o report viewer
                    crystalReportViewer1.ReportSource = report;
                    crystalReportViewer1.Zoom(100);
                }
                else 
                {
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

    }
}
