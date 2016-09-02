using Canaan.Lib;
using Canaan.Telas.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Telas.Movimentacoes.Venda.Evento
{
    public partial class Lista : FormVendaBase
    {
        //
        //PROPRIEDADES
        public Lib.Venda LibVenda
        {
            get
            {
                return new Lib.Venda();
            }
        }
        public Lib.VendaEvento LibVendaEvento
        {
            get
            {
                return new Lib.VendaEvento();
            }
        }
        public Dados.Venda Venda { get; set; }
        public List<Dados.VendaEvento> Eventos { get; set; }
        private Principal.Principal Principal { get; set; }

        //
        //CONSTRUTORES
        public Lista(Dados.Venda pVenda, Principal.Principal pPrincipal)
        {
            this.Venda = pVenda;
            this.Principal = pPrincipal;

            InitializeComponent();
        }

        //
        //EVENTOS
        private void Lista_Load(object sender, EventArgs e)
        {
            InitForm();
            CarregaEventos();
            CarregaGrid();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Insere();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Atualiza();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Deleta();
        }

        private void eventosDataGridView_DoubleClick(object sender, EventArgs e)
        {
            Atualiza();
        }

        //
        //METODOS
        private void InitForm()
        {
            this.eventosDataGridView.AutoGenerateColumns = false;

            tipoEventoTextBox.Text = Venda.TipoEvento;
            nomeModeloTextBox.Text = Venda.NomeModelo;

            if(!string.IsNullOrEmpty(Venda.EventoEspecificacao))
                eventoEspecificacaoTextBox.Text = Venda.EventoEspecificacao;
            else
                eventoEspecificacaoTextBox.Text = new Lib.Config().GetByFilial(Lib.Session.Instance.Contexto.IdFilial).TextoEvento;
        }

        private void CarregaEventos()
        {
            this.Eventos = this.LibVendaEvento.GetByVenda(this.Venda.IdPedido);
        }

        private void CarregaGrid()
        {
            this.eventosDataGridView.DataSource = LibVendaEvento.CarregaGrid(this.Eventos);
        }

        private void Insere()
        {
            var frm = new Edita(this.Venda);
            frm.ShowDialog();

            CarregaEventos();
            CarregaGrid();
        }

        private void Atualiza()
        {
            if (eventosDataGridView.SelectedRows.Count > 0)
            {
                //carrega id selecionado
                int id = (int)eventosDataGridView.SelectedRows[0].Cells[0].Value;

                //carrega tela de inclusao
                Edita frm = new Edita(this.Venda, id);
                frm.ShowDialog();

                //atualiza o grid
                CarregaEventos();
                CarregaGrid();
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado");
            }
        }

        private void Deleta()
        {
            if (eventosDataGridView.SelectedRows.Count > 0)
            {
                //carrega id selecionado
                int id = (int)eventosDataGridView.SelectedRows[0].Cells[0].Value;
                var deleted = LibVendaEvento.GetById(id);

                //carrega tela de inclusao
                try
                {
                    if (MessageBox.Show("Tem certeza que deseja excluir o registro '" + deleted.Evento.Nome + "' ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //deleta objeto
                        LibVendaEvento.Delete(id);
                        MessageBox.Show("Registro '" + deleted.Evento.Nome + "' excluido com sucesso");

                        //atualiza o grid
                        CarregaEventos();
                        CarregaGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Venda.TipoEvento = tipoEventoTextBox.Text;
            Venda.NomeModelo = nomeModeloTextBox.Text;
            Venda.EventoEspecificacao = eventoEspecificacaoTextBox.Text;

            LibVenda.Update(this.Venda);

            MessageBoxUtilities.MessageInfo("Venda atualizada com sucesso.");

        }
    }
}
