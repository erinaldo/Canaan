using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Lib.Utilitarios;
using Canaan.Telas.Properties;
using DevExpress.XtraEditors;
using Config = Canaan.Lib.Config;
using Foto = Canaan.Dados.Foto;

namespace Canaan.Telas.Movimentacoes.Sessao.Telas
{
    public partial class FullViewer : XtraForm
    {
        #region PROPRIEDADES

        public int CurrentIndex { get; set; }

        public Foto CurrentItem { get; set; }

        public List<Foto> Lista { get; set; }

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

        public BackgroundWorker Worker { get; set; }

        public Dados.Sessao Sessao { get; set; }

        public Dados.SessaoPasta SessaoPasta { get; set; }

        public Dados.Venda Venda { get; set; }

        public VendaFoto LibVendaFoto
        {
            get
            {
                return new VendaFoto();
            }
        }

        public Lib.Foto LibFoto
        {
            get
            {
                return new Lib.Foto();
            }
        }

        public List<Foto> FotosVenda { get; set; }

        public Image ImageBtAddAndRemoveVenda { get; set; }

        public string TextBtAddAndRemoveVenda { get; set; }

        public bool FotoIsVenda { get; set; }

        #endregion

        #region CONSTRUTOR

        public FullViewer(int currentIndex, List<Foto> lista, Dados.Sessao sessao, Dados.Venda venda = null)
        {
            CurrentIndex = currentIndex;

            Lista = lista;
            Sessao = sessao;
            Venda = venda;

            if (Venda != null)
                CarregaFotosVenda();
            else
                SessaoPasta = new Lib.SessaoPasta().GetById(Lista.FirstOrDefault().IdSessaoPasta.GetValueOrDefault());

            if (lista.Count > 0 && currentIndex < lista.Count)
                CurrentItem = lista[currentIndex];

            Config = LibConfig.GetByFilial(Session.Contexto.IdFilial);

            InitializeComponent();
        }

        private void CarregaFotosVenda()
        {
            FotosVenda = LibFoto.GetByVenda(Venda.IdPedido);
        }


        #endregion

        #region EVENTOS

        private void FullViewer_Load(object sender, EventArgs e)
        {
            CarregaCurrent();
            ConfiguraForm();
            IsVenda();
        }

