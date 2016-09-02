using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPanel.Relatorios.Lancamentos
{
    public partial class Filtro : Form
    {
        #region PROPRIEDADES

        public CPanel.Dados.filiais Filial { get; set; }

        #endregion

        #region CONSTRUTORES

        public Filtro()
        {
            //inicializa o formulario
            InitializeComponent();

            //inicializa formaulario
            CarregaFiliais();
            CarregaMeses();
            InitForm();
        }

        public Filtro(int idFilial)
        {
            //inicializa propriedades
            this.Filial = CPanel.Lib.Filiais.GetById(idFilial);

            //inicializa tela
            InitializeComponent();

            //inicializa formulario
            CarregaFiliais();
            CarregaMeses();
            InitForm();
        }

        #endregion

        #region METODOS

        private void InitForm()
        {
            //verifica se tem filial selecionada
            if (Filial != null)
            {
                //seleciona filial
                filtroAno.Text = DateTime.Today.Year.ToString();
                filtroMes.SelectedValue = DateTime.Today.Month;

                checkBoxFilial.Checked = true;
                comboBoxFilial.SelectedValue = Filial.id_filial;

                //desabilita opcoes
                groupBoxFilial.Enabled = false;
            }
            else
            {
                //seleciona filial
                checkBoxFilial.Checked = false;
                
                //desabilita opcoes
                groupBoxFilial.Enabled = true;
            }
        }

        private void CarregaFiliais()
        {
            comboBoxFilial.ValueMember = "id_filial";
            comboBoxFilial.DisplayMember = "nome";
            comboBoxFilial.DataSource = CPanel.Lib.Filiais.Get();
        }

        private void CarregaMeses()
        {
            filtroMes.ValueMember = "mes";
            filtroMes.DisplayMember = "descricao";
            filtroMes.DataSource = CPanel.Lib.Meses.Get();
        }

        private void CarregaRelatorio() 
        {
            //codigo da filial
            var pFilial = checkBoxFilial.Checked == true ? (int)comboBoxFilial.SelectedValue : 0;
            var frm = new Viewer(pFilial, (int)filtroMes.SelectedValue, int.Parse(filtroAno.Text));
            frm.Show();
        }

        #endregion

        #region EVENTOS

        private void Filtro_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void checkBoxFilial_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFilial.Checked)
                comboBoxFilial.Enabled = true;
            else
                comboBoxFilial.Enabled = false;
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            CarregaRelatorio();
        }

        #endregion

    }
}
