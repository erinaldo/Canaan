using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados
{
    [MetadataType(typeof(FilialMetadata))]
    public partial class Filial
    {
    }

    public class FilialMetadata
    {
        [Filter]
        public object IdFilial { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IdGrupoEmpresa { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IdCidade { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object RazaoSocial { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object NomeFantasia { get; set; }

        [Filter]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Cnpj { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Endereco { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Numero { get; set; }
        
        public object Complemento { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Bairro { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Cep { get; set; }

        public object Email { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Telefone { get; set; }

        public object Celular { get; set; }

        public object Fax { get; set; }

        public object IsAtivo { get; set; }
    }

}
