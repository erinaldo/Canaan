using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Telas.Laboratorio.Pendentes
{
    public partial class Lista : Form
    {
        public List<Dados.Envio> Envios { get; set; }
        public List<GridModel> GridList { get; set; }

        public Lista()
        {
            this.Envios = new List<Dados.Envio>();

            InitializeComponent();
        }

        private void Lista_Load(object sender, EventArgs e)
        {
            this.Init();
            this.LoadGrid();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            ExecutaFiltro();
        }

        private void gridVendas_DoubleClick(object sender, EventArgs e)
        {
            OpenVenda();
        }

        private void gridVendas_SelectionChanged(object sender, EventArgs e)
        {
            LoadPedidos();
        }



        private void Init()
        {
            gridVendas.AutoGenerateColumns = false;
            gridPedidos.AutoGenerateColumns = false;
        }

        private void LoadGrid()
        {
            this.GridList = new List<GridModel>();

            foreach (var item in this.Envios)
            {
                this.GridList.Add(new GridModel
                {
                    IdEnvio = item.IdEnvio,
                    IdPedido = item.IdPedido,
                    CodigoReduzido = item.Pedido_Venda.Atendimento.CodigoReduzido,
                    Valor = item.Pedido_Venda.ValorLiquido.GetValueOrDefault(),
                    Data = item.Pedido_Venda.DataVenda.GetValueOrDefault(),
                    Nome = item.Pedido_Venda.CliFor.Nome
                });
            }

            gridVendas.DataSource = this.GridList;
        }

        private void LoadPedidos()
        {
            if (gridVendas.SelectedRows.Count > 0)
            {
                var libPedido = new Lib.EnvioPedido();
                var id = (int)gridVendas.SelectedRows[0].Cells[0].Value;

                var pedidos = libPedido.GetByEnvio(id);

                gridPedidos.DataSource = pedidos;
                gridPedidos.ClearSelection();
            }
            

        }

        private void ExecutaFiltro()
        {
            var libVenda = new Lib.Venda();
            var libEnvio = new Lib.Envio();
            var lista = new List<Dados.Venda>();

            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                var codigoReduzido = int.Parse(txtCodigo.Text);
                var filial = Lib.Session.Instance.Contexto.IdFilial;

                lista = libVenda.GetByCodigoReduzido(codigoReduzido, filial);
            }
            else
            {
                if (!string.IsNullOrEmpty(txtCliente.Text))
                {
                    lista = libVenda.GetByNome(txtCliente.Text);
                }
            }

            //cria lista de envio
            this.Envios = new List<Dados.Envio>();
            foreach (var item in lista)
            {
                var envios = libEnvio.GetByVenda(item.IdPedido);

                foreach (var envio in envios)
                {
                    this.Envios.Add(envio);
                }
                    
            }

            //carrega o grid
            this.LoadGrid();
        }

        private void OpenVenda()
        {
            if (gridVendas.SelectedRows.Count > 0)
            {
                var id = (int)gridVendas.SelectedRows[0].Cells[0].Value;
                var IdVenda = (int)gridVendas.SelectedRows[0].Cells[1].Value;
                var envio = this.Envios.FirstOrDefault(a => a.IdEnvio == id);

                
                var frm = new Movimentacoes.Venda.Principal.Principal(IdVenda);
                frm.ShowDialog();

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gridVendas.SelectedRows.Count > 0)
            {
                var id = (int)gridVendas.SelectedRows[0].Cells[0].Value;
                var IdVenda = (int)gridVendas.SelectedRows[0].Cells[1].Value;
                var envio = this.Envios.FirstOrDefault(a => a.IdEnvio == id);


                var frm = new Pedido.Edita(envio);
                frm.ShowDialog();

                this.LoadPedidos();
            }
            else
            {
                MessageBox.Show("Nenhuma venda selecionada.");
            }
            
        }
    }
}
