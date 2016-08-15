using System.Reflection;
using Canaan.Dados;
using Canaan.Envio.Model;
using Canaan.Envio.Utilitarios;
using Canaan.Lib.Model.Envio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.FtpClient;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.FtpClient.Extensions;

namespace Canaan.Envio
{
    public class ProcessdorEnvio
    {
        #region CAMPOS

        private readonly Dados.CanaanModelContainer _conn;

        #endregion

        #region PROPRIEDADES

        private const int Buffer = 2048;

        public PacoteAtualModel InfoAtual { get; private set; }

        public InfoEnvioModel InfoGeral { get; private set; }

        public UserStateProgress UserStateProgressTotal { get; private set; }

        public Stream Ostream { get; private set; }

        public string Remotefilepath { get; private set; }

        public string LocalCompletePath { get; set; }

        public bool Verificado { get; set; }

        public string Dir { get; private set; }

        public string SubDir { get; private set; }

        public UserStateProgress AtualStateProgress { get; private set; }

        public int Erros { get; private set; }

        public int TotalArqTranferido { get; private set; }

        public int TotalArquivos { get; private set; }

        public Dados.Sessao Sessao { get; set; }

        public string PathFile
        {
            get { return string.Format("{0}/{1}", Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "log.txt"); }
        }


        /// <summary>
        /// Biblioteca de Consultas Envio
        /// </summary>
        private Lib.Envio LibEnvio
        {
            get
            {
                return new Lib.Envio(_conn);
            }
        }

        /// <summary>
        /// Biblioteca de Consulta Ordem de Serviço Item
        /// </summary>
        public Lib.OrdemServicoItem LibOrdemServicoItem
        {
            get
            {
                return new Lib.OrdemServicoItem();
            }
        }

        /// <summary>
        /// Biblioteca de Consulta Ordem de Serviço
        /// </summary>
        public Lib.OrdemServico LibOrdemServico
        {
            get
            {
                return new Lib.OrdemServico();
            }
        }

        /// <summary>
        /// Background Worker
        /// </summary>
        private BackgroundWorker BackWork { get; set; }

        /// <summary>
        /// Biblioteca de Consulta do Cservice Envelopes
        /// </summary>
        private static CService.Lib.Envelope LibCServicEnvelope
        {
            get
            {
                return new CService.Lib.Envelope();
            }
        }

        /// <summary>
        /// Biblioteca de Consulta do CService Envelopes Fotos
        /// </summary>
        //private static CService.Lib.EnvEnvelopeFoto LibCServiceEnvelopeFoto
        //{
        //    get
        //    {
        //        return new CService.Lib.EnvEnvelopeFoto();
        //    }
        //}
        private static CService.Lib.EnvelopeFoto LibCServiceEnvelopeFoto
        {
            get
            {
                return new CService.Lib.EnvelopeFoto();
            }
        }

        /// <summary>
        /// Lista de Envio
        /// </summary>
        private BindingList<EnvioModel> Lista { get; set; }

        /// <summary>
        /// Lista de Envio que houve erro ao fazer envio para servidor
        /// </summary>
        private BindingList<EnvioModel> ListaErro { get; set; }

        /// <summary>
        /// Biblioteca de Ftp
        /// </summary>
        public FtpEnvio Ftp { get; set; }

        /// <summary>
        /// Cliente Ftp
        /// </summary>
        public FtpClient Client { get; set; }

        /// <summary>
        /// Biblioteca do Config
        /// </summary>
        public Lib.Config LibConfig
        {
            get
            {
                return new Lib.Config();
            }
        }

        /// <summary>
        /// Config
        /// </summary>
        public Dados.Config Config { get; set; }

        public Dados.Filial Filial { get; set; }

        #endregion

        #region CONSTRUTOR

        public ProcessdorEnvio(BackgroundWorker backWork, Dados.Filial pFilial)
        {
            this.Filial = pFilial;
            this.BackWork = backWork;
            backWork.DoWork += backWork_DoWork;

            Client = new FtpClient
            {
                EnableThreadSafeDataConnections =  false
            };

            Ftp = new FtpEnvio(Client, Filial);
            Config = LibConfig.GetByFilial(Filial.IdFilial);
            ListaErro = new BindingList<EnvioModel>();

            _conn = new Dados.CanaanModelContainer();
        }

        #endregion

        #region EVENTOS

