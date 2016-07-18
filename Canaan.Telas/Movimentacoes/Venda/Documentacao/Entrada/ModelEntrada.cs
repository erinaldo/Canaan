using System.ComponentModel;

namespace Canaan.Telas.Movimentacoes.Venda.Documentacao.Entrada
{
    public class ModelEntrada : INotifyPropertyChanged
    {
        private decimal? _totalEntrada;
        private decimal _entradaDinheiro;
        private decimal _entradaCartao;       

        public decimal? TotalEntrada
        {
            get { return _totalEntrada; }
            set
            {
                _totalEntrada = value;
                NotifyPropertyChanged("TotalEntrada");
                NotifyPropertyChanged("Restante");
            }
        }

        public decimal EntradaDinheiro
        {
            get { return _entradaDinheiro; }
            set
            {
                _entradaDinheiro = value;
                NotifyPropertyChanged("EntradaDinheiro");
                NotifyPropertyChanged("Restante");
            }
        }

        public decimal EntradaCartao
        {
            get { return _entradaCartao; }
            set
            {
                _entradaCartao = value;
                NotifyPropertyChanged("EntradaCartao");
                NotifyPropertyChanged("Restante");
            }
        }

        public decimal Restante
        {
            get { return TotalEntrada.GetValueOrDefault() - (EntradaDinheiro + EntradaCartao); }           
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