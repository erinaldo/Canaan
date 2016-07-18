using System;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Telas.Base;

namespace Canaan.Telas.Configuracoes.Marketing.Convenio.Tipo
{
    public partial class Seleciona : FormSelecao
    {
        //PROPRIEDADES
        public EnumConvenioTipo ? ConvenioTipo { get; set; }

        public Lib.Convenio LibConvenio { get; set; }

        //CONSTRUTOR
        public Seleciona()
        {            
            InitializeComponent();

            //Inicializa Propriedades
            LibConvenio = new Lib.Convenio();

            //Configura Form
            ConfiguraForm();
        }

        //METODOS
        private void ConfiguraForm()
        {
            filtroLabel.Text = "Selecione o Tipo";
        }

        //EVENTOS
        protected override void btnFiltro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filtroTextBox.Text))
            {
                dataGrid.DataSource = LibConvenio.GetValuesFromEnum(filtroTextBox.Text).ToList();
            }
            else
            {
                dataGrid.DataSource = LibConvenio.GetValuesFromEnum().ToList();
            }
        }

        protected override void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                //carrega a propriedade
                int id = (int)dataGrid.SelectedRows[0].Cells[0].Value;
                ConvenioTipo = LibConvenio.GetEnumForKey(id);

                //fecha o form
                Close();
            }
            else
            {
                MessageBox.Show("Nenhum tipo de convênio selecionada");
            }
        }
    }
}
