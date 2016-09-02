using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Telas.Ferramentas.Programadas
{
    public partial class VendaFiltro : Form
    {
        //
        //PROPRIEDADES
        public List<Dados.TMOV> Vendas { get; set; }

        //
        //CONSTRUTORES
        public VendaFiltro()
        {
            InitializeComponent();
        }


        //
        //EVENTOS
        private void VendaFiltro_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregaVendas();
        }

        //
        //METODOS
        private void InitForm()
        {
            CarregaFiliais();
        }

        private void CarregaFiliais() 
        {
            filiaisComboBox.DisplayMember = "NOMEFANTASIA";
            filiaisComboBox.ValueMember = "CGC";
            filiaisComboBox.DataSource = Lib.Filiais.Get();
        }

        private void CarregaVendas() 
        {
            if (!string.IsNullOrEmpty(clienteTextBox.Text))
            {
                var filial = Lib.Filiais.GetByCnpj(filiaisComboBox.SelectedValue.ToString());
                Vendas = Lib.Movimento.GetVendasByCliente(filial, clienteTextBox.Text);
                this.Close();

            }
            else 
            {
                MessageBox.Show("Nenhum cliente selecionado");
            }
        }
    }
}
