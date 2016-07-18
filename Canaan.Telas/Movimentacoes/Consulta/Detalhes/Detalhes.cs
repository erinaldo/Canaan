using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Lib.Model;
using Lancamento = Canaan.Lib.Lancamento;
using VendaItem = Canaan.Lib.Model.VendaItem;

namespace Canaan.Telas.Movimentacoes.Consulta.Detalhes
{
    public partial class Detalhes : Form
    {
        #region PROPRIEDADES

        public List<OrdermServico> Ordens { get; set; }
        public List<VendaItem> Produtos { get; set; }

        public OrdemServico LibOrdens
        {
            get
            {
                return new OrdemServico();
            }
        }
        public Lib.VendaItem LibProdutos 
        {
            get
            {
                return new Lib.VendaItem();
            }
        }
        public Dados.Venda Venda { get; set; }
        public Lib.Venda LibVenda 
        {
            get
            {
                return new Lib.Venda();
            }
        }
        public Lancamento LibLancamento 
        {
            get
            {
                return new Lancamento();
            }
        }
        public Cupom LibCupom 
        {
            get
            {
                return new Cupom();
            }
        }
        public VendaMov LibVendaMov 
        { 
            get 
            {
                return new VendaMov();
            } 
        }

        public List<VendaMovModel> VendasMov { get; set; }

        public List<MotivoDevolucaoModel> MotivosDevolucao { get; set; }

        public MotivoDevolucao LibMotivoDevolucao
        {
            get
            {
                return new MotivoDevolucao();
            }
        }

        public int SelectedMov
        {
            get
            {
                if (dataGridDevolucoes.SelectedRows.Count <= 0)
                    return 0;

                return int.Parse(dataGridDevolucoes.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        #endregion

        #region CONSTRUTOR

        public Detalhes(Dados.Venda venda)
        {
            Venda = LibVenda.GetById(venda.IdPedido);
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Detalhes_Load(object sender, EventArgs e)
        {
            gridEnvelopes.AutoGenerateColumns = false;
            gridProdutos.AutoGenerateColumns = false;
            gridMovimentacoes.AutoGenerateColumns = false;

            CarregaServicos();
            CarregaProdutosAdquiridos();
            CarregaParcelas();
            CarregaOutrasInformacoes();
            CarregaMovimentacoes();
            CarregaDevolucoes();
        }

        #endregion

        #region METODOS

        private void CarregaParcelas()
        {
            var parcelas = LibLancamento.GetByPedido(Venda.IdPedido);
            gridParcelas.DataSource = LibLancamento.GetModelParcelas(parcelas);

        }

        private void CarregaProdutosAdquiridos()
        {
            var produtos = LibProdutos.GetByVenda(Venda.IdPedido);
            gridProdutos.DataSource = LibProdutos.CarregaGrid(produtos);
        }

        private void CarregaServicos()
        {
            var servicos = LibOrdens.GetModelByVenda(Venda.IdPedido);
            gridEnvelopes.DataSource = servicos;
        }

        private void CarregaOutrasInformacoes()
        {
            lbVendedora.Text = Venda.Atendimento.Usuario.Nome;
            lbResponsavelFinanceiro.Text = Venda.CliFor.Nome;
            lbFormaPagamento.Text = Venda.FormaPgto.Nome;
            lbFormaEntrada.Text = Venda.FormaEntrada.Nome;
            lbConvenio.Text = Venda.Atendimento.Agendamento.Cupom.Parceria.Convenio.Nome;
            lbParceria.Text = Venda.Atendimento.Agendamento.Cupom.Parceria.Nome;


            //Indicação

            var indicador = LibCupom.GetIndicador(Venda.Atendimento.Agendamento.Cupom.IdCupom);

            lbIndicacao.Text = indicador;


        }

        private void CarregaMovimentacoes()
        {
            var mov = LibVendaMov.GetMovimentacoes(Venda.IdPedido);
            gridMovimentacoes.DataSource = mov;
        }

        private void CarregaDevolucoes()
        {
            VendasMov = LibVendaMov.GetDevolucoes(Venda.IdPedido);
            dataGridDevolucoes.DataSource = VendasMov;
        }

        #endregion

        private void dataGridDevolucoes_SelectionChanged(object sender, EventArgs e)
        {
            MotivosDevolucao = LibMotivoDevolucao.GetByIdMov(SelectedMov);
            datagridMotivos.DataSource = MotivosDevolucao;
        }

    }
}
