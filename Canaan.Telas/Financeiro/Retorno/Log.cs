using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Canaan.Dados;

namespace Canaan.Telas.Financeiro.Retorno
{
    public partial class Log : Form
    {
        #region PROPRIEDADES

        public Lib.Retorno LibRetorno { get; set; }
        public List<RetornoLog> Lista { get; set; }

        #endregion

        #region CONSTRUTOR

        public Log(int pIdRetorno)
        {
            LibRetorno = new Lib.Retorno();
            Lista = LibRetorno.GetLogByRetorno(pIdRetorno);

            InitializeComponent();
        }

        #endregion


        #region EVENTOS

        private void Log_Load(object sender, EventArgs e)
        {
            Init();
        }

        #endregion

        #region METODOS

        private void Init() 
        {
            logDataGridView.AutoGenerateColumns = false;
            logDataGridView.DataSource = Lista;
        }

        #endregion
    }
}
