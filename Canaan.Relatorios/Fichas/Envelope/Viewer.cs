using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Fichas.Envelope
{
    public partial class Viewer : Base.Viewer
    {    
        public Model Dataset { get; set; }

        public int IdVenda { get; set; }

        public Viewer(int idVenda)
        {
            this.IdVenda = idVenda;
            InitializeComponent();
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

        private void CarregaRelatorio()
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

        private void CarregaDataSet()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                var venda = conn.Pedido.OfType<Dados.Venda>().FirstOrDefault(a => a.IdPedido == IdVenda);

                var rowAtendimento = Dataset.Atendimento.NewAtendimentoRow();
                var rowCliente = Dataset.Cliente.NewClienteRow();

                //Atendimento
                rowAtendimento.IdAtendimento = venda.Atendimento.IdAtendimento;
                rowAtendimento.Data = venda.Atendimento.Data;
                rowAtendimento.Estudio = venda.Atendimento.Filial.NomeFantasia;
                rowAtendimento.CodigoReduzido = venda.Atendimento.CodigoReduzido;
                rowAtendimento.Logo = Utilitarios.Comum.GetLogoReport();

                //imagens selecionadas
                rowAtendimento.Imagens = "";
                foreach (var item in venda.VendaFoto.OrderBy(a => a.Foto.Nome))
                {
                    rowAtendimento.Imagens += string.Format("{0} - ", item.Foto.Nome);
                }


                //Cliente
                var cliente = venda.Atendimento.CliFor as Dados.PessoaFisica;

                rowCliente.Nome = venda.Atendimento.CliFor.Nome;
                rowCliente.Nascimento = cliente == null ? string.Empty : cliente.Nascimento.ToShortDateString();
                rowCliente.RG = cliente == null ? string.Empty : cliente.Rg;
                rowCliente.Endereco = venda.Atendimento.CliFor.Endereco;
                rowCliente.Bairro = venda.Atendimento.CliFor.Bairro;
                rowCliente.Cep = venda.Atendimento.CliFor.Cep;
                rowCliente.Telefone =  Lib.Utilitarios.Comum.FormataTelefone(venda.Atendimento.CliFor.Telefone);
                rowCliente.EstadoCivil = cliente == null ? string.Empty : cliente.EstadoCivil.ToString();
                rowCliente.Conjuje = cliente == null ? string.Empty : cliente.Conjuge;
                rowCliente.Filiacao = cliente == null ? string.Empty : string.Format("{0} - {1}", cliente.NomeMae, cliente.NomePai);
                rowCliente.Sexo = cliente.Sexo.ToString();
                rowCliente.CPF = Lib.Utilitarios.Comum.FormataCpf(venda.Atendimento.CliFor.Documento);
                rowCliente.Cidade = venda.Atendimento.CliFor.Cidade.Nome;
                rowCliente.Estado = venda.Atendimento.CliFor.Cidade.Estado.Nome;
                rowCliente.Celular = Lib.Utilitarios.Comum.FormataTelefone(venda.Atendimento.CliFor.Celular);
                rowCliente.IdCliente = venda.Atendimento.CliFor.IdCliFor;
                rowCliente.IdAtendimento = venda.Atendimento.IdAtendimento;

                Dataset.Atendimento.AddAtendimentoRow(rowAtendimento);
                Dataset.Cliente.AddClienteRow(rowCliente);

                //Fichas
                foreach (var item in venda.Atendimento.AtendimentoModelo)
                {
                    var rowModelos = Dataset.Modelo.NewModeloRow();

                    rowModelos.Nome = item.Modelo.NomeCompleto;
                    rowModelos.Nascimento = item.Modelo.Nascimento.ToShortDateString();
                    rowModelos.Idade = Lib.Utilitarios.Comum.CalculaIdade(item.Modelo.Nascimento);
                    rowModelos.CPF = Lib.Utilitarios.Comum.FormataCpf(item.Modelo.Cpf);
                    rowModelos.IdAtendimento = venda.Atendimento.IdAtendimento;

                    Dataset.Modelo.AddModeloRow(rowModelos);
                }


                //Referencia Profissional
                foreach (var item in venda.Atendimento.CliFor.CliForReferencia.Where(a => a.Tipo == Dados.EnumCliForTipoRef.Profissional))
                {
                    var rowProfissional = Dataset.ReferenciaProfissional.NewReferenciaProfissionalRow();

                    rowProfissional.IdReferencia = item.IdReferencia;
                    rowProfissional.Nome = item.Nome;
                    rowProfissional.Endereco = item.Endereco;
                    rowProfissional.Telefone = Lib.Utilitarios.Comum.FormataTelefone(item.Telefone);
                    rowProfissional.Celular = Lib.Utilitarios.Comum.FormataTelefone(item.Celular);
                    rowProfissional.IdCliente = item.IdCliFor;

                    Dataset.ReferenciaProfissional.AddReferenciaProfissionalRow(rowProfissional);
                }


                //Referencia Profissional
                foreach (var item in venda.Atendimento.CliFor.CliForReferencia.Where(a => a.Tipo == Dados.EnumCliForTipoRef.Pessoal))
                {
                    var rowPessoal = Dataset.ReferenciaPessoal.NewReferenciaPessoalRow();

                    rowPessoal.IdReferencia = item.IdReferencia;
                    rowPessoal.Nome = item.Nome;
                    rowPessoal.Endereco = item.Endereco;
                    rowPessoal.Telefone = Lib.Utilitarios.Comum.FormataTelefone(item.Telefone);
                    rowPessoal.Celular = Lib.Utilitarios.Comum.FormataTelefone(item.Celular);
                    rowPessoal.IdCliente = item.IdCliFor;

                    Dataset.ReferenciaPessoal.AddReferenciaPessoalRow(rowPessoal);
                }

                
            }
        }


    }
}
