using Canaan.Relatorios.ViewModel.Marketing.Agendamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Marketing.AgendamentoDia
{
    public partial class Filtro : Base.FiltroBase
    {
        #region PROPRIEDADES

        public Lib.TelemarketingStatus LibTelemarketingStatus
        {
            get
            {
                return new Lib.TelemarketingStatus();
            }
        }

        #endregion

        #region CONSTRUTOR

        public Filtro()
        {
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Filtro_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new AgendamentoViewModel
                {
                    DataInicial = dtIncial.Value.Date,
                    DataFinal = dtFinal.Value.Date.AddHours(23),
                    Status = (Dados.EnumAgendamentoStatus)Enum.Parse(typeof(Dados.EnumAgendamentoStatus), cbStatus.SelectedValue.ToString()),
                    IdFilial = Session.Contexto.IdFilial
                };

                var frmRelatorio = new Relatorios.Marketing.AgendamentoDia.Viewer(model);
                frmRelatorio.ShowDialog();

            }
            catch (Exception ex)
            {
                Lib.MessageBoxUtilities.MessageError(null, ex);
            }

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
