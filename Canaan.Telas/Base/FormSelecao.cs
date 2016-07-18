using System;
using System.Windows.Forms;
using Canaan.Lib;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Base
{
    public partial class FormSelecao : XtraForm
    {
        public int Id 
        {
            get
            {
                return (int)dataGrid.SelectedRows[0].Cells[0].Value;
            }
        }

        public FormSelecao()
        {
            InitializeComponent();
        }

        public Session Session 
        {
            get
            {
                return Session.Instance;
            }
        }

        protected virtual void btnFiltro_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGrid.ColumnCount > 0)
            {
                foreach (var item in dataGrid.Columns)
                {
                    //int
                    if (item is DataGridViewTextBoxColumn)
                    {
                        var col = (DataGridViewTextBoxColumn)item;
                        int value;

                        if (dataGrid.Rows.Count > 0)
                        {
                            if (int.TryParse(dataGrid.Rows[0].Cells[col.Index].Value.ToString(), out value) == true)
                            {
                                dataGrid.Columns[col.Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                                dataGrid.Columns[col.Index].Width = 75;
                            }
                            else
                            {
                                dataGrid.Columns[col.Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            }
                        }

                    }

                    //checkbox
                    if (item is DataGridViewCheckBoxColumn)
                    {
                        var col = (DataGridViewCheckBoxColumn)item;
                        dataGrid.Columns[col.Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dataGrid.Columns[col.Index].Width = 75;
                    }
                }

                dataGrid.ClearSelection();
            }
        }

        protected virtual void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
