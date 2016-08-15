using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.CService.Telas.Integracao.Fechamento
{
    public partial class Lista : Form
    {
        #region PROPRIEDADES

        public List<PedidoProducao> Pedidos { get; set; }

        #endregion

        #region CONSTRUTORES

        public Lista()
        {
            this.Pedidos = new List<PedidoProducao>();
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Lista_Load(object sender, EventArgs e)
        {

        }

        private void consultaButton_Click(object sender, EventArgs e)
        {
            CarregaLista();
        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            EnviaEmail();
        }

        #endregion

        #region METODOS

        private void CarregaLista() 
        {
            var baseURL = new Uri("http://cpc.canaanfotos.com.br/cpanel/producao/entrada/");
            var dataInicio = string.Format("{0}-{1}-{2}", inicioDateTimePicker.Value.Year.ToString(), inicioDateTimePicker.Value.Month.ToString(), inicioDateTimePicker.Value.Day.ToString());
            var dataFim = string.Format("{0}-{1}-{2}", fimDateTimePicker.Value.Year.ToString(), fimDateTimePicker.Value.Month.ToString(), fimDateTimePicker.Value.Day.ToString());

            using (var client = new HttpClient()) 
            {
                client.BaseAddress = baseURL;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = Task.Run(() => client.GetAsync(dataInicio + "/" + dataFim)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var r = Task.Run(() => response.Content.ReadAsStringAsync()).Result;
                    this.Pedidos = JsonConvert.DeserializeObject<List<PedidoProducao>>(r);

                    this.footerLabel.Text = string.Format("Total: {0:c}", this.Pedidos.Sum(a => a.ValorTotal));

                    this.pedidosDataGridView.Rows.Clear();

                    foreach (var pedido in this.Pedidos)
                    {
                        foreach (var item in pedido.Itens) 
                        { 
                            //var row = new DataGridViewRow();
                            
                            //DataGridViewCell item1;
                            //item1.Value = pedido.Cliente;
                            //row.Cells.Add(item1);

                            //DataGridViewCell item2;
                            //item2.Value = pedido.Cidade;
                            //row.Cells.Add(item2);

                            //DataGridViewCell item3;
                            //item3.Value = item.Produto;
                            //row.Cells.Add(item3);

                            //DataGridViewCell item4;
                            //item4.Value = item.Quantidade;
                            //row.Cells.Add(item4);

                            //DataGridViewCell item5;
                            //item5.Value = item.ValorTotal;
                            //row.Cells.Add(item5);

                            //row.Cells[0].Value = pedido.Cliente;
                            //row.Cells[1].Value = pedido.Cidade;
                            //row.Cells[2].Value = item.Produto;
                            //row.Cells[3].Value = item.Quantidade;
                            //row.Cells[4].Value = item.ValorTotal;

                            this.pedidosDataGridView.Rows.Add(new object[] { pedido.Cliente, pedido.Cidade, item.Produto, item.Quantidade, item.ValorTotal });
                        }
                    }
                }
            }
        }

        private void EnviaEmail() 
        {
            try
            {
                //configura o email
                MailMessage objMessage = new MailMessage();
                SmtpClient objSmtp = new SmtpClient();
                NetworkCredential objCredencial = new NetworkCredential();

                //configura credenciais
                objCredencial.UserName = "job@canaanfotos.com.br";
                objCredencial.Password = "cemail1234";

                //configura mensagem
                objMessage.From = new MailAddress("job@canaanfotos.com.br");

                //adiciona destinatarios
                //foreach (var contato in to)
                //{
                //    objMessage.To.Add(contato);
                //}
                objMessage.To.Add("jobvitral@gmail.com");
                objMessage.To.Add("alessandro@canaanfotos.com.br");
                objMessage.To.Add("admilson@canaanfotos.com.br");
                objMessage.To.Add("karine@canaanalbuns.com.br");
                objMessage.To.Add("atendimento@canaanalbuns.com.br");

                //informações das mensagens
                objMessage.Subject = "Encadernação Entrada de Produção";
                objMessage.IsBodyHtml = true;
                objMessage.Body = MontaEmail();

                //envia a mensagem
                objSmtp.Host = "smtp.canaanfotos.com.br";
                objSmtp.Port = 587;

                objSmtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                objSmtp.EnableSsl = false;

                objSmtp.Credentials = objCredencial;
                objSmtp.Send(objMessage);

                MessageBox.Show("Emails enviados com sucesso.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private string MontaEmail() 
        {
            var body = "";
            var color = "#ffffff";

            body += "<table>";
            body += "<tr>";
            body += "   <td style='padding:5px' colspan='4'>";
            body +=         string.Format("<b>Data do Relatório: {0} - {1}</b>", inicioDateTimePicker.Value.ToShortDateString(), fimDateTimePicker.Value.ToShortDateString());
            body += "   </td>";
            body += "</tr>";

            foreach (var pedido in this.Pedidos)
            {
                body += "<tr style='background-color: "+ color  +"'>";
                body += "   <td style='padding:5px; vertical-align: top'>";
                body +=         string.Format("{0}", pedido.Cliente);
                body += "   </td>";
                body += "   <td style='padding:5px; vertical-align: top'>";
                body +=         string.Format("{0}", pedido.Cidade);
                body += "   </td>";
                body += "   <td style='padding:5px; vertical-align: top'>";
                body +=         string.Format("{0}", GetItens(pedido));
                body += "   </td>";
                body += "   <td style='padding:5px; vertical-align: top'>";
                body +=         string.Format("{0:c}", pedido.ValorTotal);
                body += "   </td>";
                body += "</tr>";

                if (color == "#ffffff")
                    color = "#cccccc";
                else
                    color = "#ffffff";
            }

            body += "<tr>";
            body += "   <td style='padding:5px' colspan='4'>";
            body +=         string.Format("<b>Valor Total: {0:c}</b>", this.Pedidos.Sum(a => a.ValorTotal));
            body += "   </td>";
            body += "</tr>";

            body += "</table>";

            return body;
        }

        private string GetItens(PedidoProducao pedido)
        {
            var itens = "";

            foreach (var item in pedido.Itens)
            {
                itens += item.Produto + "<br>";
            }

            return itens;
        }

        #endregion
    }
}
