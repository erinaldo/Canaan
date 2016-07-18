using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Marketing.Parceria.ParceriaOnlineXResultado
{
    public partial class Filtro : Form
    {
        public Filtro()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var frmViewer = new Viewer(int.Parse(cbConsultoras.SelectedValue.ToString()), cbConsultoras.Text);
            frmViewer.ShowDialog();
        }

        private void Filtro_Load(object sender, EventArgs e)
        {
            CarregarConsultoras();
        }

        private void CarregarConsultoras()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var consultoras =
                    conn.Parceria.Where(a => a.IdConsultora != null)
                        .GroupBy(a => new {a.IdConsultora, a.NomeConsultora})
                        .Select(a => new ConsultoraModel {Codigo = a.Key.IdConsultora, Nome = a.Key.NomeConsultora.ToUpper()})
                        .ToList();

                cbConsultoras.DisplayMember = "Nome";
                cbConsultoras.ValueMember = "Codigo";
                cbConsultoras.DataSource = consultoras;

            }
        }
    }

    public class ConsultoraModel
    {
        public int ? Codigo { get; set; }
        public string Nome { get; set; }
        
    }
}
