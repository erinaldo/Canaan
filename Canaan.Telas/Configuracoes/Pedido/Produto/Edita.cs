using System;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Base;

namespace Canaan.Telas.Configuracoes.Pedido.Produto
{
    public partial class Edita : FormEdita
    {
        public Lib.Tabela LibTabela
        {
            get
            {
                return new Lib.Tabela();
            }
        }

        public Dados.Tabela Tabela { get; set; }

        public Lib.Produto LibProduto
        {
            get
            {
                return new Lib.Produto();
            }
        }

        public Dados.Produto Produto { get; set; }

        public Edita(Dados.Produto produto)
        {
            Tabela = LibTabela.GetById(produto.IdTabela);
            Produto = produto;
            IsNovo = false;

            InitializeComponent();
        }

        public Edita(int idTabela)
        {
            Tabela = LibTabela.GetById(idTabela);
            Produto = new Dados.Produto
            {
                IdTabela = Tabela.IdTabela,
                Custo = 0,
                Valor = 0,
                IsAtivo = true
            };

            IsNovo = true;

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
                Text = "Novo Produto";
            else
                Text = "Editando Produto: " + Produto.Nome;
        }

        protected override void CarregaForm()
        {
            //carrega o data source
            produtoBindingSource.DataSource = Produto;

            ////inicializa para inclusao
            lkTableName.Text = Tabela.Nome;

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
                produtoBindingSource.EndEdit();

                //envia para metodo de update
                Produto = LibProduto.Insert((Dados.Produto)produtoBindingSource.Current);

                //mensagem de retorno
                MessageBoxUtilities.MessageInfo(string.Format("Registro '{0}' incluido com sucesso", Produto.Nome));

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
                produtoBindingSource.EndEdit();

                //envia para metodo de update
                Produto = LibProduto.Update((Dados.Produto)produtoBindingSource.Current);

                //mensagem de retorno
                MessageBoxUtilities.MessageInfo(string.Format("Registro '{0}' alterado com sucesso", Produto.Nome));

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

        private void tipoConvenioLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //var seleciona = new Tipo.Seleciona();
            //seleciona.ShowDialog();

            //if (seleciona.ConvenioTipo != null)
            //{
            //    //atualiza item bindado
            //    tipoTextBox.Text = seleciona.ConvenioTipo.ToString();
            //    tipoConvenioLabel.Text = seleciona.ConvenioTipo.ToString();
            //}
        }
    }
}
