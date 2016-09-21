using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Lib.Model;
using Canaan.Lib.Utilitarios;
using Canaan.Telas.Movimentacoes.Venda.Principal;
using Canaan.Telas.Properties;
using Atendimento = Canaan.Dados.Atendimento;
using CliFor = Canaan.Dados.CliFor;
using CliForReferencia = Canaan.Lib.CliForReferencia;
using Config = Canaan.Lib.Config;
using Envio = Canaan.Lib.Envio;
using Lancamento = Canaan.Lib.Lancamento;
using MotivoDevolucao = Canaan.Lib.MotivoDevolucao;
using OrdemServico = Canaan.Lib.OrdemServico;
using PessoaFisica = Canaan.Dados.PessoaFisica;
using Venda = Canaan.Dados.Venda;
using VendaItem = Canaan.Lib.Model.VendaItem;
using VendaMov = Canaan.Lib.VendaMov;

namespace Canaan.Telas.Rotinas.Liberacao.Detalhes
{
    public partial class DetalhesLiberacao : Form
    {
        #region PROPRIEDADES
        
        public bool Conferencia { get; set; }

        public Venda Venda { get; set; }

        public Atendimento Atendimento { get; set; }

        public CliFor Cliente { get; set; }

        public CliFor ClienteFinanceiro { get; set; }

        public List<VendaItem> ItensVenda { get; set; }

        public List<VendaMovModel> VendasMov { get; set; }

        public List<MotivoDevolucaoModel> MotivosDevolucao { get; set; }

