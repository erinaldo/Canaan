using System;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Lib.Utilitarios;
using Canaan.Relatorios.Fichas.Boleto;
using Canaan.Telas.Base;
using Config = Canaan.Lib.Config;
using FormaPgto = Canaan.Lib.FormaPgto;
using Lancamento = Canaan.Lib.Lancamento;
using Usuario = Canaan.Lib.Usuario;

namespace Canaan.Telas.Movimentacoes.Venda.Documentacao
{
    public partial class Documentacao : FormVendaBase
    {
        #region PROPRIEDADES

        private Dados.Venda Venda;

        private Principal.Principal principal;

        public Lib.Venda LibVenda
        {
            get
            {
                return new Lib.Venda();
            }
        }

        public Usuario LibUsuario
        {
            get
            {
                return new Usuario();
            }
        }

        public Lancamento LibLancamento
        {
            get
            {
                return new Lancamento();
            }
        }

        public Lib.Atendimento LibAtendimento 
        {
            get 
            {
                return new Lib.Atendimento();
            }
        }

        public Lib.Config LibConfig
        {
            get { return new Lib.Config(); }

        }

        #endregion

        #region CONSTRUTORES

        public Documentacao(Dados.Venda Venda, Principal.Principal principal)
        {
            this.Venda = Venda;
            this.principal = principal;

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Documentacao_Load(object sender, EventArgs e)
        {
            CanUpdate();
            CarregaVendedoras();
            DesabilitaBotoes();
        }

        private void btnBoleto_Click(object sender, EventArgs e)
        {
            AlteraVendedora();

            var frm = new Viewer(Venda.IdPedido);
            frm.ShowDialog();
        }

        private void btnEnvelope_Click(object sender, EventArgs e)
        {
            AlteraVendedora();

            var frm = new Relatorios.Fichas.Envelope.Viewer(Venda.IdPedido);
            frm.ShowDialog();
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            AlteraVendedora();

            var frm = new Relatorios.Fichas.Servicos.Viewer(Venda.IdPedido);
            frm.ShowDialog();

        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            AlteraVendedora();

            var frm = new Relatorios.Fichas.Contrato.Viewer(Venda.IdPedido);
            frm.ShowDialog();
        }

        private void btLiberarVenda_Click(object sender, EventArgs e)
        {
            var frm = new Tipo.Tipo();
            frm.ShowDialog();

            FinalizaVenda(frm.TipoVenda);
            CriaAgendamento();
        }

        private void btAditamento_Click(object sender, EventArgs e)
        {
            AlteraVendedora();

            var frm = new Relatorios.Fichas.Aditamento.Viewer(Venda.IdPedido);
            frm.ShowDialog();
        }

        private void cbVendedoras_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnComprovante_Click(object sender, EventArgs e)
        {
            AlteraVendedora();

            var frm = new Relatorios.Fichas.ComprovanteEntrada.Viewer(Venda.IdPedido);
            frm.Show();
        }

        private void btnControlePgto_Click(object sender, EventArgs e)
        {
            AlteraVendedora();

            var frm = new Relatorios.Fichas.ControlePgto.Viewer(Venda.IdPedido);
            frm.Show();
        }

        private void btnIndiquePlus_Click(object sender, EventArgs e)
        {
            var atendimento = LibAtendimento.GetById(Venda.IdAtendimento);

            var frm = new Telas.Movimentacoes.Atendimento.Edita(atendimento, EnumConvenioTipo.PosVenda);
            frm.ShowDialog();
        }

        #endregion

        #region METODOS

        private void CarregaVendedoras()
        {
            var vendedoras = LibUsuario.GetVendedoras(Session.Instance.Contexto.IdFilial);

            cbVendedoras.DisplayMember = "FullName";
            cbVendedoras.ValueMember = "IdUsuario";
            cbVendedoras.DataSource = vendedoras;

            if (Venda.IdUsuario != null)
                cbVendedoras.SelectedValue = Venda.IdUsuario;
        }

        private void DesabilitaBotoes()
        {
            var config = LibConfig.GetByFilial(Session.Instance.Contexto.IdFilial);

            if (config.UsaMenuSimplificado == true)
            {
                btnComprovante.Visible = false;
                btnServicos.Visible = false;
                btAditamento.Visible = false;
                btnIndiquePlus.Visible = false;
                btnBoleto.Visible = false;
            }
        }

        private void CanUpdate()
        {
            if (Comum.CanUpdateVenda(Venda))
            {
                toolstripActions.Enabled = true;
            }
            else
            {
                toolstripActions.Enabled = false;
            }
        }

        private void AlterarStatusVenda()
        {
            if (Venda.Status == EnumStatusVenda.NaoFinalizado)
            {
                Venda.Status = EnumStatusVenda.AFaturar;
                LibVenda.Update(Venda);
            }
        }

        private void AlteraVendedora()
        {
            if (Venda.IdUsuario != (int)cbVendedoras.SelectedValue)
            {
                if (MessageBoxUtilities.MessageQuestionWarning("Tem certeza que deseja alterar a vendedora para " + cbVendedoras.Text + "?") == DialogResult.Yes)
                {
                    Venda.IdUsuario = (int)cbVendedoras.SelectedValue;
                    LibVenda.Update(Venda);
                    MessageBoxUtilities.MessageInfo("Vendedora alterada com sucesso");
                }
                else
                {
                    cbVendedoras.SelectedValue = Venda.IdUsuario;
                }
            }
        }

        private bool VerificaParcelas()
        {
            //carrega os lancamentos
            var libLanc = new Lancamento();
            var lanc = libLanc.GetByPedido(Venda.IdPedido);

            //carrega a forma de pagamento
            var libPgto = new FormaPgto();
            var formapgto = libPgto.GetById(Venda.IdFormaPgto.GetValueOrDefault());

            //verifica se é venda a vista
            if (formapgto.NumParcela <= 1)
            {
                //verifica tem parcela
                if (lanc.Count > 1)
                {
                    return false;
                }
                return true;
            }

            if (lanc.Count == formapgto.NumParcela)
            {
                return true;
            }

            return false;
        }

        private void FinalizaVenda(TipoVenda tipoVenda)
        {
            try
            {
                if (VerificaParcelas())
                {
                    if (string.IsNullOrEmpty(tipoVenda.ToString()) || tipoVenda.ToString().Equals("0"))
                        return;

                    if (LibVenda.ValidaPedidos(Venda))
                    {
                        var tipo = UtilityEnum.GetEnumDescription(tipoVenda.ToString(), typeof(TipoVenda));

                        if (MessageBoxUtilities.MessageQuestion(string.Format("Deseja finalizar esta venda como {0} ?", tipo)) == DialogResult.Yes)
                        {
                            // Limpa campos do caderno do cmaster
                            LimpaCamposCaderno();

                            //atualiza o status da venda
                            switch (tipoVenda)
                            {
                                case TipoVenda.ComEntrada:
                                    Venda.Status = EnumStatusVenda.AFaturar;
                                    break;
                                case TipoVenda.SemEntrada:
                                    Venda.Status = EnumStatusVenda.AFaturar;
                                    break;
                                case TipoVenda.AVista:
                                    Venda.Status = EnumStatusVenda.AFaturar;
                                    break;
                                case TipoVenda.Cortesia:
                                    Venda.Status = EnumStatusVenda.AFaturar;
                                    break;
                                case TipoVenda.ConcursoGaleria:
                                    Venda.Status = EnumStatusVenda.AFaturar;
                                    break;
                                case TipoVenda.Acompanhamento:
                                    Venda.Status = EnumStatusVenda.AFaturar;
                                    break;
                                default:
                                    break;
                            }

                            //atualiza a data da venda
                            Venda.DataVenda = DateTime.Now;
                            Venda.IdUsuario = int.Parse(cbVendedoras.SelectedValue.ToString());

                            Venda.IsConfirmado = true;
                            Venda.DataConfirmacao = DateTime.Now;

                            Venda.DataDevolucao = null;
                            Venda.IsDevolvida = false;

                            Venda.TipoVenda = (int)tipoVenda;

                            //atualiza a venda
                            LibVenda.Update(Venda);

                            //abre tela de liberacao
                            var config = this.LibConfig.GetByFilial(Venda.IdFilial);

                            if (config.UsaLiberacao == false)
                            {
                                var frmLiberacao = new Rotinas.Liberacao.Detalhes.DetalhesLiberacao(Venda.IdPedido, false);
                                frmLiberacao.ShowDialog();
                            }
                            
                            MessageBoxUtilities.MessageInfo(string.Format("Venda Finalizada como {0} ", tipo));
                            principal.Close();
                        }
                    }
                    else
                    {
                        MessageBoxUtilities.MessageWarning("Existem pedidos sem foto selecionada");
                    }

                }
                else
                {
                    MessageBox.Show(@"Verifique a forma de pagamento escolhida e as parcelas");
                }
            }
            catch (Exception ex)
            {

                MessageBoxUtilities.MessageError(null, ex);
            }

        }

        private void LimpaCamposCaderno()
        {
            Venda.EntradaCartao = 0;
            Venda.EntradaDepositada = 0;
            Venda.EntradaDinheiro = 0;

            Venda.VendaCartao = 0;
            Venda.VendaDinheiro = 0;
        }

        private void AtualizaStatusLancamentos()
        {
            var config = new Config().GetByFilial(Session.Instance.Contexto.IdFilial);

            //faz loop nos lancamentos
            foreach (var item in Venda.Lancamento.Where(item => item.Status == EnumStatusLanc.AguardandoLiberacao))
            {
                //seta lancamento em aberto
                item.Status = EnumStatusLanc.EmAberto;

                //salva atualizacao do lancamento
                LibLancamento.Update(item);
            }
        }

        private void CriaAgendamento()
        {
            var vendaEventos = new Lib.VendaEvento().GetByVenda(this.Venda.IdPedido);

            if (vendaEventos.Count > 0)
            {
                var agenda = new Lib.Agenda().GetByFilial(true, this.Venda.IdFilial);

                foreach (var item in vendaEventos)
                {
                    var vendaEvento = new Lib.VendaEvento().GetById(item.IdVendaEvento);
                    var agendamento = new Lib.Agendamento().GetByVendaEvento(item.IdVendaEvento);

                    if (vendaEvento.IsAgendamento == true)
                    {
                        //verifica se agendamento ja existe
                        if (agendamento == null)
                        {
                            NovoAgendamento(agenda, vendaEvento);
                        }
                        else
                        {
                            AlteraAgendamento(agendamento, vendaEvento);
                        }
                    }

                    
                }
                //var msg = "Deseja incluir os Eventos / Acompanhamentos na agenda?";

                //if (MessageBox.Show(msg, "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                //{


                //    MessageBox.Show("Agendamentos atualizados com sucesso");
                //}
            }
        }

        private Dados.Agendamento NovoAgendamento(Dados.Agenda agenda, Dados.VendaEvento vendaEvento)
        {
            //cria o cupom
            var cupom = new Dados.Cupom
            {
                IdParceria = vendaEvento.Evento.IdParceria,
                IdUsuario = Lib.Session.Instance.Usuario.IdUsuario,
                Data = DateTime.Now,
                DataPreenchimento = DateTime.Now,
                Status = EnumCupomStatus.Agendado,
                Nome = this.Venda.CliFor.Nome,
                Telefone = this.Venda.CliFor.Telefone,
                Celular = this.Venda.CliFor.Celular,
                Email = this.Venda.CliFor.Email,
                Obs = vendaEvento.Descricao,
                IsAtivo = true,
                UltimaUtilizacao = DateTime.Now,
                IsAgendado = true,
                DataAgendado = DateTime.Now,
                IsDescartado = false,
                IsLembrete = false,
                IdCupomWeb = vendaEvento.IdVendaEvento
            };
            cupom = new Lib.Cupom().Insert(cupom);

            //cria o agendamento
            var agendamento = new Dados.Agendamento
            {
                IdCupom = cupom.IdCupom,
                IdAgenda = agenda.IdAgenda,
                Status = EnumAgendamentoStatus.Agendado,
                Inicio = vendaEvento.DataInicio,
                Termino = vendaEvento.DataFim,
                Observacao = vendaEvento.Descricao,
                Modelo = this.Venda.CliFor.Nome,
            };

            agendamento = new Lib.Agendamento().Insert(agendamento);

            return agendamento;
        }

        private Dados.Agendamento AlteraAgendamento(Dados.Agendamento agendamento, Dados.VendaEvento vendaEvento)
        {
            agendamento.Status = EnumAgendamentoStatus.Agendado;
            agendamento.Inicio = vendaEvento.DataInicio;
            agendamento.Termino = vendaEvento.DataFim;
            agendamento.Observacao = vendaEvento.Descricao;
            agendamento.Modelo = this.Venda.CliFor.Nome;

            agendamento = new Lib.Agendamento().Update(agendamento);

            return agendamento;
        }

        #endregion

        private void btnFichaCliente_Click(object sender, EventArgs e)
        {
            var frmRecibo = new Relatorios.Fichas.Recibo.Viewer(Venda.IdPedido);
            frmRecibo.Show();
        }
    }
}
