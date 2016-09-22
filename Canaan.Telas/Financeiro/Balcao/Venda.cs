using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Telas.Financeiro.Balcao
{
    public partial class Venda : Form
    {
        #region PROPRIEDADES

        public Dados.CliFor CliFor { get; set; }
        public Dados.Lancamento Lancamento { get; set; }
        public Dados.Venda Item { get; set; }
        public List<Dados.Produto> Produtos { get; set; }

        #endregion

        #region CONSTRUTORES

        public Venda()
        {
            this.CliFor = new Lib.CliFor().GetByCpf("00000000000").FirstOrDefault(a => a.Tipo == Dados.EnumCliForTipo.Cliente);
            this.Item = new Dados.Venda();
            this.Lancamento = new Dados.Lancamento();
            this.Produtos = new Lib.Produto().Get().Where(a => a.IsAtivo == true).ToList();

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Venda_Load(object sender, EventArgs e)
        {
            InicializaFormulario();
            CarregaProdutos();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            EfetuaVenda();
            BaixaLancamento();

            this.Close();
        }

        private void produtosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculaPreco();
        }

        private void quantTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculaPreco();
        }

        #endregion

        #region METODOS

        private void CarregaProdutos()
        {
            produtosComboBox.DisplayMember = "Nome";
            produtosComboBox.ValueMember = "IdProduto";
            produtosComboBox.DataSource = this.Produtos;
        }

        private void InicializaFormulario()
        {
            lbCliente.Text = this.CliFor.Nome;
            dataDateTimePicker.Value = DateTime.Today;
            quantTextBox.Text = "1";
            valorTextEdit.EditValue = 0;
        }

        private void CalculaPreco()
        {
            try
            {
                var id = (int)produtosComboBox.SelectedValue;

                valorTextEdit.EditValue = this.Produtos.FirstOrDefault(a => a.IdProduto == id).Valor * int.Parse(quantTextBox.Text);
            }
            catch (Exception)
            {

                valorTextEdit.EditValue = 0;
            }
            
        }

        private void EfetuaVenda()
        {
            //configura venda
            this.Item.IdFilial = Lib.Session.Instance.Contexto.IdFilial;
            this.Item.IdCliFor = this.CliFor.IdCliFor;
            this.Item.IdUsuario = Lib.Session.Instance.Usuario.IdUsuario;
            this.Item.IdAtendimento = new Lib.Atendimento().GetByCliFor(this.CliFor.IdCliFor).FirstOrDefault().IdAtendimento;
            this.Item.IdFormaPgto = new Lib.FormaPgto().Get().FirstOrDefault(a => a.NumParcela == 1 && a.DistParcela == 0).IdFormaPgto;
            this.Item.IdFormaEntrada = new Lib.FormaEntrada().Get().FirstOrDefault(a => a.Parcelas == 0).IdFormaEntrada;
            this.Item.Data = DateTime.Today.Date;
            this.Item.DataEmissao = dataDateTimePicker.Value;
            this.Item.ClasseContabil = Dados.EnumClasseContabil.Entrada;
            this.Item.ValorBruto = (decimal)valorTextEdit.EditValue;
            this.Item.ValorLiquido = (decimal)valorTextEdit.EditValue;
            this.Item.Status = Dados.EnumStatusVenda.Faturado;
            this.Item.ValorEntrada = 0;
            this.Item.DataVenda = dataDateTimePicker.Value;
            this.Item.IsFaturado = true;
            this.Item.DataFaturamento = DateTime.Today;
            this.Item.IsLiberado = true;
            this.Item.DataLiberacao = DateTime.Today;
            this.Item.IsDevolvida = false;
            this.Item.DataDevolucao = null;
            this.Item.IsConfirmado = true;
            this.Item.DataConfirmacao = DateTime.Today;
            this.Item.TipoVenda = (int)Lib.Utilitarios.TipoVenda.AVista;
            this.Item.IsAtivo = true;

            //salva venda
            this.Item = new Lib.Venda().Insert(this.Item);

            //inclui produto
            var produto = this.Produtos.FirstOrDefault(a => a.IdProduto == (int)produtosComboBox.SelectedValue);
            var vendaItem = new Dados.VendaItem();
            vendaItem.IdPedido = this.Item.IdPedido;
            vendaItem.IdProduto = produto.IdProduto;
            vendaItem.Quant = int.Parse(quantTextBox.Text);
            vendaItem.ValorUnitario = produto.Valor;
            vendaItem.ValorTotal = decimal.Parse(valorTextEdit.Text);

            vendaItem = new Lib.VendaItem().Insert(vendaItem);


            //cria lancamento
            this.Lancamento.IdPedido = this.Item.IdPedido;
            this.Lancamento.IdCliFor = this.CliFor.IdCliFor;
            this.Lancamento.IdFilial = Lib.Session.Instance.Contexto.IdFilial;
            this.Lancamento.IdContaCaixa = new Lib.ContaCaixa().GetPadraoFilial(this.Lancamento.IdFilial).IdContaCaixa;
            this.Lancamento.Tipo = Dados.EnumLancTipo.Receber;
            this.Lancamento.Status = Dados.EnumStatusLanc.EmAberto;
            this.Lancamento.ClasseContabil = Dados.EnumClasseContabil.Entrada;
            this.Lancamento.DataEmissao = DateTime.Today;
            this.Lancamento.DataVencimento = dataDateTimePicker.Value.Date;
            this.Lancamento.ValorOriginal = (decimal)valorTextEdit.EditValue;
            this.Lancamento.ValorLiquido = (decimal)valorTextEdit.EditValue;
            this.Lancamento.IsEntrada = false;
            this.Lancamento.Descricao = produto.Nome;

            this.Lancamento = new Lib.Lancamento().Insert(this.Lancamento);
        }

        private void BaixaLancamento()
        {
            if (this.Lancamento.DataVencimento == DateTime.Today)
            {
                var ids = new List<int>();
                ids.Add(this.Lancamento.IdLancamento);

                var frm = new Telas.Financeiro.Lancamento.Baixa(ids.ToArray());
                frm.ShowDialog();
            }
        }

        #endregion
    }
}
