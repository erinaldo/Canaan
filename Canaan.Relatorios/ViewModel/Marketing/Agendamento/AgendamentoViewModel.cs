using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Relatorios.ViewModel.Marketing.Agendamento
{
    public class AgendamentoViewModel
    {
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public Dados.EnumAgendamentoStatus Status { get; set; }
        public int IdFilial { get; set; }
    }
}
