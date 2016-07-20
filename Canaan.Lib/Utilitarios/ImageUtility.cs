using Canaan.Lib.Componentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Lib.Utilitarios
{
    public class ImageUtility
    {
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetDiskFreeSpaceEx(string lpDirectoryName,
        out ulong lpFreeBytesAvailable,
        out ulong lpTotalNumberOfBytes,
        out ulong lpTotalNumberOfFreeBytes);


        #region CAMPOS

        private ToolStripProgressBar Status;
        private BackgroundWorker Worker;
        private OpenFileDialog Dialog;
        private ToolStripLabel LbInfo;
        private Direction Direcao;
        private Dados.Sessao Sessao;
        private Dados.SessaoPasta SessaoPasta;

        #endregion

        #region PROPRIEDADES

        private delegate ListView.ListViewItemCollection GetItems(ListView lstview);

        public bool Backup { get; set; }

        public Lib.Config LibConfig
        {
            get
            {
                return new Config();
            }
        }

        public Dados.Config Config { get; set; }

        public Lib.Session Session
        {
            get
            {
                return Session.Instance;
            }
        }

        public Lib.Foto LibFoto
        {
            get
            {
                return new Foto();
            }
        }

        public Lib.Sessao LibSessao
        {
            get
            {
                return new Sessao();
            }
        }

        public Lib.SessaoPasta LibSessaoPasta
        {
            get
            {
                return new Lib.SessaoPasta();
            }
        }

        public IEnumerable<Dados.Foto> SelectedImgs { get; set; }

        public Dados.Foto Imagem { get; set; }

        public Agendamento LibAgendamento
        {
            get
            {
                return new Agendamento();
            }
        }

        public AgendamentoMov LibAgendamentoMov
        {
            get
            {
                return new AgendamentoMov();
            }
        }

        #endregion

        #region CONSTRUTOR

        public ImageUtility(ToolStripProgressBar statusBar, BackgroundWorker worker, OpenFileDialog dialog, ToolStripLabel lbInfo)
        {
            Status = statusBar;
            Worker = worker;
            Dialog = dialog;
            LbInfo = lbInfo;

            Config = LibConfig.GetByFilial(Session.Contexto.IdFilial);

            if (Config == null)
                throw new Exception("Não existe um registro de configuração para estudio atual.");

        }

        public ImageUtility(BackgroundWorker Worker)
        {
            // TODO: Complete member initialization
            this.Worker = Worker;

            Config = LibConfig.GetByFilial(Session.Contexto.IdFilial);
        }

        #endregion

        #region EVENTOS

        public void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case (int)Acao.Cancel:
                    LbInfo.Text = "Cancelado...";
                    break;
                case (int)Acao.Delete:
                    LbInfo.Text = "Deletado...";
                    break;
                case (int)Acao.Left:
                    LbInfo.Text = "Rotacionado para Esquerda o arquivo " + e.UserState.ToString();
                    break;
                case (int)Acao.Right:
                    LbInfo.Text = "Rotacionado para Direita o arquivo " + e.UserState.ToString();
                    break;
                case (int)Acao.Error:
                    LbInfo.Text = "Erro: " + e.UserState.ToString();
                    LbInfo.ForeColor = Color.Red;
                    break;
                case (int)Acao.Calculando:
                    LbInfo.Text = "Aguarde " + e.UserState.ToString() + "...";
                    break;
                case (int)Acao.Diretorios:
                    LbInfo.Text = "Aguarde " + e.UserState.ToString() + "...";
                    break;
                case (int)Acao.Finalizado:
                    LbInfo.Text = "Finalizado";
                    break;
                default:
                    Status.Value = e.ProgressPercentage;
                    if (e.UserState != null)
                        LbInfo.Text = string.Format("Processando o arquivo {0}", e.UserState.ToString());
                    break;
            }
        }

        /// <summary>
        /// Upload
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var progress = 1;
            Worker.ReportProgress((int)Acao.Calculando, "Calculando Espaço disponivel");

            if (CalculaEspaco(Dialog.FileNames))
            {
                foreach (var file in Dialog.FileNames)
                {
                    //Verifica se existe um pedido para cancelamento
                    if (Worker.CancellationPending)
                        Worker.ReportProgress((int)Acao.Cancel, file);

                    Worker.ReportProgress(progress, Path.GetFileName(file));

                    //Carrega informações sobre o arquivo
                    var filename = Path.GetFileNameWithoutExtension(file);
                    var extensao = Path.GetExtension(file);

                    //Faz upload da imagem
                    Upload(filename, extensao, file);

                    progress++;
                }

                Worker.ReportProgress((int)Acao.Finalizado, "Finalizado.");

                if (!Backup)
                {
                    //Atualiza Cupom para Fotografado
                    AtualizaSessao(Sessao);
                    AtualizaAgendamento(Sessao);
                    AdicionaMovimentacaoAgendamento(Sessao);
                }
            }
            else
            {
                throw new Exception("Espaço disponível insuficiente para descarregar está sessão. \n Contate o Administrador");
            }
        }

        /// <summary>
        /// Atualiza Tamanho Total da Sessao
        /// </summary>
        /// <param name="Sessao"></param>
        private void AtualizaSessao(Dados.Sessao Sessao)
        {
            var valor = LibSessao.GetById(Sessao.IdSessao).Foto.Sum(a => a.Tamanho);
            Sessao.Tamanho = valor;
            LibSessao.Update(Sessao);
        }

        private void Worker_DoWorkRotateUnique(object sender, DoWorkEventArgs e)
        {
            rotacionarUnique(Direcao);
        }

        private void Worker_DoWorkRotateList(object sender, DoWorkEventArgs e)
        {
            rotacionar(Direcao);
        }

        #endregion

        #region METODOS

        public void ConfiguraComponentes()
        {

            if (Dialog != null)
                if (Dialog.FileNames.Count() <= 0)
                    throw new Exception("Nenhum arquivo de imagem selecionado");

            if (Status != null)
            {
                //Configura status bar
                Status.Value = 0;
                Status.Maximum = Dialog.FileNames.Count();
            }

            //Configura Worker
            Worker.ProgressChanged += Worker_ProgressChanged;
            Worker.WorkerReportsProgress = true;
            Worker.WorkerSupportsCancellation = true;

        }

        public void Upload(Dados.Sessao sessao, Dados.SessaoPasta sessaoPasta, bool backup)
        {
            Backup = backup;

            try
            {
                Sessao = sessao;
                SessaoPasta = sessaoPasta;

                //Remove outros eventos atribuidos
                Worker.DoWork -= Worker_DoWorkRotateList;
                Worker.DoWork -= Worker_DoWork;

                Worker.DoWork += Worker_DoWork;
                Worker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Rotaciona uma lista de itens
        /// </summary>
        /// <param name="selectedImgs"></param>
        /// <param name="sessao"></param>
        /// <param name="direcao"></param>
        public void rotacionar(IEnumerable<Dados.Foto> selectedImgs, Dados.Sessao sessao, Direction direcao)
        {
            Sessao = sessao;
            SelectedImgs = selectedImgs;
            Direcao = direcao;

            //Remove outros eventos adicionados
            Worker.DoWork -= Worker_DoWork;
            Worker.DoWork -= Worker_DoWorkRotateList;

            Status.Minimum = 0;
            Status.Maximum = SelectedImgs.Count();

            Worker.DoWork += Worker_DoWorkRotateList;
            Worker.RunWorkerAsync();
        }

        private void rotacionar(Direction direcao)
        {

            int progress = 0;

            foreach (var foto in SelectedImgs)
            {
                if (direcao == Direction.Left)
                    Worker.ReportProgress((int)Acao.Left, foto.Nome);
                else
                    Worker.ReportProgress((int)Acao.Right, foto.Nome);

                var pathImage = string.Format(@"\\{0}\{1}\{2}", Config.ServImagem, Config.Folder, foto.Url);
                var paththumb = string.Format(@"\\{0}\{1}\{2}", Config.ServImagem, Config.Folder, foto.Thumb);

                var thumb = Image.FromStream(new MemoryStream(VerificaCriptografia(foto, paththumb)));
                var image = Image.FromStream(new MemoryStream(VerificaCriptografia(foto, pathImage)));

                if (direcao == Direction.Left)
                {
                    image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    thumb.RotateFlip(RotateFlipType.Rotate270FlipNone);
                }
                else
                {
                    image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    thumb.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }

                if (foto.Sessao.IsCriptografado)
                {
                    //cria a imagem criptografada
                    byte[] imagemCripto = Criptografia.Criptografa(GetBytes(image));
                    File.WriteAllBytes(pathImage, imagemCripto);

                    //cria o thumb criptografado
                    byte[] thumbCripto = Criptografia.Criptografa(GetBytes(thumb));
                    File.WriteAllBytes(paththumb, thumbCripto);
                }
                else
                {
                    image.Save(pathImage);
                    thumb.Save(paththumb);
                }

                progress++;
                Worker.ReportProgress(progress, string.Empty);
            }

            Worker.ReportProgress((int)Acao.Finalizado, string.Empty);
        }

        /// <summary>
        /// Rotaciona um unico item
        /// </summary>
        /// <param name="img"></param>
        /// <param name="sessao"></param>
        /// <param name="direcao"></param>
        public void rotacionar(Dados.Foto img, Dados.Sessao sessao, Direction direcao)
        {
            Sessao = sessao;
            Imagem = img;
            Direcao = direcao;

            Worker.DoWork += Worker_DoWorkRotateUnique;
            Worker.RunWorkerAsync();
        }

        private void rotacionarUnique(Direction direcao)
        {
            var pathImage = string.Format(@"\\{0}\{1}", Config.ServImagem, Imagem.Url);
            var paththumb = string.Format(@"\\{0}\{1}", Config.ServImagem, Imagem.Thumb);

            var thumb = Image.FromStream(new MemoryStream(File.ReadAllBytes(paththumb)));
            var image = Image.FromStream(new MemoryStream(File.ReadAllBytes(pathImage)));

            if (direcao == Direction.Left)
            {
                image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                thumb.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            else
            {
                image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                thumb.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

            image.Save(pathImage);
            thumb.Save(paththumb);
        }

        private void Upload(string filename, string extensao, string caminho)
        {
            //Carrega Configurações
            var criptografado = Config.IsCriptogradado;
            var idAtendimento = Sessao.Atendimento.CodigoReduzido.ToString();
            var numSessao = Sessao.NumSessao.ToString();

            var servidor = Config.ServImagem;
            var folder = Config.Folder;

            //Ex: \\Servcmaster\Fotografados\810\
            //var diretorio = string.Format(@"\\{0}\{1}\{2}-{3}", servidor, folder, idAtendimento, numSessao);
            var diretorio = string.Format(@"\\{0}\{1}\{2}", servidor, folder, SessaoPasta.Caminho);

            //Ex: \\Servcmaster\Fotografados\810\1
            //var subdiretorio = Path.Combine(diretorio, numSessao);
            var thumb = Path.Combine(diretorio, "thumb");

            //Cria diretorio para salvar imagens
            CriarDiretorio(diretorio);
            CriarDiretorio(thumb);

            //Retorna as Imagens
            var img = GetImagem(caminho);
            var thumbFile = CreateThumbnail(img);

            //Verifica a extensão
            if (criptografado)
            {
                extensao = ".canaan";
            }

            //Configura nome do Arquivo
            var fullPathFile = Path.Combine(diretorio, string.Format("{0}{1}", filename, extensao));
            filename = VerificaExiste(diretorio, filename, extensao);


            //Caminho completo do arquivo
            var fullPathThumbFile = Path.Combine(string.Format(@"{0}\{1}", diretorio, "thumb"), string.Format("{0}{1}", filename, extensao));

            if (criptografado)
            {
                //cria a imagem criptografada
                byte[] imagemCripto = Criptografia.Criptografa(GetBytes(img));
                File.WriteAllBytes(fullPathFile, imagemCripto);

                //cria o thumb criptografado
                byte[] thumbCripto = Criptografia.Criptografa(GetBytes(thumbFile));
                File.WriteAllBytes(fullPathThumbFile, thumbCripto);
            }


            //Salva Imagens
            if (!File.Exists(fullPathFile))
                img.Save(fullPathFile);

            if (!File.Exists(fullPathThumbFile))
                thumbFile.Save(fullPathThumbFile);

            //Prepara dados para salvar no banco
            var name = string.Format("{0}{1}", filename, extensao);
            var url = string.Format(@"{0}\{1}{2}", SessaoPasta.Caminho, filename, extensao);
            var urlthumb = string.Format(@"{0}\thumb\{1}{2}", SessaoPasta.Caminho, filename, extensao);
            var tamanho = GetTamanho(fullPathFile);
            var mime = GetMimeType(img);
            var hora = GetHoraImage(img);


            if (!Backup)
            {

                LibFoto.Insert(
                    new Dados.Foto
                    {
                        IdSessao = Sessao.IdSessao,
                        IdSessaoPasta = SessaoPasta.IdSessaoPasta,
                        Nome = Path.GetFileNameWithoutExtension(fullPathFile),
                        Url = url,
                        Tamanho = (int)tamanho,
                        MimeType = mime,
                        IsAtivo = true,
                        Hora = hora,
                        Thumb = urlthumb
                    }
                );
            }
        }

        private string GetMimeType(Image img)
        {
            ImageFormat format = img.RawFormat;
            ImageCodecInfo codec = ImageCodecInfo.GetImageDecoders().First(c => c.FormatID == format.Guid);
            return codec.MimeType;
        }

        private long GetTamanho(string fullPathFile)
        {
            var imgInfo = new FileInfo(fullPathFile);
            return imgInfo.Length;
        }

        private DateTime GetHoraImage(Image img)
        {
            DateTime dtaken;

            try
            {
                PropertyItem propItem = img.GetPropertyItem(306);

                //Convert date taken metadata to a DateTime object
                string sdate = Encoding.UTF8.GetString(propItem.Value).Trim();
                string secondhalf = sdate.Substring(sdate.IndexOf(" "), (sdate.Length - sdate.IndexOf(" ")));
                string firsthalf = sdate.Substring(0, 10);

                firsthalf = firsthalf.Replace(":", "-");
                sdate = firsthalf + secondhalf;
                dtaken = DateTime.Parse(sdate);
            }
            catch (Exception)
            {
                dtaken = DateTime.Now;
            }
            
            return dtaken;
        }

        private Image CreateThumbnail(Image img)
        {
            var imagem = new Kaliko.ImageLibrary.KalikoImage(img);
            imagem.BackgroundColor = Color.White;
            return imagem.GetThumbnailImage(200, 200, Kaliko.ImageLibrary.ThumbnailMethod.Pad).Image;
        }

        private Image GetImagem(string filename)
        {
            if (Path.GetExtension(filename) == ".canaan")
            {
                return Image.FromStream(new MemoryStream(Criptografia.Descriptografa(GetBytes(filename))));
            }
            else
            {
                return Image.FromStream(GetStream(filename));
            }
        }

        private Stream GetStream(string filename)
        {
            return new MemoryStream(GetBytes(filename));
        }

        private byte[] GetBytes(string filename)
        {
            return File.ReadAllBytes(filename);
        }

        public static byte[] GetBytes(Image imagem)
        {
            var codec = ImageCodecInfo.GetImageEncoders().Where(a => a.MimeType == "image/jpeg").FirstOrDefault();
            var ep = new EncoderParameters();
            ep.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)100);

            MemoryStream ms = new MemoryStream();
            imagem.Save(ms, codec, ep);

            return ms.ToArray();
        }

        public static Image GetFromPath(string filename)
        {
            return Image.FromFile(filename);
        }

        public static Bitmap GetFromURL(string url)
        {
            System.Net.HttpWebRequest wreq;
            System.Net.HttpWebResponse wresp;
            Stream mystream;
            Bitmap bmp;

            bmp = null;
            mystream = null;
            wresp = null;
            try
            {
                wreq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(url);
                wreq.AllowWriteStreamBuffering = true;

                wresp = (System.Net.HttpWebResponse)wreq.GetResponse();

                if ((mystream = wresp.GetResponseStream()) != null)
                    bmp = new Bitmap(mystream);
            }
            catch
            {
                // Do nothing... 
            }
            finally
            {
                if (mystream != null)
                    mystream.Close();

                if (wresp != null)
                    wresp.Close();
            }

            return (bmp);
        }

        public static Image GetThumbnail(Image img, int width, int height)
        {
            var imagem = new Kaliko.ImageLibrary.KalikoImage(img);
            imagem.BackgroundColor = Color.White;
            return imagem.GetThumbnailImage(width, height, Kaliko.ImageLibrary.ThumbnailMethod.Pad).Image;
        }

        /// <summary>
        /// Cria diretorios
        /// </summary>
        /// <param name="diretorio"></param>
        private void CriarDiretorio(string diretorio)
        {
            try
            {
                if (!Directory.Exists(diretorio))
                    Directory.CreateDirectory(diretorio);
            }
            catch (Exception ex)
            {
                Worker.ReportProgress((int)Acao.Error, ex.Message + diretorio);
            }
        }

        /// <summary>
        /// Verifica se existe algum arquivo com o mesmo nome
        /// </summary>
        /// <param name="path"></param>
        /// <param name="filename"></param>
        /// <param name="extensao"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string VerificaExiste(string path, string filename, string extensao, int count = 0)
        {
            bool existe = true;

            var img = string.Format(@"{0}\{1}{2}", path, filename, extensao);
            var thumb = string.Format(@"{0}\{1}{2}\thumb", path, filename, extensao);

            while (existe == true)
            {
                //verifica se imagem existe
                if (File.Exists(img) && File.Exists(thumb))
                {
                    count++;
                    filename = filename + count.ToString();
                }
                else
                {
                    existe = false;
                }
            }

            return filename;
        }

        /// <summary>
        /// Calcula espaço a ser utilizado para armazenar as imagens selecionadas
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        private bool CalculaEspaco(string[] files)
        {
            var totalArq = files.Sum(a => new FileInfo(a).Length);
            var freeSpace = GetFreeSpace();
            return freeSpace > ulong.Parse(totalArq.ToString());
        }

        /// <summary>
        /// Retorna espaço livre da rede
        /// </summary>
        /// <returns></returns>
        private ulong GetFreeSpace()
        {

            ulong FreeBytesAvailable;
            ulong TotalNumberOfBytes;
            ulong TotalNumberOfFreeBytes;
            string diretorio = string.Format(@"\\{0}\{1}", Config.ServImagem, Config.Folder);

            bool success = GetDiskFreeSpaceEx(diretorio, out FreeBytesAvailable, out TotalNumberOfBytes, out TotalNumberOfFreeBytes);

            if (!success)
                Worker.ReportProgress((int)Acao.Error, string.Format("O caminho {0} não foi encontrado. Entre em contato com o Administrador.", diretorio));

            return FreeBytesAvailable;


        }

        private void AtualizaAgendamento(Dados.Sessao Sessao)
        {
            var agendamento = LibAgendamento.GetById(Sessao.Atendimento.Agendamento.IdAgendamento);
            agendamento.Status = Dados.EnumAgendamentoStatus.Fotografado;
            LibAgendamento.Update(agendamento);
        }

        private void AdicionaMovimentacaoAgendamento(Dados.Sessao Sessao)
        {
            var agendamento = LibAgendamento.GetById(Sessao.Atendimento.Agendamento.IdAgendamento);
            LibAgendamentoMov.Insert(new Dados.AgendamentoMov
            {
                IdAgendamento = agendamento.IdAgendamento,
                IdUsuario = Session.Instance.Usuario.IdUsuario,
                Status = Dados.EnumAgendamentoStatus.Fotografado,
                Data = DateTime.Today,
                Hora = DateTime.Now.TimeOfDay
            });
        }

        public static byte[] GetBytesFromResource(Image img)
        {
            byte[] byteArray = new byte[0];
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, ImageFormat.Png);
                stream.Close();

                byteArray = stream.ToArray();
            }
            return byteArray;
        }

        public static byte[] VerificaCriptografia(Dados.Foto item, string file)
        {

            if (item.Sessao.IsCriptografado || Path.GetExtension(file).Equals(".canaan"))
            {
                return Criptografia.Descriptografa(File.ReadAllBytes(file));
            }
            else
            {
                return File.ReadAllBytes(file);
            }

        }

        #endregion
    }
}
