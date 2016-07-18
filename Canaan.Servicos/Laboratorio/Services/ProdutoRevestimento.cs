using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class ProdutoRevestimento
    {
        public static List<Models.ProdutoRevestimento> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtorevestimento", Method.GET);
            var response = client.Execute<List<Models.ProdutoRevestimento>>(request);

            return response.Data;
        }

        public static Models.ProdutoRevestimento GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtorevestimento/{id}", Method.GET);

            //configura o request
            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.ProdutoRevestimento>(request);

            return response.Data;
        }

        public static List<Models.ProdutoRevestimento> GetByProduto(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtorevestimento/findbyproduto/{id}", Method.GET);

            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<List<Models.ProdutoRevestimento>>(request);

            return response.Data;
        }

        public static List<Models.ProdutoRevestimento> GetByRevestimento(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtorevestimento/findbyrevestimento/{id}", Method.GET);

            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<List<Models.ProdutoRevestimento>>(request);

            return response.Data;
        }
    }
}
