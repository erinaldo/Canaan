using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Lib
{
    public class Enums
    {
        public enum StatusLan : short
        {
            [Description("Em Aberto")]
            EmAberto = 0,

            [Description("Baixado")]
            Baixada = 1,

            [Description("Cancelada")]
            Cancelada = 2,

            [Description("ParcialmenteBaixada")]
            BaixaParcial = 3
        }

        public enum Funcoes : short
        {
            [Description("Vendedor")]
            Vendedor = 0,

            [Description("Comprador")]
            Comprador = 1,

            [Description("Vendedor e Comprador")]
            VendedorComprador = 2,

            [Description("Programador")]
            Programador = 3,

            [Description("Caixa")]
            Caixa = 4,

            [Description("Gerente")]
            Gerente = 5
        }
    }
}
