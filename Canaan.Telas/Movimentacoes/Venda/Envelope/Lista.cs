using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Lib.Model;
using Canaan.Lib.Utilitarios;
using Canaan.Telas.Base;
using Canaan.Telas.Movimentacoes.Venda.Envelope.Colecoes;
using Canaan.Telas.Movimentacoes.Venda.Envelope.Item;
using Canaan.Telas.Movimentacoes.Venda.Envelope.Servico;
using OrdemServico = Canaan.Lib.OrdemServico;
using Produto = Canaan.Lib.Produto;
using VendaItem = Canaan.Lib.VendaItem;
using VendaItemOrdemServico = Canaan.Lib.VendaItemOrdemServico;

namespace Canaan.Telas.Movimentacoes.Venda.Envelope
{
    public partial class Lista : FormVendaBase
    {
        private Principal.Principal principal;

        #region PROPRIEDADES

        public Modelo Model { get; set; }

        public Lib.Servico LibServico
        {
            get
            {
                return new Lib.Servico();
            }
        }

        public VendaItem LibVendaItem
        {
            get
            {
                return new VendaItem();
            }
        }

        public Dados.Venda Venda { get; set; }

        public Produto LibProduto
        {
            get
            {
                return new Produto();
            }
        }

        public OrdemServico LibOrdemServico
        {
            get
            {
                return new OrdemServico();
            }
        }

        public Lib.Model.Produto ProdutoCorrente { get; set; }

        public VendaItemOrdemServico LibVendaItemOrdermServico
        {
            get
            {
                return new VendaItemOrdemServico();
            }
        }

        public Dados.VendaItem VendaItem { get; set; }

        public Lib.Venda LibVenda
        {
            get
            {
                return new Lib.Venda();
            }
        }

        public bool CanUpdateFlag { get; set; }

        public bool AllowNext { get; set; }

        #endregion

        #region CONSTRUTOR

