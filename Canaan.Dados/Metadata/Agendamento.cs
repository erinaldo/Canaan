using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados
{
    [MetadataType(typeof(AgendamentoMetadata))]
    public partial class Agendamento { }

    public class AgendamentoMetadata
    {

        public object IdAgendamento { get; set; }
        public object IdCupom { get; set; }
        public object IdAgenda { get; set; }

        [Filter]
        public object Status { get; set; }

        [Filter]
        public object Inicio { get; set; }

        [Filter]
        public object Termino { get; set; }

        public object IdCarta { get; set; }


        //Navigations
        public virtual object Agenda { get; set; }

        public virtual object Carta { get; set; }

        [Filter]
        public virtual object Cupom { get; set; }
    }
}
