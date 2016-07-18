using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Telas.Base;
using Canaan.Telas.Properties;
using Cupom = Canaan.Lib.Cupom;
using TelemarketingAgenda = Canaan.Lib.TelemarketingAgenda;

namespace Canaan.Telas.Rotinas.Marketing.Telemarketing.Lembrete
{
    public partial class Lista : FormLista
    {

        //CAMPOS
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

        public List<Dados.TelemarketingAgenda> ListTeleAgenda { get; set; }

        //CONSTRUTORES
        public Lista()
        {
            //inicializa propriedades
            ListTeleAgenda = LibTeleAgenda.GetByUsuarioAndFilial(Session.Usuario.IdUsuario, Session.Contexto.IdFilial);

            //inicializa os componentes
            InitializeComponent();

            //inicializa o titulo
            Text = string.Format("Listagem de Lembretes para {0}", Session.Usuario.Nome);
        }

        //EVENTOS
        private void Lista_Load(object sender, EventArgs e)
        {
            CarregaActions();
            CarregaGrid(LibTeleAgenda.CarregaGrid(ListTeleAgenda));
        }

        private void btnFiliais_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                var frmParcerias = new Telas.Marketing.Parceria.Lista(Id);
                frmParcerias.ShowDialog();
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
            }
        }

        //METODOS
        protected override void CarregaNovo()
        {
            if (Id != 0)
            {
                var agendaTele = LibTeleAgenda.GetById(Id);

                if (agendaTele == null)
                    return;

                var cupom = LibCupom.GetById(agendaTele.IdCupom);

                //carrega tela de inclusao
                Edita frm = new Edita(cupom);
                frm.ShowDialog();

            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
            }

            //atualiza o grid
            ListTeleAgenda = LibTeleAgenda.GetByUsuarioAndFilial(Session.Usuario.IdUsuario, Session.Contexto.IdFilial);
            CarregaGrid(LibTeleAgenda.CarregaGrid(ListTeleAgenda));
        }

        protected override void CarregaEdita()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                try
                {
                    var agendaTele = LibTeleAgenda.GetById(Id);

                    if (agendaTele != null)
                    {
                        //carrega tela de inclusao
                        Edita frm = new Edita(agendaTele);
                        frm.ShowDialog();
                    }

                    //atualiza o grid
                    ListTeleAgenda = LibTeleAgenda.GetByUsuarioAndFilial(Session.Usuario.IdUsuario, Session.Contexto.IdFilial);
                    CarregaGrid(LibTeleAgenda.CarregaGrid(ListTeleAgenda));
                }
                catch (Exception ex)
                {
                    MessageBoxUtilities.MessageError(null, ex);
                }
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
            }
        }

        protected override void ExecutaDelete()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                var deleted = LibTeleAgenda.GetById(Id);

                //carrega tela de inclusao
                try
                {
                    if (MessageBoxUtilities.MessageQuestion("Tem certeza que deseja excluir o registro '" + deleted.Cupom.Nome + "' ?") == DialogResult.Yes)
                    {
                        //deleta objeto
                        deleted = LibTeleAgenda.Delete(Id);
                        MessageBoxUtilities.MessageInfo("Registro '" + deleted.Cupom.Nome + "' excluido com sucesso");

                        //Apos deletar agendamento do cupom voltar para o status de distribuido
                        AtualizaCupom(deleted);

                        //atualiza o grid
                        ListTeleAgenda = LibTeleAgenda.GetByUsuarioAndFilial(Session.Usuario.IdUsuario, Session.Contexto.IdFilial);
                        CarregaGrid(LibTeleAgenda.CarregaGrid(ListTeleAgenda));
                    }
                }
                catch (Exception ex)
                {
                    MessageBoxUtilities.MessageError(this, ex);
                }

            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
            }
        }

        private void AtualizaCupom(Dados.TelemarketingAgenda deleted)
        {
            var result = LibCupom.GetById(deleted.IdCupom);
            result.IdStatusTele = EnumTelemarketingStatus.Distribuido;
            LibCupom.Update(result);
        }

        protected override void CarregaActions()
        {
            btnActions.DropDownItems.Add(new ToolStripMenuItem("Parcerias", Resources.arrow_Sync_16xLG, new EventHandler(btnFiliais_Click)));
        }

        protected override void CarregaFiltros()
        {
        }
    }
}
