using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Base;

namespace Canaan.Telas.Configuracoes.Geral.Filiais
{
    public partial class Lista : FormLista
    {
        //
        //PROPRIEDADES
        Filial objLib;
        List<Dados.Filial> objLista;

        //
        //CONSTRUTORES
        public Lista()
        {
            //inicializa propriedades
            objLib = new Filial();
            objLista = objLib.GetByAtivo(true);

            //inicializa os componentes
            InitializeComponent();

            //inicializa o titulo
            Text = "Listagem de Filiais";
        }

        public Lista(int idgrupoempresa)
        {
            //inicializa propriedades
            objLib = new Filial();
            objLista = objLib.GetByGrupo(idgrupoempresa);

            //inicializa os componentes
            InitializeComponent();

            //inicializa o titulo
            var libGrupo = new Lib.GrupoEmpresa();
            Text = "Listagem de Filiais do Grupo: " + libGrupo.GetById(idgrupoempresa).Nome;
        }

        //
        //EVENTOS
        private void Lista_Load(object sender, EventArgs e)
        {
            //CarregaActions();
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
                    if (MessageBox.Show("Tem certeza que deseja excluir o registro '" + deleted.NomeFantasia + "' ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                    {
                        //deleta objeto
                        deleted = objLib.Delete(id);
                        MessageBox.Show("Registro '" + deleted.NomeFantasia + "' excluido com sucesso");

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
        }

        protected override void CarregaFiltros()
        {
        }
    }
}
