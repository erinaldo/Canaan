using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class Cidade
    {
        public static List<Models.Cidade> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("cidade", Method.GET);
            var response = client.Execute<List<Models.Cidade>>(request);

            return response.Data;
        }

        public static Models.Cidade GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("cidade/{id}", Method.GET);

            //configura o request
            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.Cidade>(request);

            return response.Data;
        }

        public static List<Models.Cidade> GetByEstado(int idEstado)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("cidade/findbyestado/{id}", Method.GET);

            request.AddUrlSegment("id", idEstado.ToString());

            var response = client.Execute<List<Models.Cidade>>(request);

            return response.Data;
        }
    }
}
