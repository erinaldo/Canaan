using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Fichas.Cancelamento
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public List<Model> Lista { get; set; }
        public int IdVenda { get; set; }

        #endregion

        #region CONSTRUTORES

        public Viewer(int idPedido)
        {
            this.Lista = new List<Model>();
            this.IdVenda = idPedido;

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

        private void CarregaDataSet()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                var venda = conn.Pedido.OfType<Dados.Venda>().FirstOrDefault(a => a.IdPedido == IdVenda);
                var cliente = venda.CliFor as Dados.PessoaFisica;
                var empresa = conn.Filial.FirstOrDefault(a => a.IdFilial == Lib.Session.Instance.Contexto.IdFilial);
                var item = new Model();

                item.EmpresaCidade = empresa.Cidade.Nome;
                item.Empresa = empresa.NomeFantasia;
                item.Cnpj = Lib.Utilitarios.Comum.FormataCNPJ(empresa.Cnpj);
                item.Nome = cliente.Nome;
                item.Cpf = Lib.Utilitarios.Comum.FormataCpf(cliente.Documento);
                item.Identidade = cliente.Rg;
                item.Endereco = cliente.Endereco;
                item.Bairro = cliente.Bairro;
                item.Cidade = cliente.Cidade.Nome;
                item.Telefone = cliente.Telefone;
                item.Celular = cliente.Celular;


                //Produtos
                var produtosText = "";
                foreach (var prod in venda.VendaItem)
                {
                    produtosText += string.Format("{0}\n", prod.Produto.Nome);
                }

                //Servicos
                var servicosText = "";
                foreach (var serv in venda.OrdemServico)
                {
                    servicosText += string.Format("{0} - {1} fotos\n", serv.Servico.Nome, serv.OrdemServicoItem.Count.ToString());
                }

                //eventos
                var eventos = new Lib.VendaEvento().GetByVenda(venda.IdPedido);
                var txtEvento = "";
                if (!string.IsNullOrEmpty(venda.TipoEvento) && !string.IsNullOrEmpty(venda.NomeModelo))
                {
                    txtEvento += string.Format("Tipo de Evento: {0}", venda.TipoEvento);
                    txtEvento += Environment.NewLine;
                    txtEvento += string.Format("Nome: {0}", venda.NomeModelo);
                    txtEvento += Environment.NewLine;
                }
                else
                {
                    txtEvento += produtosText;
                }
                
                foreach (var evento in eventos)
                {
                    txtEvento += string.Format("{0}:", evento.Evento.Nome);
                    txtEvento += Environment.NewLine;
                    txtEvento += string.Format("Data: {0}", evento.DataInicio.ToShortDateString());
                    txtEvento += Environment.NewLine;
                    txtEvento += string.Format("{0}", evento.Descricao);
                    txtEvento += Environment.NewLine;
                    txtEvento += Environment.NewLine;
                }

                item.Descricao = txtEvento;
                item.Logo = Lib.Session.Instance.LogoReport;

                //adiciona no dataset
                this.Lista.Add(item);
            }
        }

        private void CarregaRelatorio()
        {
            try
            {
                //configura o relatorio
                Relatorio report = new Relatorio();

                //carrega dados
                report.SetDataSource(Lista);

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
