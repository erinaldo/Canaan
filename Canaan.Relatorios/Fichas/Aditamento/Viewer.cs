using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Fichas.Aditamento
{
    public partial class Viewer : Base.Viewer
    {

        public Model Dataset { get; set; }

        public int IdVenda { get; set; }

        public Viewer(int idVenda)
        {
            this.IdVenda = idVenda;
            InitializeComponent();
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            if (Dataset == null)
            {
                Dataset = new Model();
                CarregaDataSet();
                CarregaRelatorio();
            }
        }

        private void CarregaDataSet()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                var venda = conn.Pedido.OfType<Dados.Venda>().FirstOrDefault(a => a.IdPedido == IdVenda);

                var rowAditamento = Dataset.Aditamento.NewAditamentoRow();

                rowAditamento.IdVenda = venda.IdPedido;
                rowAditamento.Vendedora = venda.Atendimento.Usuario.Nome;
                rowAditamento.Cliente = venda.CliFor.Nome;
                rowAditamento.TotalVenda = venda.ValorLiquido.GetValueOrDefault().ToString("c");
                rowAditamento.Cidade = venda.Filial.Cidade.Nome;
                rowAditamento.Logo = Utilitarios.Comum.GetLogoReport();

                var totalentrada = venda.Lancamento.Where(a => a.IsEntrada).Sum(a => a.ValorLiquido);
                rowAditamento.TotalEntrada = totalentrada.ToString("c");

                decimal porcentagem = 0.0m;

                if(venda.ValorLiquido != 0)
                    porcentagem = ((totalentrada * 100) / venda.ValorLiquido).GetValueOrDefault();

                rowAditamento.Porcentagem = porcentagem;

                Dataset.Aditamento.AddAditamentoRow(rowAditamento);


                // Pa
                int count = 1;

                foreach (var item in venda.Lancamento.Where(a => a.IsEntrada).OrderBy(a => a.DataVencimento))
                {
                    var rowEntrada = Dataset.Entradas.NewEntradasRow();

                    rowEntrada.IdVenda = venda.IdPedido;
                    rowEntrada.Valor = item.ValorLiquido.ToString("c");
                    rowEntrada.Vencimento = item.DataVencimento;
                    rowEntrada.Parcela = count.ToString();

                    count++;

                    Dataset.Entradas.AddEntradasRow(rowEntrada);
                }

            }
        }

        private void CarregaRelatorio()
        {
            try
            {
                //configura o relatorio
                Relatorio report = new Relatorio();

                //carrega dados
                report.SetDataSource(Dataset);

                //carrega o report viewer
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Zoom(100);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
