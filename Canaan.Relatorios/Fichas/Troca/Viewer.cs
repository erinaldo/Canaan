using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Fichas.Troca
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public int IdVenda { get; set; }
        public Model DataSetTroca { get; set; }

        #endregion

        #region CONSTRUTORES

        public Viewer(int pIdVenda)
        {
            this.DataSetTroca = new Model();
            this.IdVenda = pIdVenda;

            InitializeComponent();
        }

        #endregion

        #region METODOS

        private void CarregaDados() 
        {
            //carrega dados
            var venda = new Lib.Venda().GetById(this.IdVenda);
            var atend = new Lib.Atendimento().GetById(venda.IdAtendimento);
            var cliente = new Lib.CliFor().GetById(atend.IdCliFor);
            var troca = new Lib.CliFor().GetById(venda.IdCliFor);
            var modelos = new Lib.Modelo().GetByAtendimento(atend.IdAtendimento);
            var vendaprod = new Lib.VendaItem().GetByVenda(venda.IdPedido);
            var studio = new Lib.Filial().GetById(venda.IdFilial);
            
            //carreda dados da troca
            var rowTroca = this.DataSetTroca.Troca.NewTrocaRow();
            rowTroca.IdTroca = venda.IdPedido;
            rowTroca.IdCliente = cliente.IdCliFor;
            rowTroca.IdClienteFinanceiro = troca.IdCliFor;
            rowTroca.Cidade = studio.Cidade.Nome;

            rowTroca.CliNome = cliente.Nome;
            rowTroca.CliCpf = Lib.Utilitarios.Comum.FormataCpf(cliente.Documento); //string.Format(@"{0:000\.000\.000\-00}", Convert.ToInt64(Lib.Utilitarios.Comum.RemoveEspeciais(cliente.Documento)));
            rowTroca.CliEndereco = string.Format("{0} {1} {2}", cliente.Endereco, cliente.Numero, cliente.Complemento);
            rowTroca.CliCidade = cliente.Cidade.Nome;
            rowTroca.CidUf = cliente.Cidade.Estado.Nome;

            rowTroca.TrocaNome = troca.Nome;
            rowTroca.TrocaCpf = Lib.Utilitarios.Comum.FormataCpf(troca.Documento); //string.Format(@"{0:000\.000\.000\-00}", Convert.ToInt64(Lib.Utilitarios.Comum.RemoveEspeciais(troca.Documento)));
            rowTroca.TrocaEndereco = string.Format("{0} {1} {2}", troca.Endereco, troca.Numero, troca.Complemento);
            rowTroca.TrocaCidade = troca.Cidade.Nome;
            rowTroca.TrocaUf = troca.Cidade.Estado.Nome;
            rowTroca.TrocaValor = string.Format("{0:c}", venda.ValorLiquido);

            rowTroca.Logo = Utilitarios.Comum.GetLogoReport();
            rowTroca.NomeFantasia = Lib.Session.Instance.Contexto.Filial.NomeFantasia;

            DataSetTroca.Troca.AddTrocaRow(rowTroca);

            //carrega dados dos produtos
            foreach (var item in vendaprod)
            {
                var prod = DataSetTroca.Produto.NewProdutoRow();
                prod.IdProduto = item.IdProduto;
                prod.IdTroca = venda.IdPedido;
                prod.Nome = item.Produto.Nome;
                prod.Valor = string.Format("{0:c}", item.ValorTotal);

                DataSetTroca.Produto.AddProdutoRow(prod);
            }

            //carrega dados dos modelos
            foreach (var item in modelos)
            {
                var mod = DataSetTroca.Modelo.NewModeloRow();
                mod.IdModelo = item.IdModelo;
                mod.IdTroca = venda.IdPedido;
                mod.Nome = item.NomeCompleto;
                mod.Cpf = Lib.Utilitarios.Comum.FormataCpf(item.Cpf); //string.Format(@"{0:000\.000\.000\-00}", Convert.ToInt64(Lib.Utilitarios.Comum.RemoveEspeciais(item.Cpf)));
                mod.Nascimento = item.Nascimento.ToShortDateString();
                mod.Idade = Lib.Utilitarios.Comum.CalculaIdade(item.Nascimento);

                DataSetTroca.Modelo.AddModeloRow(mod);
            }

        }

        private void CarregaRelatorio() 
        {
            try
            {
                //configura o relatorio
                Relatorio report = new Relatorio();

                //carrega dados
                report.SetDataSource(DataSetTroca);

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

        #region EVENTOS

        private void Viewer_Load(object sender, EventArgs e)
        {
            CarregaDados();
            CarregaRelatorio();
        }

        #endregion
    }
}
