using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados
{
    [MetadataType(typeof(AgenciaMetadata))]
    public partial class Agencia { }

    public class AgenciaMetadata
    {

        public object IdAgencia { get; set; }
        public object IdBanco { get; set; }
        public object IdCidade { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [Filter]
        public object Nome { get; set; }

        [Filter]
        public object Telefone { get; set; }

        [Filter]
        public object Celular { get; set; }

        [Filter]
        public object Gerente { get; set; }

        [Filter]
        public object Email { get; set; }

        [Filter]
        public object IsAtivo { get; set; }

        //Navigarions
        [Filter]
        public virtual Banco Banco { get; set; }

        [Filter]
        public virtual Cidade Cidade { get; set; }
    }
}
