using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.UI;

namespace Canaan.Telas.Movimentacoes.Agendamento
{
    public class CustomAppointmentFormController : AppointmentFormController
    {
        public int ? IdAgendamento { get { return (int ?)EditedAppointmentCopy.CustomFields["IdAgendamento"]; } set { EditedAppointmentCopy.CustomFields["IdAgendamento"] = value; } }
        int ? SourceIdAgendamento { get { return (int ?)SourceAppointment.CustomFields["IdAgendamento"]; } set { SourceAppointment.CustomFields["IdAgendamento"] = value; } }

        public CustomAppointmentFormController(SchedulerControl control, Appointment apt)
            : base(control, apt)
        {

        }

        public override bool IsAppointmentChanged()
        {
            if (base.IsAppointmentChanged())
                return true;
            return SourceIdAgendamento != IdAgendamento;
        }

        protected override void ApplyCustomFieldsValues()
        {
            SourceIdAgendamento = IdAgendamento;
        }
    }
}
