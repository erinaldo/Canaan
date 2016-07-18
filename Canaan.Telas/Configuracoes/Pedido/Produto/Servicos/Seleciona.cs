using System;
using System.Linq;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Base;

namespace Canaan.Telas.Configuracoes.Pedido.Produto.Servicos
{
    public partial class Seleciona : FormSelecao
    {
        #region PROPRIEDADES

        public Servico LibServico
        {
            get
            {
                return new Servico();
            }
        }

        public Dados.Servico Servico { get; set; }

        #endregion

        #region CONSTRUTORES

        public Seleciona()
        {
            InitializeComponent();
        }

        #endregion

        #region METODOS

        private void ConfiguraForm()
        {
            toolStripSeleciona.Items[0].Text = "Nome do Serviço";
        }

        #endregion

        #region EVENTOS

        protected override void btnFiltro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filtroTextBox.Text))
            {
                dataGrid.DataSource = LibServico.CarregaGrid(LibServico.GetByNome(filtroTextBox.Text.Trim()));
            }
            else
            {
                dataGrid.DataSource = LibServico.CarregaGrid(LibServico.Get().Take(100).ToList());
            }
        }

        protected override void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                //carrega a propriedade
                int id = (int)dataGrid.SelectedRows[0].Cells[0].Value;
                Servico = LibServico.GetById(id);

                //fecha o form
                Close();
            }
            else
            {
                MessageBox.Show("Nenhum tipo de convênio selecionada");
            }
        }

        private void Seleciona_Load(object sender, EventArgs e)
        {
            ConfiguraForm();
        }

        #endregion
    }
}
