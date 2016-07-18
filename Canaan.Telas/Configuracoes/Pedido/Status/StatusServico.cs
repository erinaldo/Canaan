using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using OrdemServico = Canaan.Lib.OrdemServico;
using Venda = Canaan.Lib.Venda;

namespace Canaan.Telas.Configuracoes.Pedido.Status
{
    public partial class StatusServico : Form
    {
        public StatusServico()
        {
            InitializeComponent();
        }

        private void StatusServico_Load(object sender, EventArgs e)
        {
            CarregaComboStatus();
        }

        private void CarregaComboStatus()
        {
            var status = Enum.GetNames(typeof(EnumStatusServico));
            cbStatus.DataSource = status.OrderBy(a => a).ToList();
        }

        public Venda LibVenda
        {
            get
            {
                return new Venda();
            }
        }

        public OrdemServico LibOrdem
        {
            get
            {
                return new OrdemServico();
            }
        }

        public TipoEntrega Tipo { get; set; }

        public BindingList<ServicoEntregaProdutoModel> Servicos { get; set; }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                var vendas = LibVenda.GetByCodigoReduzido(int.Parse(txtCodigo.Text.Trim()), Session.Instance.Contexto.IdFilial);
                dataGridVendas.DataSource = vendas.Select(a => new VendaEntregaProdutoModel
                {
                    CodigoReduzido = a.Atendimento.CodigoReduzido,
                    IdVenda = a.IdPedido,
                    Cliente = a.CliFor.Nome,
                    DataVenda = a.DataVenda,
                    DataLiberacao = a.DataLiberacao
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void EntregaPacote_Load(object sender, EventArgs e)
        {
            dataGridVendas.AutoGenerateColumns = false;
            dataGridServicos.AutoGenerateColumns = false;
        }

        private void dataGridVendas_SelectionChanged(object sender, EventArgs e)
        {
            CarregarOrdens();
        }

        private void CarregarOrdens()
        {
            try
            {
                if (dataGridVendas.SelectedRows.Count > 0)
                {
                    var idVenda = int.Parse(dataGridVendas.SelectedRows[0].Cells[2].Value.ToString());

                    Servicos = new BindingList<ServicoEntregaProdutoModel>(LibOrdem.GetByVenda(idVenda).Select(a => new ServicoEntregaProdutoModel
                    {
                        CodOrdem = a.IdOrdemServico,
                        Album = a.Album == null ? string.Empty : a.Album.Nome,
                        Moldura = a.Moldura == null ? string.Empty : a.Moldura.Nome,
                        Servico = a.Servico.Nome,
                        Status = a.Status
                    }).ToList());

                    dataGridServicos.DataSource = Servicos;
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxUtilities.MessageQuestion("Deseja mudar o status dos serviços selecionados para" + cbStatus.SelectedValue.ToString()) == DialogResult.Yes)
                {
                    AlterarStatus();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void AlterarStatus()
        {
            foreach (var item in Servicos.Where(a => a.Selecionado))
            {

                var ordem = LibOrdem.GetById(item.CodOrdem);
                ordem.Status = (EnumStatusServico)Enum.Parse(typeof(EnumStatusServico), cbStatus.SelectedValue.ToString());
                LibOrdem.Update(ordem);
            }

            MessageBoxUtilities.MessageInfo("Status alterado com sucesso");
            CarregarOrdens();
        }

        private void dataGridServicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridServicos.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }


    public class VendaEntregaProdutoModel
    {
        public int CodigoReduzido { get; set; }
        public int IdVenda { get; set; }
        public DateTime? DataVenda { get; set; }
        public DateTime? DataLiberacao { get; set; }
        public string Cliente { get; set; }
    }

    public class ServicoEntregaProdutoModel
    {
        public bool Selecionado { get; set; }
        public int CodOrdem { get; set; }
        public string Servico { get; set; }
        public string Album { get; set; }
        public string Moldura { get; set; }
        public EnumStatusServico Status { get; set; }
    }

    public enum TipoEntrega
    {
        Entrega,
        Recebimento
    }
}
