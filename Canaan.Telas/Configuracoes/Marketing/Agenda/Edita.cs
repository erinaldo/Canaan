using System;
using Canaan.Lib;
using Canaan.Telas.Base;

namespace Canaan.Telas.Configuracoes.Agenda
{
    public partial class Edita : FormEdita
    {
        public Dados.Agenda Agenda { get; set; }

        public Lib.Agenda LibAgenda { get; set; }

        public Filial LibFilial 
        {
            get
            {
                return new Filial();
            }
        }

        public Edita()
        {
            //Instacia propriedades
            LibAgenda = new Lib.Agenda();

            InitializeComponent();
        }

        protected override void CarregaForm()
        {
            Agenda = LibAgenda.GetByFilial(true, Session.Contexto.IdFilial);

            filialBindingSource.Add(LibFilial.GetById(Session.Contexto.IdFilial));

            if (Agenda == null)
            {
                IsNovo = true;
                Agenda = new Dados.Agenda
                    {
                        IdFilial = Session.Instance.Contexto.IdFilial,
                        IsAtivo = true
                    };

                agendaBindingSource.DataSource = Agenda;
            }
            else
            {
                IsNovo = false;
                agendaBindingSource.DataSource = Agenda;
            }
        }

        protected override void SetTitle()
        {
            if (IsNovo)
                Text = "Nova Agenda";
            else
                Text = "Editando Agenda da Filial: " + Agenda.Filial.NomeFantasia;
        }

        protected override void Incluir()
        {
            try
            {
                //para a edicao do datasource
                agendaBindingSource.EndEdit();

                //envia para metodo de update
                Agenda = LibAgenda.Insert((Dados.Agenda)agendaBindingSource.Current);

                //mensagem de retorno
                MessageBoxUtilities.MessageInfo(string.Format("Registro incluido com sucesso"));

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

        protected override void Editar()
        {
            try
            {
                //para a edicao do datasource
                agendaBindingSource.EndEdit();

                //envia para metodo de update
                Agenda = LibAgenda.Update((Dados.Agenda)agendaBindingSource.Current);

                //mensagem de retorno
                MessageBoxUtilities.MessageInfo(string.Format("Registro alterado com sucesso"));

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

        private void Edita_Load(object sender, EventArgs e)
        {
            CarregaForm();
            SetTitle();
        }
    }
}
