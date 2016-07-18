using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados
{
    [MetadataType(typeof(ContaMetadata))]
    public partial class Conta { }

    public class ContaMetadata
    {
        [Key]
        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IdConta { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IdAgencia { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Nome { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object ContaNumero { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object ContaDigito { get; set; }
        
        public object CarteiraNumero { get; set; }
        
        public object CarteiraDigito { get; set; }
        
        public object CedenteNome { get; set; }
        
        public object CedenteCnjp { get; set; }
        
        public object CedenteNumero { get; set; }
        
        public object CedenteDigito { get; set; }
        
        public object ConvenioNumero { get; set; }
        
        public object ConvenioDigito { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object TipoConta { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object TipoCobranca { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IsAtivo { get; set; }
    }
}
