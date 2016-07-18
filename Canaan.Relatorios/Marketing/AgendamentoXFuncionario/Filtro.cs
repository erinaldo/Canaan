using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Marketing.AgendamentoXFuncionario
{
    public partial class Filtro : Form
    {
        #region CONSTRUTORES

        public Filtro()
        {
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void btnReport_Click(object sender, EventArgs e)
        {
            var status = (Dados.EnumAgendamentoStatus)Enum.Parse(typeof(Dados.EnumAgendamentoStatus), cbStatus.SelectedValue.ToString());
            var isStatus = statusCheckBox.Checked;

            var frm = new Viewer(inicioDateTimePicker.Value.Date, fimDateTimePicker.Value.Date.AddHours(23), status, isStatus);
            frm.Show();
        }

        private void statusCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (statusCheckBox.Checked)
                cbStatus.Enabled = true;
            else
                cbStatus.Enabled = false;
        }

        private void Filtro_Load(object sender, EventArgs e)
        {
            cbStatus.Enabled = false;
            CarregaDados();
        }

        #endregion

        #region METODOS

        private void CarregaDados()
        {
            cbStatus.DataSource = cbStatus.DataSource = Enum.GetNames(typeof(Dados.EnumAgendamentoStatus));
        }

        #endregion
    }
}
