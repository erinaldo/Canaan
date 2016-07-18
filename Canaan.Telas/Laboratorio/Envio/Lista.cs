using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Telas.Laboratorio.Envio
{
    public partial class Lista : Form
    {
        public List<Dados.EnvioPedido> Pedidos { get; set; }
        public List<Model> ListaPedidos { get; set; }
        public Dados.Config Config { get; set; }

        public Lista()
        {
            this.ListaPedidos = new List<Model>();
            this.Config = new Lib.Config().Get().FirstOrDefault();

            InitializeComponent();
        }

        private void Init()
        {
            gridPedidos.AutoGenerateColumns = false;

            CarregaPedidos();
            CarregaGrid();
        }

        private void CarregaPedidos()
        {
            var libPedidos = new Lib.EnvioPedido();

            this.Pedidos = libPedidos.GetByStatus(false);
        }

        private void CarregaGrid()
        {
            //limpa a lista
            this.ListaPedidos.Clear();

            //carrega a lista com os pedidos atuais
            foreach (var item in this.Pedidos)
            {
                this.ListaPedidos.Add(new Envio.Model
                {
                    IdEnvio = item.IdEnvio.GetValueOrDefault(),
                    IdPedido = item.IdEnvioPedido,
                    Cliente = item.Cliente,
                    Produto = string.Format("{0} - {1}", item.Categoria, item.Produto),
                    Tamanho = item.Tamanho,
                    Imagens = item.EnvioImagem.Count,
                    Status = StatusEnvio.Aguardando,
                    Mensagem = "Aguardando envio"
                });
            }

            //carrega o grid
            gridPedidos.DataSource = this.ListaPedidos;
            gridPedidos.ClearSelection();
        }

        private Servicos.Laboratorio.Models.Pedido InsertPedido(Dados.EnvioPedido pedido)
        {
            var item = new Servicos.Laboratorio.Models.Pedido();
            item.IdCliente = this.Config.CServiceId.GetValueOrDefault();
            item.NomeCliente = pedido.Cliente;
            item.Categoria = pedido.Categoria;
            item.Produto = pedido.Produto;
            item.Tamanho = pedido.Tamanho;
            item.Detalhes = pedido.Detalhes;
            item.Observacoes = pedido.Observacoes;
            item.DataEntrada = DateTime.Now;
            item.DataPrevista = DateTime.Now.AddDays(20).Date;

            if (pedido.IdEnvio != null)
            {
                var codigoReduzido = new Lib.Venda().GetById(pedido.Envio.IdPedido).Atendimento.CodigoReduzido;
                item.CampoLivre1 = codigoReduzido.ToString();
                item.CampoLivre2 = pedido.Envio.IdPedido.ToString();
                item.CampoLivre3 = pedido.IdEnvio.ToString();
            }
            
            item.CampoLivre4 = pedido.IdEnvioPedido.ToString();
            item.IsImpresso = false;
            item.IsEnviado = false;
            item.IsFaturado = false;

            var result = Servicos.Laboratorio.Services.Pedido.Insert(item);

            return result;
        }

        private Servicos.Laboratorio.Models.PedidoImagem InsertImagem(int idPedido, Dados.EnvioImagem imagem)
        {
            var item = new Servicos.Laboratorio.Models.PedidoImagem();
            item.IdPedido = idPedido;
            item.Tipo = imagem.Tipo;
            item.Nome = imagem.Nome;
            item.Caminho = string.Format(@"{0}/{1}", idPedido, item.Nome);
            item.Thumbnail = string.Format(@"{0}/thumbs/{1}", idPedido, item.Nome);
            item.Observacoes = "";
            item.Width = 0;
            item.Height = 0;

            var result = Servicos.Laboratorio.Services.PedidoImagem.Insert(item);

            return result;
        }

        private void AlteraStatus(Dados.EnvioPedido pedido)
        {
            var libPedido = new Lib.EnvioPedido();

            libPedido.UpdateStatus(pedido);
        }

        private void ProcessaEnvio()
        {
            var indice = 0;
            var countPedidos = this.Pedidos.Count;

            foreach (var item in this.Pedidos)
            {
                var progressPedido = indice * 100 / countPedidos;

                //salva o pedido no cpc
                pedidoWorker.ReportProgress(progressPedido, new ReportModel
                {
                    Indice = indice,
                    Mensagem = string.Format("Salvando pedido {0} - {1}", item.Categoria, item.Produto),
                    Status = StatusEnvio.Enviando,
                    Progress = 0
                });
                var pedido = InsertPedido(item);

                //salva as imagens
                var indiceImage = 0;
                var countImage = item.EnvioImagem.Count;

                foreach (var imagem in item.EnvioImagem)
                {
                    //reporta
                    var progress = indiceImage * 100 / countImage;
                    pedidoWorker.ReportProgress(progressPedido, new ReportModel
                    {
                        Indice = indice,
                        Mensagem = string.Format("Enviando {0} - {1}: {2} de {3} -> {4}", item.Categoria, item.Produto, indiceImage + 1, countImage, imagem.Nome),
                        Status = StatusEnvio.Enviando,
                        Progress = progress
                    });

                    //faz upload da imagem
                    Servicos.Laboratorio.Services.PedidoImagem.Upload(pedido.IdPedido, imagem.Caminho);

                    //salva imagem no banco de dados
                    var novaImagem = InsertImagem(pedido.IdPedido, imagem);

                    //incrementa indice
                    indiceImage++;
                }

                //marca pedido como enviado
                pedidoWorker.ReportProgress(progressPedido, new ReportModel
                {
                    Indice = indice,
                    Mensagem = string.Format("Pedido {0} - {1} enviado", item.Categoria, item.Produto),
                    Status = StatusEnvio.Enviado,
                    Progress = indiceImage
                });

                //altera o status do pedido
                AlteraStatus(item);

                //incrementa indice
                indice++;
            }
        }



        private void Lista_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void pedidoWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcessaEnvio();
        }

        private void pedidoWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var report = (ReportModel)e.UserState;

            statusProgressBar.Value = report.Progress;
            statusLabel.Text = report.Mensagem;
            gridPedidos.Rows[report.Indice].Cells["Status"].Value = report.Status;
        }

        private void pedidoWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            statusProgressBar.Value = 0;
            statusLabel.Text = "Pedidos enviados com sucesso";

            CarregaPedidos();
            CarregaGrid();
        }

        private void btnExecuta_Click(object sender, EventArgs e)
        {
            pedidoWorker.RunWorkerAsync();
        }
    }
}
