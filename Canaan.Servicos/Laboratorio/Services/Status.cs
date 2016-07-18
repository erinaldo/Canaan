using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class Status
    {
        public static List<Models.Status> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("status", Method.GET);
            var response = client.Execute<List<Models.Status>>(request);

            return response.Data;
        }

        public static Models.Status GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("status/{id}", Method.GET);

            //configura o request
            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.Status>(request);

            return response.Data;
        }


        public static Models.Status Insert(Models.Status item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("status", Method.POST);

            //configura o request
            request.AddJsonBody(item);

            var response = client.Execute<Models.Status>(request);

            return response.Data;
        }

        public static Models.Status Update(Models.Status item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("status/{id}", Method.PUT);

            //configura o request
            request.AddUrlSegment("id", item.IdStatus.ToString());
            request.AddJsonBody(item);

            var response = client.Execute<Models.Status>(request);

            return response.Data;
        }

        public static Models.Status Delete(Models.Status item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("status/{id}", Method.DELETE);

            //configura o request
            request.AddUrlSegment("id", item.IdStatus.ToString());

            var response = client.Execute(request);

            return item;
        }
    }
}
