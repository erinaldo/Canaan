using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados
{
    [MetadataType(typeof(VendaMetadata))]
    public partial class Venda { }

    public class VendaMetadata
    {

        public object IdAtendimento { get; set; }
        public object IdFormaEntrada { get; set; }
        [Filter]
        public object Status { get; set; }
        public object ValorEntrada { get; set; }
        [Filter]
        public object DataVenda { get; set; }
        public object IsFaturado { get; set; }
        [Filter]
        public object DataFaturamento { get; set; }
        public object IsLiberado { get; set; }
        [Filter]
        public object DataLiberacao { get; set; }
        public object IsDevolvida { get; set; }
        public object DataDevolucao { get; set; }


        [Filter]
        public virtual object Atendimento { get; set; }

        [Filter]
        public virtual object FormaEntrada { get; set; }
    }
}
