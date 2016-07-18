using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados
{
    [MetadataType(typeof(ContaCaixaMetadata))]
    public partial class ContaCaixa { }

    public class ContaCaixaMetadata
    {
        [Key]
        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IdContaCaixa { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IdFilial { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IdConta { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Nome { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IsCaixa { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IsPadrao { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IsAtivo { get; set; }
    }
}
