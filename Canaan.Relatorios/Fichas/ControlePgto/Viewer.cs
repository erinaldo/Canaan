using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Fichas.ControlePgto
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

        public Viewer(int pIdVenda, Model pDataSet) 
        {
            this.IdVenda = pIdVenda;
            this.DataSet = pDataSet;

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Viewer_Load(object sender, EventArgs e)
        {
            if (this.DataSet == null)
            {
                this.DataSet = new Model();
                CarregaDataSet();
                CarregaRelatorio();
            }
            else 
            {
                CarregaRelatorio();
            }
        }

        #endregion

        #region METODOS

        private void CarregaRelatorio()
        {
            try
            {
                //configura o relatorio
                Carne report = new Carne();

                //carrega dados
                report.SetDataSource(DataSet);

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
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                var atual = 1;
                var venda = conn.Pedido.OfType<Dados.Venda>().FirstOrDefault(a => a.IdPedido == IdVenda);
                var filial = new Lib.Filial().GetById(Lib.Session.Instance.Contexto.IdFilial);
                var cidade = new Lib.Cidade().GetById(filial.IdCidade);
                var lancamentos = venda.Lancamento.Where(a => a.DataVencimento > a.DataEmissao).OrderBy(a => a.DataVencimento);

                //Fichas
                foreach (var item in lancamentos)
                {
                    var rowLanc = DataSet.Lancamento.NewLancamentoRow();
                    rowLanc.IdLancamento = item.IdLancamento;
                    rowLanc.CodCMaster = venda.Atendimento.CodigoReduzido;
                    rowLanc.Nome = venda.CliFor.Nome;
                    rowLanc.Cpf = venda.CliFor.Documento;
                    rowLanc.DataCompra = venda.DataEmissao.GetValueOrDefault();
                    rowLanc.DataVencimento = item.DataVencimento;
                    rowLanc.Valor = item.ValorLiquido;
                    rowLanc.Logo = Utilitarios.Comum.GetLogoReport();
                    rowLanc.NomeFantasia = filial.NomeFantasia;
                    rowLanc.Cidade = cidade.Nome;
                    rowLanc.ValorCrediario = venda.ValorCrediario.GetValueOrDefault();
                    rowLanc.ValorCanaan = venda.ValorLiquido.GetValueOrDefault();
                    rowLanc.CountAtual = atual;
                    rowLanc.CountTotal = lancamentos.Count();
                    rowLanc.CodVenda = venda.IdPedido;
                    rowLanc.CodLancamento = item.IdLancamento;
                    
                    DataSet.Lancamento.AddLancamentoRow(rowLanc);

                    atual++;
                }
            }
        }

        #endregion
    }
}
