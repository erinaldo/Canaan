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

namespace Canaan.Telas.Movimentacoes.Agendamento.Confirmar
{
    public partial class Confirmar : FormSelecao
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

        public List<Dados.Agendamento> objList { get; set; }

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

        public Confirmar(DateTime start, DateTime end)
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
            SalvarConfirmado();
        }

        protected override void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Carrega Grid
        /// </summary>
        protected virtual void CarregaGrid()
        {
            objList = LibAgendamento.GetPossivesConfirmados(start, end.AddHours(24.9), Session.Contexto.IdFilial);
            dataGrid.DataSource = LibAgendamento.CarregaGrid(objList);
        }

        /// <summary>
        /// Salva Faltante
        /// </summary>
        private void SalvarConfirmado()
        {
            var result = ListIdentificadores;

            foreach (var item in result)
            {
                var agendamento = LibAgendamento.GetById(item);

                //Atualiza Status do Agendamento
                agendamento.Status = EnumAgendamentoStatus.Confirmado;
                agendamento.NumConfirmacao = 1;
                LibAgendamento.Update(agendamento);

                //Salva Movimentação do Agendamento
                SalvarMovimentacao(agendamento);

                MessageBoxUtilities.MessageInfo("Confirmados Salvos com sucesso");

                AtualizarStatusCupom(agendamento);

                //Reecarrega Grid
                CarregaGrid();
            }

        }

        /// <summary>
        /// Atualiza status do cupom
        /// </summary>
        /// <param name="agendamento"></param>
        private void AtualizarStatusCupom(Dados.Agendamento agendamento)
        {
            var cupom = LibCupom.GetById(agendamento.IdCupom);
            cupom.Status = EnumCupomStatus.Confirmado;
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
                Status = EnumAgendamentoStatus.Confirmado,
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
            toolStripSeleciona.Items.Add(new ToolStripMenuItem("Salvar Confirmado", Resources.save_16xLG, new EventHandler(btlSalvarFaltante_Click)));

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
