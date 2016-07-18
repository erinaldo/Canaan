using System;
using System.ComponentModel;
using System.Linq;
using Canaan.Lib;
using Canaan.Lib.Utilitarios;
using Canaan.Telas.Rotinas.Liberacao.Detalhes;
using Venda = Canaan.Lib.Model.Venda;

namespace Canaan.Telas.Rotinas.Liberacao
{
    public partial class Liberacao : LiberacaoBase
    {
        #region PROPRIEDADES

        public Venda SelectedVenda
        {
            get
            {
                return dataGrid.CurrentRow.DataBoundItem as Venda;
            }
        }

        public BindingList<Dados.Venda> VendasLiberacao { get; set; }

        public Lib.Venda LibVenda
        {
            get
            {
                return new Lib.Venda();
            }
        }


        #endregion

        #region CONSTRUTORES

        public Liberacao()
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
            var frm = new DetalhesLiberacao(SelectedVenda.Codigo, false);
            frm.ShowDialog();

            //Recarrega Dados
            InitModel();
            InitForm();
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
            VendasLiberacao = LibVenda.GetVendasLiberacaoFilial(Session.Contexto.IdFilial);
        }

        private void InitForm()
        {
            dataGrid.AutoGenerateColumns = false;
            lbInfo.Text = string.Format("Foram encontradas {0} vendas para serem liberadas.", VendasLiberacao.Count);
            dataGrid.DataSource = LibVenda.CarregaGrid(VendasLiberacao.ToList());

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
                        VendasLiberacao = LibVenda.GetVendasLiberacaoFilialAndCod(Session.Contexto.IdFilial, int.Parse(tbBusca.Text.Trim()));
                        break;
                    case TipoBusca.Cpf:
                        VendasLiberacao = LibVenda.GetVendasLiberacaoByCpfAndFilial(tbBusca.Text.Trim(), Session.Contexto.IdFilial);
                        break;
                    case TipoBusca.Nome:
                        VendasLiberacao = LibVenda.GetVendasLiberacaoByNome(tbBusca.Text.Trim(), Session.Contexto.IdFilial);
                        break;
                    default:
                        VendasLiberacao = LibVenda.GetVendasLiberacaoByNome(tbBusca.Text.Trim(), Session.Contexto.IdFilial);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        #endregion


    }
}
