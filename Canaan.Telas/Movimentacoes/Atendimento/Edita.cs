using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Relatorios.Fichas.Atendimento;
using DevExpress.XtraScheduler;
using Agenda = Canaan.Lib.Agenda;
using AtendimentoModelo = Canaan.Lib.AtendimentoModelo;
using CliFor = Canaan.Lib.CliFor;
using Cupom = Canaan.Dados.Cupom;
using Filial = Canaan.Lib.Filial;
using Indicacao = Canaan.Lib.Indicacao;
using Modelo = Canaan.Lib.Modelo;
using Parceria = Canaan.Lib.Parceria;
using PessoaFisica = Canaan.Dados.PessoaFisica;
using PessoaJuridica = Canaan.Dados.PessoaJuridica;
using Usuario = Canaan.Lib.Usuario;

namespace Canaan.Telas.Movimentacoes.Atendimento
{
    public partial class Edita : Form
    {
        private Appointment appointment;

        #region PROPRIEDADES

        public bool IsDireto { get; set; }

        public Cupom Cupom { get; set; }

        public Lib.Atendimento LibAtendimento
        {
            get
            {
                return new Lib.Atendimento();
            }
        }
        public Dados.Atendimento ObjAtendimento { get; set; }

        public Lib.Agendamento LibAgendamento
        {
            get { return new Lib.Agendamento(); }
        }
        public Dados.Agendamento Agendamento { get; set; }

        public CliFor LibCliente
        {
            get
            {
                return new CliFor();
            }
        }
        public Dados.CliFor ObjCliente { get; set; }

        public Modelo LibModelo
        {
            get { return new Modelo(); }
        }

        public List<Dados.Modelo> Modelos { get; set; }

        public Indicacao LibIndicacao
        {
            get { return new Indicacao(); }
        }

        public List<Dados.Indicacao> Indicacoes { get; set; }

        public AtendimentoModelo LibAtendimentoModelo
        {
            get { return new AtendimentoModelo(); }
        }

        public List<Dados.AtendimentoModelo> Fichas { get; set; }

        public Filial LibFilial
        {
            get { return new Filial(); }
        }

        public Usuario LibUusuario
        {
            get { return new Usuario(); }
        }

        public bool IsNovo { get; set; }

        public Session Session
        {
            get { return Session.Instance; }
        }

        public int SelectedModel
        {
            get
            {
                if (gridModelos.SelectedRows.Count > 0)
                    return int.Parse(gridModelos.SelectedRows[0].Cells[0].Value.ToString());

                return 0;
            }
        }

        public Lib.Cupom LibCupom
        {
            get
            {
                return new Lib.Cupom();
            }
        }

        public Parceria LibParceria
        {
            get
            {
                return new Parceria();
            }
        }

        public Agenda LibAgenda
        {
            get
            {
                return new Agenda();
            }
        }

        public EnumConvenioTipo TipoConvenio { get; set; }

        #endregion

        #region CONTRUTORES

