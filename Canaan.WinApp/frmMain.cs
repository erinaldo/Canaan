using Canaan.Telas.Base;
using DevExpress.Utils;
using DevExpress.XtraNavBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Relatorios.Marketing.ListaTele.Avulsas;
using Filtro = Canaan.Relatorios.Venda.Produtos.Filtro;
using TelemarketingAgenda = Canaan.Dados.TelemarketingAgenda;
using UsuarioFilial = Canaan.Dados.UsuarioFilial;
using Viewer = Canaan.Relatorios.Marketing.Parceria.ResumoMaterial.Viewer;

namespace Canaan.WinApp
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        #region PROPRIEDADES

        public Lib.Session Session
        {
            get
            {
                return Lib.Session.Instance;
            }
        }

        public Lib.UsuarioFilial LibUsuarioFilial
        {
            get
            {
                return new Lib.UsuarioFilial();
            }
        }

        public UsuarioFilial Grupo { get; set; }

        public Lib.Config LibConfig
        {
            get { return new Lib.Config(); }

        }

        public Lib.Agendamento LibAgendamento 
        {
            get 
            {
                return new Lib.Agendamento();
            }
        }

        public override sealed Image BackgroundImage
        {
            get { return base.BackgroundImage; }
            set { base.BackgroundImage = value; }
        }

        #endregion

        #region EVENTOS

        public frmMain()
        {
            InitializeComponent();
            //BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(Properties.Settings.Default.BgMain);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CarregaVersao();
            
            EfetuaLogin();
            UpdateFaltantes();

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region METODOS

        //
        //METODOS
        private void EfetuaLogin()
        {
            VerificaUsuario();
            VerificaContexto();
            CarregaSessionInfo();

            //Aplica Permissoes e Habilita Timer de Lembretes
            AplicarPermissoes();

            CarregaMenuSimplificado();
        }

        private void CarregaSessionInfo()
        {
            if (Lib.Session.Instance != null)
            {
                if (Lib.Session.Instance.Contexto != null)
                {
                    //carrega dados da tela
                    mainContexto.Text = Lib.Session.Instance.Contexto.Filial.NomeFantasia;
                    mainUsuario.Text = Lib.Session.Instance.Contexto.Usuario.Username;
                    mainPermissao.Text = Lib.Session.Instance.Contexto.UsuarioGrupo.Nome;
                }
            }
        }

        private void VerificaUsuario()
        {
            if (Lib.Session.Instance.Usuario == null)
            {
                CarregaLogin();
            }
        }

        private void VerificaContexto()
        {
            //verifica se o usuario esta logado
            VerificaUsuario();

            //verifica se o contexto esta selecionado
            if (Lib.Session.Instance.Contexto == null)
            {
                if (Lib.Session.Instance != null && Lib.Session.Instance.Usuario != null)
                {
                    //carrega filiais do usuario
                    var userFiliais = new Lib.UsuarioFilial().GetByUsuario(Lib.Session.Instance.Usuario.IdUsuario);

                    //verifica se acesso a alguma filial
                    if (userFiliais.Count > 0)
                    {
                        //verifica se tem apenas uma filial
                        if (userFiliais.Count == 1)
                        {
                            //carrega sessao com filial unica
                            Lib.Session.Instance.Contexto = userFiliais.FirstOrDefault();

                            //carrega informacao da logo da empresa
                            Lib.Session.Instance.LogoReport = new Lib.Config().GetByFilial(userFiliais.FirstOrDefault().IdFilial).Logomarca;
                        }
                        else
                        {
                            CarregaContexto();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario " + Lib.Session.Instance.Usuario.Nome + " não possui permissão em nenhuma filial do sistema");
                        Close();
                    }
                }

            }
        }

        private void CarregaContexto()
        {
            var frm = new Telas.Autenticacao.Contexto(Lib.Session.Instance.Usuario.IdUsuario);
            frm.ShowDialog();

            //verifica se é pra sair da app
            if (frm.ExitApp)
            {
                Close();
            }
            else
            {
                //aplica atualizações no formulario
                if (frm.ContextoItem != null)
                    Lib.Session.Instance.Contexto = frm.ContextoItem;

                //carregadados da sessao
                CarregaSessionInfo();
            }
        }

        private void CarregaLogin()
        {
            //abre a tela de login
            var frm = new Telas.Autenticacao.Login(Properties.Settings.Default.BgLogin);
            frm.ShowDialog();

            //verifica se é pra sair da app
            if (frm.ExitApp)
            {
                Close();
            }
            else
            {
                //aplica atualizações no formulario
                Lib.Session.Instance.Usuario = frm.Usuario;
            }
        }

        private void AplicarPermissoes()
        {
            //Habilita todos os menus antes de desabilitar
            mVenda.Enabled = true;
            mFinanceiro.Enabled = true;
            mConfiguracao.Enabled = true;
            mConfigGeral.Enabled = true;
            mConfigFinanceiro.Enabled = true;
            mConfigPedido.Enabled = true;
            mConfigSegGrupos.Enabled = true;
            mConfiguracaoStatus.Enabled = true;
            mTelemarketing.Enabled = true;
            mMarketingGeral.Enabled = true;
            mRotinasDistCupons.Enabled = true;
            mRotinasDistFaltantes.Enabled = true;

            if (Session.Contexto != null && Session.Usuario != null)
            {
                Grupo = LibUsuarioFilial.GetByUsuarioFilial(Session.Usuario.IdUsuario, Session.Contexto.IdFilial);
            }

            if (Grupo == null)
            {
                Lib.MessageBoxUtilities.MessageWarning("Erro ao Logar. A Aplicação será fechada");
                Application.Exit();
            }

            if (Grupo != null)
            {
                //Permissao Atendimento /////////////
                if (Grupo.UsuarioGrupo != null && (Grupo != null && !Grupo.UsuarioGrupo.IsComercial))
                {
                    mVenda.Enabled = false;
                }

                /////////////////////////////////////
                //Permissao Financeiro ///////////////
                if (!Grupo.UsuarioGrupo.IsFinanceiro)
                {
                    mFinanceiro.Enabled = false;
                }


                //////////////////////////////////////
                // Permissao Configurações /////////////
                if (!Grupo.UsuarioGrupo.IsSupervisor &&
                    !Grupo.UsuarioGrupo.IsAdmin &&
                    !Grupo.UsuarioGrupo.IsGerente &&
                    !Grupo.UsuarioGrupo.IsMarketing)
                {
                    mConfiguracao.Enabled = false;
                }

                if (!Grupo.UsuarioGrupo.IsAdmin)
                {
                    mConfigGeral.Enabled = false;
                    mConfigFinanceiro.Enabled = false;
                    mConfigPedido.Enabled = false;
                    mConfigSegGrupos.Enabled = false;
                    mConfiguracaoStatus.Enabled = false;
                }

                if (!Grupo.UsuarioGrupo.IsGerente)
                {
                    mConfigSegUsuario.Enabled = false;
                }

                ///////////////////////////////////////


                //Permissõpes Rotinas /////////////////
                if (!Grupo.UsuarioGrupo.IsFinanceiro)
                {
                }

                if (!Grupo.UsuarioGrupo.IsMarketing)
                {
                    mTelemarketing.Enabled = false;
                    mMarketingGeral.Enabled = false;
                }

                if (!Grupo.UsuarioGrupo.IsGerente)
                {
                    mRotinasDistCupons.Enabled = false;
                    mRotinasDistFaltantes.Enabled = false;
                }

            }

            //////////////////////////////////////////
        }

        private void UpdateFaltantes()
        {
            LibAgendamento.UpdateConfirmadoFaltante(Session.Instance.Contexto.Filial.IdFilial);
        }

        private void CarregaVersao()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var assemName = assembly.GetName();
            var ver = assemName.Version;
            Text = string.Format("{0}{1}{2}", Text, ' ', ver);
        }

        private void CarregaMenuSimplificado()
        {
            var config = new Lib.Config().GetByFilial(Session.Contexto.IdFilial);

            if (config.UsaMenuSimplificado == true)
            {
                atendimentosToolStripMenuItem.Visible = false;
                toolStripSeparator14.Visible = false;
                mConsulta.Visible = false;
                consultaCPCToolStripMenuItem.Visible = false;
                consultaClubeDaAmizadeToolStripMenuItem.Visible = false;
                toolStripSeparator15.Visible = false;
                recebimentoDeProdutoToolStripMenuItem.Visible = false;
                entregaDeProdutoToolStripMenuItem.Visible = false;

                cadastrosToolStripMenuItem.Visible = false;
                clienteFornecedorToolStripMenuItem.Visible = false;

                laboratórioToolStripMenuItem.Visible = false;
                pedidosPendentesToolStripMenuItem.Visible = false;
                pedidoAvulsoToolStripMenuItem.Visible = false;
                toolStripMenuItem2.Visible = false;
                envioDeImagensToolStripMenuItem.Visible = false;

                cuponsXFuncionarioToolStripMenuItem.Visible = false;
                toolStripSeparator21.Visible = false;
                resultadoDasParceriasToolStripMenuItem.Visible = false;
                resultadosDasIndicaçõesToolStripMenuItem.Visible = false;
                parceriasXPeriodoToolStripMenuItem.Visible = false;
                resumoDeMaterialToolStripMenuItem.Visible = false;
                toolStripMenuItem4.Visible = false;

                backupFotografadosToolStripMenuItem.Visible = false;
                toolStripSeparator11.Visible = false;
                conferênciaToolStripMenuItem.Visible = false;

                mMarketingGeral.Visible = false;
                parceriasToolStripMenuItem.Visible = false;
                cuponsToolStripMenuItem.Visible = false;
                toolStripSeparator1.Visible = false;
                mTelemarketing.Visible = false;
                toolStripSeparator2.Visible = false;
                mRotinasDistCupons.Visible = false;
                mRotinasDistFaltantes.Visible = false;

                toolStripSeparator6.Visible = false;
                retornoBancarioToolStripMenuItem.Visible = false;

                atendidosXPeriodoToolStripMenuItem.Visible = false;
                toolStripMenuItem3.Visible = false;
                toolStripSeparator23.Visible = false;
                pacotesParaLiberaçãoToolStripMenuItem.Visible = false;
                vendasDevolvidasToolStripMenuItem.Visible = false;
                vendasProgramadasToolStripMenuItem.Visible = false;

                termoDeResposabilidadeToolStripMenuItem.Visible = false;
                autorizacaoDeUsoDeImagemToolStripMenuItem.Visible = false;
                toolStripSeparator19.Visible = false;
                serviçosContratadosToolStripMenuItem.Visible = false;
                boletoToolStripMenuItem.Visible = false;
                termoDeAditamentoToolStripMenuItem.Visible = false;
                trocaDeTitularidadeToolStripMenuItem.Visible = false;
            }
        }

        #endregion

        #region MOVIMENTACOES

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Movimentacoes.Agendamento.Agendamento();
            frm.ShowDialog();
        }

        private void atendimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Movimentacoes.Atendimento.Lista();
            frm.ShowDialog();
        }

        private void consultaDePacoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Movimentacoes.Consulta.Filtro();
            frm.ShowDialog();
        }

        private void consultaCPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Movimentacoes.ConsultaOnline.ConsultaOnline();
            frm.ShowDialog();
        }

        private void consultaClubeDaAmizadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Movimentacoes.Atendimento.Clube.Lista();
            frm.ShowDialog();
        }

        private void sessoesFotograficasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Movimentacoes.Sessao.Lista();
            frm.ShowDialog();
        }

        private void recebimentoDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Movimentacoes.Entrega.EntregaPacote(Telas.Movimentacoes.Entrega.TipoEntrega.Recebimento);
            frm.ShowDialog();
        }

        private void entregaDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Movimentacoes.Entrega.EntregaPacote(Telas.Movimentacoes.Entrega.TipoEntrega.Entrega);
            frm.ShowDialog();
        }

        private void atendimentoFInalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Movimentacoes.Venda.Busca.Lista();
            frm.ShowDialog();
        }

        #endregion

        #region CADASTROS

        private void clienteFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Cadastros.ClienteFornecedor.Lista();
            frm.ShowDialog();
        }

        #endregion

        #region RELATORIOS

        private void agendamentoXDiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Marketing.AgendamentoDia.Filtro();
            frm.ShowDialog();
        }

        private void agendamentoXDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Marketing.AgendamentoParceria.Filtro();
            frm.ShowDialog();
        }

        private void agendamentoXHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Marketing.AgendamentoHora.Filtro();
            frm.ShowDialog();
        }

        private void agendamentoXFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Marketing.AgendamentoXFuncionario.Filtro();
            frm.ShowDialog();
        }

        private void listaDeTelemarketingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Marketing.ListaTele.Filtro();
            frm.ShowDialog();
        }

        private void etiquetasAvulstasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new EtiquetaAvulsa();
            frm.ShowDialog();
        }

        private void cuponsXFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Base.FiltroUsuario(EnumRelatorioTipo.Marketing_CuponsXUsuario);
            frm.ShowDialog();
        }

        private void resultadoDasParceriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Marketing.Parceria.ParceriaXResultado.Filtro();
            frm.ShowDialog();
        }

        private void resultadosDasIndicaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Marketing.Parceria.IndicacoesXPeriodo.Filtro();
            frm.Show();
        }

        private void parceriasXPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Marketing.Parceria.ParceriaXPeriodo.Filtro();
            frm.ShowDialog();
        }

        private void resumoDeMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Viewer();
            frm.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Marketing.Parceria.Auditoria.Filtro();
            frm.ShowDialog();
        }

        private void fotografadosXPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Base.FiltroPeriodo(EnumRelatorioTipo.Fotog_Periodo);
            frm.ShowDialog();
        }

        private void fotografadosXGêneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Fotografados.FotogXGenero.Filtro();
            frm.ShowDialog();
        }

        private void fotografadosXFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Fotografados.FotogXFuncionario.Filtro();
            frm.ShowDialog();
        }

        private void atendidosXPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Base.FiltroPeriodo(EnumRelatorioTipo.Atendimento_AtendidoXPeriodo, Properties.Settings.Default.ReportLogo);
            frm.ShowDialog();
        }

        private void vendasXProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Filtro();
            frm.ShowDialog();
        }

        private void pacotesParaLiberaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Venda.Liberacao.Filtro();
            frm.Show();
        }

        private void vendasDevolvidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Venda.Devolvida.Filtro();
            frm.Show();
        }

        private void vendasProgramadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Venda.Programada.Filtro();
            frm.Show();
        }

        private void aReceberXPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Financeiro.Lancamento.Receber.Filtro();
            frm.ShowDialog();
        }

        private void recebidoXPeríodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Financeiro.Lancamento.Recebido.Filtro();
            frm.ShowDialog();
        }

        private void fichaDeAtendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Base.FiltroModelo(EnumRelatorioTipo.Atendimento_Ficha);
            frm.ShowDialog();
        }

        private void termoDeResposabilidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Fichas.Termo.Filtro();
            frm.ShowDialog();
        }

        private void autorizacaoDeUsoDeImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Base.FiltroModelo(EnumRelatorioTipo.Atendimento_UsoImagem);
            frm.ShowDialog();
        }

        private void envelopeDeServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Base.FiltroVenda(EnumRelatorioTipo.Venda_Envelope);
            frm.ShowDialog();
        }

        private void serviçosContratadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Base.FiltroVenda(EnumRelatorioTipo.Venda_ServicosContratados);
            frm.ShowDialog();
        }

        private void boletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Base.FiltroVenda(EnumRelatorioTipo.Venda_Boleto);
            frm.ShowDialog();
        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Base.FiltroVenda(EnumRelatorioTipo.Venda_Contrato);
            frm.ShowDialog();
        }

        private void controleDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Base.FiltroVenda(EnumRelatorioTipo.Venda_ControlePagamento);
            frm.ShowDialog();
        }

        private void comprovanteDeEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Base.FiltroVenda(EnumRelatorioTipo.Venda_ComprovanteEntrada);
            frm.ShowDialog();
        }

        private void trocaDeTitularidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Base.FiltroVenda(EnumRelatorioTipo.Venda_Troca);
            frm.ShowDialog();
        }

        private void termoDeAditamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Base.FiltroVenda(EnumRelatorioTipo.Venda_Aditamento);
            frm.ShowDialog();
        }

        #endregion

        #region ROTINAS

        private void telemarketingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Rotinas.Marketing.Telemarketing.Lista();
            frm.ShowDialog();
        }

        private void selecaoDeCuponsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Rotinas.Marketing.DistribuicaoCupons.DistribuicaoCupons();
            frm.ShowDialog();
        }

        private void distribuicaoDeFaltantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Rotinas.Marketing.DistribuicaoFaltantes.DistribuicaoFaltantes();
            frm.ShowDialog();
        }

        private void backupFotografadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Rotinas.Backup.Backup();
            frm.Show();
        }

        private void conferênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Rotinas.Liberacao.Liberacao();
            frm.ShowDialog();
        }

        #endregion

        #region MARKETING

        private void parceriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Marketing.Parceria.Lista();
            frm.ShowDialog();
        }

        private void cuponsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Marketing.Cupom.Lista();
            frm.ShowDialog();
        }

        #endregion

        #region FINANCEIRO

        private void lançamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Financeiro.Lancamento.Lista frm = new Telas.Financeiro.Lancamento.Lista();
            frm.ShowDialog();
        }

        private void retornoBancarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Financeiro.Retorno.Lista();
            frm.ShowDialog();
        }

        #endregion

        #region CONFIGURACOES

        private void menuConf_Geral_GruposEmpresa_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Configuracoes.Geral.GrupoEmpresa.Lista();
            frm.ShowDialog();
        }

        private void menuConf_Geral_Filiais_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Configuracoes.Geral.Filiais.Lista();
            frm.ShowDialog();
        }

        private void menuConf_Seg_GruposUsuarios_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Configuracoes.Seguranca.UsuarioGrupo.Lista();
            frm.ShowDialog();
        }

        private void menuConf_Seg_Usuarios_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Configuracoes.Seguranca.Usuario.Lista();
            frm.ShowDialog();
        }

        private void convenioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Configuracoes.Marketing.Convenio.Lista();
            frm.ShowDialog();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Configuracoes.Agenda.Edita();
            frm.ShowDialog();
        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Financeiro.Banco.Lista();
            frm.ShowDialog();

        }

        private void agenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Financeiro.Agencia.Lista();
            frm.ShowDialog();
        }

        private void contasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Financeiro.Conta.Lista();
            frm.ShowDialog();
        }

        private void contasCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Financeiro.ContaCaixa.Lista();
            frm.ShowDialog();
        }

        private void tabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Configuracoes.Pedido.Tabela.Lista();
            frm.ShowDialog();
        }

        private void mudançaDeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Configuracoes.Pedido.Status.StatusServico();
            frm.ShowDialog();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Configuracoes.Integracao.Servicos.Lista();
            frm.ShowDialog();
        }

        private void corrigeCuponsDuplicadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Suporte.CorrigeCupons.Formulario();
            frm.Show();
        }

        private void devolveVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Suporte.DevolveVenda.Formulario();
            frm.ShowDialog();
        }

        #endregion

        #region SAIR

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //limpa a session
            Lib.Session.Instance.Contexto = null;
            Lib.Session.Instance.Usuario = null;

            //limpa a tela
            mainContexto.Text = "";
            mainUsuario.Text = "";
            mainPermissao.Text = "";

            EfetuaLogin();
        }

        #endregion

        #region CONTEXT

        private void alterarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Configuracoes.Seguranca.Usuario.Edita(Lib.Session.Instance.Usuario.IdUsuario);
            frm.ShowDialog();
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Configuracoes.Seguranca.Usuario.ChangePassword(Lib.Session.Instance.Usuario.IdUsuario);
            frm.ShowDialog();
        }

        #endregion

        private void pedidosPendentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Laboratorio.Pendentes.Lista();
            frm.Show();
        }

        private void pedidoAvulsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Laboratorio.Pedido.Edita();
            frm.Show();
        }

        private void envioDeImagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var frm = new Telas.Laboratorio.Envio.Lista();
            //frm.Show();
            var frm = new Envio.Principal(this.Session.Contexto.IdFilial);
            frm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Configuracoes.Integracao.Servicos.Lista();
            frm.ShowDialog();
        }

        private void serviçosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Configuracoes.Geral.Configuracoes.Edita();
            frm.ShowDialog();
        }

        private void pastasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Configuracoes.Geral.Pasta.Lista();
            frm.ShowDialog();
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Configuracoes.Geral.Eventos.Lista();
            frm.ShowDialog();
        }

        private void atendimentosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var frm = new Telas.Movimentacoes.Atendimento.Lista();
            frm.ShowDialog();
        }

        private void vendaXPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Venda.Periodo.Filtro();
            frm.ShowDialog();
        }






        

        private void agendaToolStripButton_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Movimentacoes.Agendamento.Agendamento();
            frm.ShowDialog();
        }

        private void sessaoToolStripButton_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Movimentacoes.Sessao.Lista();
            frm.ShowDialog();
        }

        private void retiradaToolStripButton1_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Financeiro.Balcao.Compra();
            frm.ShowDialog();
        }

        private void contratoToolStripButton_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Movimentacoes.Venda.Busca.Lista();
            frm.ShowDialog();
        }

        private void caixaToolStripButton_Click(object sender, EventArgs e)
        {
            Telas.Financeiro.Lancamento.Lista frm = new Telas.Financeiro.Lancamento.Lista();
            frm.ShowDialog();
        }

        private void clientesToolStripButton_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Cadastros.ClienteFornecedor.Lista();
            frm.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tabela = new Lib.Tabela().GetByStatus(true).FirstOrDefault();
            var frm = new Telas.Configuracoes.Pedido.Produto.Lista(tabela);

            frm.ShowDialog();
        }

        private void vendaToolStripButton_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Financeiro.Balcao.Venda();
            frm.ShowDialog();
        }

        private void cancelamentoDeContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Base.FiltroVenda(EnumRelatorioTipo.Venda_Cancelamento);
            frm.ShowDialog();
        }

        private void administrativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Telas.Suporte.DevolveVenda.Formulario();
            frm.ShowDialog();
        }

        private void listagemDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Cliente.Listagem.Viewer();
            frm.Show();
        }

        private void fichaDeAcompanhamentoDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Relatorios.Base.FiltroVenda(EnumRelatorioTipo.Venda_Recibo);
            frm.ShowDialog();
        }
    }
}
