using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.CService.Telas.Integracao.Produto
{
    public partial class Lista : Form
    {
        #region PROPRIEDADES

        public List<Model> Produtos { get; set; }

        #endregion

        #region CONSTRUTORES

        public Lista()
        {
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Lista_Load(object sender, EventArgs e)
        {
            CarregaLista();
            CarregaGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AtualizaProdutos();
        }

        #endregion

        #region METODOS

        private void CarregaLista() 
        {
            this.Produtos = Model.Get();
        }

        private void CarregaGrid() 
        {
            produtosDataGridView.AutoGenerateColumns = false;
            produtosDataGridView.DataSource = this.Produtos;
        }

        private void AtualizaProdutos() 
        {
            try
            {
                foreach (var item in this.Produtos)
                {
                    //verifica se existem no banco de dados
                    var tamanho = Lib.Produto.GetByNome(item.Nome);

                    if (tamanho == null)
                        Insert(item);
                    else
                        Update(item);
                }

                MessageBox.Show("Produtos atualizados com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Insert(Model item)
        {
            var tamanho = new Dados.env_tamanhos();
            tamanho.nome = item.Nome;
            tamanho.valor = item.Valor;
            tamanho.prazo = 15;
            tamanho.exibir_studio = true;

            Lib.Produto.Insert(tamanho);
        }

        private void Update(Model item)
        {
            var tamanho = Lib.Produto.GetByNome(item.Nome);
            tamanho.nome = item.Nome;
            tamanho.valor = item.Valor;
            tamanho.exibir_studio = true;

            Lib.Produto.Update(tamanho);
        }

        #endregion
    }
}
