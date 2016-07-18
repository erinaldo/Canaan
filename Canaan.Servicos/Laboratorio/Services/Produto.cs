using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class Produto
    {
        public static List<Models.Produto> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produto", Method.GET);
            var response = client.Execute<List<Models.Produto>>(request);

            return response.Data;
        }

        public static Models.Produto GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produto/{id}", Method.GET);

            //configura o request
            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.Produto>(request);

            return response.Data;
        }

        public static List<Models.Produto> GetByEmpresa(int idEmpresa)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produto/findbyempresa/{id}", Method.GET);

            request.AddUrlSegment("id", idEmpresa.ToString());

            var response = client.Execute<List<Models.Produto>>(request);

            return response.Data;
        }

        public static List<Models.Produto> GetByCategoria(int idEmpresa)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produto/findbycategoria/{id}", Method.GET);

            request.AddUrlSegment("id", idEmpresa.ToString());

            var response = client.Execute<List<Models.Produto>>(request);

            return response.Data;
        }

        public static string Upload(string imagem)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("produto/upload/{id}", Method.POST);

            //configura o request
            request.AddUrlSegment("id", "0");
            request.AddFile("file", imagem);

            var response = client.Execute(request);

            return response.ToString();
        }
    }
}
