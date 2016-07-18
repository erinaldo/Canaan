using System;
using System.Windows.Forms;
using Canaan.Lib;

namespace Canaan.Telas.Movimentacoes.Venda.Documentacao.Venda
{
    public partial class Venda : Form
    {
        private readonly Dados.Venda _venda;
        private readonly ModelVenda _model;

        public Venda(Dados.Venda venda)
        {
            _venda = venda;
            _model = new ModelVenda();
            InitializeComponent();
        }

        private void Venda_Load(object sender, EventArgs e)
        {
            ConfiguraForm();
            ConfiguraModel();
            ConfiguraBinds();
        }

        private void ConfiguraBinds()
        {
            lbValorTotal.DataBindings.Add(new Binding("Text", _model, "TotalVenda") { FormattingEnabled = true, FormatString = "R$ #.00" });
            lbRestante.DataBindings.Add(new Binding("Text", _model, "Restante") { FormattingEnabled = true, FormatString = "R$ #.00" });
            txtEntradaCartao.DataBindings.Add(new Binding("Text", _model, "VendaCartao") { FormattingEnabled = true, FormatString = "R$ #.00" });
            txtEntradaDinheiro.DataBindings.Add(new Binding("Text", _model, "VendaDinheiro") { FormattingEnabled = true, FormatString = "R$ #.00" });
        }

        private void ConfiguraModel()
        {
            _model.TotalVenda = _venda.ValorLiquido.GetValueOrDefault();
        }

        private void ConfiguraForm()
        {
            lbValorTotal.Text = string.Empty;
            lbRestante.Text = string.Empty;
        }

        private void btSalvarEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaEntradas())
                {
                    _venda.VendaCartao = _model.VendaCartao;
                    _venda.VendaDinheiro = _model.VendaDinheiro;
                    Close();
                }
                else
                {
                    MessageBoxUtilities.MessageWarning(string.Format(@"A soma dos valores deve ser igual a {0}", _model.TotalVenda.ToString("C")));
                }

            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private bool ValidaEntradas()
        {
            return _model.Restante == 0;
        }
    }
}
