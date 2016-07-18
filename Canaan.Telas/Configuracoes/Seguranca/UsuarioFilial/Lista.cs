using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Canaan.Telas.Base;

namespace Canaan.Telas.Configuracoes.Seguranca.UsuarioFilial
{
    public partial class Lista : FormLista
    {
        //
        //PROPRIEDADES
        public Lib.UsuarioFilial objLib { get; set; }
        public List<Dados.UsuarioFilial> objLista { get; set; }
        public Dados.Usuario Usuario { get; set; }


        //
        //CONSTRUTORES
        public Lista(int idusuario)
        {
            //inicializa propriedades
            objLib = new Lib.UsuarioFilial();
            objLista = objLib.GetByUsuario(idusuario);
            Usuario = new Lib.Usuario().GetById(idusuario);

            //inicializa os componentes
            InitializeComponent();

            //inicializa o titulo
            Text = "Listagem de Filiais do Usuário " + Usuario.Nome;
        }


        //
        //EVENTOS
        private void Lista_Load(object sender, EventArgs e)
        {
            CarregaGrid(objLib.CarregaGrid(objLista));
        }


        //
        //METODOS
        protected override void CarregaNovo()
        {
            //carrega tela de inclusao
            Edita frm = new Edita(Usuario.IdUsuario);
            frm.ShowDialog();

            //atualiza o grid
            objLista = objLib.GetByUsuario(Usuario.IdUsuario);
            CarregaGrid(objLib.CarregaGrid(objLista));
        }

        protected override void CarregaEdita()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                //carrega id selecionado
                int id = (int)dataGrid.SelectedRows[0].Cells[0].Value;

                //carrega tela de inclusao
                Edita frm = new Edita(Usuario.IdUsuario ,id);
                frm.ShowDialog();

                //atualiza o grid
                objLista = objLib.GetByUsuario(Usuario.IdUsuario);
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
                    if (MessageBox.Show("Tem certeza que deseja excluir o registro '" + string.Format("{0} - {1}",deleted.Usuario.Nome, deleted.Filial.NomeFantasia) + "' ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //deleta objeto
                        objLib.Delete(id);
                        MessageBox.Show("Registro '" + string.Format("{0} - {1}", deleted.Usuario.Nome, deleted.Filial.NomeFantasia) + "' excluido com sucesso");

                        //atualiza o grid
                        objLista = objLib.GetByUsuario(Usuario.IdUsuario);
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
        }

        protected override void CarregaFiltros()
        {

        }
    }
}
