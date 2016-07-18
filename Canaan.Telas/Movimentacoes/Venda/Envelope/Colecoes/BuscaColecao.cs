using System;
using System.ComponentModel;
using System.Windows.Forms;
using Canaan.Lib;
using Tabela = Canaan.Dados.Tabela;

namespace Canaan.Telas.Movimentacoes.Venda.Envelope.Colecoes
{
    public partial class BuscaColecao : Form
    {
        #region PROPRIEDADES

        public Model Model { get; set; }

        public TabelaFilial LibTabela
        {
            get
            {
                return new TabelaFilial();
            }
        }

        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }

        public Produto LibProduto
        {
            get
            {
                return new Produto();
            }
        }

        public bool Selected { get; set; }

        #endregion

        #region CONSTRUTORES

        public BuscaColecao()
        {
            InitializeComponent();
        }

        #endregion

        #region METODOS

        private void InitBinding()
        {
            txtFiltro.DataBindings.Add(new Binding("Text", Model, "Filtro"));
            dataGrid.DataBindings.Add(new Binding("DataSource", Model, "Colecoes"));
            txtUnitario.DataBindings.Add(new Binding("Text", Model, "PrecoUnitarioStr"));
            txtTotal.DataBindings.Add(new Binding("Text", Model, "PrecoTotalStr"));

            txtQuantidade.DataBindings.Add(new Binding("Text", Model, "Quantidade"));
        }

        private void InitModel()
        {
            Model = new Model();
            Model.Tabela = LibTabela.GetByFilial(Session.Contexto.IdFilial);
            Model.Quantidade = 1;

        }

        private void CalculaValores()
        {
            try
            {
                Model.Quantidade = decimal.Parse(txtQuantidade.Text);

                //Valor Unitário
                if (Model.ColecaoSelecionada != null)
                {

                    if (string.IsNullOrWhiteSpace(txtValManual.Text))
                    {
                        Model.PrecoUnitarioStr = Model.ColecaoSelecionada.Valor;
                        Model.PrecoUnitario = Model.ColecaoSelecionada.Prod.Valor.Value;

                        //Valor Total
                        var result = Model.ColecaoSelecionada.Prod.Valor * decimal.Parse(txtQuantidade.Text);
                        Model.PrecoTotal = result.Value;
                        Model.PrecoTotalStr = result.Value.ToString("c");
                    }
                    else
                    {
                        var novoValor = decimal.Parse(txtValManual.Text);
                        Model.PrecoUnitario = novoValor;
                        Model.PrecoUnitarioStr = novoValor.ToString("c");

                        //Valor Total
                        var result = novoValor * decimal.Parse(txtQuantidade.Text);
                        Model.PrecoTotal = result;
                        Model.PrecoTotalStr = result.ToString("c");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        #endregion

        #region EVENTOS

        private void BuscaColecao_Load(object sender, EventArgs e)
        {
            dataGrid.AutoGenerateColumns = false;

            InitModel();
            InitBinding();
        }

        private void btFiltro_Click(object sender, EventArgs e)
        {
            if (Model.Tabela != null)
            {
                var produtos = LibProduto.GetByTabelaAndNome(Model.Tabela.IdTabela, Model.Filtro);
                Model.Colecoes = new BindingList<Lib.Model.Produto>(LibProduto.CarregaGridModel(produtos));
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhuma tabela selecionada");
            }
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            Selected = false;
            Model.SelectedRow = dataGrid.CurrentRow;
            CalculaValores();
        }

        private void BuscaColecao_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (Model.ColecaoSelecionada != null)
            {
                Selected = true;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum Registro selecionado");
            }

        }

        #endregion

        private void txtUnitario_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtValManual_Leave(object sender, EventArgs e)
        {
            CalculaValores();
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            CalculaValores();
        }

    }

    #region MODELO

    public class Model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        private BindingList<Lib.Model.Produto> colecoes;

        public BindingList<Lib.Model.Produto> Colecoes
        {
            get { return colecoes; }
            set
            {
                colecoes = value;
                NotifyPropertyChanged("Colecoes");
            }
        }

        private Tabela tabela;

        public Tabela Tabela
        {
            get { return tabela; }
            set
            {
                tabela = value;
                NotifyPropertyChanged("Tabela");
            }
        }

        public Lib.Model.Produto ColecaoSelecionada
        {
            get
            {
                if (selectedRow == null)
                    return null;

                return SelectedRow.DataBoundItem as Lib.Model.Produto;
            }
        }

        private DataGridViewRow selectedRow;

        public DataGridViewRow SelectedRow
        {
            get { return selectedRow; }
            set
            {
                selectedRow = value;
                NotifyPropertyChanged("SelectedRow");
                NotifyPropertyChanged("ColecaoSelecionada");
                NotifyPropertyChanged("PrecoUnitarioStr");
            }
        }

        private string precoUnitarioStr;

        public string PrecoUnitarioStr
        {
            get
            {
                return precoUnitarioStr;
            }
            set
            {
                precoUnitarioStr = value;
                NotifyPropertyChanged("PrecoUnitarioStr");
                NotifyPropertyChanged("PrecoTotalStr");
            }
        }

        private string precoTotalStr;

        public string PrecoTotalStr
        {
            get
            {
                return precoTotalStr;
            }
            set
            {
                precoTotalStr = value;
                NotifyPropertyChanged("PrecoTotalStr");
            }
        }

        public decimal PrecoTotal { get; set; }

        public decimal PrecoUnitario { get; set; }

        private string filtro;

        public string Filtro
        {
            get { return filtro; }
            set
            {
                filtro = value;
                NotifyPropertyChanged("Filtro");
            }
        }

        private decimal quantidade;

        public decimal Quantidade
        {
            get
            {
                return quantidade;
            }
            set
            {
                quantidade = value;
                NotifyPropertyChanged("Quantidade");
                NotifyPropertyChanged("PrecoTotalStr");
            }
        }


    #endregion

    }
}

