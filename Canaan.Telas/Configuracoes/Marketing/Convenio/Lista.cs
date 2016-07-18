using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Base;
using Canaan.Telas.Properties;

namespace Canaan.Telas.Configuracoes.Marketing.Convenio
{
    public partial class Lista : FormLista
    {
        //CAMPOS
        Lib.Convenio objLib;
        List<Dados.Convenio> objLista;

        //CONSTRUTORES
        public Lista()
        {
            //inicializa propriedades
            objLib = new Lib.Convenio();
            objLista = objLib.GetByAtivo(true);

            //inicializa os componentes
            InitializeComponent();

            //inicializa o titulo
            Text = "Listagem de Convenios";
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
                var frmParcerias = new Telas.Marketing.Parceria.Lista(Id);
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
            objLista = objLib.GetByAtivo(true);
            CarregaGrid(objLib.CarregaGrid(objLista));
        }

        protected override void CarregaEdita()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                //carrega tela de inclusao
                Edita frm = new Edita(Id);
                frm.ShowDialog();

                //atualiza o grid
                objLista = objLib.GetByAtivo(true);
                CarregaGrid(objLib.CarregaGrid(objLista));
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
                var deleted = objLib.GetById(Id);

                //carrega tela de inclusao
                try
                {
                    if (MessageBoxUtilities.MessageQuestion("Tem certeza que deseja excluir o registro '" + deleted.Nome + "' ?") == DialogResult.Yes)
                    {
                        //deleta objeto
                        deleted = objLib.Delete(Id);
                        MessageBoxUtilities.MessageInfo("Registro '" + deleted.Nome + "' excluido com sucesso");

                        //atualiza o grid
                        objLista = objLib.GetByAtivo(true);
                        CarregaGrid(objLib.CarregaGrid(objLista));
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
            btnActions.DropDownItems.Add(new ToolStripMenuItem("Parcerias", Resources.arrow_Sync_16xLG, new EventHandler(btnFiliais_Click)));
        }

        protected override void CarregaFiltros()
        {
        }

    }
}
