using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Relatorios.ViewModel.Marketing.ListaTele
{
    public class ListaTeleViewModel
    {
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public int IdFilial { get; set; }
        public Lib.Componentes.TipoRelatorioTele TipoRelatorio { get; set; }
        public bool Etiquetas { get; set; }
        public bool Cartas { get; set; }
    }   
}
