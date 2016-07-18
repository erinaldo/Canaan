using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Fichas.Termo
{
    public partial class Viewer : Base.Viewer
    {
        private int IdModelo;
        private Dados.EnumModeloTipoResp parente;
        private int IdAtendimento;

        public Model Dataset { get; set; }

        public Viewer()
        {
            InitializeComponent();
        }

        public Viewer(int IdModelo, int IdAtendimento, Dados.EnumModeloTipoResp parent)
            : this()
        {
            // TODO: Complete member initialization
            this.IdModelo = IdModelo;
            this.IdAtendimento = IdAtendimento;
            this.parente = parent;
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            if (Dataset == null)
            {
                Dataset = new Model();
                CarregaDataSet();
                CarregaRelatorio();
            }
        }

        private void CarregaDataSet()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                var modelo = conn.Modelo.FirstOrDefault(a => a.IdModelo == IdModelo);
                var cliente = conn.Modelo.Where(a => a.IdModelo == IdModelo).Select(a => a.CliFor).FirstOrDefault();
                var atendimento = conn.Atendimento.FirstOrDefault(a => a.CodigoReduzido == IdAtendimento);
                var filial = conn.Filial.FirstOrDefault(a => a.IdFilial == atendimento.IdFilial);
                var responsavel = conn.ModeloResp.FirstOrDefault(a => a.Tipo == parente && a.IdModelo == IdModelo);
                var resposavelPrincipal = conn.ModeloResp.FirstOrDefault(a => a.Tipo == Dados.EnumModeloTipoResp.Responsavel_Legal && a.IdModelo == IdModelo);


                if (responsavel == null)
                {
                    MessageBox.Show(string.Format("Nenhum responsável do tipo {0} foi encontrado. Adicione um novo responsavel para o modelo {1} e tente novamente.", Lib.Utilitarios.UtilityEnum.GetEnumDescription(parente.ToString(), typeof(Dados.EnumModeloTipoResp)), modelo.NomeCompleto));
                    return;
                }

                if(resposavelPrincipal == null)
                {
                    MessageBox.Show(string.Format("É Necessário cadastrar um responsável do tipo {0}", Lib.Utilitarios.UtilityEnum.GetEnumDescription(parente.ToString(), typeof(Dados.EnumModeloTipoResp))));
                    return;

                }


                //Atendimento
                var rowAtendimento = Dataset.Atendimento.NewAtendimentoRow();

                rowAtendimento.IdAtendimento = atendimento.IdAtendimento;
                rowAtendimento.IdCliente = atendimento.IdCliFor;
                rowAtendimento.Logo = Utilitarios.Comum.GetLogoReport();
                rowAtendimento.NomeFantasia = Lib.Session.Instance.Contexto.Filial.NomeFantasia;

                Dataset.Atendimento.AddAtendimentoRow(rowAtendimento);


                //Cliente
                var rowCliente = Dataset.Cliente.NewClienteRow();

                var cli = cliente as Dados.PessoaFisica;

                rowCliente.IdCliente = cliente.IdCliFor;
                rowCliente.Nome = cliente.Nome;
                rowCliente.RG = cli == null ? string.Empty : cli.Rg;
                rowCliente.CPF = cliente.Documento;
                rowCliente.IdFilial = filial.IdFilial;

                Dataset.Cliente.AddClienteRow(rowCliente);

                //Modelo
                var rowModelo = Dataset.Modelo.NewModeloRow();

                rowModelo.IdModelo = modelo.IdModelo;
                rowModelo.IdAtendimento = atendimento.IdAtendimento;
                rowModelo.Nome = modelo.NomeCompleto;
                rowModelo.Nascimento = modelo.Nascimento.ToShortDateString();

                Dataset.Modelo.AddModeloRow(rowModelo);

                //Filial

                var rowFilial = Dataset.Filial.NewFilialRow();

                rowFilial.IdFilial = filial.IdFilial;
                rowFilial.Cidade = filial.Cidade.Nome;

                Dataset.Filial.AddFilialRow(rowFilial);


                //Responsavel
                var rowResponsavel = Dataset.Responsavel.NewResponsavelRow();

                rowResponsavel.IdModelo = modelo.IdModelo;
                rowResponsavel.IdResponsavel = responsavel.IdModeloResp;
                rowResponsavel.Nome = responsavel.Nome;
                rowResponsavel.CPF = Lib.Utilitarios.Comum.FormataCpf(responsavel.Cpf);
                rowResponsavel.RG = responsavel.Rg;
                rowResponsavel.Tipo = Lib.Utilitarios.UtilityEnum.GetEnumDescription(parente.ToString(), typeof(Dados.EnumModeloTipoResp));

                Dataset.Responsavel.AddResponsavelRow(rowResponsavel);

                var rowResponsabelPrincipal = Dataset.ResponsavelPrincipal.NewResponsavelPrincipalRow();

                rowResponsabelPrincipal.IdModelo = modelo.IdModelo;
                rowResponsabelPrincipal.IdResponsavel = resposavelPrincipal.IdModeloResp;
                rowResponsabelPrincipal.Nome = resposavelPrincipal.Nome;
                rowResponsabelPrincipal.CPF = Lib.Utilitarios.Comum.FormataCpf(resposavelPrincipal.Cpf);
                rowResponsabelPrincipal.RG = resposavelPrincipal.Rg;
                rowResponsabelPrincipal.Tipo = Lib.Utilitarios.UtilityEnum.GetEnumDescription(Dados.EnumModeloTipoResp.Responsavel_Legal.ToString(), typeof(Dados.EnumModeloTipoResp));

                Dataset.ResponsavelPrincipal.AddResponsavelPrincipalRow(rowResponsabelPrincipal);

            }
        }

        private void CarregaRelatorio()
        {
            try
            {
                if (parente == Dados.EnumModeloTipoResp.Responsavel_Legal)
                {
                    Relatorio report = new Relatorio();
                    //carrega dados
                    report.SetDataSource(Dataset);

                    //carrega o report viewer
                    crystalReportViewer1.ReportSource = report;
                }
                else
                {
                    RelatorioOutros report = new RelatorioOutros();
                    report.SetDataSource(Dataset);

                    //carrega o report viewer
                    crystalReportViewer1.ReportSource = report;
                }

                crystalReportViewer1.Zoom(100);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
