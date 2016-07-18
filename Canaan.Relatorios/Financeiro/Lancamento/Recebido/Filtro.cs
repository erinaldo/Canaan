using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Financeiro.Lancamento.Recebido
{
    public partial class Filtro : Form
    {
        public Filtro()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            CarregaRelatorio();
        }

        public Shared.Model CarregaDados()
        {
            //inicializa
            var dados = new Shared.Model();
            var filial = Lib.Session.Instance.Contexto.IdFilial;

            using (var conn = new Dados.CanaanModelContainer())
            {
                var lanc = conn.Lancamento.Where(a => a.DataBaixa >= inicioDateTimePicker.Value.Date &&
                                                      a.DataBaixa <= fimDateTimePicker.Value.Date &&
                                                      a.IdFilial == filial &&
                                                      a.Tipo == Dados.EnumLancTipo.Receber &&
                                                      a.Status == Dados.EnumStatusLanc.Baixado);

                foreach (var item in lanc)
                {
                    var row = dados.Lancamento.NewLancamentoRow();
                    row.IdLancamento = item.IdLancamento;
                    row.IdFilial = item.IdFilial;
                    row.IdCaixa = item.IdContaCaixa;
                    row.IdAtendimento = ((Dados.Venda)item.Pedido).Atendimento.CodigoReduzido;
                    row.Nome = item.CliFor.Nome;
                    row.Filial = item.Filial.NomeFantasia;
                    row.Data1 = item.DataVencimento;
                    row.Data2 = item.DataBaixa.Value;
                    row.Documento = string.Format("{0}{1}", item.NossoNumero, item.NossoNumeroDac);
                    row.Valor1 = item.ValorLiquido;
                    row.Valor2 = item.ValorBaixado.Value;
                    row.Status = item.Status.ToString();
                    row.Situacao = "Pago";
                    row.Telefone1 = item.CliFor.Telefone;
                    row.Telefone2 = item.CliFor.Celular;
                    row.Telefone3 = item.CliFor.Celular2;
                    row.Logo = Utilitarios.Comum.GetLogoReport();

                    dados.Lancamento.AddLancamentoRow(row);
                }
            }

            //retorna os dados
            return dados;
        }

        private void CarregaRelatorio()
        {
            var dados = CarregaDados();
            var filial = Lib.Session.Instance.Contexto.Filial.NomeFantasia;
            var form = new Shared.Viewer("Recebido X Período",
                                         filial,
                                         inicioDateTimePicker.Value,
                                         fimDateTimePicker.Value,
                                         "Vencimento",
                                         "Baixa",
                                         "Liquido",
                                         "Baixado",
                                         dados);
            form.Show();
        }
    }
}
