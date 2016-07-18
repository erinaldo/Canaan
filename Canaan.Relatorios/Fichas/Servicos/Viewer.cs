using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Fichas.Servicos
{
    public partial class Viewer : Form
    {
        //propriedades
        public int CodVenda { get; set; }
        public Model DsModel { get; set; }

        //construtor
        public Viewer(int pCodVenda)
        {
            //inicializa as propriedades
            CodVenda = pCodVenda;
            DsModel = new Model();

            InitializeComponent();
        }

        //eventos
        private void Viewer_Load(object sender, EventArgs e)
        {
            CarregaDados();
            CarregaRelatorio();
        }

        //metodos
        private void CarregaDados()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                //recupera venda no banco de dados
                var item = conn.Pedido.OfType<Dados.Venda>().FirstOrDefault(a => a.IdPedido == CodVenda);

                //servicos
                foreach (var refOS in item.OrdemServico)
                {
                    var servico = DsModel.Servico.NewServicoRow();
                    servico.CodOrdemServico = refOS.IdOrdemServico;
                    servico.CodServico = refOS.IdServico;
                    servico.CodVenda = refOS.IdPedido;
                    servico.Nome = refOS.Servico.Nome;
                    servico.NomeAbertura = refOS.NomeAbertura;
                    servico.Album = refOS.Album == null ? "Nenhum" : refOS.Album.Nome;
                    servico.Moldura = refOS.Moldura == null ? "Nenhum" : refOS.Moldura.Nome;
                    servico.Observacoes = refOS.Observacao;
                    servico.QuantImagem = refOS.OrdemServicoItem.Count;

                    servico.CodVenda = item.IdPedido;
                    servico.CodAtendimento = item.IdAtendimento;
                    servico.Cliente = item.CliFor.Nome;
                    servico.DataEmissao = item.DataEmissao.GetValueOrDefault();
                    servico.CodigoReduzido = item.Atendimento.CodigoReduzido.ToString();
                    servico.Logo = Utilitarios.Comum.GetLogoReport();

                    //adiciona no dataset
                    DsModel.Servico.AddServicoRow(servico);

                    //adidiona imagens
                    foreach (var refItem in refOS.OrdemServicoItem)
                    {
                        var imagem = DsModel.ServicoItem.NewServicoItemRow();
                        imagem.CodItem = refItem.IdItem;
                        imagem.CodServico = refItem.OrdemServico.IdOrdemServico;
                        imagem.CodImagem = refItem.IdFoto;
                        imagem.Imagem = refItem.Foto.Nome;
                        imagem.Sessao = refItem.Foto.Sessao.NumSessao;
                        imagem.Quantidade = refItem.Quantidade;
                        imagem.Efeito = refItem.EfeitoDigital == null ? "Nenhum" : refItem.EfeitoDigital.Nome;
                        imagem.Observacao = refItem.Observacao;


                        //adiciona no dataset
                        DsModel.ServicoItem.AddServicoItemRow(imagem);
                    }
                }
            }
        }

        private void CarregaRelatorio()
        {
            try
            {
                //configura o relatorio
                Relatorio report = new Relatorio();

                //carrega dados
                report.SetDataSource(DsModel);

                //carrega o report viewer
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Zoom(100);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
