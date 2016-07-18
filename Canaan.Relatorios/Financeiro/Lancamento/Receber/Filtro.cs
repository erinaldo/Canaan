using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Canaan.Relatorios.Financeiro.Lancamento.Receber
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
                var lanc = conn.Lancamento.Where(a => a.DataVencimento >= inicioDateTimePicker.Value.Date &&
                                                      a.DataVencimento <= fimDateTimePicker.Value.Date &&
                                                      a.IdFilial == filial &&
                                                      a.Tipo == Dados.EnumLancTipo.Receber &&
                                                      a.Status == Dados.EnumStatusLanc.EmAberto);

                foreach (var item in lanc)
                {
                    var row = dados.Lancamento.NewLancamentoRow();
                    row.IdLancamento = item.IdLancamento;
                    row.IdFilial = item.IdFilial;
                    row.IdCaixa = item.IdContaCaixa;
                    row.IdAtendimento = ((Dados.Venda)item.Pedido).Atendimento.CodigoReduzido;
                    row.Nome = item.CliFor.Nome;
                    row.Filial = item.Filial.NomeFantasia;
                    row.Data1 = item.DataEmissao;
                    row.Data2 = item.DataVencimento;
                    row.Documento = string.Format("{0}{1}", item.NossoNumero, item.NossoNumeroDac);
                    row.Valor1 = item.ValorOriginal;
                    row.Valor2 = item.ValorLiquido;
                    row.Status = item.Status.ToString();
                    row.Situacao = string.Format("{0} atraso", (int)(DateTime.Today - item.DataVencimento).TotalDays);
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
            var form = new Shared.Viewer("A Receber X Período",
                                         filial,
                                         inicioDateTimePicker.Value,
                                         fimDateTimePicker.Value,
                                         "Emissão",
                                         "Vencimento",
                                         "Original",
                                         "Líquido",
                                         dados);
            form.Show();
        }
    }
}
