using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPanel.Relatorios.Faturamento.TempoReal
{
    public partial class Filtro : Form
    {
        public Filtro()
        {
            InitializeComponent();
        }

        private void btnExecuta_Click(object sender, EventArgs e)
        {
            var ds = new FaturamentoDataSet();
            var filiais = CPanel.Lib.Filiais.GetByRede().Where(a => a.ativo == true && a.id_setor != 6).OrderBy(a => a.nome);

            foreach (var item in filiais)
            {
                var caderno = CPanel.Lib.Caderno.GetByPeriodo(item.id_filial, dtInicio.Value.Date, dtFim.Value.Date);
                var row = ds.Faturamento.NewFaturamentoRow();
                row.IdFilial = item.id_filial;
                row.Filial = item.nome;
                row.Entrada = caderno.Sum(a => a.entrada_total) + caderno.Sum(a => a.venda_cartao);
                row.Venda = caderno.Sum(a => a.venda_total);

                ds.Faturamento.AddFaturamentoRow(row);
            }

            var frm = new Relatorio(ds, dtInicio.Value, dtFim.Value);
            frm.Show();
        }
    }
}
