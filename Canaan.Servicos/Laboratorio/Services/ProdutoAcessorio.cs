using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class ProdutoAcessorio
    {
        public static List<Models.ProdutoAcessorio> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtoacessorio", Method.GET);
            var response = client.Execute<List<Models.ProdutoAcessorio>>(request);

            return response.Data;
        }

        public static Models.ProdutoAcessorio GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtoacessorio/{id}", Method.GET);

            //configura o request
            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.ProdutoAcessorio>(request);

            return response.Data;
        }

        public static List<Models.ProdutoAcessorio> GetByProduto(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtoacessorio/findbyproduto/{id}", Method.GET);

            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<List<Models.ProdutoAcessorio>>(request);

            return response.Data;
        }

        public static List<Models.ProdutoAcessorio> GetByAcessorio(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtoacessorio/findbyacessorio/{id}", Method.GET);

            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<List<Models.ProdutoAcessorio>>(request);

            return response.Data;
        }
    }
}
