using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Telas.Laboratorio.Envio
{
    public class Model
    {
        public int IdPedido { get; set; }
        public int IdEnvio { get; set; }
        public string Cliente { get; set; }
        public string Produto { get; set; }
        public string Tamanho { get; set; }
        public int Imagens { get; set; }
        public StatusEnvio Status { get; set; }
        public string Mensagem { get; set; }

        public Model()
        {
            this.Status = StatusEnvio.Aguardando;
        }
    }

    public class ReportModel
    {
        public int Indice { get; set; }
        public string Mensagem { get; set; }
        public StatusEnvio Status { get; set; }
        public int Progress { get; set; }
    }

    public enum StatusEnvio
    {
        Aguardando,
        Enviando,
        Enviado,
        Erro
    }
}
