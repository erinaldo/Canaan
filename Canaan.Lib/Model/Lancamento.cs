using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib.Model
{
    public class Lancamento
    {

        public int IdPedido { get; set; }

        [Browsable(false)]
        public int IdLan { get; set; }

        [Browsable(false)]
        public int IdCliFor { get; set; }

        [ReadOnly(true)]
        public string Cliente { get; set; }

        [Browsable(false)]
        public int IdFilial { get; set; }

        [ReadOnly(true)]
        public string Filial { get; set; }

        [ReadOnly(true)]
        public Dados.EnumLancTipo Tipo { get; set; }

        [ReadOnly(true)]
        public Dados.EnumClasseContabil ClasseContabil { get; set; }

        [ReadOnly(true)]
        public DateTime DataEmissao { get; set; }

        public DateTime? DataVencimento { get; set; }
        
        [Browsable(false)]
        public DateTime DataAgendamento { get; set; }

        [ReadOnly(true)]
        public decimal ValorOriginal { get; set; }

        [ReadOnly(true)]
        [Browsable(false)]
        public decimal ValorDesconto { get; set; }

        [ReadOnly(true)]
        [Browsable(false)]
        public decimal ValorAcrescimo { get; set; }

        [ReadOnly(true)]
        [Browsable(false)]
        public decimal ValorLiquido { get; set; }

        public Bitmap TipoParcela { get; set; }
    }
}
