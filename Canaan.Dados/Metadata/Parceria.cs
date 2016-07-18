using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados
{
    [MetadataType(typeof(ParceriaMetadata))]
    public partial class Parceria
    {
    }

    public class ParceriaMetadata
    {
        public object IdParceria { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IdConvenio { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IdFilial { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [Filter(Nome="Nome")]
        public string Nome { get; set; }

        [Filter(Nome = "Descricao")]
        public object Descricao { get; set; }
        
        [Filter(Nome = "Data Inicio")]
        public object DataInicio { get; set; }

        public object DataFim { get; set; }

        public object DataRetirada { get; set; }

        public object ContatoNome { get; set; }

        public object ContatoTel { get; set; }

        public object ContatoCel { get; set; }

        public object ContatoEmail { get; set; }

        public object IsRetirada { get; set; }

        [Filter(Nome = "Status")]
        public object IsAtivo { get; set; }


        //Navigations

        [Filter(Nome = "Convenio")]
        public object Convenio { get; set; }

        [Filter(Nome = "Filial")]
        public object Filial { get; set; }

        public object Cupom { get; set; }
    }

}
