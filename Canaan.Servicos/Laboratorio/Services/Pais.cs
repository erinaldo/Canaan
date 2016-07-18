using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class Pais
    {
        public static List<Models.Pais> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("pais", Method.GET);
            var response = client.Execute<List<Models.Pais>>(request);

            return response.Data;
        }

        public static Models.Pais GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("pais/{id}", Method.GET);

            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.Pais>(request);

            return response.Data;
        }
    }
}
