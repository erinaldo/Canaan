using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Lib.Utilitarios;
using Canaan.Telas.Base;
using Canaan.Telas.Properties;
using ContaCaixa = Canaan.Lib.ContaCaixa;
using FormaEntrada = Canaan.Dados.FormaEntrada;
using FormaPgto = Canaan.Dados.FormaPgto;
using Lancamento = Canaan.Lib.Lancamento;
using PessoaFisica = Canaan.Dados.PessoaFisica;
using PessoaJuridica = Canaan.Dados.PessoaJuridica;

namespace Canaan.Telas.Movimentacoes.Venda.Financeiro
{
    public partial class LancFinanceiro : FormVendaBase
    {
        #region PROPRIEDADES

        public Dados.Venda Venda { get; set; }

        public List<FormaPgto> FormasPagamento { get; set; }
        public Lib.FormaPgto LibFormaPagamento
        {
            get
            {
                return new Lib.FormaPgto();
            }
        }

        public List<FormaEntrada> FormasEntrada { get; set; }
        public Lib.FormaEntrada LibFormaEntrada
        {
            get
            {
                return new Lib.FormaEntrada();
            }
        }

        public Lancamento LibLancamento
        {
            get
            {
                return new Lancamento();
            }
        }

        public ContaCaixa LibContaCaixa
        {
            get
            {
                return new ContaCaixa();
            }
        }

        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }

        public Model Model { get; set; }

        public PessoaFisica PessoaFisica
        {
            get
            {
                if (Venda.CliFor != null)
                    return Venda.CliFor as PessoaFisica;

                return null;
            }
        }

        public PessoaJuridica PessoaJuridica
        {
            get
            {
                if (Venda.CliFor != null)
                    return Venda.CliFor as PessoaJuridica;

                return null;
            }
        }

        public Lib.Venda LibVenda
        {
            get
            {
                return new Lib.Venda();
            }
        }

        public int[] Dias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private Principal.Principal principal;

        #endregion

        #region CONTRUTOR

        public LancFinanceiro(Dados.Venda venda, Principal.Principal principal)
        {
            Venda = venda;
            this.principal = principal;

            InitializeComponent();
        }


        #endregion

        #region EVENTOS

        private void LancFinanceiro_Load(object sender, EventArgs e)
        {
            //Inicializa Listas
            InitModel();
            InitForm();
            InitBinding();
        }

        private void txtValorDesconto_Leave(object sender, EventArgs e)
        {
            try
            {
                Model.ValorDesconto = decimal.Parse(txtValorDesconto.Text);
                Model.PercentDesconto = Lancamento.CalculaPorcentagemOfValue(Model.ValorDesconto, Model.ValorBruto);

            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }

        }

