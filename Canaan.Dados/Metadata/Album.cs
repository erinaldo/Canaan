using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados
{
    [MetadataType(typeof(AlbumMetadata))]
    public partial class Album { }

    public class AlbumMetadata
    {
        public int IdAlbum { get; set; }

        [Filter]
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string Nome { get; set; }

        public bool IsAtivo { get; set; }
    }
}
