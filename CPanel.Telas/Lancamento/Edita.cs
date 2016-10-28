using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPanel.Telas.Lancamento
{
    public partial class Edita : Form
    {
        #region PROPRIEDADES

        public CPanel.Dados.lancamentos Lancamento { get; set; }

        #endregion

        #region CONSTRUTORES

        public Edita(int idLancamento) 
        {
            //inicializa o lancamento
            this.Lancamento = Lib.Lancamento.GetById(idLancamento);

            //incializa o form
            InitializeComponent();
        }

        #endregion

        #region METODOS

        private void InitForm() 
        {
            CarregaInfoGeral();
            CarregaEntradas();
            CarregaRecebimento();
            CarregaVendas();
            CarregaResumo();
            CarregaOutras();
        }

        private void CarregaInfoGeral() 
        {
            this.labelNomeFilial.Text = this.Lancamento.filiais.nome;
            this.labelDataLancamento.Text = this.Lancamento.data.GetValueOrDefault().ToShortDateString();
            this.labelDiaSemana.Text = this.Lancamento.data.GetValueOrDefault().DayOfWeek.ToString();
        }

        private void CarregaEntradas() 
        {
            this.entradaDinheiro.EditValue = this.Lancamento.venda_entradas.GetValueOrDefault();
            this.entradaCartao.EditValue = this.Lancamento.venda_entrada_cartao.GetValueOrDefault();
            this.entradaDepositada.EditValue = this.Lancamento.venda_entrada_depositada.GetValueOrDefault();
            this.entradaTotal.EditValue = this.Lancamento.comissao.GetValueOrDefault();
        }

        private void CarregaRecebimento() 
        {
            this.recebimentoRM.EditValue = this.Lancamento.recebimento_rm.GetValueOrDefault();
            this.recebimentoCaixa.EditValue = this.Lancamento.recebimento_caixa.GetValueOrDefault();
            this.recebimentoCartao.EditValue = this.Lancamento.recebimento_cartao.GetValueOrDefault();
            this.recebimentoPherfil.EditValue = this.Lancamento.recebimento_pherfil.GetValueOrDefault();
            this.recebimentoTotal.EditValue = this.Lancamento.recebimento.GetValueOrDefault();
        }

        private void CarregaVendas() 
        {
            this.vendaDinheiro.EditValue = this.Lancamento.venda_vista.GetValueOrDefault();
            this.vendaCartao.EditValue = this.Lancamento.venda_vista_cartao.GetValueOrDefault();
            this.vendaPrazo.EditValue = this.Lancamento.venda_prazo.GetValueOrDefault();
            this.vendaDevolvida.EditValue = this.Lancamento.venda_devolvidas.GetValueOrDefault();
        }

        private void CarregaResumo() 
        {
            this.faturamentoBruto.EditValue = this.Lancamento.faturamento_bruto.GetValueOrDefault();
            this.faturamentoLiquido.EditValue = this.Lancamento.faturamento.GetValueOrDefault();
            this.fluxoCaixa.EditValue = this.Lancamento.fluxo_caixa.GetValueOrDefault();
        }

        private void CarregaOutras() 
        {
            this.quantFotografados.EditValue = this.Lancamento.fotografados.GetValueOrDefault();
            this.quantProgramadas.EditValue = this.Lancamento.condicional.GetValueOrDefault();
            this.quantVendas.EditValue = this.Lancamento.vendas.GetValueOrDefault();
            this.quantBrindes.EditValue = this.Lancamento.brindes.GetValueOrDefault();
            this.quantAtendidos.EditValue = this.Lancamento.atendidos.GetValueOrDefault();
            this.bloqueadoCheckBox.Checked = this.Lancamento.bloqueado.GetValueOrDefault();
        }

        private void CalculaSumario() 
        {
            CalculaEntradas();
            CalculaRecebimento();
            CalculaLiquido();
            CalculaBruto();
            CalculaFluxoCaixa();
        }

        private void CalculaEntradas() 
        {
            try
            {
                var entDinheiro = (decimal)this.entradaDinheiro.EditValue;
                //var entCartao = (decimal)this.entradaCartao.EditValue - ((decimal)this.entradaCartao.EditValue * 5 / 100);
                var entCartao = (decimal)this.entradaCartao.EditValue;
                var entDepos = (decimal)this.entradaDepositada.EditValue;
                var vendVista = (decimal)this.vendaDinheiro.EditValue;
                //var vendCartao = (decimal)this.vendaCartao.EditValue - ((decimal)this.vendaCartao.EditValue * 5 / 100);
                var vendCartao = (decimal)this.vendaCartao.EditValue;

                entradaTotal.EditValue = entDinheiro + entCartao + vendVista + vendCartao - entDepos;
            }
            catch (Exception)
            {
                entradaTotal.EditValue = 0;
            }
        }

        private void CalculaRecebimento() 
        {
            try
            {
                var recebRM = Decimal.Parse(this.recebimentoRM.EditValue.ToString());
                var recebCaixa = Decimal.Parse(this.recebimentoCaixa.EditValue.ToString());
                var recebPherfil = Decimal.Parse(this.recebimentoPherfil.EditValue.ToString());
                var recebCartao = Decimal.Parse(this.recebimentoCartao.EditValue.ToString()) - (Decimal.Parse(this.recebimentoCartao.EditValue.ToString()) * 5 / 100);

                recebimentoTotal.EditValue = recebRM + recebCaixa + recebPherfil + recebCartao;
            }
            catch (Exception)
            {
                recebimentoTotal.EditValue = 0;
            }
            
        }

        private void CalculaLiquido() 
        {
            try
            {
                var dinheiro = Decimal.Parse(this.vendaDinheiro.EditValue.ToString());
                var cartao = Decimal.Parse(this.vendaCartao.EditValue.ToString());
                var prazo = Decimal.Parse(this.vendaPrazo.EditValue.ToString());

                faturamentoLiquido.EditValue = dinheiro + cartao + prazo;
            }
            catch (Exception)
            {
                faturamentoLiquido.EditValue = 0;
            }
            
        }

        private void CalculaBruto() 
        {
            try
            {
                var dinheiro = Decimal.Parse(this.vendaDinheiro.EditValue.ToString());
                var cartao = Decimal.Parse(this.vendaCartao.EditValue.ToString());
                var prazo = Decimal.Parse(this.vendaPrazo.EditValue.ToString());
                var devolvida = Decimal.Parse(this.vendaDevolvida.EditValue.ToString());

                faturamentoBruto.EditValue = dinheiro + cartao + prazo + devolvida;
            }
            catch (Exception)
            {
                faturamentoBruto.EditValue = 0;
            }
        }

        private void CalculaFluxoCaixa() 
        {
            try
            {
                var entDinheiro = Decimal.Parse(this.entradaDinheiro.EditValue.ToString());
                var entCartao = Decimal.Parse(this.entradaCartao.EditValue.ToString()) - (Decimal.Parse(this.entradaCartao.EditValue.ToString()) * 5 / 100);
                var entDepos = Decimal.Parse(this.entradaDepositada.EditValue.ToString());
                var vendVista = Decimal.Parse(this.vendaDinheiro.EditValue.ToString());
                var vendCartao = Decimal.Parse(this.vendaCartao.EditValue.ToString()) - (Decimal.Parse(this.vendaCartao.EditValue.ToString()) * 5 / 100);
                var recebRM = Decimal.Parse(this.recebimentoRM.EditValue.ToString());
                var recebCaixa = Decimal.Parse(this.recebimentoCaixa.EditValue.ToString());
                var recebPherfil = Decimal.Parse(this.recebimentoPherfil.EditValue.ToString());
                var recebCartao = Decimal.Parse(this.recebimentoCartao.EditValue.ToString()) - (Decimal.Parse(this.recebimentoCartao.EditValue.ToString()) * 5 / 100);

                fluxoCaixa.EditValue = entDinheiro + entCartao + vendVista + vendCartao + recebRM + recebCaixa + recebPherfil + recebCartao - entDepos;
            }
            catch (Exception)
            {
                fluxoCaixa.EditValue = 0;
            }
        }

        private void UpdateLancamento() 
        {
            try
            {
                Lancamento.venda_entradas = (decimal)entradaDinheiro.EditValue;
                Lancamento.venda_entrada_cartao = (decimal)entradaCartao.EditValue;
                Lancamento.venda_entrada_depositada = (decimal)entradaDepositada.EditValue;
                Lancamento.venda_prazo = (decimal)vendaPrazo.EditValue;
                Lancamento.venda_vista = (decimal)vendaDinheiro.EditValue;
                Lancamento.venda_vista_cartao = (decimal)vendaCartao.EditValue;
                Lancamento.venda_devolvidas = (decimal)vendaDevolvida.EditValue;
                Lancamento.faturamento = (decimal)faturamentoLiquido.EditValue;
                Lancamento.faturamento_bruto = (decimal)faturamentoBruto.EditValue;
                Lancamento.comissao = (decimal)entradaTotal.EditValue;
                Lancamento.recebimento = (decimal)recebimentoTotal.EditValue;
                Lancamento.recebimento_rm = (decimal)recebimentoRM.EditValue;
                Lancamento.recebimento_caixa = (decimal)recebimentoCaixa.EditValue;
                Lancamento.recebimento_pherfil = (decimal)recebimentoPherfil.EditValue;
                Lancamento.recebimento_cartao = (decimal)recebimentoCartao.EditValue;
                Lancamento.fluxo_caixa = (decimal)fluxoCaixa.EditValue;
                Lancamento.fotografados = (int)quantFotografados.EditValue;
                Lancamento.condicional = (int)quantProgramadas.EditValue;
                Lancamento.vendas = (int)quantVendas.EditValue;
                Lancamento.brindes = (int)quantBrindes.EditValue;
                Lancamento.atendidos = (int)quantAtendidos.EditValue;
                Lancamento.bloqueado = bloqueadoCheckBox.Checked;

                Lib.Lancamento.Update(Lancamento);

                MessageBox.Show("Lançamento atualizado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void CarregaOnline() 
        {
            var caderno = Lib.Caderno.GetByPeriodo(Lancamento.id_filial.GetValueOrDefault(), Lancamento.data.GetValueOrDefault(), Lancamento.data.GetValueOrDefault()).FirstOrDefault();

            if (caderno != null) 
            {
                entradaDinheiro.EditValue = caderno.entrada_dinheiro;
                entradaCartao.EditValue = caderno.entrada_cartao;
                entradaDepositada.EditValue = caderno.entrada_depositada;

                vendaDinheiro.EditValue = caderno.venda_dinheiro;
                vendaCartao.EditValue = caderno.venda_cartao;
                vendaPrazo.EditValue = caderno.venda_prazo;
                vendaDevolvida.EditValue = caderno.devolvida_valor;
                //vendaDevolvida.EditValue = caderno.cadernos_vendas.Where(a => a.is_devolvida == true).Sum(a => a.venda_total);

                var vendas = caderno.cadernos_vendas;
                quantFotografados.EditValue = caderno.fotografados;
                quantProgramadas.EditValue = vendas.Where(a => a.is_programada == true && a.is_devolvida == false).Count();
                quantVendas.EditValue = vendas.Where(a => a.is_cortesia == false && a.is_devolvida == false && a.is_programada == false).Count();
                quantBrindes.EditValue = vendas.Where(a => a.is_cortesia == true && a.is_devolvida == false).Count();
                quantAtendidos.EditValue = vendas.Count;
            }
        }

        #endregion

        #region EVENTOS

        private void Edita_Load(object sender, EventArgs e)
        {
            InitForm();
        }       

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.UpdateLancamento();
        }

        private void btnCarregaOnline_Click(object sender, EventArgs e)
        {
            CarregaOnline();
            CalculaSumario();
        }

        private void entradaDinheiro_EditValueChanged(object sender, EventArgs e)
        {
            CalculaSumario();
        }

        private void entradaCartao_EditValueChanged(object sender, EventArgs e)
        {
            CalculaSumario();
        }

        private void entradaDepositada_EditValueChanged(object sender, EventArgs e)
        {
            CalculaSumario();
        }

        private void recebimentoRM_EditValueChanged(object sender, EventArgs e)
        {
            CalculaSumario();
        }

        private void recebimentoCaixa_EditValueChanged(object sender, EventArgs e)
        {
            CalculaSumario();
        }

        private void vendaDinheiro_EditValueChanged(object sender, EventArgs e)
        {
            CalculaSumario();
        }

        private void vendaCartao_EditValueChanged(object sender, EventArgs e)
        {
            CalculaSumario();
        }

        private void vendaPrazo_EditValueChanged(object sender, EventArgs e)
        {
            CalculaSumario();
        }

        private void vendaDevolvida_EditValueChanged(object sender, EventArgs e)
        {
            CalculaSumario();
        }

        private void recebimentoCartao_EditValueChanged(object sender, EventArgs e)
        {
            CalculaSumario();
        }

        private void recebimentoPherfil_EditValueChanged(object sender, EventArgs e)
        {
            CalculaSumario();
        }

        private void recebimentoTotal_EditValueChanged(object sender, EventArgs e)
        {
            CalculaSumario();
        }

        #endregion


    }
}
