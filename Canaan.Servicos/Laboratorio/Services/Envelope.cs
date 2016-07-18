using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class Envelope
    {
        public static List<Models.Envelope> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("envelope", Method.GET);
            var response = client.Execute<List<Models.Envelope>>(request);

            return response.Data;
        }

        public static Models.Envelope GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("envelope/{id}", Method.GET);

            //configura o request
            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.Envelope>(request);

            return response.Data;
        }

        public static List<Models.Envelope> GetByPedido(int idPedido)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("envelope/findbypedido/{id}", Method.GET);

            request.AddUrlSegment("id", idPedido.ToString());

            var response = client.Execute<List<Models.Envelope>>(request);

            return response.Data;
        }

        public static List<Models.Envelope> GetByStatus(int idStatus)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("envelope/findbystatus/{id}", Method.GET);

            request.AddUrlSegment("id", idStatus.ToString());

            var response = client.Execute<List<Models.Envelope>>(request);

            return response.Data;
        }


        public static Models.Envelope Insert(Models.Envelope item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("envelope", Method.POST);

            //configura o request
            request.AddJsonBody(item);

            var response = client.Execute<Models.Envelope>(request);

            return response.Data;
        }

        public static Models.Envelope Update(Models.Envelope item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("envelope/{id}", Method.PUT);

            //configura o request
            request.AddUrlSegment("id", item.IdEnvelope.ToString());
            request.AddJsonBody(item);

            var response = client.Execute<Models.Envelope>(request);

            return response.Data;
        }

        public static Models.Envelope Delete(Models.Envelope item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("envelope/{id}", Method.DELETE);

            //configura o request
            request.AddUrlSegment("id", item.IdEnvelope.ToString());

            var response = client.Execute(request);

            return item;
        }
    }
}
