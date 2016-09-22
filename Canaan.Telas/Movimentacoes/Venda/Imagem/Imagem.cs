using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Lib.Componentes;
using Canaan.Lib.Utilitarios;
using Canaan.Telas.Base;
using Canaan.Telas.Movimentacoes.Sessao.Telas;
using Canaan.Telas.Rotinas.Backup;
using System.IO;
using System.Drawing;
using Canaan.Telas.Properties;

namespace Canaan.Telas.Movimentacoes.Venda.Imagem
{
    public partial class Imagem : FormVendaBase
    {
        #region LIBS

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

        public VendaFoto LibVendaFoto
        {
            get
            {
                return new VendaFoto();
            }

        }

        #endregion

        #region PROPRIEDADES

        public Dados.Atendimento Atendimento { get; set; }

        public Dados.Venda Venda { get; set; }

        public List<Dados.Sessao> Sessoes { get; set; }

        public List<Dados.SessaoPasta> Pastas { get; set; }

        public List<MemoryStream> Fotos { get; set; }

        public List<MemoryStream> Selecionadas { get; set; }

        public Dados.Sessao SessaoAtual { get; set; }

        public Dados.SessaoPasta PastaAtual { get; set; }

        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }

        public Dados.Config Config
        {
            get
            {
                return LibConfig.GetByFilial(Session.Contexto.IdFilial);
            }
        }


        #endregion

        #region CONSTRUTORES

        public Imagem(Dados.Atendimento Atendimento, Dados.Venda Venda)
        {
            this.Atendimento = Atendimento;
            this.Venda = Venda;
            
            //Inicializa Model
            //Model = new ModelImageVenda();

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Imagem_Load(object sender, EventArgs e)
        {
            VerificaPastaSelecionada();

            InitModel();
            InitComboPastas();
            InitComboSessoes();
            InitBinding();
            CanUpdate();

            CarregaSelecionadas();
        }

        private void cbSessoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pega sessão atual
            var id = int.Parse(cbSessoes.ComboBox.SelectedValue.ToString());
            this.SessaoAtual = this.Sessoes.FirstOrDefault(a => a.IdSessao == id);

            //atualiza lista
            this.Pastas = LibSessaoPasta.GetBySessao(this.SessaoAtual.IdSessao);

            //atualiza o combo das pastas
            cbPastas.ComboBox.DataSource = this.Pastas;
        }

