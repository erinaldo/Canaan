using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPanel.Relatorios.Caderno
{
    public partial class frmReport : Form
    {
        #region PROPRIEDADES
        
        public Dados.cadernos Caderno { get; set; }
        public Caderno.CadernoVendas.CadernoDataSet ReportData { get; set; }

        #endregion

        #region CONSTRUTORES
        
        public frmReport(Dados.cadernos p_Caderno)
        {
            Caderno = p_Caderno;
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void frmReport_Load(object sender, EventArgs e)
        {
            SetReportData();
            CarregaRelatorio();
        }

        #endregion

        #region METODOS

        private void SetReportData() 
        { 
            //inicializa as propriedades
            ReportData = new CadernoVendas.CadernoDataSet();

            //carrega dados do caderno
            ReportData.Caderno.Rows.Add(GetCaderno());

            //carrega dados da venda
            foreach (var venda in Lib.CadernoVendas.Get(Caderno.id_caderno))
            {
                ReportData.Venda.Rows.Add(GetVenda(venda));
            }

            //carrega dados da venda
            foreach (var devolucao in Lib.CadernoDevolucao.Get(Caderno.id_caderno))
            {
                ReportData.Devolucao.Rows.Add(GetDevolucao(devolucao));
            }

            //carrega dados da venda
            foreach (var liberacao in Lib.CadernoLiberacao.Get(Caderno.id_caderno))
            {
                ReportData.Liberacao.Rows.Add(GetLiberacao(liberacao));
            }
        }

        private CadernoVendas.CadernoDataSet.CadernoRow GetCaderno() 
        {
            CadernoVendas.CadernoDataSet.CadernoRow row = ReportData.Caderno.NewCadernoRow();

            row.id_caderno = Caderno.id_caderno;
            row.filial = Lib.Filiais.GetById(Caderno.id_filial).nome;
            row.data = Caderno.data;
            row.entrada_cartao = Caderno.entrada_cartao;
            row.entrada_depositada = Caderno.entrada_depositada;
            row.entrada_dinheiro = Caderno.entrada_dinheiro;
            row.entrada_total = Caderno.entrada_total;
            row.venda_cartao = Caderno.venda_cartao;
            row.venda_dinheiro = Caderno.venda_dinheiro;
            row.venda_prazo = Caderno.venda_prazo;
            row.venda_total = Caderno.venda_total;
            row.devolvida_qtde = Caderno.devolvida_qtde;
            row.devolvida_valor = Caderno.devolvida_valor;
            row.programada_qtde = Caderno.programada_qtde;
            row.programada_valor = Caderno.programada_valor;
            row.autorizada_qtde = Caderno.autorizada_qtde;
            row.autorizada_valor = Caderno.autorizada_valor;
            row.fotografados = Caderno.fotografados;
            row.brinde = Caderno.brinde;
            row.liberada_gerente = Caderno.liberada_gerente;
            row.liberada_escrit = Caderno.liberada_escrit;

            return row;
        }

        private CadernoVendas.CadernoDataSet.VendaRow GetVenda(Dados.cadernos_vendas venda) 
        {
            CadernoVendas.CadernoDataSet.VendaRow row = ReportData.Venda.NewVendaRow();

            row.id_venda = venda.id_venda;
            row.id_caderno = venda.id_caderno;
            row.cod_cmaster = venda.cod_cmaster;
            row.cod_rm = venda.cod_rm;
            row.tipo = GetTipoVenda(venda);
            row.nome_cliente = venda.nome_cliente;
            row.entrada_cartao = venda.entrada_cartao;
            row.entrada_depositada = venda.entrada_depositada;
            row.entrada_depositada_data = venda.entrada_depositada_data.HasValue == true ? venda.entrada_depositada_data.Value.ToShortDateString() : "";
            row.entrada_dinheiro = venda.entrada_dinheiro;
            row.venda_cartao = venda.venda_cartao;
            row.venda_dinheiro = venda.venda_dinheiro;
            row.venda_prazo = venda.venda_prazo;
            row.venda_total = venda.venda_total;
            row.is_autorizada = venda.is_autorizada;
            row.is_devolvida = venda.is_devolvida;
            row.is_programada = venda.is_programada;

            return row;
        }

        private CadernoVendas.CadernoDataSet.DevolucaoRow GetDevolucao(Dados.cadernos_devolucoes devolucao) 
        {
            CadernoVendas.CadernoDataSet.DevolucaoRow row = ReportData.Devolucao.NewDevolucaoRow();
            var venda = Lib.CadernoVendas.GetById(devolucao.id_venda);

            row.id_devolvida = devolucao.id_devolvida;
            row.id_caderno = Caderno.id_caderno;
            row.cod_cmaster = venda.cod_cmaster;
            row.cod_rm = venda.cod_rm;
            row.nome_cliente = venda.nome_cliente;
            row.valor = venda.venda_total;
            row.motivo = devolucao.cadernos_devolucoes_motivos.descricao;
            row.observacao = devolucao.observacao;

            return row;
        }

        private CadernoVendas.CadernoDataSet.LiberacaoRow GetLiberacao(Dados.cadernos_liberacoes liberacao) 
        {
            CadernoVendas.CadernoDataSet.LiberacaoRow row = ReportData.Liberacao.NewLiberacaoRow();
            var venda = Lib.CadernoVendas.GetById(liberacao.id_venda);

            row.id_liberacao = liberacao.id_liberacao;
            row.id_caderno = Caderno.id_caderno;
            row.cod_cmaster = venda.cod_cmaster;
            row.cod_rm = venda.cod_rm;
            row.nome_cliente = venda.nome_cliente;
            row.valor = venda.venda_total;
            row.desconto = liberacao.desconto;
            row.tipo = liberacao.cadernos_liberacoes_tipos.descricao;
            row.observacao = liberacao.observacao;

            return row;
        }

        private string GetTipoVenda(Dados.cadernos_vendas venda)
        {
            var retorno = "Vendas";

            if (venda.is_programada)
            {
                retorno = "Vendas Programadas";
            }

            return retorno;
        }

        public void CarregaRelatorio()
        {
            //configura o relatorio
            CadernoVendas.relCaderno report = new CadernoVendas.relCaderno();

            //carrega dados
            report.SetDataSource(ReportData);

            //carrega o report viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Zoom(100);
        }

        #endregion
    }
}