        private void txtPorcDesconto_Leave(object sender, EventArgs e)
        {
            try
            {
                Model.PercentDesconto = decimal.Parse(txtPorcDesconto.Text);
                Model.ValorDesconto = Lancamento.CalculaValorOfPorcentagem(Model.ValorBruto, Model.PercentDesconto);
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void txtValAcrescimo_Leave(object sender, EventArgs e)
        {
            try
            {
                Model.ValorAcrescimo = decimal.Parse(txtValAcrescimo.Text);
                Model.PercentAcrescimo = Lancamento.CalculaPorcentagemOfValue(Model.ValorAcrescimo, Model.ValorBruto);
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void txtPorcAcrescimo_Leave(object sender, EventArgs e)
        {
            try
            {
                Model.PercentAcrescimo = decimal.Parse(txtPorcAcrescimo.Text);
                Model.ValorAcrescimo = Lancamento.CalculaValorOfPorcentagem(Model.ValorBruto, Model.PercentAcrescimo);
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void txtValorEntrada_Leave(object sender, EventArgs e)
        {
            try
            {
                Model.ValorEntrada = decimal.Parse(txtValorEntrada.Text);
                Model.PercentEntrada = Lancamento.CalculaPorcentagemOfValue(Model.ValorEntrada, Model.ValorLiquido);
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void txtPorcEntrada_Leave(object sender, EventArgs e)
        {
            try
            {
                Model.PercentEntrada = decimal.Parse(txtPorcEntrada.Text);
                Model.ValorEntrada = Lancamento.CalculaValorOfPorcentagem(Model.ValorLiquido, Model.PercentEntrada);
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void txtValorCrediario_Leave(object sender, EventArgs e)
        {
            try
            {
                Model.ValorCrediario = decimal.Parse(txtValorCrediario.Text);
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void btParcelas_Click(object sender, EventArgs e)
        {
            try
            {
                //Limpa Parcelas
                Model.Parcelas.Clear();

                if (Model.SelectedFormaPagamento.NumParcela - Model.SelectedFormaEntrada.Parcelas <= 0)
                {
                    MessageBoxUtilities.MessageWarning("Forma de Pagamento não pode ser menor ou Igual que Forma da Entrada");
                }
                else
                {
                    if (Model.SelectedFormaEntrada.Parcelas == 0 && Model.ValorEntrada > 0)
                    {
                        //Limpa campos de entrada
                        Model.ValorEntrada = 0;
                        Model.PercentEntrada = 0;
                    }
                    else if (Model.ValorEntrada != 0)
                    {
                        CriarParcelasDeEntrada();
                    }

                    CriarParcelas();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void cbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.SelectedFormaPagamento = cbFormaPagamento.SelectedItem as FormaPgto;
        }

        private void cbFormaEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.SelectedFormaEntrada = cbFormaEntrada.SelectedItem as FormaEntrada;
        }

        private void btSalvarFinanceiro_Click(object sender, EventArgs e)
        {
            try
            {

                //Limpa Lançamentos Existentes
                CleanLancamentosExistentes();

                //Salva lançamentos
                SalvarLancamentos();

                //Atualiza Venda
                AtualizaVenda();

                if (Venda.ValorLiquido != null)
                {
                    //Habilita Documentação
                    principal.lkDocumentacao.Enabled = true;
                }

                MessageBoxUtilities.MessageInfo("Lançamentos salvos com sucesso");

            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void datagrid_DoubleClick(object sender, EventArgs e)
        {

        }


        #endregion

        #region METODOS

        private void InitForm()
        {
            //Carrega Combos
            CarregaComboPagamento();
            CarregaComboEntrada();

            //Inicializa Combos
            cbFormaEntrada.SelectedValue = Venda.IdFormaEntrada ?? FormasEntrada.FirstOrDefault(a => a.Parcelas == 0).IdFormaEntrada;
            cbFormaPagamento.SelectedValue = Venda.IdFormaPgto ?? FormasPagamento.FirstOrDefault().IdFormaPgto;

            //Configura GRID
            datagrid.AutoGenerateColumns = false;

            var grid = datagrid.Columns["ValorOriginal"];
            if (grid != null)
                grid.DefaultCellStyle.Format = "c";


            dtInicioEntrada.EditValue = DateTime.Now;

            //Verifica se pode atualizar a venda
            CanUpdate();

            //datagrid.ClearSelection();
        }

        private void CanUpdate()
        {
            if (Comum.CanUpdateVenda(Venda))
            {
                toolstripActions.Enabled = true;
                gbEntrada.Enabled = true;
                gbFinanciamento.Enabled = true;
                datagrid.Enabled = true;
            }
            else
            {
                toolstripActions.Enabled = false;
                gbEntrada.Enabled = false;
                gbFinanciamento.Enabled = false;
                datagrid.Enabled = false;
            }
        }

        private void InitModel()
        {
            Model = new Model();

            Model.ValorBruto = Venda.ValorBruto.GetValueOrDefault();
            Model.ValorAcrescimo = Venda.ValorAcrescimo.GetValueOrDefault();
            Model.ValorDesconto = Venda.ValorDesconto.GetValueOrDefault();
            Model.ValorEntrada = Venda.ValorEntrada.GetValueOrDefault();
            Model.ValorLiquido = Venda.ValorLiquido.GetValueOrDefault();
            Model.ValorEntrada = Venda.ValorEntrada.GetValueOrDefault();
            Model.ValorCrediario = Venda.ValorCrediario.GetValueOrDefault();


            Model.PercentAcrescimo = Lancamento.CalculaPorcentagemOfValue(Model.ValorAcrescimo, Model.ValorBruto);
            Model.PercentDesconto = Lancamento.CalculaPorcentagemOfValue(Model.ValorDesconto, Model.ValorBruto);
            Model.PercentEntrada = Lancamento.CalculaPorcentagemOfValue(Model.ValorEntrada, Model.ValorLiquido);

            //Inicia lista de parcelas
            InicializaParcelas();

            FormasPagamento = LibFormaPagamento.GetByStatus(true).OrderBy(a => a.NumParcela).ToList();
            FormasEntrada = LibFormaEntrada.Get().OrderBy(a => a.Parcelas).ToList();
        }

        private void InicializaParcelas()
        {
            var result = LibLancamento.GetByPedido(Venda.IdPedido);
            Model.Parcelas = LibLancamento.GetModelParcelas(result);

            if (Model.Parcelas == null)
                Model.Parcelas = new BindingList<Lib.Model.Lancamento>();
        }

        private void CarregaComboEntrada()
        {
            cbFormaEntrada.DataSource = FormasEntrada;
            cbFormaEntrada.ValueMember = "IdFormaEntrada";
            cbFormaEntrada.DisplayMember = "Nome";
        }

        private void CarregaComboPagamento()
        {
            cbFormaPagamento.DataSource = FormasPagamento;
            cbFormaPagamento.ValueMember = "IdFormaPgto";
            cbFormaPagamento.DisplayMember = "Nome";
        }

        private void InitBinding()
        {
            //Valores
            txtValorBruto.DataBindings.Add(new Binding("Text", Model, "ValorBruto") { FormattingEnabled = true, FormatString = "#.00" });
            txtValorLiquido.DataBindings.Add(new Binding("Text", Model, "ValorLiquido") { FormattingEnabled = true, FormatString = "#.00" });
            txtValorRestante.DataBindings.Add(new Binding("Text", Model, "ValorRestante") { FormattingEnabled = true, FormatString = "#.00" });


            txtValorDesconto.DataBindings.Add(new Binding("Text", Model, "ValorDesconto") { FormattingEnabled = true, FormatString = "#.00" });
            txtValAcrescimo.DataBindings.Add(new Binding("Text", Model, "ValorAcrescimo") { FormattingEnabled = true, FormatString = "#.00" });

            txtValorEntrada.DataBindings.Add(new Binding("Text", Model, "ValorEntrada") { FormattingEnabled = true, FormatString = "#.00" });

            txtValorCrediario.DataBindings.Add(new Binding("Text", Model, "ValorCrediario") { FormattingEnabled = true, FormatString = "#.00" });
            

            //Porcentagens
            txtPorcDesconto.DataBindings.Add(new Binding("Text", Model, "PercentDesconto") { FormattingEnabled = true, FormatString = "#.00" });
            txtPorcAcrescimo.DataBindings.Add(new Binding("Text", Model, "PercentAcrescimo") { FormattingEnabled = true, FormatString = "#.00" });

            txtPorcEntrada.DataBindings.Add(new Binding("Text", Model, "PercentEntrada") { FormattingEnabled = true, FormatString = "#.00" });

            datagrid.DataBindings.Add(new Binding("DataSource", Model, "Parcelas"));

        }

        private void CriarParcelas()
        {
            //Subtrai numeros de partelas das parcelas da entrada
            decimal quantidadeParcelas = Model.SelectedFormaPagamento.NumParcela;

            if (Model.ValorEntrada != 0)
                quantidadeParcelas = quantidadeParcelas - Model.SelectedFormaEntrada.Parcelas;

            //Valor de Cada Parcela
            var valorParcelas = (Model.ValorRestante - Model.ValorCrediario) / quantidadeParcelas;

            //Declara variavel com data atual

            //Verifica se existe parcelamento de entrada
            var dataatual = dtInicioEntrada.EditValue as Nullable<DateTime>;

            //Pega o dia do vencimento
            int dia = dataatual.GetValueOrDefault().Day;

            //Cria um acumulador para somar os meses
            var dataAcumulador = DateTime.Today;

            for (int i = 0; i < quantidadeParcelas; i++)
            {

                if (Model.SelectedFormaEntrada.Parcelas != 0)
                    dataAcumulador = dataatual.GetValueOrDefault().AddMonths(i + (Model.SelectedFormaEntrada.Parcelas));
                else
                    dataAcumulador = dataatual.GetValueOrDefault().AddMonths(i + 1);

                Model.Parcelas.Add(
                    new Lib.Model.Lancamento
                    {
                        IdPedido = Venda.IdPedido,
                        IdCliFor = Venda.IdCliFor,
                        Cliente = Venda.CliFor.Nome,//Caso quantidade de parcelas for = 1 altera a classe contabil para entrada
                        ClasseContabil = quantidadeParcelas == 1 && Model.Parcelas.Count == 0 ? EnumClasseContabil.Entrada : EnumClasseContabil.Parcela,
                        DataEmissao = DateTime.Now,
                        //Caso quantidade de parcelas for = 1 altera o mes de vencimento para o mes atual
                        DataVencimento = quantidadeParcelas == 1 && Model.Parcelas.Count == 0 ? GetDia(dataAcumulador, dia).GetValueOrDefault().Date.AddMonths(-1) : GetDia(dataAcumulador, dia),
                        Filial = Venda.Filial.NomeFantasia,
                        IdFilial = Venda.IdFilial,
                        ValorOriginal = valorParcelas,
                        ValorLiquido = valorParcelas,
                        ValorAcrescimo = 0,
                        ValorDesconto = 0,
                        Tipo = EnumLancTipo.Receber,
                        //Caso quantidade de parcelas for = 1 altera a imagem para entrada
                        TipoParcela = quantidadeParcelas == 1 && Model.Parcelas.Count == 0 ? Resources.money2 : Resources.money_envelope
                    });
            }

        }

        private void CriarParcelasDeEntrada()
        {
            //Valores das Parcelas
            var valorParcelasEntrada = Model.ValorEntrada / Model.SelectedFormaEntrada.Parcelas;

            //Data atual
            var dataatual = dtInicioEntrada.EditValue as Nullable<DateTime>;

            //Dia em que vence as parcelas
            var dia = dataatual.GetValueOrDefault().Day;

            var dataAcumulador = DateTime.Today;

            for (int i = 0; i < Model.SelectedFormaEntrada.Parcelas; i++)
            {
                dataAcumulador = dataatual.GetValueOrDefault().AddMonths(i);

                Model.Parcelas.Add(
                 new Lib.Model.Lancamento
                 {
                     IdPedido = Venda.IdPedido,
                     IdCliFor = Venda.IdCliFor,
                     Cliente = Venda.CliFor.Nome,
                     ClasseContabil = EnumClasseContabil.Entrada,
                     DataEmissao = DateTime.Now,
                     DataVencimento = GetDia(dataAcumulador, dia),
                     Filial = Venda.Filial.NomeFantasia,
                     IdFilial = Venda.IdFilial,
                     ValorOriginal = valorParcelasEntrada,
                     ValorLiquido = valorParcelasEntrada,
                     ValorAcrescimo = 0,
                     ValorDesconto = 0,
                     Tipo = EnumLancTipo.Receber,
                     TipoParcela = Resources.money2
                 });
            }

        }

        private DateTime? GetDia(DateTime dataAtual, int dia)
        {

            if (dia == 30 || dia == 31)
                return new DateTime(dataAtual.Year, dataAtual.Month, Dias[dataAtual.Month - 1]);

            if (dataAtual.Month == 2 && dia == 29)
                return new DateTime(dataAtual.Year, dataAtual.Month, 28);

            return new DateTime(dataAtual.Year, dataAtual.Month, dia);
        }

        private void CleanLancamentosExistentes()
        {
            LibLancamento.Delete(LibLancamento.GetByPedido(Venda.IdPedido).Select(a => a.IdLancamento).ToArray(), EnumModulo.Venda);
        }

        private void AtualizaVenda()
        {
            Venda.IdFormaEntrada = Model.SelectedFormaEntrada.IdFormaEntrada;
            Venda.IdFormaPgto = Model.SelectedFormaPagamento.IdFormaPgto;
            Venda.ValorEntrada = Model.SelectedFormaPagamento.NumParcela == 1 ? Model.ValorLiquido : Model.ValorEntrada;
            Venda.DataVenda = DateTime.Now;
            Venda.DataEmissao = DateTime.Now;
            Venda.ValorAcrescimo = Model.ValorAcrescimo;
            Venda.ValorBruto = Model.ValorBruto;
            Venda.ValorDesconto = Model.ValorDesconto;
            Venda.ValorLiquido = Model.ValorLiquido;
            Venda.ValorCrediario = Model.ValorCrediario;

            //Atualiza Venda
            Venda = LibVenda.Update(Venda);

        }

        private void SalvarLancamentos()
        {
            foreach (var item in Model.Parcelas)
            {
                var lancamento = new Dados.Lancamento
                {
                    IdCliFor = item.IdCliFor,
                    IdPedido = item.IdPedido,
                    IdFilial = item.IdFilial,
                    IdContaCaixa = LibContaCaixa.GetPadraoFilial(item.IdFilial).IdConta,
                    ClasseContabil = item.ClasseContabil,
                    DataEmissao = item.DataEmissao,
                    DataVencimento = item.DataVencimento.GetValueOrDefault(),
                    ValorOriginal = item.ValorOriginal,
                    ValorLiquido = item.ValorLiquido,
                    ValorAcrescimo = item.ValorAcrescimo,
                    ValorDesconto = item.ValorDesconto,
                    Tipo = item.Tipo,
                    Status = EnumStatusLanc.AguardandoLiberacao,
                    IsEntrada = item.ClasseContabil == EnumClasseContabil.Entrada ? true : false
                };

                LibLancamento.Insert(lancamento);
            }
        }

        #endregion

        
    }

    public class Model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        /// <summary>
        /// Valores Readonly
        /// </summary>
        private decimal valorBruto;
        public decimal ValorBruto
        {
            get { return valorBruto; }
            set
            {
                valorBruto = value;
                NotifyPropertyChanged("ValorBrutoStr");
                NotifyPropertyChanged("ValorLiquidoStr");
                NotifyPropertyChanged("ValorRestanteStr");
            }
        }

        private decimal valorLiquido;
        public decimal ValorLiquido
        {
            get { return valorBruto - ValorDesconto + ValorAcrescimo; }
            set
            {
                valorLiquido = value;
                NotifyPropertyChanged("ValorLiquido");
                NotifyPropertyChanged("ValorBruto");
                NotifyPropertyChanged("ValorLiquido");
            }
        }

        private decimal valorRestante;
        public decimal ValorRestante
        {
            get { return ValorLiquido - ValorEntrada; }
            set
            {
                valorRestante = value;
                NotifyPropertyChanged("ValorRestante");
                NotifyPropertyChanged("ValorBruto");
                NotifyPropertyChanged("ValorLiquido");
            }
        }

        /// <summary>
        /// Valores Desconto e Acrescimo
        /// </summary>
        private decimal valorDesconto;
        public decimal ValorDesconto
        {
            get { return valorDesconto; }
            set
            {
                valorDesconto = value;
                NotifyPropertyChanged("ValorDesconto");
                NotifyPropertyChanged("ValorLiquido");
            }
        }

        private decimal valorAcrescimo;
        public decimal ValorAcrescimo
        {
            get { return valorAcrescimo; }
            set
            {
                valorAcrescimo = value;
                NotifyPropertyChanged("ValorDesconto");
                NotifyPropertyChanged("ValorLiquido");
            }
        }

        /// <summary>
        /// Valor Entrada
        /// </summary>
        private decimal valorEntrada;
        public decimal ValorEntrada
        {
            get { return valorEntrada; }
            set
            {
                valorEntrada = value;
                NotifyPropertyChanged("ValorEntrada");
                NotifyPropertyChanged("ValorRestante");
            }
        }

        private decimal percentEntrada;
        public decimal PercentEntrada
        {
            get { return percentEntrada; }
            set
            {
                percentEntrada = value;
                NotifyPropertyChanged("PercentEntrada");
            }
        }

        private decimal percentDesconto;
        public decimal PercentDesconto
        {
            get { return percentDesconto; }
            set
            {
                percentDesconto = value;
                NotifyPropertyChanged("PercentDesconto");
            }
        }

        private decimal percentAcrescimo;
        public decimal PercentAcrescimo
        {
            get
            {
                return percentAcrescimo;
            }
            set
            {
                percentAcrescimo = value;
                NotifyPropertyChanged("PercentAcrescimo");
            }
        }

        private decimal valorCrediario;
        public decimal ValorCrediario
        {
            get { return valorCrediario; }
            set
            {
                valorCrediario = value;
                NotifyPropertyChanged("ValorCrediario");
            }
        }

        private FormaPgto selectedFormaPagamento;
        public FormaPgto SelectedFormaPagamento
        {
            get { return selectedFormaPagamento; }
            set
            {
                selectedFormaPagamento = value;
                NotifyPropertyChanged("SelectedFormaPagamento");
            }
        }

        private FormaEntrada selectedFormaEntrada;
        public FormaEntrada SelectedFormaEntrada
        {
            get { return selectedFormaEntrada; }
            set
            {
                selectedFormaEntrada = value;
                NotifyPropertyChanged("SelectedFormaEntrada");
            }
        }

        public BindingList<Lib.Model.Lancamento> Parcelas { get; set; }

        private Color gridColor;

        public Color GridColor
        {
            get { return gridColor; }
            set
            {
                gridColor = value;
                NotifyPropertyChanged("GridColor");
            }
        }

    }
}
