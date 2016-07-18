using System;
using System.Linq;
using System.Windows.Forms;
using Canaan.Telas.Base;

namespace Canaan.Telas.Marketing.Cupom.Parceria
{
    public partial class Seleciona : FormSelecao
    {
        public Dados.Parceria Parceria { get; set; }

        public Lib.Parceria LibParceria { get; set; }

        public Seleciona()
        {
            InitializeComponent();

            //Inicializa Propriedades
            LibParceria = new Lib.Parceria();

            //Configura Form
            ConfiguraForm();

            InitializeComponent();
        }

        private void ConfiguraForm()
        {
            filtroLabel.Text = "Selecione a Parceria";
        }

        //EVENTOS
        protected override void btnFiltro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filtroTextBox.Text))
            {
                dataGrid.DataSource = LibParceria.GetByNome(filtroTextBox.Text)
                    .Select(a => new
                {
                    Codigo = a.IdParceria,
                    Nome = a.Nome,
                    Status = a.IsAtivo
                }).ToList();
            }
            else
            {
                dataGrid.DataSource = LibParceria.GetByAtivo(true, Session.Contexto.IdFilial)
                    .Select(a => new
                {
                    Codigo = a.IdParceria,
                    Nome = a.Nome,
                    Status = a.IsAtivo
                }).ToList();
            }
        }

        protected override void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                //carrega a propriedade
                int id = (int)dataGrid.SelectedRows[0].Cells[0].Value;
                Parceria = LibParceria.GetById(id);

                //fecha o form
                Close();
            }
            else
            {
                MessageBox.Show("Nenhum tipo de convênio selecionada");
            }
        }
    }
}
