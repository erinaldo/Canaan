//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Canaan.Dados
{
    using System;
    using System.Collections.Generic;
    
    public partial class Agendamento
    {
        public Agendamento()
        {
            this.AgendamentoMov = new HashSet<AgendamentoMov>();
            this.Atendimento = new HashSet<Atendimento>();
        }
    
        public int IdAgendamento { get; set; }
        public int IdCupom { get; set; }
        public int IdAgenda { get; set; }
        public EnumAgendamentoStatus Status { get; set; }
        public System.DateTime Inicio { get; set; }
        public System.DateTime Termino { get; set; }
        public Nullable<int> IdCarta { get; set; }
        public string Observacao { get; set; }
        public string Modelo { get; set; }
        public int NumConfirmacao { get; set; }
        public Nullable<int> IdUsuario { get; set; }
    
        public virtual Agenda Agenda { get; set; }
        public virtual Carta Carta { get; set; }
        public virtual ICollection<AgendamentoMov> AgendamentoMov { get; set; }
        public virtual ICollection<Atendimento> Atendimento { get; set; }
        public virtual Cupom Cupom { get; set; }
        public virtual AgendamentoStatus AgendamentoStatus { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
