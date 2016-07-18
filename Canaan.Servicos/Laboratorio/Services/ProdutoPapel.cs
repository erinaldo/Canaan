using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class ProdutoPapel
    {
        public static List<Models.ProdutoPapel> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtopapel", Method.GET);
            var response = client.Execute<List<Models.ProdutoPapel>>(request);

            return response.Data;
        }

        public static Models.ProdutoPapel GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtopapel/{id}", Method.GET);

            //configura o request
            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.ProdutoPapel>(request);

            return response.Data;
        }

        public static List<Models.ProdutoPapel> GetByProduto(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtopapel/findbyproduto/{id}", Method.GET);

            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<List<Models.ProdutoPapel>>(request);

            return response.Data;
        }

        public static List<Models.ProdutoPapel> GetByPapel(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtopapel/findbypapel/{id}", Method.GET);

            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<List<Models.ProdutoPapel>>(request);

            return response.Data;
        }
    }
}
