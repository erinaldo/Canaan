using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.CService.Relatorios.Envelope.AtrasoXCliente
{
    public partial class Filtro : Form
    {
        #region PROPRIEDADES

        public List<FiltroViewModel> Clientes { get; set; }

        #endregion

        #region CONSTRUTOR

        public Filtro()
        {
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Filtro_Load(object sender, EventArgs e)
        {
            this.Init();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            this.CarregaGrid();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.CarregaRelatorio();
        }

        #endregion

        #region METODOS

        private void Init() 
        {
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.previsaoDateTimePicker.Value = DateTime.Today;
            this.CarregaClientes();
            this.CarregaGrid();
        }

        private void CarregaClientes() 
        {
            using (var conn = new Dados.CServicosEntities())
            {
                this.Clientes = new List<FiltroViewModel>();

                foreach (var item in conn.env_envelopes.GroupBy(a => a.nome_cliente).OrderBy(a => a.Key))
                {
                    this.Clientes.Add(new FiltroViewModel { 
                        Cliente = item.Key.ToUpper()
                    });
                }
            }
        }

        private void CarregaGrid() 
        {
            if(string.IsNullOrEmpty(clienteTextBox.Text))
                this.clienteDataGridView.DataSource = this.Clientes;
            else
                this.clienteDataGridView.DataSource = this.Clientes.Where(a => a.Cliente.Contains(clienteTextBox.Text.ToUpper().Trim())).ToList();

        }

        private void CarregaRelatorio() 
        {
            if (clienteDataGridView.SelectedRows.Count > 0)
            {
                var cliente = clienteDataGridView.SelectedRows[0].Cells[0].Value.ToString();

                //abre o relatorio
                var frm = new Viewer(cliente, this.previsaoDateTimePicker.Value);
                frm.Show();
            }
            else 
            {
                MessageBox.Show("Nenhum cliente selecionado");
            }
        }

        #endregion

        

        
    }
}
