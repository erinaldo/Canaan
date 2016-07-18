using System;
using System.ComponentModel;

namespace Canaan.Relatorios.Marketing.Parceria.Auditoria
{
    public class ModelFiltro : INotifyPropertyChanged
    {

        public ModelFiltro()
        {
            DataInicial = DateTime.Today;
            DataFinal = DateTime.Today;
        }

        private DateTime _dataInicial;

        public DateTime DataInicial
        {
            get { return _dataInicial; }
            set
            {
                _dataInicial = value;                
            }

        }
        private DateTime _dataFinal;

        public DateTime DataFinal
        {
            get { return _dataFinal; }
            set
            {
                _dataFinal = value;                
            }
        }

        private bool _aberta;

        public bool Aberta
        {
            get { return _aberta; }
            set
            {
                _aberta = value;                
            }
        }


        private bool _fechada;

        public bool Fechada
        {
            get { return _fechada; }
            set
            {
                _fechada = value;
            }
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