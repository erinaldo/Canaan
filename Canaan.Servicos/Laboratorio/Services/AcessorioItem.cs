using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class AcessorioItem
    {
        public static List<Models.AcessorioItem> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("acessorioitem", Method.GET);
            var response = client.Execute<List<Models.AcessorioItem>>(request);

            return response.Data;
        }

        public static Models.AcessorioItem GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("acessorioitem/{id}", Method.GET);

            //configura o request
            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.AcessorioItem>(request);

            return response.Data;
        }

        public static List<Models.AcessorioItem> GetByAcessorio(int idEmpresa)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("acessorioitem/findbyacessorio/{id}", Method.GET);

            request.AddUrlSegment("id", idEmpresa.ToString());

            var response = client.Execute<List<Models.AcessorioItem>>(request);

            return response.Data;
        }
    }
}
