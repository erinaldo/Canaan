using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Lib.Utilitarios;
using Canaan.Telas.Base;
using Canaan.Telas.Movimentacoes.Atendimento;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using Agenda = Canaan.Lib.Agenda;
using Cupom = Canaan.Dados.Cupom;
using Filtro = Canaan.Lib.Filtro;
using TelemarketingAgenda = Canaan.Lib.TelemarketingAgenda;

namespace Canaan.Telas.Movimentacoes.Agendamento
{
    public partial class Agendamento : XtraForm
    {
        #region CAMPOS

        private Cupom Cupom;

        #endregion

        #region PROPRIEDADES

        public bool Fechar { get; set; }

        public DateTime DataAtual { get; set; }

        public bool Agendado { get; set; }

        public Agenda LibAgenda { get; set; }

        public Lib.Agendamento LibAgendamento
        {
            get
            {
                return new Lib.Agendamento();
            }
        }

        public Dados.Agenda Agenda { get; set; }

        public TimeOfDayInterval WorkTime { get; set; }

        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }

        public SchedulerStorage Storage { get; set; }

        public Filtro objLibFiltro
        {
            get
            {
                return new Filtro();
            }
        }

        public Lib.Cupom LibCupom
        {
            get
            {
                return new Lib.Cupom();
            }
        }

        //Filtro

        public object[] Parametros { get; set; }

        public FilterExpressionCollection FilterExpression { get; set; }

        public TelemarketingAgenda LibAgendaTele
        {
            get
            {
                return new TelemarketingAgenda();
            }
        }

        #endregion

        #region CONSTRUTOR

        public Agendamento()
        {
            CarregaDadosBase();
            InitializeComponent();
        }

        public Agendamento(Cupom Cupom)
        {
            Fechar = true;

            //Carrega dados fundamentais
            CarregaDadosBase();

            // TODO: Complete member initialization
            this.Cupom = Cupom;

            InitializeComponent();
        }

        #endregion

        #region EVENTOS


        private void Agendamento_Load(object sender, EventArgs e)
        {
            //Configura Scheduler
            ConfiguraScheduler();
            CarregaFiltros();

            //atualiza faltantes
            UpdateFaltantes();
        }

        void btitemNovo_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //Abre tela de Edição de Filtro
                var frm = new FormFilterBase(typeof(Dados.Agendamento));
                frm.ShowDialog();

