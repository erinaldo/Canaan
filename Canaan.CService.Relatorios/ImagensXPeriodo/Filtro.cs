using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.CService.Relatorios.ImagensXPeriodo
{
    public partial class Filtro : Form
    {
        #region PROPRIEDADES

        public List<Dados.env_studios> Estudios { get; set; }
        public int Tipo { get; set; }

        #endregion

        #region CONSTRUTORES

        public Filtro()
        {
            this.Estudios = new List<Dados.env_studios>();
            this.Tipo = 0;

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Filtro_Load(object sender, EventArgs e)
        {
            CarregaComboEstudio();
            HabilitaCidade();
        }

        private void cidadeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaCidade();
        }

        private void gerarButton_Click(object sender, EventArgs e)
        {
            //define estudio selecionado
            SetEstudios();

            //carrega relatorio
            CarregaRelatorio();

        }

        private void tipoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tipoCheckBox.Checked)
                this.Tipo = 1;
            else
                this.Tipo = 0;
        }

        #endregion

        #region METODOS

        private void HabilitaCidade() 
        {
            if (cidadeCheckBox.Checked)
                cidadeComboBox.Enabled = true;
            else
                cidadeComboBox.Enabled = false;
        }

        private void CarregaComboEstudio() 
        {
            cidadeComboBox.ValueMember = "id_studio";
            cidadeComboBox.DisplayMember = "nome";
            cidadeComboBox.DataSource = Lib.Estudio.Get();
        }

        private void SetEstudios() 
        { 
            this.Estudios.Clear();

            if (cidadeCheckBox.Checked)
                this.Estudios.Add(Lib.Estudio.GetById((int)cidadeComboBox.SelectedValue));
            else
                this.Estudios = Lib.Estudio.Get();
        }

        private void CarregaRelatorio() 
        {
            var frm = new Viewer(this.Estudios, inicioDateTimePicker.Value.Date, fimDateTimePicker.Value.Date, this.Tipo);
            frm.Show();
        }

        #endregion

        

        
    }
}
