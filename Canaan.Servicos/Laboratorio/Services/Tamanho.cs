using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class Tamanho
    {
        public static List<Models.Tamanho> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("tamanho", Method.GET);
            var response = client.Execute<List<Models.Tamanho>>(request);

            return response.Data;
        }

        public static Models.Tamanho GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("tamanho/{id}", Method.GET);

            //configura o request
            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.Tamanho>(request);

            return response.Data;
        }

        public static List<Models.Tamanho> GetByEmpresa(int idEmpresa)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("tamanho/findbyempresa/{id}", Method.GET);

            request.AddUrlSegment("id", idEmpresa.ToString());

            var response = client.Execute<List<Models.Tamanho>>(request);

            return response.Data;
        }
    }
}