        public int SelectedMov 
        { 
            get
            {
                if (dataGridDevolucoes.SelectedRows.Count <= 0)
                    return 0;

                return int.Parse(dataGridDevolucoes.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        
        #region LIBS

        public VendaMov LibVendaMov
        {
            get
            {
                return new VendaMov();
            }
        }

        public MotivoDevolucao LibMotivoDevolucao
        {
            get
            {
                return new MotivoDevolucao();
            }
        }

        public Envio LibEnvio
        {
            get
            {
                return new Envio();
            }
        }

        public Lib.Atendimento LibAtendimento
        {
            get
            {
                return new Lib.Atendimento();
            }
        }

        public Lib.CliFor LibViewCliFor
        {
            get
            {
                return new Lib.CliFor();
            }
        }

        public Lib.VendaItem LibVendaItem
        {
            get
            {
                return new Lib.VendaItem();
            }
        }

        public OrdemServico LibOrdens
        {
            get
            {
                return new OrdemServico();
            }
        }

        public Lib.Venda LibVenda
        {
            get
            {
                return new Lib.Venda();
            }
        }

        public VendaItem SelectedVendaItem
        {
            get
            {
                return dataGrid.CurrentRow.DataBoundItem as VendaItem;
            }
        }

        public List<OrdermServico> Envelopes { get; set; }

        public CliForReferencia LibReferencia
        {
            get
            {
                return new CliForReferencia();
            }
        }

        public Lancamento LibLancamento
        {
            get
            {
                return new Lancamento();
            }
        }

        #endregion

        #endregion

        #region CONSTRUTOR

        public DetalhesLiberacao(int idVenda, bool Conferencia)
        {
            this.Conferencia = Conferencia;

            //Carrega Venda
            Venda = LibVenda.GetById(idVenda);

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void DetalhesLiberacao_Load(object sender, EventArgs e)
        {
            lbEmancipado.Text = string.Empty;
            datagridMotivos.AutoGenerateColumns = false;
            dataGridDevolucoes.AutoGenerateColumns = false;

            InitData();
            InitForm();
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectedVendaItem != null)
            {
                Envelopes = LibOrdens.GetByVendaItemInModel(SelectedVendaItem.IdVenda);
                dataGridEnvelope.DataSource = Envelopes;
            }
        }

        private void BtDevolver_Click(object sender, EventArgs e)
        {
            ExecutaDevolucao();
        }

        private void btLiberar_Click(object sender, EventArgs e)
        {
            ExecutaLiberacao();
        }
        
        private void btConferir_Click(object sender, EventArgs e)
        {
            ExecutaConferencia();
        }       

        private void btCorrigir_Click(object sender, EventArgs e)
        {
            var frm = new Principal(Venda.IdPedido);
            frm.ShowDialog();
        }

        private void dataGridDevolucoes_SelectionChanged(object sender, EventArgs e)
        {
            MotivosDevolucao = LibMotivoDevolucao.GetByIdMov(SelectedMov);
            datagridMotivos.DataSource = MotivosDevolucao;
        }

        #endregion

        #region METODOS

        private void InitForm()
        {
            //Verifica se pode liberar
            ConfiguraPermissoesLiberacao();

            dataGrid.AutoGenerateColumns = false;
            dataGridEnvelope.AutoGenerateColumns = false;
            dataGridReferencia.AutoGenerateColumns = false;
            dataGridLanc.AutoGenerateColumns = false;

            //Labels Dados Gerais
            InitLabelsGerais();
            InitLabesInformacoesCliente();
            InitLabelsFinanceiro();
            InitReferencias();

            dataGrid.DataSource = ItensVenda;
            dataGridDevolucoes.DataSource = VendasMov;
            datagridMotivos.DataSource = MotivosDevolucao;

            panelActions.Enabled = true;



            var cliente = Cliente as PessoaFisica;

            if(cliente != null)
            {
                var idade = Comum.CalculaIdade(cliente.Nascimento);

                if(idade < 18)
                {
                    lbEmancipado.Text = "Solicitar documentação de emancipação";
                }
            }
        }

        private void ConfiguraPermissoesLiberacao()
        {
            btLiberar.Enabled = true;
        }

        private void InitLabelsFinanceiro()
        {
            lbValorProduto.Text = Venda.ValorBruto.GetValueOrDefault().ToString("c");
            lbValorJuro.Text = Venda.ValorAcrescimo.GetValueOrDefault().ToString("c");
            lbPorcentagemJuros.Text = Lancamento.CalculaPorcentagemOfValue(Venda.ValorAcrescimo.GetValueOrDefault(), Venda.ValorBruto.GetValueOrDefault()).ToString("#.##");

            lbValorDesconto.Text = Venda.ValorDesconto.GetValueOrDefault().ToString("c");
            lbPorcentagemDesconto.Text = Lancamento.CalculaPorcentagemOfValue(Venda.ValorDesconto.GetValueOrDefault(), Venda.ValorBruto.GetValueOrDefault()).ToString("#.##");

            lbValorTotal.Text = Venda.ValorLiquido.GetValueOrDefault().ToString("c");
            lbValorEntrada.Text = Venda.ValorEntrada.GetValueOrDefault().ToString("c");
            lbValorRestante.Text = (Venda.ValorLiquido - Venda.ValorEntrada).GetValueOrDefault().ToString("c");

            lbFormaEntrada.Text = Venda.FormaEntrada == null ? string.Empty : Venda.FormaEntrada.Nome.ToUpper();
            lbFormaPagamento.Text = Venda.FormaPgto == null ? string.Empty : Venda.FormaPgto.Nome.ToUpper();


            var dataEntrada = LibLancamento.GetByPedido(Venda.IdPedido).Where(a => a.IsEntrada)
                                                                          .OrderBy(a => a.DataVencimento)
                                                                          .FirstOrDefault();

            lbDataEntrada.Text = dataEntrada == null ? string.Empty : dataEntrada.DataVencimento.ToShortDateString();

            //Inicializa Parcelas
            InitParcelas();
        }

        private void InitParcelas()
        {
            var result = LibLancamento.GetByPedido(Venda.IdPedido);

            var parcelas = new BindingList<Lib.Model.Lancamento>(result.Select(a => new Lib.Model.Lancamento
            {
                ClasseContabil = a.ClasseContabil,
                IdFilial = a.IdFilial,
                Filial = a.Filial.NomeFantasia,
                IdCliFor = a.IdCliFor,
                Cliente = ClienteFinanceiro.Nome,
                DataVencimento = a.DataVencimento,
                DataEmissao = a.DataEmissao,
                IdLan = a.IdLancamento,
                IdPedido = a.IdPedido.GetValueOrDefault(),
                DataAgendamento = a.DataAgendamento.GetValueOrDefault(),
                Tipo = EnumLancTipo.Receber,
                TipoParcela = a.IsEntrada ? Resources.money2 : Resources.money_envelope,
                ValorAcrescimo = a.ValorAcrescimo,
                ValorDesconto = a.ValorDesconto,
                ValorLiquido = a.ValorLiquido,
                ValorOriginal = a.ValorOriginal

            }).ToList());

            dataGridLanc.DataSource = parcelas;
        }

        private void InitReferencias()
        {
            var result = LibReferencia.GetByCliente(Cliente.IdCliFor);
            dataGridReferencia.DataSource = result;
        }

        private void InitLabesInformacoesCliente()
        {
            lbClienteComercial.Text = Cliente.Nome.ToUpper();
            lbClienteFinanceiro.Text = ClienteFinanceiro.Nome.ToUpper();


            var pessoaFisica = Cliente as PessoaFisica;

            if (pessoaFisica != null)
            {
                var nomePai = pessoaFisica.NomePai == null ? string.Empty : pessoaFisica.NomePai;
                var nomeMae = pessoaFisica.NomeMae == null ? string.Empty : pessoaFisica.NomeMae;

                lbSexo.Text = string.IsNullOrEmpty(pessoaFisica.Sexo.ToString()) ? string.Empty : pessoaFisica.Sexo.ToString().ToUpper();
                lbFiliacao.Text = nomeMae + " e " + nomePai;
                lbDataNasc.Text = string.IsNullOrEmpty(pessoaFisica.Nascimento.ToString()) ? string.Empty : pessoaFisica.Nascimento.ToString("d").ToUpper();
                lbRG.Text = string.IsNullOrEmpty(pessoaFisica.Rg) ? string.Empty : pessoaFisica.Rg.ToUpper();
                lbConjuje.Text = string.IsNullOrEmpty(pessoaFisica.Conjuge) ? string.Empty : pessoaFisica.Conjuge.ToUpper();
            }


            lbEndereco.Text = Cliente.Endereco == null ? string.Empty : Cliente.Endereco.ToUpper();
            lbBairro.Text = Cliente.Endereco == null ? string.Empty : Cliente.Bairro.ToUpper();
            lbCidade.Text = Cliente.Cidade.Nome.ToUpper();
            lbEstado.Text = Cliente.Cidade.Estado.Nome.ToUpper();
            lbCep.Text = Cliente.Cep == null ? string.Empty : Cliente.Cep.ToUpper();

            lbEmail.Text = Cliente.Email == null ? string.Empty : Cliente.Email.ToUpper();
            lbTelefone.Text = Cliente.Telefone == null ? string.Empty : Cliente.Telefone.ToUpper();
            lbCelular.Text = Cliente.Celular == null ? string.Empty : Cliente.Celular.ToUpper();

            lbCPF.Text = Cliente.Documento == null ? string.Empty : Cliente.Documento;
        }

        private void InitLabelsGerais()
        {
            lbCodAtendimento.Text = Atendimento.CodigoReduzido.ToString();
            lbCodVenda.Text = Venda.IdPedido.ToString();
            lbDataVenda.Text = Venda.Data.ToString("d");
            lbVendedora.Text = Venda.Usuario == null ? string.Empty : Venda.Usuario.Nome;
            lbStatusLabel.Text = Venda.Status.ToString();
        }

        private void InitData()
        {
            Atendimento = LibAtendimento.GetById(Venda.IdAtendimento);
            Cliente = LibViewCliFor.GetById(Venda.Atendimento.IdCliFor);
            ClienteFinanceiro = LibViewCliFor.GetById(Venda.IdCliFor);
            ItensVenda = LibVendaItem.CarregaGrid(LibVendaItem.GetByVenda(Venda.IdPedido)) as List<VendaItem>;
            VendasMov = LibVendaMov.GetDevolucoes(Venda.IdPedido);
        }

        private void ExecutaConferencia()
        {
            if (MessageBoxUtilities.MessageQuestion("Deseja conferir esta venda ?. Se executar esta ação esta venda não poderá ser alterada sem devolução do escritorio.") == DialogResult.Yes)
            {
                if (Venda.ValorLiquido == null)
                {
                    MessageBoxUtilities.MessageWarning("O valor liquido na venda não é válido. Favor corrigir venda");
                }
                else
                {
                    Venda.IsConfirmado = true;
                    Venda.DataConfirmacao = DateTime.Now;
                    LibVenda.Update(Venda);
                    MessageBoxUtilities.MessageInfo(string.Format("Venda do código {0} conferida com sucesso.", Venda.Atendimento.CodigoReduzido));
                }
            }
        }

        private void ExecutaLiberacao()
        {
            try
            {
                //Atualiza dados da venda
                Venda.DataLiberacao = DateTime.Now;
                Venda.IsLiberado = true;

                //se a filial nao utiliza o financeiro marca venda como faturada
                var config = new Config().GetByFilial(Session.Instance.Contexto.IdFilial);

                //atualiza dados do faturamento
                Venda.IsFaturado = true;
                Venda.DataFaturamento = DateTime.Now;
                Venda.Status = EnumStatusVenda.Faturado;

                //Atualiza Venda
                LibVenda.Update(Venda);

                //Atualiza Status Envelopes
                UpdateServicos();

                //atualiza lancamentos
                UpdateLancamentos();

                //Adiciona No envio
                LibEnvio.Insert(Venda);

                //verifica se efetua a baixa da entrada
                if (config.UsaBaixaEntrada == true)
                {
                    BaixaEntrada();
                }

                //panelActions.Enabled = false;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void ExecutaDevolucao()
        {
            try
            {
                //armazena status
                var currStatus = Venda.Status;

                //motivos de devolucao
                var frm = new Devolucao.MotivoDevolucao();
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                {
                    if (frm.MotivosDevolucao.Count > 0)
                    {
                        //devolve a venda
                        DevolveVenda();

                        //devolve os lancamentos financeiro em aberto
                        DevolveLancamento();

                        //Retorna ultima movimentação de uma venda 
                        var lastMov = LibVendaMov.GetLastMov(Venda.IdPedido, EnumStatusVenda.Devolvido);


                        foreach (var item in frm.MotivosDevolucao)
                        {
                            item.IdVendaMov = lastMov.IdMov;
                            LibMotivoDevolucao.Insert(item);
                        }

                        //Devolve venda Caderno Online
                        //vao devolve programada no caderno
                        if (currStatus != EnumStatusVenda.Programada) 
                        {
                            //seleciona data do caderno
                            var frmData = new Movimentacoes.Venda.Documentacao.Caderno.SelecionaData();
                            frmData.ShowDialog();
                        }


                        MessageBoxUtilities.MessageInfo("Venda devolvida com sucesso");

                        //Verifica se pode liberar
                        ConfiguraPermissoesLiberacao();
                    }
                    else
                    {
                        MessageBoxUtilities.MessageWarning("A venda não pode ser devolvida pois não foi selecionado nenhum motivo para liberação");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void DevolveLancamento()
        {
            //devolve os lancamentos financeiros
            foreach (var item in Venda.Lancamento.Where(a => a.Status == EnumStatusLanc.EmAberto))
            {
                item.Status = EnumStatusLanc.AguardandoLiberacao;
                LibLancamento.Update(item);
            }
        }

        private void DevolveVenda()
        {
            //altera devolucao de venda
            Venda.DataDevolucao = DateTime.Now;
            Venda.IsDevolvida = true;
            Venda.Status = EnumStatusVenda.Devolvido;

            Venda.IsConfirmado = false;
            Venda.DataConfirmacao = null;
            Venda.IsFaturado = false;
            Venda.DataFaturamento = null;

            //salva modificacoes da venda
            Venda = LibVenda.Update(Venda);
        }

        private void UpdateLancamentos()
        {
            var lancamentos = LibLancamento.GetByPedido(Venda.IdPedido);

            foreach (var item in lancamentos)
            {
                item.Status = EnumStatusLanc.EmAberto;
                LibLancamento.Update(item);
            }

        }

        private void BaixaEntrada()
        {
            var lancamentos = LibLancamento.GetByPedido(Venda.IdPedido).Where(a => a.ClasseContabil == EnumClasseContabil.Entrada);

            if (lancamentos.Count() > 0)
            {
                var frm = new Financeiro.Lancamento.Baixa(lancamentos.Select(a => a.IdLancamento).ToArray());
                frm.ShowDialog();
            }
        }

        private void UpdateServicos()
        {
            var servicos = LibOrdens.GetByVenda(Venda.IdPedido);

            foreach (var item in servicos)
            {
                item.Status = EnumStatusServico.Envio;
                LibOrdens.Update(item);
            }
        }

        private void InsertMovimentacao() 
        {
            Dados.VendaMov mov = new Dados.VendaMov();
            mov.IdPedido = Venda.IdPedido;
            mov.IdUsuario = Session.Instance.Usuario.IdUsuario;
            mov.Status = Venda.Status;
            mov.Data = DateTime.Now;
        }

        #endregion

    }
}

