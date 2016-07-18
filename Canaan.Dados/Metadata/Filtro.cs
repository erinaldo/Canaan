using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados.Metadata
{
    [MetadataType(typeof(FiltroMetadata))]
    public partial class Filtro{}

    public class FiltroMetadata
    {
        [Required(ErrorMessage="{0} é Obrigatório")]
        public object Nome { get; set; }
    }

}
