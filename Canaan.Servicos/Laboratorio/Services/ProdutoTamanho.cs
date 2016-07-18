using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class ProdutoTamanho
    {
        public static List<Models.ProdutoTamanho> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtotamanho", Method.GET);
            var response = client.Execute<List<Models.ProdutoTamanho>>(request);

            return response.Data;
        }

        public static Models.ProdutoTamanho GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtotamanho/{id}", Method.GET);

            //configura o request
            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.ProdutoTamanho>(request);

            return response.Data;
        }

        public static List<Models.ProdutoTamanho> GetByProduto(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtotamanho/findbyproduto/{id}", Method.GET);

            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<List<Models.ProdutoTamanho>>(request);

            return response.Data;
        }

        public static List<Models.ProdutoTamanho> GetByPapel(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtotamanho/findbytamanho/{id}", Method.GET);

            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<List<Models.ProdutoTamanho>>(request);

            return response.Data;
        }
    }
}
