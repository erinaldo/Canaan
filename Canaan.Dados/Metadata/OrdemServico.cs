using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados
{
    [MetadataType(typeof(OrdemServicoMetadata))]
    public partial class OrdemServico
    {
    }

    public class OrdemServicoMetadata
    {
        //[Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object NomeAbertura { get; set; }
    }
}
