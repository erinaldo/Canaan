using System;
using System.Windows.Forms;
using Canaan.Lib;

namespace Canaan.Telas.Movimentacoes.ConsultaOnline
{
    public partial class ConsultaOnline : Form
    {
        public Config LibConfig 
        { 
            get
            {
                return new Config();
            }
        }

        public ConsultaOnline()
        {
            InitializeComponent();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                var config = LibConfig.GetByFilial(Session.Instance.Contexto.IdFilial);
                var codigo = int.Parse(txtPacote.Text.Trim());
                //var result = LibEnvelope.GetByAtendimento(codigo, config.CServiceId.GetValueOrDefault()); //9924-9229
                //dataGrid.DataSource = result;

            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }            
        }

        private void ConsultaOnline_Load(object sender, EventArgs e)
        {
            dataGrid.AutoGenerateColumns = false;
        }
    }
}
