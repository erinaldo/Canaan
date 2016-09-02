using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Relatorios.Financeiro.FluxoCaixa
{
    public partial class frmFiltro : Form
    {
        public frmFiltro()
        {
            InitializeComponent();
        }

        private void btnExecuta_Click(object sender, EventArgs e)
        {
            var ds = new dsReport();
            var filiais = CPanel.Lib.Filiais.GetByRede().Where(a => a.rm_coligada != 0);

            foreach (var item in filiais)
            {
                var row = ds.FluxoCaixa.NewFluxoCaixaRow();
                row.IdCidade = item.id_filial;
                row.NomeFantasia = item.nome;
                if(item.spc_consulta != CPanel.Dados.SpcTipoConsulta.Tranferido)
                    row.Valor = Lib.Lancamento.GetFluxoByFilial((short)item.rm_coligada, (short)item.rm_filial, dtInicio.Value.Date, dtFim.Value.Date);
                else
                    row.Valor = Lib.Lancamento.GetFluxoByFilialTransferida((short)item.rm_coligada, (short)item.rm_filial, dtInicio.Value.Date, dtFim.Value.Date);

                ds.FluxoCaixa.AddFluxoCaixaRow(row);
            }

            var frm = new frmReport(ds, dtInicio.Value, dtFim.Value);
            frm.Show();
        }

        private void frmFiltro_Load(object sender, EventArgs e)
        {

        }
    }
}
