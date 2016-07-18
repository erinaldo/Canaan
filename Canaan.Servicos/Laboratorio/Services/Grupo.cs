using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class Grupo
    {
        public static List<Models.Grupo> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("grupo", Method.GET);
            var response = client.Execute<List<Models.Grupo>>(request);

            return response.Data;
        }

        public static Models.Grupo GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("grupo/{id}", Method.GET);

            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.Grupo>(request);

            return response.Data;
        }
    }
}
