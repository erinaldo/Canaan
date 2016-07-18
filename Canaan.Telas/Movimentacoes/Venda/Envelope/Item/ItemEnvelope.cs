using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Lib.Componentes;
using Canaan.Telas.Base;
using Canaan.Telas.Movimentacoes.Sessao.Telas;
using Canaan.Telas.Movimentacoes.Venda.Envelope.Servico;
using Album = Canaan.Lib.Album;
using Config = Canaan.Dados.Config;
using EfeitoDigital = Canaan.Lib.EfeitoDigital;
using Foto = Canaan.Lib.Foto;
using Moldura = Canaan.Lib.Moldura;
using OrdemServico = Canaan.Lib.OrdemServico;
using OrdemServicoItem = Canaan.Lib.OrdemServicoItem;
using VendaFoto = Canaan.Lib.VendaFoto;

namespace Canaan.Telas.Movimentacoes.Venda.Envelope.Item
{
    public partial class ItemEnvelope : FormVendaBase
    {
        #region PROPRIEDADES

        public Model Model { get; set; }

        public Album LibAlbum
        {
            get
            {
                return new Album();
            }
        }

        public Moldura LibMoldura
        {
            get
            {
                return new Moldura();
            }
        }

        public int IdOrdemServico { get; set; }

        public int IdSessao { get; set; }

        public OrdemServico LibOrdemServico
        {
            get
            {
                return new OrdemServico();
            }
        }

        public Dados.OrdemServico OrdemServico { get; set; }

        public Foto LibFoto
        {
            get
            {
                return new Foto();
            }
        }

        public VendaFoto LibVendaFoto
        {
            get
            {
                return new VendaFoto();
            }
        }

        public int IdVenda { get; set; }

        public Dados.Venda Venda { get; set; }

        public Lib.Venda LibVenda
        {
            get
            {
                return new Lib.Venda();
            }
        }

        public BindingList<Dados.Foto> FotosVenda { get; set; }

        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }

        public Config Config
        {
            get
            {
                return new Lib.Config().GetByFilial(Session.Contexto.IdFilial);
            }
        }

        public OrdemServicoItem LibOrdemServicoItem
        {
            get
            {
                return new OrdemServicoItem();
            }
        }

        public EfeitoDigital LibEfeitoDigital
        {
            get
            {
                return new EfeitoDigital();
            }
        }

        public BindingList<Dados.OrdemServicoItem> OrdensServicoItem { get; set; }

        public Dados.OrdemServicoItem FotoEnvSelected { get; set; }

        public Dados.OrdemServicoItem SelectedOrdemItem { get; set; }

        public BindingList<Dados.Foto> FotosEnvelope { get; set; }

        #endregion

        #region CONSTRUTOR

        public ItemEnvelope(int idOrdem, int idVenda)
        {
            IdOrdemServico = idOrdem;
            IdVenda = idVenda;
            Venda = LibVenda.GetById(IdVenda);
            OrdemServico = LibOrdemServico.GetById(IdOrdemServico);

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void ItemEnvelope_Load(object sender, EventArgs e)
        {
            InitModel();
            InitBinding();
            InitForm();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!string.IsNullOrEmpty(txtNomeAbertura.Text.Trim()))
                //{
                    //AtualizarOrdem();
                    //Lib.MessageBoxUtilities.MessageInfo("Registro salvo com sucesso");
                //}
                //else
                //{
                //    Lib.MessageBoxUtilities.MessageWarning("O Campo Nome Abertura é obrigatório");
                //}

                AtualizarOrdem();
                MessageBoxUtilities.MessageInfo("Registro salvo com sucesso");
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        //List View Imagens Venda
        private void lvImgVenda_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        private void lvImgVenda_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lvImgVenda_DragDrop(object sender, DragEventArgs e)
        {
            if (lvImgEnvelope.SelectedItems.Count > 0)
            {
                foreach (CListViewItem item in lvImgEnvelope.SelectedItems)
                {
                    var ositem = item.Item as Dados.OrdemServicoItem;

                    LibOrdemServicoItem.Delete(ositem.IdItem);
                    CarregaImagensEnvelope();
                    CarregaImagensVenda();
                }
            }
        }


        //List View Imagens Envelope
        private void lvImgEnvelope_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        private void lvImgEnvelope_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lvImgEnvelope_DragDrop(object sender, DragEventArgs e)
        {
            if (lvImgVenda.SelectedItems.Count > 0)
            {
                foreach (CListViewItem item in lvImgVenda.SelectedItems)
                {
                    var foto = item.Item as Dados.Foto;

                    if (foto != null)
                        LibOrdemServicoItem.Insert(new Dados.OrdemServicoItem
                        {
                            IdFoto = foto.IdFoto,
                            IdOrdemServico = OrdemServico.IdOrdemServico,
                            Observacao = string.Empty,
                            Quantidade = 1
                        });

                    CarregaImagensEnvelope();
                    CarregaImagensVenda();

                    if(lvImgEnvelope.SelectedItems == null || lvImgEnvelope.SelectedItems.Count <= 0)
                    {
                        lvImgEnvelope.Items[0].Selected = true;
                        lvImgEnvelope_SelectedIndexChanged(null, null);
                        CarregaInfoItem();
                    }
                    
                }
            }
        }

        private void lvImgEnvelope_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvImgEnvelope.SelectedItems == null || lvImgEnvelope.SelectedItems.Count <= 0)
                    return;

