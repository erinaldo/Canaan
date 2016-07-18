using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class PedidoImagem
    {
        public static List<Models.PedidoImagem> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("pedidoimagem", Method.GET);
            var response = client.Execute<List<Models.PedidoImagem>>(request);

            return response.Data;
        }

        public static Models.PedidoImagem GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("pedidoimagem/{id}", Method.GET);

            //configura o request
            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.PedidoImagem>(request);

            return response.Data;
        }

        public static List<Models.PedidoImagem> GetByPedido(int idPedido)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("pedidoimagem/findbypedido/{id}", Method.GET);

            request.AddUrlSegment("id", idPedido.ToString());

            var response = client.Execute<List<Models.PedidoImagem>>(request);

            return response.Data;
        }


        public static Models.PedidoImagem Insert(Models.PedidoImagem item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("pedidoimagem", Method.POST);

            //configura o request
            request.AddJsonBody(item);

            var response = client.Execute<Models.PedidoImagem>(request);

            return response.Data;
        }

        public static Models.PedidoImagem Update(Models.PedidoImagem item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("pedidoimagem/{id}", Method.PUT);

            //configura o request
            request.AddUrlSegment("id", item.IdPedidoImagem.ToString());
            request.AddJsonBody(item);

            var response = client.Execute<Models.PedidoImagem>(request);

            return response.Data;
        }

        public static Models.PedidoImagem Delete(Models.PedidoImagem item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("pedidoimagem/{id}", Method.DELETE);

            //configura o request
            request.AddUrlSegment("id", item.IdPedidoImagem.ToString());

            var response = client.Execute(request);

            return item;
        }


        public static string Upload(int idPedido, string imagem)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("pedidoimagem/upload/{id}", Method.POST);

            //configura o request
            request.AddUrlSegment("id", idPedido.ToString());
            request.AddFile("file", imagem);

            var response = client.Execute(request);

            return response.ToString();
        }
    }
}
