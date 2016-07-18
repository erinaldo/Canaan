using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Lib.Utilitarios;
using AtendimentoModelo = Canaan.Lib.AtendimentoModelo;
using Modelo = Canaan.Dados.Modelo;

namespace Canaan.Telas.Movimentacoes.Consulta
{
    public partial class Filtro : Form
    {
        public dynamic AtendimentosClientes { get; set; }

        public List<Modelo> AtModelos { get; set; }

        public List<Dados.Venda> Vendas { get; set; }

        public Lib.Atendimento LibAtendimento
        {
            get
            {
                return new Lib.Atendimento();
            }
        }

        public Dados.Atendimento CurrentAtendimento { get; set; }

        public AtendimentoModelo LibAtendimentoModelos
        {
            get
            {
                return new AtendimentoModelo();
            }
        }

        public Lib.Venda LibVenda
        {
            get
            {
                return new Lib.Venda();
            }
        }

        public Lib.Modelo LibModelo
        {
            get
            {
                return new Lib.Modelo();
            }
        }

        public Dados.Venda CurrentVenda { get; set; }

        public Filtro()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text) && (string.IsNullOrEmpty(txtCliente.Text)))
            {
                MessageBoxUtilities.MessageWarning("Digite um Código ou Nome do Cliente/Modelo");
            }
            else if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                BuscarAntedimento(TipoBusca.Codigo);
            }
            else
            {
                BuscarAntedimento(TipoBusca.Nome);
            }
        }

        private void BuscarAntedimento(TipoBusca tipoBusca)
        {
            try
            {
                if (tipoBusca == TipoBusca.Codigo)
                {
                    var cod = int.Parse(txtCodigo.Text.Trim());
                    AtendimentosClientes = LibAtendimento.CarregaGrid(LibAtendimento.GetListById(cod));
                }
                else
                {
                    AtendimentosClientes = LibAtendimento.CarregaGrid(LibAtendimento.GetByNome(txtCliente.Text.Trim()));
                }

                gridAtendimentos.DataSource = AtendimentosClientes;
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }


        }

        private void gridAtendimentos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (gridAtendimentos.SelectedRows.Count > 0)
                {
                    var cod = int.Parse(gridAtendimentos.SelectedRows[0].Cells[0].Value.ToString());

                    //Carrega Vendas do Atendimento
                    CarregaVendasAtendimento(cod);

                    //Carrega Modelos do Atendimento
                    CarregaModelos(cod);
                }
                else
                {
                    //Carrega Vendas do Atendimento
                    CarregaVendasAtendimento(0);

                    //Carrega Modelos do Atendimento
                    CarregaModelos(0);
                }


            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void CarregaVendasAtendimento(int cod)
        {
            Vendas = LibVenda.GetByAtendimento(cod, Session.Instance.Contexto.IdFilial);
            gridVenda.DataSource = LibVenda.CarregaGridModel(Vendas);
        }

        private void CarregaModelos(int cod)
        {
            //Carrega Lista de Fichas 
            AtModelos = LibModelo.GetByAtendimento(cod);


            if (CurrentVenda != null)
                //Carrega os modelos do cliente para este atendimento
                gridModelos.DataSource = LibModelo.CarregaGridFicha(AtModelos, CurrentVenda.IdAtendimento);
        }

        private void Filtro_Load(object sender, EventArgs e)
        {
            ConfiguraForm();
        }

        private void ConfiguraForm()
        {
            gridModelos.AutoGenerateColumns = false;
            gridAtendimentos.AutoGenerateColumns = false;
        }

        private void gridVenda_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (gridVenda.SelectedRows.Count > 0)
                {
                    var cod = int.Parse(gridVenda.SelectedRows[0].Cells[1].Value.ToString());
                    CurrentVenda = LibVenda.GetById(cod);
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void gridVenda_DoubleClick(object sender, EventArgs e)
        {
            if (gridVenda.SelectedRows.Count > 0)
            {
                var frmdetalhes = new Movimentacoes.Venda.Principal.Principal(CurrentVenda.IdPedido);
                frmdetalhes.ShowDialog();
            }
        }

        private void gridAtendimentos_DoubleClick(object sender, EventArgs e)
        {
            if (gridAtendimentos.SelectedRows.Count > 0)
            {
                var codigo = int.Parse(gridAtendimentos.SelectedRows[0].Cells[0].Value.ToString());
                CurrentAtendimento = LibAtendimento.GetById(codigo);

                var frmAtendimento = new Atendimento.Edita(CurrentAtendimento);
                frmAtendimento.ShowDialog();
            }
        }

        private void gridModelos_DoubleClick(object sender, EventArgs e)
        {
            if (gridModelos.SelectedRows.Count > 0)
            {
                var codigo = int.Parse(gridModelos.SelectedRows[0].Cells[0].Value.ToString());

                var frmModelo = new Atendimento.Modelos.Edita(codigo);
                frmModelo.ShowDialog();


            }

        }
    }
}

