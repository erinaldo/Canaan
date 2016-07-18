using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Dados
{
    [MetadataType(typeof(LancamentoMetadata))]
    public partial class Lancamento { }

    public class LancamentoMetadata
    {
        [FilterAttribute]
        [Key]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object IdLancamento { get; set; }

        [FilterAttribute]
        [Range(1, int.MaxValue, ErrorMessage = "Campo Cliente / Fornecedor é obrigatório")]
        public object IdCliFor { get; set; }

        [FilterAttribute]
        [Range(1, int.MaxValue, ErrorMessage = "Campo Filial é obrigatório")]
        public object IdFilial { get; set; }

        [FilterAttribute]
        [Range(1, int.MaxValue, ErrorMessage = "Campo Conta Caixa é obrigatório")]
        public object IdContaCaixa { get; set; }

        [FilterAttribute]
        public object IdPedido { get; set; }

        [FilterAttribute]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Tipo { get; set; }

        [FilterAttribute]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object Status { get; set; }

        [FilterAttribute]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object ClasseContabil { get; set; }

        [FilterAttribute]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object DataEmissao { get; set; }

        [FilterAttribute]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object DataVencimento { get; set; }

        [FilterAttribute]
        public object DataBaixa { get; set; }

        [FilterAttribute]
        public object DataAgendamento { get; set; }

        [FilterAttribute]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object ValorOriginal { get; set; }

        [FilterAttribute]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object ValorJuros { get; set; }

        [FilterAttribute]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object ValorMulta { get; set; }

        [FilterAttribute]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object ValorDesconto { get; set; }

        [FilterAttribute]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object ValorAcrescimo { get; set; }

        [FilterAttribute]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public object ValorLiquido { get; set; }

        [FilterAttribute]
        public object ValorBaixado { get; set; }

        [FilterAttribute]
        public object NossoNumero { get; set; }

        [FilterAttribute]
        public object Ipte { get; set; }

        [FilterAttribute]
        public object CodigoBarras { get; set; }

        [FilterAttribute]
        public object IsEntrada { get; set; }

        [FilterAttribute]
        public object Pedido { get; set; }


        
    }
}
