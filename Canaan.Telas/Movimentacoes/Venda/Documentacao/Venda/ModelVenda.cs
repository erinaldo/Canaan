using System.ComponentModel;

namespace Canaan.Telas.Movimentacoes.Venda.Documentacao.Venda
{
    public class ModelVenda : INotifyPropertyChanged
    {
        private decimal _totalVenda;
        private decimal _vendaDinheiro;
        private decimal _vendaCartao;

        public decimal TotalVenda
        {
            get { return _totalVenda; }
            set
            {
                _totalVenda = value;
                NotifyPropertyChanged("TotalVenda");
                NotifyPropertyChanged("Restante");
            }
        }

        public decimal VendaDinheiro
        {
            get { return _vendaDinheiro; }
            set
            {
                _vendaDinheiro = value;
                NotifyPropertyChanged("VendaDinheiro");
                NotifyPropertyChanged("Restante");
            }
        }

        public decimal VendaCartao
        {
            get { return _vendaCartao; }
            set
            {
                _vendaCartao = value;
                NotifyPropertyChanged("VendaCartao");
                NotifyPropertyChanged("Restante");
            }
        }


        public decimal Restante
        {
            get { return TotalVenda - (VendaDinheiro + VendaCartao); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
