using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Base;
using Canaan.Telas.Properties;
using Venda = Canaan.Dados.Venda;

namespace Canaan.Telas.Rotinas.Liberacao
{
    public partial class LiberacaoBase : Form
    {
        #region PROPRIEDADES

        protected ToolStripSplitButton btnFiltrosBase { get; set; }

        public object[] Parametros { get; set; }

        public FilterExpressionCollection FilterExpression { get; set; }

        public Filtro objLibFiltro
        {
            get
            {
                return new Filtro();
            }
        }

        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }

        List<Venda> objLista;

        public Lib.Venda objLib
        {
            get
            {
                return new Lib.Venda();
            }
        }

        #endregion

        #region CONSTRUTOR

        public LiberacaoBase()
        {
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void btlExecFiltro_Click(object sender, EventArgs e)
        {
            //Pega item clicado
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            string filterName = string.Empty;

            //Pega nome do filtro selecionado
            if (clickedItem != null)
                filterName = clickedItem.Text;

            //Carrega do banco o filtro
            FilterExpression = objLibFiltro.GetByNome(filterName, typeof(Venda).FullName, Session.Instance.Usuario.IdUsuario);


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
                }
            }
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                //Abre tela de Edição de Filtro
                var frm = new FormFilterBase(typeof(Venda));
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
                    objLista = objLib.Filter(expressao, frmParam.Parametros);
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(this, ex);
            }
        }

        #endregion

        #region METODOS

        protected void CarregaFiltros(ToolStripSplitButton btFiltro)
        {
            btnFiltrosBase = btFiltro;

            // Carrega Lista de Filtros para a entidade atual
            var filtros = objLibFiltro.GetByEntidade(typeof(Venda).FullName, Session.Instance.Usuario.IdUsuario);

            //Adiciona filtros na lista 
            foreach (var item in filtros)
            {
                btnFiltrosBase.DropDown.Items.Add(new ToolStripMenuItem(item.Nome, Resources.filter_16xLG, new EventHandler(btlExecFiltro_Click)));
            }

            //Adiciona o Criador de filtros
            btnFiltrosBase.DropDownItems.Add(new ToolStripMenuItem("Novo Filtro", Resources.arrow_Sync_16xLG, new EventHandler(btnFiltros_Click)));
        }

        #endregion
    }
}
