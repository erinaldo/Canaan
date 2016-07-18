using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados
{
    [MetadataType(typeof(AtendimentoMetadata))]
    public partial class Atendimento { }

    public class AtendimentoMetadata
    {

        public object IdAtendimento { get; set; }

        [Required]
        public object IdFilial { get; set; }

        [Required]
        public object IdCliFor { get; set; }

        [Required]
        public object IdAgendamento { get; set; }

        [Required]
        public object IdUsuario { get; set; }

        [Filter]
        [Required]
        public object Data { get; set; }

        [Filter]
        [Required]
        public object IsAtivo { get; set; }

        [Filter]
        [Required]
        public object IsConfirmado { get; set; }

        [Filter]
        public object CodigoReduzido { get; set; }


        //Navigations
        [Filter]
        public virtual object Usuario { get; set; }

        [Filter]
        public virtual object CliFor { get; set; }

        [Filter]
        public virtual object Filial { get; set; }
    }
}
