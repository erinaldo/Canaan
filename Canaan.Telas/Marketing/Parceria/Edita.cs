using System;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Base;
using Canaan.Telas.Marketing.Parceria.Convenio;

namespace Canaan.Telas.Marketing.Parceria
{
    public partial class Edita : FormEdita
    {

        //
        //PROPRIEDADES
        public Lib.Parceria objLib { get; set; }
        private Dados.Parceria Parceria { get; set; }
        public Dados.Convenio Convenio { get; set; }

        //
        //CONSTRUTORES
        public Edita()
        {
            //carrega as propriedades
            IsNovo = true;
            objLib = new Lib.Parceria();
            Parceria = new Dados.Parceria();


            //carrega os componentes
            InitializeComponent();
        }

        public Edita(int id)
        {
            //carrega as propriedades
            IsNovo = false;
            objLib = new Lib.Parceria();
            Parceria = objLib.GetById(id);

            //carrega os componentes
            InitializeComponent();
        }

        public Edita(Dados.Convenio convenio)
        {
            //carrega as propriedades
            IsNovo = true;
            objLib = new Lib.Parceria();
            Convenio = convenio;

            //Cria nova Parceria com um convenio Default
            Parceria = new Dados.Parceria
            {
                IdConvenio = convenio.IdConvenio
            };

            //carrega os componentes
            InitializeComponent();
        }

        //
        //EVENTOS
        private void Edita_Load(object sender, EventArgs e)
        {
            SetTitle();
            CarregaForm();
        }

        //
        //METODOS
        protected override void SetTitle()
        {
            if (IsNovo)
                Text = "Nova Parceria";
            else
                Text = "Editando Parceria: " + Parceria.Nome;
        }

        protected override void CarregaForm()
        {
            //Vincula filial do contexto à parceria
            Parceria.IdFilial = Session.Instance.Contexto.IdFilial;

            //carrega o data source
            parceriaBindingSource.DataSource = Parceria;

            //inicializa para inclusao
            if (IsNovo)
            {
                if (Convenio == null)
                    convenioLabel.Text = "Selecione Convênio";
                else
                    convenioLabel.Text = Convenio.Nome;

                isAtivoCheckBox.Checked = true;
            }
            else
            {
                //Seta conveio selecionado na edição para o link
                convenioLabel.Text = Parceria.Convenio.Nome;
            }
        }

        protected override void Incluir()
        {
            try
            {
                //para a edicao do datasource
                parceriaBindingSource.EndEdit();

                //envia para metodo de update
                Parceria = objLib.Insert((Dados.Parceria)parceriaBindingSource.Current);

                //mensagem de retorno
                MessageBoxUtilities.MessageInfo(string.Format("Registro '{0}' incluido com sucesso", Parceria.Nome));

                //marca para edicao
                IsNovo = false;
                SetTitle();

                //recarrega o datasource
                CarregaForm();
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBoxUtilities.MessageError(this, ex);
            }
        }

        protected override void Editar()
        {
            try
            {
                //para a edicao do datasource
                parceriaBindingSource.EndEdit();

                //envia para metodo de update
                Parceria = objLib.Update((Dados.Parceria)parceriaBindingSource.Current);

                //mensagem de retorno
                MessageBoxUtilities.MessageInfo(string.Format("Registro '{0}' alterado com sucesso", Parceria.Nome));

                //marca para edicao
                IsNovo = false;
                SetTitle();

                //recarrega o datasource
                CarregaForm();
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBoxUtilities.MessageError(this, ex);
            }
        }

        private void convenioLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var seleciona = new Seleciona();
            seleciona.ShowDialog();

            if (seleciona.Convenio != null)
            {
                //atualiza item bindado
                var source = (Dados.Parceria)parceriaBindingSource.Current;
                convenioLabel.Text = seleciona.Convenio.Nome;
                source.IdConvenio = seleciona.Convenio.IdConvenio;

                parceriaBindingSource.EndEdit();
                parceriaBindingSource.ResetBindings(true);
            }
        }

    }
}
