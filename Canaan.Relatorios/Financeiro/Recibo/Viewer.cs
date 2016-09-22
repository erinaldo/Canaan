using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Financeiro.Recibo
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public int IdExtrato { get; set; }
        public List<Model> Recibo { get; set; }

        #endregion

        public Viewer(int pIdExtrato)
        {
            this.IdExtrato = pIdExtrato;
            this.Recibo = new List<Model>();

            InitializeComponent();
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            CarregaDados();
            CarregaRelatorio();
        }

        private void CarregaDados()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var lancamentos = conn.Lancamento.Where(a => a.IdExtrato == this.IdExtrato);

                if (lancamentos.Count() > 0)
                {
                    var lanc = lancamentos.FirstOrDefault();
                    var recibo = new Model();

                    recibo.Cliente = lanc.CliFor.Nome;
                    recibo.Usuario = lanc.Extrato.Usuario.Nome;
                    recibo.Caixa = lanc.Extrato.ContaCaixa.Nome;
                    recibo.TipoPagamento = lanc.Extrato.TipoPgto.ToString();
                    recibo.ValorLiquido = lanc.Extrato.ValorLiquido;
                    recibo.ValorBaixado = lanc.Extrato.ValorPago;
                    recibo.ValorTroco = lanc.Extrato.ValorTroco;
                    recibo.Data = lanc.Extrato.Data.AddHours(lanc.Extrato.Hora.Hours).AddMinutes(lanc.Extrato.Hora.Minutes);
                    recibo.Hora = lanc.Extrato.Hora;
                    recibo.Logo = Lib.Session.Instance.LogoReport;

                    
                    foreach (var item in lancamentos)
                    {
                        recibo.Lancamentos += string.Format("{0} - {1:c}{2}", item.DataVencimento.ToShortDateString(), item.ValorLiquido, Environment.NewLine);
                    }

                    this.Recibo.Add(recibo);
                }
                else
                {
                    MessageBox.Show("Nenhum lancamento encontrado");
                    this.Close();
                }
            }
        }

        private void CarregaRelatorio()
        {
            try
            {
                //configura o relatorio
                Relatorio report = new Relatorio();
                report.SetDataSource(this.Recibo);

                //carrega o report viewer
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Zoom(100);
            }
            catch (Exception ex)
            {
                Lib.MessageBoxUtilities.MessageError(null, ex);
            }
        }
    }
}
