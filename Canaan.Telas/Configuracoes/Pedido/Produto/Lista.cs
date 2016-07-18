using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Base;
using Canaan.Telas.Configuracoes.Pedido.Tabela.Estudio;
using Canaan.Telas.Properties;

namespace Canaan.Telas.Configuracoes.Pedido.Produto
{
    public partial class Lista : FormLista
    {
        public Dados.Tabela Tabela { get; set; }

        public Lib.Produto LibProduto 
        { 
            get
            {
                return new Lib.Produto();
            }
        }

        public List<Dados.Produto> Produtos { get; set; }

        public Lista(Dados.Tabela tabela)
        {
            Tabela = tabela;
            InitializeComponent();
        }

        //EVENTOS
        private void Lista_Load(object sender, EventArgs e)
        {
            CarregaActions();
            CarregaGrid();
            SetTitle();
        }

        private void btnFiliais_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                var frmParcerias = new Seleciona(Id);
                frmParcerias.ShowDialog();
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
            }
        }

        //METODOS
        private void SetTitle()
        {
            if (Tabela != null)
                Text = string.Format("Produtos da tabela : {0}", Tabela.Nome);
        }

        protected override void CarregaNovo()
        {
            //carrega tela de inclusao
            Edita frm = new Edita(Tabela.IdTabela);
            frm.ShowDialog();

            //atualiza o grid
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            Produtos = LibProduto.GetByTabela(Tabela.IdTabela);
            CarregaGrid(LibProduto.CarregaGrid(Produtos));
        }

        protected override void CarregaEdita()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                //carrega tela de inclusao
                Edita frm = new Edita(LibProduto.GetById(Id));
                frm.ShowDialog();

                //atualiza o grid
                CarregaGrid();
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
            }
        }

        protected override void ExecutaDelete()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                var deleted = LibProduto.GetById(Id);

                //carrega tela de inclusao
                try
                {
                    if (MessageBoxUtilities.MessageQuestion("Tem certeza que deseja excluir o registro '" + deleted.Nome + "' ?") == DialogResult.Yes)
                    {
                        //deleta objeto
                        deleted = LibProduto.Delete(Id);
                        MessageBoxUtilities.MessageInfo("Registro '" + deleted.Nome + "' excluido com sucesso");

                        //atualiza o grid
                        CarregaGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBoxUtilities.MessageError(this, ex);
                }


            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
            }
        }

        protected override void CarregaActions()
        {
            btnActions.DropDownItems.Add(new ToolStripMenuItem("Serviços", Resources.arrow_Sync_16xLG, new EventHandler(btnServicos_Click)));
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {

            if (Id != 0)
            {

                var frm = new Servicos.Servicos(Id);
                frm.ShowDialog();
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
            }
        }

        protected override void CarregaFiltros()
        {
        }
    }
}
