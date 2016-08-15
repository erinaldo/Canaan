using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.FtpClient;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Envio
{
    public class FtpEnvio
    {
        public FtpClient Client { get; set; }

        public Lib.Config LibConfig
        {
            get
            {
                return new Lib.Config();
            }
        }

        public Dados.Config Config { get; set; }

        public Dados.Filial Filial { get; set; }

        public FtpEnvio(FtpClient client, Dados.Filial pFilial)
        {
            Filial = pFilial;
            Config = LibConfig.GetByFilial(this.Filial.IdFilial);
            this.Client = client;
        }

        public bool Connect(bool isDatabase)
        {
            if (isDatabase)
            {
                Client.Host = Config.FtpHost;
                Client.Credentials = new NetworkCredential(Config.FtpUser, Config.FtpPass);
                Client.Connect();
            }
            else
            {
                Client.Host = Config.FtpHost;
                Client.Credentials = new NetworkCredential(Config.FtpUser, Config.FtpPass);
                Client.Connect();
            }
            

            return Client.IsConnected;
        }

        public bool Disconnect() 
        {
            Client.Disconnect();

            return Client.IsConnected;
        }


        public void CreateDirectory(string path)
        {
            if(!Client.DirectoryExists(path))
            {
                Client.CreateDirectory(path, true);
            }
        }
    }
}
