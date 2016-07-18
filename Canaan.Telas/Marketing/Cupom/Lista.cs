using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Base;
using Canaan.Telas.Properties;

namespace Canaan.Telas.Marketing.Cupom
{
    public partial class Lista : FormLista
    {
        //
        //PROPRIEDADES
        Lib.Cupom objLib;
        Lib.Parceria objLibParceria;

        List<Dados.Cupom> objLista;
        Dados.Parceria parceria;

        //
        //CONSTRUTORES
        public Lista()
        {
            //inicializa propriedades
            objLib = new Lib.Cupom();

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
            Text = "Listagem de Cupons";
        }

        public Lista(int idParceria)
        {

            //Inicializa bibliotecas
            objLib = new Lib.Cupom();
            objLibParceria = new Lib.Parceria();

            //inicializa propriedades
            parceria = objLibParceria.GetById(idParceria);
            objLista = objLib.GetByAtivo(parceria.IdParceria, true);

            //inicializa os componentes
            InitializeComponent();

            //inicializa o titulo
            Text = string.Format("Cupons da Parceria - {0}", parceria.Nome);
        }

        //
        //EVENTOS
        private void Lista_Load(object sender, EventArgs e)
        {
            //CarregaActions();
            CarregaFiltros();

            //Se lista for nula cria uma lista vazia
            if (objLista == null)
                objLista = new List<Dados.Cupom>();

            CarregaGrid(objLib.CarregaGrid(objLista));
        }

        //
        //METODOS
        protected override void CarregaNovo()
        {
            Edita frm;

            if (parceria == null)
                frm = new Edita();
            else
                frm = new Edita(parceria);

            //carrega tela de inclusao
            frm.ShowDialog();

            //Verifica se a lista de parcerias e de um convenio especifico
            if (parceria == null)
            {
                ExecutarFiltro();
            }
            else
            {
                objLista = objLib.GetByAtivo(parceria.IdParceria, true);
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
                if (parceria == null)
                {
                    //atualiza o grid
                    objLista = objLib.GetByAtivo(true);
                    CarregaGrid(objLib.CarregaGrid(objLista));
                }
                else
                {
                    objLista = objLib.GetByAtivo(parceria.IdParceria, true);
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
                        if (parceria == null)
                        {
                            //atualiza o grid
                            objLista = objLib.GetByAtivo(true);
                            CarregaGrid(objLib.CarregaGrid(objLista));
                        }
                        else
                        {
                            objLista = objLib.GetByAtivo(parceria.IdParceria, true);
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
        }


        #region CODIGO FILTRO

        public string Expressao { get; set; }

        protected override void CarregaFiltros()
        {
            // Carrega Lista de Filtros para a entidade atual
            var filtros = objLibFiltro.GetByEntidade(typeof(Dados.Cupom).FullName, Session.Instance.Usuario.IdUsuario);

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
            FilterExpression = objLibFiltro.GetByNome(filterName, typeof(Dados.Cupom).FullName, Session.Instance.Usuario.IdUsuario);


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
                var frm = new FormFilterBase(typeof(Dados.Cupom));
                frm.ShowDialog();

                //Verifica se foi criado alguma expressã0
                if (frm.FilterExpression.Count > 0)
                {
                    FilterExpression = frm.FilterExpression;

                    var frmParam = new FormFilterParam(FilterExpression);
                    frmParam.ShowDialog();

                    if (frmParam.DialogResult != DialogResult.Cancel)
                    {
                        //Constroi expressão
                        var expressao = FilterExpression.BuildExpression();

                        //Executa Filtros
                        objLista = objLib.Filter(expressao, frmParam.Parametros);
                        CarregaGrid(objLib.CarregaGrid(objLista));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(this, ex);
            }
        }

        private void AplicaFiltroPadrao()
        {
            if(string.IsNullOrEmpty(Expressao))
                return;

            var filtros = objLibFiltro.GetByEntidade(typeof(Dados.Cupom).FullName, Session.Instance.Usuario.IdUsuario);
            var filtroPadrao = filtros.FirstOrDefault(a => a.Padrao);

            if (filtroPadrao != null)
            {
                //Carrega do banco o filtro
                FilterExpression = objLibFiltro.GetByNome(filtroPadrao.Nome, typeof(Dados.Cupom).FullName, Session.Instance.Usuario.IdUsuario);


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
                objLista = new List<Dados.Cupom>();
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
