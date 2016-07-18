using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Atendimento.UsoImagem
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public int IdAtendimento { get; set; }
        public int IdModelo { get; set; }
        public Model DataSetFicha { get; set; }

        #endregion

        #region CONSTRUTOR

        public Viewer(int pIdAtendimento, int pIdModelo)
        {
            this.DataSetFicha = new Model();
            this.IdAtendimento = pIdAtendimento;
            this.IdModelo = pIdModelo;

            InitializeComponent();
        }

        #endregion

        #region METODOS

        private void CarregaDados() 
        {
            //recupera dados do banco
            var cliente = new Lib.CliFor().GetCliByAtendimento(this.IdAtendimento).FirstOrDefault();
            var modelo = new Lib.Modelo().GetById(this.IdModelo);

            //configura o termo
            var row = DataSetFicha.Termo.NewTermoRow();
            row.IdAtendimento = this.IdAtendimento;
            row.IdCliente = cliente.IdCliFor;
            row.CliNome = cliente.Nome;
            row.CliEndereco = string.Format("{0} {1} {2}", cliente.Endereco, cliente.Numero, cliente.Complemento);
            row.ModeloNome = modelo.NomeCompleto;
            row.Logo = Utilitarios.Comum.GetLogoReport();
            row.NomeFantasia = Lib.Session.Instance.Contexto.Filial.NomeFantasia;

            //adiciona no dataset
            DataSetFicha.Termo.AddTermoRow(row);
        }

        private void CarregaRelatorio() 
        {
            try
            {
                //configura o relatorio
                Relatorio report = new Relatorio();

                //carrega dados
                report.SetDataSource(DataSetFicha);

                //carrega o report viewer
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Zoom(100);
            }
            catch (Exception ex)
            {
                Lib.MessageBoxUtilities.MessageError(null, ex);
            }
        }

        #endregion

        #region ENVENTOS

        private void Viewer_Load(object sender, EventArgs e)
        {
            CarregaDados();
            CarregaRelatorio();
        }

        #endregion
    }
}
