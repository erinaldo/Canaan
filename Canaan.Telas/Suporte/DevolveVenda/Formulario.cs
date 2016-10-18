using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Telas.Movimentacoes.Venda.Principal;
using Config = Canaan.Lib.Config;
using Envio = Canaan.Lib.Envio;
using Venda = Canaan.Lib.Venda;

namespace Canaan.Telas.Suporte.DevolveVenda
{
    public partial class Formulario : Form
    {
        #region PROPRIEDADES

        public List<Model> Lista { get; set; }
        public Model Selecionado 
        {
            get 
            {
                if (vendasDataGridView.SelectedRows.Count > 0)
                {
                    var selected = (int)vendasDataGridView.SelectedRows[0].Cells[0].Value;

                    return Lista.FirstOrDefault(a => a.IdPedido == selected);
                }
                else 
                {
                    return null;
                }
            }
        }

        #endregion

        #region CONSTRUTORES

        public Formulario()
        {
            InitializeComponent();
        }

        public Formulario(int codigoReduzido)
        {
            InitializeComponent();

            codigoTextBox.Text = codigoReduzido.ToString();
            CarregaLista();
        }

        #endregion

        #region EVENTOS

        private void Formulario_Load(object sender, EventArgs e)
        {
            InitForm();
        }
        
        private void vendasDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (Selecionado != null)
            {
                var frm = new Principal(Selecionado.IdPedido);
                frm.Show();
            }
            else 
            {
                MessageBox.Show("Nenhuma venda selecionada");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregaLista();
        }

        private void btnExecuta_Click(object sender, EventArgs e)
        {
            DevolveVenda();
        }

        #endregion

        #region METODOS

        private void InitForm()
        {
            vendasDataGridView.AutoGenerateColumns = false;
        }

        public void CarregaLista() 
        {
            if (!string.IsNullOrEmpty(codigoTextBox.Text))
            {
                try
                {
                    var cod = int.Parse(codigoTextBox.Text);

                    //carrega a lista
                    Lista = Model.GetByAtendimento(cod);

                    //carrega o grid
                    CarregaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else 
            {
                MessageBox.Show("Informe o código do pedido");
            }
        }

        private void CarregaGrid()
        {
            vendasDataGridView.DataSource = Lista;
        }

        private void DevolveVenda() 
        {
            if (Selecionado != null)
            {
                if (MessageBoxUtilities.MessageQuestion("Tem certeza que deseja cancelar o pedido?") == DialogResult.Yes) 
                {
                    try
                    {
                        //devolve a venda e cancela os lancamentos
                        DevolveVendaEstudio();

                        //imprime o relatorio de cancelamento
                        CarregaRelatorio();

                        //mensagem de retorno
                        MessageBox.Show("Venda cancelada com sucesso");

                        //recarrega a lista
                        CarregaLista();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else 
            {
                MessageBox.Show("Nenhuma venda selecionada");
            }
        }

        private void DevolveVendaEstudio() 
        {
            var libVenda = new Venda();
            var libEnvio = new Envio();
            var libLancamentos = new Canaan.Lib.Lancamento();

            //carrega a venda
            var venda = libVenda.GetById(Selecionado.IdPedido);

            //devolve a venda
            venda.IsConfirmado = false;
            venda.DataConfirmacao = null;
            venda.IsFaturado = false;
            venda.DataFaturamento = null;
            venda.IsLiberado = false;
            venda.DataLiberacao = null;
            venda.IsDevolvida = true;
            venda.DataDevolucao = DateTime.Now;
            venda.Status = EnumStatusVenda.Cancelado;

            libVenda.Update(venda);

            //cancela lancamentos lancamentos
            var lancamentos = libLancamentos.GetByPedido(Selecionado.IdPedido);
            foreach (var item in lancamentos)
            {
                if (item.Status != EnumStatusLanc.Baixado)
                {
                    item.Status = EnumStatusLanc.Cancelado;

                    libLancamentos.Update(item);
                }
            }
            
        }

        private void CarregaRelatorio()
        {
            var frm = new Relatorios.Fichas.Cancelamento.Viewer(Selecionado.IdPedido);
            frm.ShowDialog();
        }
        
        #endregion        
    }
}
