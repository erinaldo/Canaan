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
    public partial class frmLiberacao : Form
    {
        #region PROPRIEDADES

        public Dados.cadernos_vendas Venda { get; set; }
        public Dados.cadernos_liberacoes Liberacao { get; set; }
        public bool IsNovo { get; set; }
        public bool IsAdmin { get; set; }

        #endregion

        #region CONSTRUTORES

        public frmLiberacao(Dados.cadernos_vendas p_Venda, bool p_IsAdmin)
        {
            //inicializa propriedades
            Venda = p_Venda;
            Liberacao = new Dados.cadernos_liberacoes();
            IsNovo = true;
            IsAdmin = p_IsAdmin;

            //inicializa componentes
            InitializeComponent();
        }

        public frmLiberacao(Dados.cadernos_vendas p_Venda, int id, bool p_IsAdmin)
        {
            //inicializa propriedades
            Venda = p_Venda;
            Liberacao = Lib.CadernoLiberacao.GetById(id);
            IsNovo = false;
            IsAdmin = p_IsAdmin;

            //inicializa componentes
            InitializeComponent();
        }

        #endregion

        #region EVENTOS
        
        private void frmLiberacao_Load(object sender, EventArgs e)
        {
            CarregaTipos();
            InitForm();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void descontoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(descontoTextBox.Text))
            {
                descontoTextBox.Text = "0";
            }
        }
        #endregion

        #region METODOS

        private void CarregaTipos()
        {
            id_tipoComboBox.ValueMember = "id_tipo";
            id_tipoComboBox.DisplayMember = "descricao";
            id_tipoComboBox.DataSource = Lib.CadernoLiberacao.GetTipos();
        }

        private void InitForm()
        {
            if (this.IsNovo)
            {
                this.Text = "Nova liberação de venda " + Venda.cod_cmaster;

                //entradas
                id_tipoComboBox.SelectedIndex = 0;
                descontoTextBox.Text = "0";
                observacaoTextBox.Text = "";
            }
            else
            {
                this.Text = string.Format("Editando liberação da venda {0} - {1}", Venda.cod_cmaster, Venda.nome_cliente);

                id_tipoComboBox.SelectedValue = Liberacao.id_tipo;
                descontoTextBox.Text = Liberacao.desconto.ToString();
                observacaoTextBox.Text = Liberacao.observacao;
            }
        }

        private void Salvar()
        {
            //atualiza dados do objeto
            Liberacao.id_venda = Venda.id_venda;
            Liberacao.id_tipo = (int)id_tipoComboBox.SelectedValue;
            Liberacao.desconto = decimal.Parse(descontoTextBox.Text);
            Liberacao.observacao = observacaoTextBox.Text;

            //inclui ou atualiza venda
            try
            {
                if (this.IsNovo)
                {
                    //novo registro
                    Liberacao = Lib.CadernoLiberacao.Insert(Liberacao, IsAdmin);

                    //finaliza alteração
                    MessageBox.Show("Liberação da venda incluida com sucesso");

                    //fecha o form
                    this.Close();
                }
                else
                {
                    //edita registro
                    Liberacao = Lib.CadernoLiberacao.Update(Liberacao, IsAdmin);

                    //finaliza alteração
                    MessageBox.Show("Liberação da venda alterada com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion   
    }
}