                FotoEnvSelected = lvImgEnvelope.SelectedItems.Cast<CListViewItem>().FirstOrDefault().Item as Dados.OrdemServicoItem;

                if (FotoEnvSelected == null || OrdemServico == null)
                    return;

                SelectedOrdemItem = LibOrdemServicoItem.GetById(FotoEnvSelected.IdItem);
                CarregaInfoItem();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }


        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvImgEnvelope.SelectedItems.Count <= 0)
                {
                    MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
                }
                else
                {
                    ExcluirOrdemServicoItem();
                    MessageBoxUtilities.MessageInfo("Registro excluido com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void atualizarServico_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarOrdemServicoItem();
                MessageBoxUtilities.MessageInfo("Registro atualizado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void lvImgVenda_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var item = lvImgVenda.SelectedItems.Cast<CListViewItem>().Select(a => a.Item).FirstOrDefault() as Dados.Foto;
                var index = FotosVenda.IndexOf(item);

                var frmFullView = new FullViewer(index, FotosVenda.ToList(), item.Sessao);
                frmFullView.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void lvImgEnvelope_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var item = lvImgEnvelope.SelectedItems.Cast<CListViewItem>().Select(a => a.Item).FirstOrDefault() as Dados.OrdemServicoItem;
                var index = FotosEnvelope.IndexOf(item.Foto);

                var frmFullView = new FullViewer(index, FotosEnvelope.ToList(), item.Foto.Sessao);
                frmFullView.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void linkEfeito_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frmEfeito = new Efeito.Efeito();
            frmEfeito.ShowDialog();

            if (frmEfeito.EfeitoSelecionado != null)
            {
                SelectedOrdemItem.IdEfeito = frmEfeito.EfeitoSelecionado.IdEfeito;
                LibOrdemServicoItem.Update(SelectedOrdemItem);

                Model.Efeito = frmEfeito.EfeitoSelecionado.Nome;
                CarregaImagensEnvelope();
            }

        }

        private void btRemoveEfeito_Click(object sender, EventArgs e)
        {
            if (SelectedOrdemItem != null)
            {
                SelectedOrdemItem.IdEfeito = null;
                SelectedOrdemItem = LibOrdemServicoItem.Update(SelectedOrdemItem);

                CarregaImagensEnvelope();
                ValidaVizualizacaoRemocaoEfeito();
            }
        }

        #endregion

        #region METODOS

        private void InitForm()
        {
            lkEfeito.Text = "Selecione um efeito";

            ValidaVizualizacaoRemocaoEfeito();

            CarregaInfoOrdemServico();
            CarregaImagensEnvelope();
            CarregaImagensVenda();

            if (lvImgEnvelope.Items.Count > 0)
            {
                lvImgEnvelope.Items[0].Selected = true;
                lvImgEnvelope_SelectedIndexChanged(null, null);
                CarregaInfoItem();
            }
        }

        private void ValidaVizualizacaoRemocaoEfeito()
        {

            if (SelectedOrdemItem != null)
                if (SelectedOrdemItem.EfeitoDigital == null)
                    toolTipDeleteEfeito.Visible = false;
        }

        private void CarregaImagensVenda()
        {
            int[] fotosselecionadas = FotosEnvelope.Select(a => a.IdFoto).ToArray();

            FotosVenda = new BindingList<Dados.Foto>(LibFoto.GetByVenda(IdVenda).Where(a => !fotosselecionadas.Contains(a.IdFoto)).ToList());

            LibFoto.CarregaImagensItemEnvelope(FotosVenda, imgListVenda, Config);

            lvImgVenda.Clear();
            lvImgVenda.Items.AddRange(FotosVenda.Select((a, i) => new CListViewItem(a, string.Format("{0}-{1}", a.Nome, a.Sessao.NumSessao), i)).ToArray());
            lvImgVenda.LargeImageList = imgListVenda;
            lvImgVenda.Refresh();
            lvImgVenda.EndUpdate();
        }

        private void CarregaImagensEnvelope()
        {
            OrdensServicoItem = new BindingList<Dados.OrdemServicoItem>(LibFoto.GetByOrdemServico(OrdemServico.IdOrdemServico));

            FotosEnvelope = new BindingList<Dados.Foto>(OrdensServicoItem.Select(a => a.Foto).ToList());

            LibFoto.CarregaImagensItemEnvelope(FotosEnvelope, imgListEnvelope, Config);

            lvImgEnvelope.Clear();


            lvImgEnvelope.Items.AddRange(OrdensServicoItem.Select((a, i) => new CListViewItem(a, a.Foto.Nome, i)).ToArray());


            lvImgEnvelope.LargeImageList = imgListEnvelope;
            lvImgEnvelope.Refresh();
            lvImgEnvelope.EndUpdate();

            cQuantidade.Text = FotosEnvelope.Count.ToString();
        }

        private void CarregaInfoOrdemServico()
        {
            lkLabelServico.Text = OrdemServico.Servico.Nome;

            if (OrdemServico.IdAlbum != null)
                cbAlbum.SelectedValue = OrdemServico.IdAlbum;

            if (OrdemServico.IdMoldura != null)
                cbMoldura.SelectedValue = OrdemServico.IdMoldura;

            if (OrdemServico.NomeAbertura != null)
                txtNomeAbertura.Text = OrdemServico.NomeAbertura;

            if (OrdemServico.Observacao != null)
                txtObservacao.Text = OrdemServico.Observacao;
        }

        private void InitBinding()
        {
            //Album
            cbAlbum.DisplayMember = "Nome";
            cbAlbum.ValueMember = "IdAlbum";
            cbAlbum.DataBindings.Add(new Binding("DataSource", Model, "Albuns"));

            //Moldura
            cbMoldura.DisplayMember = "Nome";
            cbMoldura.ValueMember = "IdMoldura";
            cbMoldura.DataBindings.Add(new Binding("DataSource", Model, "Molduras"));

            if (string.IsNullOrEmpty(Model.Efeito))
            {
                lkEfeito.DataBindings.Add(new Binding("Text", Model, "Efeito"));
            }

        }

        private void InitModel()
        {
            Model = new Model();
            CarregaListas();
        }

        private void CarregaListas()
        {
            Model.Albuns = new BindingList<Dados.Album>(LibAlbum.GetByStatus(true));
            Model.Molduras = new BindingList<Dados.Moldura>(LibMoldura.GetByStatus(true));
        }

        private void AtualizarOrdem()
        {
            OrdemServico.NomeAbertura = txtNomeAbertura.Text;
            OrdemServico.Observacao = txtObservacao.Text;
            OrdemServico.IdAlbum = int.Parse(cbAlbum.SelectedValue.ToString());
            OrdemServico.IdMoldura = int.Parse(cbMoldura.SelectedValue.ToString());

            LibOrdemServico.Update(OrdemServico);
        }

        private void ExcluirOrdemServicoItem()
        {
            LibOrdemServicoItem.Delete(SelectedOrdemItem.IdItem);
            CarregaImagensEnvelope();
            CarregaImagensVenda();
        }

        private void CarregaInfoItem()
        {
            var image = LibFoto.GetImageById(FotoEnvSelected.IdFoto, Config);

            if (image != null)
            {
                picBox.Image = image;
                txtNomeImagem.Text = SelectedOrdemItem.Foto.Nome;
                txtInfoImagem.Text = SelectedOrdemItem.Observacao;
                tbInfoQuant.Value = SelectedOrdemItem.Quantidade;
            }

            if (SelectedOrdemItem.EfeitoDigital != null)
                lkEfeito.Text = SelectedOrdemItem.EfeitoDigital.Nome;
            else
                lkEfeito.Text = "Selecione um efeito";
        }

        private void AtualizarOrdemServicoItem()
        {
            SelectedOrdemItem.Observacao = txtInfoImagem.Text;
            SelectedOrdemItem.Quantidade = (int)tbInfoQuant.Value;

            LibOrdemServicoItem.Update(SelectedOrdemItem);
        }

        #endregion

        private void lkLabelServico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new BuscaServicos();
            frm.ShowDialog();

            //Adiciona Ordem de serviço
            OrdemServico = LibOrdemServico.Update(new Dados.OrdemServico
            {   IdOrdemServico = OrdemServico.IdOrdemServico,
                IdPedido = Venda.IdPedido,
                IdServico = frm.Model.ServicoSelecionado.IdServico,
                IdAlbum = null,
                IdMoldura = null,
                NomeAbertura = null,
                Data = DateTime.Now,
                DataPrevista = DateTime.Now.AddDays(frm.Model.ServicoSelecionado.Previsao),
                Observacao = null,
                Status = EnumStatusServico.AguardandoLiberacao
            });

            CarregaInfoOrdemServico();
        }
    }

    public class Model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        private BindingList<Dados.Album> albuns;
        public BindingList<Dados.Album> Albuns
        {
            get { return albuns; }
            set
            {
                albuns = value;
                NotifyPropertyChanged("Albuns");
            }
        }

        private BindingList<Dados.Moldura> molduras;
        public BindingList<Dados.Moldura> Molduras
        {
            get { return molduras; }
            set
            {
                molduras = value;
                NotifyPropertyChanged("Molduras");
            }
        }

        private string efeito;
        public string Efeito
        {
            get { return efeito; }
            set
            {
                efeito = value;
                NotifyPropertyChanged("Efeito");
            }
        }


    }
}
