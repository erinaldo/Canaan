using System;
using System.ComponentModel;
using System.Linq;
using Canaan.Lib;
using Canaan.Lib.Utilitarios;
using Canaan.Telas.Rotinas.Liberacao.Detalhes;
using Venda = Canaan.Lib.Model.Venda;

namespace Canaan.Telas.Rotinas.Liberacao
{
    public partial class Conferencia : LiberacaoBase
    {
        #region PROPRIEDADES

        public Venda SelectedVenda
        {
            get
            {
                return dataGrid.CurrentRow.DataBoundItem as Venda;
            }
        }

        public Venda SelectedVendaDevolvida
        {
            get
            {
                return datagridDevolvidas.CurrentRow.DataBoundItem as Venda;
            }
        }

        public BindingList<Dados.Venda> VendasConfirmacoes { get; set; }

        public BindingList<Dados.Venda> VendasDevolvidas { get; set; }

        public Lib.Venda LibVenda
        {
            get
            {
                return new Lib.Venda();
            }
        }

        #endregion

        #region CONSTRUTORES

        public Conferencia()
        {
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Liberacao_Load(object sender, EventArgs e)
        {
            //Tipos de Busca
            ddlTipoBusca.Items.Clear();
            ddlTipoBusca.Items.AddRange(Enum.GetNames(typeof(TipoBusca)));
            ddlTipoBusca.SelectedIndex = 0;

            InitModel();
            InitForm();
        }

        private void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            AbrirConferencia(SelectedVenda.Codigo);
        }

        private void AbrirConferencia(int idPedido)
        {
            try
            {
                var frm = new DetalhesLiberacao(idPedido, true);
                frm.ShowDialog();

                InitModel();
                InitForm();

            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                BuscaVendas();
                InitForm();
            }
            catch (Exception ex)
            {

                MessageBoxUtilities.MessageError(null, ex);
            }
        }
        #endregion

        #region METODOS

        private void InitModel()
        {
            VendasConfirmacoes = LibVenda.GetVendasConfirmacoes(Session.Contexto.IdFilial);

            var dtInicial = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            var dtFinal = DateTime.Today.AddDays(DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));

            VendasDevolvidas = LibVenda.GetVendasDevolvidasPeriodo(Session.Contexto.IdFilial, dtInicial, dtFinal);
        }

        private void InitForm()
        {
            dataGrid.AutoGenerateColumns = false;
            lbInfo.Text = string.Format("Foram encontradas {0} para serem confirmadas.", VendasConfirmacoes.Count);
            dataGrid.DataSource = LibVenda.CarregaGrid(VendasConfirmacoes.ToList());

            datagridDevolvidas.AutoGenerateColumns = false;
            lbVendasDevolvidas.Text = string.Format("Foram encontradas {0} vendas que foram devolvidas.", VendasDevolvidas.Count);
            datagridDevolvidas.DataSource = LibVenda.CarregaGrid(VendasDevolvidas.ToList());
        }

        private void BuscaVendas()
        {
            try
            {
                var value = ddlTipoBusca.SelectedItem.ToString();
                var selected = (TipoBusca)Enum.Parse(typeof(TipoBusca), value);

                switch (selected)
                {
                    case TipoBusca.Codigo:
                        VendasConfirmacoes = LibVenda.GetConferenciaLiberacaoFilialAndCod(Session.Contexto.IdFilial, int.Parse(tbBusca.Text.Trim()));
                        break;
                    case TipoBusca.Cpf:
                        VendasConfirmacoes = LibVenda.GetConferenciaLiberacaoByCpfAndFilial(tbBusca.Text.Trim(), Session.Contexto.IdFilial);
                        break;
                    case TipoBusca.Nome:
                        VendasConfirmacoes = LibVenda.GetConferenciaLiberacaoByNome(tbBusca.Text.Trim(), Session.Contexto.IdFilial);
                        break;
                    default:
                        VendasConfirmacoes = LibVenda.GetConferenciaLiberacaoByNome(tbBusca.Text.Trim(), Session.Contexto.IdFilial);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        #endregion

        private void datagridDevolvidas_DoubleClick(object sender, EventArgs e)
        {
            AbrirConferencia(SelectedVendaDevolvida.Codigo);
        }

        private void btFiltrarDevolvidas_Click(object sender, EventArgs e)
        {
            VendasDevolvidas = LibVenda.GetVendasDevolvidasPeriodo(Session.Contexto.IdFilial, dateTimeInicial.Value, dateTimeFinal.Value);
            InitForm();
        }
    }
}
