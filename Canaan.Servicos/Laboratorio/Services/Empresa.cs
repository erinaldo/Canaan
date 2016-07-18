using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class Empresa
    {
        public static List<Models.Empresa> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("empresa", Method.GET);
            var response = client.Execute<List<Models.Empresa>>(request);

            return response.Data;
        }

        public static Models.Empresa GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("empresa/{id}", Method.GET);

            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.Empresa>(request);

            return response.Data;
        }
    }
}
