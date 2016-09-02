using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Telas.Ferramentas.Spc
{
    public partial class Filtro : Form
    {
        #region PROPRIEDADES

        public ModelFiltro objFiltro { get; set; }

        #endregion

        #region CONSTRUTORES

        public Filtro()
        {
            InitializeComponent();
        }

        #endregion
        
        #region EVENTOS

        private void Filtro_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            CarregaFiltro();
            this.Close();
        }

        #endregion

        #region METODOS

        private void InitForm() 
        {
            CarregaFiliais();
        }

        private void CarregaFiliais()
        {
            cbFilial.DisplayMember = "nome";
            cbFilial.ValueMember = "id_filial";
            cbFilial.DataSource = CPanel.Lib.Filiais.GetAll();
        }

        private void CarregaFiltro() 
        {
            objFiltro = new ModelFiltro();
            objFiltro.Filial = CPanel.Lib.Filiais.GetById(int.Parse(cbFilial.SelectedValue.ToString()));
            objFiltro.DataInicio = dtInicio.Value;
            objFiltro.DataFim = dtFim.Value;

            if (rbRegistrar.Checked)
                objFiltro.Tipo = TipoAcao.Registro;
            else
                objFiltro.Tipo = TipoAcao.Reabilitacao;
        }

        #endregion

    }
}
