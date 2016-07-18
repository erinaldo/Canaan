using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Canaan.Telas.Base;

namespace Canaan.Telas.Configuracoes.Geral.GrupoEmpresa
{
    public partial class Lista : FormLista
    {
        //
        //PROPRIEDADES
        Lib.GrupoEmpresa objLib;
        List<Dados.GrupoEmpresa> objLista;

        //
        //CONSTRUTORES
        public Lista()
        {
            //inicializa propriedades
            objLib = new Lib.GrupoEmpresa();
            objLista = objLib.GetByAtivo(true);
            
            //inicializa os componentes
            InitializeComponent();

            //inicializa o titulo
            Text = "Listagem de Grupos de Empresa";
        }

        //
        //EVENTOS
        private void Lista_Load(object sender, EventArgs e)
        {
            CarregaActions();
            CarregaGrid(objLib.CarregaGrid(objLista));
        }

        //
        //METODOS
        protected override void CarregaNovo()
        {
            //carrega tela de inclusao
            Edita frm = new Edita();
            frm.ShowDialog();

            //atualiza o grid
            objLista = objLib.GetByAtivo(true);
            CarregaGrid(objLib.CarregaGrid(objLista));
        }

        protected override void CarregaEdita()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                //carrega id selecionado
                int id = (int)dataGrid.SelectedRows[0].Cells[0].Value;

                //carrega tela de inclusao
                Edita frm = new Edita(id);
                frm.ShowDialog();

                //atualiza o grid
                objLista = objLib.GetByAtivo(true);
                CarregaGrid(objLib.CarregaGrid(objLista));
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado");
            }
        }

        protected override void ExecutaDelete()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                //carrega id selecionado
                int id = (int)dataGrid.SelectedRows[0].Cells[0].Value;
                var deleted = objLib.GetById(id);

                //carrega tela de inclusao
                try
                {
                    if (MessageBox.Show("Tem certeza que deseja excluir o registro '" + deleted.Nome + "' ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //deleta objeto
                        deleted = objLib.Delete(id);
                        MessageBox.Show("Registro '" + deleted.Nome + "' excluido com sucesso");

                        //atualiza o grid
                        objLista = objLib.GetByAtivo(true);
                        CarregaGrid(objLib.CarregaGrid(objLista));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado");
            }
        }

        protected override void CarregaActions()
        {
            btnActions.DropDownItems.Add(new ToolStripMenuItem("Filiais", null, new EventHandler(btnFiliais_Click)));
        }

        protected override void CarregaFiltros()
        {
            
        }


        //
        //EVENTOS DAS ACTIONS
        private void btnFiliais_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                int id = int.Parse(dataGrid.SelectedRows[0].Cells[0].Value.ToString());
                var frm = new Filiais.Lista(id);
                frm.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Nenhum registro selecionado");
            }
        }

        //
        //EVENTOS DOS FILTROS
        
    }
}
