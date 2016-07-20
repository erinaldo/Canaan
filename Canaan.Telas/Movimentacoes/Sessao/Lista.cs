using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Base;
using Canaan.Telas.Properties;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Movimentacoes.Sessao
{
    public partial class Lista : XtraForm
    {
        #region PROPRIEDADES


        /// <summary>
        /// 
        /// </summary>
        public Filtro objLibFiltro
        {
            get
            {
                return new Filtro();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public object[] Parametros { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public FilterExpressionCollection FilterExpression { get; set; }

        public List<Dados.Atendimento> Atendimentos { get; set; }

        public Lib.Sessao LibSessao
        {
            get
            {
                return new Lib.Sessao();
            }
        }
        public List<Dados.Sessao> Sessoes { get; set; }

        public Modelo LibModelo
        {
            get
            {
                return new Modelo();
            }
        }
        public List<Dados.Modelo> Modelos { get; set; }

        public Lib.Atendimento LibAtendimento
        {
            get
            {
                return new Lib.Atendimento();
            }
        }

        public Dados.Atendimento Atendimento { get; set; }

        public int SelectedAtend
        {
            get
            {
                if (gridAtendimento.SelectedRows.Count > 0)
                {
                    return int.Parse(gridAtendimento.SelectedRows[0].Cells[0].Value.ToString());
                }

                return 0;
            }
        }

        public int SelectedSessao
        {
            get
            {
                if (gridSessoes.SelectedRows.Count > 0)
                {
                    return int.Parse(gridSessoes.SelectedRows[0].Cells[0].Value.ToString());
                }

                return 0;
            }
        }

        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }

        public bool CloseWindow { get; set; }

        #endregion

        #region CONSTRUTOR

        public Lista()
        {
            InitializeComponent();

            try
            {
                //Aplicar Filtro Padrão
                //AplicaFiltroPadrao();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }

            
            Atendimentos = new List<Dados.Atendimento>();
        }

        #endregion

        #region METODOS

        private void CarregaLista()
        {
            if (Atendimentos != null)
                Atendimentos.Clear();

            var expressao = FilterExpression.BuildExpression();

            Atendimentos = LibAtendimento.Filter(expressao, Parametros);

            //CarregaGrid(LibCliFor.CarregaGridClientes(Clientes.GroupBy(a => a.CliFor).Select(a => a.FirstOrDefault()).ToList()));
            CarregaGrid(LibAtendimento.CarregaGrid(Atendimentos));
        }

        protected void CarregaFiltros()
        {
            // Carrega Lista de Filtros para a entidade atual
            var filtros = objLibFiltro.GetByEntidade(typeof(Dados.Atendimento).FullName, Session.Instance.Usuario.IdUsuario);

            //Adiciona filtros na lista 
            foreach (var item in filtros)
            {
                btnFiltros.DropDown.Items.Add(new ToolStripMenuItem(item.Nome, Resources.filter_16xLG, new EventHandler(btnExecFiltro_Click)));
            }

            //Adiciona o Criador de filtros
            btnFiltros.DropDownItems.Add(new ToolStripMenuItem("Novo Filtro", Resources.arrow_Sync_16xLG, new EventHandler(btnFiltros_Click)));
        }

        private void CarregaGrid(dynamic lista)
        {
            gridAtendimento.DataSource = lista;
        }

        private void SetTitle()
        {
            Text = "Lista de Sessões";
        }

        private void CarregaGridSessao()
        {
            Sessoes = LibSessao.GetByAtendimentoAndFilial(SelectedAtend, Session.Contexto.IdFilial);
            gridSessoes.DataSource = LibSessao.CarregaGrid(Sessoes);
        }

        private void CarregaGridModelo()
        {
            Modelos = LibModelo.GetBySessao(SelectedSessao);
            gridModelos.DataSource = LibModelo.CarregaGridSessaoWindow(Modelos);
        }

        private void EditaSessao()
        {
            if (gridSessoes.SelectedRows.Count > 0)
            {
                //abre tela de atualização
                Edita frm = new Edita(SelectedSessao);
                frm.ShowDialog();

                //atualiza lista e recarrega o grid
                CarregaGridSessao();
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
            }
        }

        private void DeletaSessao()
        {
            if (gridSessoes.SelectedRows.Count > 0)
            {
                if (MessageBoxUtilities.MessageQuestion("Tem certeza que deseja excluir este registro ?") == DialogResult.Yes)
                {
                    LibSessao.Delete(SelectedSessao);
                    CarregaGridSessao();

                    MessageBoxUtilities.MessageInfo("Registro removido com sucesso");
                }
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
            }
        }

        private void gridSessoes_SelectionChanged(object sender, EventArgs e)
        {
            CarregaGridModelo();
        }

        #endregion

        #region EVENTOS

        private void Lista_Load(object sender, EventArgs e)
        {

            //CarregaActions();            
            CarregaFiltros();
            ExecutarFiltro();
            SetTitle();

            //Desabilita a criação automatica de coluna para os grids de modelo e cliente
            gridModelos.AutoGenerateColumns = false;
            gridAtendimento.AutoGenerateColumns = false;

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
                FilterExpression = objLibFiltro.GetByNome(filterName, typeof(Dados.Atendimento).FullName, Session.Instance.Usuario.IdUsuario);


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
                var frm = new FormFilterBase(typeof(Dados.Atendimento));
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

        private void gridClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectedAtend > 0)
            {
                CarregaGridSessao();
                CarregaGridModelo();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridAtendimento.SelectedRows.Count <= 0)
                {
                    MessageBoxUtilities.MessageWarning("Nenhum Cliente selecionado");
                }
                else
                {
                    Atendimento = LibAtendimento.GetById(SelectedAtend);
                    var frmSessao = new Edita(Atendimento);
                    frmSessao.ShowDialog();

                    CarregaLista();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }

            #region Antigo

            //try
            //{
            //    if (gridClientes.SelectedRows.Count <= 0)
            //    {
            //        Lib.MessageBoxUtilities.MessageWarning("Nenhum Cliente selecionado");
            //    }
            //    else
            //    {
            //        //Carrega todos os atendimentos do cliente
            //        Atendimentos = LibAtendimento.GetByCliFor(SelectedCliFor);

            //        //Se tiver uma lista de atendimentos é necessario selecionar entre eles
            //        if (Atendimentos.Count > 1)
            //        {
            //            var frmAtendimento = new Atendimento.Lista(Atendimentos);
            //            frmAtendimento.ShowDialog();

            //            if (frmAtendimento.AtendimentoSelecionado != null)
            //                AtendimentoGrid = frmAtendimento.AtendimentoSelecionado;

            //            var frmSessao = new Edita(AtendimentoGrid);
            //            frmSessao.ShowDialog();
            //        }
            //        else
            //        {
            //            AtendimentoGrid = Atendimentos.FirstOrDefault();

            //            var frmSessao = new Edita(AtendimentoGrid);
            //            frmSessao.ShowDialog();
            //        }

            //        //Reecarrega Grid Sessoes
            //        CarregaGridSessao();
            //    }

            //}
            //catch (Exception ex)
            //{
            //Lib.MessageBoxUtilities.MessageError(null, ex);
            //}

            #endregion
        }

        private void gridSessoes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                EditaSessao();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                EditaSessao();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeletaSessao();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        #endregion

        #region CODIGO FILTRO

        public string Expressao { get; set; }

        private void ExecutarFiltro()
        {
            if (Atendimentos != null)
                Atendimentos.Clear();

            if (Expressao == null || Parametros == null)
                return;

            Atendimentos = LibAtendimento.Filter(Expressao, Parametros);

            //CarregaGrid(LibCliFor.CarregaGridClientes(Clientes.GroupBy(a => a.CliFor).Select(a => a.FirstOrDefault()).ToList()));
            CarregaGrid(LibAtendimento.CarregaGrid(Atendimentos));
        }

        private void AplicaFiltroPadrao()
        {
            var filtros = objLibFiltro.GetByEntidade(typeof(Dados.Atendimento).FullName, Session.Instance.Usuario.IdUsuario);
            var filtroPadrao = filtros.FirstOrDefault(a => a.Padrao);

            if (filtroPadrao != null)
            {
                //Carrega do banco o filtro
                FilterExpression = objLibFiltro.GetByNome(filtroPadrao.Nome, typeof(Dados.Atendimento).FullName, Session.Instance.Usuario.IdUsuario);


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
                Atendimentos = LibAtendimento.CarregaGrid(new List<Dados.Atendimento>());
            }
        }

        #endregion
    }
}
