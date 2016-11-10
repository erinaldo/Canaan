using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Financeiro.Caixa.LivroCaixa
{
    public partial class Filtro : Form
    {
        public Filtro()
        {
            InitializeComponent();
        }

        

        private void Filtro_Load(object sender, EventArgs e)
        {
            contaCaixaComboBox.ValueMember = "IdContaCaixa";
            contaCaixaComboBox.DisplayMember = "Nome";
            contaCaixaComboBox.DataSource = new Lib.ContaCaixa().GetByFilial(Lib.Session.Instance.Contexto.IdFilial);
        }

        private void gerarButton_Click(object sender, EventArgs e)
        {
            var idContaCaixa = (int)contaCaixaComboBox.SelectedValue;
            var inicio = inicioDateTimePicker.Value.Date;
            var fim = fimDateTimePicker.Value.Date;

            var frm = new Viewer(idContaCaixa, inicio, fim);
            frm.Show();
        }
    }
}
