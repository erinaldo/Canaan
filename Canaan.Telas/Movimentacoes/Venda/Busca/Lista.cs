using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Lib.Utilitarios;
using Canaan.Relatorios.Fichas.Envelope;
using CliFor = Canaan.Lib.CliFor;
using PessoaFisica = Canaan.Dados.PessoaFisica;
using PessoaJuridica = Canaan.Dados.PessoaJuridica;

namespace Canaan.Telas.Movimentacoes.Venda.Busca
{
    public partial class Lista : Form
    {
        #region PROPRIEDADES

        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }

        public CliFor LibCliFor
        {
            get
            {
                return new CliFor();
            }
        }

        public List<Dados.Atendimento> Clientes { get; set; }

        public Lib.Venda LibVenda
        {
            get
            {
                return new Lib.Venda();
            }
        }

        public int SelectedAtend
        {
            get
            {
                if (dgvAtendimentos.SelectedRows.Count > 0)
                    return int.Parse(dgvAtendimentos.SelectedRows[0].Cells[0].Value.ToString());

                return 0;
            }
        }

        public Lib.Atendimento LibAtendimento
        {
            get
            {
                return new Lib.Atendimento();
            }
        }

        public List<Dados.Atendimento> Atendimentos { get; set; }

        public Dados.Atendimento Atendimento { get; set; }

        public BindingList<Lib.Model.Venda> Vendas { get; set; }

        public int CurrentVenda
        {
            get
            {
                var result = dgvVendas.SelectedRows[0].Cells[0].Value;

                int value;
                var ok = int.TryParse(result.ToString(), out value);

                if (ok)
                    return value;
                else
                    return 0;
            }
        }

        public Dados.Venda Venda { get; set; }

        public Dados.Venda Inserted { get; set; }

        public Dados.CliFor ClienteTroca { get; set; }

        public PessoaFisica PessoaFisica
        {
            get
            {
                return ClienteTroca != null ? ClienteTroca as PessoaFisica : null;
            }
        }

        public PessoaJuridica PessoaJuridica
        {
            get
            {
                return ClienteTroca != null ? ClienteTroca as PessoaJuridica : null;
            }
        }

        #endregion

        #region CONSTRUTORES

