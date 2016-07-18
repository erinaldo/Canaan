using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class Usuario
    {
        public static List<Models.Usuario> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("usuario", Method.GET);
            var response = client.Execute<List<Models.Usuario>>(request);

            return response.Data;
        }

        public static Models.Usuario GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("usuario/{id}", Method.GET);

            //configura o request
            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.Usuario>(request);

            return response.Data;
        }

        public static List<Models.Usuario> GetByEmpresa(int idEmpresa)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("usuario/findbyempresa/{id}", Method.GET);

            request.AddUrlSegment("id", idEmpresa.ToString());

            var response = client.Execute<List<Models.Usuario>>(request);

            return response.Data;
        }

        public static List<Models.Usuario> GetByGrupo(int idEmpresa)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("usuario/findbygrupo/{id}", Method.GET);

            request.AddUrlSegment("id", idEmpresa.ToString());

            var response = client.Execute<List<Models.Usuario>>(request);

            return response.Data;
        }

        public static List<Models.Usuario> GetByLogin(string username, string password)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("usuario/{username}/{password}", Method.GET);

            request.AddUrlSegment("username", username);
            request.AddUrlSegment("password", password);

            var response = client.Execute<List<Models.Usuario>>(request);

            return response.Data;
        }
    }
}