                //Verifica se foi criado alguma expressã0
                if (frm.FilterExpression.Count > 0)
                {
                    FilterExpression = frm.FilterExpression;

                    var frmParam = new FormFilterParam(FilterExpression);
                    var dialogResult = frmParam.ShowDialog();

                    if (dialogResult == DialogResult.Cancel)
                        return;

                    //Carrega os parametros
                    Parametros = frmParam.Parametros;

                    //Constroi expressão
                    var expressao = FilterExpression.BuildExpression();

                    //atualiza lista
                    CarregaLista();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(this, ex);
            }
        }

        void btitemExecFiltro_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //Pega item clicado
                var clickedItem = e.Item;

                string filterName = string.Empty;

                //Pega nome do filtro selecionado
                if (clickedItem != null)
                    filterName = clickedItem.Caption;

                //Carrega do banco o filtro
                FilterExpression = objLibFiltro.GetByNome(filterName, typeof(Dados.Agendamento).FullName, Session.Instance.Usuario.IdUsuario);


                //Se a expressao foi carregada com sucesso
                if (FilterExpression != null)
                {
                    //Carrega form com as expressoes passadas como parametro
                    var frmParam = new FormFilterParam(FilterExpression);
                    var dialogResult = frmParam.ShowDialog();

                    if (dialogResult == DialogResult.Cancel)
                        return;

                    //carrega os parametros
                    Parametros = frmParam.Parametros;

                    //atualiza lista
                    CarregaLista();

                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void schedulerControl1_QueryWorkTime(object sender, QueryWorkTimeEventArgs e)
        {
            CriaWorkTime(e);
        }

        private void schedulerControl1_VisibleIntervalChanged(object sender, EventArgs e)
        {

            if (WorkTime == null)
                return;

            if (scheduler != null)
            {
                scheduler.DayView.VisibleTime = WorkTime;
                scheduler.DayView.WorkTime = WorkTime;

                scheduler.WorkWeekView.VisibleTime = WorkTime;
                scheduler.WorkWeekView.WorkTime = WorkTime;
            }


        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            //Pega scheduler 
            SchedulerControl scheduler = ((SchedulerControl)(sender));

            //Cria Form Customizado
            CustomAppointmentForm form;

            //Pega id Agendamento
            var customField = e.Appointment.CustomFields["IdAgendamento"];

            var strCustomField = string.Empty;

            //Verifica se custom field é nulo
            if (customField != null)
                strCustomField = customField.ToString();

            int idAgendamento = 0;

            //Retorna cupom e agendamento para edição
            if (!string.IsNullOrEmpty(strCustomField))
            {
                idAgendamento = int.Parse(strCustomField);
                var agendamento = LibAgendamento.GetById(idAgendamento);
                Cupom = LibCupom.GetById(agendamento.IdCupom);
            }

            if (Cupom == null)
            {
                //cria cupom
                form = new CustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            else
            {
                form = new CustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm, Cupom);

                try
                {
                    e.DialogResult = form.ShowDialog();

                    //Verifica se o cupom passado pelo agendamento foi agendado
                    if (form.Agendado)
                    {
                        Agendado = true;

                        if (Fechar)
                            Close();
                    }

                    //Limpa cupom
                    Cupom = null;
                    e.Handled = true;
                }
                finally
                {
                    form.Dispose();
                }
            }

            //recarrega tela
            DataAtual = e.Appointment.Start.Date;
            ConfiguraScheduler();
        }

        private void schedulerControl1_AllowAppointmentConflicts(object sender, AppointmentConflictEventArgs e)
        {
            if (e.Conflicts.Count <= 4)
                e.Conflicts.Clear();
        }

        private void schedulerControl1_AllowAppointmentCreate(object sender, AppointmentOperationEventArgs e)
        {
            e.Allow = IsIntervalAllowed(scheduler.ActiveView.SelectedInterval);
        }

        private void schedulerControl1_SelectionChanged(object sender, EventArgs e)
        {
            var selected = scheduler.SelectedInterval;

            //Determina um intervalo de 30 minutos se a seleção for maior que 30
            if (selected.End.TimeOfDay.Hours - selected.Start.TimeOfDay.Hours > 30)
            {
                scheduler.ActiveView.SetSelection(new TimeInterval(selected.Start, TimeSpan.FromMinutes(30)), scheduler.ActiveView.SelectedResource);
            }
        }

        private void schedulerControl1_InitAppointmentDisplayText(object sender, AppointmentDisplayTextEventArgs e)
        {
            //Pega campo customizado do agendamento
            var idAgendamento = (int)e.Appointment.CustomFields["IdAgendamento"];
            var result = LibAgendamento.GetById(idAgendamento);

            var nome = string.IsNullOrEmpty(result.Cupom.Nome) ? string.Empty : result.Cupom.Nome;
            var email = string.IsNullOrEmpty(result.Cupom.Email) ? string.Empty : result.Cupom.Email;
            var telefone = string.IsNullOrEmpty(result.Cupom.Telefone) ? string.Empty : Comum.FormataTelefone(result.Cupom.Telefone);
            var celular = string.IsNullOrEmpty(result.Cupom.Celular) ? string.Empty : Comum.FormataTelefone(result.Cupom.Celular);
            var usuario = result.Usuario == null ? string.Empty : result.Usuario.Nome;

            //Formata texto
            e.Text = string.Format(" Nome: {0} - {1} Email: {2} Tel: {3}  Cel: {4} - ({5}) - {6}", result.NumConfirmacao, nome, email, telefone, celular, result.Status, usuario);
        }

        private void schedulerControl1_AppointmentDrop(object sender, AppointmentDragEventArgs e)
        {
            try
            {
                //Pega o id do agendamento 
                var idAgendamento = (int)e.SourceAppointment.CustomFields["IdAgendamento"];
                Dados.Agendamento agendamento = LibAgendamento.GetById(idAgendamento);

                if (agendamento.Status == EnumAgendamentoStatus.Fotografado | agendamento.Atendimento.Count > 0)
                {
                    MessageBoxUtilities.MessageWarning("Cliente com atendimento não pode ter agendamento alterado.");
                }
                else
                {

                    if (MessageBoxUtilities.MessageQuestion("Deseja alterar horario deste cupom ?") == DialogResult.Yes)
                    {

                        if (agendamento.Status == EnumAgendamentoStatus.Faltante)
                            agendamento.Status = EnumAgendamentoStatus.Agendado;

                        //Seta os novos valores para inicio e termino do agendamento
                        agendamento.Inicio = e.EditedAppointment.Start;
                        agendamento.Termino = e.EditedAppointment.End;

                        //Atualizar
                        LibAgendamento.Update(agendamento);
                        MessageBoxUtilities.MessageInfo("Cliente alterado com sucesso");
                    }
                    else
                    {
                        e.Allow = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(this, ex);
            }

        }

        private void btFaltante_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmFaltantes = new Faltantes.Faltantes(dateNavigator.SelectionStart, dateNavigator.SelectionEnd);
            frmFaltantes.ShowDialog();

            CarregaDados(LibAgendamento.Get(Session.Contexto.IdFilial));
        }

        private void btConfirmar_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmFaltantes = new Confirmar.Confirmar(dateNavigator.SelectionStart, dateNavigator.SelectionEnd);
            frmFaltantes.ShowDialog();

            //Recarrega Dados
            CarregaDados(LibAgendamento.Get(Session.Contexto.IdFilial));
        }

        private void ckFaltante_DownChanged(object sender, ItemClickEventArgs e)
        {
            if (ckFaltante.Checked)
                ckConfirmados.Checked = false;

            CarregaVisualizacao();
        }

        private void ckConfirmados_DownChanged(object sender, ItemClickEventArgs e)
        {
            if (ckConfirmados.Checked)
                ckFaltante.Checked = false;
            CarregaVisualizacao();
        }

        private void ckFaltante_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (!ckConfirmados.Checked && !ckFaltante.Checked)
            {
                CarregaDados(LibAgendamento.Get(Session.Contexto.IdFilial, DataAtual.Month, DataAtual.Year));
            }
        }

        private void ckConfirmados_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (!ckConfirmados.Checked && !ckFaltante.Checked)
            {
                CarregaDados(LibAgendamento.Get(Session.Contexto.IdFilial, DataAtual.Month, DataAtual.Year));
            }
        }

        private void schedulerControl1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            e.Menu.Items.Clear();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (scheduler.SelectedAppointments.Count > 0)
            {
                var result = scheduler.SelectedAppointments[0];
                var idAgendamento = int.Parse(result.CustomFields["IdAgendamento"].ToString());

                var frmAtendimento = new Edita(LibAgendamento.GetById(idAgendamento));
                frmAtendimento.ShowDialog();
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum Agendamento Selecionado");
            }
        }

        private void scheduler_AppointmentViewInfoCustomizing(object sender, AppointmentViewInfoCustomizingEventArgs e)
        {
            var idAgendamento = (int)e.ViewInfo.Appointment.CustomFields["IdAgendamento"];

            var cupom = LibAgendamento.GetById(idAgendamento);

            if (cupom == null)
                return;

            var aptViewInfo = e.ViewInfo as AppointmentViewInfo;

            aptViewInfo.Appearance.Options.UseBackColor = true;
            aptViewInfo.Appearance.BackColor = GetColorFromStatus(cupom.Status);
        }

        private void scheduler_AllowAppointmentDrag(object sender, AppointmentOperationEventArgs e)
        {
            try
            {
                //Pega o id do agendamento 
                var idAgendamento = (int)e.Appointment.CustomFields["IdAgendamento"];
                var agendamento = LibAgendamento.GetById(idAgendamento);

                if (agendamento.Status == EnumAgendamentoStatus.Fotografado | agendamento.Atendimento.Count > 0)
                {
                    e.Allow = false;
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(this, ex);
            }
        }

        private void scheduler_AllowAppointmentResize(object sender, AppointmentOperationEventArgs e)
        {
            e.Allow = false;
        }

        private void scheduler_AllowAppointmentDelete(object sender, AppointmentOperationEventArgs e)
        {
            var customField = e.Appointment.CustomFields["IdAgendamento"];

            if (customField != null)
            {
                var idagendamento = int.Parse(customField.ToString());
                var result = LibAgendamento.GetById(idagendamento);

                if (result != null)
                {
                    //define a condicao do cupom
                    if (result.Status != EnumAgendamentoStatus.Agendado)
                    {
                        e.Allow = false;
                    }
                    else
                    {
                        e.Allow = true;
                    }


                }
                else
                {
                    e.Allow = false;
                }



            }
            else
            {
                e.Allow = false;
            }


        }

        private void scheduler_DeleteRecurrentAppointmentFormShowing(object sender, DeleteRecurrentAppointmentFormEventArgs e)
        {

        }

        private void scheduler_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void Storage_AppointmentDeleting(object sender, PersistentObjectCancelEventArgs e)
        {
            DeletarAgendamento(e);
        }

        private void dateNavigator_Click(object sender, EventArgs e)
        {
            DataAtual = dateNavigator.SelectionStart.Date;
            ConfiguraScheduler();
        }

        private void btDescartar_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (scheduler.SelectedAppointments.Count > 0)
                {

                    var result = scheduler.SelectedAppointments[0];
                    var idAgendamento = int.Parse(result.CustomFields["IdAgendamento"].ToString());
                    var agendamento = LibAgendamento.GetById(idAgendamento);
                    var cupom = LibCupom.GetById(agendamento.IdCupom);

                    if (MessageBoxUtilities.MessageQuestion(string.Format("Deseja descartar o cupom no nome de: {0}", cupom.Nome)) == DialogResult.Yes)
                    {
                        //descarta o cupom
                        cupom = LibCupom.DescartaCupom(cupom);
                        LibCupom.Update(cupom);

                        //deleta os agendamentos
                        LibAgendamento.Delete(idAgendamento);

                        MessageBoxUtilities.MessageInfo("Cupom descartado com sucesso");

                        ConfiguraScheduler();
                    }
                }
                else
                {
                    MessageBoxUtilities.MessageWarning("Nenhum Agendamento Selecionado");
                }
            }
            catch (Exception ex)
            {

                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        #endregion

        #region METODOS

        private void UpdateFaltantes()
        {
            LibAgendamento.UpdateConfirmadoFaltante(Session.Instance.Contexto.Filial.IdFilial);
        }

        private void CarregaVisualizacao()
        {
            if (ckFaltante.Checked)
            {
                CarregaFaltante();
            }
            else if (ckConfirmados.Checked)
            {
                CarregaConfirmados();
            }
        }

        private void CarregaConfirmados()
        {
            CarregaDados(LibAgendamento.GetConfirmados(Session.Contexto.IdFilial));
        }

        private void CarregaFaltante()
        {
            CarregaDados(LibAgendamento.GetFaltantes(Session.Contexto.IdFilial));
        }

        private bool IsIntervalAllowed(TimeInterval interval)
        {
            if (WorkTime == null)
                return false;

            DateTime dayStart = interval.Start;
            DateTime agora = DateTime.Now;

            if (dayStart < agora)
                return false;

            //Verifica se a data selecionada esta entre o WorkTime
            if (dayStart.TimeOfDay >= WorkTime.Start && dayStart.TimeOfDay <= WorkTime.End)
                return true;

            return false;
        }

        private void ConfiguraScheduler()
        {
            //Configura semana de trabalho
            scheduler.WorkDays.BeginUpdate();
            scheduler.WorkDays.Clear();
            scheduler.WorkDays.Add(WeekDays.EveryDay);
            scheduler.WorkDays.EndUpdate();

            //Carrega dados do banco
            CarregaDados(LibAgendamento.Get(Session.Contexto.IdFilial, DataAtual.Month, DataAtual.Year));

            //Configura nome do botão do navegador para Hoje
            dateNavigator.TodayButton.Text = "Hoje";

            //Exibe hoje quando form abrir
            scheduler.Start = DataAtual;
        }

        private void CarregaDados(List<Dados.Agendamento> objLista)
        {
            Storage = new SchedulerStorage();

            Storage.AppointmentDeleting += Storage_AppointmentDeleting;

            Storage.Appointments.Mappings.Subject = "Cupom.Nome";
            Storage.Appointments.Mappings.Start = "Inicio";
            Storage.Appointments.Mappings.End = "Termino";
            
            Storage.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("IdAgendamento", "IdAgendamento"));

            BindingSource bs = new BindingSource();
            bs.DataSource = objLista;
            Storage.Appointments.DataSource = bs;

            scheduler.Storage = Storage;
        }

        private void CriaWorkTime(QueryWorkTimeEventArgs e)
        {
            var date = e.Interval.Start;
            var diaSemana = date.DayOfWeek;

            if (Agenda == null)
                return;

            switch (diaSemana)
            {
                case DayOfWeek.Friday:
                    WorkTime = new TimeOfDayInterval(TimeSpan.FromHours(Agenda.SexInicio.Hour), TimeSpan.FromHours(Agenda.SexFim.Hour));
                    break;
                case DayOfWeek.Monday:
                    WorkTime = new TimeOfDayInterval(TimeSpan.FromHours(Agenda.SegInicio.Hour), TimeSpan.FromHours(Agenda.SegFim.Hour));
                    break;
                case DayOfWeek.Saturday:
                    WorkTime = new TimeOfDayInterval(TimeSpan.FromHours(Agenda.SabInicio.Hour), TimeSpan.FromHours(Agenda.SabFim.Hour));
                    break;
                case DayOfWeek.Sunday:
                    WorkTime = new TimeOfDayInterval(TimeSpan.FromHours(Agenda.DomInicio.Hour), TimeSpan.FromHours(Agenda.DomFim.Hour));
                    break;
                case DayOfWeek.Thursday:
                    WorkTime = new TimeOfDayInterval(TimeSpan.FromHours(Agenda.QuiInicio.Hour), TimeSpan.FromHours(Agenda.QuiFim.Hour));
                    break;
                case DayOfWeek.Tuesday:
                    WorkTime = new TimeOfDayInterval(TimeSpan.FromHours(Agenda.TerInicio.Hour), TimeSpan.FromHours(Agenda.TerFim.Hour));
                    break;
                case DayOfWeek.Wednesday:
                    WorkTime = new TimeOfDayInterval(TimeSpan.FromHours(Agenda.QuaInicio.Hour), TimeSpan.FromHours(Agenda.QuaFim.Hour));
                    break;
            }
        }

        private void CarregaDadosBase()
        {
            DataAtual = DateTime.Today;

            //Carrega Agenda
            LibAgenda = new Agenda();
            Agenda = LibAgenda.GetByFilial(true, Session.Instance.Contexto.IdFilial);
        }

        public void CarregaFiltros()
        {
            // Carrega Lista de Filtros para a entidade atual
            var filtros = objLibFiltro.GetByEntidade(typeof(Dados.Agendamento).FullName, Session.Instance.Usuario.IdUsuario);

            List<BarItem> items = new List<BarItem>();

            //Adiciona filtros na lista 
            foreach (var item in filtros)
            {
                bLinkContainerItem.ClearLinks();

                var btitem = new BarButtonItem
                {
                    Caption = item.Nome,

                };

                items.Add(btitem);

                btitem.ItemClick += btitemExecFiltro_ItemClick;
            }

            bLinkContainerItem.AddItems(items.ToArray());


            //Adiciona o novo filtro
            var btItemNovo = new BarButtonItem
            {
                Caption = "Novo Filtro",

            };

            btItemNovo.ItemClick += btitemNovo_ItemClick;
            bLinkContainerItem.AddItem(btItemNovo);
        }

        private void CarregaLista()
        {
            if (FilterExpression == null)
                return;

            var expressao = FilterExpression.BuildExpression();

            var agendamentos = LibAgendamento.Filter(expressao, Parametros);

            CarregaDados(agendamentos);
        }

        private Color GetColorFromStatus(EnumAgendamentoStatus enumAgendamentoStatus)
        {
            switch (enumAgendamentoStatus)
            {
                case EnumAgendamentoStatus.Agendado:
                    return Color.FromArgb(214, 229, 198); // Verde
                case EnumAgendamentoStatus.Confirmado:
                    return Color.FromArgb(192, 226, 243); // Azul
                case EnumAgendamentoStatus.Fotografado:
                    return Color.FromArgb(231, 236, 146); // Dourado
                case EnumAgendamentoStatus.Faltante:
                    return Color.FromArgb(245, 195, 195); // Vermelho
                case EnumAgendamentoStatus.Atendido:
                    return Color.FromArgb(228, 173, 87);
                default:
                    return Color.FromArgb(214, 229, 198);
            }
        }

        private void DeletarAgendamento(PersistentObjectCancelEventArgs e)
        {
            var customField = e.Object.CustomFields["IdAgendamento"];

            if (customField != null)
            {
                var idagendamento = int.Parse(customField.ToString());
                var agendamento = LibAgendamento.GetById(idagendamento);
                if (agendamento != null)
                {
                    if (MessageBoxUtilities.MessageQuestion("Deseja deletar este agendamento?") == DialogResult.Yes)
                    {
                        if (agendamento.Status != EnumAgendamentoStatus.Agendado)
                        {
                            MessageBoxUtilities.MessageWarning("Só é possivel excluir agendamento com status 'Agendado'");
                            return;
                        }
                        else
                        {
                            LibAgendamento.Delete(idagendamento);


                            //busca cupom
                            var cupom = LibCupom.GetById(agendamento.IdCupom);

                            //descarta o cupom
                            cupom = LibCupom.DescartaCupom(cupom);
                            LibCupom.Update(cupom);

                            MessageBoxUtilities.MessageInfo("Agendamento deletado com sucesso");
                        }
                    }
                }

            }
        }

        private void AtualizaStatusCupom(Dados.Agendamento agendamento)
        {

            var cupom = LibCupom.GetById(agendamento.IdCupom);
            cupom.Status = EnumCupomStatus.EmAberto;
            cupom.IdStatusTele = EnumTelemarketingStatus.Distribuido;

            LibCupom.Update(cupom);

            //atualiza cupom
            LibCupom.RemoveCondicao(cupom);
        }

        #endregion

    }
}

