using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados
{
    [MetadataType(typeof(CidadeMetadata))]
    public partial class Cidade { }

    public class CidadeMetadata
    {
        public object IdCidade { get; set; }
        public object IdEstado { get; set; }

        [Filter]
        public object Nome { get; set; }
        public object IsAtivo { get; set; }
    }
}
