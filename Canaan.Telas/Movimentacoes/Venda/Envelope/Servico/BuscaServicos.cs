using System;
using System.ComponentModel;
using System.Windows.Forms;
using Canaan.Lib;

namespace Canaan.Telas.Movimentacoes.Venda.Envelope.Servico
{
    public partial class BuscaServicos : Form
    {
        private int idProduto;

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

        public Lib.Servico LibServico
        {
            get
            {
                return new Lib.Servico();
            }
        }

        #endregion

        #region CONSTRUTORES

        public BuscaServicos(int idProduto)
        {
            this.idProduto = idProduto;
            InitializeComponent();
        }

        public BuscaServicos()
        {
            InitializeComponent();
        }

        #endregion

        #region METODOS

        private void InitBinding()
        {
            txtFiltro.DataBindings.Add(new Binding("Text", Model, "Filtro"));
            dataGrid.DataBindings.Add(new Binding("DataSource", Model, "Servicos"));
        }

        private void InitModel()
        {
            Model = new Model();
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
            if (!string.IsNullOrEmpty(txtFiltro.Text))
            {
                var result = LibServico.GetByNome(txtFiltro.Text.Trim());
                Model.Servicos = new BindingList<Lib.Model.Servico>(LibServico.CarregaGridModel(result, idProduto));
            }
            else
            {
                var result = LibServico.GetByStatus(true);
                Model.Servicos = new BindingList<Lib.Model.Servico>(LibServico.CarregaGridModel(result, idProduto));

            }
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            Model.SelectedRow = dataGrid.CurrentRow;
        }

        private void BuscaColecao_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (Model.ServicoSelecionado != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum Registro selecionado");
            }

        }

        #endregion

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

        private BindingList<Lib.Model.Servico> servicos;
        public BindingList<Lib.Model.Servico> Servicos
        {
            get { return servicos; }
            set
            {
                servicos = value;
                NotifyPropertyChanged("Servicos");
            }
        }

        public Lib.Model.Servico ServicoSelecionado
        {
            get
            {
                return SelectedRow.DataBoundItem as Lib.Model.Servico;
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
                NotifyPropertyChanged("ServicoSelecionado");
            }
        }

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

    #endregion

    }
}