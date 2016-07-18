using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados
{
    [MetadataType(typeof(EfeitoDigitalMetadata))]
    public partial class EfeitoDigital{}

    public class EfeitoDigitalMetadata
    {
        public object IdEfeito { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Nome { get; set; }

        [Browsable(false)]
        public object IsAtivo { get; set; }

        [Browsable(false)]
        public virtual object OrdemServicoItem { get; set; }
    }
}
