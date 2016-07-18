using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados
{
    [MetadataType(typeof(PedidoMetadata))]
    public partial class Pedido { }

    public class PedidoMetadata
    {
        [Filter]
        public object Data { get; set; }
        [Filter]
        public object DataEmissao { get; set; }
        [Filter]
        public object ClasseContabil { get; set; }
        [Filter]
        public object ValorBruto { get; set; }
        [Filter]
        public object ValorDesconto { get; set; }
        [Filter]
        public object ValorAcrescimo { get; set; }

    }
}
