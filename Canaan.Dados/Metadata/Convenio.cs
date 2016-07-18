using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados
{
    [MetadataType(typeof(ConvenioMetadata))]
    public partial class Convenio{}

    public class ConvenioMetadata
    {
        public object IdConvenio { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Nome { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Tipo { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IsAtivo { get; set; }
    }
}
