using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraPrinting.Native;

namespace Canaan.Relatorios.Marketing.Parceria.ParceriaXPeriodo
{
    public partial class Filtro : Form
    {
        private static Lib.Parceria LibParceria
        {
            get { return new Lib.Parceria(); }
        }

        private BindingList<ParceriaModel> _parcerias;


        public Filtro()
        {
            InitializeComponent();

            lckParcerias.ItemCheck += (sender, e) =>
            {
                _parcerias[e.Index].Selected = (e.NewValue != CheckState.Unchecked);
            };

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            CarregaDados();
            CarregaListCheckBox();
        }

        private void CarregaListCheckBox()
        {
            ((ListBox)lckParcerias).DataSource = _parcerias;
            ((ListBox)lckParcerias).ValueMember = "IdParceria";
            ((ListBox)lckParcerias).DisplayMember = "Nome";

            CarregaItensSelecionados();
        }

        private void CarregaItensSelecionados()
        {
            for (var i = 0; i < lckParcerias.Items.Count; i++)
            {
                var obj = (ParceriaModel)lckParcerias.Items[i];
                lckParcerias.SetItemChecked(i, obj.Selected);
            }
        }

        private void CarregaDados()
        {
            var parcerias = LibParceria.GetByPeriodo(dtInicial.Value, dtFinal.Value).Select(a => new ParceriaModel
            {
                IdParceria = a.IdParceria,
                Nome = a.Nome,
                Selected = false
            }).ToList();

            if(string.IsNullOrEmpty(buscaTextBox.Text))
                _parcerias = new BindingList<ParceriaModel>(parcerias);
            else
                _parcerias = new BindingList<ParceriaModel>(parcerias.Where(a => a.Nome.Contains(buscaTextBox.Text)).ToList());
        }

        private void ckTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (ckTodas.Checked)
            {
                if (_parcerias != null) _parcerias.ForEach(a => a.Selected = true);
            }
            else
            {
                if (_parcerias != null) _parcerias.ForEach(a => a.Selected = false);
            }

            CarregaItensSelecionados();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var frm = new Viewer(_parcerias.ToList());
            frm.ShowDialog();
        }
    }

    public class ParceriaModel
    {
        public int IdParceria { get; set; }
        public string Nome { get; set; }
        public bool Selected { get; set; }
    }
}
