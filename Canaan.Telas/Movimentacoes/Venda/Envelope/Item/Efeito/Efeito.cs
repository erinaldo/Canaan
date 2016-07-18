using System;
using System.Linq;
using Canaan.Lib;
using Canaan.Telas.Base;

namespace Canaan.Telas.Movimentacoes.Venda.Envelope.Item.Efeito
{
    public partial class Efeito : FormSelecao
    {
        #region PROPRIEDADES

        public EfeitoDigital LibEfeito
        {
            get
            {
                return new EfeitoDigital();
            }
        }

        public dynamic Efeitos { get; set; }

        public Lib.Model.EfeitoDigital EfeitoSelecionado { get; set; }

        #endregion

        #region CONSTRUTOR

        public Efeito()
        {
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Efeito_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        protected override void btnFiltro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filtroTextBox.Text))
            {
                Efeitos = LibEfeito.Get().Select(a => new Lib.Model.EfeitoDigital { IdEfeito = a.IdEfeito, Nome = a.Nome, Status = a.IsAtivo }).OrderBy(a => a.Nome).ToList();
            }
            else
            {
                Efeitos = LibEfeito.GetByNome(filtroTextBox.Text.Trim()).Select(a => new Lib.Model.EfeitoDigital { IdEfeito = a.IdEfeito, Nome = a.Nome, Status = a.IsAtivo }).OrderBy(a => a.Nome).ToList();
            }

            dataGrid.DataSource = Efeitos;
        }

        protected override void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            EfeitoSelecionado = dataGrid.CurrentRow.DataBoundItem as Lib.Model.EfeitoDigital;
            Close();
        }

        #endregion

        #region METODOS

        private void InitForm()
        {
            filtroLabel.Text = "Nome Efeito";
        }

        #endregion
    }
}
