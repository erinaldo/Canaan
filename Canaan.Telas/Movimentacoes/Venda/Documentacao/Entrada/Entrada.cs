using System;
using System.Windows.Forms;
using Canaan.Lib;

namespace Canaan.Telas.Movimentacoes.Venda.Documentacao.Entrada
{
    public partial class Entrada : Form
    {
        private readonly Dados.Venda _venda;
        private readonly ModelEntrada _model;

        public Entrada(Dados.Venda venda)
        {
            _venda = venda;
            _model = new ModelEntrada();
            InitializeComponent();
        }

        private void Entrada_Load(object sender, EventArgs e)
        {
            ConfiguraForm();
            ConfiguraModel();
            ConfiguraBinds();
        }

        private void ConfiguraForm()
        {
            lbEntradaTotal.Text = string.Empty;
            lbRestante.Text = string.Empty;
        }

        private void ConfiguraModel()
        {
            _model.TotalEntrada = _venda.ValorEntrada;
        }

        private void ConfiguraBinds()
        {
            lbEntradaTotal.DataBindings.Add(new Binding("Text", _model, "TotalEntrada") { FormattingEnabled = true, FormatString = "R$ #.00" });
            lbRestante.DataBindings.Add(new Binding("Text", _model, "Restante") { FormattingEnabled = true, FormatString = "R$ #.00" });
            txtEntradaCartao.DataBindings.Add(new Binding("Text", _model, "EntradaCartao") { FormattingEnabled = true, FormatString = "R$ #.00" });
            txtEntradaDinheiro.DataBindings.Add(new Binding("Text", _model, "EntradaDinheiro") { FormattingEnabled = true, FormatString = "R$ #.00" });
        }

        private void btSalvarEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaEntradas())
                {
                    _venda.EntradaCartao = _model.EntradaCartao;
                    _venda.EntradaDinheiro = _model.EntradaDinheiro;
                    Close();
                }
                else
                {
                    MessageBoxUtilities.MessageWarning(string.Format(@"A soma das entradas deve ser igual a {0}", _model.TotalEntrada.GetValueOrDefault().ToString("C")));
                }

            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        /// <summary>
        /// Valida Entradas
        /// </summary>
        /// <returns></returns>
        private bool ValidaEntradas()
        {
            return _model.Restante == 0;
        }
    }
}