        public Lista(Dados.Venda venda, Principal.Principal principal)
        {
            Venda = venda;
            this.principal = principal;

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Lista_Load(object sender, EventArgs e)
        {
            dataGridProduto.AutoGenerateColumns = false;
            datagridEnvelope.AutoGenerateColumns = false;

            InitModel();
            InitBinding();
            CanUpdate();
            AtualizaValorDataVenda();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditaEnvelope();
        }

        private void datagridEnvelope_DoubleClick(object sender, EventArgs e)
        {
            EditaEnvelope();
        }

        private void EditaEnvelope()
        {
            try
            {
                if (CanUpdateFlag)
                {
                    var frm = new ItemEnvelope(Model.SelectedOrdem.Codigo, Venda.IdPedido);
                    frm.ShowDialog();
                    CarregaModel();
                }
                else
                {
                    MessageBoxUtilities.MessageWarning(string.Format("Venda com o status {0} não pode ser alterada.", Venda.Status));
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void btSalvarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizaValorDataVenda();

                if (/*LibVenda.ExisteOrdensServico(Venda) && */ Venda.ValorBruto != null)
                {
                    //habilita lançamento financeiro
                    principal.lkFinanceiro.Enabled = true;
                }
                else
                {
                    MessageBoxUtilities.MessageWarning("Não existe nenhuma Ordem de Serviço criada. \nNão será possível dar continuidade ao processo de venda");
                }

                MessageBoxUtilities.MessageInfo("Venda atualizada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
            
        }

        public void AtualizaValorDataVenda()
        {
            try
            {
                //Atualiza Valor e data da Venda
                //var valor = Model.ItensVenda.Sum(a => a.Prod.Valor * a.Quantidade);
                var valor = LibVendaItem.GetByVenda(Venda.IdPedido).Sum(a => a.ValorUnitario * a.Quant);
                Venda.DataVenda = DateTime.Now;
                Venda.ValorBruto = valor;
                LibVenda.Update(Venda);

                valorToolStripButton.Text = string.Format("{0:c}", Venda.ValorBruto);
                //Lib.MessageBoxUtilities.MessageInfo("Venda atualizada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        #region PRODUTO

        private void novoProduto_Click(object sender, EventArgs e)
        {
            AbriBuscaProduto();
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (Model.SelectedProd != null)
                {
                    //Abre tela editar item da venda
                    var frm = new Edita(LibVendaItem.GetById(Model.SelectedProd.Codigo));
                    frm.ShowDialog();

                    CarregaModel();

                    //atualiza valor da venda
                    AtualizaValorDataVenda();
                }
                else
                {
                    MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void btExcluirProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (Model.SelectedProd == null)
                {
                    MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
                }
                else
                {
                    //Processa Exclusão de um Item Venda
                    ProcessaExclusaoProduto();

                    //Recarrega Model
                    CarregaModel();

                    //atualiza valor da venda
                    AtualizaValorDataVenda();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void dataGridProduto_SelectionChanged(object sender, EventArgs e)
        {
            datagridEnvelope.ClearSelection();

            //Seleciona o Venda Item Corrente
            Model.ProdRowSelected = dataGridProduto.CurrentRow;

            //Configura Cor do Grid
            SetAllRowsColor(Color.White);
            SetColor(Color.White);
        }

        #endregion

        #region ENVELOPE

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Verifica se item selecionado na lista de Venda Item
            //if (dataGridProduto.SelectedRows.Count <= 0)
            //{
            //    Lib.MessageBoxUtilities.MessageWarning("Nenhum produto selecionado. Adicione um porduto antes de criar um novo envelope");
            //}
            //else
            //{
            //Abre lista para pesquisa de produto

            var frmBuscaServico = new BuscaServicos();
            frmBuscaServico.ShowDialog();

            //Adiciona Ordem de serviço
            var ordemServ = LibOrdemServico.Insert(new Dados.OrdemServico
            {
                IdPedido = Venda.IdPedido,
                IdServico = frmBuscaServico.Model.ServicoSelecionado.IdServico,
                IdAlbum = null,
                IdMoldura = null,
                NomeAbertura = null,
                Data = DateTime.Now,
                DataPrevista = DateTime.Now.AddDays(frmBuscaServico.Model.ServicoSelecionado.Previsao),
                Observacao = null,
                Status = EnumStatusServico.AguardandoLiberacao
            });


            //Salvar relação ordem de serviço venda item
            //LibVendaItemOrdermServico.Insert(new Dados.VendaItemOrdemServico
            //{
            //    IdItem = Model.SelectedProd.Codigo,
            //    IdOrdemServico = ordemServ.IdOrdemServico
            //});

            CarregaModel();

            MessageBoxUtilities.MessageInfo("Ordem de serviço criada com sucesso");
            //}
        }

        private void datagridEnvelope_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Colore o grid de acordo com o Item selecionado
            SetAllRowsColor(Color.White);
            SetColor(Color.White);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Model.SelectedOrdem != null)
                {

                    //Venda item do envelope selecionado
                    var vendaItem = LibProduto.GetByOrdem(Model.SelectedOrdem.Codigo);

                    //Verifica se a ordem de serviço a ser deletada tem envelope criado
                    if (LibOrdemServico.ExisteEnvelope(Model.SelectedOrdem))
                    {
                        if (MessageBoxUtilities.MessageQuestionWarning("Deseja relamente deletar esta ordem de serviço. Os envelopes criados também serão deletados.") == DialogResult.Yes)
                        {
                            LibOrdemServico.Delete(Model.SelectedOrdem.Codigo);
                            CarregaModel();
                        }
                    }
                    else
                    {
                        LibOrdemServico.Delete(Model.SelectedOrdem.Codigo);
                        CarregaModel();
                    }
                }
                else
                {
                    MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }


        }

        private void datagridEnvelope_SelectionChanged(object sender, EventArgs e)
        {
            //Seleciona a ordem atual
            Model.OrdemRowSelected = datagridEnvelope.CurrentRow;
        }

        #endregion

        #endregion

        #region METODOS

        private void AbriBuscaProduto()
        {
            var frm = new BuscaColecao();
            var result = frm.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                MessageBoxUtilities.MessageWarning("Nenhum produto selecionado");
            }
            else if (result == DialogResult.OK && frm.Selected)
            {
                ProdutoCorrente = frm.Model.ColecaoSelecionada;

                if (LibVendaItem.CanInsert(Venda.IdPedido, ProdutoCorrente.Codigo))
                {

                    VendaItem = LibVendaItem.Insert(new Dados.VendaItem
                                    {
                                        IdProduto = ProdutoCorrente.Codigo,
                                        IdPedido = Venda.IdPedido,
                                        Quant = frm.Model.Quantidade,
                                        ValorUnitario = frm.Model.PrecoUnitario,
                                        ValorTotal = frm.Model.PrecoTotal
                                    });


                    CriaOrdemServico(frm.Model.Quantidade);

                    //atualiza valor da venda
                    AtualizaValorDataVenda();

                    //Carrega Grids
                    CarregaModel();

                    MessageBoxUtilities.MessageInfo(string.Format("Produto {0} selecionado.", frm.Model.ColecaoSelecionada.Nome));
                }
                else
                {
                    MessageBoxUtilities.MessageWarning(string.Format("O Produto {0} já esta adicionado a esta venda.", ProdutoCorrente.Nome));
                }

            }
        }

        private void CriaOrdemServico(decimal quantidade)
        {
            //Carrega serviços do produto
            var servicos = LibServico.GetByProduto(ProdutoCorrente.Prod.IdProduto);

            for (int i = 0; i < quantidade; i++)
            {
                foreach (var item in servicos)
                {

                    //Ordem de Serviço
                    var ordemServico = new Dados.OrdemServico
                    {
                        IdPedido = Venda.IdPedido,
                        IdServico = item.IdServico,
                        IdAlbum = null,
                        IdMoldura = null,
                        NomeAbertura = null,
                        Data = DateTime.Now,
                        DataPrevista = DateTime.Now.AddDays(item.Previsao),
                        Observacao = null,
                        Status = EnumStatusServico.AguardandoLiberacao
                    };

                    LibOrdemServico.Insert(ordemServico);


                    //Relação Orderm de Servico VendaItem

                    var relacao = new Dados.VendaItemOrdemServico
                    {
                        IdOrdemServico = ordemServico.IdOrdemServico,
                        IdItem = VendaItem.IdItem
                    };

                    LibVendaItemOrdermServico.Insert(relacao);
                }
            }
        }

        private void InitForm()
        {
            dataGridProduto.AutoGenerateColumns = false;
        }

        private void InitBinding()
        {
            CarregaModel();
            dataGridProduto.DataBindings.Add(new Binding("DataSource", Model, "ItensVenda"));
            datagridEnvelope.DataBindings.Add(new Binding("DataSource", Model, "OrdensServicos"));
        }

        private void InitModel()
        {
            Model = new Modelo();
        }

        private void CarregaModel()
        {
            //Carrega Vendas Itens
            var vendaItems = LibVendaItem.GetByVenda(Venda.IdPedido);
            Model.ItensVenda = new BindingList<Lib.Model.VendaItem>(LibVendaItem.CarregaGrid(vendaItems));

            //Carrega Servicos
            var ordensServico = LibOrdemServico.GetModelByVenda(Venda.IdPedido);
            Model.OrdensServicos = new BindingList<OrdermServico>(ordensServico);

        }

        private void SetAllRowsColor(Color color)
        {
            foreach (DataGridViewRow item in datagridEnvelope.Rows)
            {
                item.DefaultCellStyle.BackColor = color;
            }
        }

        private void SetColor(Color cor)
        {
            if (Model.SelectedProd == null)
                return;

            var result = datagridEnvelope.Rows.Cast<DataGridViewRow>().Where(a => ((OrdermServico)a.DataBoundItem).IdProduto == Model.SelectedProd.IdProduto);

            foreach (var item in result)
            {
                item.DefaultCellStyle.BackColor = Color.FromArgb(240, 251, 242);
            }
        }

        private void ProcessaExclusaoProduto()
        {
            try
            {
                if(MessageBoxUtilities.MessageQuestion(string.Format("Deseja deletar o produto {0} ?", Model.SelectedProd.Produto)) == DialogResult.Yes)
                {
                    LibVendaItem.Delete(Model.SelectedProd.Codigo);
                    MessageBoxUtilities.MessageInfo("Registro excluido com sucesso");
                }

                ////Verifica se ja existe Itens Criados para ordem der servicos
                //if (LibOrdemServico.CanDelete(Model.OrdensProdutoSelecionado))
                //{
                //    //Deleta Ordens Vinculadas
                //    LibOrdemServico.DeleteByVendaItem(Model.SelectedProd.Codigo);

                //    //Deleta Produtos
                //    LibVendaItem.Delete(Model.SelectedProd.Codigo);
                //}
                //else
                //{
                //    if (Lib.MessageBoxUtilities.MessageQuestionWarning("Já existem envelopes criados para este produto. Deseja excluir mesmo assim. Se escolher sim todos os envelopes deste produto serão exlcuidos") == System.Windows.Forms.DialogResult.Yes)
                //    {
                //        //Deleta Ordens Vinculadas
                //        LibOrdemServico.DeleteByVendaItem(Model.SelectedProd.Codigo);

                //        //Deleta Produto
                //        LibVendaItem.Delete(Model.SelectedProd.Codigo);
                //    }
                //}
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
                toolstripActions.Enabled = true;
                toolstripActionsProduto.Enabled = true;
                CanUpdateFlag = true;
            }
            else
            {
                toolstripActions.Enabled = false;
                toolstripActionsProduto.Enabled = false;
                CanUpdateFlag = false;
            }
        }

        #endregion
    }

    public class Modelo : INotifyPropertyChanged
    {
        public OrdemServico LibOrdemServico
        {
            get
            {
                return new OrdemServico();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        private BindingList<Lib.Model.VendaItem> itensVenda;
        public BindingList<Lib.Model.VendaItem> ItensVenda
        {
            get { return itensVenda; }
            set
            {
                itensVenda = value;
                NotifyPropertyChanged("ItensVenda");
            }
        }

        private BindingList<OrdermServico> servicos;
        public BindingList<OrdermServico> OrdensServicos
        {
            get { return servicos; }
            set
            {
                servicos = value;
                NotifyPropertyChanged("OrdensServicos");
            }
        }

        private DataGridViewRow prodRowSelected;
        public DataGridViewRow ProdRowSelected
        {
            get { return prodRowSelected; }
            set
            {
                prodRowSelected = value;
                NotifyPropertyChanged("ProdRowSelected");
                NotifyPropertyChanged("SelectedProd");
            }
        }

        public Lib.Model.VendaItem SelectedProd
        {
            get
            {
                if (ProdRowSelected == null)
                    return null;

                return ProdRowSelected.DataBoundItem as Lib.Model.VendaItem;
            }
        }

        private DataGridViewRow ordemRowSelected;
        public DataGridViewRow OrdemRowSelected
        {
            get { return ordemRowSelected; }
            set
            {
                ordemRowSelected = value;
                NotifyPropertyChanged("OrdemRowSelected");
                NotifyPropertyChanged("SelectedOrdem");
            }
        }

        public OrdermServico SelectedOrdem
        {
            get
            {
                if (OrdemRowSelected == null)
                    return null;

                return OrdemRowSelected.DataBoundItem as OrdermServico;
            }
        }

        public List<Dados.OrdemServico> OrdensProdutoSelecionado
        {
            get
            {
                if (SelectedProd == null)
                    return null;

                return LibOrdemServico.GetByVendaItem(SelectedProd.Codigo);
            }
        }
    }

}

