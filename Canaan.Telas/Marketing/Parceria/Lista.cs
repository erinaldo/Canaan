using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Base;
using Canaan.Telas.Properties;

namespace Canaan.Telas.Marketing.Parceria
{
    public partial class Lista : FormLista
    {
        #region CAMPOS

        //
        //PROPRIEDADES
        Lib.Parceria objLib;
        Lib.Convenio objLibConv;
        List<Dados.Parceria> objLista;
        Dados.Convenio convenio;

        #endregion

        #region CONTRUTOR
        //
        //CONSTRUTORES
        public Lista()
        {
            //inicializa propriedades
            objLib = new Lib.Parceria();
            
            try
            {
                //Aplicar Filtro Padrão
                AplicaFiltroPadrao();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }



            //inicializa os componentes
            InitializeComponent();

            //inicializa o titulo
            Text = "Listagem de Parcerias";
        }

        public Lista(int idConvenio)
        {

            //Inicializa bibliotecas
            objLib = new Lib.Parceria();
            objLibConv = new Lib.Convenio();

            //inicializa propriedades
            convenio = objLibConv.GetById(idConvenio);
            objLista = objLib.GetByAtivo(convenio.IdConvenio, true, Session.Contexto.IdFilial);

            //inicializa os componentes
            InitializeComponent();

            //inicializa o titulo
            Text = string.Format("Parcerias do Convênio - {0}", convenio.Nome);
        }

        #endregion

        #region EVENTOS

        //
        //EVENTOS
        private void Lista_Load(object sender, EventArgs e)
        {
            CarregaActions();
            CarregaFiltros();
            //CarregaGrid(objLib.CarregaGrid(objLista));
        }        
        
