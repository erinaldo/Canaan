using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib.Model.Envio
{
    public class OrdemServicoEnvioModel
    {

        public OrdemServicoEnvioModel()
        {
            OrdensServicoItem = new List<OrdemServicoItemEnvioModel>();
        }

        public int IdEnvelopeCpc { get; set; }

        public int IdOrdem { get; set; }

        public int ? IdCService { get; set; }

        public int IdFilialEstudio { get; set; }

        public EnumStatusEnvio Status { get; set; }

        public int CodigoReduzido { get; set; }

        public int CodigoCliente { get; set; }

        public int CodEnvelope { get; set; }

        public int CodVenda { get; set; }

        public int NumFotos { get; set; }

        public DateTime? DataVenda { get; set; }

        public DateTime DataEnvio { get; set; }

        public DateTime? DataPrevista { get; set; }

        public string NomeCliente { get; set; }

        public string NomeVendedora { get; set; }

        public string NomeEnvio { get; set; }

        public string NomeAbertura { get; set; }

        public string Album { get; set; }

        public string Moldura { get; set; }

        public string Servico { get; set; }

        public string Obs { get; set; }

        public bool Faturado { get; set; }

        public bool Distribuido { get; set; }

        public DateTime DataStatus { get; set; }

        public DateTime ? DataStatusPrevista { get; set; }

        public bool Expedicao { get; set; }

        public List<OrdemServicoItemEnvioModel> OrdensServicoItem { get; set; }

    }
}
