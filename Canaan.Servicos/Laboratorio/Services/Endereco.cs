using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class Endereco
    {
        public static List<Models.Endereco> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("endereco", Method.GET);
            var response = client.Execute<List<Models.Endereco>>(request);

            return response.Data;
        }

        public static Models.Endereco GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("endereco/{id}", Method.GET);

            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.Endereco>(request);

            return response.Data;
        }


        public static Models.Endereco Insert(Models.Endereco item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("endereco", Method.POST);

            //configura o request
            request.AddJsonBody(item);

            var response = client.Execute<Models.Endereco>(request);

            return response.Data;
        }

        public static Models.Endereco Update(Models.Endereco item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("endereco/{id}", Method.PUT);

            //configura o request
            request.AddUrlSegment("id", item.IdEndereco.ToString());
            request.AddJsonBody(item);

            var response = client.Execute<Models.Endereco>(request);

            return response.Data;
        }

        public static Models.Endereco Delete(Models.Endereco item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("endereco/{id}", Method.DELETE);

            //configura o request
            request.AddUrlSegment("id", item.IdEndereco.ToString());

            var response = client.Execute(request);

            return item;
        }
    }
}
