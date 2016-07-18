using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class ProdutoServico
    {
        public static List<Models.ProdutoServico> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtoservico", Method.GET);
            var response = client.Execute<List<Models.ProdutoServico>>(request);

            return response.Data;
        }

        public static Models.ProdutoServico GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtoservico/{id}", Method.GET);

            //configura o request
            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.ProdutoServico>(request);

            return response.Data;
        }

        public static List<Models.ProdutoServico> GetByProduto(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtoservico/findbyproduto/{id}", Method.GET);

            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<List<Models.ProdutoServico>>(request);

            return response.Data;
        }

        public static List<Models.ProdutoServico> GetByPapel(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtoservico/findbyservico/{id}", Method.GET);

            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<List<Models.ProdutoServico>>(request);

            return response.Data;
        }
    }
}
