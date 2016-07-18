using System;
using System.ComponentModel;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using OrdemServico = Canaan.Lib.OrdemServico;
using VendaItem = Canaan.Dados.VendaItem;
using VendaItemOrdemServico = Canaan.Lib.VendaItemOrdemServico;

namespace Canaan.Telas.Movimentacoes.Venda.Envelope.Colecoes
{
    public partial class Edita : Form
    {
        public VendaItem VendaItem { get; set; }

        public ModelEditaVendaItem Model { get; set; }

        public Lib.VendaItem LibVendaItem
        {
            get
            {
                return new Lib.VendaItem();
            }
        }

        public OrdemServico LibOrdemServico
        {
            get
            {
                return new OrdemServico();
            }
        }

        public Lib.Servico LibServico
        {
            get
            {
                return new Lib.Servico();
            }
        }

        public VendaItemOrdemServico LibVendaItemOrdermServico
        {
            get
            {
                return new VendaItemOrdemServico();
            }
        }

        public Edita(VendaItem vendaItem)
        {
            VendaItem = vendaItem;
            InitializeComponent();
        }

        private void Edita_Load(object sender, EventArgs e)
        {
            InitModel();
            InitBinding();
        }

        private void InitBinding()
        {
            lbQuantidadeAtual.DataBindings.Add(new Binding("Text", Model, "Quantidade"));
            lbValorAtual.DataBindings.Add(new Binding("Text", Model, "ValorTotal"));
            lbValorUnitario.DataBindings.Add(new Binding("Text", Model, "ValorUnitario"));
            lkLabelProduto.DataBindings.Add(new Binding("Text", Model, "Produto"));
            txtQuantidade.DataBindings.Add(new Binding("Text", Model, "NovaQuantidade"));
            lbNovoValor.DataBindings.Add(new Binding("Text", Model, "NovoValor"));

        }

        private void InitModel()
        {
            Model = new ModelEditaVendaItem();

            Model.Quantidade = VendaItem.Quant.ToString();
            Model.ValorTotal = VendaItem.ValorTotal.GetValueOrDefault().ToString("c");
            Model.ValorUnitario = VendaItem.ValorUnitario.GetValueOrDefault().ToString("c");
            Model.ValorUnitarioNum = VendaItem.ValorUnitario.GetValueOrDefault();
            Model.Produto = VendaItem.Produto.Nome;
            Model.NovaQuantidade = VendaItem.Quant.ToString();
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            try
            {
                Model.NovaQuantidade = txtQuantidade.Text;
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
                txtQuantidade.ResetText();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Atualiza Item da Venda
                var quantidade = int.Parse(Model.NovaQuantidade);
                VendaItem.Quant = quantidade;
                VendaItem.ValorTotal = Model.ValorUnitarioNum * quantidade;

                if (!string.IsNullOrWhiteSpace(txtValorManual.Text))
                {
                    VendaItem.ValorUnitario = decimal.Parse(txtValorManual.Text);
                }

                LibVendaItem.Update(VendaItem);

                //Cria novas ordens de serviço
                ProcessaOrdensSevico();

                MessageBoxUtilities.MessageInfo("Item atualizado com sucesso");

                Close();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void ProcessaOrdensSevico()
        {
            var novaQuantidade = int.Parse(Model.NovaQuantidade);
            var antigaQuantidade = int.Parse(Model.Quantidade);

            if (novaQuantidade > antigaQuantidade)
            {
                var diferenca = novaQuantidade - antigaQuantidade;
                CriaOrdemServico(diferenca);
            }

        }

        private void CriaOrdemServico(int quantidade)
        {
            //Carrega serviços do produto
            var servicos = LibServico.GetByProduto(VendaItem.Produto.IdProduto);

            for (int i = 0; i < quantidade; i++)
            {
                foreach (var item in servicos)
                {

                    //Ordem de Serviço
                    var ordemServico = new Dados.OrdemServico
                    {
                        IdPedido = VendaItem.Venda.IdPedido,
                        IdServico = item.IdServico,
                        IdAlbum = null,
                        IdMoldura = null,
                        NomeAbertura = null,
                        Data = DateTime.Now,
                        DataPrevista = DateTime.Now.AddDays(item.Previsao),
                        Observacao = null,
                        Status = EnumStatusServico.AguardandoLiberacao
                    };

                    LibOrdemServico.Insert(ordemServico);


                    //Relação Orderm de Servico VendaItem

                    var relacao = new Dados.VendaItemOrdemServico
                    {
                        IdOrdemServico = ordemServico.IdOrdemServico,
                        IdItem = VendaItem.IdItem
                    };

                    LibVendaItemOrdermServico.Insert(relacao);
                }
            }
        }

        private void txtValorManual_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtValorManual.Text))
                {
                    Model.ValorUnitarioNum = decimal.Parse(txtValorManual.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
                txtQuantidade.ResetText();
            }
        }
    }

    public class ModelEditaVendaItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        private string valorUnitario;
        public string ValorUnitario
        {
            get { return valorUnitario; }
            set
            {
                valorUnitario = value;
                NotifyPropertyChanged("ValorUnitario");
            }
        }

        private string valorTotal;
        public string ValorTotal
        {
            get { return valorTotal; }
            set
            {
                valorTotal = value;
                NotifyPropertyChanged("ValorTotal");
            }
        }

        private string quantidade;
        public string Quantidade
        {
            get { return quantidade; }
            set
            {
                quantidade = value;
                NotifyPropertyChanged("Quantidade");
                NotifyPropertyChanged("NovoValor");
            }
        }

        private string produto;
        public string Produto
        {
            get { return produto; }
            set
            {
                produto = value;
                NotifyPropertyChanged("Produto");
            }
        }

        private string novaQuantidade;
        public string NovaQuantidade
        {
            get { return novaQuantidade; }
            set
            {
                novaQuantidade = value;
                NotifyPropertyChanged("NovaQuantidade");
                NotifyPropertyChanged("NovoValor");
            }
        }

        private decimal valorUnitarioNum;

        public decimal ValorUnitarioNum
        {
            get
            {
                return valorUnitarioNum;
            }
            set
            {
                valorUnitarioNum = value;
                NotifyPropertyChanged("NovoValor");
            }
        }

        public string NovoValor
        {
            get
            {

                if (string.IsNullOrEmpty(NovaQuantidade))
                    return string.Empty;

                return (int.Parse(NovaQuantidade) * ValorUnitarioNum).ToString("c");
            }
        }
    }
}

