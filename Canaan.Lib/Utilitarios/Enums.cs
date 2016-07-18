using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib.Utilitarios
{
    public enum Acao
    {
        Delete = -1,
        Left = -2,
        Right = -3,
        Cancel = -4,
        Error = -5,
        Calculando = -6,
        Diretorios = -7,
        Finalizado = -8
    }

    public enum Direction
    {
        Left,
        Right
    }

    public enum TipoBusca
    {
        Codigo,
        Cpf,
        Nome
    }
    
    public enum TipoVenda
    {
        [Description("Venda com Entrada")]
        ComEntrada = 1,

        [Description("Venda sem Entrada")]
        SemEntrada = 2,

        [Description("À Vista")]
        AVista = 3,

        [Description("Venda Programada")]
        Programada = 4,

        [Description("Cortesia")]
        Cortesia = 5,

        [Description("Concurso/Galeria")]
        ConcursoGaleria = 6,

        [Description("PAB")]
        Acompanhamento = 7
    }

    public enum EnumModulo
    {
        Venda,
        Financeiro,
        Marketing
    }

    public enum EnumTipoMov
    {
        Insert,
        Update,
        Delete
    }

    
}
