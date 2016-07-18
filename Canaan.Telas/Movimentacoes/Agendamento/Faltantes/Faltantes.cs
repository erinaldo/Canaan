using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Telas.Base;
using Canaan.Telas.Properties;
using AgendamentoMov = Canaan.Lib.AgendamentoMov;
using Cupom = Canaan.Lib.Cupom;

namespace Canaan.Telas.Movimentacoes.Agendamento.Faltantes
{
    public partial class Faltantes : FormSelecao
    {
        #region CAMPOS

        private DateTime start;
        private DateTime end;

        #endregion

        #region PROPRIEDADES

        public Cupom LibCupom 
        {
            get
            {
                return new Cupom();
            }
        }

        public Lib.Agendamento LibAgendamento 
        {
            get
            {
                return new Lib.Agendamento();
            }
        }

        public List<Dados.Agendamento> ObjList { get; set; }

        public List<int> ListIdentificadores 
        {
            get
            {
                return dataGrid.Rows.Cast<DataGridViewRow>()
                                        .Where(a => (bool)a.Cells[0].EditedFormattedValue)
                                        .Select(a => int.Parse(a.Cells[1].Value.ToString()))
                                        .ToList();
            }
        }

        public AgendamentoMov LibAgedamentoMov 
        {
            get
            {
                return new AgendamentoMov();
            }
        }

        #endregion

        #region CONSTRUTOR

        public Faltantes(DateTime start, DateTime end)
        {
            InitializeComponent();

            //Periodo selecionado na visão anterior
            this.start = start;
            this.end = end;

            ConfiguraForm();
        }

        #endregion

        #region EVENTOS

        private void Faltantes_Load(object sender, EventArgs e)
        {
            //Carrega Grid
            CarregaGrid();
        }

        private void btlSalvarFaltante_Click(object sender, EventArgs e)
        {
            SalvarFaltante();
        }

        protected override void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            
        }

        #endregion

        #region METODOS

        protected virtual void CarregaGrid()
        {
            ObjList = LibAgendamento.GetPossiveisFaltante(start, end.AddHours(24.9), Session.Contexto.IdFilial);
            dataGrid.DataSource = LibAgendamento.CarregaGrid(ObjList);
        }

        /// <summary>
        /// Salva Faltante
        /// </summary>
        private void SalvarFaltante()
        {
            var result = ListIdentificadores;

            foreach (var agendamento in result.Select(item => LibAgendamento.GetById(item)))
            {
                ////Atualiza Status do Agendamento
                //agendamento.Status = Dados.EnumAgendamentoStatus.Faltante;
                //LibAgendamento.Update(agendamento);

                ////Salva Movimentação do Agendamento
                //SalvarMovimentacao(agendamento);

                ////Atualiza Status do Cupom para Faltante
                //AtualizaStatusCupom(agendamento);     

                LibAgendamento.SalvaFaltante(agendamento);

                //Reecarrega Grid
                CarregaGrid();
            }

            MessageBoxUtilities.MessageInfo("Faltantes Salvos com sucesso");
        }

        /// <summary>
        /// Atualiza status cupom para faltante
        /// </summary>
        /// <param name="agendamento"></param>
        private void AtualizaStatusCupom(Dados.Agendamento agendamento)
        {
            var cupom = LibCupom.GetById(agendamento.IdCupom);
            
            cupom.Status = EnumCupomStatus.Faltante;
            cupom.IdUsuarioTele = null;
            cupom.IdStatusTele = EnumTelemarketingStatus.Faltante;
            cupom.IsAgendado = false;
            cupom.DataAgendado = null;

            LibCupom.Update(cupom);
        }

        /// <summary>
        /// Salva Movimentação
        /// </summary>
        /// <param name="agendamento"></param>
        private void SalvarMovimentacao(Dados.Agendamento agendamento)
        {
            LibAgedamentoMov.Insert(new Dados.AgendamentoMov
            {
                IdAgendamento = agendamento.IdAgendamento,
                IdUsuario = Session.Usuario.IdUsuario,
                Status = EnumAgendamentoStatus.Faltante,
                Data = DateTime.Today,
                Hora = DateTime.Now.TimeOfDay
            });
        }

        /// <summary>
        /// Configura Form
        /// </summary>
        private void ConfiguraForm()
        {
            //Limpa Tool Strip
            toolStripSeleciona.Items.Clear();

            //Cria Botão de Salvar
            toolStripSeleciona.Items.Add(new ToolStripMenuItem("Salvar Faltantes", Resources.save_16xLG, new EventHandler(btlSalvarFaltante_Click)));

            Text = string.Format("Faltantes de {0} a {1}", start.ToShortDateString(), end.ToShortDateString());

            EnableCheckRow();
        }

        /// <summary>
        /// Habilita 
        /// </summary>
        private void EnableCheckRow()
        {
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dataGrid.Columns.Add(chk);
            chk.HeaderText = "Faltante";
            chk.Name = "chk";
            chk.ReadOnly = false;

            dataGrid.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        #endregion
    }
}
