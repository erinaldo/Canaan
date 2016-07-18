using System;
using System.Windows.Forms;
using Canaan.Lib;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Base
{
    public partial class FormLista : XtraForm
    {

        //PROPRIEDADES
        /// <summary>
        /// Propriedade que armazena item selecionado no grid
        /// </summary>
        public int Id
        {
            get
            {
                if (dataGrid.SelectedRows.Count > 0)
                {
                    return (int)dataGrid.SelectedRows[0].Cells[0].Value;
                }
                else
                {
                    return 0;
                } 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public object[] Parametros { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public FilterExpressionCollection FilterExpression { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Filtro objLibFiltro
        {
            get
            {
                return new Filtro();
            }
        }

        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }


        //
        //CONTRUTOR
        public FormLista()
        {
            InitializeComponent();
        }


        //
        //EVENTOS
        private void btnInsert_Click(object sender, EventArgs e)
        {
            CarregaNovo();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CarregaEdita();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ExecutaDelete();
        }

        public virtual void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            CarregaEdita();
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
                            if (dataGrid.Rows[0].Cells[col.Index].Value != null)
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


        //
        //METODOS
        protected virtual void CarregaGrid(dynamic lista)
        {
            if (lista != null)
            {
                dataGrid.DataSource = lista;
            }
        }

        protected virtual void CarregaNovo()
        {
            throw new NotImplementedException();
        }

        protected virtual void CarregaEdita()
        {
            throw new NotImplementedException();
        }

        protected virtual void ExecutaDelete()
        {

            throw new NotImplementedException();
        }

        protected virtual void CarregaActions()
        {
            throw new NotImplementedException();
        }

        protected virtual void CarregaFiltros()
        {
            throw new NotImplementedException();
        }

        private void FormLista_Load(object sender, EventArgs e)
        {

        }


    }
}
