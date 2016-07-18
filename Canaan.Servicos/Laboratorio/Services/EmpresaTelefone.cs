using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class EmpresaTelefone
    {
        public static List<Models.EmpresaTelefone> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("empresatelefone", Method.GET);
            var response = client.Execute<List<Models.EmpresaTelefone>>(request);

            return response.Data;
        }

        public static Models.EmpresaTelefone GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("empresatelefone/{id}", Method.GET);

            //configura o request
            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.EmpresaTelefone>(request);

            return response.Data;
        }

        public static List<Models.EmpresaTelefone> GetByEmpresa(int idEmpresa)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("empresatelefone/findbyempresa/{id}", Method.GET);

            request.AddUrlSegment("id", idEmpresa.ToString());

            var response = client.Execute<List<Models.EmpresaTelefone>>(request);

            return response.Data;
        }

        public static List<Models.EmpresaTelefone> GetByTelefone(int idEmpresa)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("empresatelefone/findbytelefone/{id}", Method.GET);

            request.AddUrlSegment("id", idEmpresa.ToString());

            var response = client.Execute<List<Models.EmpresaTelefone>>(request);

            return response.Data;
        }
    }
}
