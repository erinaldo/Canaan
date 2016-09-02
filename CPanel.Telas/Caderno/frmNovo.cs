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
    public partial class frmNovo : Form
    {
        #region PROPRIEDADES

        public Dados.filiais Filial { get; set; }
        public Dados.cadernos Caderno { get; set; }

        #endregion

        #region CONSTRUTORES

        public frmNovo(Dados.filiais p_Filial)
        {
            //inicializa propriedades
            Filial = p_Filial;

            //inicializa componentes
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void frmNovo_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            InsertCaderno();
            CarregaEdita();
        }

        #endregion

        #region METODOS

        private void InitForm()
        {
            //carrega as filiais
            CarregaFiliais();
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

        private void InsertCaderno() 
        {
            var confirmacao = string.Format("Tem certeza que deseja criar o caderno do dia {0} para a filial {1}", cadernoDateTimePicker.Value.ToShortDateString(), Filial.nome);
            if (MessageBox.Show(confirmacao, "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) 
            {
                try
                {
                    Caderno = Lib.Caderno.Insert(Filial, cadernoDateTimePicker.Value.Date);
                    MessageBox.Show("Caderno criado com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void CarregaEdita() 
        {
            if (Caderno != null) 
            { 
                
            }
        }

        #endregion

        
    }
}
