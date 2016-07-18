using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class ClienteTelefone
    {
        public static List<Models.ClienteTelefone> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("clientetelefone", Method.GET);
            var response = client.Execute<List<Models.ClienteTelefone>>(request);

            return response.Data;
        }

        public static Models.ClienteTelefone GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("clientetelefone/{id}", Method.GET);

            //configura o request
            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.ClienteTelefone>(request);

            return response.Data;
        }

        public static List<Models.ClienteTelefone> GetByCliente(int idCliente)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("clientetelefone/findbycliente/{id}", Method.GET);

            request.AddUrlSegment("id", idCliente.ToString());

            var response = client.Execute<List<Models.ClienteTelefone>>(request);

            return response.Data;
        }

        public static List<Models.ClienteTelefone> GetByTelefone(int idTelefone)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("clientetelefone/findbytelefone/{id}", Method.GET);

            request.AddUrlSegment("id", idTelefone.ToString());

            var response = client.Execute<List<Models.ClienteTelefone>>(request);

            return response.Data;
        }


        public static Models.ClienteTelefone Insert(Models.ClienteTelefone item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("clientetelefone", Method.POST);

            //configura o request
            request.AddJsonBody(item);

            var response = client.Execute<Models.ClienteTelefone>(request);

            return response.Data;
        }

        public static Models.ClienteTelefone Update(Models.ClienteTelefone item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("clientetelefone/{id}", Method.PUT);

            //configura o request
            request.AddUrlSegment("id", item.IdClienteTelefone.ToString());
            request.AddJsonBody(item);

            var response = client.Execute<Models.ClienteTelefone>(request);

            return response.Data;
        }

        public static Models.ClienteTelefone Delete(Models.ClienteTelefone item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("clientetelefone/{id}", Method.DELETE);

            //configura o request
            request.AddUrlSegment("id", item.IdClienteTelefone.ToString());

            var response = client.Execute(request);

            return item;
        }
    }
}
