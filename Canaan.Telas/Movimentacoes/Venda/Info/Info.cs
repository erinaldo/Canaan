using System;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Lib.Utilitarios;
using Canaan.Relatorios.Fichas.Servicos;
using Canaan.Telas.Base;
using Canaan.Telas.Cadastros.ClienteFornecedor;
using CliFor = Canaan.Dados.CliFor;
using PessoaFisica = Canaan.Dados.PessoaFisica;
using PessoaJuridica = Canaan.Dados.PessoaJuridica;

namespace Canaan.Telas.Movimentacoes.Venda.Info
{
    public partial class Info : FormVendaBase
    {
        #region PROPRIEDADES

        public Dados.Atendimento Atendimento { get; set; }

        public Dados.Venda Venda { get; set; }

        public Dados.Agendamento Agendamento { get; set; }

        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }

        public CliFor ClienteTroca { get; set; }

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

        #region Libs

        public Lib.CliFor LibCliFor
        {
            get
            {
                return new Lib.CliFor();
            }
        }

        public Convenio LibConvenio
        {
            get
            {
                return new Convenio();
            }
        }

        public Parceria LibParceria
        {
            get
            {
                return new Parceria();
            }
        }

        public Carta LibCarta
        {
            get
            {
                return new Carta();
            }
        }

        public Lib.Venda LibVenda
        {
            get
            {
                return new Lib.Venda();
            }
        }

        public Lib.Agendamento LibAgendamento
        {
            get
            {
                return new Lib.Agendamento();
            }
        }

        #endregion

        #region Cliente Atendimento

        public CliFor CliForAtendimento { get; set; }

        public PessoaFisica PessoaFisicaAtendimento
        {
            get
            {
                return CliForAtendimento as PessoaFisica;
            }
        }

        public PessoaJuridica PessoaJuridicaAtendimento
        {
            get
            {
                return CliForAtendimento as PessoaJuridica;
            }
        }

        #endregion

        #region Cliente Financeiro

        public CliFor CliForFinanceiro { get; set; }

        public PessoaFisica PessoaFisicaFinanceiro
        {
            get
            {
                return CliForFinanceiro as PessoaFisica;
            }
        }

        public PessoaJuridica PessoaJuridicaFinanceiro
        {
            get
            {
                return CliForFinanceiro as PessoaJuridica;
            }
        }

        #endregion

        #endregion

        #region CONSTRUTORES

        public Info()
        {
            InitializeComponent();
        }

        public Info(Dados.Atendimento atendimento, Dados.Venda venda)
        {
            Atendimento = atendimento;
            Venda = venda;

            CliForAtendimento = LibCliFor.GetById(Atendimento.IdCliFor);
            CliForFinanceiro = LibCliFor.GetById(Venda.IdCliFor);
            Agendamento = LibAgendamento.GetById(Atendimento.IdAgendamento);

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Info_Load(object sender, EventArgs e)
        {
            ConfiguraForm();
        }

        private void cbConvenio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Atendimento == null)
                return;

