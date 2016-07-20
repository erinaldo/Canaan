using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Lib.Componentes;
using Canaan.Lib.Utilitarios;
using Canaan.Telas.Properties;
using Canaan.Telas.Rotinas.Backup;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Movimentacoes.Sessao.Telas
{
    public partial class Imagem : XtraForm
    {

        #region PROPRIEDADES

        public BackgroundWorker Worker { get; set; }

        public Lib.Sessao LibSessao
        {
            get
            {
                return new Lib.Sessao();
            }
        }

        public Lib.SessaoPasta LibSessaoPasta
        {
            get
            {
                return new Lib.SessaoPasta();
            }
        }

        public Lib.CliFor LibCLiente
        {
            get
            {
                return new Lib.CliFor();
            }
        }

        public Lib.Foto LibFoto
        {
            get
            {
                return new Lib.Foto();
            }
        }

        public Lib.Config LibConfig
        {
            get
            {
                return new Lib.Config();
            }
        }

        private Dados.Sessao Sessao;

        private Dados.SessaoPasta SessaoPasta { get; set; }
        
        public Dados.Config Config { get; set; }

        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }

        public List<MemoryStream> Fotos { get; set; }

        #endregion

        #region CONSTRUTORES

        public Imagem(Dados.Sessao Sessao, int idPasta)
        {
            // TODO: Complete member initialization
            this.Sessao = Sessao;
            this.SessaoPasta = LibSessaoPasta.GetById(idPasta);
            this.Config = LibConfig.GetByFilial(Session.Contexto.Filial.IdFilial);

            InitializeComponent();

            //Remove grip status bar
            statusBar.SizingGrip = false;
            lbInfo.Text = string.Empty;
        }

        #endregion

        #region EVENTOS

        public void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CarregaImagens();
            AtualizaSessao();
        }

        private void Imagem_Load(object sender, EventArgs e)
        {
            AtualizaImagens(false);
            CarregaImagens();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            try
            {
                Worker = new BackgroundWorker();
                Worker.RunWorkerCompleted += worker_RunWorkerCompleted;

                if (dialogFile.ShowDialog() == DialogResult.OK)
                {
                    var utility = new ImageUtility(progressBar, Worker, dialogFile, lbInfo);
                    utility.ConfiguraComponentes();
                    utility.Upload(Sessao, SessaoPasta, false);
                }

            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void rotacionarEsquerda_Click(object sender, EventArgs e)
        {
            try
            {
                Worker = new BackgroundWorker();
                Worker.RunWorkerCompleted += worker_RunWorkerCompleted;

                var selectedImgs = lstFotos.SelectedItems.Cast<CListViewItem>().Select(a => a.Item).Cast<Dados.Foto>().ToList();

                if (selectedImgs.Count() > 0)
                {

                    var utility = new ImageUtility(progressBar, Worker, dialogFile, lbInfo);
                    utility.ConfiguraComponentes();

                    //Armazena imagens selecionadas
                    utility.rotacionar(selectedImgs, Sessao, Direction.Left);
                }
                else
                {
                    MessageBoxUtilities.MessageInfo("Nennhuma Imagem selecionada");
                }

            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }

        }

        private void rotacionarDireita_Click(object sender, EventArgs e)
        {
            try
            {
                Worker = new BackgroundWorker();
                Worker.RunWorkerCompleted += worker_RunWorkerCompleted;

                var selectedImgs = lstFotos.SelectedItems.Cast<CListViewItem>().Select(a => a.Item).Cast<Dados.Foto>().ToList();

                if (selectedImgs.Count() > 0)
                {

                    var utility = new ImageUtility(progressBar, Worker, dialogFile, lbInfo);
                    utility.ConfiguraComponentes();

                    //Armazena imagens selecionadas
                    utility.rotacionar(selectedImgs, Sessao, Direction.Right);
                }
                else
                {
                    MessageBoxUtilities.MessageInfo("Nennhuma Imagem selecionada");
                }

            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void lstFotos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selectedImg = lstFotos.SelectedItems.Cast<CListViewItem>().FirstOrDefault();

                if (selectedImg != null)
                {
                    var item = selectedImg.Item as Dados.Foto;
                    var lista = lstFotos.Items.Cast<CListViewItem>().Select(a => a.Item).Cast<Dados.Foto>().Select(a => a).ToList();
                    var index = lista.IndexOf(item);

                    var frm = new FullViewer(index, lista, Sessao);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBoxUtilities.MessageWarning("Nenhuma imagem selecionada");
                }

            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void btBackup_Click(object sender, EventArgs e)
        {
            var frm = new Restaurar(Sessao, SessaoPasta);
            frm.ShowDialog();

            CarregaImagens();
        }

        private void Imagem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            GC.Collect();
        }

        private void btExcluirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                var fotos = lstFotos.SelectedItems.Cast<CListViewItem>().Select(a => a.Item).Cast<Dados.Foto>();
                if (MessageBoxUtilities.MessageQuestion("Deseja excluir todas as fotos selecionadas") == DialogResult.Yes)
                {
                    foreach (var item in fotos)
                    {
                        LibFoto.Delete(item.IdFoto);

                        var thumb = string.Format(@"\\{0}\{1}\{2}", Config.ServImagem, Config.Folder, item.Thumb);
                        var thumbCanaan = string.Format(@"\\{0}\{1}\{2}.canaan", Config.ServImagem, Config.Folder, item.Thumb.Split('.').FirstOrDefault());

                        if (File.Exists(thumb))
                        {
                            File.Delete(thumb);
                        }
                        else if (File.Exists(thumbCanaan))
                        {
                            File.Delete(thumbCanaan);
                        }


                        var file = string.Format(@"\\{0}\{1}\{2}", Config.ServImagem, Config.Folder, item.Url);
                        var fileCanaan = string.Format(@"\\{0}\{1}\{2}.canaan", Config.ServImagem, Config.Folder, item.Url.Split('.').FirstOrDefault());

                        if (File.Exists(file))
                        {
                            File.Delete(file);
                        }
                        else if (File.Exists(fileCanaan))
                        {
                            File.Delete(file);
                        }

                    }

                    CarregaImagens();
                    MessageBoxUtilities.MessageInfo("Imagens deletadas sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void adicionarNoCadernoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void cartaFotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedImg = lstFotos.SelectedItems.Cast<CListViewItem>().FirstOrDefault();

                if (selectedImg != null)
                {
                    //declara as variaveis
                    Image imagem;
                    var item = selectedImg.Item as Dados.Foto;
                    var direBase = string.Format(@"\\{0}\{1}\{2}-{3}", Config.ServImagem, Config.Folder, Sessao.Atendimento.CodigoReduzido, Sessao.NumSessao);
                    var file = string.Format(@"\\{0}\{1}\{2}", Config.ServImagem, Config.Folder, item.Url);
                    var fileCanaan = string.Format(@"\\{0}\{1}\{2}.canaan", Config.ServImagem, Config.Folder, item.Url.Split('.').FirstOrDefault());
                    var cliente = LibCLiente.GetCliByAtendimento(Sessao.IdAtendimento).FirstOrDefault();

                    //carrega a imagem
                    if (File.Exists(file))
                    {
                        imagem = Image.FromStream(new MemoryStream(CarregaImagem(file)));
                    }
                    else if (File.Exists(fileCanaan))
                    {
                        imagem = Image.FromStream(new MemoryStream(CarregaImagem(fileCanaan)));
                    }
                    else
                    {
                        imagem = Image.FromStream(new MemoryStream(ImageUtility.GetBytesFromResource(Resources.no_image_big)));
                    }

                    //mensagem de retorno
                    MessageBoxUtilities.MessageWarning("Carta Foto criada com sucesso");
                }
                else
                {
                    MessageBoxUtilities.MessageWarning("Nenhuma imagem selecionada");
                }

            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            AtualizaImagens(true);
            CarregaImagens();
        }

        #endregion

        #region METODOS

        public void AtualizaImagens(bool forceThumb)
        {
            var folder = string.Format(@"\\{0}\{1}\{2}", this.Config.ServImagem, this.Config.Folder, this.SessaoPasta.Caminho);
            var files = System.IO.Directory.EnumerateFiles(folder);

            foreach (var file in files)
            {
                var filename = file.Substring(file.LastIndexOf(@"\") + 1);
                var thumb = string.Format(@"{0}\thumb\{1}", this.SessaoPasta.Caminho, filename);
                var url = string.Format(@"{0}\{1}", this.SessaoPasta.Caminho, filename);

                //verifica se existe no banco de dados
                if (LibFoto.GetByURL(url).Count == 0)
                {
                    //insere no banco de dados
                    var foto = new Dados.Foto();
                    foto.IdSessao = this.Sessao.IdSessao;
                    foto.IdSessaoPasta = this.SessaoPasta.IdSessaoPasta;
                    foto.Nome = filename;
                    foto.Url = url;
                    foto.Hora = DateTime.Now;
                    foto.Tamanho = 0;
                    foto.MimeType = "image/jpeg";
                    foto.Thumb = thumb;
                    foto.IsAtivo = true;
                    foto.IsSelected = false;

                    LibFoto.Insert(foto);

                    //cria o thumbnail para novas imagens
                    try
                    {
                        var imagem = Image.FromFile(file);
                        var thumbImage = Lib.Utilitarios.ImageUtility.GetThumbnail(imagem, 200, 200);
                        thumbImage.Save(string.Format(@"{0}\thumb\{1}", folder, filename));
                    }
                    catch (Exception) { }
                }

                if (forceThumb)
                {
                    //recira todos os thumbs
                    try
                    {
                        var imagem = Image.FromFile(file);
                        var thumbImage = Lib.Utilitarios.ImageUtility.GetThumbnail(imagem, 200, 200);
                        thumbImage.Save(string.Format(@"{0}\thumb\{1}", folder, filename));
                    }
                    catch (Exception) { }
                }

                
            }
        }

        public void AtualizaSessao()
        {
            try
            {
                //Retorna todas as fotos
                var fotos = LibFoto.GetBySessao(Sessao.IdSessao).OrderBy(a => a.Hora.TimeOfDay).ToList();

                //Conta quantidade de fotos
                Sessao.QuantidadeFoto = fotos.Count();

                //Calcula tempo de sessao
                Sessao.TempoSessao = fotos.LastOrDefault().Hora.TimeOfDay - fotos.FirstOrDefault().Hora.TimeOfDay;

                LibSessao.Update(Sessao);
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void CarregaImagens()
        {
            //titulo
            tabPage1.Text = SessaoPasta.Nome;

            //Inicializa Fotos
            if (Fotos == null)
                Fotos = new List<MemoryStream>();

            try
            {
                //Limpa compenentes
                imgList.Images.Clear();
                lstFotos.Items.Clear();


                //Carrega lista de fotos
                var listaFotos = LibFoto.GetBySessaoPasta(Sessao.IdSessao, SessaoPasta.IdSessaoPasta);

                //verifica se é para sincronizar o caderno
                var direBase = string.Format(@"\\{0}\{1}", Config.ServImagem, Config.Folder);

                if (!Directory.Exists(direBase))
                {
                    Fotos = listaFotos.Select(a => new MemoryStream(ImageUtility.GetBytesFromResource(Resources.no_image))).ToList();
                    imgList.Images.AddRange(Fotos.Select(a => Image.FromStream(a)).ToArray());

                    lstFotos.Items.AddRange(listaFotos.Select((a, i) => new CListViewItem(a, a.Nome, i)).ToArray());
                    lstFotos.LargeImageList = imgList;
                    lstFotos.Refresh();
                    lstFotos.EndUpdate();
                }
                else
                {
                    Fotos.Clear();

                    foreach (var item in listaFotos)
                    {
                        var file = string.Format(@"\\{0}\{1}\{2}", Config.ServImagem, Config.Folder, item.Thumb);
                        var fileCanaan = string.Format(@"\\{0}\{1}\{2}.canaan", Config.ServImagem, Config.Folder, item.Thumb.Split('.').FirstOrDefault());

                        if (File.Exists(file))
                        {
                            Fotos.Add(new MemoryStream(ImageUtility.VerificaCriptografia(item, file)));
                        }
                        else if (File.Exists(fileCanaan))
                        {
                            Fotos.Add(new MemoryStream(ImageUtility.VerificaCriptografia(item, fileCanaan)));
                        }
                        else
                        {
                            Fotos.Add(new MemoryStream(ImageUtility.GetBytesFromResource(Resources.no_image)));
                        }

                    }

                    imgList.Images.AddRange(Fotos.Select(a => Image.FromStream(a)).ToArray());

                    lstFotos.Items.AddRange(listaFotos.Select((a, i) => new CListViewItem(a, a.Nome, i)).ToArray());
                    lstFotos.LargeImageList = imgList;
                    lstFotos.Refresh();
                    lstFotos.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private byte[] CarregaImagem(string file)
        {
            if (Sessao.IsCriptografado || Path.GetExtension(file).Equals(".canaan"))
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


