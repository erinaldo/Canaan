using System;
using System.Windows.Forms;

namespace Canaan.Telas.Configuracoes.Geral.Cidade
{
    public partial class Seleciona : Form
    {
        //
        //PROPRIEDADES
        public Lib.Cidade LibCidade { get; set; }
        public Dados.Cidade Cidade { get; set; }


        //
        //CONSTRUTORES
        public Seleciona()
        {
            //inicializa propriedades
            LibCidade = new Lib.Cidade();
            Cidade = null;

            //iniciliza controles
            InitializeComponent();
        }


        //
        //EVENTOS
        //seleciona a cidade
        private void dataGridCidade_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridCidade.SelectedRows.Count > 0)
            {
                //carrega a propriedade
                int id = (int)dataGridCidade.SelectedRows[0].Cells[0].Value;
                Cidade = LibCidade.GetById(id);

                //fecha o form
                Close();
            }
            else 
            {
                MessageBox.Show("Nenhuma cidade selecionada");
            }
        }

        //carrega o formulario
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filtroTextBox.Text))
            {
                dataGridCidade.DataSource = LibCidade.CarregaGrid(LibCidade.GetByNome(filtroTextBox.Text));
            }
            else 
            {
                MessageBox.Show("Nenhum filtro informado");
            }
            
        }

        private void Seleciona_Load(object sender, EventArgs e)
        {

        }

        private void dataGridCidade_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridCidade.ColumnCount > 0)
            {
                foreach (var item in dataGridCidade.Columns)
                {
                    //int
                    if (item is DataGridViewTextBoxColumn)
                    {
                        var col = (DataGridViewTextBoxColumn)item;
                        int value;

                        if (dataGridCidade.Rows.Count > 0)
                        {
                            if (int.TryParse(dataGridCidade.Rows[0].Cells[col.Index].Value.ToString(), out value) == true)
                            {
                                dataGridCidade.Columns[col.Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                                dataGridCidade.Columns[col.Index].Width = 75;
                            }
                            else
                            {
                                dataGridCidade.Columns[col.Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            }
                        }

                    }

                    //checkbox
                    if (item is DataGridViewCheckBoxColumn)
                    {
                        var col = (DataGridViewCheckBoxColumn)item;
                        dataGridCidade.Columns[col.Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dataGridCidade.Columns[col.Index].Width = 75;
                    }
                }

                dataGridCidade.ClearSelection();
            }
        }
    }
}
