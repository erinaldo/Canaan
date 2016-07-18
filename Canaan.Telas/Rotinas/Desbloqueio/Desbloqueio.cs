using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Canaan.Lib;

namespace Canaan.Telas.Rotinas.Desbloqueio
{
    public partial class Desbloqueio : Form
    {
        public Venda LibVenda
        {
            get
            {
                return new Venda();
            }
        }

        public BindingList<DesbloquioModel> VendasDesbloqueio { get; set; }

        public Desbloqueio()
        {
            InitializeComponent();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarVenda();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void CarregarVenda()
        {
            VendasDesbloqueio = new BindingList<DesbloquioModel>(LibVenda.GetByCodigoReduzidoDesbloqueio(int.Parse(txtCodigo.Text.Trim()), Session.Instance.Contexto.IdFilial)
                                                                         .Select(a => new DesbloquioModel
                                                                         {
                                                                             IdVenda = a.IdPedido,
                                                                             Atendimento = a.Atendimento.CodigoReduzido,
                                                                             Cliente = a.CliFor.Nome,
                                                                             DataVenda = a.DataVenda
                                                                         }).ToList());

            dataGrid.DataSource = VendasDesbloqueio;
        }

        private void Desbloqueio_Load(object sender, EventArgs e)
        {
            dataGrid.AutoGenerateColumns = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(MessageBoxUtilities.MessageQuestion("Deseja desbloquear esta venda para alteração ? Tenha bastante atenção antes de executar ação.") == DialogResult.Yes)
            {
                foreach (var item in VendasDesbloqueio.Where(a => a.Selecionado))
                {
                    var venda = LibVenda.GetById(item.IdVenda);
                    venda.IsConfirmado = false;
                    venda.DataConfirmacao = null;
                    venda.IsLiberado = false;
                    venda.DataLiberacao = null;

                    LibVenda.Update(venda);

                    MessageBoxUtilities.MessageInfo(string.Format("Código {0} liberado com sucesso.", venda.Atendimento.CodigoReduzido));
                }
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }

    public class DesbloquioModel
    {
        public bool Selecionado { get; set; }

        public int IdVenda { get; set; }

        public int Atendimento { get; set; }

        public string Cliente { get; set; }

        public DateTime? DataVenda { get; set; }
    }
}
