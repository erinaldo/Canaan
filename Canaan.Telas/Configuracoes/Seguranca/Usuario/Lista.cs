using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Canaan.Telas.Base;
using Canaan.Telas.Properties;

namespace Canaan.Telas.Configuracoes.Seguranca.Usuario
{
    public partial class Lista : FormLista
    {
        //
        //PROPRIEDADES
        Lib.Usuario objLib;
        List<Dados.Usuario> objLista;

        //
        //CONSTRUTORES
        public Lista()
        {
            //inicializa propriedades
            objLib = new Lib.Usuario();
            objLista = objLib.Get();

            //inicializa os componentes
            InitializeComponent();

            //inicializa o titulo
            Text = "Listagem de Usuários";
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
            objLista = objLib.Get();
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
                objLista = objLib.Get();
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
                        objLista = objLib.Get();
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
            btnActions.DropDownItems.Add(new ToolStripMenuItem("Alterar Senha", Resources.key_16xLG , new EventHandler(btnPassword_Click)));
            btnActions.DropDownItems.Add(new ToolStripMenuItem("Reenviar Senha", Resources.envelope_16xLG, new EventHandler(btnResend_Click)));
            btnActions.DropDownItems.Add(new ToolStripMenuItem("Permissões por Filial", Resources.Building_16xLG, new EventHandler(btnPermissao_Click)));
        }
        
        protected override void CarregaFiltros()
        {

        }

        //
        //EVENTOS DAS ACTIONS
        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                //carrega id selecionado
                int id = (int)dataGrid.SelectedRows[0].Cells[0].Value;

                //carrega tela de inclusao
                ChangePassword frm = new ChangePassword(id);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado");
            }
        }

        private void btnPermissao_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                //carrega id selecionado
                int id = (int)dataGrid.SelectedRows[0].Cells[0].Value;

                //carrega tela de inclusao
                UsuarioFilial.Lista frm = new UsuarioFilial.Lista(id);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado");
            }            
        }

        private void btnResend_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                //carrega id selecionado
                int id = (int)dataGrid.SelectedRows[0].Cells[0].Value;

                //carrega tela de inclusao
                try
                {
                    var retorno = objLib.SendPassword(id);
                    MessageBox.Show("Senha do usuário '" + retorno.Nome + "' enviado para '" + retorno.Email + "'");
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


        //
        //EVENTOS DOS FILTROS
    }
}
