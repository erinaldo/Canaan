using System;
using System.Windows.Forms;

namespace Canaan.Telas.Financeiro.Conta
{
    public partial class Seleciona : Form
    {
        #region PROPRIEDADES

        public Lib.Conta objLib { get; set; }
        public Dados.Conta objItem { get; set; }

        #endregion

        #region CONSTRUTORES

        public Seleciona()
        {
            //inicializa propriedades
            objLib = new Lib.Conta();
            objItem = null;

            //iniciliza controles
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void dataGridSeleciona_DoubleClick(object sender, EventArgs e)
        {
            SelecionaItem();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            Filtra();
        }

        private void Seleciona_Load(object sender, EventArgs e)
        {
            Filtra();
        }

        private void dataGridSeleciona_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridSeleciona.ColumnCount > 0)
            {
                foreach (var item in dataGridSeleciona.Columns)
                {
                    //int
                    if (item is DataGridViewTextBoxColumn)
                    {
                        var col = (DataGridViewTextBoxColumn)item;
                        int value;

                        if (dataGridSeleciona.Rows.Count > 0)
                        {
                            if (int.TryParse(dataGridSeleciona.Rows[0].Cells[col.Index].Value.ToString(), out value) == true)
                            {
                                dataGridSeleciona.Columns[col.Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                                dataGridSeleciona.Columns[col.Index].Width = 75;
                            }
                            else
                            {
                                dataGridSeleciona.Columns[col.Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            }
                        }

                    }

                    //checkbox
                    if (item is DataGridViewCheckBoxColumn)
                    {
                        var col = (DataGridViewCheckBoxColumn)item;
                        dataGridSeleciona.Columns[col.Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dataGridSeleciona.Columns[col.Index].Width = 75;
                    }
                }

                dataGridSeleciona.ClearSelection();
            }
        }

        #endregion

        #region METODOS

        private void SelecionaItem()
        {
            if (dataGridSeleciona.SelectedRows.Count > 0)
            {
                //carrega a propriedade
                int id = (int)dataGridSeleciona.SelectedRows[0].Cells[0].Value;
                objItem = objLib.GetById(id);

                //fecha o form
                Close();
            }
            else
            {
                MessageBox.Show("Nenhuma registro selecionado");
            }
        }

        private void Filtra()
        {
            if (!string.IsNullOrEmpty(filtroTextBox.Text))
            {
                dataGridSeleciona.DataSource = objLib.CarregaGrid(objLib.GetByNome(filtroTextBox.Text));
            }
            else
            {
                dataGridSeleciona.DataSource = objLib.CarregaGrid(objLib.Get());
            }
        }

        #endregion
    }
}
