using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados
{
    [MetadataType(typeof(LancamentoMovMetadata))]
    public partial class LancamentoMov { }

    public class LancamentoMovMetadata
    {
        [FilterAttribute]
        [Key]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IdMov { get; set; }

        [FilterAttribute]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IdLancamento { get; set; }

        [FilterAttribute]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IdUsuario { get; set; }

        [FilterAttribute]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Data { get; set; }

        [FilterAttribute]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Status { get; set; }
    }
}
