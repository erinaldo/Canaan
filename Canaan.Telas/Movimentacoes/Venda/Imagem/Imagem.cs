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

namespace Canaan.Telas.Movimentacoes.Venda.Imagem
{
    public partial class Imagem : FormVendaBase
    {
        #region PROPRIEDADES

        public Dados.Atendimento Atendimento { get; set; }

        public Dados.Venda Venda { get; set; }

        public ModelImageVenda Model { get; set; }

        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }

        #region Libs

        public Lib.Sessao LibSessao
        {
            get
            {
                return new Lib.Sessao();
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
        public Dados.Config Config
        {
            get
            {
                return LibConfig.GetByFilial(Session.Contexto.IdFilial);
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

        #endregion

        #region CONSTRUTORES

        public Imagem(Dados.Atendimento Atendimento, Dados.Venda Venda)
        {
            this.Atendimento = Atendimento;
            this.Venda = Venda;

            //Inicializa Model
            Model = new ModelImageVenda();

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Imagem_Load(object sender, EventArgs e)
        {
            InitModel();
            InitComboSessoes();
            InitBinding();
            CanUpdate();
        }

        private void cbSessoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pega sessão atual
            Model.IdSessaoAtual = int.Parse(cbSessoes.ComboBox.SelectedValue.ToString());

            BindingListView(Model.FotosSessaoAtual, imgList, Config, lvImagensSessao);
        }

        private void lvImagensSessao_DoubleClick(object sender, EventArgs e)
        {
            OpenFull(TypeFullOpen.FotosSessao);
        }

        private void lvImagensSelecionadas_DoubleClick(object sender, EventArgs e)
        {
            OpenFull(TypeFullOpen.FotosVenda);
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
                        LibVendaFoto.Delete(foto.IdFoto, Venda.IdPedido);
                        item.Remove();

                        //Atualiza Sessao Model
                        Model.IdSessaoAtual = foto.IdSessao;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                //Atualiza Componente
                Model.UpdateListas(Venda.IdPedido);
                InitBinding();
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
                }

                //Atualiza Componente
                Model.UpdateListas(Venda.IdPedido);
                InitBinding();
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

        #endregion

        #region METODOS

        private void InitModel()
        {
            //Carrega Sessoes
            Model.Sessoes = new BindingList<Dados.Sessao>(LibSessao.GetByAtendimentoAndFilial(Atendimento.IdAtendimento, Atendimento.IdFilial).OrderByDescending(a => a.Data).ToList());
            Model.FotosSelecionadas = new BindingList<Dados.Foto>(LibFoto.GetByVenda(Venda.IdPedido));
        }

        private void InitBinding()
        {
            //Carrega ListView Fotos da Sessao
            BindingListView(Model.FotosSessaoAtual, imgList, Config, lvImagensSessao);
            labelImagensSessao.Text = string.Format("Imagens Selecionadas ({0})", lvImagensSessao.Items.Count);

            //Carrega ListView Fotos da Venda
            BindingListView(Model.FotosSelecionadas, imgListVenda, Config, lvImagensVenda);
            labelImagensVenda.Text = string.Format("Imagens da Sessão ({0})", lvImagensVenda.Items.Count);
        }

        private void BindingListView(BindingList<Dados.Foto> fotos, ImageList imgList, Dados.Config config, ListView listView)
        {
            LibFoto.CarregaImagensVenda(fotos, imgList, config, Model.IdSessaoAtual);

            listView.Clear();
            listView.Items.AddRange(fotos.Select((a, i) => new CListViewItem(a, a.Nome, i)).ToArray());
            listView.LargeImageList = imgList;
            listView.Refresh();
            listView.EndUpdate();
        }

        private void InitComboSessoes()
        {
            cbSessoes.ComboBox.ValueMember = "IdSessao";
            cbSessoes.ComboBox.DisplayMember = "Data";

            //Binding Sessao
            cbSessoes.ComboBox.DataBindings.Add(new Binding("DataSource", Model, "Sessoes", false, DataSourceUpdateMode.OnPropertyChanged));
            cbSessoes.ComboBox.DataBindings.Add(new Binding("SelectedValue", Model, "IdSessaoAtual", false, DataSourceUpdateMode.OnPropertyChanged));

            if (cbSessoes.Items.Count > 0)
                cbSessoes.SelectedIndex = 0;

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
                    Model.IdSessaoAtual = item.IdSessao;
                    var lista = Model.ListaSlideShow;
                    var obj = lista.FirstOrDefault(a => a.IdFoto == item.IdFoto);
                    var index = lista.IndexOf(obj);

                    if (index < 0)
                        return;

                    var frm = new FullViewer(index, lista, Model.SessaoAtual, Venda);
                    frm.ShowDialog();

                    Model.UpdateListas(Venda.IdPedido);
                    BindingListView(Model.FotosSessaoAtual, imgList, Config, lvImagensSessao);
                    BindingListView(Model.FotosSelecionadas, imgListVenda, Config, lvImagensVenda);
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

        #endregion

        private void lvImagensSessao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }
    }

    #region MODELO

    public class ModelImageVenda : INotifyPropertyChanged
    {

        #region Libs

        public Lib.Sessao LibSessao
        {
            get
            {
                return new Lib.Sessao();
            }
        }

        public Foto LibFoto
        {
            get
            {
                return new Foto();
            }
        }

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        private BindingList<Dados.Foto> fotosSelecionadas;
        public BindingList<Dados.Foto> FotosSelecionadas
        {
            get { return fotosSelecionadas; }
            set
            {
                fotosSelecionadas = value;
                NotifyPropertyChanged("FotosSelecionadas");
                NotifyPropertyChanged("FotosSessaoAtual");
            }
        }

        public BindingList<Dados.Foto> FotosSessaoAtual
        {
            get
            {
                if (SessaoAtual == null)
                    return new BindingList<Dados.Foto>();

                return new BindingList<Dados.Foto>(LibFoto.GetBySessao(SessaoAtual.IdSessao).Except(FotosSelecionadas, new FotosComparer()).ToList());
            }

        }

        private BindingList<Dados.Sessao> sessoes;
        public BindingList<Dados.Sessao> Sessoes
        {
            get { return sessoes; }
            set
            {
                sessoes = value;
                NotifyPropertyChanged("Sessoes");
            }
        }

        public List<Dados.Foto> ListaSlideShow
        {
            get 
            {
                return LibFoto.GetBySessao(idSessaoAtual);
            }
        }

        public Dados.Sessao SessaoAtual
        {
            get
            {
                if (IdSessaoAtual == 0)
                    return null;

                return LibSessao.GetById(IdSessaoAtual);
            }
        }

        private int idSessaoAtual;
        public int IdSessaoAtual
        {
            get { return idSessaoAtual; }
            set
            {
                idSessaoAtual = value;
                NotifyPropertyChanged("IdSessaoAtual");
                NotifyPropertyChanged("SessaoAtual");
                NotifyPropertyChanged("FotosSessaoAtual");
                NotifyPropertyChanged("ListaSlideShow");
            }
        }

        public void UpdateListas(int idVenda)
        {
            FotosSelecionadas = new BindingList<Dados.Foto>(LibFoto.GetByVenda(idVenda));
            NotifyPropertyChanged("FotosSessaoAtual");
        }

    }

    #endregion

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
