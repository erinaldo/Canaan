using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Services
{
    public class EnvelopeMovimentacao
    {
        public static List<Models.EnvelopeMovimentacao> Get()
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("envelopemovimentacao", Method.GET);
            var response = client.Execute<List<Models.EnvelopeMovimentacao>>(request);

            return response.Data;
        }

        public static Models.EnvelopeMovimentacao GetById(int id)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("envelopemovimentacao/{id}", Method.GET);

            //configura o request
            request.AddUrlSegment("id", id.ToString());

            var response = client.Execute<Models.EnvelopeMovimentacao>(request);

            return response.Data;
        }

        public static List<Models.EnvelopeMovimentacao> GetByEnvelope(int idEnvelope)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("envelopemovimentacao/findbyenvelope/{id}", Method.GET);

            request.AddUrlSegment("id", idEnvelope.ToString());

            var response = client.Execute<List<Models.EnvelopeMovimentacao>>(request);

            return response.Data;
        }

        public static List<Models.EnvelopeMovimentacao> GetByStatus(int idStatus)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("envelopemovimentacao/findbystatus/{id}", Method.GET);

            request.AddUrlSegment("id", idStatus.ToString());

            var response = client.Execute<List<Models.EnvelopeMovimentacao>>(request);

            return response.Data;
        }

        public static List<Models.EnvelopeMovimentacao> GetByUsuario(int idUsuario)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("envelopemovimentacao/findbyusuario/{id}", Method.GET);

            request.AddUrlSegment("id", idUsuario.ToString());

            var response = client.Execute<List<Models.EnvelopeMovimentacao>>(request);

            return response.Data;
        }


        public static Models.EnvelopeMovimentacao Insert(Models.EnvelopeMovimentacao item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("envelopemovimentacao", Method.POST);

            //configura o request
            request.AddJsonBody(item);

            var response = client.Execute<Models.EnvelopeMovimentacao>(request);

            return response.Data;
        }

        public static Models.EnvelopeMovimentacao Update(Models.EnvelopeMovimentacao item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("envelopemovimentacao/{id}", Method.PUT);

            //configura o request
            request.AddUrlSegment("id", item.IdMovimentacao.ToString());
            request.AddJsonBody(item);

            var response = client.Execute<Models.EnvelopeMovimentacao>(request);

            return response.Data;
        }

        public static Models.EnvelopeMovimentacao Delete(Models.EnvelopeMovimentacao item)
        {
            var client = new RestClient(Properties.Settings.Default.ApiAddress);
            var request = new RestRequest("envelopemovimentacao/{id}", Method.DELETE);

            //configura o request
            request.AddUrlSegment("id", item.IdMovimentacao.ToString());

            var response = client.Execute(request);

            return item;
        }
    }
}
