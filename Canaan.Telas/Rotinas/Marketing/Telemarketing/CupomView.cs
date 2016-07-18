using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Telas.Rotinas.Marketing.Telemarketing.Historico;
using Canaan.Telas.Rotinas.Marketing.Telemarketing.Lembrete;
using DevExpress.XtraEditors;
using Agendamento = Canaan.Telas.Movimentacoes.Agendamento.Agendamento;
using Cupom = Canaan.Dados.Cupom;
using Indicacao = Canaan.Lib.Indicacao;
using Parceria = Canaan.Dados.Parceria;
using TelemarketingAgenda = Canaan.Lib.TelemarketingAgenda;
using TelemarketingStatus = Canaan.Dados.TelemarketingStatus;
using Usuario = Canaan.Dados.Usuario;

namespace Canaan.Telas.Rotinas.Marketing.Telemarketing
{
    public partial class CupomView : XtraForm
    {
        #region PROPRIEDADES

        public Cupom Cupom { get; set; }

        public Usuario Usuario { get; set; }

        public Parceria Parceria { get; set; }

        public List<TelemarketingStatus> Status { get; set; }

        public Lib.Cupom LibCupom
        {
            get
            {
                return new Lib.Cupom();
            }
        }

        public Lib.Usuario LibUsuario
        {
            get
            {
                return new Lib.Usuario();
            }
        }

        public Lib.TelemarketingStatus LibTeleStatus
        {
            get
            {
                return new Lib.TelemarketingStatus();
            }
        }

        public Lib.Parceria LibParceria
        {
            get
            {
                return new Lib.Parceria();
            }
        }

        public bool Agendado { get; set; }

        public TelemarketingAgenda LibAgendaTele
        {
            get
            {
                return new TelemarketingAgenda();
            }
        }

        public Dados.TelemarketingAgenda AgendaTele { get; set; }

        public Indicacao LibIndicacao
        {
            get
            {
                return new Indicacao();
            }
        }

        public Dados.Indicacao Indicacao { get; set; }

        public TelemarketingAgenda LibTeleAgenda
        {
            get
            {
                return new TelemarketingAgenda();
            }
        }

        public List<Dados.TelemarketingAgenda> ListTeleAgenda { get; set; }

        #endregion

        #region CONSTRUTOR

        public CupomView(int id)
        {
            ListTeleAgenda = new List<Dados.TelemarketingAgenda>();

            //Carrega Cupom
            Cupom = LibCupom.GetById(id);
            Usuario = LibUsuario.GetById(Cupom.IdUsuarioTele.GetValueOrDefault());
            Status = LibTeleStatus.Get();
            Parceria = LibParceria.GetById(Cupom.IdParceria);
            AgendaTele = LibAgendaTele.GetByCupom(id);
            Indicacao = LibIndicacao.GetByCupom(id);

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void CupomView_Load(object sender, EventArgs e)
        {
            ConfiguraForm();

        }

        private void agendarStripButton1_Click(object sender, EventArgs e)
        {
            var frm = new Agendamento(Cupom);
            frm.ShowDialog();

            // Se o cupom passado foi agendado fecha tela
            if (frm.Agendado)
            {
                MessageBoxUtilities.MessageInfo("Agendamento Feito com Sucesso. Para visualizar acesse a agenda");
                Close();
            }
        }

        private void btHistorico_Click(object sender, EventArgs e)
        {
            var frmHitorico = new HistoricoCupom(Cupom.IdCupom);
            frmHitorico.ShowDialog();
        }

        private void btLembrete_Click(object sender, EventArgs e)
        {
            var frmLembretes = new Edita(Cupom);
            frmLembretes.ShowDialog();
            CarregaLembretes();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBoxUtilities.MessageQuestion("Deseja Realmente descartas este cupom?") == DialogResult.Yes)
            {
                DescartaCupom();
                CarregaDados();
            }
        }

        private void nãoAtendeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxUtilities.MessageQuestion("Deseja marcar cupom como não atende ?") == DialogResult.Yes)
                {
                    Cupom.Status = EnumCupomStatus.NaoAtende;
                    LibCupom.Update(Cupom);
                    CarregaDados();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void desligadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxUtilities.MessageQuestion("Deseja marcar cupom como telefone desligado ?") == DialogResult.Yes)
                {
                    Cupom.Status = EnumCupomStatus.Desligado;
                    LibCupom.Update(Cupom);
                    CarregaDados();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                try
                {
                    var agendaTele = LibTeleAgenda.GetById(int.Parse(dataGrid.SelectedRows[0].Cells[0].Value.ToString()));

                    if (agendaTele != null)
                    {
                        //carrega tela de inclusao
                        Edita frm = new Edita(agendaTele);
                        frm.ShowDialog();
                    }

                    //atualiza o grid
                    CarregaLembretes();
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

        private void clIndicacao_Click(object sender, EventArgs e)
        {
            AbreAtendimentoIndicacao();
        }

        #endregion

        #region METODOS

        private void ConfiguraForm()
        {
            if (Cupom != null)
                Text = string.Format("Visualizando Cupom de {0}", Cupom.Nome);

            if (AgendaTele != null)
                cLembreteReponsavel.Text = AgendaTele.Usuario.Nome;

            if (Parceria != null)
                parceriaLabel.Text = Parceria.Nome;

            if (Indicacao != null)
            {
                clIndicacao.Text = string.Format("{0} - {1}", Indicacao.Atendimento.CodigoReduzido, Indicacao.Atendimento.CliFor.Nome);
                clIndicacao.ForeColor = System.Drawing.Color.Blue;
            }
                

            //Carrega Lembretes
            CarregaLembretes();

            CarregaDados();
        }

        private void CarregaLembretes()
        {
            ListTeleAgenda = LibTeleAgenda.GetListByCupom(Cupom.IdCupom);
            dataGrid.DataSource = LibTeleAgenda.CarregaGrid(ListTeleAgenda);
            tbLembrete.Text = string.Format("Lembretes - ({0})", ListTeleAgenda.Count);
        }

        private void CarregaDados()
        {
            //Configura Cupom
            cupomBindingSource.Add(Cupom);

            //Configura combo status telemarketing do cupom
            telemarketingStatusBindingSource.DataSource = Status;
            idStatusTeleComboBox.SelectedValue = Cupom.IdStatusTele;

            //Configura usuario
            usuarioBindingSource.Add(Usuario);
        }

        private void DescartaCupom() 
        {
            try
            {
                //Deleta lembrete do cupom descartado
                DeletaLembretes(Cupom.IdCupom);

                //atualiza o cupom
                //Cupom.IdStatusTele = EnumTelemarketingStatus.Descartado;
                //Cupom.Status = EnumCupomStatus.Descartado;
                //Cupom.IdUsuarioTele = null;
                this.Cupom = LibCupom.DescartaCupom(this.Cupom);
                LibCupom.Update(Cupom);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void DeletaLembretes(int idCupom)
        {
            try
            {
                LibAgendaTele.DeleteByCupom(idCupom);
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void AbreAtendimentoIndicacao() 
        {
            if (Indicacao != null) 
            {
                var frm = new Movimentacoes.Atendimento.Edita(this.Indicacao.Atendimento);
                frm.Show();
            }
        }

        #endregion       
    }
}
