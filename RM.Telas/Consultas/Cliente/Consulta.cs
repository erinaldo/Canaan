using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Telas.Consultas.Cliente
{
    public partial class Consulta : Form
    {
        #region PROPRIEDADES

        public bool IsConsulta { get; set; }
        public double CodColigada { get; set; }
        public string CodCliente { get; set; }

        #endregion

        #region CONSTRUTORES

        public Consulta(double pColigada)
        {
            this.IsConsulta = true;
            this.CodColigada = pColigada;
            InitializeComponent();
        }

        public Consulta(double pColigada, bool pIsConsulta)
        {
            this.IsConsulta = pIsConsulta;
            this.CodColigada = pColigada;
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ExecutaConsulta();
        }

        private void gridResult_DoubleClick(object sender, EventArgs e)
        {
            if (this.IsConsulta)
                CarregaDetalhes();
            else
                CarregaCodigo();
        }

        #endregion

        #region METODOS

        private void ExecutaConsulta() 
        {
            if (!string.IsNullOrEmpty(tbFiltro.Text))
            {
                var result = ModelConsulta.GetByResult(tbFiltro.Text, GetTipo(), this.CodColigada);

                if (result.Count > 0)
                {
                    gridResult.DataSource = result;
                }
                else 
                {
                    MessageBox.Show("Nenhum registro encontrado");
                    gridResult.DataSource = null;
                }
            }
            else {
                MessageBox.Show("Informe o valor no campo de pesquisa");
            }
        }

        private int GetTipo() 
        { 
            var tipo = 1;

            if (rbCMaster.Checked)
                tipo = 1;
            if (rbCPF.Checked)
                tipo = 2;
            if (rbNome.Checked)
                tipo = 3;

            return tipo;
        }

        private void CarregaDetalhes() 
        {
            if (gridResult.SelectedRows.Count > 0)
            {
                var cod = (string)gridResult.SelectedRows[0].Cells[0].Value;

                var frm = new Detalhe((int)this.CodColigada, cod);
                frm.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Nenhum registro selecionado");
            }
        }

        private void CarregaCodigo() 
        {
            if (gridResult.SelectedRows.Count > 0)
            {
                this.CodCliente = (string)gridResult.SelectedRows[0].Cells[0].Value;
                this.Close();
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado");
            }
        }

        #endregion

        
    }
}
