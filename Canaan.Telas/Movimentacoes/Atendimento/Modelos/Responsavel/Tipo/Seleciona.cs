using System;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Telas.Base;
using ModeloResp = Canaan.Lib.ModeloResp;

namespace Canaan.Telas.Movimentacoes.Atendimento.Modelos.Responsavel.Tipo
{
    public partial class Seleciona : FormSelecao
    {
        //PROPRIEDADES
        public EnumModeloTipoResp? ResponsavelTipo { get; set; }

        public ModeloResp LibResponsavel 
        {
            get
            {
                return new ModeloResp();
            }
        }

        //CONSTRUTOR
        public Seleciona()
        {
            InitializeComponent();

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
                dataGrid.DataSource = LibResponsavel.GetValuesFromEnum(filtroTextBox.Text).ToList();
            }
            else
            {
                dataGrid.DataSource = LibResponsavel.GetValuesFromEnum().ToList();
            }
        }

        protected override void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                //carrega a propriedade
                int id = (int)dataGrid.SelectedRows[0].Cells[0].Value;
                ResponsavelTipo = LibResponsavel.GetEnumForKey(id);

                //fecha o form
                Close();
            }
            else
            {
                MessageBox.Show("Nenhum tipo de responsavel selecionado");
            }
        }
    }
}