        private void back_Click(object sender, EventArgs e)
        {
            try
            {
                Anterior();
            }
            catch (Exception ex)
            {

                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void forward_Click(object sender, EventArgs e)
        {
            try
            {
                Proximo();
            }
            catch (Exception ex)
            {

                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Proximo();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                timer.Start();
                btPlay.Image = Resources.pause;
            }
            else
            {
                timer.Stop();
                btPlay.Image = Resources.play;
            }
        }

        private void girarEsquerda_Click(object sender, EventArgs e)
        {
            try
            {
                bNavigator.Enabled = false;
                Girar(Direction.Left);
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void giraDireita_Click(object sender, EventArgs e)
        {
            try
            {
                bNavigator.Enabled = false;
                Girar(Direction.Right);
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CarregaCurrent();
            bNavigator.Enabled = true;
        }

        private void tsAddVenda_Click(object sender, EventArgs e)
        {
            if (!FotoIsVenda)
            {
                //insere na pasta de selecionadas
                InsereSelecionada();

                //insere na venda
                LibVendaFoto.Insert(new Dados.VendaFoto
                {
                    IdPedido = Venda.IdPedido,
                    IdFoto = CurrentItem.IdFoto
                });

                //Atualiza Lista de Botão de Remove/Add foto à venda.
                CarregaFotosVenda();
                IsVenda();

                //MessageBoxUtilities.MessageInfo(string.Format("Imagem {0} adicionada à venda com sucesso", CurrentItem.Nome));
            }
            else
            {
                //deleta das selecionadas
                RemoveSelecionada();

                //deleta da venda
                LibVendaFoto.Delete(CurrentItem.IdFoto, Venda.IdPedido);

                //Atualiza Lista de Botão de Remove/Add foto à venda.
                CarregaFotosVenda();
                IsVenda();

                //MessageBoxUtilities.MessageInfo(string.Format("Imagem {0} removida da venda com sucesso", CurrentItem.Nome));
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FullViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            GC.Collect();
        }

        private void btAddSelecionada_Click(object sender, EventArgs e)
        {
            if (CurrentItem.IsSelected != true)
            {
                InsereSelecionada();
                CarregaCurrent();
            }
            else
            {
                RemoveSelecionada();
                CarregaCurrent();
            }
        }

        #endregion

        #region METODOS

        private void CarregaCurrent()
        {            

            try
            {
                //var direBase = string.Format(@"\\{0}\{1}\{2}-{3}", Config.ServImagem, Config.Folder, Sessao.Atendimento.CodigoReduzido, Sessao.NumSessao);
                var direBase = string.Format(@"\\{0}\{1}", Config.ServImagem, Config.Folder);

                //nome da imagem
                txtNome.Text = CurrentItem.Nome;

                //icone do botao
                if (CurrentItem.IsSelected == true)
                {
                    btAddSelecionada.Image = Resources.delete;
                    btAddSelecionada.Text = "Remover das Selecionadas";
                }
                else
                {
                    btAddSelecionada.Image = Resources.add_list;
                    btAddSelecionada.Text = "Adicionar as Selecionadas";
                }

                //carrega a imagem
                if (Directory.Exists(direBase))
                {
                    var file = string.Format(@"\\{0}\{1}\{2}", Config.ServImagem, Config.Folder, CurrentItem.Url);
                    var fileCanaan = string.Format(@"\\{0}\{1}\{2}.canaan", Config.ServImagem, Config.Folder, CurrentItem.Url.Split('.').FirstOrDefault());

                    if (File.Exists(file))
                    {
                        pictureBox1.Image = Image.FromStream(new MemoryStream(CarregaImagem(file)));
                    }
                    else if (File.Exists(fileCanaan))
                    {
                        pictureBox1.Image = Image.FromStream(new MemoryStream(CarregaImagem(fileCanaan)));
                    }
                    else
                    {
                        pictureBox1.Image = Image.FromStream(new MemoryStream(ImageUtility.GetBytesFromResource(Resources.no_image_big)));
                    }
                }
                else
                {
                    pictureBox1.Image = Image.FromStream(new MemoryStream(ImageUtility.GetBytesFromResource(Resources.no_image_big)));
                }

                if (Venda != null)
                    IsVenda();
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

        private void Anterior()
        {
            if (CurrentIndex > 0)
            {
                CurrentIndex--;
                CurrentItem = Lista[CurrentIndex];
                CarregaCurrent();
            }
            else
            {
                CurrentIndex = Lista.Count - 1;
                CurrentItem = Lista[CurrentIndex];
                CarregaCurrent();
            }
        }

        private void Proximo()
        {
            if (CurrentIndex < Lista.Count - 1)
            {
                CurrentIndex++;
                CurrentItem = Lista[CurrentIndex];
                CarregaCurrent();
            }
            else
            {
                CurrentIndex = 0;
                CurrentItem = Lista[CurrentIndex];
                CarregaCurrent();
            }
        }

        private void IsVenda()
        {
            if (FotosVenda == null || FotosVenda.Count <= 0)
                return;

            if (FotosVenda.Any(a => a.IdFoto == CurrentItem.IdFoto))
            {
                ImageBtAddAndRemoveVenda = Resources.delete;
                TextBtAddAndRemoveVenda = "Remover das Selecionadas";
                FotoIsVenda = true;
            }
            else
            {
                ImageBtAddAndRemoveVenda = Resources.add_list;
                TextBtAddAndRemoveVenda = "Adicionar as Selecionadas";
                FotoIsVenda = false;
            }

            btAddVenda.Image = ImageBtAddAndRemoveVenda;
            btAddVenda.Text = TextBtAddAndRemoveVenda;
        }

        private void Girar(Direction direction)
        {
            Worker = new BackgroundWorker();
            Worker.RunWorkerCompleted += Worker_RunWorkerCompleted;

            if (CurrentItem != null)
            {
                var utility = new ImageUtility(Worker);
                utility.ConfiguraComponentes();
                utility.rotacionar(CurrentItem, Sessao, direction);
            }
            else
            {
                MessageBoxUtilities.MessageInfo("Nennhuma Imagem selecionada");
            }
        }

        private void ConfiguraForm()
        {
            if (Venda != null)
            {
                btAddSelecionada.Visible = false;
                btAddVenda.Visible = true;
                tsSeparator.Visible = true;
            }
            else
            {
                //verifica se existe pasta de selecionados
                var libPastas = new Lib.Pasta();
                if (libPastas.GetByNome("Selecionadas").Count > 0 && SessaoPasta != null)
                {
                    var pastaSelecionada = libPastas.GetByNome("Selecionadas").FirstOrDefault();
                    if(SessaoPasta.Nome != pastaSelecionada.Nome)
                        btAddSelecionada.Visible = true;
                    else
                        btAddSelecionada.Visible = false;
                }
                else
                {
                    //verifica se a pasta atual é a selecionada
                    btAddSelecionada.Visible = false;
                }

                btAddVenda.Visible = false;
                tsSeparator.Visible = false;
            }
        }

        private void InsereSelecionada()
        {
            //marca como selecionada
            CurrentItem.IsSelected = true;
            LibFoto.Update(CurrentItem);

            //faz copia da imagem
            var pastaSelecionada = new Lib.SessaoPasta().GetBySessao(Sessao.IdSessao).FirstOrDefault(a => a.Nome == "Selecionadas");
            if (pastaSelecionada != null)
            {
                var currentFolder = new Lib.SessaoPasta().GetById(CurrentItem.IdSessaoPasta.GetValueOrDefault());
                if (currentFolder != null)
                {
                    var dirBase = string.Format(@"\\{0}\{1}", Config.ServImagem, Config.Folder);
                    var filePath = CurrentItem.Url.Replace(currentFolder.Nome, pastaSelecionada.Nome);
                    var thumbPath = CurrentItem.Thumb.Replace(currentFolder.Nome, pastaSelecionada.Nome);

                    //copia imagem e thumb fisicamente
                    System.IO.File.Copy(string.Format(@"{0}\{1}", dirBase, CurrentItem.Url), string.Format(@"{0}\{1}", dirBase, filePath));
                    System.IO.File.Copy(string.Format(@"{0}\{1}", dirBase, CurrentItem.Thumb), string.Format(@"{0}\{1}", dirBase, thumbPath));

                    //cria o registro da imagem
                    var foto = new Dados.Foto();
                    foto.IdSessao = CurrentItem.IdSessao;
                    foto.IdSessaoPasta = pastaSelecionada.IdSessaoPasta;
                    foto.Nome = CurrentItem.Nome;
                    foto.Url = filePath;
                    foto.Thumb = thumbPath;
                    foto.Hora = CurrentItem.Hora;
                    foto.Tamanho = CurrentItem.Tamanho;
                    foto.MimeType = CurrentItem.MimeType;
                    foto.IsAtivo = CurrentItem.IsAtivo;
                    foto.IsSelected = CurrentItem.IsSelected;

                    LibFoto.Insert(foto);
                }

            }
        }

        private void RemoveSelecionada()
        {
            //marca como selecionada
            CurrentItem.IsSelected = false;
            LibFoto.Update(CurrentItem);

            //faz copia da imagem
            var pastaSelecionada = new Lib.SessaoPasta().GetBySessao(Sessao.IdSessao).FirstOrDefault(a => a.Nome == "Selecionadas");
            if (pastaSelecionada != null)
            {
                var currentFolder = new Lib.SessaoPasta().GetById(CurrentItem.IdSessaoPasta.GetValueOrDefault());
                if (currentFolder != null)
                {
                    var dirBase = string.Format(@"\\{0}\{1}", Config.ServImagem, Config.Folder);
                    var filePath = CurrentItem.Url.Replace(currentFolder.Nome, pastaSelecionada.Nome);
                    var thumbPath = CurrentItem.Thumb.Replace(currentFolder.Nome, pastaSelecionada.Nome);

                    //copia imagem e thumb fisicamente
                    System.IO.File.Delete(string.Format(@"{0}\{1}", dirBase, filePath));
                    System.IO.File.Delete(string.Format(@"{0}\{1}", dirBase, thumbPath));

                    //cria o registro da imagem
                    var foto = LibFoto.GetBySessaoPasta(pastaSelecionada.IdSessao, pastaSelecionada.IdSessaoPasta).FirstOrDefault(a => a.Url == filePath);

                    LibFoto.Delete(foto.IdFoto);
                }

            }
        }

        #endregion
        
    }

    public enum FullViewerType
    {
        Sessao = 1,
        Venda = 2
    }
}