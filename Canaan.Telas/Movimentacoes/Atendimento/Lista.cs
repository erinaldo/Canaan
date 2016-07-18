using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Relatorios.Fichas.Atendimento;
using Canaan.Telas.Base;
using Canaan.Telas.Properties;

namespace Canaan.Telas.Movimentacoes.Atendimento
{
    public partial class Lista : FormLista
    {
        #region PROPRIEDADES

        public Dados.Atendimento AtendimentoSelecionado { get; set; }

        public Lib.Atendimento LibAtendimento
        {
            get
            {
                return new Lib.Atendimento();
            }
        }

        public List<Dados.Atendimento> Atendimentos { get; set; }

        public CliFor LibCliente
        {
            get
            {
                return new CliFor();
            }
        }

        public Dados.CliFor Cliente { get; set; }

        public bool CloseWindow { get; set; }

        #endregion

        #region CONSTRUTORES

        //CONSTRUTORES
        public Lista()
        {
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
            Text = "Listagem de Atendimentos";
        }

        public Lista(List<Dados.Atendimento> atendimentos)
        {
            Atendimentos = atendimentos;
            CloseWindow = true;
            Cliente = LibCliente.GetById(atendimentos[0].IdCliFor);

            InitializeComponent();

            //inicializa o titulo
            Text = string.Format("Listagem de Atendimentos - {0}", Cliente.Nome);
        }

        //EVENTOS
        private void Lista_Load(object sender, EventArgs e)
        {
            CarregaActions();
            CarregaFiltros();
            ExecutarFiltro();

            //Atualiza Botões Form
            btnInsert.Visible = false;
            btnDelete.Visible = false;
            separatorNovo.Visible = false;
            separatorEdita.Visible = false;
        }

        #endregion

        #region EVENTOS

        private void btnFiliais_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                var frmParcerias = new Marketing.Parceria.Lista(Id);
                frmParcerias.ShowDialog();
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
            }
        }

        public override void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //Se Veio de uma tela onde apos a seleção o form precisa ser fechado
                if (CloseWindow)
                {
                    if (Id > 0)
                    {
                        AtendimentoSelecionado = LibAtendimento.GetById(Id);
                        Close();
                    }
                }
                else
                {
                    try
                    {
                        Editar();
                    }
                    catch (Exception ex)
                    {
                        MessageBoxUtilities.MessageError(null, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void btnFichaAtendimento_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                var frm = new Viewer(Id);
                frm.ShowDialog();
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
            }
        }

        #endregion

        #region METODOS

        //METODOS

        private void CarregaLista()
        {

        }

        protected override void CarregaNovo()
        {
            //carrega tela de inclusao
            //Edita frm = new Edita();
            //frm.ShowDialog();

            //atualiza o grid
            //objLista = objLib.GetByAtivo(true);
            //CarregaGrid(objLib.CarregaGrid(objLista));
        }

        protected override void CarregaEdita()
        {
            try
            {
                Editar();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void Editar()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                //carrega tela de inclusao
                Edita frm = new Edita(LibAtendimento.GetById(Id));
                frm.ShowDialog();

                //atualiza o grid
                ExecutarFiltro();
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
            }
        }

        protected override void ExecutaDelete()
        {
            //if (dataGrid.SelectedRows.Count > 0)
            //{
            //    var deleted = objLib.GetById(Id);

            //    //carrega tela de inclusao
            //    try
            //    {
            //        if (Lib.MessageBoxUtilities.MessageQuestion("Tem certeza que deseja excluir o registro '" + deleted.Nome + "' ?") == DialogResult.Yes)
            //        {
            //            //deleta objeto
            //            deleted = objLib.Delete(Id);
            //            Lib.MessageBoxUtilities.MessageInfo("Registro '" + deleted.Nome + "' excluido com sucesso");

            //            //atualiza o grid
            //            objLista = objLib.GetByAtivo(true);
            //            CarregaGrid(objLib.CarregaGrid(objLista));
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Lib.MessageBoxUtilities.MessageError(this, ex);
            //    }


            //}
            //else
            //{
            //    Lib.MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
            //}
        }

        protected override void CarregaActions()
        {
            btnActions.DropDownItems.Add(new ToolStripMenuItem("Ficha de Atendimento", Resources.RSReport_16xLG, new EventHandler(btnFichaAtendimento_Click)));
        }


        #endregion

        #region CODIGO FILTRO

        public string Expressao { get; set; }

        protected override void CarregaFiltros()
        {
            // Carrega Lista de Filtros para a entidade atual
            var filtros = objLibFiltro.GetByEntidade(typeof(Dados.Atendimento).FullName, Session.Instance.Usuario.IdUsuario);

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
            FilterExpression = objLibFiltro.GetByNome(filterName, typeof(Dados.Atendimento).FullName, Session.Instance.Usuario.IdUsuario);


            //Se a expressao foi carregada com sucesso
            if (FilterExpression != null)
            {
                //Carrega form com as expressoes passadas como parametro
                var frmParam = new FormFilterParam(FilterExpression);
                frmParam.ShowDialog();


                if (frmParam.DialogResult != DialogResult.Cancel)
                {
                    var expressao = FilterExpression.BuildExpression();

                    Atendimentos = LibAtendimento.Filter(expressao, frmParam.Parametros);
                    CarregaGrid(LibAtendimento.CarregaGrid(Atendimentos));
                }
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
                    frmParam.ShowDialog();


                    if (frmParam.DialogResult != DialogResult.Cancel)
                    {
                        //Constroi expressão
                        var expressao = FilterExpression.BuildExpression();

                        //Executa Filtros
                        Atendimentos = LibAtendimento.Filter(expressao, frmParam.Parametros);
                        CarregaGrid(LibAtendimento.CarregaGrid(Atendimentos));
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

        private void ExecutarFiltro()
        {
            if (CloseWindow)
            {
                //Carrega atendimentos passados como paramentro
                CarregaGrid(LibAtendimento.CarregaGrid(Atendimentos));
            }
            else
            {
                if (Expressao != null)
                {
                    Atendimentos = LibAtendimento.Filter(Expressao, Parametros);
                    CarregaGrid(LibAtendimento.CarregaGrid(Atendimentos));
                }
            }
        }

        #endregion
    }
}
