using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Base;
using Canaan.Telas.Configuracoes.Pedido.Tabela.Estudio;
using Canaan.Telas.Properties;

namespace Canaan.Telas.Configuracoes.Pedido.Tabela
{
    public partial class Lista : FormLista
    {
        //CAMPOS
        public Lib.Tabela LibTabela 
        { 
            get
            {
                return new Lib.Tabela();
            }
        }

        public List<Dados.Tabela> Tabelas { get; set; }

        //CONSTRUTORES
        public Lista()
        {
            //inicializa os componentes
            InitializeComponent();

            //inicializa o titulo
            Text = "Listagem de Tabelas";
        }

        //EVENTOS
        private void Lista_Load(object sender, EventArgs e)
        {
            CarregaActions();
            CarregaGrid();
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
        protected override void CarregaNovo()
        {
            //carrega tela de inclusao
            Edita frm = new Edita();
            frm.ShowDialog();

            //atualiza o grid
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            Tabelas = LibTabela.GetByStatus(true);
            CarregaGrid(LibTabela.CarregaGrid(Tabelas));
        }

        protected override void CarregaEdita()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                //carrega tela de inclusao
                Edita frm = new Edita(Id);
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
                var deleted = LibTabela.GetById(Id);

                //carrega tela de inclusao
                try
                {
                    if (MessageBoxUtilities.MessageQuestion("Tem certeza que deseja excluir o registro '" + deleted.Nome + "' ?") == DialogResult.Yes)
                    {
                        //deleta objeto
                        deleted = LibTabela.Delete(Id);
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
            btnActions.DropDownItems.Add(new ToolStripMenuItem("Estúdios", Resources.arrow_Sync_16xLG, new EventHandler(btnFiliais_Click)));
            btnActions.DropDownItems.Add(new ToolStripMenuItem("Produtos", Resources.arrow_Sync_16xLG, new EventHandler(btnProdutos_Click)));
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                var frmProdutos = new Produto.Lista(LibTabela.GetById(Id));
                frmProdutos.ShowDialog();
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
