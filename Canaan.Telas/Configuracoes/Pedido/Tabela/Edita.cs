using System;
using Canaan.Lib;
using Canaan.Telas.Base;

namespace Canaan.Telas.Configuracoes.Pedido.Tabela
{
    public partial class Edita : FormEdita
    {
        //
        //PROPRIEDADES
        public Lib.Tabela LibTabela 
        { 
            get
            {
                return new Lib.Tabela();
            }
        }
        private Dados.Tabela Tabela { get; set; }

        //
        //CONSTRUTORES
        public Edita()
        {
            //carrega as propriedades
            IsNovo = true;
            Tabela = new Dados.Tabela();

            //carrega os componentes
            InitializeComponent();
        }

        public Edita(int id)
        {
            //carrega as propriedades
            IsNovo = false;
            Tabela = LibTabela.GetById(id);

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
                Text = "Nova Tabela";
            else
                Text = "Editando Tabela: " + Tabela.Nome;
        }

        protected override void CarregaForm()
        {
            //carrega o data source
            tabelaBindingSource.DataSource = Tabela;

            //inicializa para inclusao
            if (IsNovo)
            {
                isAtivoCheckEdit.Checked = true;
            }
        }

        protected override void Incluir()
        {
            try
            {
                //para a edicao do datasource
                tabelaBindingSource.EndEdit();

                //envia para metodo de update
                Tabela = LibTabela.Insert((Dados.Tabela)tabelaBindingSource.Current);

                //mensagem de retorno
                MessageBoxUtilities.MessageInfo(string.Format("Registro '{0}' incluido com sucesso", Tabela.Nome));

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
                tabelaBindingSource.EndEdit();

                //envia para metodo de update
                Tabela = LibTabela.Update((Dados.Tabela)tabelaBindingSource.Current);

                //mensagem de retorno
                MessageBoxUtilities.MessageInfo(string.Format("Registro '{0}' alterado com sucesso", Tabela.Nome));

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
