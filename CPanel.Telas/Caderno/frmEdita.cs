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
    public partial class frmEdita : Form
    {
        #region PROPIREDADES

        public Dados.cadernos Caderno { get; set; }
        public bool IsAdmin { get; set; }

        #endregion

        #region CONSTRUTORES

        public frmEdita(int idCaderno, bool p_isAdmin)
        {
            //inicializa propriedades
            Caderno = Lib.Caderno.GetById(idCaderno);
            IsAdmin = p_isAdmin;

            //inicializa componentes
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void frmEdita_Load(object sender, EventArgs e)
        {
            vendasDataGridView.AutoGenerateColumns = false;
            InitForm();
            CarregaInfo();
            CarregaVendas();
        }

        private void vendasDataGridView_DoubleClick(object sender, EventArgs e)
        {
            VendaEdit();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        
        private void btnVendaAdd_Click(object sender, EventArgs e)
        {
            VendaAdd();
        }

        private void btnVendaEdit_Click(object sender, EventArgs e)
        {
            VendaEdit();
        }

        private void btnVendaDelete_Click(object sender, EventArgs e)
        {
            VendaDelete();
        }

        
        private void btnAutorizacaoAdd_Click(object sender, EventArgs e)
        {
            LiberacaoEdit();
        }

        private void btnAutorizacaoEdit_Click(object sender, EventArgs e)
        {
            LiberacaoEdit();
        }

        private void btnAutorizacaoDelete_Click(object sender, EventArgs e)
        {
            LiberacaoDelete();
        }

        
        private void btnDevolucaoAdd_Click(object sender, EventArgs e)
        {
            DevolucaoEdit();
        }

        private void btnDevolucaoEdt_Click(object sender, EventArgs e)
        {
            DevolucaoEdit();
        }

        private void btnDevolucaoDelete_Click(object sender, EventArgs e)
        {
            DevolucaoDelete();
        }

        #endregion

        #region METODOS

        private void InitForm() 
        {
            if (this.IsAdmin == false) 
            {
                btnVendaAdd.Enabled = false;
            }
        }

        private void CarregaInfo() 
        {
            filialLabel.Text = string.Format("{0}", Lib.Filiais.GetById(Caderno.id_filial).nome);
            dataLabel.Text = string.Format("{0:d}", Caderno.data);

            entrada_dinheiroLabel.Text = string.Format("{0:c}", Caderno.entrada_dinheiro);
            entrada_cartaoLabel.Text = string.Format("{0:c}", Caderno.entrada_cartao);
            entrada_depositadaLabel.Text = string.Format("{0:c}", Caderno.entrada_depositada);
            entrada_totalLabel.Text = string.Format("{0:c}", Caderno.entrada_total);

            venda_prazoLabel.Text = string.Format("{0:c}", Caderno.venda_prazo);
            venda_dinheiroLabel.Text = string.Format("{0:c}", Caderno.venda_dinheiro);
            venda_cartaoLabel.Text = string.Format("{0:c}", Caderno.venda_cartao);
            venda_totalLabel.Text = string.Format("{0:c}", Caderno.venda_total);

            devolvidaLabel.Text = string.Format("{0} - {1:c}", Caderno.devolvida_qtde, Caderno.devolvida_valor);
            programadasLabel.Text = string.Format("{0} - {1:c}", Caderno.programada_qtde, Caderno.programada_valor);
            autorizadasLabel.Text = string.Format("{0} - {1:c}", Caderno.autorizada_qtde, Caderno.autorizada_valor);

            brindexTextBox.Text = string.Format("{0}", Caderno.brinde);
            fotografadosTextBox.Text = string.Format("{0}", Caderno.fotografados);
        }

        private void CarregaVendas() 
        {
            vendasDataGridView.DataSource = Lib.CadernoVendas.GetGrid(Lib.CadernoVendas.Get(Caderno.id_caderno));
            vendasDataGridView.ClearSelection();
            CustomizaGridVendas();
        }

        private void CustomizaGridVendas() 
        {
            foreach (DataGridViewRow row in vendasDataGridView.Rows)
            {
                if ((bool)row.Cells["Devolvida"].Value == true)
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                    row.DefaultCellStyle.Font = new Font(this.Font, FontStyle.Strikeout);
                }

                if ((bool)row.Cells["Autorizada"].Value == true)
                {
                    row.DefaultCellStyle.ForeColor = Color.Blue;
                }

                if ((bool)row.Cells["Programada"].Value == true)
                {
                    row.DefaultCellStyle.ForeColor = Color.Green;
                    row.DefaultCellStyle.Font = new Font(this.Font, FontStyle.Strikeout);
                }

                if ((bool)row.Cells["Cortesia"].Value == true)
                {
                    row.DefaultCellStyle.ForeColor = Color.DarkGoldenrod;                    
                }

                if ((bool) row.Cells["Acompanhamento"].Value == true)
                {
                    row.DefaultCellStyle.ForeColor = Color.DarkGray;
                }
            }
        }

        private void Salvar() 
        {
            //atualiza campos
            Caderno.brinde = int.Parse(brindexTextBox.Text);
            Caderno.fotografados = int.Parse(fotografadosTextBox.Text);

            //salva no banco de dados
            try
            {
                //atualiza caderno
                Caderno = Lib.Caderno.Update(Caderno);

                //atualiza dados da tela
                CarregaInfo();

                //mensagem de retorno
                MessageBox.Show("Caderno atualizado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VendaAdd()
        {
            //abre tela de venda
            var frm = new frmVenda(Caderno, IsAdmin);
            frm.ShowDialog();

            //atualiza caderno
            Caderno = Lib.Caderno.Update(Caderno);

            //atualiza dados da tela
            CarregaVendas();
            CarregaInfo();
        }

        private void VendaEdit() 
        {
            if (vendasDataGridView.SelectedRows.Count > 0) 
            {
                var id = (int)vendasDataGridView.SelectedRows[0].Cells[0].Value;

                //abre tela de venda
                var frm = new frmVenda(Caderno, id, IsAdmin);
                frm.ShowDialog();

                //atualiza caderno
                Caderno = Lib.Caderno.Update(Caderno);

                //atualiza dados da tela
                CarregaVendas();
                CarregaInfo();
            }
            else
            {
                MessageBox.Show("Nenhuma venda selecionada");
            }
        }

        private void VendaDelete()
        {
            if (vendasDataGridView.SelectedRows.Count > 0)
            {
                var id = (int)vendasDataGridView.SelectedRows[0].Cells[0].Value;
                var nome = vendasDataGridView.SelectedRows[0].Cells["Nome"].Value;
                var valor = vendasDataGridView.SelectedRows[0].Cells["Venda"].Value;
                var confirm = string.Format("Tem certeza que deseja excluir do caderno a venda de {0} no valor de {1} ?", nome, valor);

                //abre tela de venda
                try
                {
                    if (MessageBox.Show(confirm, "Confirmacao", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) 
                    {
                        //remove do banco 
                        Lib.CadernoVendas.Delete(id, IsAdmin);

                        //mensagem
                        MessageBox.Show("Venda removida do caderno com sucesso");

                        //atualiza caderno
                        Caderno = Lib.Caderno.Update(Caderno);

                        //atualiza dados da tela
                        CarregaVendas();
                        CarregaInfo();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Nenhuma venda selecionada");
            }
        }

        private void DevolucaoEdit()
        {
            if (vendasDataGridView.SelectedRows.Count > 0)
            {
                var id = (int)vendasDataGridView.SelectedRows[0].Cells[0].Value;
                var venda = Lib.CadernoVendas.GetById(id);
                var devolucao = Lib.CadernoDevolucao.GetByVenda(id);

                //verifica se ja tem registro de devolução
                if (devolucao == null)
                {
                    //abre tela de inclusao
                    var frm = new frmDevolucao(venda, IsAdmin);
                    frm.ShowDialog();
                }
                else 
                {
                    //abre tela de alteracao
                    var frm = new frmDevolucao(venda, devolucao.id_devolvida, IsAdmin);
                    frm.ShowDialog();
                }
                

                //atualiza caderno
                Caderno = Lib.Caderno.Update(Caderno);

                //atualiza dados da tela
                CarregaVendas();
                CarregaInfo();
            }
            else 
            {
                MessageBox.Show("Nenhuma venda selecionada para devolução");
            }
        }

        private void DevolucaoDelete()
        {
            if (vendasDataGridView.SelectedRows.Count > 0)
            {
                var id = (int)vendasDataGridView.SelectedRows[0].Cells[0].Value;
                var nome = vendasDataGridView.SelectedRows[0].Cells["Nome"].Value;
                var valor = vendasDataGridView.SelectedRows[0].Cells["Venda"].Value;
                var devolucao = Lib.CadernoDevolucao.GetByVenda(id);

                //verifica se ja tem registro de devolução
                if (devolucao == null)
                {
                    MessageBox.Show("A venda selecionada nao possui registro de devolução.");
                }
                else
                {
                    var confirm = string.Format("Tem certeza que deseja excluir a devolução da venda de {0} no valor de {1} ?", nome, valor);

                    if (MessageBox.Show(confirm, "Confirmacao", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        //remove do banco 
                        Lib.CadernoDevolucao.Delete(devolucao.id_devolvida, IsAdmin);

                        //mensagem
                        MessageBox.Show("Devolução de venda cancelada com sucesso");

                        //atualiza caderno
                        Caderno = Lib.Caderno.Update(Caderno);

                        //atualiza dados da tela
                        CarregaVendas();
                        CarregaInfo();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma venda selecionada");
            }
        }

        private void LiberacaoEdit()
        {
            if (vendasDataGridView.SelectedRows.Count > 0)
            {
                var id = (int)vendasDataGridView.SelectedRows[0].Cells[0].Value;
                var venda = Lib.CadernoVendas.GetById(id);
                var liberacao = Lib.CadernoLiberacao.GetByVenda(id);

                //verifica se ja tem registro de devolução
                if (liberacao == null)
                {
                    //abre tela de inclusao
                    var frm = new frmLiberacao(venda, IsAdmin);
                    frm.ShowDialog();
                }
                else
                {
                    //abre tela de alteracao
                    var frm = new frmLiberacao(venda, liberacao.id_liberacao, IsAdmin);
                    frm.ShowDialog();
                }


                //atualiza caderno
                Caderno = Lib.Caderno.Update(Caderno);

                //atualiza dados da tela
                CarregaVendas();
                CarregaInfo();
            }
            else
            {
                MessageBox.Show("Nenhuma venda selecionada para devolução");
            }
        }

        private void LiberacaoDelete()
        {
            if (vendasDataGridView.SelectedRows.Count > 0)
            {
                var id = (int)vendasDataGridView.SelectedRows[0].Cells[0].Value;
                var nome = vendasDataGridView.SelectedRows[0].Cells["Nome"].Value;
                var valor = vendasDataGridView.SelectedRows[0].Cells["Venda"].Value;
                var liberacao = Lib.CadernoLiberacao.GetByVenda(id);

                //verifica se ja tem registro de devolução
                if (liberacao == null)
                {
                    MessageBox.Show("A venda selecionada nao possui registro de autorização.");
                }
                else
                {
                    var confirm = string.Format("Tem certeza que deseja excluir a autorização da venda de {0} no valor de {1} ?", nome, valor);

                    if (MessageBox.Show(confirm, "Confirmacao", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        //remove do banco 
                        Lib.CadernoLiberacao.Delete(liberacao.id_liberacao, IsAdmin);

                        //mensagem
                        MessageBox.Show("Liberação de venda cancelada com sucesso");

                        //atualiza caderno
                        Caderno = Lib.Caderno.Update(Caderno);

                        //atualiza dados da tela
                        CarregaVendas();
                        CarregaInfo();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma venda selecionada");
            }
        }
        #endregion
    }
}
