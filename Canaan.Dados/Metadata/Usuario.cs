using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados
{
    [MetadataType(typeof(UsuarioMetadata))]
    public partial class Usuario 
    {
        public string FullName 
        { 
            get
            {
                return string.Format("{0} {1}", Nome, Sobrenome);
            }
        }
    }

    public class UsuarioMetadata
    {
    }
}
