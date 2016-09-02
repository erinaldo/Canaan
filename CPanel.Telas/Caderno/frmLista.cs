using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPanel.Telas.Caderno
{
    public partial class frmLista : Form
    {
        #region PROPRIEDADES

        public Dados.filiais Filial { get; set; }
        public List<Dados.cadernos> Cadernos { get; set; }
        public bool IsAdmin { get; set; }

        #endregion

        #region CONTRUTORES

        public frmLista(bool p_IsAdmin)
        {
            //inicializa as propriedades
            this.IsAdmin = p_IsAdmin;
            
            //inicializa os componentes
            InitializeComponent();
        }

        public frmLista(bool p_IsAdmin, int p_IdFilial)
        {
            //inicializa as propriedades
            this.Filial = Lib.Filiais.GetById(p_IdFilial);
            this.IsAdmin = p_IsAdmin;

            //inicializa os componentes
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void frmLista_Load(object sender, EventArgs e)
        {
            //inicialia o formulario
            InitForm();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            SetCaderno();
            CarregaCaderno();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var frm = new frmNovo(Filial);
            frm.ShowDialog();
        }

        private void btnEdita_Click(object sender, EventArgs e)
        {
            EditaCaderno();
        }

        private void cadernosDataGridView_DoubleClick(object sender, EventArgs e)
        {
            EditaCaderno();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ImprimeCaderno();
        }

        private void btnLibera_Click(object sender, EventArgs e)
        {
            FechaCaderno();
        }

        #endregion

        #region METODOS

        private void InitForm() 
        {
            //carrega as filiais
            CarregaFiliais();

            //verifica se pode liberar o caderno
            if (IsAdmin)
                btnLibera.Visible = true;
            else
                btnLibera.Visible = false;

            //carrega o grid
            CarregaCaderno();
        }

        private void CarregaFiliais() 
        {
            //configura o combobox
            filiaisComboBox.DisplayMember = "nome";
            filiaisComboBox.ValueMember = "id_filial";

            //seta o datasource
            filiaisComboBox.DataSource = Lib.Filiais.Get();

            //verifica se tem filial selecionada
            if (Filial != null) 
            {
                filiaisComboBox.Enabled = false;
                filiaisComboBox.SelectedValue = Filial.id_filial;
            }
        }

        private void CarregaCaderno() 
        {
            cadernosDataGridView.DataSource = Lib.Caderno.GetGrid(Cadernos);
        }

        private void SetCaderno() 
        {
            Cadernos = Lib.Caderno.GetByPeriodo((int)filiaisComboBox.SelectedValue,
                                                inicioDateTimePicker.Value.Date,
                                                fimDateTimePicker.Value.Date);
        }

        private void EditaCaderno()
        {
            if (cadernosDataGridView.SelectedRows.Count > 0)
            {
                var id = (int)cadernosDataGridView.SelectedRows[0].Cells[0].Value;
                
                //var caderno = Lib.Caderno.GetById(id);
                //if (caderno.liberada_escrit == false)
                //{
                    
                //}
                //else 
                //{
                //    MessageBox.Show("O caderno deve estar aberto para ser alterado");
                //}

                var frm = new frmEdita(id, IsAdmin);
                frm.ShowDialog();

                SetCaderno();
                CarregaCaderno();
            }
            else
            {
                MessageBox.Show("Nenhum caderno selecionado");
            }
        }

        private void ImprimeCaderno()
        {
            if (cadernosDataGridView.SelectedRows.Count > 0)
            {
                var id = (int)cadernosDataGridView.SelectedRows[0].Cells[0].Value;
                var caderno = Lib.Caderno.GetById(id);

                var frm = new Relatorios.Caderno.frmReport(caderno);
                frm.ShowDialog();

                SetCaderno();
                CarregaCaderno();
            }
            else
            {
                MessageBox.Show("Nenhum caderno selecionado");
            }
        }

        private void FechaCaderno()
        {
            if (cadernosDataGridView.SelectedRows.Count > 0)
            {
                var id = (int)cadernosDataGridView.SelectedRows[0].Cells[0].Value;
                var caderno = Lib.Caderno.GetById(id);
                var confirm = string.Format("Tem certeza que deseja fechar o caderno do dia {0}", caderno.data.ToShortDateString());

                if (MessageBox.Show(confirm, "Confirmação", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    caderno.liberada_escrit = true;
                    caderno.liberada_gerente = true;

                    Lib.Caderno.Update(caderno);

                    SetCaderno();
                    CarregaCaderno();
                }
            }
            else
            {
                MessageBox.Show("Nenhum caderno selecionado");
            }
        }

        #endregion

        

        

    }
}
