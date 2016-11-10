using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Financeiro.Caixa.LivroCaixa
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public Dados.ContaCaixa ContaCaixa { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Model Dataset { get; set; }

        #endregion

        #region CONSTRUTORES

        public Viewer(int pIdContaCaixa, DateTime pDataInicio, DateTime pDataFim)
        {
            this.ContaCaixa = new Lib.ContaCaixa().GetById(pIdContaCaixa);
            this.DataInicio = pDataInicio;
            this.DataFim = pDataFim;
            this.Dataset = new Model();

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
            using (var conn = new Canaan.Dados.CanaanModelContainer())
            {
                //configura o livro caixa
                var rowLivroCaixa = Dataset.LivroCaixa.NewLivroCaixaRow();

                //dados do livro caixa
                rowLivroCaixa.IdContaCaixa = ContaCaixa.IdContaCaixa;
                rowLivroCaixa.ContaCaixa = ContaCaixa.Nome;
                rowLivroCaixa.DataInicio = DataInicio;
                rowLivroCaixa.DataFim = DataFim;
                rowLivroCaixa.AnteriorDebido = GetAnteriorDebito();
                rowLivroCaixa.AnteriorCredito = GetAnteriorCredito();
                rowLivroCaixa.SaldoAnterior = rowLivroCaixa.AnteriorCredito - rowLivroCaixa.AnteriorDebido;

                //lancamentos do periodo
                var extratos = conn.Extrato.Where(a => a.Data >= DataInicio && a.Data <= DataFim);
                

                foreach (var extrato in extratos)
                {
                    var rowExtrato = Dataset.Extrato.NewExtratoRow();
                    rowExtrato.IdExtrato = extrato.IdExtrato;
                    rowExtrato.IdContaCaixa = extrato.IdContaCaixa;
                    rowExtrato.CliFor = extrato.Lancamento.Count > 0 ? extrato.Lancamento.FirstOrDefault().CliFor.Nome : "";

                    if (extrato.Lancamento.Count > 0)
                        rowExtrato.PagRec = extrato.Lancamento.FirstOrDefault().Tipo == Dados.EnumLancTipo.Pagar ? "D" : "C";
                    else
                        rowExtrato.PagRec = "N";

                    rowExtrato.Tipo = extrato.TipoPgto.ToString();
                    rowExtrato.Status = extrato.Status == Dados.EnumStatusExtrato.Baixado ? "B" : "E";

                    rowExtrato.Data = extrato.Data;

                    if (rowExtrato.PagRec == "D")
                        rowExtrato.Valor = extrato.ValorPago * -1;
                    else
                        rowExtrato.Valor = extrato.ValorPago;


                    var obs = "";
                    foreach (var lanc in extrato.Lancamento)
                    {
                        obs += string.Format("{0}{1}", lanc.Descricao, Environment.NewLine);
                    }
                    rowExtrato.Obs = obs;

                    Dataset.Extrato.AddExtratoRow(rowExtrato);

                }


                //coloca a logo e os somatorios
                rowLivroCaixa.SaldoCredito = Dataset.Extrato.Where(a => a.PagRec == "C").Sum(a => a.Valor);
                rowLivroCaixa.SaldoDebito = Dataset.Extrato.Where(a => a.PagRec == "D").Sum(a => a.Valor);
                rowLivroCaixa.SaldoDia = rowLivroCaixa.SaldoCredito + rowLivroCaixa.SaldoDebito;
                rowLivroCaixa.SaldoAtual = (rowLivroCaixa.SaldoCredito + rowLivroCaixa.SaldoDebito) + rowLivroCaixa.SaldoAnterior;
                rowLivroCaixa.Logo = Lib.Session.Instance.LogoReport;

                //adiciona no dataset
                Dataset.LivroCaixa.AddLivroCaixaRow(rowLivroCaixa);

            }
        }

        private void CarregaRelatorio()
        {
            try
            {
                //configura o relatorio
                var report = new Relatorio();

                //carrega dados
                report.SetDataSource(this.Dataset);

                //carrega o report viewer
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Zoom(100);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private decimal GetAnteriorDebito()
        {
            using (var conn = new Canaan.Dados.CanaanModelContainer())
            {
                var baixado = conn.Lancamento.Where(a => a.Extrato != null &&
                                                         a.IdContaCaixa == ContaCaixa.IdContaCaixa &&
                                                         a.Extrato.Data < DataInicio &&
                                                         a.Extrato.Status == Canaan.Dados.EnumStatusExtrato.Baixado &&
                                                         a.Tipo == Canaan.Dados.EnumLancTipo.Pagar)
                                             .Select(a => a.Extrato)
                                             .ToList();

                var estornado = conn.Lancamento.Where(a => a.IdContaCaixa == ContaCaixa.IdContaCaixa &&
                                                           a.Extrato.Data < DataInicio &&
                                                           a.Extrato.Status == Canaan.Dados.EnumStatusExtrato.Estornado &&
                                                           a.Tipo == Canaan.Dados.EnumLancTipo.Pagar)
                                               .Select(a => a.Extrato)
                                               .ToList();


                var valorBaixado = baixado.Count == 0 ? 0 : baixado.Distinct().Sum(a => a.ValorPago);
                var valorEstornado = estornado.Count == 0 ? 0 : estornado.Distinct().Sum(a => a.ValorPago);

                //return baixado - estornado;
                return valorBaixado - valorEstornado;
            }
        }

        private decimal GetAnteriorCredito()
        {
            using (var conn = new Canaan.Dados.CanaanModelContainer())
            {
                var baixado = conn.Lancamento.Where(a => a.Extrato != null &&
                                                         a.IdContaCaixa == ContaCaixa.IdContaCaixa &&
                                                         a.Extrato.Data < DataInicio &&
                                                         a.Extrato.Status == Canaan.Dados.EnumStatusExtrato.Baixado &&
                                                         a.Tipo == Canaan.Dados.EnumLancTipo.Receber)
                                             .Select(a => a.Extrato)
                                             .ToList();

                var estornado = conn.Lancamento.Where(a => a.IdContaCaixa == ContaCaixa.IdContaCaixa &&
                                                           a.Extrato.Data < DataInicio &&
                                                           a.Extrato.Status == Canaan.Dados.EnumStatusExtrato.Estornado &&
                                                           a.Tipo == Canaan.Dados.EnumLancTipo.Receber)
                                               .Select(a => a.Extrato)
                                               .ToList();


                var valorBaixado = baixado.Count == 0 ? 0 : baixado.Distinct().Sum(a => a.ValorPago);
                var valorEstornado = estornado.Count == 0 ? 0 : estornado.Distinct().Sum(a => a.ValorPago);

                //return baixado - estornado;
                return valorBaixado - valorEstornado;
            }
        }


        #endregion
    }
}