        private void backWork_DoWork(object sender, DoWorkEventArgs e)
        {

            //Configura label situação do envio
            ReportaInfoView((int)EnumProgressReport.Situacao, BackWork.IsBusy);

            //Salva todos os Pacotes e imagens cpc
            SalvaDadosCpc(e);

            //Envia Imagens CPC
            EnviaImagens(e, Lista);

            while (ListaErro.Count > 0)
            {
                //Reenvia envio que possui imagem com erro
                EnviaImagens(e, ListaErro);
            }
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Carrega Lista de Envio
        /// </summary>
        /// <returns></returns>
        public BindingList<EnvioModel> CarregaLista()
        {
            Lista = new BindingList<EnvioModel>(LibEnvio.GetEnvioByFilial(Filial.IdFilial));
            return Lista;
        }

        /// <summary>
        /// Retorna Utlimo Pacote Horario Ultimo Pacote Enviado
        /// </summary>
        /// <returns></returns>
        public DateTime? GetUltimaExecucao()
        {
            return LibEnvio.GetUltimExecucaoFilial(Filial.IdFilial);
        }

        /// <summary>
        /// Processa Lista de Envio
        /// </summary>
        public void ProcessaEnvio()
        {
            BackWork.RunWorkerAsync();
        }

        /// <summary>
        /// Salva Dados do Envio No CPC
        /// </summary>
        /// <param name="e"></param>
        private void SalvaDadosCpc(DoWorkEventArgs e)
        {
            //Itera sobre lista de vendas
            foreach (var envio in Lista)
            {
                ReportaInfoView((int)EnumProgressReport.StatusServidor, null);

                foreach (var envelope in envio.OrdensEnvio)
                {
                    try
                    {
                        //Reporta status servidor
                        ReportaInfoView((int)EnumProgressReport.StatusServidor, null);
                        ReportaInfoView((int)EnumProgressReport.StatusServidor, null);
                        ReportaInfoView((int)EnumProgressReport.ReportInfo, string.Format("Salvando serviço {0} do Codigo {1} no banco CServicos", envelope.Servico, envelope.CodigoReduzido));

                        //Atualiza o usuario do escritorio que liberou a venda
                        envelope.NomeEnvio = envio.NomeEnvio;

                        //Salva ordens CPC e retorno um resumo dos itens adicionados                        
                        var sumaryOrdemServico = LibCServicEnvelope.SalvaOrdens(envelope);

                        //Atualiza IdEnvelope CPC
                        envelope.IdEnvelopeCpc = sumaryOrdemServico.IdEnvelopeCpc;

                        foreach (var foto in envelope.OrdensServicoItem)
                        {
                            try
                            {
                                //Reporta status servidor
                                ReportaInfoView((int)EnumProgressReport.StatusServidor, null);
                                ReportaInfoView((int)EnumProgressReport.ReportInfo, string.Format("Salvando imagem {0} no banco CServicos", foto.NomeFoto.Split('\\').LastOrDefault()));

                                //Salva imagens do envelope
                                var sumaryItem = LibCServiceEnvelopeFoto.SalvaOrdensItem(foto, envelope.IdEnvelopeCpc);

                                foto.IdFotoCpc = sumaryItem.IdFotoCpc;
                            }
                            catch (Exception ex)
                            {
                                ReportaInfoView((int)EnumProgressReport.ReportErro, ex.Message);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        ReportaInfoView((int)EnumProgressReport.ReportErro, ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Reporta Informação para tela
        /// </summary>
        /// <param name="status"></param>
        /// <param name="info"></param>
        public void ReportaInfoView(int status, object info)
        {
            BackWork.ReportProgress(status, info);
        }

        /// <summary>
        /// Envia Imagens para Ftp
        /// </summary>
        /// <param name="e"></param>
        /// <param name="list"></param>
        private void EnviaImagens(DoWorkEventArgs e, BindingList<EnvioModel> list)
        {
            //Inicializa Informações na tela antes de iniciar o processo de envio
            Inicializacao(list);

            //Itera sobre a lista de Pacotes a serem tranferidos
            foreach (var envio in list.ToList())
            {
                try
                {
                    Ftp.Disconnect();

                    //Verifica qual configuração de ftp sera chamado
                    var connected = Ftp.Connect(envio.Valor != 0);

                    //verifica se conseguiu conexao
                    if (connected)
                    {
                        //Pega Fotos a serem transferidas envio atual e atualiza status Cmaster para enviando
                        var fotos = GetFotos(envio);

                        //Define Erros
                        Erros = 0;

                        //faz loop nas imagens para enviar                        

                        foreach (var foto in fotos)
                        {
                            #region TRY DENTRO FOREACH

                            try
                            {
                                //Cria diretorios remotos
                                CriaDiretorios(foto);

                                //Verifica se existe arquivo no servidor
                                if (ExisteArquivo(Remotefilepath))
                                {
                                    //Caso exista verifica se esta corrompido
                                    Verificado = VerificaArquivo(LocalCompletePath, Remotefilepath);
                                }

                                //Caso o arquivo esteja corrompido reenvia o arquivo
                                if (!Verificado)
                                {
                                    //Pega array de bytes para envio
                                    var stremRead = CarregaStreamImagem(foto);

                                    //Inicia Processo de Envio//
                                    EnviaImagem(stremRead, foto, envio);
                                }

                                //Atualiza Informação apos envio da imagem
                                AtualizaInfoImagemAtual();
                            }
                            catch (Exception ex)
                            {
                                Erros++;
                                ReportaInfoView((int)EnumProgressReport.IconeErro, envio.IdEnvio);
                                ReportaInfoView((int)EnumProgressReport.ReportErro, ex.Message);
                                Thread.Sleep(500);

                                var filemanager = new FileManager(PathFile);
                                filemanager.Write(string.Format("{0} {1} {2} {3} {4}", DateTime.Now, Environment.NewLine, ex.StackTrace, Environment.NewLine, foto.NomeFoto));
                            }

                            #endregion
                        }

                        //Atualiza Status ou coloca envio na lista de erros
                        AtualizaStatusCpc(envio);

                    }
                    else
                    {
                        //Reporta falha de conexão
                        ReportaInfoView((int)EnumProgressReport.ReportErro, string.Format("Não foi possivel conectar a {0}", Config.FtpHost));
                    }

                }
                catch (Exception ex)
                {
                    ReportaInfoView((int)EnumProgressReport.ReportErro, ex.Message);
                }
            }

            //Zera Bar Total
            ReportaInfoView((int)EnumProgressReport.ZeraProgresso, EnumProgressBar.Total);
            Thread.Sleep(500);
        }

        /// <summary>
        /// Atualiza Status CPC
        /// </summary>
        /// <param name="envio"></param>
        private void AtualizaStatusCpc(EnvioModel envio)
        {
            if (Erros > 0)
            {
                //Verifica se envio atual ja esta na lista de erros
                if (ListaErro.All(a => a.IdEnvio != envio.IdEnvio))
                {
                    ListaErro.Add(envio);
                }
            }
            else
            {
                //Remove da lista de erro
                ListaErro.Remove(envio);

                //Atualiza Total de Pacotes Transferidos
                InfoGeral.PacotesTranferidos++;
                ReportaInfoView((int)EnumProgressReport.InfoEnvio, InfoGeral);

                //Retira Pacote da Lista de envio
                ReportaInfoView((int)EnumProgressReport.RemoveLista, envio.IdEnvio);
                Thread.Sleep(2000);

                ReportaInfoView((int)EnumProgressReport.ReportInfo, string.Format("Mudando Status CMaster código {0}", envio.CodigoReduzido));

                //altera status no cpc
                foreach (var item in envio.OrdensEnvio)
                {
                    //verifica se utiliza manipulacao externa e nao é brinde
                    if (LibConfig.GetByFilial(Filial.IdFilial).UsaManipulacao == true && envio.Valor > 0)
                    {
                        LibCServicEnvelope.Update(EnumStatusEnvio.AguardandoManipulacao, item.IdEnvelopeCpc);
                    }
                    else
                    {
                        LibCServicEnvelope.Update(EnumStatusEnvio.Recepcao, item.IdEnvelopeCpc);
                    }
                }

                //Atualiza o Status CMaster
                AtualizaStatusCMaster(envio);
            }
        }

        /// <summary>
        /// Atualiza Status CMaster
        /// </summary>
        /// <param name="envio"></param>
        private void AtualizaStatusCMaster(EnvioModel envio)
        {
            //Muda Status CMaster
            LibEnvio.UpdateEnvio(Dados.EnumEnvioStatus.Enviado, envio.IdEnvio);

            //Muda Status do Servico                
            foreach (var ordem in LibOrdemServico.GetByVenda(envio.IdVenda))
            {
                ordem.Status = Dados.EnumStatusServico.EnviadoLaboratorio;
                LibOrdemServico.Update(ordem);
            }
        }

        /// <summary>
        /// Cria Diretorios
        /// </summary>
        /// <param name="item"></param>
        private void CriaDiretorios(OrdemServicoItemEnvioModel item)
        {
            //Reporta status servidor
            ReportaInfoView((int)EnumProgressReport.StatusServidor, null);

            //Carrega Sessao da Foto
            Sessao = new Lib.Sessao().GetByIdFoto(item.Foto.IdFoto);

            //Cria Pasta codigo reduzido ex: 37543
            CreateDiretorioBase(Sessao);

            //Cria sub pasta com sessao da foto ex: 37543/1
            CreateSubDiretorio(Sessao);

            //Caminho do arquivo 
            LocalCompletePath = string.Format(@"\\{0}\{1}\{2}-{3}\{4}", Config.ServImagem, Config.Folder,
                Sessao.Atendimento.CodigoReduzido, Sessao.NumSessao, item.Foto.Url.Split('\\').LastOrDefault());

            //Abre arquivo remoto para escrita
            Remotefilepath = string.Format("{0}/{1}", SubDir, item.Foto.Url.Split('\\').LastOrDefault());

            //Variavel para determinar se imagem ja foi verificada no servidor
            Verificado = false;
        }

        /// <summary>
        /// Carrega array de bytes da imagem
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private byte[] CarregaStreamImagem(OrdemServicoItemEnvioModel item)
        {
            //Reporta leitura de imagem
            ReportaInfoView((int)EnumProgressReport.ReportInfo,
                string.Format("Lendo imagem {0} ", item.Foto.Url.Split('\\').LastOrDefault()));

            //Le bytes do arquivo de imagem
            var stremRead = File.ReadAllBytes(LocalCompletePath);

            //Atualiza ProgressBar Atual
            AtualizaProgressAtual(stremRead);

            ReportaInfoView((int)EnumProgressReport.Maximo, AtualStateProgress);

            //Cria stream para arquivo remoto ftp
            Ostream = Client.OpenWrite(Remotefilepath, FtpDataType.Binary);

            //Reporta salvamento de imagem online
            ReportaInfoView((int)EnumProgressReport.ReportInfo,
                string.Format("Salvando imagem {0} em {1} ", item.Foto.Url.Split('\\').LastOrDefault(), Config.FtpFolder));
            return stremRead;
        }

        /// <summary>
        /// Envia Imagem
        /// </summary>
        /// <param name="stremRead"></param>
        /// <param name="item"></param>
        /// <param name="envio"></param>
        private void EnviaImagem(byte[] stremRead, OrdemServicoItemEnvioModel item, EnvioModel envio)
        {
            if (Ostream == null) return;
            var contentRead = new byte[Buffer];
            using (Stream fs = new MemoryStream(stremRead))
            {
                int bytesRead;
                do
                {
                    bytesRead = fs.Read(contentRead, 0, Buffer);
                    Ostream.Write(contentRead, 0, bytesRead);

                    //Atualiza Progresso do Atual
                    AtualStateProgress.Progresso = bytesRead;

                    //Reporta maximo reporta atual
                    //ReportaInfoView((int)EnumProgressReport.Progress, AtualStateProgress);
                } while (!(bytesRead < Buffer));

                fs.Close();
            }

            Ostream.Close();

            ReportaInfoView((int)EnumProgressReport.ReportInfo,
                string.Format("Verificando Arquivo {0}", item.Foto.Url.Split('\\').LastOrDefault()));

            if (VerificaArquivo(LocalCompletePath, Remotefilepath))
            {
                ReportaInfoView((int)EnumProgressReport.ReportInfo,
                    string.Format("Arquivo {0} verificado com sucesso", item.Foto.Url.Split('\\').LastOrDefault()));
            }
            else
            {
                ReportaInfoView((int)EnumProgressReport.IconeErro, envio.IdEnvio);
                ReportaInfoView((int)EnumProgressReport.ReportErro, string.Format("Falha na verificação do arquivo {0}", item.Foto.Url.Split('\\').LastOrDefault()));
                Erros++;
            }
        }

        /// <summary>
        /// Atualiza Informação de arquivos transferidos e atualiza tela
        /// </summary>
        private void AtualizaInfoImagemAtual()
        {
            //Atualiza Info Pacote Atual
            InfoAtual.ArquivosTransferidos++;
            ReportaInfoView((int)EnumProgressReport.InfoPacoteAtual, InfoAtual);

            //Incrementa Arquivo enviado
            TotalArqTranferido++;

            InfoGeral.ArquivosTransferidos = TotalArqTranferido;
            ReportaInfoView((int)EnumProgressReport.InfoEnvio, InfoGeral);


            //Atualiza Progress Total
            UserStateProgressTotal.Progresso = TotalArqTranferido;
            ReportaInfoView((int)EnumProgressReport.Progress, UserStateProgressTotal);


            //Zera Bar Atual
            ReportaInfoView((int)EnumProgressReport.ZeraProgresso, EnumProgressBar.Atual);
            Thread.Sleep(500);
        }

        /// <summary>
        /// Retorna fotos, atualiza status do cmaster para enviando e atualiza informações 
        /// na tela sobre o pacote atual
        /// </summary>
        /// <param name="envio"></param>
        /// <returns></returns>
        private IEnumerable<OrdemServicoItemEnvioModel> GetFotos(EnvioModel envio)
        {
            //Atualiza Status Envio Cmaster para enviando
            LibEnvio.UpdateEnvioInicio(EnumEnvioStatus.Enviando, envio.IdEnvio);
            ReportaInfoView((int)EnumProgressReport.IconeEnviando, envio.IdEnvio);

            var fotos = CarregaImagensAgrupadas(envio);

            //Atualiza Informação do Pacote atual
            AtualizaInformacaAtual(envio, fotos);

            //Reporta para tela informação do pacote atual
            ReportaInfoView((int)EnumProgressReport.InfoPacoteAtual, InfoAtual);

            //Parametriza as informações para progressbar total
            IncializaProgressTotal(TotalArquivos);

            //Reporta maximo pbar total
            ReportaInfoView((int)EnumProgressReport.Maximo, UserStateProgressTotal);
            return fotos;
        }

        /// <summary>
        /// Calcula e envia informações Iniciais para a tela do envio
        /// </summary>
        /// <param name="list"></param>
        private void Inicializacao(BindingList<EnvioModel> list)
        {
            //Reporta Tentantiva de conexão con servidor
            ReportaInfoView((int)EnumProgressReport.ReportInfo, string.Format("Conectando a {0}", Config.FtpHost));

            //Informa conexão bem sucedida
            ReportaInfoView((int)EnumProgressReport.ReportInfo, string.Format("Conectado a {0}", Config.FtpHost));

            //Total de Arquivos Tranferidos
            TotalArqTranferido = 0;

            //Total de Arquivos
            TotalArquivos = SomaTotalImagens(list);

            //Informação Geral
            InfoGeral = ConfigInicialInfoGeral(list, TotalArqTranferido, TotalArquivos);

            //Reporta para tela informação do pacote atual
            ReportaInfoView((int)EnumProgressReport.InfoEnvio, InfoGeral);

            //Informação pacote Atual
            InfoAtual = ConfigInicialInfoAtual();

            //Reporta para tela informação do pacote atual
            ReportaInfoView((int)EnumProgressReport.InfoPacoteAtual, InfoAtual);
        }

        /// <summary>
        /// Atualiza Progresso Atual
        /// </summary>
        /// <param name="stremRead"></param>
        private void AtualizaProgressAtual(byte[] stremRead)
        {
            AtualStateProgress = new UserStateProgress
            {
                Bar = EnumProgressBar.Atual,
                Maximo = stremRead.Length
            };
        }

        /// <summary>
        /// Cria Subdiretorio
        /// </summary>
        /// <param name="sessao"></param>
        private void CreateSubDiretorio(Sessao sessao)
        {
            SubDir = string.Format("{0}/{1}", Dir, sessao.NumSessao);
            ReportaInfoView((int)EnumProgressReport.ReportInfo, string.Format("Criando diretorio {0} ", SubDir));
            Ftp.CreateDirectory(SubDir);
        }

        /// <summary>
        /// Cria Diretorio
        /// </summary>
        /// <param name="sessao"></param>
        private void CreateDiretorioBase(Sessao sessao)
        {
            Dir = string.Format("{0}/{1}", Config.FtpFolder, sessao.Atendimento.CodigoReduzido);
            ReportaInfoView((int)EnumProgressReport.ReportInfo, string.Format("Criando diretorio {0} ", Dir));
            Ftp.CreateDirectory(Dir);
        }

        /// <summary>
        /// Inicializa progresso Total
        /// </summary>
        /// <param name="totalArquivos"></param>
        private void IncializaProgressTotal(int totalArquivos)
        {
            UserStateProgressTotal = new UserStateProgress
            {
                Bar = EnumProgressBar.Total,
                Maximo = totalArquivos,
                Progresso = 0
            };
        }

        /// <summary>
        /// Atualiza Informação Atual
        /// </summary>
        /// <param name="envio"></param>
        /// <param name="fotos"></param>
        private void AtualizaInformacaAtual(EnvioModel envio, List<OrdemServicoItemEnvioModel> fotos)
        {
            InfoAtual.TotalPacote = envio.OrdensEnvio.Count;
            InfoAtual.ArquivosTransferidos = 0;
            InfoAtual.TotalImagens = fotos.Count;
        }

        /// <summary>
        /// Configuração inicial do model que mantem informações do envio atual
        /// </summary>
        /// <returns></returns>
        private static PacoteAtualModel ConfigInicialInfoAtual()
        {
            var infoAtual = new PacoteAtualModel { TotalPacote = 0, ArquivosTransferidos = 0, TotalImagens = 0 };
            return infoAtual;
        }

        /// <summary>
        /// Configuração Inicial do model que mantem informações gerais do envio
        /// </summary>
        /// <param name="list"></param>
        /// <param name="totalArqTranferido"></param>
        /// <param name="totalArquivos"></param>
        /// <returns></returns>
        private static InfoEnvioModel ConfigInicialInfoGeral(BindingList<EnvioModel> list, int totalArqTranferido, int totalArquivos)
        {
            var infoGeral = new InfoEnvioModel
            {
                ArquivosTransferidos = totalArqTranferido,
                PacotesTranferidos = 0,
                TotalArquivos = totalArquivos,
                TotalPacotes = list.Count
            };

            return infoGeral;
        }

        /// <summary>
        /// Verifica se o existe arquivo no ftp
        /// </summary>
        /// <param name="remotefilepath"></param>
        /// <returns></returns>
        private bool ExisteArquivo(string remotefilepath)
        {
            return Client.FileExists(remotefilepath);
        }

        /// <summary>
        /// Faz comparação de arquivo remoto com arquivo local
        /// </summary>
        /// <param name="localCompletePath"></param>
        /// <param name="remotefilepath"></param>
        /// <returns></returns>
        private bool VerificaArquivo(string localCompletePath, string remotefilepath)
        {
            var fileInfo = new FileInfo(localCompletePath);

            return fileInfo.Length == Client.GetFileSize(remotefilepath);

            //return new FileInfo(localCompletePath).Length != Client.GetFileSize(remotefilepath);

            //FtpHash hash;

            //if ((hash = Client.GetChecksum(remotefilepath)).IsValid)
            //{
            //    if (!hash.Verify(localCompletePath))
            //        return false;
            //}
            //else
            //{
            //    if ((new FileInfo(localCompletePath)).Length != Client.GetFileSize(remotefilepath))
            //        return false;
            //}

            //return true;
        }

        /// <summary>
        /// Retorna total de imagens
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private static int SomaTotalImagens(IEnumerable<EnvioModel> list)
        {
            var listFotos = (from envio in list from envelope in envio.OrdensEnvio from foto in envelope.OrdensServicoItem select foto).ToList();
            return listFotos.GroupBy(a => a.Foto.IdFoto).Select(a => a.FirstOrDefault()).Count();
        }

        /// <summary>
        /// Retorna Imagens
        /// </summary>
        /// <param name="envio"></param>
        /// <returns></returns>
        private static List<OrdemServicoItemEnvioModel> CarregaImagensAgrupadas(EnvioModel envio)
        {
            var fotos = envio.OrdensEnvio.SelectMany(envelope => envelope.OrdensServicoItem).ToList();
            return fotos.GroupBy(a => a.Foto.IdFoto).Select(a => a.FirstOrDefault()).ToList();
        }

        #endregion
    }
}