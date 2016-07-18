using System;
using System.Linq;
using Canaan.Lib;
using Canaan.Lib.Utilitarios;
using Canaan.Telas.Base;

namespace Canaan.Telas.Movimentacoes.Venda.Documentacao.Tipo
{
    public partial class Tipo : FormSelecao
    {
        #region PROPRIEDADES

        public TipoVenda TipoVenda { get; set; }

        #endregion

        #region CONSTRUTOR

        public Tipo()
        {
            InitializeComponent();
            ConfiguraForm();
        }

        #endregion

        #region EVENTOS

        private void Tipo_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        protected override void btnFiltro_Click(object sender, EventArgs e)
        {
            var result = UtilityEnum.GetItemsFromEnum<TipoVenda>()
                                    .Select(a => new { Codigo = (int)a.Key, Descricao = a.Value })
                                    .ToList();

            if (!string.IsNullOrEmpty(filtroTextBox.Text))
            {
                dataGrid.DataSource = result.Where(a => a.Descricao.Contains(filtroTextBox.Text.Trim())).ToList();
            }
            else
            {
                dataGrid.DataSource = result;
            }

        }

        protected override void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var result = int.Parse(dataGrid.SelectedRows[0].Cells[0].Value.ToString());

                if (result == 1)
                {
                    TipoVenda = TipoVenda.ComEntrada;
                }
                else if (result == 2)
                {
                    TipoVenda = TipoVenda.SemEntrada;
                }
                else if (result == 3)
                {
                    TipoVenda = TipoVenda.AVista;
                }
                else if (result == 4)
                {
                    TipoVenda = TipoVenda.Programada;
                }
                else if(result == 5)
                {
                    TipoVenda = TipoVenda.Cortesia;
                }
                else if (result == 6)
                {
                    TipoVenda = TipoVenda.ConcursoGaleria;
                }
                else
                {
                    TipoVenda = TipoVenda.Acompanhamento;
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }

            Close();
        }

        #endregion

        #region METODOS

        private void CarregaDados()
        {
            dataGrid.DataSource = UtilityEnum.GetItemsFromEnum<TipoVenda>()
                                                       .Select(a => new { Codigo = (int)a.Key, Descricao = a.Value })
                                                       .ToList();
        }

        private void ConfiguraForm()
        {
            filtroLabel.Text = "Tipo de Venda";
        }

        #endregion
    }
}
