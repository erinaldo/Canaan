using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class Pedido
    {
        public static List<Models.Pedido> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("pedido", Method.GET);
            var response = client.Execute<List<Models.Pedido>>(request);

            return response.Data;
        }

        public static Models.Pedido GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("pedido/{id}", Method.GET);

            //configura o request
            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.Pedido>(request);

            return response.Data;
        }

        public static List<Models.Pedido> GetByCliente(int idCliente)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("pedido/findbycliente/{id}", Method.GET);

            request.AddUrlSegment("id", idCliente.ToString());

            var response = client.Execute<List<Models.Pedido>>(request);

            return response.Data;
        }


        public static Models.Pedido Insert(Models.Pedido item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("pedido", Method.POST);

            //configura o request
            request.AddJsonBody(item);

            var response = client.Execute<Models.Pedido>(request);

            return response.Data;
        }

        public static Models.Pedido Update(Models.Pedido item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("pedido/{id}", Method.PUT);

            //configura o request
            request.AddUrlSegment("id", item.IdPedido.ToString());
            request.AddJsonBody(item);

            var response = client.Execute<Models.Pedido>(request);

            return response.Data;
        }

        public static Models.Pedido Delete(Models.Pedido item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("pedido/{id}", Method.DELETE);

            //configura o request
            request.AddUrlSegment("id", item.IdPedido.ToString());

            var response = client.Execute(request);

            return item;
        }
    }
}
