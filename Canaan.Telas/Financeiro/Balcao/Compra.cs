using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Telas.Financeiro.Balcao
{
    public partial class Compra : Form
    {
        #region PROPRIEDADES

        public Dados.CliFor CliFor { get; set; }
        public Dados.Lancamento Lancamento { get; set; }

        #endregion

        #region CONSTRUTORES

        public Compra()
        {
            this.CliFor = new Lib.CliFor().GetByCpf("11111111111").FirstOrDefault(a => a.Tipo == Dados.EnumCliForTipo.Fornecedor);
            this.Lancamento = new Dados.Lancamento();

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Compra_Load(object sender, EventArgs e)
        {
            ConfiguraForm();
        }
        
        private void salvarButton_Click(object sender, EventArgs e)
        {
            SalvaRegistro();
        }

        #endregion

        #region METODOS

        private void ConfiguraForm()
        {
            lbFornecedor.Text = this.CliFor.Nome;
            dataDateTimePicker.Value = DateTime.Today;
            valorTextEdit.EditValue = 0.00M;
        }

        private void SalvaRegistro()
        {
            SalvaLancamento();
            BaixaLancamento();

            this.Close();
        }

        private void SalvaLancamento()
        {
            this.Lancamento.IdCliFor = this.CliFor.IdCliFor;
            this.Lancamento.IdFilial = Lib.Session.Instance.Contexto.IdFilial;
            this.Lancamento.IdContaCaixa = new Lib.ContaCaixa().GetPadraoFilial(this.Lancamento.IdFilial).IdContaCaixa;
            this.Lancamento.Tipo = Dados.EnumLancTipo.Pagar;
            this.Lancamento.Status = Dados.EnumStatusLanc.EmAberto;
            this.Lancamento.ClasseContabil = Dados.EnumClasseContabil.Parcela;
            this.Lancamento.DataEmissao = DateTime.Today;
            this.Lancamento.DataVencimento = dataDateTimePicker.Value.Date;
            this.Lancamento.ValorOriginal = decimal.Parse(valorTextEdit.EditValue.ToString());
            this.Lancamento.ValorLiquido = decimal.Parse(valorTextEdit.EditValue.ToString());
            this.Lancamento.IsEntrada = false;
            this.Lancamento.Descricao = descricaoTextbox.Text;

            this.Lancamento = new Lib.Lancamento().Insert(this.Lancamento);

            MessageBox.Show("Lancamento incluido com sucesso");
        }

        private void BaixaLancamento()
        {
            if (this.Lancamento.DataVencimento == DateTime.Today)
            {
                var ids = new List<int>();
                ids.Add(this.Lancamento.IdLancamento);

                var frm = new Telas.Financeiro.Lancamento.Baixa(ids.ToArray());
                frm.ShowDialog();
            }
        }


        #endregion  
    }
}
