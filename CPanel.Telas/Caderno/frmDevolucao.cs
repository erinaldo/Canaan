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
    public partial class frmDevolucao : Form
    {
        #region PROPRIEDADES

        public Dados.cadernos_vendas Venda { get; set; }
        public Dados.cadernos_devolucoes Devolucao { get; set; }
        public bool IsNovo { get; set; }
        public bool IsAdmin { get; set; }

        #endregion

        #region CONSTRUTORES

        public frmDevolucao(Dados.cadernos_vendas p_Venda, bool p_IsAdmin)
        {
            //inicializa propriedades
            Venda = p_Venda;
            Devolucao = new Dados.cadernos_devolucoes();
            IsNovo = true;
            IsAdmin = p_IsAdmin;

            //inicializa componentes
            InitializeComponent();
        }

        public frmDevolucao(Dados.cadernos_vendas p_Venda, int id, bool p_IsAdmin)
        {
            //inicializa propriedades
            Venda = p_Venda;
            Devolucao = Lib.CadernoDevolucao.GetById(id);
            IsNovo = false;
            IsAdmin = p_IsAdmin;

            //inicializa componentes
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void frmDevolucao_Load(object sender, EventArgs e)
        {
            CarregaMotivos();
            InitForm();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        #endregion

        #region METODOS

        private void CarregaMotivos() 
        {
            id_motivoComboBox.ValueMember = "id_motivo";
            id_motivoComboBox.DisplayMember = "descricao";
            id_motivoComboBox.DataSource = Lib.CadernoDevolucao.GetMotivos();
        }

        private void InitForm()
        {
            if (this.IsNovo)
            {
                this.Text = "Nova devolução de venda " + Venda.cod_cmaster;

                //entradas
                id_motivoComboBox.SelectedIndex = 0;
                observacaoTextBox.Text = "";
            }
            else
            {
                this.Text = string.Format("Editando devolução da venda {0} - {1}",Venda.cod_cmaster, Venda.nome_cliente);

                id_motivoComboBox.SelectedValue = Devolucao.id_motivo;
                observacaoTextBox.Text = Devolucao.observacao;
            }
        }

        private void Salvar()
        {
            //atualiza dados do objeto
            Devolucao.id_venda = Venda.id_venda;
            Devolucao.id_motivo = (int)id_motivoComboBox.SelectedValue;
            Devolucao.observacao = observacaoTextBox.Text;

            //inclui ou atualiza venda
            try
            {
                if (this.IsNovo)
                {
                    //novo registro
                    Devolucao = Lib.CadernoDevolucao.Insert(Devolucao, IsAdmin);

                    //finaliza alteração
                    MessageBox.Show("Devolução da venda incluida com sucesso");

                    //fecha o form
                    this.Close();
                }
                else
                {
                    //edita registro
                    Devolucao = Lib.CadernoDevolucao.Update(Devolucao, IsAdmin);

                    //finaliza alteração
                    MessageBox.Show("Devolução da venda alterada com sucesso");
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
