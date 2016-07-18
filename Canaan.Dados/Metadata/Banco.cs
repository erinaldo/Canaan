using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados
{
    [MetadataType(typeof(BancoMetadata))]
    public partial class Banco { }

    public class BancoMetadata
    {
        [FilterAttribute]
        [Key]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IdBanco { get; set; }

        [FilterAttribute]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Nome { get; set; }

        [FilterAttribute]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Abreviacao { get; set; }

        [FilterAttribute]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Numero { get; set; }

        [FilterAttribute]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Digito { get; set; }

        [FilterAttribute]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IsAtivo { get; set; }

    }
}
