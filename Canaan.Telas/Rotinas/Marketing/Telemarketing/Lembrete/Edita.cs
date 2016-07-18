using System;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Telas.Base;
using Cupom = Canaan.Lib.Cupom;
using TelemarketingAgenda = Canaan.Lib.TelemarketingAgenda;
using Usuario = Canaan.Lib.Usuario;

namespace Canaan.Telas.Rotinas.Marketing.Telemarketing.Lembrete
{
    public partial class Edita : FormEdita
    {

        public Usuario LibUsuario 
        {
            get
            {
                return new Usuario();
            }
        }

        public TelemarketingAgenda LibTeleAgenda 
        {
            get
            {
                return new TelemarketingAgenda();
            }
        }

        public Cupom LibCupom 
        {
            get
            {
                return new Cupom();
            }
        }

        public Dados.TelemarketingAgenda Lembrete { get; set; }

        private Dados.Cupom Cupom;

        public Edita(Dados.Cupom Cupom)
        {
            // TODO: Complete member initialization
            this.Cupom = Cupom;
            IsNovo = true;
            Lembrete = new Dados.TelemarketingAgenda
            {
                IdCupom = Cupom.IdCupom,
                IdUsuario = Cupom.IdUsuario,
                 Data = DateTime.Today,
                 Hora = DateTime.Now.TimeOfDay,
                 Ativo = true,
            };

            InitializeComponent();
        }

        public Edita(Dados.TelemarketingAgenda agenda)
        {
            IsNovo = false;
            Lembrete = LibTeleAgenda.GetById(agenda.IdTelemarketingAgenda);

            if (Lembrete == null)
                throw new Exception("Não existe lembrete para ser editado para este cupom.");

            Cupom = LibCupom.GetById(Lembrete.IdCupom);

            InitializeComponent();
        }

        //
        //EVENTOS
        private void Edita_Load(object sender, EventArgs e)
        {
            SetTitle();
            CarregaForm();
        }

        //
        //METODOS
        protected override void SetTitle()
        {
            if (IsNovo)
                Text = "Novo Lembrete";
            else
                Text = "Editando Lembrete: " + Cupom.Nome;
        }

        protected override void CarregaForm()
        {
            //carrega o data source
            telemarketingAgendaBindingSource.DataSource = Lembrete;
            cupomBindingSource.DataSource = Cupom;
            usuarioBindingSource.DataSource = LibUsuario.GetById(Cupom.IdUsuarioTele.GetValueOrDefault());
        }

        protected override void Incluir()
        {
            try
            {
                if (IsNovo)
                {

                    //para a edicao do datasource
                    telemarketingAgendaBindingSource.EndEdit();

                    //envia para metodo de update
                    Lembrete = LibTeleAgenda.Insert((Dados.TelemarketingAgenda)telemarketingAgendaBindingSource.Current);

                    //mensagem de retorno
                    MessageBoxUtilities.MessageInfo(string.Format("Registro '{0}' incluido com sucesso", Cupom.Nome));

                    //Atualiza Status Telemarketing
                    AtualizaStatusTeleCupom(EnumTelemarketingStatus.Agendado);

                    //Remove todos os lembretes para um cupom exceto o com o codigo passado
                    LibTeleAgenda.RemoveExceto(Lembrete.IdTelemarketingAgenda, Cupom.IdCupom);

                    //marca para edicao
                    IsNovo = false;
                    SetTitle();
                }
                else
                {
                    //para a edicao do datasource
                    telemarketingAgendaBindingSource.EndEdit();

                    //envia para metodo de update
                    Lembrete = LibTeleAgenda.Update((Dados.TelemarketingAgenda)telemarketingAgendaBindingSource.Current);

                }
                //recarrega o datasource
                CarregaForm();
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBoxUtilities.MessageError(this, ex);
            }
        }

        private void AtualizaStatusTeleCupom(EnumTelemarketingStatus status)
        {
            Cupom.IdStatusTele = status;
            LibCupom.Update(Cupom);
        }

        protected override void Editar()
        {
            try
            {
                //para a edicao do datasource
                telemarketingAgendaBindingSource.EndEdit();

                //envia para metodo de update
                Lembrete = LibTeleAgenda.Update((Dados.TelemarketingAgenda)telemarketingAgendaBindingSource.Current);

                //mensagem de retorno
                MessageBoxUtilities.MessageInfo(string.Format("Registro '{0}' alterado com sucesso", Cupom.Nome));

                //marca para edicao
                IsNovo = false;
                SetTitle();

                //recarrega o datasource
                CarregaForm();
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBoxUtilities.MessageError(this, ex);
            }
        }

    }
}
