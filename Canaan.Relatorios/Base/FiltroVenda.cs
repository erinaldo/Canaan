using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Base
{
    public partial class FiltroVenda : Form
    {
        #region PROPRIEDADES

        public Lib.Session Session
        {
            get
            {
                return Lib.Session.Instance;
            }
        }

        public Lib.CliFor LibCliFor
        {
            get
            {
                return new Lib.CliFor();
            }
        }
        public List<Dados.Atendimento> Clientes { get; set; }

        public Lib.Atendimento LibAtendimento
        {
            get
            {
                return new Lib.Atendimento();
            }
        }
        public List<Dados.Atendimento> Atendimentos { get; set; }
        public int SelectedAtend
        {
            get
            {
                if (dgvAtendimentos.SelectedRows.Count > 0)
                    return int.Parse(dgvAtendimentos.SelectedRows[0].Cells[0].Value.ToString());

                return 0;
            }
        }

        public Lib.Venda LibVenda
        {
            get
            {
                return new Lib.Venda();
            }
        }
        public Dados.Venda Venda { get; set; }
        public BindingList<Lib.Model.Venda> Vendas { get; set; }
        public int CurrentVenda
        {
            get
            {
                var result = dgvVendas.SelectedRows[0].Cells[0].Value;

                int value;
                var ok = int.TryParse(result.ToString(), out value);

                if (ok)
                    return value;
                else
                    return 0;
            }
        }

        public Dados.EnumRelatorioTipo TipoRelatorio { get; set; }

        #endregion

        #region CONSTRUTORES

        public FiltroVenda(Dados.EnumRelatorioTipo pTipoRelatorio)
        {
            this.TipoRelatorio = pTipoRelatorio;

            InitializeComponent();
        }

        #endregion

        #region METODOS

        private void CarregaTipoBusca()
        {
            ddlTipoBusca.Items.Clear();
            ddlTipoBusca.Items.AddRange(Enum.GetNames(typeof(Lib.Utilitarios.TipoBusca)));
        }

        private void CarregaGridAtendimentos()
        {
            dgvAtendimentos.DataSource = LibAtendimento.CarregaGrid(Clientes);
        }

        private void BuscaClientes()
        {
            var value = ddlTipoBusca.SelectedItem.ToString();
            var selected = (Lib.Utilitarios.TipoBusca)Enum.Parse(typeof(Lib.Utilitarios.TipoBusca), value);

            switch (selected)
            {
                case Canaan.Lib.Utilitarios.TipoBusca.Codigo:
                    Clientes = (LibAtendimento.GetByCodigoReduzidoAndFilial(int.Parse(tbBusca.Text.Trim()), Session.Contexto.IdFilial));
                    break;
                case Canaan.Lib.Utilitarios.TipoBusca.Cpf:
                    Clientes = LibAtendimento.GetByCpfAndFilial(tbBusca.Text.Trim(), Session.Contexto.IdFilial);
                    break;
                case Canaan.Lib.Utilitarios.TipoBusca.Nome:
                    Clientes = LibAtendimento.GetByNomeAndFilial(tbBusca.Text.Trim(), Session.Contexto.IdFilial);
                    break;
                default:
                    Clientes = LibAtendimento.GetByNomeAndFilial(tbBusca.Text.Trim(), Session.Contexto.IdFilial);
                    break;
            }
        }

        private void CarregaVendas()
        {
            try
            {
                var vendas = LibVenda.GetByAtendimento(SelectedAtend, Session.Contexto.IdFilial);
                Vendas = new BindingList<Lib.Model.Venda>(LibVenda.CarregaGridModel(vendas));
                dgvVendas.DataSource = Vendas;
            }
            catch (Exception ex)
            {
                Lib.MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void CarregaRelatorio() 
        {
            switch (TipoRelatorio)
            {
                case Canaan.Dados.EnumRelatorioTipo.Venda_Envelope:
                    var frmEnvelope = new Relatorios.Fichas.Envelope.Viewer(CurrentVenda);
                    frmEnvelope.Show();
                    break;
                case Canaan.Dados.EnumRelatorioTipo.Venda_ServicosContratados:
                    var frmServicos = new Relatorios.Fichas.Servicos.Viewer(CurrentVenda);
                    frmServicos.Show();
                    break;
                case Canaan.Dados.EnumRelatorioTipo.Venda_Contrato:
                    var frmContrato = new Relatorios.Fichas.Contrato.Viewer(CurrentVenda);
                    frmContrato.Show();
                    break;
                case Canaan.Dados.EnumRelatorioTipo.Venda_Boleto:
                    var frmBoleto = new Relatorios.Fichas.Boleto.Viewer(CurrentVenda);
                    frmBoleto.Show();
                    break;
                case Canaan.Dados.EnumRelatorioTipo.Venda_Troca:
                    var frmTroca = new Relatorios.Fichas.Troca.Viewer(CurrentVenda);
                    frmTroca.Show();
                    break;
                case Canaan.Dados.EnumRelatorioTipo.Venda_Aditamento:
                    var frmAditamento = new Relatorios.Fichas.Aditamento.Viewer(CurrentVenda);
                    frmAditamento.Show();
                    break;
                case Canaan.Dados.EnumRelatorioTipo.Venda_ControlePagamento:
                    var frmControlePgto = new Relatorios.Fichas.ControlePgto.Viewer(CurrentVenda);
                    frmControlePgto.Show();
                    break;
                case Canaan.Dados.EnumRelatorioTipo.Venda_ComprovanteEntrada:
                    var frmCompEntrada = new Relatorios.Fichas.ComprovanteEntrada.Viewer(CurrentVenda);
                    frmCompEntrada.Show();
                    break;
                case Canaan.Dados.EnumRelatorioTipo.Venda_Cancelamento:
                    var frmCancelamento = new Relatorios.Fichas.Cancelamento.Viewer(CurrentVenda);
                    frmCancelamento.Show();
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region EVENTOS

        private void FiltroVenda_Load(object sender, EventArgs e)
        {
            dgvVendas.AutoGenerateColumns = false;
            dgvAtendimentos.AutoGenerateColumns = false;

            CarregaTipoBusca();

            ddlTipoBusca.SelectedIndex = 0;
        }
       
        private void btnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                BuscaClientes();
                CarregaGridAtendimentos();
            }
            catch (Exception ex)
            {

                Lib.MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void dgvAtendimentos_SelectionChanged(object sender, EventArgs e)
        {
            CarregaVendas();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            CarregaRelatorio();
        }
                
        #endregion
    }
}
