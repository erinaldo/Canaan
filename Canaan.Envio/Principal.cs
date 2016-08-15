using System.Globalization;
using Canaan.Envio.Model;
using Canaan.Lib.Model;
using Canaan.Lib.Model.Envio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Envio
{
    public partial class Principal : Form
    {
        #region PROPRIEDADES

        /// <summary>
        /// Processador de Envio
        /// </summary>
        public ProcessdorEnvio Processador { get; set; }

        /// <summary>
        /// Lista de Envio
        /// </summary>
        public BindingList<EnvioModel> Lista { get; set; }

        public Dados.Filial Filial { get; set; }

        public Dados.Config Config { get; set; }

        #endregion

        #region CONSTRUTORES

        public Principal(int pIdFilial)
        {
            //configura a filial
            this.Filial = new Lib.Filial().GetById(pIdFilial);
            this.Config = new Lib.Config().GetByFilial(pIdFilial);
            
            //inicializa a tela
            InitializeComponent();
            backgroundWorker.ProgressChanged += backgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
        }

        #endregion

        #region EVENTOS

        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Principal_Load(object sender, EventArgs e)
        {
            try
            {
                //Carrega Versão do Envio
                CarregaVersao();
                dataGrid.AutoGenerateColumns = false;

                //Instacia Envio
                Processador = new ProcessdorEnvio(backgroundWorker, Filial);                

                //Configura Form
                ConfiguraForm();

                //Inicia Timer
                timer.Start();
            }
            catch (Exception ex)
            {
                ShowBalloonErro(ex.Message);
            }
        }

        /// <summary>
        /// Background Worker Complete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ConfiguraSituacao();           
            ShowBalloonInfo("Envio de Imanges Finalizado");
        }

        /// <summary>
        /// Background Worker Progress Change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (Enum.IsDefined(typeof(EnumProgressReport), e.ProgressPercentage))
            {
                var result = (EnumProgressReport)e.ProgressPercentage;
                switch (result)
                {
                    case EnumProgressReport.ReportErro:
                        ShowBalloonErro(e.UserState.ToString());
                        break;
                    case EnumProgressReport.InfoPacoteAtual:
                        ConfiguraPacoteAtual(e);
                        break;
                    case EnumProgressReport.Situacao:
                        ConfiguraSituacao();
                        break;
                    case EnumProgressReport.Maximo:
                        ConfiguraMaximo(e);
                        break;
                    case EnumProgressReport.StatusServidor:
                        ConfiguraStatusServidor();
                        break;
                    case EnumProgressReport.ReportInfo:
                        ShowBalloonInfo(e.UserState.ToString());
                        break;
                    case EnumProgressReport.Progress:
                        AtualizaProgresso(e);
                        break;
                    case EnumProgressReport.InfoEnvio:
                        ConfigurarInfoEnvio(e);
                        break;
                    case EnumProgressReport.ZeraProgresso:
                        ZeraProgresso(e);
                        break;
                    case EnumProgressReport.RemoveLista:
                        RemoveLista(e);
                        break;
                    case EnumProgressReport.IconeEnviando:
                        AdicionarIconeEnviando(e);
                        break;
                    case EnumProgressReport.IconeErro:
                        AdicionarIconeErro(e);
                        break;
                    default:
                        break;
                }
            }

            if (e.ProgressPercentage == -1)
            {
                ShowBalloonErro(e.UserState.ToString());
            }
        }

        /// <summary>
        /// Fechando form principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            //this.Visible = false;

            //Se fecha pelo x do form ele vai para o systray e mostra uma mensagem 
            //se for pelo menu ele fecha o envio
            //if (!this.Fechar)
            //{
            //    e.Cancel = true;
            //    notifyIcon.Visible = true;
            //    ShowBalloonInfo("Envio de Imagens Minimizado");
            //}
        }

        /// <summary>
        /// Fecha Envio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Fechar = true;
            //Application.Exit();
            //this.Close();
        }

        /// <summary>
        /// Restaura Envio na Tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            IniciarProcessoEnvio();
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Mostra Balloon de Informação
        /// </summary>
        /// <param name="mensagem"></param>
        private void ShowBalloonInfo(string mensagem)
        {
            notificationLabel.Text = mensagem;
            notificationLabel.ForeColor = Color.Black;
            //if (!ShowBallon) return;
            //notifyIcon.BalloonTipText = mensagem;
            //notifyIcon.ShowBalloonTip(5000, "Informação", mensagem, ToolTipIcon.Info);
        }

        /// <summary>
        /// Mostra Balloon de Erro
        /// </summary>
        /// <param name="mensagem"></param>
        private void ShowBalloonErro(string mensagem)
        {
            notificationLabel.Text = mensagem;
            notificationLabel.ForeColor = Color.Red;
            //if (!ShowBallon) return;
            //notifyIcon.BalloonTipText = mensagem;
            //notifyIcon.ShowBalloonTip(5000, "Erro", mensagem, ToolTipIcon.Error);            
        }

        /// <summary>
        /// Mostra Balloon de Atenção
        /// </summary>
        /// <param name="mensagem"></param>
        private void ShowBalloonWarning(string mensagem)
        {
            notificationLabel.Text = mensagem;
            notificationLabel.ForeColor = Color.Yellow;
            //if (!ShowBallon) return;
            //notifyIcon.BalloonTipText = mensagem;
            //notifyIcon.ShowBalloonTip(5000, "Informação", mensagem, ToolTipIcon.Warning);
        }

        /// <summary>
        /// Configuração Incial do Form
        /// </summary>
        private void ConfiguraForm()
        {           
            var ultimaExec = Processador.GetUltimaExecucao();
            timeUltimaExecucao.Value = ultimaExec == null ? DateTime.Now : ultimaExec.GetValueOrDefault();

            //Info Envio
            lbTotalPacotes.Text = @"0";
            lbTotalArquivos.Text = @"0";
            lbPacotesTransferidos.Text = @"0";
            lbArquivosTransferidos.Text = @"0";


            //Configura Conexão
            var config = new Lib.Config().GetByFilial(Filial.IdFilial);
            lbServer.Text = config.FtpHost;
            lbPasta.Text = config.FtpFolder;

            //Coonfigura status servidor
            ConfiguraStatusServidor();

            //Verifica Execução
            backgroundWorker.ReportProgress((int)EnumProgressReport.Situacao, backgroundWorker.IsBusy);
        }

        /// <summary>
        /// Configura o Status do Servidor
        /// </summary>
        private void ConfiguraStatusServidor()
        {
            var config = new Lib.Config().GetByFilial(Filial.IdFilial);

            if (PingHost(config.FtpHost))
            {
                lbStatus.Text = "Online";
                lbStatus.ForeColor = Color.Green;
            }
            else
            {
                lbStatus.Text = "Online";
                lbStatus.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// Carrega Grid
        /// </summary>
        private void CarregaGrid()
        {
            //Limpa grid antes de carregar
            dataGrid.Rows.Clear();

            //Carrega Lista
            Lista = Processador.CarregaLista();

            //Carrega Grid
            dataGrid.DataSource = Lista;
        }

        /// <summary>
        /// Inicia Processo de Envio
        /// </summary>
        private void IniciarProcessoEnvio()
        {
            if (backgroundWorker.IsBusy) return;

            //Carrega Grid Envio
            CarregaGrid();

            //Processa Lista do Envio
            Processador.ProcessaEnvio();
        }

        /// <summary>
        /// Verifica se Servidor esta online
        /// </summary>
        /// <param name="nameOrAddress"></param>
        /// <returns></returns>
        public bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = new Ping();

            try
            {
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException ex)
            {
                ShowBalloonErro(ex.Message);
            }

            return pingable;
        }

        /// <summary>
        /// Configura se envio esta parado ou em execução
        /// </summary>
        private void ConfiguraSituacao()
        {
            if (backgroundWorker.IsBusy)
            {
                lbSituacao.Text = "Executando";
                lbSituacao.ForeColor = Color.Green;
            }
            else
            {
                lbSituacao.Text = "Parado";
                lbSituacao.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// Carrega Versão do envio
        /// </summary>
        private void CarregaVersao()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var assemName = assembly.GetName();
            var ver = assemName.Version;
            Text = Text + ' ' + ver;
        }

        /// <summary>
        /// Adiciona Icone de Erro
        /// </summary>
        /// <param name="e"></param>
        private void AdicionarIconeErro(ProgressChangedEventArgs e)
        {
            var result = (int)e.UserState;
            var row = dataGrid.Rows.Cast<DataGridViewRow>().FirstOrDefault(a => (int)a.Cells["IdEnvio"].Value == result);
            if (row != null)
                row.Cells["Icone"].Value = Properties.Resources.erro;
        }

        /// <summary>
        /// Adiciona Icone de Enviando
        /// </summary>
        /// <param name="e"></param>
        private void AdicionarIconeEnviando(ProgressChangedEventArgs e)
        {
            var result = (int)e.UserState;
            var row = dataGrid.Rows.Cast<DataGridViewRow>().FirstOrDefault(a => (int)a.Cells["IdEnvio"].Value == result);
            if (row != null)
                row.Cells["Icone"].Value = Properties.Resources.enviando;
        }

        /// <summary>
        /// Remove item da lista
        /// </summary>
        /// <param name="e"></param>
        private void RemoveLista(ProgressChangedEventArgs e)
        {
            var result = (int)e.UserState;
            var row = dataGrid.Rows.Cast<DataGridViewRow>().FirstOrDefault(a => (int)a.Cells["IdEnvio"].Value == result);
            if (row != null)
                dataGrid.Rows.Remove(row);
        }

        /// <summary>
        /// Zera progresso do progressBar
        /// </summary>
        /// <param name="e"></param>
        private void ZeraProgresso(ProgressChangedEventArgs e)
        {
            var result = (EnumProgressBar)e.UserState;

            if (result == EnumProgressBar.Atual)
            {
                pBarAtual.Value = 0;
            }
            else
            {
                pBarTotal.Value = 0;
            }
        }

        /// <summary>
        /// Configura Infomeçãoes do Envio
        /// </summary>
        /// <param name="e"></param>
        private void ConfigurarInfoEnvio(ProgressChangedEventArgs e)
        {
            var result = e.UserState as InfoEnvioModel;

            if (result == null)
                return;

            //Info Envio
            lbPacotesTransferidos.Text = result.PacotesTranferidos.ToString(CultureInfo.InvariantCulture);
            lbArquivosTransferidos.Text = result.ArquivosTransferidos.ToString(CultureInfo.InvariantCulture);
            lbTotalArquivos.Text = result.TotalArquivos.ToString(CultureInfo.InvariantCulture);
            lbTotalPacotes.Text = result.TotalPacotes.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Configura informações pacote atual
        /// </summary>
        /// <param name="e"></param>
        private void ConfiguraPacoteAtual(ProgressChangedEventArgs e)
        {
            var info = e.UserState as PacoteAtualModel;
            
            if (info == null) return;

            lbTotalEnvelopes.Text = info.TotalPacote.ToString(CultureInfo.InvariantCulture);
            lbTotalImagens.Text = info.TotalImagens.ToString(CultureInfo.InvariantCulture);
            lbArqTranferidosPacote.Text = info.ArquivosTransferidos.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Atualiza Progresso
        /// </summary>
        /// <param name="e"></param>
        private void AtualizaProgresso(ProgressChangedEventArgs e)
        {
            try
            {
                var result = (UserStateProgress)e.UserState;

                if (result == null)
                    return;

                if (result.Bar == EnumProgressBar.Atual)
                {
                    pBarAtual.Value = pBarAtual.Value + result.Progresso;
                }
                else if (result.Bar == EnumProgressBar.Total)
                {
                    pBarTotal.Value = result.Progresso;
                }
            }
            catch (Exception ex)
            {

                ShowBalloonErro(ex.Message);
            }

        }

        /// <summary>
        /// Configura o Maximo do ProgessBar
        /// </summary>
        /// <param name="e"></param>
        private void ConfiguraMaximo(ProgressChangedEventArgs e)
        {
            var result = (UserStateProgress)e.UserState;

            if (result == null)
                return;

            if (result.Bar == EnumProgressBar.Atual)
            {
                pBarAtual.Maximum = result.Maximo;
            }
            else
            {
                pBarTotal.Maximum = result.Maximo;
            }
        }


        #endregion

        private void btAdiantar_Click(object sender, EventArgs e)
        {

        }
    }
}