        public Edita(Dados.Agendamento agendamento)
        {
            TipoConvenio = EnumConvenioTipo.Indicacao;

            InitializeComponent();
            gridFichas.AutoGenerateColumns = false;

            try
            {
                CarregaAgendamento(agendamento.IdAgendamento);
                CarregaAtendimento(agendamento.IdAgendamento);
                CarregaUsuario();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        public Edita(Dados.Atendimento atendimento)
        {
            TipoConvenio = EnumConvenioTipo.Indicacao;

            InitializeComponent();
            gridFichas.AutoGenerateColumns = false;

            try
            {
                CarregaAgendamento(atendimento.IdAgendamento);
                CarregaAtendimento(atendimento.IdAgendamento);
                CarregaUsuario();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        public Edita(Appointment appointment)
        {
            this.appointment = appointment;

            TipoConvenio = EnumConvenioTipo.Indicacao;
            IsNovo = true;
            IsDireto = true;

            InitializeComponent();

            gridFichas.AutoGenerateColumns = false;

            //Habilita seleção de cliente
            HabilitaSelectCliente(true);

            try
            {
                IsNovo = true;

                CarregaUsuario();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        public Edita(Dados.Atendimento atendimento, EnumConvenioTipo pTipoConvenio)
        {
            TipoConvenio = pTipoConvenio;

            InitializeComponent();

            gridFichas.AutoGenerateColumns = false;

            try
            {
                CarregaAgendamento(atendimento.IdAgendamento);
                CarregaAtendimento(atendimento.IdAgendamento);
                CarregaUsuario();

                tbControl.SelectedTabPage = tbIndique;
                tbControl.Update();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Carrega Agendamento vinculado ao atendimento
        /// </summary>
        /// <param name="idAgendamento"></param>
        private void CarregaAgendamento(int idAgendamento)
        {
            Agendamento = LibAgendamento.GetById(idAgendamento);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idAgendamento"></param>
        private void CarregaAtendimento(int idAgendamento = 0, int idCliFor = 0)
        {
            ObjAtendimento = LibAtendimento.GetByIdAgendamento(idAgendamento);

            if (ObjAtendimento != null)
            {
                IsNovo = false;

                //Carrega Modelos do Atendimento
                CarregaModelos();

                //Carrega Indicações
                CarregaIndicacoes();

                //Carrega Modelos para Ficha de Atendimento
                CarregaFicha();

                //Habilita as abas
                HabilitaAbas(true);

            }
            else
            {
                IsNovo = true;

                //carrega cliente
                if (idCliFor == 0)
                {
                    var cliForm = new Telas.Cadastros.ClienteFornecedor.Wizard();
                    cliForm.ShowDialog();
                    ObjCliente = cliForm.CliFor;

                    if (ObjCliente != null && ObjCliente.IdCliFor > 0)
                    {
                        CarregaInfoCliente();
                        CarregaAtendimento(idAgendamento, ObjCliente.IdCliFor);
                    }
                    else
                    {
                        ObjAtendimento = new Dados.Atendimento
                        {
                            IdCliFor = idCliFor,
                            IdAgendamento = idAgendamento,
                            IdFilial = Session.Contexto.IdFilial,
                            Data = DateTime.Today,
                            IdUsuario = Session.Usuario.IdUsuario,
                            IsAtivo = true,
                            IsConfirmado = false
                        };
                    }
                }
                else
                {
                    ObjAtendimento = new Dados.Atendimento
                    {
                        IdCliFor = idCliFor,
                        IdAgendamento = idAgendamento,
                        IdFilial = Session.Contexto.IdFilial,
                        Data = DateTime.Today,
                        IdUsuario = Session.Usuario.IdUsuario,
                        IsAtivo = true,
                        IsConfirmado = false
                    };
                }
            }

            atendimentoBindingSource.DataSource = ObjAtendimento;
            atendimentoBindingSource.ResetBindings(false);
        }

        /// <summary>
        /// Habilita as Abas
        /// </summary>
        /// <param name="p"></param>
        private void HabilitaAbas(bool status)
        {
            tbModelos.PageEnabled = status;
            tbIndique.PageEnabled = status;
            tbFichaAtendimento.PageEnabled = status;
        }

        /// <summary>
        /// Seta Titulo da tela
        /// </summary>
        private void SetTitle()
        {
            if (IsNovo)
                Text = "Novo Atendimento";
            else
            {
                Text = "Editando Atendimento do Cliente: " + ObjAtendimento.CliFor.Nome;
            }
        }

        /// <summary>
        /// Limpa labels
        /// </summary>
        /// <param name="gp"></param>
        private static void ClearLabels(GroupBox gp)
        {
            foreach (var label in gp.Controls.Cast<Control>().Where(a => a.GetType() == typeof(Label) && VerificaNome(a as Label)))
            {
                label.Text = "";
            }
        }

        /// <summary>
        /// Verifica se o texto do label inicia-se com lb para poder apagar o conteudo
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        private static bool VerificaNome(Label label)
        {
            if (label != null)
                return label.Text.StartsWith("lb");

            return false;
        }

        /// <summary>
        /// Carrega informações do cliente
        /// </summary>
        private void CarregaInfoCliente()
        {
            var fisica = ObjCliente as PessoaFisica;

            if (fisica != null)
            {
                //Dados do Cliente
                linkSelecionarCliente.Text = ObjCliente.Nome;
                lbNomeCliente.Text = ObjCliente.Nome;
                lbNascimento.Text = fisica.Nascimento.ToShortDateString();
                lbEmail.Text = fisica.Email;
                lbEndereco.Text = string.Format("{0} Nº {1} {2}, {3} {4}-{5} ", fisica.Endereco, fisica.Numero, fisica.Complemento, fisica.Bairro, fisica.Cidade.Nome, fisica.Cidade.Estado.Abreviatura);
                lbCelular.Text = fisica.Celular;
                lbTelefone.Text = fisica.Telefone;

                //Dados Complementares
                lbMae.Text = fisica.NomeMae;
                lbPai.Text = fisica.NomePai;
                lbCPF.Text = ObjCliente.Documento;
                lbRG.Text = fisica.Rg;
                lbEstadoCivil.Text = fisica.EstadoCivil.ToString();
                lbConjuje.Text = fisica.Conjuge;

                if (ObjAtendimento != null)
                    lbCodAtendimento.Text = ObjAtendimento.CodigoReduzido.ToString();
            }
            else
            {
                var juridica = ObjCliente as PessoaJuridica;

                if (juridica == null)
                    return;

                linkSelecionarCliente.Text = ObjCliente.Nome;

                gpDadosComplementares.Visible = false;

                //Dados do Cliente
                linkSelecionarCliente.Text = juridica.Nome;
                lbNomeCliente.Text = juridica.Nome;
                lbEmail.Text = juridica.Email;
                lbEndereco.Text = string.Format("{0} Nº {1} {2}, {3} {4}-{5} ", juridica.Endereco, juridica.Numero, juridica.Complemento, juridica.Bairro, juridica.Cidade.Nome, juridica.Cidade.Estado.Abreviatura);
                lbCelular.Text = juridica.Celular;
                lbTelefone.Text = juridica.Telefone;
            }
        }

        /// <summary>
        /// Carrega Indicações
        /// </summary>
        private void CarregaIndicacoes()
        {
            gpClubeAmizade.Enabled = true;
            Indicacoes = LibIndicacao.GetByAtendimento(ObjAtendimento.IdAtendimento);
            dataGridIndicacoes.DataSource = LibIndicacao.CarregaGrid(Indicacoes);
        }

        /// <summary>
        /// Carrega Modelos
        /// </summary>
        private void CarregaModelos()
        {
            if (ObjAtendimento == null)
                return;

            Modelos = LibModelo.GetByIdCliFor(ObjAtendimento.IdCliFor);
            gridModelos.DataSource = LibModelo.CarregaGrid(Modelos);
        }

        /// <summary>
        /// Carregas Modelos para Ficha de Atendimento
        /// </summary>
        private void CarregaFicha()
        {
            //Carrega Lista de Fichas 
            Fichas = LibAtendimentoModelo.GetByAtendimento(ObjAtendimento.IdAtendimento);

            //Carrega os modelos do cliente para este atendimento
            gridFichas.DataSource = LibModelo.CarregaGridFicha(Modelos, ObjAtendimento.IdAtendimento);
        }

        /// <summary>
        /// Carrega dados do cliente
        /// </summary>
        private void CarregaCliente()
        {
            if (ObjAtendimento != null)
            {
                ObjCliente = LibCliente.GetById(ObjAtendimento.IdCliFor);

            }
        }

        /// <summary>
        /// Carrega Usuario
        /// </summary>
        private void CarregaUsuario()
        {
            usuarioBindingSource.DataSource = LibUusuario.Get();
        }

        /// <summary>
        /// Carrega Filial
        /// </summary>
        private void CarregaFilial()
        {
            filialBindingSource.DataSource = LibFilial.GetById(Session.Contexto.IdFilial);
        }

        /// <summary>
        /// Habilita o link para seleção de Cliente
        /// </summary>
        /// <param name="status"></param>
        private void HabilitaSelectCliente(bool status)
        {
            linkSelecionarCliente.Enabled = status;
        }

        /// <summary>
        /// Abre Form de Modelo para Edição
        /// </summary>
        private void OpendEditModelo()
        {
            if (gridModelos.SelectedRows.Count > 0)
            {
                var frm = new Modelos.Edita(SelectedModel);
                frm.ShowDialog();

                CarregaModelos();
                CarregaFicha();
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum Registro Selecionado");
            }
        }

        /// <summary>
        /// Abre Form de Indicação para Edição
        /// </summary>
        private void OpenEditIndicacao()
        {
            if (dataGridIndicacoes.SelectedRows.Count <= 0)
            {
                MessageBoxUtilities.MessageWarning("Nenhum Registro Selecionado");
            }
            else
            {
                var selected = int.Parse(dataGridIndicacoes.SelectedRows[0].Cells[1].Value.ToString());
                var frm = new Marketing.Cupom.Edita(selected);
                frm.ShowDialog();

                CarregaIndicacoes();
            }
        }


        private void SalvarFicha()
        {
            gridFichas.EndEdit();

            //Carrega lista de modelos selecionados no grid
            var result = gridFichas.Rows.Cast<DataGridViewRow>()
                                        .Where(a => a.Cells[0].Value != null && (bool)a.Cells[0].Value == true)
                                        .Select(a => a.Cells[1].Value)
                                        .ToList();

            //Deleta todos os modelos selcionados nesta ficha
            LibAtendimentoModelo.DeleteAllModelosAtendimento(ObjAtendimento.IdAtendimento);

            //Itera sobre resultado
            foreach (var modelo in result)
            {
                //Cria o tipo
                var modeloAtendimento = new Dados.AtendimentoModelo
                {
                    IdAtendimento = ObjAtendimento.IdAtendimento,
                    IdModelo = int.Parse(modelo.ToString())
                };

                //Salva
                LibAtendimentoModelo.Insert(modeloAtendimento);
            }
        }

        private Dados.Agendamento CriaAgendamento()
        {
            var agendamento = new Dados.Agendamento
            {
                IdAgenda = LibAgenda.GetByFilial(true, Session.Contexto.IdFilial).IdAgenda,
                IdCupom = Cupom.IdCupom,
                Status = EnumAgendamentoStatus.Agendado,
                Inicio = appointment.Start,
                Termino = appointment.End
            };

            return LibAgendamento.Insert(agendamento);
        }

        private void CriarCupom(Dados.CliFor ObjCliente)
        {
            var cupom = new Cupom
            {
                IdParceria = LibParceria.GetByTipoConvenioAndFilial(Session.Instance.Contexto.IdFilial, EnumConvenioTipo.Direto).IdParceria,
                IdUsuario = Session.Usuario.IdUsuario,
                IdUsuarioTele = Session.Usuario.IdUsuario,
                IdStatusTele = EnumTelemarketingStatus.Agendado,
                Status = EnumCupomStatus.Agendado,
                Nome = ObjCliente.Nome,
                Telefone = ObjCliente.Telefone,
                Celular = ObjCliente.Celular,
                Email = ObjCliente.Email,
                Data = DateTime.Now,
                DataPreenchimento = DateTime.Now,
                IsAgendado = true,
                DataAgendado = DateTime.Now
            };

            Cupom = LibCupom.Insert(cupom);
        }

        private void SalvaAtendimento()
        {
            try
            {
                //Verifica se o cliente tem idade para poder comprar
                if (LibCliente.ValidaIdade(ObjCliente))
                {
                    if (IsNovo)
                    {
                        //para a edicao do datasource
                        atendimentoBindingSource.EndEdit();

                        if (IsDireto)
                        {
                            CriarCupom(ObjCliente);
                            Agendamento = CriaAgendamento();
                            CarregaAtendimento(Agendamento.IdAgendamento, ObjCliente.IdCliFor);
                        }

                        //envia para metodo de insert
                        ObjAtendimento = LibAtendimento.Insert((Dados.Atendimento)atendimentoBindingSource.Current);

                        //Atualiza Titulo
                        SetTitle();

                        //Habilita Abas
                        HabilitaAbas(true);

                        MessageBoxUtilities.MessageInfo("Registro incluido com sucesso");

                        CarregaModelos();
                        CarregaFicha();
                        CarregaIndicacoes();

                        IsNovo = false;
                        CarregaInfoCliente();

                        //Atualiza Cupom Após atendimento
                        AtualizaAgendamento(ObjAtendimento);

                    }
                }
                else
                {
                    MessageBoxUtilities.MessageError(null, new Exception("Cliente não tem idade suficiente para comprar. Verifique se o cliente é emancipado e altere o cadastro. Lembrando que ao fazer essa alteração será indispensavel apresentação de documentação que comprove a afirmação. Obrigado."));
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void AtualizaAgendamento(Dados.Atendimento ObjAtendimento)
        {
            var agendamento = LibAgendamento.GetById(ObjAtendimento.IdAgendamento);

            if (agendamento != null)
            {
                agendamento.Status = EnumAgendamentoStatus.Atendido;
                LibAgendamento.Update(agendamento);
            }
        }

        #endregion

        #region EVENTOS

        private void Atendimento_Load(object sender, EventArgs e)
        {
            try
            {
                //Seta Titulo da Janela
                SetTitle();

                //Limpa labels
                ClearLabels(gpDadosCliente);
                ClearLabels(gpDadosComplementares);
                ClearLabels(gpClubeAmizade);


                if (ObjAtendimento != null)
                {
                    //Habilita seleção de cliente
                    if (ObjAtendimento.IdAtendimento == 0)
                    {
                        HabilitaSelectCliente(true);
                    }
                    else
                    {
                        HabilitaSelectCliente(true);
                        gpClubeAmizade.Enabled = true;
                    }
                }

                //Carrega Dados do Cliente caso já exista um atendimento vinculado a este cupom
                CarregaCliente();

                //Carrega Informações do cliente
                CarregaInfoCliente();

                //Carrega Filial
                CarregaFilial();

                //Carrega Modelos
                CarregaModelos();

                //Carrega Dados Clube da Amizade
                CarregaClubeDaAmizade();

            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void CarregaClubeDaAmizade()
        {
            if (Agendamento != null)
            {
                var indicacao = LibIndicacao.GetByCupom(Agendamento.IdCupom);

                if (indicacao != null)
                {
                    var atendimento = LibAtendimento.GetById(indicacao.IdAtendimento);
                    var cliente = LibCliente.GetById(atendimento.IdCliFor);
                    linkIndicado.Text = string.Format("{0} - {1}", atendimento.CodigoReduzido, cliente.Nome);
                }
            }

            if (ObjAtendimento != null)
            {
                var indicacoes = LibIndicacao.GetIndicadosAtendidos(ObjAtendimento.IdAtendimento);
                lbCountIndicacoes.Text = indicacoes.ToString();
            }
        }

        private void btnFichaAtendimento_Click(object sender, EventArgs e)
        {
            try
            {
                SalvarFicha();
                var frm = new Viewer(ObjAtendimento.IdAtendimento);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }

        }

        private void saveAtendimentoButton_Click(object sender, EventArgs e)
        {
            SalvaAtendimento();
        }

        
        private void linkSelecionarCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //Abre tela para selcionar cliente
                //var frm = new Cadastros.ClienteFornecedor.Lista(true);
                //frm.ShowDialog();

                if (ObjCliente != null)
                {
                    var frmClifor = new Cadastros.ClienteFornecedor.Wizard(ObjCliente.IdCliFor);
                    frmClifor.ShowDialog();

                    if (frmClifor.CliFor != null)
                        ObjCliente = frmClifor.CliFor;
                }
                else
                {
                    var frmClifor = new Cadastros.ClienteFornecedor.Wizard();
                    frmClifor.ShowDialog();

                    if (frmClifor.CliFor != null)
                        ObjCliente = frmClifor.CliFor;
                }
                
                if (ObjCliente != null)
                {
                    //Reecarrega informações do novo cliente
                    CarregaInfoCliente();

                    if (Agendamento != null)
                        //Recarrega atendimento
                        CarregaAtendimento(Agendamento.IdAgendamento, ObjCliente.IdCliFor);
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }


        }

        private void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            OpendEditModelo();
        }

        private void novoModelo_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new Modelos.Edita(ObjAtendimento);
                frm.ShowDialog();

                //Recarrega Grid de Modelos
                CarregaModelos();

                //Carrega Ficha
                CarregaFicha();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void editarModelo_Click(object sender, EventArgs e)
        {
            OpendEditModelo();
        }

        private void excluirModelo_Click(object sender, EventArgs e)
        {
            if (SelectedModel > 0)
            {
                var deleted = LibModelo.GetById(SelectedModel);

                //carrega tela de inclusao
                try
                {
                    if (MessageBoxUtilities.MessageQuestion("Tem certeza que deseja excluir o registro '" + deleted.NomeCompleto + "' ?") == DialogResult.Yes)
                    {
                        //deleta objeto
                        deleted = LibModelo.Delete(SelectedModel);
                        MessageBoxUtilities.MessageInfo("Registro '" + deleted.NomeCompleto + "' excluido com sucesso");

                        //atualiza o grid
                        CarregaModelos();
                        CarregaFicha();
                    }
                }
                catch (Exception ex)
                {
                    MessageBoxUtilities.MessageError(this, ex);
                }

            }
        }

        private void btNovaIndicacao_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new Marketing.Cupom.Edita(ObjAtendimento.IdAtendimento, TipoConvenio);
                frm.ShowDialog();

                CarregaIndicacoes();

            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void btEditarIndicacao_Click(object sender, EventArgs e)
        {
            OpenEditIndicacao();
        }

        private void btExcluirIndicacao_Click(object sender, EventArgs e)
        {
            if (dataGridIndicacoes.SelectedRows.Count <= 0)
            {
                MessageBoxUtilities.MessageWarning("Nenhum Registro Selecionado");
            }
            else
            {
                var selected = int.Parse(dataGridIndicacoes.SelectedRows[0].Cells[0].Value.ToString());
                LibIndicacao.Delete(selected);

                MessageBoxUtilities.MessageInfo("Registro removido com sucesso");

                CarregaIndicacoes();
            }
        }

        private void salvarFicha_Click(object sender, EventArgs e)
        {
            try
            {
                SalvarFicha();

                MessageBoxUtilities.MessageInfo("Registros Salvos com Sucesso");

            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void linkIndicado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new Clube.Lista();
            frm.ShowDialog();

            var selected = frm.Selecionado;

            if (selected != null)
            {

                var indicao = new Dados.Indicacao
                {
                    IdAtendimento = selected.IdAtendimento,
                    IdCupom = Agendamento.IdCupom
                };

                LibIndicacao.Insert(indicao);

                CarregaClubeDaAmizade();

                frm.PermiteSelecionar = false;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new Clube.Lista(ObjAtendimento);
            frm.ShowDialog();
        }

        #endregion

        private void indiqueEGanheEscritórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new Marketing.Cupom.Edita(ObjAtendimento.IdAtendimento, Dados.EnumConvenioTipo.IndicacaoEscritorio);
                frm.ShowDialog();

                CarregaIndicacoes();

            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }
    }
}
