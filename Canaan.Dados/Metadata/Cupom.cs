using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados
{
    [MetadataType(typeof(CupomMetadata))]
    public partial class Cupom { }

    public class CupomMetadata
    {
        public object IdCupom { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IdParceria { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IdUsuario { get; set; }

        public object Data { get; set; }

        public object DataPreenchimento { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Status { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Nome { get; set; }

        public object Email { get; set; }

        public object Endereco { get; set; }

        [Filter]
        public object Telefone { get; set; }

        [Filter]
        public object Celular { get; set; }

        public object Obs { get; set; }

        public object IsAtivo { get; set; }


        public object TelemarketingStatus { get; set; }
        public object UsuarioTele { get; set; }

        [FilterAttribute]
        public object Parceria { get; set; }
        public object Usuario { get; set; }
    }
}
