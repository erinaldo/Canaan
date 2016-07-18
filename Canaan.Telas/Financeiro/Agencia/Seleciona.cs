using System;
using System.Windows.Forms;

namespace Canaan.Telas.Financeiro.Agencia
{
    public partial class Seleciona : Form
    {
        #region PROPRIEDADES

        public Lib.Agencia LibAgencia { get; set; }
        public Dados.Agencia Agencia { get; set; }

        #endregion

        #region CONSTRUTORES
        
        public Seleciona()
        {
            //inicializa propriedades
            LibAgencia = new Lib.Agencia();
            Agencia = null;

            //iniciliza controles
            InitializeComponent();
        }
        
        #endregion

        #region EVENTOS
        
        //seleciona a cidade
        private void dataGridAgencia_DoubleClick(object sender, EventArgs e)
        {
            SelecionaItem();
        }

        //carrega o formulario
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            Filtra();

        }

        private void Seleciona_Load(object sender, EventArgs e)
        {
            Filtra();
        }

        private void dataGridAgencia_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridAgencia.ColumnCount > 0)
            {
                foreach (var item in dataGridAgencia.Columns)
                {
                    //int
                    if (item is DataGridViewTextBoxColumn)
                    {
                        var col = (DataGridViewTextBoxColumn)item;
                        int value;

                        if (dataGridAgencia.Rows.Count > 0)
                        {
                            if (int.TryParse(dataGridAgencia.Rows[0].Cells[col.Index].Value.ToString(), out value) == true)
                            {
                                dataGridAgencia.Columns[col.Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                                dataGridAgencia.Columns[col.Index].Width = 75;
                            }
                            else
                            {
                                dataGridAgencia.Columns[col.Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            }
                        }

                    }

                    //checkbox
                    if (item is DataGridViewCheckBoxColumn)
                    {
                        var col = (DataGridViewCheckBoxColumn)item;
                        dataGridAgencia.Columns[col.Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dataGridAgencia.Columns[col.Index].Width = 75;
                    }
                }

                dataGridAgencia.ClearSelection();
            }
        }

        #endregion

        #region METODOS

        private void SelecionaItem()
        {
            if (dataGridAgencia.SelectedRows.Count > 0)
            {
                //carrega a propriedade
                int id = (int)dataGridAgencia.SelectedRows[0].Cells[0].Value;
                Agencia = LibAgencia.GetById(id);

                //fecha o form
                Close();
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado");
            }
        }

        private void Filtra()
        {
            if (!string.IsNullOrEmpty(filtroTextBox.Text))
            {
                dataGridAgencia.DataSource = LibAgencia.CarregaGrid(LibAgencia.GetByNome(filtroTextBox.Text));
            }
            else
            {
                dataGridAgencia.DataSource = LibAgencia.CarregaGrid(LibAgencia.Get());
            }
        }

        #endregion
    }
}
