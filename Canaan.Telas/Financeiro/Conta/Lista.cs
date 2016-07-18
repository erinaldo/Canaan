using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Base;
using Canaan.Telas.Properties;

namespace Canaan.Telas.Financeiro.Conta
{
    public partial class Lista : FormLista
    {
        #region PROPRIEDADES

        public Lib.Conta objLib { get; set; }
        public List<Dados.Conta> objLista { get; set; }

        #endregion

        #region CONSTRUTORES

        public Lista()
        {
            //inicializa propriedades
            objLib = new Lib.Conta();
            objLista = objLib.Get();

            //inicializa os componentes
            InitializeComponent();

            //inicializa o titulo
            Text = "Listagem de Contas Bancárias";
        }

        public Lista(int idAgencia)
        {
            //inicializa propriedades
            objLib = new Lib.Conta();
            objLista = objLib.GetByAgencia(idAgencia);

            //inicializa os componentes
            InitializeComponent();

            //inicializa o titulo
            Text = "Listagem de Contas Bancárias: " + new Lib.Agencia().GetById(idAgencia).Nome;
        }

        #endregion

        #region EVENTOS

        private void Lista_Load(object sender, EventArgs e)
        {
            CarregaFiltros();
            CarregaGrid(objLib.CarregaGrid(objLista));
        }

        private void btnExecFiltro_Click(object sender, EventArgs e)
        {
            //Pega item clicado
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            string filterName = string.Empty;

            //Pega nome do filtro selecionado
            if (clickedItem != null)
                filterName = clickedItem.Text;

            //Carrega do banco o filtro
            FilterExpression = objLibFiltro.GetByNome(filterName, typeof(Dados.Conta).FullName, Session.Instance.Usuario.IdUsuario);


            //Se a expressao foi carregada com sucesso
            if (FilterExpression != null)
            {
                //Carrega form com as expressoes passadas como parametro
                var frmParam = new FormFilterParam(FilterExpression);
                frmParam.ShowDialog();

                //carrega os parametros
                Parametros = frmParam.Parametros;

                //atualiza lista
                CarregaLista();
            }
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                //Abre tela de Edição de Filtro
                var frm = new FormFilterBase(typeof(Dados.Conta));
                frm.ShowDialog();

                //Verifica se foi criado alguma expressã0
                if (frm.FilterExpression.Count > 0)
                {
                    FilterExpression = frm.FilterExpression;

                    var frmParam = new FormFilterParam(FilterExpression);
                    frmParam.ShowDialog();

                    //Constroi expressão
                    var expressao = FilterExpression.BuildExpression();

                    //carrega os parametros
                    Parametros = frmParam.Parametros;

                    //atualiza lista
                    CarregaLista();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(this, ex);
            }
        }

        #endregion

        #region METODOS

        private void CarregaLista()
        {
            if (Parametros != null)
            {
                objLista = objLib.Filter(FilterExpression.BuildExpression(), Parametros);
            }
            else
            {
                objLista = objLib.Get();
            }
            CarregaGrid(objLib.CarregaGrid(objLista));
        }

        protected override void CarregaNovo()
        {
            //carrega tela de inclusao
            Edita frm = new Edita();
            frm.ShowDialog();

            //recarrega lista
            CarregaLista();
        }

        protected override void CarregaEdita()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                //carrega tela de inclusao
                Edita frm = new Edita(Id);
                frm.ShowDialog();

                //recarrega a lista
                CarregaLista();
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
                //carrega id selecionado
                var deleted = objLib.GetById(Id);

                //carrega tela de inclusao
                try
                {
                    if (MessageBoxUtilities.MessageQuestion("Tem certeza que deseja excluir o registro '" + deleted.Nome + "' ?") == DialogResult.Yes)
                    {
                        //deleta objeto
                        deleted = objLib.Delete(Id);

                        //recarrega lista
                        CarregaLista();

                        //mensagem
                        MessageBoxUtilities.MessageInfo("Registro '" + deleted.Nome + "' excluido com sucesso");
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
        }

        protected override void CarregaFiltros()
        {
            // Carrega Lista de Filtros para a entidade atual
            var filtros = objLibFiltro.GetByEntidade(typeof(Dados.Conta).FullName, Session.Instance.Usuario.IdUsuario);

            //Adiciona filtros na lista 
            foreach (var item in filtros)
            {
                btnFiltros.DropDown.Items.Add(new ToolStripMenuItem(item.Nome, Resources.filter_16xLG, new EventHandler(btnExecFiltro_Click)));
            }

            //Adiciona o Criador de filtros
            btnFiltros.DropDownItems.Add(new ToolStripMenuItem("Novo Filtro", Resources.arrow_Sync_16xLG, new EventHandler(btnFiltros_Click)));
        }

        #endregion
    }
}
