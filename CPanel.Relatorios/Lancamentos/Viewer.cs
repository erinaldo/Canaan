using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPanel.Relatorios.Lancamentos
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public int Filial { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public Model DataSet { get; set; }

        #endregion

        #region CONSTRUTORES

        public Viewer(int pFilial, int pMes, int pAno)
        {
            //inicializa as propriedades
            this.Filial = pFilial;
            this.Mes = pMes;
            this.Ano = pAno;
            this.DataSet = new Model();


            //inicializa
            InitializeComponent();
        }

        #endregion

        #region METODOS

        public void CarregaDados() 
        { 
            //verifica se é filial unica
            var filiais = this.GetFiliais();

            foreach (var item in filiais)
            {
                //adiciona a filial no dataset
                var rowFilial = DataSet.Filial.NewFilialRow();
                rowFilial.IdFilial = item.id_filial;
                rowFilial.Nome = item.nome;

                DataSet.Filial.AddFilialRow(rowFilial);

                //adiciona lancamentos da filial
                var periodo = Lib.Periodo.GetPeriodo(this.Ano, this.Mes, this.Filial);
                var lancamentos = Lib.Lancamento.GetByPeriodo(periodo.id_periodo);

                foreach (var lanc in lancamentos)
                {
                    var rowLanc = DataSet.Lancamento.NewLancamentoRow();
                    rowLanc.IdLancamento = lanc.id_lancamento;
                    rowLanc.IdFilial = lanc.id_filial.GetValueOrDefault();
                    rowLanc.Data = lanc.data.GetValueOrDefault();

                    rowLanc.FatDinheiro = lanc.venda_vista.GetValueOrDefault();
                    rowLanc.FatCartao = lanc.venda_vista_cartao.GetValueOrDefault();
                    rowLanc.FatPrazo = lanc.venda_prazo.GetValueOrDefault();
                    rowLanc.FatBruto = lanc.faturamento_bruto.GetValueOrDefault();
                    rowLanc.FatLiquido = lanc.faturamento.GetValueOrDefault();

                    rowLanc.EntradaDinheiro = lanc.venda_entradas.GetValueOrDefault();
                    rowLanc.EntradaCartao = lanc.venda_entrada_cartao.GetValueOrDefault();
                    rowLanc.EntradaTotal = lanc.comissao.GetValueOrDefault();

                    rowLanc.Recebimento = lanc.recebimento.GetValueOrDefault();
                    rowLanc.FluxoCaixa = lanc.fluxo_caixa.GetValueOrDefault();
                    rowLanc.Fotografados = lanc.fotografados.GetValueOrDefault();
                    rowLanc.Vendas = lanc.vendas.GetValueOrDefault();
                    rowLanc.Brindes = lanc.brindes.GetValueOrDefault();
                    rowLanc.Programadas = lanc.condicional.GetValueOrDefault();

                    DataSet.Lancamento.AddLancamentoRow(rowLanc);
                }
            }
        }

        public void CarregaRelatorio() 
        {
            //configura o relatorio
            Relatorio report = new Relatorio();

            //carrega dados
            report.SetDataSource(this.DataSet);

            //carrega o report viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Zoom(100);
        }

        public List<Dados.filiais> GetFiliais()
        { 
            //verifica se é filial unica
            var filiais = new List<Dados.filiais>();

            if (this.Filial != 0)
            {
                filiais.Add(Lib.Filiais.GetById(this.Filial));
            }
            else 
            {
                foreach (var item in Lib.Filiais.Get())
                {
                    filiais.Add(item);
                }
            }

            return filiais;
        }

        #endregion

        #region EVENTOS
        private void Viewer_Load(object sender, EventArgs e)
        {
            CarregaDados();
            CarregaRelatorio();
        }

        #endregion

        

        
    }
}
