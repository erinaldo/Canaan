using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class ProdutoCategoria
    {
        public static List<Models.ProdutoCategoria> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtocategoria", Method.GET);
            var response = client.Execute<List<Models.ProdutoCategoria>>(request);

            return response.Data;
        }

        public static Models.ProdutoCategoria GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtocategoria/{id}", Method.GET);

            //configura o request
            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.ProdutoCategoria>(request);

            return response.Data;
        }

        public static List<Models.ProdutoCategoria> GetByEmpresa(int idEmpresa)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produtocategoria/findbyempresa/{id}", Method.GET);

            request.AddUrlSegment("id", idEmpresa.ToString());

            var response = client.Execute<List<Models.ProdutoCategoria>>(request);

            return response.Data;
        }
    }
}
