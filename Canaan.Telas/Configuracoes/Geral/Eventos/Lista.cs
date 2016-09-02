using Canaan.Telas.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Telas.Configuracoes.Geral.Eventos
{
    public partial class Lista : FormLista
    {
        //
        //PROPRIEDADES
        public Lib.Evento objLib { get; set; }
        public List<Dados.Evento> objLista { get; set; }
        public Dados.Filial Filial { get; set; }

        //
        //CONSTRUTORES
        public Lista()
        {
            //inicializa propriedades
            Filial = Lib.Session.Instance.Contexto.Filial;
            objLib = new Lib.Evento();
            objLista = objLib.GetByFilial(this.Filial.IdFilial);

            //inicializa os componentes
            InitializeComponent();

            //inicializa o titulo
            Text = "Listagem de Eventos";
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
            objLista = objLib.GetByFilial(this.Filial.IdFilial);
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
                objLista = objLib.GetByFilial(this.Filial.IdFilial);
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
                        objLista = objLib.GetByFilial(this.Filial.IdFilial);
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
