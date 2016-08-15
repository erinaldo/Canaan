using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.CService.Telas.Integracao.Venda.Sincronismo
{
    public partial class Detalhe : Form
    {
        #region PROPRIEDADES

        public Lib.Integracao.Venda Venda { get; set; }

        #endregion

        #region CONSTRUTORES

        public Detalhe(Lib.Integracao.Venda pVenda)
        {
            this.Venda = pVenda;

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Detalhe_Load(object sender, EventArgs e)
        {
            Init();
        }

        #endregion

        #region METODOS

        private void Init() 
        {
            this.codigoLabel.Text = Venda.IdVenda.ToString();
            this.clienteLabel.Text = string.Format("{0} - {1}", Venda.IdCliente, Venda.NomeCliente);
            this.vendedorLabel.Text = Venda.NomeVendedor;
            this.emissaoLabel.Text = Venda.DataEmissao.ToShortDateString();
            this.valorLabel.Text = string.Format("{0:c}", Venda.ValorLiquido);

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = Venda.Envelopes;
            this.dataGridView1.ClearSelection();
        }

        #endregion
    }
}
