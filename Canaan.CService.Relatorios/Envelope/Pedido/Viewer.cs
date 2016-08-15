using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.CService.Relatorios.Envelope.Pedido
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public int Coligada { get; set; }
        public int CodPacote { get; set; }
        public int CodStudio { get; set; }
        public int CodStatus { get; set; }
        public bool UpdateOnClose { get; set; }
        public bool IsPrinted { get; set; }
        public bool IsReprint { get; set; }
        public Model Modelo { get; set; }
        public Lib.Envelope LibEnvelope 
        {
            get 
            {
                return new Lib.Envelope();
            }
        }

        #endregion

        #region CONSTRUTOR

        public Viewer(int pColigada, int pCodPacote, int pCodStudio, int pCodStatus, bool pUpdateOnClose = false)
        {
            this.Modelo = new Model();
            this.Coligada = pColigada;
            this.CodPacote = pCodPacote;
            this.CodStudio = pCodStudio;
            this.CodStatus = pCodStatus;
            this.UpdateOnClose = pUpdateOnClose;
            this.IsPrinted = false;
            this.IsReprint = false;

            InitializeComponent();
        }

        public Viewer(int pColigada, int pCodPacote)
        {
            this.Modelo = new Model();
            this.Coligada = pColigada;
            this.CodPacote = pCodPacote;
            this.UpdateOnClose = false;
            this.IsReprint = true;
            this.IsPrinted = true;

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Viewer_Load(object sender, EventArgs e)
        {
            AddPrintEvent();
            CarregaDados();
            CarregaRelatorio();
        }

        private void Viewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateStatus();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            IsPrinted = true;
        }

        #endregion
       
        #region METODOS

        private void CarregaDados() 
        {
            //carrega objeto
            var envelopes = new List<Dados.env_envelopes>();

            if (this.IsReprint)
            {
                envelopes.Add(Lib.Envelope.GetById(this.CodPacote));
            }
            else {
                envelopes = Lib.Envelope.GetByPacoteStatus(this.CodPacote, this.CodStudio, this.CodStatus);
            }

            foreach (var item in envelopes)
            {
                var envelope = Lib.Integracao.Envelope.GetById(this.Coligada, item.id_envelope);

                if (envelope != null)
                {
                    var row = this.Modelo.Pedido.NewPedidoRow();
                    row.IdEnvelope = envelope.IdEnvelope;
                    row.IdPedido = envelope.IdPedido;
                    row.IdVenda = envelope.IdVenda;
                    row.IdItem = envelope.IdItem;
                    row.DataEmissao = envelope.DataImportacao;
                    row.DataPrevista = envelope.DataPrevista;
                    row.Cliente = envelope.NomeCliente;
                    row.Cidade = envelope.Cidade;
                    row.Telefone = envelope.Telefone;
                    row.Email = envelope.Email;
                    row.NomeAbertura = envelope.NomeAbertura;
                    row.TipoServico = envelope.Tipo;
                    row.Linha = envelope.Linha;
                    row.Laminacao = envelope.Laminacao;
                    row.RecorteLateral = envelope.RecorteLateral;
                    row.Tecido = envelope.Tecido;
                    row.Embalagem = envelope.Embalagem;
                    row.Maleta = envelope.Maleta;
                    row.FormaPgto = envelope.FormaPagamento;
                    row.ValorBruto = envelope.ValorBruto;
                    row.ValorDesconto = envelope.ValorDesconto;
                    row.ValorDescontoPerc = envelope.ValorDescontoPerc;
                    row.ValorLiquido = envelope.ValorLiquido;
                    row.Vendedor = envelope.NomeVendedor;
                    row.Servico = envelope.Servico;
                    row.QtdeFoto = envelope.NumFoto;
                    row.Observacao = envelope.Observacao;

                    this.Modelo.Pedido.AddPedidoRow(row);

                }
            }

            
        }

        private void CarregaRelatorio() 
        {
            Report report = new Report();

            //carrega dados
            report.SetDataSource(this.Modelo);

            //carrega o report viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Zoom(100);
        }

        private void UpdateStatus() 
        {
            if (this.UpdateOnClose && this.IsPrinted) 
            {
                if (this.CodStatus == 1) 
                {
                    //carrega objeto
                    var envelopes = Lib.Envelope.GetByPacoteStatus(this.CodPacote, this.CodStudio, this.CodStatus);

                    foreach (var item in envelopes)
                    {
                        Lib.Envelope.UpdateStatus(21, item.id_envelope);
                    }
                }
            }
        }

        private void AddPrintEvent() 
        {
            foreach (ToolStrip ts in crystalReportViewer1.Controls.OfType<ToolStrip>())
            {
                foreach (ToolStripButton tsb in ts.Items.OfType<ToolStripButton>())
                {
                    //hacky but should work. you can probably figure out a better method
                    if (tsb.ToolTipText.ToLower().Contains("imprimir"))
                    {
                        //Adding a handler for our propose
                        tsb.Click += new EventHandler(printButton_Click);
                    }
                }
            }
        }

        #endregion
    }
}