        public Lista()
        {
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Lista_Load(object sender, EventArgs e)
        {
            dgvVendas.AutoGenerateColumns = false;
            dgvAtendimentos.AutoGenerateColumns = false;

            CarregaTipoBusca();

            ddlTipoBusca.SelectedIndex = 0;
        }

        private void dgvAtendimentos_SelectionChanged(object sender, EventArgs e)
        {
            CarregaVendas();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                BuscaClientes();
                CarregaGridAtendimentos();
            }
            catch (Exception ex)
            {

                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void novaVenda_Click(object sender, EventArgs e)
        {
            if (SelectedAtend != 0)
            {

                try
                {
                    Atendimento = LibAtendimento.GetById(SelectedAtend);
                    AddNewVenda();

                }
                catch (Exception ex)
                {
                    MessageBoxUtilities.MessageError(null, ex);
                }

                #region Antigo

                ////Pega lista de atendimentos do cliente
                //Atendimentos = LibAtendimento.GetByCliFor(SelectedAtend);

                //if (Atendimentos.Count > 1)
                //{
                //    var frm = new Movimentacoes.Atendimento.Lista(Atendimentos);
                //    frm.ShowDialog();

                //    //Armazena Atendimento selecionado na lista
                //    Atendimento = frm.AtendimentoSelecionado;

                //    if (Atendimento != null)
                //    {
                //        //Adiciona nova venda
                //        AddNewVenda();
                //    }
                //    else
                //    {
                //        Lib.MessageBoxUtilities.MessageWarning("Nenhum Atendimento selecionado.");
                //    }
                //}
                //else
                //{
                //    Atendimento = Atendimentos.FirstOrDefault();

                //    //Adiciona nova venda
                //    AddNewVenda();
                //}

                #endregion

            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum registro selecionado.");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (CurrentVenda == 0)
                MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
            else
                CarregaEdita(CurrentVenda);
        }

        private void dgvVendas_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void trocaDeCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentVenda == 0)
                {
                    MessageBoxUtilities.MessageWarning("Nenhuma venda selecionada");
                }
                else
                {
                    var frmCliente = new Cadastros.ClienteFornecedor.Lista(true);
                    frmCliente.ShowDialog();

                    if (frmCliente.Cliente != null)
                    {
                        ClienteTroca = frmCliente.Cliente;

                        if (ClienteTroca != null)
                        {
                            if (MessageBoxUtilities.MessageQuestion(string.Format("Deseja salvar {0} como cliente financeiro para está venda?", ClienteTroca.Nome)) == DialogResult.Yes)
                            {
                                Venda = LibVenda.GetById(CurrentVenda);
                                Venda.IdCliFor = ClienteTroca.IdCliFor;
                                LibVenda.Update(Venda);
                                MessageBoxUtilities.MessageInfo("Troca efetuada com sucesso");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void dgvVendas_DoubleClick(object sender, EventArgs e)
        {
            if (CurrentVenda == 0)
            {
                MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
            }
            else
            {
                CarregaEdita(CurrentVenda);
            }
        }

        private void serviçosContratadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentVenda == 0)
                {
                    MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
                }
                else
                {
                    var frm = new Viewer(CurrentVenda);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void serviçosContratadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentVenda == 0)
                {
                    MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
                }
                else
                {
                    var frm = new Relatorios.Fichas.Servicos.Viewer(CurrentVenda);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void boletpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentVenda == 0)
                {
                    MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
                }
                else
                {
                    var frm = new Relatorios.Fichas.Boleto.Viewer(CurrentVenda);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           try
            {
                if (CurrentVenda == 0)
                {
                    MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
                }
                else
                {
                    var frm = new Relatorios.Fichas.Contrato.Viewer(CurrentVenda);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void termoDeAditamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentVenda == 0)
                {
                    MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
                }
                else
                {
                    var frm = new Relatorios.Fichas.Aditamento.Viewer(CurrentVenda);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentVenda == 0)
                {
                    MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
                }
                else
                {
                    LibAtendimento.Delete(CurrentVenda);
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void trocaDeTitularidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentVenda == 0)
                {
                    MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
                }
                else
                {
                    var frm = new Relatorios.Fichas.Troca.Viewer(CurrentVenda);
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void controleDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentVenda == 0)
                {
                    MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
                }
                else
                {
                    var frm = new Relatorios.Fichas.ControlePgto.Viewer(CurrentVenda);
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void comprovanteDeEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentVenda == 0)
                {
                    MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
                }
                else
                {
                    var frm = new Relatorios.Fichas.ComprovanteEntrada.Viewer(CurrentVenda);
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void ddlTipoBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ddlTipoBusca.Text)
            {
                case "Codigo":
                    labelValor.Text = @"Informe o Código";
                    break;
                case "Cpf":
                    labelValor.Text = @"Informe o Cpf / Cnpj";
                    break;
                case "Nome":
                    labelValor.Text = @"Nome do Cliente / Modelo";
                    break;
                default:
                    break;
            }
        }

        private void indiquePlusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentVenda == 0)
                {
                    MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
                }
                else
                {
                    Venda = LibVenda.GetById(CurrentVenda);
                    Atendimento = LibAtendimento.GetById(Venda.IdAtendimento);

                    var frm = new Telas.Movimentacoes.Atendimento.Edita(Atendimento, EnumConvenioTipo.PosVenda);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }

            
        }

        #endregion

        #region METODOS

        private void CarregaGridAtendimentos()
        {
            dgvAtendimentos.DataSource = LibAtendimento.CarregaGrid(Clientes);
        }

        private void BuscaClientes()
        {
            var value = ddlTipoBusca.SelectedItem.ToString();
            var selected = (TipoBusca)Enum.Parse(typeof(TipoBusca), value);

            switch (selected)
            {
                case TipoBusca.Codigo:
                    Clientes = (LibAtendimento.GetByCodigoReduzidoAndFilial(int.Parse(tbBusca.Text.Trim()), Session.Contexto.IdFilial));
                    break;
                case TipoBusca.Cpf:
                    Clientes = LibAtendimento.GetByCpfAndFilial(tbBusca.Text.Trim(), Session.Contexto.IdFilial);
                    break;
                case TipoBusca.Nome:
                    Clientes = LibAtendimento.GetByNomeAndFilial(tbBusca.Text.Trim(), Session.Contexto.IdFilial);
                    break;
                default:
                    Clientes = LibAtendimento.GetByNomeAndFilial(tbBusca.Text.Trim(), Session.Contexto.IdFilial);
                    break;
            }
        }

        private void CarregaTipoBusca()
        {
            ddlTipoBusca.Items.Clear();
            ddlTipoBusca.Items.AddRange(Enum.GetNames(typeof(TipoBusca)));
        }

        private void CarregaVendas()
        {
            try
            {
                var vendas = LibVenda.GetByAtendimento(SelectedAtend, Session.Contexto.IdFilial);
                Vendas = new BindingList<Lib.Model.Venda>(LibVenda.CarregaGridModel(vendas));
                dgvVendas.DataSource = Vendas;
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void SelecteGrid()
        {
            if (Vendas.Count > 0)
            {
                dgvVendas.Rows[Vendas.IndexOf(Vendas.LastOrDefault())].Selected = true;
                dgvVendas.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void AddNewVenda()
        {

            if (Atendimento == null)
                throw new Exception("Nenhum Atendimento Selecionado");

            var venda = new Dados.Venda
            {
                IdCliFor = Atendimento.IdCliFor,
                IdFilial = Session.Contexto.IdFilial,
                IdAtendimento = Atendimento.IdAtendimento,
                IdUsuario = Session.Contexto.IdUsuario,
                Data = DateTime.Now,
                Status = EnumStatusVenda.NaoFinalizado,
                IsAtivo = true,
                IsConfirmado = false
            };

            Inserted = LibVenda.Insert(venda);
            CarregaVendas();
            CarregaEdita(venda.IdPedido);

        }

        private void CarregaEdita(int idVenda)
        {
            if (CurrentVenda == 0)
                throw new Exception("Nehum registro selecionado");

            var frm = new Principal.Principal(idVenda);
            frm.ShowDialog();

            CarregaVendas();
        }

        #endregion

        

        

        

        
    }
}

