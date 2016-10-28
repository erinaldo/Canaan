using System;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Telas.Marketing.Cupom;
using Canaan.Telas.Movimentacoes.Agendamento.Cupons;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using Agenda = Canaan.Dados.Agenda;
using AgendamentoMov = Canaan.Lib.AgendamentoMov;
using Cupom = Canaan.Dados.Cupom;
using Parceria = Canaan.Dados.Parceria;
using TelemarketingAgenda = Canaan.Lib.TelemarketingAgenda;

namespace Canaan.Telas.Movimentacoes.Agendamento
{
    public partial class CustomAppointmentForm : XtraForm
    {
        #region CONSTANTES

        /// <summary>
        /// Status Telemarketing
        /// </summary>
        private const int FINALIZADO = 6;
        private const int AGENDADO = 4;

        #endregion

        #region PROPRIEDADES

        public bool Agendado { get; set; }

        public int IdAgendamento { get; set; }

        public Dados.Agendamento Agendamento { get; set; }

        public Agenda Agenda { get; set; }

        public Parceria Parceria { get; set; }

        public Cupom Cupom { get; set; }

        public Lib.Parceria LibParceria
        {
            get
            {
                return new Lib.Parceria();
            }
        }

        public Lib.Agendamento LibAgendamento
        {
            get
            {
                return new Lib.Agendamento();
            }
        }

        public Lib.Agenda LibAgenda
        {
            get
            {
                return new Lib.Agenda();
            }
        }

        public Lib.Cupom LibCupom
        {
            get
            {
                return new Lib.Cupom();
            }
        }

        public TelemarketingAgenda LibTeleAgenda
        {
            get
            {
                return new TelemarketingAgenda();
            }
        }

        public AgendamentoMov LibAgendamentoMov
        {
            get
            {
                return new AgendamentoMov();
            }
        }

        public SchedulerControl control;

        public Appointment apt;

        public bool openRecurrenceForm = false;

        public int suspendUpdateCount;

        public CustomAppointmentFormController controller;

        protected AppointmentStorage Appointments
        {
            get { return control.Storage.Appointments; }
        }

        protected bool IsUpdateSuspended { get { return suspendUpdateCount > 0; } }

        public bool CloseForm { get; set; }

        #endregion

        #region CONSTRUTOR

        public CustomAppointmentForm(SchedulerControl control, Appointment apt, bool openRecurrenceForm)
        {
            InitializeComponent();
            LoadDefaultConfiguration(control, apt, openRecurrenceForm);
        }

        public CustomAppointmentForm(SchedulerControl control, Appointment apt, bool openRecurrenceForm, Cupom cupom)
        {
            try
            {
                InitializeComponent();

                //Seta propriedades do cupom
                Cupom = cupom;
                Agendado = false;

                //Carrega o agendamento ja existente para este cupom
                Agendamento = LibAgendamento.GetAgendamentoByCupom(cupom.IdCupom);

                if (Agendamento != null)
                {
                    apt.CustomFields["IdAgendamento"] = Agendamento.IdAgendamento;
                    Agendamento.Cupom = Cupom;
                }

                //Carrega Configuração padrão
                LoadDefaultConfiguration(control, apt, openRecurrenceForm);

                //Desabilita componentes
                txtTel.Enabled = false;
                btFilterTel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
                CloseForm = true;
            }


        }

        #endregion

        #region EVENTOS

        /// <summary>
        /// Alteração da data inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtStart_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsUpdateSuspended)
                controller.DisplayStart = dataDateEdit.DateTime.Date + horaTimeEdit.Time.TimeOfDay;
            UpdateIntervalControls();
        }

