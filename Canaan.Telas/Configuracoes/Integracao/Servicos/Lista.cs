using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Base;
using Canaan.Telas.Configuracoes.Pedido.Tabela.Estudio;
using Canaan.Telas.Properties;
using Servico = Canaan.Dados.Servico;

namespace Canaan.Telas.Configuracoes.Integracao.Servicos
{
    public partial class Lista : FormLista
    {
        public List<Servico> Servicos { get; set; }

        public Lib.Servico LibServico
        {
            get
            {
                return new Lib.Servico();
            }
        }

        public Lista()
        {
            InitializeComponent();
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
            Servicos = LibServico.GetByStatus(true);
            CarregaGrid(LibServico.CarregaGrid(Servicos));
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
                var deleted = LibServico.GetById(Id);

                //carrega tela de inclusao
                try
                {
                    if (MessageBoxUtilities.MessageQuestion("Tem certeza que deseja excluir o registro '" + deleted.Nome + "' ?") == DialogResult.Yes)
                    {
                        //deleta objeto
                        deleted = LibServico.Delete(Id);
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
        }

        protected override void CarregaFiltros()
        {
        }
    }
}
