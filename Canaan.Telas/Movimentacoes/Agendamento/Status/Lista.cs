using Canaan.Lib.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Telas.Movimentacoes.Agendamento.Status
{
    public partial class Lista : Form
    {
        #region PROPRIEDADES

        public Dados.EnumAgendamentoStatus? StatusAgendamento { get; set; }

        #endregion

        #region CONSTRUTORES

        public Lista()
        {
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Lista_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void statusDataGridView_DoubleClick(object sender, EventArgs e)
        {
            var result = int.Parse(statusDataGridView.SelectedRows[0].Cells[0].Value.ToString());

            if (result == 1)
            {
                StatusAgendamento = Dados.EnumAgendamentoStatus.Agendado;
            }
            else if (result == 2)
            {
                StatusAgendamento = Dados.EnumAgendamentoStatus.Confirmado;
            }
            else if (result == 3)
            {
                StatusAgendamento = Dados.EnumAgendamentoStatus.Fotografado;
            }
            else if (result == 4)
            {
                StatusAgendamento = Dados.EnumAgendamentoStatus.Faltante;
            }
            else if (result == 5)
            {
                StatusAgendamento = Dados.EnumAgendamentoStatus.Atendido;
            }

            Close();
        }

        #endregion
     
        #region METODOS

        private void CarregaDados()
        {
            statusDataGridView.AutoGenerateColumns = false;
            statusDataGridView.DataSource = UtilityEnum.GetItemsFromEnum<Dados.EnumAgendamentoStatus>()
                                                       .Select(a => new { Codigo = (int)a.Key, Descricao = a.Value })
                                                       .ToList();
            statusDataGridView.ClearSelection();
        }


        #endregion
                
    }
}