        private void cbPastas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPastas.ComboBox.SelectedValue != null)
            {
                var id = int.Parse(cbPastas.ComboBox.SelectedValue.ToString());
                this.PastaAtual = this.Pastas.FirstOrDefault(a => a.IdSessaoPasta == id);

                //carrega imagens
                CarregaImagens();
            }
            
        }

        private void lvImagensSessao_DoubleClick(object sender, EventArgs e)
        {
            OpenFull(TypeFullOpen.FotosSessao);
        }

        private void lvImagensSessao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvImagensSelecionadas_DoubleClick(object sender, EventArgs e)
        {
            OpenFull(TypeFullOpen.FotosVenda);
        }     

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }


        //DragDrop Imagens Sessao

        private void lvImagensSessao_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        private void lvImagensSessao_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lvImagensSessao_DragDrop(object sender, DragEventArgs e)
        {
            if (lvImagensVenda.SelectedItems.Count > 0)
            {
                foreach (CListViewItem item in lvImagensVenda.SelectedItems)
                {
                    try
                    {
                        var foto = item.Item as Dados.Foto;

                        //remove da venda
                        LibVendaFoto.Delete(foto.IdFoto, Venda.IdPedido);

                        //deleta das selecionadas
                        RemoveSelecionada(foto);

                        //remove do listview
                        item.Remove();

                        //Atualiza Sessao Model
                        //Model.IdSessaoAtual = foto.IdSessao;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                CarregaImagens();
                CarregaSelecionadas();

                ////Atualiza Componente
                //Model.UpdateListas(Venda.IdPedido);
                //InitBinding();
            }
        }
        

        //DragDrop Imagens Venda

        private void lvImagensVenda_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        private void lvImagensVenda_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lvImagensVenda_DragDrop(object sender, DragEventArgs e)
        {
            if (lvImagensSessao.SelectedItems.Count > 0)
            {
                foreach (CListViewItem item in lvImagensSessao.SelectedItems)
                {
                    var foto = item.Item as Dados.Foto;

                    LibVendaFoto.Insert(new Dados.VendaFoto
                    {
                        IdFoto = foto.IdFoto,
                        IdPedido = Venda.IdPedido
                    });

                    //insere na pasta de selecionadas
                    InsereSelecionada(foto);
                }

                CarregaImagens();
                CarregaSelecionadas();

                ////Atualiza Componente
                //Model.UpdateListas(Venda.IdPedido);
                //InitBinding();
            }
        }

        private void slideShow_Click(object sender, EventArgs e)
        {
            OpenFull(TypeFullOpen.FotosSessao);
        }

        private void btBackup_Click(object sender, EventArgs e)
        {
            //var frm = new Restaurar(LibSessao.GetById(Model.IdSessaoAtual));
            //frm.ShowDialog();

            InitBinding();
        }



        private void btAddSelecionada_Click(object sender, EventArgs e)
        {
            if (lvImagensSessao.SelectedItems.Count > 0)
            {
                foreach (CListViewItem item in lvImagensSessao.SelectedItems)
                {
                    var foto = item.Item as Dados.Foto;

                    LibVendaFoto.Insert(new Dados.VendaFoto
                    {
                        IdFoto = foto.IdFoto,
                        IdPedido = Venda.IdPedido
                    });

                    //insere na pasta de selecionadas
                    InsereSelecionada(foto);
                }

                CarregaImagens();
                CarregaSelecionadas();

                ////Atualiza Componente
                //Model.UpdateListas(Venda.IdPedido);
                //InitBinding();
            }
        }

        private void btDeleteSelecionada_Click(object sender, EventArgs e)
        {
            if (lvImagensVenda.SelectedItems.Count > 0)
            {
                foreach (CListViewItem item in lvImagensVenda.SelectedItems)
                {
                    try
                    {
                        var foto = item.Item as Dados.Foto;

                        //remove da venda
                        LibVendaFoto.Delete(foto.IdFoto, Venda.IdPedido);

                        //deleta das selecionadas
                        RemoveSelecionada(foto);

                        //remove do listview
                        item.Remove();

                        //Atualiza Sessao Model
                        //Model.IdSessaoAtual = foto.IdSessao;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                CarregaImagens();
                CarregaSelecionadas();

                ////Atualiza Componente
                //Model.UpdateListas(Venda.IdPedido);
                //InitBinding();
            }
        }

        #endregion

        #region METODOS

        private void InitModel()
        {
            //Carrega Sessoes
            this.Sessoes = LibSessao.GetByAtendimentoAndFilial(this.Atendimento.IdAtendimento, this.Atendimento.IdFilial).OrderByDescending(a => a.Data).ToList();

            if (this.Sessoes.Count > 0)
                this.Pastas = LibSessaoPasta.GetBySessao(this.Sessoes.FirstOrDefault().IdSessao);
        }

        private void InitBinding()
        {

            //Carrega ListView Fotos da Sessao
            //BindingListView(Model.FotosSessaoAtual, imgList, Config, lvImagensSessao);
            //labelImagensSessao.Text = string.Format("Imagens Selecionadas ({0})", lvImagensSessao.Items.Count);

            //Carrega ListView Fotos da Venda
            //BindingListView(Model.FotosSelecionadas, imgListVenda, Config, lvImagensVenda);
            //labelImagensVenda.Text = string.Format("Imagens da Sessão ({0})", lvImagensVenda.Items.Count);
        }

        private void InitComboSessoes()
        {
            cbSessoes.ComboBox.ValueMember = "IdSessao";
            cbSessoes.ComboBox.DisplayMember = "Data";
            cbSessoes.ComboBox.DataSource = this.Sessoes;
        }

        private void InitComboPastas()
        {
            cbPastas.ComboBox.ValueMember = "IdSessaoPasta";
            cbPastas.ComboBox.DisplayMember = "Nome";
            cbPastas.ComboBox.DataSource = this.Pastas;
        }

        private void CarregaImagens()
        {
            try
            {
                //Inicializa Fotos
                if (this.Fotos == null)
                    this.Fotos = new List<MemoryStream>();

                //Limpa compenentes
                imgList.Images.Clear();
                lvImagensSessao.Items.Clear();

                //Carrega lista de fotos
                var listaFotos = LibFoto.GetBySessaoPasta(this.PastaAtual.IdSessao, this.PastaAtual.IdSessaoPasta).OrderBy(a => a.Nome).ToList();

                //remove imagens da venda
                var listaVenda = LibFoto.GetByVenda(this.Venda.IdPedido);
                foreach (var img in listaVenda)
                {
                    var atual = listaFotos.FirstOrDefault(a => a.IdFoto == img.IdFoto);
                    if (atual != null)
                        listaFotos.Remove(atual);
                }


                //verifica se é para sincronizar o caderno
                var direBase = string.Format(@"\\{0}\{1}", Config.ServImagem, Config.Folder);

                if (!Directory.Exists(direBase))
                {
                    this.Fotos = listaFotos.Select(a => new MemoryStream(ImageUtility.GetBytesFromResource(Resources.no_image))).ToList();
                    imgList.Images.AddRange(Fotos.Select(a => Image.FromStream(a)).ToArray());

                    lvImagensSessao.Items.AddRange(listaFotos.Select((a, i) => new CListViewItem(a, a.Nome, i)).ToArray());
                    lvImagensSessao.LargeImageList = imgList;
                    lvImagensSessao.Refresh();
                    lvImagensSessao.EndUpdate();
                }
                else
                {
                    this.Fotos.Clear();

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

                    lvImagensSessao.Items.AddRange(listaFotos.Select((a, i) => new CListViewItem(a, a.Nome, i)).ToArray());
                    lvImagensSessao.LargeImageList = imgList;
                    lvImagensSessao.Refresh();
                    lvImagensSessao.EndUpdate();
                }

                //altera texto do label
                labelImagensSessao.Text = string.Format("Sessão {0} - Pasta - {1} - {2} imagens", this.PastaAtual.IdSessao, this.PastaAtual.Nome, listaFotos.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregaSelecionadas()
        {
            try
            {
                //Inicializa Fotos
                if (this.Selecionadas == null)
                    this.Selecionadas = new List<MemoryStream>();

                //Limpa compenentes
                imgListVenda.Images.Clear();
                lvImagensVenda.Items.Clear();

                //Carrega lista de fotos
                var listaFotos = LibFoto.GetByVenda(this.Venda.IdPedido);

                //muda o texto
                labelImagensVenda.Text = string.Format("Selecionadas - {0} imagens", listaFotos.Count);

                //verifica se é para sincronizar o caderno
                var direBase = string.Format(@"\\{0}\{1}", Config.ServImagem, Config.Folder);

                if (!Directory.Exists(direBase))
                {
                    this.Selecionadas = listaFotos.Select(a => new MemoryStream(ImageUtility.GetBytesFromResource(Resources.no_image))).ToList();
                    imgListVenda.Images.AddRange(Fotos.Select(a => Image.FromStream(a)).ToArray());

                    lvImagensVenda.Items.AddRange(listaFotos.Select((a, i) => new CListViewItem(a, a.Nome, i)).ToArray());
                    lvImagensVenda.LargeImageList = imgListVenda;
                    lvImagensVenda.Refresh();
                    lvImagensVenda.EndUpdate();
                }
                else
                {
                    this.Selecionadas.Clear();

                    foreach (var item in listaFotos)
                    {
                        var file = string.Format(@"\\{0}\{1}\{2}", Config.ServImagem, Config.Folder, item.Thumb);
                        var fileCanaan = string.Format(@"\\{0}\{1}\{2}.canaan", Config.ServImagem, Config.Folder, item.Thumb.Split('.').FirstOrDefault());

                        if (File.Exists(file))
                        {
                            this.Selecionadas.Add(new MemoryStream(ImageUtility.VerificaCriptografia(item, file)));
                        }
                        else if (File.Exists(fileCanaan))
                        {
                            this.Selecionadas.Add(new MemoryStream(ImageUtility.VerificaCriptografia(item, fileCanaan)));
                        }
                        else
                        {
                            this.Selecionadas.Add(new MemoryStream(ImageUtility.GetBytesFromResource(Resources.no_image)));
                        }

                    }

                    imgListVenda.Images.AddRange(this.Selecionadas.Select(a => Image.FromStream(a)).ToArray());

                    lvImagensVenda.Items.AddRange(listaFotos.Select((a, i) => new CListViewItem(a, a.Nome, i)).ToArray());
                    lvImagensVenda.LargeImageList = imgListVenda;
                    lvImagensVenda.Refresh();
                    lvImagensVenda.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OpenFull(TypeFullOpen typeFullOpen)
        {
            ListView listview = null;

            if (typeFullOpen == TypeFullOpen.FotosSessao)
                listview = lvImagensSessao;
            else
                listview = lvImagensVenda;

            try
            {
                var selectedImg = listview.SelectedItems.Cast<CListViewItem>().FirstOrDefault();
                if (selectedImg == null)
                {
                    if (listview.Items.Count > 0)
                    {
                        selectedImg = listview.Items.Cast<CListViewItem>().FirstOrDefault();
                    }
                }

                if (selectedImg != null)
                {
                    var item = selectedImg.Item as Dados.Foto;
                    var lista = new List<Dados.Foto>();

                    foreach (var foto in listview.Items.Cast<CListViewItem>())
                    {
                        lista.Add(foto.Item as Dados.Foto);
                    }

                    var obj = lista.FirstOrDefault(a => a.IdFoto == item.IdFoto);
                    var index = lista.IndexOf(obj);

                    if (index < 0)
                        return;

                    var frm = new FullViewer(index, lista, item.Sessao, Venda);
                    frm.ShowDialog();

                    //Model.UpdateListas(Venda.IdPedido);
                    //BindingListView(Model.FotosSessaoAtual, imgList, Config, lvImagensSessao);
                    //BindingListView(Model.FotosSelecionadas, imgListVenda, Config, lvImagensVenda);
                    CarregaImagens();
                    CarregaSelecionadas();
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

        private void CanUpdate()
        {

            if (Comum.CanUpdateVenda(Venda))
            {
                lvImagensVenda.AllowDrop = true;
                lvImagensSessao.AllowDrop = true;
            }
            else
            {
                lvImagensVenda.AllowDrop = false;
                lvImagensSessao.AllowDrop = false;
            }
        }

        private void RemoveSelecionada(Dados.Foto foto)
        {
            //marca como selecionada
            foto.IsSelected = false;
            LibFoto.Update(foto);

            //faz copia da imagem
            var pastaSelecionada = new Lib.SessaoPasta().GetBySessao(foto.IdSessao).FirstOrDefault(a => a.Nome == "Selecionadas");

            if (pastaSelecionada != null)
            {
                var currentFolder = new Lib.SessaoPasta().GetById(foto.IdSessaoPasta.GetValueOrDefault());

                if (currentFolder != null)
                {
                    var dirBase = string.Format(@"\\{0}\{1}", Config.ServImagem, Config.Folder);
                    var filePath = foto.Url.Replace(currentFolder.Nome, pastaSelecionada.Nome);
                    var thumbPath = foto.Thumb.Replace(currentFolder.Nome, pastaSelecionada.Nome);

                    //copia imagem e thumb fisicamente
                    System.IO.File.Delete(string.Format(@"{0}\{1}", dirBase, filePath));
                    System.IO.File.Delete(string.Format(@"{0}\{1}", dirBase, thumbPath));

                    //cria o registro da imagem
                    var fotoselecionada = LibFoto.GetBySessaoPasta(pastaSelecionada.IdSessao, pastaSelecionada.IdSessaoPasta).FirstOrDefault(a => a.Url == filePath);

                    LibFoto.Delete(fotoselecionada.IdFoto);
                }

            }
        }

        private void InsereSelecionada(Dados.Foto foto)
        {
            //marca como selecionada
            foto.IsSelected = true;
            LibFoto.Update(foto);

            //faz copia da imagem
            var pastaSelecionada = new Lib.SessaoPasta().GetBySessao(foto.IdSessao).FirstOrDefault(a => a.Nome == "Selecionadas");
            if (pastaSelecionada != null)
            {
                var currentFolder = new Lib.SessaoPasta().GetById(foto.IdSessaoPasta.GetValueOrDefault());
                if (currentFolder != null)
                {
                    var dirBase = string.Format(@"\\{0}\{1}", Config.ServImagem, Config.Folder);
                    var filePath = foto.Url.Replace(currentFolder.Nome, pastaSelecionada.Nome);
                    var thumbPath = foto.Thumb.Replace(currentFolder.Nome, pastaSelecionada.Nome);

                    //copia imagem e thumb fisicamente
                    System.IO.File.Copy(string.Format(@"{0}\{1}", dirBase, foto.Url), string.Format(@"{0}\{1}", dirBase, filePath));
                    System.IO.File.Copy(string.Format(@"{0}\{1}", dirBase, foto.Thumb), string.Format(@"{0}\{1}", dirBase, thumbPath));

                    //cria o registro da imagem
                    var selecionada = new Dados.Foto();
                    selecionada.IdSessao = foto.IdSessao;
                    selecionada.IdSessaoPasta = pastaSelecionada.IdSessaoPasta;
                    selecionada.Nome = foto.Nome;
                    selecionada.Url = filePath;
                    selecionada.Thumb = thumbPath;
                    selecionada.Hora = foto.Hora;
                    selecionada.Tamanho = foto.Tamanho;
                    selecionada.MimeType = foto.MimeType;
                    selecionada.IsAtivo = foto.IsAtivo;
                    selecionada.IsSelected = foto.IsSelected;

                    LibFoto.Insert(selecionada);
                }

            }
        }

        private void VerificaPastaSelecionada()
        {
            var folder = new Lib.Pasta().GetByNome("Selecionadas").FirstOrDefault();

            if (folder != null)
            {
                //some com as imagens selecionadas
                labelImagensVenda.Visible = false;
                lvImagensVenda.Visible = false;

                labelImagensSessao.Left = labelImagensVenda.Left;
                lvImagensSessao.Left = lvImagensVenda.Left;
                lvImagensSessao.Width = lvImagensSessao.Width + lvImagensVenda.Width;
            }
        }


        #endregion

        
    }

    //#region MODELO

    //public class ModelImageVenda : INotifyPropertyChanged
    //{

    //    #region Libs

    //    public Lib.Sessao LibSessao
    //    {
    //        get
    //        {
    //            return new Lib.Sessao();
    //        }
    //    }

    //    public Lib.SessaoPasta LibSessaoPasta
    //    {
    //        get
    //        {
    //            return new Lib.SessaoPasta();
    //        }
    //    }

    //    public Foto LibFoto
    //    {
    //        get
    //        {
    //            return new Foto();
    //        }
    //    }

    //    #endregion

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    private void NotifyPropertyChanged(string info)
    //    {
    //        if (PropertyChanged != null)
    //        {
    //            PropertyChanged(this, new PropertyChangedEventArgs(info));
    //        }
    //    }

    //    private BindingList<Dados.Foto> fotosSelecionadas;
    //    public BindingList<Dados.Foto> FotosSelecionadas
    //    {
    //        get { return fotosSelecionadas; }
    //        set
    //        {
    //            fotosSelecionadas = value;
    //            NotifyPropertyChanged("FotosSelecionadas");
    //            NotifyPropertyChanged("FotosSessaoAtual");
    //        }
    //    }

    //    public BindingList<Dados.Foto> FotosSessaoAtual
    //    {
    //        get
    //        {
    //            if (SessaoAtual == null || PastaAtual == null)
    //                return new BindingList<Dados.Foto>();

    //            return new BindingList<Dados.Foto>(LibFoto.GetBySessaoPasta(SessaoAtual.IdSessao, PastaAtual.IdSessaoPasta).Except(FotosSelecionadas, new FotosComparer()).ToList());
    //        }

    //    }

    //    private BindingList<Dados.Sessao> sessoes;
    //    public BindingList<Dados.Sessao> Sessoes
    //    {
    //        get { return sessoes; }
    //        set
    //        {
    //            sessoes = value;
    //            NotifyPropertyChanged("Sessoes");
    //        }
    //    }

    //    private BindingList<Dados.SessaoPasta> sessaoPastas;
    //    public BindingList<Dados.SessaoPasta> SessaoPastas
    //    {
    //        get { return sessaoPastas; }
    //        set
    //        {
    //            sessaoPastas = value;
    //            NotifyPropertyChanged("SessaoPastas");
    //        }
    //    }

    //    public List<Dados.Foto> ListaSlideShow
    //    {
    //        get 
    //        {
    //            return LibFoto.GetBySessao(idSessaoAtual);
    //        }
    //    }

    //    public Dados.Sessao SessaoAtual
    //    {
    //        get
    //        {
    //            if (IdSessaoAtual == 0)
    //                return null;

    //            return LibSessao.GetById(IdSessaoAtual);
    //        }
    //    }

    //    public Dados.SessaoPasta PastaAtual
    //    {
    //        get
    //        {
    //            if (IdPastaAtual == 0)
    //                return null;

    //            return LibSessaoPasta.GetById(IdPastaAtual);
    //        }
    //    }

    //    private int idSessaoAtual;
    //    public int IdSessaoAtual
    //    {
    //        get { return idSessaoAtual; }
    //        set
    //        {
    //            idSessaoAtual = value;
    //            NotifyPropertyChanged("IdSessaoAtual");
    //            NotifyPropertyChanged("SessaoAtual");
    //            NotifyPropertyChanged("PastaAtual");
    //            //NotifyPropertyChanged("ListaSlideShow");
    //        }
    //    }

    //    private int idPastaAtual;
    //    public int IdPastaAtual
    //    {
    //        get { return idPastaAtual; }
    //        set
    //        {
    //            idSessaoAtual = value;
    //            NotifyPropertyChanged("IdPastaAtual");
    //            NotifyPropertyChanged("PastaAtual");
    //            NotifyPropertyChanged("FotosSessaoAtual");
    //            NotifyPropertyChanged("ListaSlideShow");
    //        }
    //    }

    //    public void UpdateListas(int idVenda)
    //    {
    //        FotosSelecionadas = new BindingList<Dados.Foto>(LibFoto.GetByVenda(idVenda));
    //        NotifyPropertyChanged("FotosSessaoAtual");
    //    }

    //}

    //#endregion

    #region COMPARER

    public class FotosComparer : IEqualityComparer<Dados.Foto>
    {
        public bool Equals(Dados.Foto a, Dados.Foto b)
        {
            return a.IdFoto == b.IdFoto;
        }

        public int GetHashCode(Dados.Foto foto)
        {
            return foto.IdFoto.GetHashCode();
        }
    }

    #endregion

    #region ENUM

    public enum TypeFullOpen
    {
        FotosSessao = 1,
        FotosVenda = 2
    }

    #endregion
}