            LoadParcerias();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Atualiza();
        }


        private void btTrocaCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                if (Venda == null)
                {
                    MessageBoxUtilities.MessageWarning("Nenhuma venda selecionada");
                }
                else
                {
                    var frmCliente = new Cadastros.ClienteFornecedor.Wizard();
                    frmCliente.ShowDialog();

                    if (frmCliente.CliFor != null)
                    {
                        ClienteTroca = frmCliente.CliFor;

                        if (ClienteTroca != null)
                        {
                            if (MessageBoxUtilities.MessageQuestion(string.Format("Deseja salvar {0} como cliente financeiro para está venda?", ClienteTroca.Nome)) == DialogResult.Yes)
                            {
                                Venda.IdCliFor = ClienteTroca.IdCliFor;
                                LibVenda.Update(Venda);

                                CliForFinanceiro = LibCliFor.GetById(Venda.IdCliFor);

                                ConfiguraForm();

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

        private void serviçosContratadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Viewer(Venda.IdPedido);
            frm.ShowDialog();
        }

        private void envelopesDeServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Fichas.Envelope.Viewer(Venda.IdPedido);
            frm.ShowDialog();
        }

        private void boletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Fichas.Boleto.Viewer(Venda.IdPedido);
            frm.ShowDialog();
        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Fichas.Contrato.Viewer(Venda.IdPedido);
            frm.ShowDialog();
        }

        private void termoDeAditamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Fichas.Aditamento.Viewer(Venda.IdPedido);
            frm.ShowDialog();
        }

        private void conprovanteDeEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region METODOS

        private void ConfiguraForm()
        {
            try
            {
                SetLabelsAtendimento();
                SetCombos();
                CanUpdate();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void CanUpdate()
        {

            if (Comum.CanUpdateVenda(Venda))
            {
                panelInfo.Enabled = true;
                toolstripActions.Enabled = true;
            }
            else
            {
                panelInfo.Enabled = false;
                toolstripActions.Enabled = false;
            }
        }

        private void SetCombos()
        {
            LoadConvenios();
            LoadParcerias();
            LoadCartas();

            //Seleciona item combo box
            cbConvenio.SelectedValue = Atendimento.Agendamento.Cupom.Parceria.IdConvenio;
            cbParceria.SelectedValue = Atendimento.Agendamento.Cupom.IdParceria;
            cbCarta.SelectedValue = Atendimento.Agendamento.IdCarta != null ? Atendimento.Agendamento.IdCarta : LibCarta.GetDefault().IdCarta;
        }

        private void LoadConvenios()
        {
            var result = LibConvenio.GetByAtivo(true);

            cbConvenio.DisplayMember = "Nome";
            cbConvenio.ValueMember = "IdConvenio";
            cbConvenio.DataSource = result;

            cbConvenio.SelectedValue = Venda.Atendimento.Agendamento.Cupom.Parceria.Convenio.IdConvenio;

        }

        private void LoadParcerias()
        {
            if (cbConvenio.SelectedValue == null)
                return;

            var result = LibParceria.GetByConvenio(int.Parse(cbConvenio.SelectedValue.ToString()));

            cbParceria.DisplayMember = "Nome";
            cbParceria.ValueMember = "IdParceria";
            cbParceria.DataSource = result;

            cbParceria.SelectedValue = Venda.Atendimento.Agendamento.Cupom.IdParceria;
        }

        private void LoadCartas()
        {
            var result = LibCarta.GetByAtivo(true);

            cbCarta.DisplayMember = "Nome";
            cbCarta.ValueMember = "IdCarta";
            cbCarta.DataSource = result;
        }

        private void SetLabelsAtendimento()
        {
            cLbEstudio.Text = Atendimento.Filial.NomeFantasia;
            cLbCodAtendimento.Text = Venda.IdPedido.ToString();
            cLbCodPacote.Text = Atendimento.CodigoReduzido.ToString();
            cLbAtendenteResponsavel.Text = Atendimento.Usuario.Nome;
            cLbCliente.Text = PessoaFisicaAtendimento.Nome;
            cLbResponsavelFinanceiro.Text = PessoaFisicaFinanceiro.Nome;

            cLbDataAtendimento.Text = Atendimento.Data.ToShortDateString();
            cLbDataEnvio.Text = Venda.DataLiberacao.GetValueOrDefault().ToShortDateString() == "01/01/0001" ? string.Empty : Venda.DataLiberacao.GetValueOrDefault().ToShortDateString();

            //Verificar
            cLbDataEntrega.Text = string.Empty;
            cLbDataRecebimento.Text = string.Empty;

            //Verificar criação de um campo e parametrização via config para permitir liberação gerencial. // Job
            cLbStatusPedido.Text = Venda.Status.ToString();
        }

        private void Atualiza()
        {
            try
            {
                if (LibVenda.CanUpdate(Venda.Status))
                {
                    Agendamento.IdCarta = int.Parse(cbCarta.SelectedValue.ToString());
                    LibAgendamento.UpdateCarta(Agendamento);

                    MessageBoxUtilities.MessageInfo("Venda atualizada com sucesso");
                }
                else
                {
                    MessageBoxUtilities.MessageWarning(string.Format("Venda com status {0} não pode ser alterada.", Venda.Status.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        #endregion

    }
}
