using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class Estado
    {
        public static List<Models.Estado> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("estado", Method.GET);
            var response = client.Execute<List<Models.Estado>>(request);

            return response.Data;
        }

        public static Models.Estado GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("estado/{id}", Method.GET);

            //configura o request
            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.Estado>(request);

            return response.Data;
        }

        public static List<Models.Estado> GetByPais(int idPais)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("estado/findbypais/{id}", Method.GET);

            request.AddUrlSegment("id", idPais.ToString());

            var response = client.Execute<List<Models.Estado>>(request);

            return response.Data;
        }
    }
}
