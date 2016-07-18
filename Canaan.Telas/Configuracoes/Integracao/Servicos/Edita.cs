using System;
using Canaan.Lib;
using Canaan.Telas.Base;

namespace Canaan.Telas.Configuracoes.Integracao.Servicos
{
    public partial class Edita : FormEdita
    {
        //
        //PROPRIEDADES
        public Servico LibServico 
        { 
            get
            {
                return new Servico();
            }
        }
        private Dados.Servico Servico { get; set; }

        //
        //CONSTRUTORES
        public Edita()
        {
            //carrega as propriedades
            IsNovo = true;

            Servico = new Dados.Servico
            {
                IsAtivo = true,
                IsEnvio = true
            };

            //carrega os componentes
            InitializeComponent();
        }

        public Edita(int id)
        {
            //carrega as propriedades
            IsNovo = false;
            Servico = LibServico.GetById(id);

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
                Text = "Novo Serviço";
            else
                Text = "Editando Serviço: " + Servico.Nome;
        }

        protected override void CarregaForm()
        {
            //carrega o data source
            servicoBindingSource.DataSource = Servico;
        }

        protected override void Incluir()
        {
            try
            {
                //para a edicao do datasource
                servicoBindingSource.EndEdit();

                //envia para metodo de update
                Servico = LibServico.Insert((Dados.Servico)servicoBindingSource.Current);

                //mensagem de retorno
                MessageBoxUtilities.MessageInfo(string.Format("Registro '{0}' incluido com sucesso", Servico.Nome));

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
                servicoBindingSource.EndEdit();

                //envia para metodo de update
                Servico = LibServico.Update((Dados.Servico)servicoBindingSource.Current);

                //mensagem de retorno
                MessageBoxUtilities.MessageInfo(string.Format("Registro '{0}' alterado com sucesso", Servico.Nome));

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
    }
}
