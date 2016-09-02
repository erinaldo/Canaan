using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AceJundiai.Socket
{
    public class Request
    {
        public string Ip { get; set; }
        public int Port { get; set; }
        public TcpClient Client { get; set; }
        public NetworkStream Stream { get; set; }

        public Request()
        {
            this.Ip = "integra.boavistaservicos.com.br";
            this.Port = 5020;

            Client = new TcpClient(this.Ip, this.Port);
        }

        public Request(string ip)
        {
            this.Ip = ip;
            this.Port = 5020;

            Client = new TcpClient(this.Ip, this.Port);
        }

        public Request(string ip, int porta)
        {
            this.Ip = ip;
            this.Port = porta;

            Client = new TcpClient(this.Ip, this.Port);
        }

        public string SendRequest(string msg, Enums.Tipo tipo)
        {
            switch (tipo)
            {
                case Enums.Tipo.Regitrar:
                    if (msg.Length != 745)
                    {
                        throw new Exception("Mensagem para registro inválida");
                    }
                    else
                    {
                        //Envia Mensagem
                        SendRequest(msg);

                        //Envia retorno da resposta
                        return RequestReturn(Enums.Tipo.RetornoRegistro);
                    }
                case Enums.Tipo.Consultar:
                    if (msg.Length != 50)
                    {
                        throw new Exception("Mensagem para consulta inválida");
                    }
                    else
                    {
                        //Envia Mensagem
                        SendRequest(msg);

                        //Envia retorno da resposta
                        return RequestReturn(Enums.Tipo.RespostaConsulta);
                    }
                default:
                    throw new Exception("Erro Desconhecido");
            }

        }

        private void SendRequest(string msg)
        {
            //Cria Buffer para armazenar mensagem
            var sendBuffer = Encoding.ASCII.GetBytes(msg);

            Stream = Client.GetStream();

            //Envia Mensagem
            Stream.Write(sendBuffer, 0, sendBuffer.Length);
        }

        private string RequestReturn(Enums.Tipo tipo)
        {
            int totalBytesReceived = 0;
            var responseBuffer = new byte[(int)tipo];

            while (totalBytesReceived < responseBuffer.Length)
            {
                var bytesReceived = Stream.Read(responseBuffer, 0, (int)tipo);
                totalBytesReceived = totalBytesReceived + bytesReceived;
            }

            return Encoding.ASCII.GetString(responseBuffer, 0, totalBytesReceived);
        }
    }
}