        private void btnCupons_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGrid.SelectedRows.Count > 0)
                {
                    var frmCupons = new Cupom.Lista(Id);
                    frmCupons.ShowDialog();
                }
                else
                {
                    MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
                }

            }
            catch (Exception ex)
            {
                Lib.MessageBoxUtilities.MessageError(null, ex);
            }
        }

        #endregion

        #region METODOS

        //
        //METODOS
        protected override void CarregaNovo()
        {
            Edita frm;

            if (convenio == null)
                frm = new Edita();
            else
                frm = new Edita(convenio);
            //carrega tela de inclusao

            frm.ShowDialog();

            //Verifica se a lista de parcerias e de um convenio especifico
            if (convenio == null)
            {
                //atualiza o grid
                objLista = objLib.GetByAtivo(true, Session.Contexto.IdFilial);
                CarregaGrid(objLib.CarregaGrid(objLista));
            }
            else
            {
                objLista = objLib.GetByAtivo(convenio.IdConvenio, true, Session.Contexto.IdFilial);
                CarregaGrid(objLib.CarregaGrid(objLista));
            }
        }

        protected override void CarregaEdita()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                //carrega tela de inclusao
                Edita frm = new Edita(Id);
                frm.ShowDialog();


                //Verifica se a lista de parcerias e de um convenio especifico
                if (convenio == null)
                {
                    //atualiza o grid
                    objLista = objLib.GetByAtivo(true, Session.Contexto.IdFilial);
                    CarregaGrid(objLib.CarregaGrid(objLista));
                }
                else
                {
                    objLista = objLib.GetByAtivo(convenio.IdConvenio, true, Session.Contexto.IdFilial);
                    CarregaGrid(objLib.CarregaGrid(objLista));
                }
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
                        MessageBoxUtilities.MessageInfo("Registro '" + deleted.Nome + "' excluido com sucesso");

                        //Verifica se a lista de parcerias e de um convenio especifico
                        if (convenio == null)
                        {
                            //atualiza o grid
                            objLista = objLib.GetByAtivo(true, Session.Contexto.IdFilial);
                            CarregaGrid(objLib.CarregaGrid(objLista));
                        }
                        else
                        {
                            objLista = objLib.GetByAtivo(convenio.IdConvenio, true, Session.Contexto.IdFilial);
                            CarregaGrid(objLib.CarregaGrid(objLista));
                        }
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
            btnActions.DropDownItems.Add(new ToolStripMenuItem("Cupons", Resources.arrow_Sync_16xLG, new EventHandler(btnCupons_Click)));
        }

        #endregion

        #region CODIGO FILTRO

        public string Expressao { get; set; }

        protected override void CarregaFiltros()
        {
            // Carrega Lista de Filtros para a entidade atual
            var filtros = objLibFiltro.GetByEntidade(typeof(Dados.Parceria).FullName, Session.Instance.Usuario.IdUsuario);

            //Adiciona filtros na lista 
            foreach (var item in filtros)
            {
                btnFiltros.DropDown.Items.Add(new ToolStripMenuItem(item.Nome, Resources.filter_16xLG, new EventHandler(btlExecFiltro_Click)));
            }

            //Adiciona o Criador de filtros
            btnFiltros.DropDownItems.Add(new ToolStripMenuItem("Novo Filtro", Resources.arrow_Sync_16xLG, new EventHandler(btnFiltros_Click)));
        }

        private void btlExecFiltro_Click(object sender, EventArgs e)
        {
            //Pega item clicado
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            string filterName = string.Empty;

            //Pega nome do filtro selecionado
            if (clickedItem != null)
                filterName = clickedItem.Text;

            //Carrega do banco o filtro
            FilterExpression = objLibFiltro.GetByNome(filterName, typeof(Dados.Parceria).FullName, Session.Instance.Usuario.IdUsuario);


            //Se a expressao foi carregada com sucesso
            if (FilterExpression != null)
            {
                //Carrega form com as expressoes passadas como parametro
                var frmParam = new FormFilterParam(FilterExpression);
                frmParam.ShowDialog();


                if (frmParam.DialogResult != DialogResult.Cancel)
                {
                    var expressao = FilterExpression.BuildExpression();

                    objLista = objLib.Filter(expressao, frmParam.Parametros);
                    CarregaGrid(objLib.CarregaGrid(objLista));
                }
            }
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                //Abre tela de Edição de Filtro
                var frm = new FormFilterBase(typeof(Dados.Parceria));
                frm.ShowDialog();

                //Verifica se foi criado alguma expressã0
                if (frm.FilterExpression.Count > 0)
                {
                    FilterExpression = frm.FilterExpression;

                    var frmParam = new FormFilterParam(FilterExpression);
                    frmParam.ShowDialog();

                    //Constroi expressão
                    var expressao = FilterExpression.BuildExpression();

                    //Executa Filtros
                    ExecutarFiltro();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(this, ex);
            }
        }

        private void AplicaFiltroPadrao()
        {
            if (string.IsNullOrEmpty(Expressao))
                return;

            var filtros = objLibFiltro.GetByEntidade(typeof(Dados.Parceria).FullName, Session.Instance.Usuario.IdUsuario);
            var filtroPadrao = filtros.FirstOrDefault(a => a.Padrao);

            if (filtroPadrao != null)
            {
                //Carrega do banco o filtro
                FilterExpression = objLibFiltro.GetByNome(filtroPadrao.Nome, typeof(Dados.Parceria).FullName, Session.Instance.Usuario.IdUsuario);


                //Se a expressao foi carregada com sucesso
                if (FilterExpression != null)
                {
                    //Carrega form com as expressoes passadas como parametro
                    var frmParam = new FormFilterParam(FilterExpression);
                    frmParam.ShowDialog();


                    if (frmParam.DialogResult != DialogResult.Cancel)
                    {
                        Expressao = FilterExpression.BuildExpression();
                        Parametros = frmParam.Parametros;

                        ExecutarFiltro();
                    }
                }
            }
            else
            {
                objLista = new List<Dados.Parceria>();
            }
        }

        private void ExecutarFiltro()
        {
            objLista = objLib.Filter(Expressao, Parametros);
            CarregaGrid(objLib.CarregaGrid(objLista));
        }

        #endregion
    }
}
