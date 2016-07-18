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

        public Lib.CliFor LibCLiente
        {
            get
            {
                return new Lib.CliFor();
            }
        }

        private Dados.Sessao Sessao;

        public Foto LibFoto
        {
            get
            {
                return new Foto();
            }
        }

        public Config LibConfig
        {
            get
            {
                return new Config();
            }
        }

        public Dados.Config Config { get; set; }

        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }

        public List<MemoryStream> Fotos { get; set; }

        public Imagem(Dados.Sessao Sessao)
        {
            // TODO: Complete member initialization
            this.Sessao = Sessao;
            Config = LibConfig.GetByFilial(Session.Contexto.Filial.IdFilial);

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
                    utility.Upload(Sessao, false);
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
            var frm = new Restaurar(Sessao);
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

                        var file = string.Format(@"\\{0}\{1}\{2}", Config.ServImagem, Config.Folder, item.Thumb);
                        var fileCanaan = string.Format(@"\\{0}\{1}\{2}.canaan", Config.ServImagem, Config.Folder, item.Thumb.Split('.').FirstOrDefault());

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

        #endregion

        #region METODOS

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
            //Inicializa Fotos
            if (Fotos == null)
                Fotos = new List<MemoryStream>();

            try
            {
                //Limpa compenentes
                imgList.Images.Clear();
                lstFotos.Items.Clear();


                //Carrega lista de fotos
                var listaFotos = LibFoto.GetBySessao(Sessao.IdSessao);

                //verifica se é para sincronizar o caderno
                var direBase = string.Format(@"\\{0}\{1}\{2}-{3}", Config.ServImagem, Config.Folder, Sessao.Atendimento.CodigoReduzido, Sessao.NumSessao);

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
    }
}


