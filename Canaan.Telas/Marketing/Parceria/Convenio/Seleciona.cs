using System;
using System.Linq;
using Canaan.Lib;
using Canaan.Telas.Base;

namespace Canaan.Telas.Marketing.Parceria.Convenio
{
    public partial class Seleciona : FormSelecao
    {
        //PROPRIEDADES
        public Dados.Convenio Convenio { get; set; }

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
            filtroLabel.Text = "Selecione o Convênio";
        }

        //EVENTOS
        protected override void btnFiltro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filtroTextBox.Text))
            {
                dataGrid.DataSource = LibConvenio.GetByAtivo(true)
                                                 .Select(a => new
                                                 {
                                                     Codigo = a.IdConvenio,
                                                     Nome = a.Nome,
                                                     Status = a.IsAtivo
                                                 })
                                                 .ToList();
            }
            else
            {
                dataGrid.DataSource = LibConvenio.GetByNome(filtroTextBox.Text, true).Select(a => new
                                                                                     {
                                                                                        Codigo = a.IdConvenio,
                                                                                        Nome = a.Nome,
                                                                                        Status = a.IsAtivo
                                                                                     })
                                                                                     .ToList();
            }
        }

        protected override void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                //carrega a propriedade
                Convenio = LibConvenio.GetById(Id);

                //fecha o form
                Close();
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum tipo de convênio selecionada");
            }
        }
    }
}
