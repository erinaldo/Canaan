using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Fichas.Atendimento
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public int IdAtendimento { get; set; }
        public Model Dataset { get; set; }

        #endregion

        #region CONSTRUTOR

        public Viewer(int p_IdAtendimento)
        {
            IdAtendimento = p_IdAtendimento;
            Dataset = new Model();
            
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Viewer_Load(object sender, EventArgs e)
        {
            CarregaDataSet();
            CarregaRelatorio();
        }

        #endregion

        #region METODOS

        private void CarregaRelatorio()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer()) 
            {
                var row = Dataset.FichaAtendimento.NewFichaAtendimentoRow();
                var atendimento = conn.Atendimento.FirstOrDefault(a => a.IdAtendimento == IdAtendimento);
                var libIndicacao = new Lib.Indicacao();
                var indicacao = libIndicacao.GetByCupom(atendimento.Agendamento.IdCupom);

                if (atendimento != null) 
                {
                    row.IdAtendimento = atendimento.IdAtendimento;
                    row.IdFilial = atendimento.IdFilial;
                    row.IdCliente = atendimento.IdCliFor;
                    row.NomeCliente = atendimento.CliFor.Nome;
                    row.DataNascimento = atendimento.CliFor is Dados.PessoaFisica ? ((Dados.PessoaFisica)atendimento.CliFor).Nascimento : DateTime.Today;
                    row.Email = atendimento.CliFor.Email;
                    row.Cpf = atendimento.CliFor.Documento;
                    row.Rg = atendimento.CliFor is Dados.PessoaFisica ? ((Dados.PessoaFisica)atendimento.CliFor).Rg : "";
                    row.Endereco = string.Format("{0} - {1} {2}",  atendimento.CliFor.Endereco, atendimento.CliFor.Numero, atendimento.CliFor.Complemento);
                    row.Cep = atendimento.CliFor.Cep;
                    row.Bairro = atendimento.CliFor.Bairro;
                    row.Cidade = atendimento.CliFor.Cidade.Nome;
                    row.Estado = atendimento.CliFor.Cidade.Estado.Nome;
                    row.Telefone = atendimento.CliFor.Telefone;
                    row.Celular = atendimento.CliFor.Celular;
                    row.NomePai = atendimento.CliFor is Dados.PessoaFisica ? ((Dados.PessoaFisica)atendimento.CliFor).NomePai : "";
                    row.NomeMae = atendimento.CliFor is Dados.PessoaFisica ? ((Dados.PessoaFisica)atendimento.CliFor).NomeMae : "";
                    row.Conjuge = atendimento.CliFor is Dados.PessoaFisica ? ((Dados.PessoaFisica)atendimento.CliFor).Conjuge : "";
                    row.DataRecepcao = DateTime.Today;
                    row.Convenio = atendimento.Agendamento.Cupom.Parceria.Convenio.Nome;
                    row.Parceria = atendimento.Agendamento.Cupom.Parceria.Nome;
                    row.FilialNome = atendimento.Filial.NomeFantasia;
                    row.FilialRazaoSocial = atendimento.Filial.RazaoSocial;
                    row.FilialCnpj = atendimento.Filial.Cnpj;
                    row.FilialTelefone = atendimento.Filial.Telefone;
                    row.FilialCidade = atendimento.Filial.Cidade.Nome;
                    row.IndicadoPor = indicacao != null ? string.Format("{0} - {1}", indicacao.Atendimento.CodigoReduzido.ToString(), indicacao.Atendimento.CliFor.Nome) : "";
                    row.Recepcionista = atendimento.Usuario.Nome;
                    row.CodigoReduzido = atendimento.CodigoReduzido.ToString();
                    row.Logo = Utilitarios.Comum.GetLogoReport();
                    row.QtdeIndicacoes = libIndicacao.GetByAtendimento(atendimento.IdAtendimento).Where(a => a.Cupom.Parceria.Convenio.Tipo == Dados.EnumConvenioTipo.Indicacao).Count();

                    //adiciona no dataset
                    Dataset.FichaAtendimento.AddFichaAtendimentoRow(row);

                    foreach (var modelo in atendimento.AtendimentoModelo)
                    {
                        var rowModelo = Dataset.Modelo.NewModeloRow();

                        rowModelo.IdModelo = modelo.IdModelo;
                        rowModelo.IdAtendimento = modelo.IdAtendimento;
                        rowModelo.Nome = modelo.Modelo.NomeCompleto;
                        rowModelo.DataNascimento = modelo.Modelo.Nascimento;
                        rowModelo.Cpf = modelo.Modelo.Cpf;
                        rowModelo.Idade = Lib.Utilitarios.Comum.CalculaIdade(modelo.Modelo.Nascimento);

                        //adiciona no dataset
                        Dataset.Modelo.AddModeloRow(rowModelo);
                    }

                    foreach (var ind in libIndicacao.GetByAtendimento(atendimento.IdAtendimento).Where(a => a.Cupom.Parceria.Convenio.Tipo == Dados.EnumConvenioTipo.Indicacao))
                    {
                        var rowIndicacao = Dataset.Indicacoes.NewIndicacoesRow();

                        rowIndicacao.IdIndicacao = ind.idIndicacao;
                        rowIndicacao.IdAtendimento = ind.IdAtendimento;
                        rowIndicacao.Nome = ind.Cupom.Nome;
                        rowIndicacao.Telefone = ind.Cupom.Telefone;
                        rowIndicacao.Celular = ind.Cupom.Celular;
                        rowIndicacao.Email = ind.Cupom.Email;
                        rowIndicacao.Parceria = ind.Cupom.Parceria.Nome;

                        //adiciona no dataset
                        Dataset.Indicacoes.AddIndicacoesRow(rowIndicacao);
                    }

                }
            }
        }

        private void CarregaDataSet()
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

        #endregion
    }
}
