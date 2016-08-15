using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.CService.Relatorios.Envelope.AtrasoXCliente
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public string Cliente { get; set; }
        public DateTime DataPrevista { get; set; }
        public Model Modelo { get; set; }

        #endregion

        #region CONSTRUTOR

        public Viewer(string pCliente, DateTime pDataPrevista)
        {
            this.Cliente = pCliente;
            this.DataPrevista = pDataPrevista;
            this.Modelo = new Model();

            InitializeComponent();
        }

        #endregion
        
        #region EVENTOS

        private void Viewer_Load(object sender, EventArgs e)
        {
            CarregaDados();
            CarregaRelatorio();
        }

        #endregion

        #region METODOS

        private void CarregaDados() 
        {
            using (var conn = new Dados.CServicosEntities())
            {
                var status = new int[] { 16, 22 };
                var envelopes = conn.env_envelopes.Where(a => a.nome_cliente == this.Cliente && a.data_prevista < this.DataPrevista && !status.Contains(a.id_status.Value));

                foreach (var item in envelopes)
                {
                    var row = this.Modelo.Envelope.NewEnvelopeRow();
                    row.IdEnvelope = item.id_envelope;
                    row.CodPacote = item.cod_pacote.GetValueOrDefault();
                    row.CodSigi = item.cod_venda.GetValueOrDefault();
                    row.Cliente = item.nome_cliente;
                    row.Servico = item.servico;
                    row.Status = item.env_status.nome;
                    row.PrevisaoEntrega = item.data_prevista.GetValueOrDefault();
                    row.PrevisaoStatus = item.data_status_prevista.GetValueOrDefault();
                    row.AtrasoEntrega = (int)(this.DataPrevista - item.data_prevista.GetValueOrDefault()).TotalDays;
                    row.AtrasoStatus = (int)(this.DataPrevista - item.data_status_prevista.GetValueOrDefault()).TotalDays;

                    this.Modelo.Envelope.AddEnvelopeRow(row);
                }
            }
        }

        private void CarregaRelatorio()
        {
            Relatorio report = new Relatorio();

            //carrega dados
            report.SetDataSource(this.Modelo);

            //carrega o report viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Zoom(100);
        }

        #endregion

        

        
    }
}
