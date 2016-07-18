using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Base;
using Canaan.Telas.Properties;

namespace Canaan.Telas.Cadastros.ClienteFornecedor
{
    public partial class Lista : FormLista
    {
        //
        //PROPRIEDADES
        public CliFor objLib { get; set; }
        public List<Dados.CliFor> objLista { get; set; }
        public bool FlagSelecaoCliente { get; set; }
        public Dados.CliFor Cliente { get; set; }

        public CliFor LibCliFor 
        { 
            get
            {
                return new CliFor();
            }
        }


        //
        //CONSTRUTORES
        public Lista(bool atendimento = false)
        {
            //inicializa propriedades
            objLib = new CliFor();
            objLista = null;
            FlagSelecaoCliente = atendimento;

            //inicializa os componentes
            InitializeComponent();

            //inicializa o titulo
            Text = "Listagem de Clientes / Fornecedores";
        }


        //
        //EVENTOS
        private void Lista_Load(object sender, EventArgs e)
        {
            CarregaFiltros();
            CarregaGrid(objLib.CarregaGrid(objLista));
        }

        public override void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (FlagSelecaoCliente)
            {
                if (dataGrid.SelectedRows.Count > 0)
                {
                    Cliente = LibCliFor.GetById(int.Parse(dataGrid.SelectedRows[0].Cells[0].Value.ToString()));
                    Close();
                }
                else
                {
                    MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
                }
            }
            else
            {
                CarregaEdita();
            }
            //base.dataGrid_DoubleClick(sender, e);
        }

        private void btnExecFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                //Pega item clicado
                ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

                string filterName = string.Empty;

                //Pega nome do filtro selecionado
                if (clickedItem != null)
                    filterName = clickedItem.Text;

                //Carrega do banco o filtro
                FilterExpression = objLibFiltro.GetByNome(filterName, typeof(Dados.CliFor).FullName, Session.Instance.Usuario.IdUsuario);


                //Se a expressao foi carregada com sucesso
                if (FilterExpression != null)
                {
                    //Carrega form com as expressoes passadas como parametro
                    var frmParam = new FormFilterParam(FilterExpression);
                    var dialogResult = frmParam.ShowDialog();

                    if (dialogResult == DialogResult.Cancel)
                        return;

                    //carrega os parametros
                    Parametros = frmParam.Parametros;

                    //atualiza lista
                    CarregaLista();

                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }

        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                //Abre tela de Edição de Filtro
                var frm = new FormFilterBase(typeof(Dados.CliFor));
                frm.ShowDialog();

                //Verifica se foi criado alguma expressã0
                if (frm.FilterExpression.Count > 0)
                {
                    FilterExpression = frm.FilterExpression;

                    var frmParam = new FormFilterParam(FilterExpression);
                    var dialogResult = frmParam.ShowDialog();

                    if (dialogResult == DialogResult.Cancel)
                        return;

                    //Carrega os parametros
                    Parametros = frmParam.Parametros;

                    //Constroi expressão
                    var expressao = FilterExpression.BuildExpression();

                    //atualiza lista
                    CarregaLista();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(this, ex);
            }
        }

        //
        //METODOS
        protected override void CarregaNovo()
        {
            //carrega tela de inclusao
            Wizard frm = new Wizard();
            frm.ShowDialog();

            if (FlagSelecaoCliente)
            {
                Cliente = frm.CliFor;
                Close();
            }

            //recarrega lista
            CarregaLista();
        }

        protected override void CarregaEdita()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                //carrega tela de inclusao
                Wizard frm = new Wizard(Id);
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
                var nome = deleted.Nome;

                //carrega tela de inclusao
                try
                {
                    if (MessageBoxUtilities.MessageQuestion("Tem certeza que deseja excluir o registro '" + nome + "' ?") == DialogResult.Yes)
                    {
                        //deleta objeto
                        deleted = objLib.Delete(Id);
                        MessageBoxUtilities.MessageInfo("Registro '" + nome + "' excluido com sucesso");
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
            var filtros = objLibFiltro.GetByEntidade(typeof(Dados.CliFor).FullName, Session.Instance.Usuario.IdUsuario);

            //Adiciona filtros na lista 
            foreach (var item in filtros)
            {
                btnFiltros.DropDown.Items.Add(new ToolStripMenuItem(item.Nome, Resources.filter_16xLG, new EventHandler(btnExecFiltro_Click)));
            }

            //Adiciona o Criador de filtros
            btnFiltros.DropDownItems.Add(new ToolStripMenuItem("Novo Filtro", Resources.arrow_Sync_16xLG, new EventHandler(btnFiltros_Click)));
        }

        private void CarregaLista()
        {
            if (FilterExpression != null)
            {
                var expressao = FilterExpression.BuildExpression();
                var result = LibCliFor.Filter(expressao, Parametros);
                CarregaGrid(LibCliFor.CarregaGrid(result));
            }
        }
    }
}
