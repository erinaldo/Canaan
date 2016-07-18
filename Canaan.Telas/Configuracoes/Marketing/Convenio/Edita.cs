using System;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Base;
using Canaan.Telas.Configuracoes.Marketing.Convenio.Tipo;

namespace Canaan.Telas.Configuracoes.Marketing.Convenio
{
    public partial class Edita : FormEdita
    {
        //
        //PROPRIEDADES
        public Lib.Convenio objLib { get; set; }
        private Dados.Convenio Convenio { get; set; }

        //
        //CONSTRUTORES
        public Edita()
        {
            //carrega as propriedades
            IsNovo = true;
            objLib = new Lib.Convenio();
            Convenio = new Dados.Convenio();


            //carrega os componentes
            InitializeComponent();
        }

        public Edita(int id)
        {
            //carrega as propriedades
            IsNovo = false;
            objLib = new Lib.Convenio();
            Convenio = objLib.GetById(id);

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
                Text = "Novo Convênio";
            else
                Text = "Editando Convênio: " + Convenio.Nome;
        }

        protected override void CarregaForm()
        {
            //carrega o data source
            convenioBindingSource.DataSource = Convenio;

            //inicializa para inclusao
            if (IsNovo)
            {
                tipoConvenioLabel.Text = "Selecione Tipo";
                isAtivoCheckBox.Checked = true;
            }
        }

        protected override void Incluir()
        {
            try
            {
                //para a edicao do datasource
                convenioBindingSource.EndEdit();

                //envia para metodo de update
                Convenio = objLib.Insert((Dados.Convenio)convenioBindingSource.Current);

                //mensagem de retorno
                MessageBoxUtilities.MessageInfo(string.Format("Registro '{0}' incluido com sucesso", Convenio.Nome));

                //marca para edicao
                IsNovo = false;
                SetTitle();

                //recarrega o datasource
                CarregaForm();
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBoxUtilities.MessageError(this ,ex);
            }
        }

        protected override void Editar()
        {
            try
            {
                //para a edicao do datasource
                convenioBindingSource.EndEdit();

                //envia para metodo de update
                Convenio = objLib.Update((Dados.Convenio)convenioBindingSource.Current);

                //mensagem de retorno
                MessageBoxUtilities.MessageInfo(string.Format("Registro '{0}' alterado com sucesso", Convenio.Nome));

                //marca para edicao
                IsNovo = false;
                SetTitle();

                //recarrega o datasource
                CarregaForm();
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBoxUtilities.MessageError(this,ex);
            }
        }

        private void tipoConvenioLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var seleciona = new Seleciona();
            seleciona.ShowDialog();

            if (seleciona.ConvenioTipo != null)
            {
                //atualiza item bindado
                tipoTextBox.Text = seleciona.ConvenioTipo.ToString();
                tipoConvenioLabel.Text = seleciona.ConvenioTipo.ToString();
            }
        }

        
    }
}
