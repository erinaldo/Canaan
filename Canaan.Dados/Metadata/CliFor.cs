using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados
{
    [MetadataType(typeof(CliForMetadata))]
    public partial class CliFor { }

    public class CliForMetadata
    {
        [Filter]
        public object IdCliFor { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Endereco { get; set; }

        [Filter]
        public object Cidade { get; set; }

        [Filter]
        public object Tipo  { get; set; }

        [Filter]
        public object Nome { get; set; }

        [Filter]
        public object Documento { get; set; }

    }
}


