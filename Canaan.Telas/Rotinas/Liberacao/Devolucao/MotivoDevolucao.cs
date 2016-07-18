using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Motivo = Canaan.Lib.Motivo;

namespace Canaan.Telas.Rotinas.Liberacao.Devolucao
{
    public partial class MotivoDevolucao : Form
    {
        public Motivo LibMotivo
        {
            get
            {
                return new Motivo();
            }
        }

        public BindingList<Dados.MotivoDevolucao> MotivosDevolucao { get; set; }


        public MotivoDevolucao()
        {
            InitializeComponent();


            InitBind();
        }

        private void InitBind()
        {
            dataGrid.AutoGenerateColumns = false;

            if (MotivosDevolucao == null)
                MotivosDevolucao = new BindingList<Dados.MotivoDevolucao>();

            dataGrid.DataBindings.Add(new Binding("DataSource", this, "MotivosDevolucao"));

            cbMotivos.DataSource = LibMotivo.Get();
            cbMotivos.ValueMember = "IdMotivo";
            cbMotivos.DisplayMember = "Descricao";

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedMotivo = (EnumMotivoDevolucao)Enum.Parse(typeof(EnumMotivoDevolucao), cbMotivos.SelectedValue.ToString());


                if (MotivosDevolucao.Any(a => a.IdMotivo == selectedMotivo))
                {
                    MessageBoxUtilities.MessageWarning(string.Format("{0} já está na lista de motivos. Caso queira alterar remova da lista e insira novamente alterando a quantidade", selectedMotivo.ToString()));
                }
                else
                {

                    MotivosDevolucao.Add(new Dados.MotivoDevolucao
                    {
                        IdMotivo = selectedMotivo,
                        Observacao = txtObservacao.Text.Trim(),
                        Quantidade = (int)numUDQuantidade.Value
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }

        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedGrid = (EnumMotivoDevolucao)Enum.Parse(typeof(EnumMotivoDevolucao),dataGrid.SelectedRows[0].Cells[0].Value.ToString());
                var result = MotivosDevolucao.FirstOrDefault(a => a.IdMotivo == selectedGrid);
                MotivosDevolucao.Remove(result);
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
