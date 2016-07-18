using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Financeiro.Boleto.Itau
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public int[] Lancamentos { get; set; }
        public BoletoDataSet Dataset { get; set; }

        #endregion

        #region CONSTRUTOR

        public Viewer(int[] p_Lancamentos)
        {
            Lancamentos = p_Lancamentos;
            Dataset = new BoletoDataSet();

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Viewer_Load(object sender, EventArgs e)
        {
            CarregaDataSet();
            CarregaBoletos();
        }

        #endregion

        #region METODOS

        private void CarregaDataSet() 
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer()) 
            {
                var lanc = conn.Lancamento.Where(a => Lancamentos.Contains(a.IdLancamento));

                foreach (var item in lanc)
                {
                    var row = Dataset.Boleto.NewBoletoRow();

                    //informacoes gerais
                    row.Banco = string.Format("{0}-{1}", item.ContaCaixa.Conta.Agencia.Banco.Numero, item.ContaCaixa.Conta.Agencia.Banco.Digito);
                    row.NossoNumero = string.Format("{0}-{1}", item.NossoNumero, item.NossoNumeroDac);
                    row.CodigoBarras = SalvaCodigoBarras(item);
                    row.LinhaDigitavel = item.Ipte;
                    row.NumeroDoc = item.IdLancamento.ToString().PadLeft(8, '0');

                    //informacoes dos valores
                    row.ValorCobrado = string.Format("{0:c}", item.ValorLiquido);
                    row.ValorDesconto = string.Format("{0:c}", item.ValorDesconto);
                    row.ValorDocumento = string.Format("{0:c}", item.ValorOriginal);
                    row.ValorMulta = string.Format("{0:c}", (item.ValorMulta + item.ValorJuros));

                    //informacoes das datas
                    row.DataDocumento = item.DataEmissao.ToShortDateString();
                    row.DataProcessamento = DateTime.Today.ToShortDateString();
                    row.DataVencimento = item.DataVencimento.ToShortDateString();

                    //informacoes do cedente
                    row.CedenteAgencia = item.ContaCaixa.Conta.Agencia.Nome;
                    row.CedenteCarteira = item.ContaCaixa.Conta.CarteiraNumero;
                    row.CedenteBairro = item.Filial.Bairro;
                    row.CedenteCidade = item.Filial.Cidade.Nome;
                    row.CedenteEndereco = string.Format("{0} - {1}", item.Filial.Endereco, item.Filial.Numero);
                    row.CedenteCnpj = item.Filial.Cnpj;
                    row.CedenteNome = item.Filial.NomeFantasia;
                    row.CedenteCodigo = string.Format("{0}-{1}", item.ContaCaixa.Conta.CedenteNumero, item.ContaCaixa.Conta.CedenteDigito);

                    //informacoes do sacado
                    row.SacadoBairro = item.CliFor.Bairro;
                    row.SacadoCep = item.CliFor.Cep;
                    row.SacadoCidade = item.CliFor.Cidade.Nome;
                    row.SacadoDocumento = item.CliFor.Documento;
                    row.SacadoEndereco = string.Format("{0} - {1} - {2}", item.CliFor.Endereco, item.CliFor.Numero, item.CliFor.Complemento);
                    row.SacadoNome = item.CliFor.Nome;
                    row.SacadoUf = item.CliFor.Cidade.Estado.Abreviatura;

                    
                    //adiciona no dataset
                    Dataset.Boleto.AddBoletoRow(row);
                }

            }

            
        }

        private void CarregaBoletos() 
        {
            try
            {
                //configura o relatorio
                Relatorio report = new Relatorio();

                //carrega dados
                report.SetDataSource(Dataset);

                //carrega o report viewer
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Zoom(100);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ExportaBoletos()
        {
            var tempFolder = Properties.Settings.Default.TempFolder;
            var pdfPath = string.Format(@"{0}\boletos\exportados\{1}.pdf", tempFolder, Guid.NewGuid().ToString());

            if (!Directory.Exists(Path.GetDirectoryName(pdfPath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(pdfPath));                
            }

            //configura o relatorio
            Relatorio report = new Relatorio();

            //carrega dados
            CarregaDataSet();
            report.SetDataSource(Dataset);

            //exporta para o disco
            report.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, pdfPath);

            //retorna caminho do pdf
            return pdfPath;
        }

        private string SalvaCodigoBarras(Dados.Lancamento item) 
        {
            var tempFolder = Properties.Settings.Default.TempFolder;

            //salva a imagem com o codigo de barras
            var img = new Lib.Lancamento().GeraBarcode(item);            
            var imgPath = string.Format(@"{0}\boletos\codigobarras\{1}.jpg", tempFolder, item.CodigoBarras);

            if (!Directory.Exists(Path.GetDirectoryName(imgPath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(imgPath));
            }

            img.Save(imgPath);

            return imgPath;
        }

        #endregion
    }
}
