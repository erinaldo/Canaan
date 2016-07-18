using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados
{
    [MetadataType(typeof(GrupoEmpresaMetadata))]
    public partial class GrupoEmpresa { }

    public class GrupoEmpresaMetadata
    {
        public object IdGrupoEmpresa { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Nome { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Descricao { get; set; }
        public object IsFranquia { get; set; }
        public object IsAtivo { get; set; }
    }
}


