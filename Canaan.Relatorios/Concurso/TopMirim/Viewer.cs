using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Concurso.TopMirim
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public Model DataSetInscricao { get; set; }
        public Dados.Modelo Modelo { get; set; }
        public Dados.Atendimento Atendimento { get; set; }
        public Dados.CliFor Cliente { get; set; }
        public string Categoria { get; set; }

        #endregion

        #region CONSTRUTOR

        public Viewer(int pIdAtendimento, int pIdModelo)
        {
            //incializa as propriedades
            this.DataSetInscricao = new Model();
            this.Modelo = new Lib.Modelo().GetById(pIdModelo);
            this.Atendimento = new Lib.Atendimento().GetById(pIdAtendimento);
            this.Cliente = new Lib.CliFor().GetCliByAtendimento(pIdAtendimento).FirstOrDefault();

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Viewer_Load(object sender, EventArgs e)
        {
            if (VerificaCategoria())
            {
                CarregaDados();
                CarregaRelatorio();
            }
            else 
            {
                Lib.MessageBoxUtilities.MessageInfo("Modelo nao possui idade para participar do concurso");
                this.Close();
            }
        }

        #endregion

        #region METODOS

        private bool VerificaCategoria() 
        {
            var idade = Lib.Utilitarios.Comum.CalculaIdade(Modelo.Nascimento);

            if (idade >= 4 && idade <= 10)
            {
                this.Categoria = "Top Mirim";

                return true;
            }
            else {
                return false;
            }
        }

        private void CarregaDados()
        {
            var filial = new Lib.Filial().GetById(Lib.Session.Instance.Contexto.IdFilial);
            var rw = DataSetInscricao.Inscricao.NewInscricaoRow();

            rw.IdAtendimento = Atendimento.CodigoReduzido;
            rw.IdModelo = Modelo.IdModelo;
            rw.Categoria = Categoria;
            rw.DataSessao = Atendimento.Data.ToShortDateString();
            rw.DataInscricao = DateTime.Today.ToShortDateString();
            rw.FilialNome = filial.NomeFantasia;
            rw.FilialCidade = filial.Cidade.Nome;
            rw.Nome = Modelo.NomeCompleto;
            rw.Nascimento = Modelo.Nascimento.ToShortDateString();
            rw.Idade = Lib.Utilitarios.Comum.CalculaIdade(Modelo.Nascimento);
            rw.CliNome = Cliente.Nome;
            rw.CliEndereco = string.Format("{0} {1} {2}", Cliente.Endereco, Cliente.Numero, Cliente.Complemento);
            rw.CliBairro = Cliente.Bairro;
            rw.CliCidade = Cliente.Cidade.Nome;
            rw.CliEstado = new Lib.Cidade().GetById(Cliente.IdCidade).Estado.Nome;
            rw.CliCep = Cliente.Cep;
            rw.CliTelefone = Cliente.Telefone;
            rw.CliCelular = Cliente.Celular;
            rw.CliDocumento = string.Format(@"{0:000\.000\.000\-00}", Convert.ToInt64(Cliente.Documento));
            rw.CliEmail = Cliente.Email;
            rw.Logo = Utilitarios.Comum.GetLogoReport();

            DataSetInscricao.Inscricao.AddInscricaoRow(rw);
        }

        private void CarregaRelatorio()
        {
            try
            {
                //configura o relatorio
                Relatorio report = new Relatorio();

                //carrega dados
                report.SetDataSource(DataSetInscricao);

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
    }
}
