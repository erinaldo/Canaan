using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class Cliente
    {
        public static List<Models.Cliente> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("cliente", Method.GET);
            var response = client.Execute<List<Models.Cliente>>(request);

            return response.Data;
        }

        public static Models.Cliente GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("cliente/{id}", Method.GET);

            //configura o request
            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.Cliente>(request);

            return response.Data;
        }

        public static List<Models.Cliente> GetByEmpresa(int idEmpresa)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("cliente/findbyempresa/{id}", Method.GET);

            request.AddUrlSegment("id", idEmpresa.ToString());

            var response = client.Execute<List<Models.Cliente>>(request);

            return response.Data;
        }


        public static Models.Cliente Insert(Models.Cliente item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("cliente", Method.POST);

            //configura o request
            request.AddJsonBody(item);

            var response = client.Execute<Models.Cliente>(request);

            return response.Data;
        }

        public static Models.Cliente Update(Models.Cliente item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("cliente/{id}", Method.PUT);

            //configura o request
            request.AddUrlSegment("id", item.IdCliente.ToString());
            request.AddJsonBody(item);

            var response = client.Execute<Models.Cliente>(request);

            return response.Data;
        }

        public static Models.Cliente Delete(Models.Cliente item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("cliente/{id}", Method.DELETE);

            //configura o request
            request.AddUrlSegment("id", item.IdCliente.ToString());

            var response = client.Execute(request);

            return item;
        }


        public static string Upload(string imagem)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("cliente/upload/{id}", Method.POST);

            //configura o request
            request.AddUrlSegment("id", "0");
            request.AddFile("file", imagem);

            var response = client.Execute(request);

            return response.ToString();
        }
    }
}
