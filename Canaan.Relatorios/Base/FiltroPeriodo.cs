using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Base
{
    public partial class FiltroPeriodo : Form
    {
        #region PROPRIEDADES

        public Lib.Session Session
        {
            get
            {
                return Lib.Session.Instance;
            }
        }
        public Dados.EnumRelatorioTipo TipoRelatorio { get; set; }
        
        #endregion


        #region CONSTRUTORES

        public FiltroPeriodo(Dados.EnumRelatorioTipo pTipoRelatorio)
        {
            TipoRelatorio = pTipoRelatorio;
            InitializeComponent();
        }

        public FiltroPeriodo(Dados.EnumRelatorioTipo pTipoRelatorio, string pLogo)
        {
            TipoRelatorio = pTipoRelatorio;
            
            InitializeComponent();
        }

        #endregion

        #region EVENTOS
        
        private void FiltroPeriodo_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            GeraRelatorio();
        }
        #endregion

        #region METODOS

        private void GeraRelatorio()
        {
            switch (TipoRelatorio)
            {
                case Canaan.Dados.EnumRelatorioTipo.Fotog_Periodo:
                    var frmFotogPer = new Relatorios.Fotografados.FotogPeriodo.Viewer(inicioDateTimePicker.Value.Date, fimDateTimePicker.Value.Date);
                    frmFotogPer.Show();
                    break;
                case Dados.EnumRelatorioTipo.Atendimento_AtendidoXPeriodo:
                    var frmAtendPer = new Relatorios.Atendimento.AtendidosPeriodo.Viewer(inicioDateTimePicker.Value.Date, fimDateTimePicker.Value.Date);
                    frmAtendPer.Show();
                    break;
                default:
                    break;
            }
        }

        #endregion

        
    }
}
