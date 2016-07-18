using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class Acessorio
    {
        public static List<Models.Acessorio> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("acessorio", Method.GET);
            var response = client.Execute<List<Models.Acessorio>>(request);

            return response.Data;
        }

        public static Models.Acessorio GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("acessorio/{id}", Method.GET);

            //configura o request
            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.Acessorio>(request);

            return response.Data;
        }

        public static List<Models.Acessorio> GetByEmpresa(int idEmpresa)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("acessorio/findbyempresa/{id}", Method.GET);

            request.AddUrlSegment("id", idEmpresa.ToString());

            var response = client.Execute<List<Models.Acessorio>>(request);

            return response.Data;
        }
    }
}
