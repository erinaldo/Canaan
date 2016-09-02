using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Relatorios.Financeiro.VendasQuitadas
{
    public partial class frmFiltro : Form
    {
        //PROPRIEDADES
        public Dados.GFILIAL Filial { get; set; }


        //CONSTRUTORES
        public frmFiltro()
        {
            InitializeComponent();
        }

        public frmFiltro(Dados.GFILIAL p_Filial)
        {
            Filial = p_Filial;
            InitializeComponent();
        }

        //EVENTOS
        private void frmFiltro_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            GeraRelatorio();
        }

        
        //METODOS
        private void InitForm() 
        {
            CarregaFiliais();
        }

        private void CarregaFiliais()
        {
            cbEstudio.DisplayMember = "NOMEFANTASIA";
            cbEstudio.ValueMember = "CGC";
            cbEstudio.DataSource = Lib.Filiais.Get();

            if (Filial != null) {
                cbEstudio.SelectedValue = Filial.CGC;
                cbEstudio.Enabled = false;
            }
        }

        private void GeraRelatorio()
        {
            var filial = Lib.Filiais.GetByCnpj(cbEstudio.SelectedValue.ToString());

            var frm = new frmReport(filial, dtInicio.Value.Date, dtFim.Value.Date);
            frm.ShowDialog();
        }

    }
}
