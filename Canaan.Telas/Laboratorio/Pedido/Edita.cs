using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Laboratorio.Pedido
{
    public partial class Edita : DevExpress.XtraEditors.XtraForm
    {
        #region PROPRIEDADES

        public Dados.Envio Envio { get; set; }
        public Dados.EnvioPedido Pedido { get; set; }
        public List<Servicos.Laboratorio.Models.ProdutoCategoria> Categorias { get; set; }
        public List<Servicos.Laboratorio.Models.Produto> Produtos { get; set; }
        public List<Servicos.Laboratorio.Models.Tamanho> Tamanhos { get; set; }
        public List<Servicos.Laboratorio.Models.Papel> Papeis { get; set; }
        public List<Servicos.Laboratorio.Models.Acessorio> Acessorios { get; set; }
        public List<Servicos.Laboratorio.Models.Revestimento> Revestimentos { get; set; }

        #endregion

        #region CONSTRUTORES

        public Edita()
        {
            this.Envio = null;

            InitializeComponent();
        }

        public Edita(Dados.Envio pEnvio)
        {
            this.Envio = pEnvio;

            InitializeComponent();
        }

        #endregion

        #region EVENTOS DO WIZARD

        private void pageProduct_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            var status = true;
            var errorMessage = "Ocorreram erros ao validar:\n\n";

            if (string.IsNullOrEmpty(clienteTextBox.Text))
            {
                status = false;
                errorMessage += "- Campo Nome do Cliente é obrigatório\n";
            }

            if (categoriaComboBox.SelectedValue == null)
            {
                status = false;
                errorMessage += "- Campo Categoria é obrigatório\n";
            }

            if (produtosListView.SelectedItems.Count == 0)
            {
                status = false;
                errorMessage += "- Nenhum produto selecionado\n";
            }

            if (tamanhoComboBox.SelectedValue == null)
            {
                status = false;
                errorMessage += "- Nenhum tamanho selecionado\n";
            }

            if (status == false)
            {
                e.Valid = false;
                MessageBox.Show(errorMessage);
            }
        }

        private void pageProduct_PageCommit(object sender, EventArgs e)
        {
            //seta valores
            this.Pedido.Cliente = clienteTextBox.Text;
            this.Pedido.Categoria = categoriaComboBox.Text;
            this.Pedido.Produto = produtosListView.SelectedItems[0].Text;
            this.Pedido.Tamanho = tamanhoComboBox.Text;
        }


        private void pageComplementos_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {

        }

        private void pageComplementos_PageCommit(object sender, EventArgs e)
        {
            var detalhes = "";

            if (this.Papeis.Count > 0)
                detalhes += string.Format("Papel: {0}\n\n", papelComboBox.Text);
            foreach (DataGridViewRow item in acessoriosDataGrid.Rows)
            {
                detalhes += string.Format("{0}: {1}\n\n", item.Cells[0].Value, item.Cells[1].EditedFormattedValue);
            }

            this.Pedido.Detalhes = detalhes;
        }


        private void pageRevestimentos_PageInit(object sender, EventArgs e)
        {

        }

        private void pageRevestimentos_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            if (Revestimentos.Count > 0)
            {
                if (revestimentosListView.SelectedItems.Count == 0)
                {
                    e.Valid = false;
                    MessageBox.Show("É necessário escolher um revestimento");
                }
                else
                {
                    e.Valid = true;
                }
            }
        }

        private void pageRevestimentos_PageCommit(object sender, EventArgs e)
        {
            if (Revestimentos.Count > 0)
            {
                var detalhes = "";

                if (this.Papeis.Count > 0)
                    detalhes += string.Format("Papel: {0}\n\n", papelComboBox.Text);
                foreach (DataGridViewRow item in acessoriosDataGrid.Rows)
                {
                    detalhes += string.Format("{0}: {1}\n\n", item.Cells[0].Value, item.Cells[1].EditedFormattedValue);
                }
                if (this.Revestimentos.Count > 0)
                    detalhes += string.Format("Revestimento: {0}\n\n", revestimentosListView.SelectedItems[0].Text);

                this.Pedido.Detalhes = detalhes;
            }

        }


        private void pageImagensCapa_PageInit(object sender, EventArgs e)
        {
            CarregaListView_Capa();
        }

        private void pageImagensCapa_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            if (VerificaCapaImagem())
            {
                if (this.Pedido.EnvioImagem.Where(a => a.Tipo == "Capa").Count() == 0)
                {
                    e.Valid = false;
                    MessageBox.Show("O produto que você escolher tem imagem na capa.\nPor favor selecione pelo menos uma imagem.");
                }
            }
        }

        private void pageImagensCapa_PageCommit(object sender, EventArgs e)
        {

        }


        private void pageImagensEmbalagem_PageInit(object sender, EventArgs e)
        {
            CarregaListView_Embalagem();
        }

        private void pageImagensEmbalagem_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            var status = VerificaAcessorioImagem();

            if (status == true)
            {
                if (this.Pedido.EnvioImagem.Where(a => a.Tipo == "Embalagem").Count() == 0)
                {
                    e.Valid = false;
                    MessageBox.Show("O produto que você escolher tem imagem na embalagem.\nPor favor selecione pelo menos uma imagem.");
                }
            }
        }

        private void pageImagensEmbalagem_PageCommit(object sender, EventArgs e)
        {

        }


        private void pageImagensBloco_PageInit(object sender, EventArgs e)
        {
            CarregaListView_Bloco();
        }

        private void pageImagensBloco_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            if (this.Pedido.EnvioImagem.Where(a => a.Tipo == "Bloco").Count() == 0)
            {
                e.Valid = false;
                MessageBox.Show("É necessário escolher pelo menos uma imagem");
            }
        }

        private void pageImagensBloco_PageCommit(object sender, EventArgs e)
        {

        }


        private void pageObservacoes_PageInit(object sender, EventArgs e)
        {

        }

        private void pageObservacoes_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {

        }

        private void pageObservacoes_PageCommit(object sender, EventArgs e)
        {
            this.Pedido.Observacoes = observacoesTextBox.Text;
        }


        private void pageFinaliza_PageInit(object sender, EventArgs e)
        {
            CarregaResumo();
        }

        private void pageFinaliza_PageCommit(object sender, EventArgs e)
        {

        }


        private void pedidoWizard_CancelClick(object sender, CancelEventArgs e)
        {
            var message = "Tem certeza que deseja cancelar o pedido?\nTodas as informações serão perdidas";

            if (MessageBox.Show(message, "Confirmação de Cancelamento", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pedidoWizard_FinishClick(object sender, CancelEventArgs e)
        {
            try
            {
                //salva o pedido
                SalvaPedido();

                MessageBox.Show("O pedido foi salvo com sucesso e está pendente para envio.\nPara enviar os pedidos abra Laboratorio -> Envio de Pedidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pedidoWizard_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {

        }

        private void pedidoWizard_SelectedPageChanged(object sender, DevExpress.XtraWizard.WizardPageChangedEventArgs e)
        {
            //verifica produtos sem acessorios
            if (e.Page == pageComplementos)
            {
                if (this.Acessorios.Count == 0 && this.Papeis.Count == 0)
                {
                    if (e.Direction == DevExpress.XtraWizard.Direction.Forward)
                    {
                        pedidoWizard.SelectedPage = pageRevestimentos;
                    }
                    else
                    {
                        pedidoWizard.SelectedPage = pageProduct;
                    }
                }
            }

            //verifica produtos sem revestimento
            if (e.Page == pageRevestimentos)
            {
                if (this.Revestimentos.Count == 0)
                {
                    if (e.Direction == DevExpress.XtraWizard.Direction.Forward)
                    {
                        pedidoWizard.SelectedPage = pageImagensCapa;
                    }
                    else
                    {
                        pedidoWizard.SelectedPage = pageComplementos;
                    }
                }
            }

            if (e.Page == pageImagensCapa)
            {
                if (VerificaCapaImagem() == false)
                {
                    if (e.Direction == DevExpress.XtraWizard.Direction.Forward)
                    {
                        pedidoWizard.SelectedPage = pageImagensEmbalagem;
                    }
                    else
                    {
                        pedidoWizard.SelectedPage = pageRevestimentos;
                    }
                }
            }

            if (e.Page == pageImagensEmbalagem)
            {
                if (VerificaAcessorioImagem() == false)
                {
                    if (e.Direction == DevExpress.XtraWizard.Direction.Forward)
                    {
                        pedidoWizard.SelectedPage = pageImagensBloco;
                    }
                    else
                    {
                        pedidoWizard.SelectedPage = pageImagensCapa;
                    }
                }
            }
        }

        private void pedidoWizard_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {

        }

        #endregion

        #region EVENTOS

        private void Edita_Load(object sender, EventArgs e)
        {
            Init();
            CarregaCategorias();
        }

        private void categoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = (int)categoriaComboBox.SelectedValue;

            CarregaProdutos(value);
        }

        private void produtosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (produtosListView.SelectedItems.Count > 0)
            {
                var id = int.Parse(produtosListView.SelectedItems[0].ImageKey);

                CarregaTamanhos(id);
                CarregaPapeis(id);
                CarregaAcessorios(id);
                CarregaRevestimentos(id);
            }
        }

        private void imagemCapaAdd_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                AdicionaCapa(dialog.FileNames, dialog.SafeFileNames);
            }
        }

        private void imagemCapaDelete_Click(object sender, EventArgs e)
        {
            RemoveCapa();
        }

        private void imagemBlocoAdd_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                AdicionaBloco(dialog.FileNames, dialog.SafeFileNames);
            }
        }

        private void imagemBlocoDelete_Click(object sender, EventArgs e)
        {
            RemoveBloco();
        }

        private void imagemEmbalagemAdd_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                AdicionaEmbalagem(dialog.FileNames, dialog.SafeFileNames);
            }
        }

        private void imagemEmbalagemDelete_Click(object sender, EventArgs e)
        {
            RemoveEmbalagem();
        }

        #endregion

        #region METODOS

        //inicializa formulario
        private void Init()
        {
            //inicializa o pedido
            this.Pedido = new Dados.EnvioPedido();
            this.Pedido.IsEnviado = false;
            this.Pedido.IsPendente = true;

            //incializa campos
            if (this.Envio != null)
            {
                this.Pedido.IdEnvio = this.Envio.IdEnvio;
                this.clienteTextBox.Text = this.Envio.Pedido_Venda.CliFor.Nome;
            }
            else
            {
                this.Pedido.IdEnvio = null;
                this.clienteTextBox.Text = "";
            }

        }

        //carrega listas
        private void CarregaCategorias()
        {
            //atualiza os dados
            this.Categorias = Servicos.Laboratorio.Services.ProdutoCategoria.Get().OrderBy(a => a.Nome).ToList();

            //atualiza o combo
            categoriaComboBox.DisplayMember = "Nome";
            categoriaComboBox.ValueMember = "IdCategoria";
            categoriaComboBox.DataSource = this.Categorias;
        }

        private void CarregaProdutos(int idCategoria)
        {
            this.Produtos = Servicos.Laboratorio.Services.Produto.GetByCategoria(idCategoria).OrderBy(a => a.Nome).ToList();

            //faz loop carregando os produtos
            CarregaListView_Produtos();

            //verifica se esta visivel
            if (Produtos.Count > 0)
            {
                produtoLabel.Visible = true;
                produtosListView.Visible = true;
            }
            else
            {
                produtoLabel.Visible = false;
                produtosListView.Visible = false;
            }
        }

        private void CarregaTamanhos(int idProduto)
        {
            this.Tamanhos = Servicos.Laboratorio.Services.ProdutoTamanho.GetByProduto(idProduto).Select(a => a.Tamanho).OrderBy(a => a.Nome).ToList();

            //atualiza o combo
            tamanhoComboBox.DisplayMember = "Nome";
            tamanhoComboBox.ValueMember = "IdTamanho";
            tamanhoComboBox.DataSource = this.Tamanhos;

            //verifica se esta visivel
            if (Tamanhos.Count > 0)
            {
                tamanhoLabel.Visible = true;
                tamanhoComboBox.Visible = true;
            }
            else
            {
                tamanhoLabel.Visible = false;
                tamanhoComboBox.Visible = false;
            }
        }

        private void CarregaPapeis(int idProduto)
        {
            this.Papeis = Servicos.Laboratorio.Services.ProdutoPapel.GetByProduto(idProduto).Select(a => a.Papel).OrderBy(a => a.Nome).ToList();

            //atualiza o combo
            papelComboBox.DisplayMember = "Nome";
            papelComboBox.ValueMember = "IdPapel";
            papelComboBox.DataSource = this.Papeis;

            //verifica se esta visivel
            if (Papeis.Count > 0)
            {
                papelLabel.Visible = true;
                papelComboBox.Visible = true;
            }
            else
            {
                papelLabel.Visible = false;
                papelComboBox.Visible = false;
            }
        }

        private void CarregaAcessorios(int idProduto)
        {
            this.Acessorios = Servicos.Laboratorio.Services.ProdutoAcessorio.GetByProduto(idProduto).Select(a => a.Acessorio).OrderBy(a => a.Nome).ToList();

            //carrega o grid
            CarregaGridView_Acessorios();

            //verifica se esta visivel
            if (Acessorios.Count > 0)
            {
                acessorioLabel.Visible = true;
                acessoriosDataGrid.Visible = true;
            }
            else
            {
                acessorioLabel.Visible = false;
                acessoriosDataGrid.Visible = false;
            }
        }

        private void CarregaRevestimentos(int idProduto)
        {
            this.Revestimentos = Servicos.Laboratorio.Services.ProdutoRevestimento.GetByProduto(idProduto).Select(a => a.Revestimento).OrderBy(a => a.Nome).ToList();

            //faz loop carregando os produtos
            CarregaListView_Revestimentos();

            //verifica se esta visivel
            if (Revestimentos.Count > 0)
            {
                revestimentosListView.Visible = true;
            }
            else
            {
                revestimentosListView.Visible = false;
            }
        }

        private void CarregaResumo()
        {
            var resumo = "Confira todas as informações e verifique se o pedido está correto:\n\n\n";

            if (!string.IsNullOrEmpty(this.Pedido.Cliente))
                resumo += string.Format("Cliente: {0}\n\n", this.Pedido.Cliente);
            if (!string.IsNullOrEmpty(this.Pedido.Categoria) && !string.IsNullOrEmpty(this.Pedido.Produto))
                resumo += string.Format("Produto: {0} - {1}\n\n", this.Pedido.Categoria, this.Pedido.Produto);
            if (!string.IsNullOrEmpty(this.Pedido.Tamanho))
                resumo += string.Format("Tamanho: {0}\n\n", this.Pedido.Tamanho);
            if (!string.IsNullOrEmpty(this.Pedido.Detalhes))
                resumo += string.Format("{0}", this.Pedido.Detalhes);
            if (!string.IsNullOrEmpty(this.Pedido.Observacoes))
                resumo += string.Format("Observacoes: \n{0}\n\n", this.Pedido.Observacoes);

            var capa = "";
            foreach (var item in this.Pedido.EnvioImagem.Where(a => a.Tipo == "Capa"))
            {
                capa += item.Nome + ", ";
            }
            if (!string.IsNullOrEmpty(capa))
                resumo += string.Format("Imagens da Capa: {0}\n\n", capa);

            var embalagem = "";
            foreach (var item in this.Pedido.EnvioImagem.Where(a => a.Tipo == "Embalagem"))
            {
                embalagem += item.Nome + ", ";
            }
            if (!string.IsNullOrEmpty(embalagem))
                resumo += string.Format("Imagens da Embalagem: {0}\n\n", embalagem);

            var bloco = "";
            foreach (var item in this.Pedido.EnvioImagem.Where(a => a.Tipo == "Bloco"))
            {
                bloco += item.Nome + ", ";
            }
            if (!string.IsNullOrEmpty(bloco))
                resumo += string.Format("Imagens do Bloco: {0}\n\n", bloco);


            resumoTextBox.Text = resumo;
        }

        //carrega listviews e grids
        private void CarregaListView_Produtos()
        {
            //limpa as imagens
            produtosListView.Items.Clear();
            produtosImageList.Images.Clear();

            //carrega os itens
            foreach (var item in Produtos)
            {
                var server = @"http://cpc.canaanfotos.com.br:3000/content/images/produto/";
                var image = Lib.Utilitarios.ImageUtility.GetFromURL(string.Format(@"{0}/{1}", server, item.Imagem));

                produtosImageList.Images.Add(item.IdProduto.ToString(), image);

                produtosListView.Items.Add(new ListViewItem
                {
                    ImageKey = item.IdProduto.ToString(),
                    Text = item.Nome
                });
            }

            produtosListView.LargeImageList = produtosImageList;
            produtosListView.Refresh();
            produtosListView.EndUpdate();

            if (produtosListView.Items.Count > 0)
            {
                produtosListView.Items[0].Selected = true;
            }
        }

        private void CarregaListView_Revestimentos()
        {
            //limpa as imagens
            revestimentosListView.Items.Clear();
            revestimentosImageList.Images.Clear();

            //carrega os itens
            foreach (var item in Revestimentos)
            {
                var server = @"http://cpc.canaanfotos.com.br:3000/content/images/revestimento";
                var image = Lib.Utilitarios.ImageUtility.GetFromURL(string.Format(@"{0}/{1}", server, item.Imagem));

                revestimentosImageList.Images.Add(item.IdRevestimento.ToString(), image);

                revestimentosListView.Items.Add(new ListViewItem
                {
                    ImageKey = item.IdRevestimento.ToString(),
                    Text = item.Nome
                });
            }

            revestimentosListView.LargeImageList = revestimentosImageList;
            revestimentosListView.Refresh();
            revestimentosListView.EndUpdate();

            if (revestimentosListView.Items.Count > 0)
            {
                revestimentosListView.Items[0].Selected = true;
            }
        }

        private void CarregaListView_Capa()
        {
            //limpa as imagens
            capaListView.Items.Clear();
            capaImageList.Images.Clear();

            //carrega os itens
            foreach (var item in Pedido.EnvioImagem.Where(a => a.Tipo == "Capa"))
            {
                var image = Image.FromFile(item.Caminho);
                var thumb = Lib.Utilitarios.ImageUtility.GetThumbnail(image, 150, 150);

                capaImageList.Images.Add(item.Nome, thumb);

                capaListView.Items.Add(new ListViewItem
                {
                    ImageKey = item.Nome,
                    Text = item.Nome
                });
            }

            capaListView.LargeImageList = capaImageList;
            capaListView.Refresh();
            capaListView.EndUpdate();
        }

        private void CarregaListView_Bloco()
        {
            //limpa as imagens
            blocoListView.Items.Clear();
            blocoImageList.Images.Clear();

            //carrega os itens
            foreach (var item in Pedido.EnvioImagem.Where(a => a.Tipo == "Bloco"))
            {
                var image = Image.FromFile(item.Caminho);
                var thumb = Lib.Utilitarios.ImageUtility.GetThumbnail(image, 150, 150);

                blocoImageList.Images.Add(item.Nome, thumb);

                blocoListView.Items.Add(new ListViewItem
                {
                    ImageKey = item.Nome,
                    Text = item.Nome
                });
            }

            blocoListView.LargeImageList = blocoImageList;
            blocoListView.Refresh();
            blocoListView.EndUpdate();
        }

        private void CarregaListView_Embalagem()
        {
            //limpa as imagens
            embalagemListView.Items.Clear();
            embalagemImageList.Images.Clear();

            //carrega os itens
            foreach (var item in Pedido.EnvioImagem.Where(a => a.Tipo == "Embalagem"))
            {
                var image = Image.FromFile(item.Caminho);
                var thumb = Lib.Utilitarios.ImageUtility.GetThumbnail(image, 150, 150);

                embalagemImageList.Images.Add(item.Nome, thumb);

                embalagemListView.Items.Add(new ListViewItem
                {
                    ImageKey = item.Nome,
                    Text = item.Nome
                });
            }

            embalagemListView.LargeImageList = embalagemImageList;
            embalagemListView.Refresh();
            embalagemListView.EndUpdate();
        }

        private void CarregaGridView_Acessorios()
        {
            //limpa os itens
            acessoriosDataGrid.Rows.Clear();

            //carrega o grid
            foreach (var item in this.Acessorios)
            {
                var row = new DataGridViewRow();

                //item
                DataGridViewTextBoxCell itemText = new DataGridViewTextBoxCell();
                itemText.Value = item.Nome;

                //options
                var itemList = new List<Servicos.Laboratorio.Models.AcessorioItem>();
                itemList.Add(new Servicos.Laboratorio.Models.AcessorioItem
                {
                    IdAcessorio = 0,
                    IdItem = 0,
                    Nome = "Nenhum"
                });

                foreach (var acessorioItem in Servicos.Laboratorio.Services.AcessorioItem.GetByAcessorio(item.IdAcessorio))
                {
                    itemList.Add(acessorioItem);
                }

                DataGridViewComboBoxCell valueComboBox = new DataGridViewComboBoxCell();
                valueComboBox.ValueMember = "IdItem";
                valueComboBox.DisplayMember = "Nome";
                valueComboBox.DataSource = itemList;
                valueComboBox.Value = 0;

                //add cell
                row.Cells.Add(itemText);
                row.Cells.Add(valueComboBox);

                //adiciona no grid
                acessoriosDataGrid.Rows.Add(row);
                acessoriosDataGrid.Refresh();
                acessoriosDataGrid.EndEdit();
            }

            acessoriosDataGrid.ClearSelection();
        }

        private bool VerificaAcessorioImagem()
        {
            var result = false;

            foreach (DataGridViewRow item in acessoriosDataGrid.Rows)
            {
                var id = (int)item.Cells[1].Value;

                if (id != 0)
                {
                    var acessorio = Servicos.Laboratorio.Services.AcessorioItem.GetById(id);

                    if (acessorio.IsFotografico)
                        result = true;
                }

            }

            if (result == false)
            {
                //remove todas as imagens da lista
                var lista = this.Pedido.EnvioImagem.Where(a => a.Tipo == "Embalagem").ToList();

                foreach (var item in lista)
                {
                    this.Pedido.EnvioImagem.Remove(item);
                }
            }

            return result;
        }

        private bool VerificaCapaImagem()
        {
            var status = false;
            var id = int.Parse(produtosListView.SelectedItems[0].ImageKey);
            var prod = this.Produtos.FirstOrDefault(a => a.IdProduto == id);

            if (prod.IsCapaFotografica)
            {
                status = true;
            }
            else
            {
                //remove todas as imagens da lista
                var lista = this.Pedido.EnvioImagem.Where(a => a.Tipo == "Capa").ToList();

                foreach (var item in lista)
                {
                    this.Pedido.EnvioImagem.Remove(item);
                }
            }


            return status;
        }

        //capa
        private void AdicionaCapa(string[] imagens, string[] nomes)
        {
            for (int i = 0; i < imagens.Count(); i++)
            {
                this.Pedido.EnvioImagem.Add(new Dados.EnvioImagem
                {
                    IdEnvioImagem = 0,
                    IdEnvioPedido = Pedido.IdEnvioPedido,
                    Tipo = "Capa",
                    Nome = nomes[i],
                    Caminho = imagens[i]
                });
            }

            CarregaListView_Capa();
        }

        private void RemoveCapa()
        {
            if (capaListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in capaListView.SelectedItems)
                {
                    var deleted = Pedido.EnvioImagem.FirstOrDefault(a => a.Tipo == "Capa" && a.Nome == item.ImageKey);

                    if (deleted != null)
                        Pedido.EnvioImagem.Remove(deleted);
                }

                CarregaListView_Capa();
            }
        }

        //bloco
        private void AdicionaBloco(string[] imagens, string[] nomes)
        {
            for (int i = 0; i < imagens.Count(); i++)
            {
                this.Pedido.EnvioImagem.Add(new Dados.EnvioImagem
                {
                    IdEnvioImagem = 0,
                    IdEnvioPedido = Pedido.IdEnvioPedido,
                    Tipo = "Bloco",
                    Nome = nomes[i],
                    Caminho = imagens[i]
                });
            }

            CarregaListView_Bloco();
        }

        private void RemoveBloco()
        {
            if (capaListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in blocoListView.SelectedItems)
                {
                    var deleted = Pedido.EnvioImagem.FirstOrDefault(a => a.Tipo == "Bloco" && a.Nome == item.ImageKey);

                    if (deleted != null)
                        Pedido.EnvioImagem.Remove(deleted);
                }

                CarregaListView_Bloco();
            }
        }

        //embalagem
        private void AdicionaEmbalagem(string[] imagens, string[] nomes)
        {
            for (int i = 0; i < imagens.Count(); i++)
            {
                this.Pedido.EnvioImagem.Add(new Dados.EnvioImagem
                {
                    IdEnvioImagem = 0,
                    IdEnvioPedido = Pedido.IdEnvioPedido,
                    Tipo = "Embalagem",
                    Nome = nomes[i],
                    Caminho = imagens[i]
                });
            }

            CarregaListView_Embalagem();
        }

        private void RemoveEmbalagem()
        {
            if (embalagemListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in embalagemListView.SelectedItems)
                {
                    var deleted = Pedido.EnvioImagem.FirstOrDefault(a => a.Tipo == "Embalagem" && a.Nome == item.ImageKey);

                    if (deleted != null)
                        Pedido.EnvioImagem.Remove(deleted);
                }

                CarregaListView_Embalagem();
            }
        }

        //salva registro
        private void SalvaPedido()
        {
            if (this.Envio != null)
            {
                var libEnvio = new Lib.Envio();

                //marca o pedido como criado
                libEnvio.UpdateEnvio(Dados.EnumEnvioStatus.Aguardando, this.Envio.IdEnvio);
            }

            //salva no banco de dados
            var libPedido = new Lib.EnvioPedido();

            this.Pedido.IsPendente = false;

            this.Pedido = libPedido.Insert(this.Pedido);
        }

        #endregion        
    }
}