        /// <summary>
        /// Alteração hora inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeStart_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsUpdateSuspended)
                controller.DisplayStart = dataDateEdit.DateTime.Date + horaTimeEdit.Time.TimeOfDay;
            UpdateIntervalControls();
        }

        /// <summary>
        /// Alteração hora final
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeEnd_EditValueChanged(object sender, EventArgs e)
        {
            if (IsUpdateSuspended) return;
            if (IsIntervalValid())
                controller.DisplayEnd = dtEnd.DateTime.Date + timeEnd.Time.TimeOfDay;
            else
                timeEnd.EditValue = new DateTime(controller.DisplayEnd.TimeOfDay.Ticks);
        }

        /// <summary>
        /// Alteração data final
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtEnd_EditValueChanged(object sender, EventArgs e)
        {
            if (IsUpdateSuspended) return;
            if (IsIntervalValid())
                controller.DisplayEnd = dtEnd.DateTime.Date + timeEnd.Time.TimeOfDay;
            else
                dtEnd.EditValue = controller.DisplayEnd.Date;
        }

        /// <summary>
        /// Click do para salvar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                //atualiza dados do cupom
                Agendamento.Cupom.Nome = nomeTextBox.Text;
                Agendamento.Cupom.Endereco = enderecoTextBox.Text;
                Agendamento.Cupom.Email = emailTextBox.Text;
                Agendamento.Cupom.Celular = celularMaskedTextBox.Text;
                Agendamento.Cupom.Telefone = telefoneMaskedTextBox.Text;
                Agendamento.Cupom.Obs = obsTextBox.Text;
                Agendamento.Cupom.IsAtivo = true;

                if(Agendamento.Cupom.IdCupom != 0)
                    LibCupom.Update(Agendamento.Cupom);


                //Edita registro ja existente
                if (IdAgendamento > 0)
                {
                    UpdateIntervalControls();

                    agendamentoBindingSource.EndEdit();

                    var agendamento = (Dados.Agendamento)agendamentoBindingSource.Current;

                    if (agendamento.Status == EnumAgendamentoStatus.Faltante)
                        agendamento.Status = EnumAgendamentoStatus.Agendado;

                    //verifica confirmacao
                    if (agendamento.Status == EnumAgendamentoStatus.Agendado) {
                        if (numConfirmacaoNumericUpDown.Value > 0) {
                            agendamento.Status = EnumAgendamentoStatus.Confirmado;
                        }
                    }
                    else if(agendamento.Status == EnumAgendamentoStatus.Confirmado){
                        if (numConfirmacaoNumericUpDown.Value <= 0)
                            agendamento.Status = EnumAgendamentoStatus.Agendado;
                    }

                    Agendamento = LibAgendamento.Update(agendamento);

                    if (!controller.IsConflictResolved())
                        return;

                    controller.Subject = nomeTextBox.Text;
                    controller.DisplayStart = dataDateEdit.DateTime.Date + horaTimeEdit.Time.TimeOfDay;
                    controller.DisplayEnd = dataDateEdit.DateTime.Date + timeEnd.Time.TimeOfDay;
                    controller.IdAgendamento = IdAgendamento;

                    controller.ApplyChanges();

                    //Idetifica se veio do telemarketing e seta como agendado
                    if (Cupom != null)
                    {
                        Agendado = true;
                        Close();
                    }

                    

                    //Atualiza Status e salva movimentação de Agendamento
                    AtualizarStatusCupom(Agendamento.IdCupom, EnumCupomStatus.Agendado, EnumTelemarketingStatus.Finalizado, agendamento.Status);
                    AtualizarStatusAgendamento(Agendamento.Status);
                }
                //Salva novo Registro
                else
                {
                    //Verifica se existe conflito de horario
                    if (!controller.IsConflictResolved())
                        return;

                    //Salva Registro no banco
                    if (SalvaRegistro())
                    {

                        controller.Subject = nomeTextBox.Text;
                        controller.DisplayStart = dataDateEdit.DateTime.Date + horaTimeEdit.Time.TimeOfDay;
                        controller.DisplayEnd = dataDateEdit.DateTime.Date + timeEnd.Time.TimeOfDay;
                        controller.IdAgendamento = IdAgendamento;

                        controller.ApplyChanges();

                        //Idetifica se veio do telemarketing e seta como agendado
                        if (Cupom != null)
                        {
                            Agendado = true;
                            Close();
                        }


                        //Atualiza Status e salva movimentação de Agendamento
                        AtualizarStatusCupom(Agendamento.IdCupom, EnumCupomStatus.Agendado, EnumTelemarketingStatus.Finalizado, EnumAgendamentoStatus.Agendado);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(this, ex);
            }

        }

        /// <summary>
        /// Atualiza status do Agendamento
        /// </summary>
        /// <param name="enumAgendamentoStatus"></param>
        private void AtualizarStatusAgendamento(EnumAgendamentoStatus enumAgendamentoStatus)
        {
            Agendamento.Status = enumAgendamentoStatus;
            LibAgendamento.Update(Agendamento);
        }

        /// <summary>
        /// Load do Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomAppointmentForm_Load(object sender, EventArgs e)
        {
            if (CloseForm)
                Close();

            Cupom = new Dados.Cupom();
            Cupom.Status = EnumCupomStatus.Agendado;
            Cupom.IdParceria = int.Parse(idParceriaTextBox.Text);
            nomeTextBox.Focus();
        }

        private void lbData_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Filtro do telefone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btFilterTel_Click(object sender, EventArgs e)
        {
            CarregaCuponsConflitantes();
        }

        private void lkParceria_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void timeEnd_EditValueChanged_1(object sender, EventArgs e)
        {
            if (!IsUpdateSuspended)
                controller.DisplayEnd = dtEnd.DateTime.Date + timeEnd.Time.TimeOfDay;
            UpdateIntervalControls();
        }

        #endregion

        #region METODOS

        private void LoadDefaultConfiguration(SchedulerControl control, Appointment apt, bool openRecurrenceForm)
        {

            try
            {
                //Carrega os campos
                this.openRecurrenceForm = openRecurrenceForm;
                controller = new CustomAppointmentFormController(control, apt);
                this.apt = apt;
                this.control = control;

                SuspendUpdate();

                ResumeUpdate();

                //Atualiza Form em Edição
                UpdateForm();

                //Cria o agendamento a ser inserido
                CriaAgendamento();

                //Configura o Form
                ConfiguraForm();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
                CloseForm = true;
            }
        }

        /// <summary>
        /// Cria agendamento
        /// </summary>
        private void CriaAgendamento()
        {
            //Carrega Agenda
            Agenda = LibAgenda.GetByFilial(true, Session.Instance.Contexto.IdFilial);

            //Carrega Parceria
            Parceria = LibParceria.GetByTipoConvenioAndFilial(Session.Instance.Contexto.IdFilial, EnumConvenioTipo.Direto);

            if (Cupom != null)
                if (Cupom.IdParceria != 0)
                    Parceria = LibParceria.GetById(Cupom.IdParceria);

            if (Parceria == null)
                throw new Exception("Não existe nenhum parceria vinculada com convênio direto");

            if (IdAgendamento > 0)
            {
                //Carrega do banco
                Agendamento = LibAgendamento.GetById(IdAgendamento);
                Agendamento.Inicio = apt.Start;
                Agendamento.Termino = apt.End;

                agendamentoBindingSource.DataSource = Agendamento;

                //Desabilita filtro na edição
                txtTel.Enabled = false;
                btFilterTel.Enabled = false;
            }
            else
            {
                //Cria novo agendamento

                Agendamento = new Dados.Agendamento
                {
                    IdAgenda = Agenda.IdAgenda,
                    Inicio = controller.DisplayStart,
                    Termino = controller.DisplayEnd,
                    Status = EnumAgendamentoStatus.Agendado,
                };

                if (Cupom == null)
                {
                    Agendamento.Cupom = new Cupom
                    {
                        Status = EnumCupomStatus.Agendado,
                        IdParceria = Parceria.IdParceria,
                        Data = DateTime.Today,
                        DataPreenchimento = DateTime.Today,
                        IdUsuario = Session.Instance.Usuario.IdUsuario,
                        IsAtivo = true

                    };
                }
                else
                {
                    Agendamento.Cupom = Cupom;
                }


                //Atualiza datasource
                agendamentoBindingSource.DataSource = Agendamento;
            }
        }

        bool IsIntervalValid()
        {
            DateTime start = dataDateEdit.DateTime + horaTimeEdit.Time.TimeOfDay;
            DateTime end = dtEnd.DateTime + timeEnd.Time.TimeOfDay;
            return end >= start;
        }

        protected void SuspendUpdate()
        {
            suspendUpdateCount++;
        }

        protected void ResumeUpdate()
        {
            if (suspendUpdateCount > 0)
                suspendUpdateCount--;
        }

        /// <summary>
        /// Atualiza form na abertura para edição
        /// </summary>
        private void UpdateForm()
        {
            SuspendUpdate();

            try
            {
                dataDateEdit.DateTime = controller.DisplayStart.Date;
                dtEnd.DateTime = controller.DisplayEnd.Date;
                horaTimeEdit.Time = new DateTime(controller.DisplayStart.TimeOfDay.Ticks);
                timeEnd.Time = new DateTime(controller.DisplayEnd.TimeOfDay.Ticks);

                //Atualiza IdAgendamento em caso de edição
                IdAgendamento = controller.IdAgendamento.GetValueOrDefault();
                txtCodigo.Text = controller.IdAgendamento.GetValueOrDefault().ToString();

            }
            finally
            {
                ResumeUpdate();
            }

            UpdateIntervalControls();
        }

        /// <summary>
        /// Verifica os intervalos validos de data e hora
        /// </summary>
        protected virtual void UpdateIntervalControls()
        {
            if (IsUpdateSuspended)
                return;

            SuspendUpdate();

            try
            {
                //agendamentoBindingSource.ResetBindings(false);

                dataDateEdit.EditValue = controller.DisplayStart.Date + controller.DisplayStart.TimeOfDay;
                dtEnd.EditValue = controller.DisplayEnd.Date + controller.DisplayEnd.TimeOfDay;


                //Atualiza Binding
                if (Agendamento != null)
                    Agendamento.Termino = controller.DisplayEnd.Date + controller.DisplayEnd.TimeOfDay;

                horaTimeEdit.EditValue = new DateTime(controller.DisplayStart.TimeOfDay.Ticks);
                timeEnd.EditValue = new DateTime(controller.DisplayEnd.TimeOfDay.Ticks);

            }
            finally
            {
                ResumeUpdate();
            }
        }

        /// <summary>
        /// Configura Form 
        /// </summary>
        private void ConfiguraForm()
        {
            if (Agenda != null)
                lkLabelAgenda.Text = Agenda.Filial.NomeFantasia;

            if (Parceria != null)
                lkParceria.Text = Parceria.Nome;
        }

        /// <summary>
        /// Salva agendamento do banco
        /// </summary>
        private bool SalvaRegistro()
        {
            //Finaliza edição 
            agendamentoBindingSource.EndEdit();

            //Carrega obj do datasource
            Agendamento = (Dados.Agendamento)agendamentoBindingSource.Current;


            if (LibAgendamento.ValidaSalvarCupom(Agendamento.Cupom))
            {
                //Verifica se o cupom a ser vinculado ao agendamento ja existe no banco
                if (Agendamento.Cupom.IdCupom != 0)
                {
                    //Alterar o id do cupom no agendamento
                    Agendamento.IdCupom = Agendamento.Cupom.IdCupom;

                    //Seta Cupom do agendamento como null para não salvar outro no banco
                    Agendamento.Cupom = null;
                }
                Agendamento = LibAgendamento.Insert(Agendamento);

                //Atualiza a propriedade que armazena o id do agendamento
                IdAgendamento = Agendamento.IdAgendamento;

                //Salvou cupom
                return true;
            }
            

            return false;
        }

        /// <summary>
        /// Carrega Cupons Conflitantes
        /// </summary>
        private void CarregaCuponsConflitantes()
        {
            if (!string.IsNullOrEmpty(txtTel.Text))
            {
                var cupons = LibCupom.GetByTel(txtTel.Text);

                //Verifica se existe mais de cupom na lista
                if (cupons.Count > 0)
                {
                    //Se a quantidade for igual a 1 carrega cupom
                    if (cupons.Count == 1)
                    {
                        //Carrega Cupom do banco
                        Agendamento.Cupom = cupons.FirstOrDefault();
                        agendamentoBindingSource.ResetBindings(false);

                        //Atualiza Parceria
                        Parceria = LibParceria.GetById(cupons.FirstOrDefault().IdParceria);

                        //Reconfigura form
                        ConfiguraForm();
                    }
                    else
                    {
                        //Abre Lista de cupons conflitantes
                        var frmSeleciona = new SelecionaCupom(cupons);
                        frmSeleciona.ShowDialog();

                        //Se o usuario selecionou um cupom carrega o mesmo no formulario
                        if (frmSeleciona.SelectedCupom != null)
                        {
                            //Carrega Cupom do banco
                            Agendamento.Cupom = frmSeleciona.SelectedCupom;
                            agendamentoBindingSource.ResetBindings(false);

                            //Atualiza Parceria
                            Parceria = LibParceria.GetById(frmSeleciona.SelectedCupom.IdParceria);

                            //Reconfigura form
                            ConfiguraForm();
                        }
                    }
                }
                else
                {
                    Agendamento.Cupom.Telefone = txtTel.Text.Trim();
                    agendamentoBindingSource.ResetBindings(false);
                }

                gpCupom.Enabled = true;
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Digite um telefone válido");
            }
        }

        /// <summary>
        /// Atualiza status do cupom inserido no banco
        /// </summary>
        private void AtualizarStatusCupom(int idCupom, EnumCupomStatus enumCupomStatus, EnumTelemarketingStatus status, EnumAgendamentoStatus statusAgendamento)
        {
            var cupom = LibCupom.GetById(idCupom);

            //Altera o status
            if (statusAgendamento == EnumAgendamentoStatus.Agendado)
            {
                if(cupom.IdStatusTele == null)
                    cupom.IdUsuarioTele = Session.Instance.Usuario.IdUsuario;
                cupom.IsAgendado = true;
                cupom.DataAgendado = DateTime.Now;
            }
                        
            cupom.Status = enumCupomStatus;
            cupom.IdStatusTele = status;

            LibCupom.Update(cupom);

            //descarta cupons repetidos em aberto
            LibCupom.DescartaRepetidos(cupom);
        }

        #endregion
    }
}
