using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class Telefone
    {
        public static List<Models.Telefone> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("telefone", Method.GET);
            var response = client.Execute<List<Models.Telefone>>(request);

            return response.Data;
        }

        public static Models.Telefone GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("telefone/{id}", Method.GET);

            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.Telefone>(request);

            return response.Data;
        }
    }
}
