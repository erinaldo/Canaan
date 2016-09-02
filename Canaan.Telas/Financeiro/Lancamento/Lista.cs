using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Relatorios.Financeiro.Boleto.Itau;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Financeiro.Lancamento
{
    public partial class Lista : XtraForm
    {
        #region PROPRIEDADES

        public Lib.Lancamento LibLancamento { get; set; }
        public List<Dados.Lancamento> Lancamentos { get; set; }
        public Filtro FormFiltro { get; set; }

        #endregion

        #region CONSTRUTORES

        public Lista()
        {
            LibLancamento = new Lib.Lancamento();
            FormFiltro = new Filtro();

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Lista_Load(object sender, EventArgs e)
        {
            ExecutarFiltro();
            Sumario();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoLancamento();
        }

        private void btnEdita_Click(object sender, EventArgs e)
        {
            EditaLancamento();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeletaLancamentos();
        }

        private void btnBaixa_Click(object sender, EventArgs e)
        {
            BaixaLancamentos();
        }

        private void btnCancelaBaixa_Click(object sender, EventArgs e)
        {
            CancelaLancamentos();
        }

        private void btnEstornar_Click(object sender, EventArgs e)
        {
            EstornaLancamentos();
        }

        private void btnRenegociacaoEfetua_Click(object sender, EventArgs e)
        {

        }

        private void btnRenegociacaoCancela_Click(object sender, EventArgs e)
        {

        }

        private void btnRenegociacaoView_Click(object sender, EventArgs e)
        {

        }

        private void btnFaturasEmail_Click(object sender, EventArgs e)
        {
            EmailBoletos();
        }

        private void btnFaturasPrint_Click(object sender, EventArgs e)
        {
            PrintBoletos();
        }

        private void btnFaturasRecibo_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ExecutarFiltro();
        }

        private void lancDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lancDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void lancDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Sumario();
        }

        private void lancDataGridView_DoubleClick(object sender, EventArgs e)
        {
            EditaLancamento();
        }

        #endregion

        #region METODOS

        private void ExecutarFiltro() 
        {
            //abre a tela
            //var frm = new Filtro();
            FormFiltro.ShowDialog();

            //pega o resultado
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            FormFiltro.ExecutaConsulta();
            var result = FormFiltro.GetResult();

            if (result != null)
            {
                Lancamentos = result;

                var lancamentos = LibLancamento.CarregaGrid(Lancamentos);

                lancDataGridView.DataSource = lancamentos;
                Sumario();
            }
        }

        private void NovoLancamento() 
        {
            //abre tela de inclusao de lancamento
            Edita frm = new Edita();
            frm.ShowDialog();

            ExecutarFiltro();
            Sumario();

            //inclui lancamento na lista e recarrega o grid
            //if (frm.Lancamento != null)
            //{
            //    //Lancamentos.Add(frm.Lancamento);
            //    CarregaGrid();
            //}
        }

        private void EditaLancamento() 
        {
            if (lancDataGridView.SelectedRows.Count > 0)
            {
                //abre tela de atualização
                var id = (int)lancDataGridView.SelectedRows[0].Cells["Codigo"].Value;
                Edita frm = new Edita(id);
                frm.ShowDialog();

                //atualiza lista e recarrega o grid
                //var atual = Lancamentos.FirstOrDefault(a => a.IdLancamento == id);
                //atual = frm.Lancamento;

                CarregaGrid();
            }
            else 
            {
                MessageBox.Show("Nenhum registro selecionado");
            }
        }

        private void DeletaLancamentos() 
        {
            if (MessageBox.Show("Tem certeza que deseja excluir os lançamentos selecionados?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //pega lista de lancamentos selecionados
                var result = lancDataGridView.Rows.Cast<DataGridViewRow>().Where(a => a.Cells["CheckBoxLanc"].Value != null && a.Cells["CheckBoxLanc"].Value.ToString() == "True").ToList();

                if (result.Count > 0)
                {
                    //cria lista de items para excluir
                    List<int> ids = new List<int>();

                    //faz loop preenchendo a lista
                    foreach (var item in result)
                    {
                        ids.Add((int)item.Cells["Codigo"].Value);
                    }

                    //executa exclusão dos itens
                    try
                    {
                        LibLancamento.Delete(ids.ToArray());
                        MessageBox.Show("Registros excluidos com sucesso");

                    }
                    catch (Exception ex)
                    {
                        //mensagem de erro ao excluir
                        MessageBox.Show(ex.Message);
                    }

                    //remove da lista
                    foreach (var item in Lancamentos.Where(a => ids.Contains(a.IdLancamento)).ToList())
                    {
                        Lancamentos.Remove(item);
                    }

                    //recarrega a lista
                    CarregaGrid();
                }
                else
                {
                    MessageBox.Show("Nenhum lançamento selecionado");
                }
            }
        }

        private void CancelaLancamentos()
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar os lançamentos selecionados?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //pega lista de lancamentos selecionados
                var result = lancDataGridView.Rows.Cast<DataGridViewRow>().Where(a => a.Cells["CheckBoxLanc"].Value != null && a.Cells["CheckBoxLanc"].Value.ToString() == "True").ToList();

                if (result.Count > 0)
                {
                    //cria lista de items para excluir
                    List<int> ids = new List<int>();

                    //faz loop preenchendo a lista
                    foreach (var item in result)
                    {
                        ids.Add((int)item.Cells["Codigo"].Value);
                    }

                    //executa exclusão dos itens
                    try
                    {
                        LibLancamento.Cancela(ids.ToArray());
                        MessageBoxUtilities.MessageInfo("Registros cancelados com sucesso");
                    }
                    catch (Exception ex)
                    {
                        //mensagem de erro ao excluir
                        MessageBoxUtilities.MessageError(null, ex);
                    }

                    //recarrega a lista
                    //CarregaLista();
                    CarregaGrid();
                }
                else
                {
                    MessageBoxUtilities.MessageInfo("Nenhum lançamento selecionado");
                }
            }
        }

        private void EstornaLancamentos()
        {
            if (MessageBox.Show("Tem certeza que deseja estornar os lançamentos selecionados?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //pega lista de lancamentos selecionados
                var result = lancDataGridView.Rows.Cast<DataGridViewRow>().Where(a => a.Cells["CheckBoxLanc"].Value != null && a.Cells["CheckBoxLanc"].Value.ToString() == "True").ToList();

                if (result.Count > 0)
                {
                    //cria lista de items para excluir
                    List<int> ids = new List<int>();

                    //faz loop preenchendo a lista
                    foreach (var item in result)
                    {
                        ids.Add((int)item.Cells["Codigo"].Value);
                    }

                    //executa exclusão dos itens
                    try
                    {
                        LibLancamento.Estorna(ids.ToArray());
                        MessageBoxUtilities.MessageInfo("Registros estornados com sucesso");
                    }
                    catch (Exception ex)
                    {
                        //mensagem de erro ao excluir
                        MessageBoxUtilities.MessageError(null, ex);
                    }

                    //recarrega a lista
                    CarregaGrid();
                }
                else
                {
                    MessageBoxUtilities.MessageInfo("Nenhum lançamento selecionado");
                }
            }
        }

        private void BaixaLancamentos()
        {
            if (MessageBox.Show("Tem certeza que deseja baixar os lançamentos selecionados?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //pega lista de lancamentos selecionados
                var result = lancDataGridView.Rows.Cast<DataGridViewRow>().Where(a => a.Cells["CheckBoxLanc"].Value != null && a.Cells["CheckBoxLanc"].Value.ToString() == "True").ToList();

                if (result.Count > 0)
                {
                    //cria lista de items para excluir
                    List<int> ids = new List<int>();

                    //faz loop preenchendo a lista
                    foreach (var item in result)
                    {
                        var atual = Lancamentos.Where(a => a.IdLancamento == (int)item.Cells["Codigo"].Value).FirstOrDefault();

                        if (atual.Status == EnumStatusLanc.EmAberto) 
                        {
                            ids.Add((int)item.Cells["Codigo"].Value);
                        }
                    }

                    if (ids.Count > 0)
                    {
                        //executa baixa dos itens
                        var frm = new Baixa(ids.ToArray());
                        frm.ShowDialog();

                        //recarrega a lista
                        //CarregaLista();
                        CarregaGrid();
                    }
                    else 
                    {
                        MessageBoxUtilities.MessageInfo("Nenhum lançamento em aberto selecionado");
                    }
                }
                else
                {
                    MessageBoxUtilities.MessageInfo("Nenhum lançamento selecionado");
                }
            }
        }

        

        private void Sumario() 
        {
            //pega lista de lancamentos selecionados
            var result = lancDataGridView.Rows.Cast<DataGridViewRow>().Where(a => a.Cells["CheckBoxLanc"].Value != null && a.Cells["CheckBoxLanc"].Value.ToString() == "True").ToList();
            
            //inicializa variaveis
            int quant = 0;
            decimal val = 0;

            //conta quantidade de registros
            quant = result.Count;

            //totaliza o liquido
            foreach (var item in result)
            {
                val = val + Lancamentos.Where(a => a.IdLancamento == (int)item.Cells["Codigo"].Value).FirstOrDefault().ValorOriginal;
            }

            //atualiza dados da tela
            lancamentosValue.Text = quant.ToString();
            liquidoValue.Text = string.Format("{0:c}", val);
        }

        private void PrintBoletos()
        {
            if (MessageBox.Show("Tem certeza que deseja imprimir os lançamentos selecionados?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //pega lista de lancamentos selecionados
                var result = lancDataGridView.Rows.Cast<DataGridViewRow>().Where(a => a.Cells["CheckBoxLanc"].Value != null && a.Cells["CheckBoxLanc"].Value.ToString() == "True").ToList();

                if (result.Count > 0)
                {
                    //cria lista de items para excluir
                    List<int> ids = new List<int>();

                    //faz loop preenchendo a lista
                    foreach (var item in result)
                    {
                        ids.Add((int)item.Cells["Codigo"].Value);
                    }

                    //executa exclusão dos itens
                    try
                    {
                        var frm = new Viewer(ids.ToArray());
                        frm.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        //mensagem de erro ao excluir
                        MessageBoxUtilities.MessageError(null, ex);
                    }
                }
                else
                {
                    MessageBoxUtilities.MessageInfo("Nenhum lançamento selecionado");
                }
            }
        }

        private void EmailBoletos()
        {
            if (MessageBox.Show(@"Tem certeza que deseja enviar por email os lançamentos selecionados?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //pega lista de lancamentos selecionados
                var result = lancDataGridView.Rows.Cast<DataGridViewRow>().Where(a => a.Cells["CheckBoxLanc"].Value != null && a.Cells["CheckBoxLanc"].Value.ToString() == "True").ToList();

                if (result.Count > 0)
                {
                    //cria lista de items para excluir
                    List<int> ids = new List<int>();

                    //faz loop preenchendo a lista
                    foreach (var item in result)
                    {
                        ids.Add((int)item.Cells["Codigo"].Value);
                    }

                    //executa exclusão dos itens
                    try
                    {
                        var frm = new Email(Lancamentos.Where(a => ids.ToArray().Contains(a.IdLancamento)).ToList());
                        frm.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        //mensagem de erro ao excluir
                        MessageBoxUtilities.MessageError(null, ex);
                    }
                }
                else
                {
                    MessageBoxUtilities.MessageInfo("Nenhum lançamento selecionado");
                }
            }
        }

        #endregion            
    }
}
