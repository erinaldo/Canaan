using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Financeiro.Lancamento
{
    public partial class RenegociacaoEdita : XtraForm
    {
        #region PROPRIEDADES

        public List<Dados.Lancamento> Lancamentos { get; set; }

        #endregion

        #region CONSTRUTORES

        public RenegociacaoEdita()
        {
            InitializeComponent();
        }

        #endregion


        #region EVENTOS

        private void RenegociacaoEdita_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region METODOS

        #endregion
    }
}
