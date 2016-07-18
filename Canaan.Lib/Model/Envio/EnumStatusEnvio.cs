using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib.Model.Envio
{
    public enum EnumStatusEnvio
    {
        NaoDefinido = 0,
        Recepcao = 1,
        Laboratorio = 2,
        Repeticao = 4,
        FotoAcabamento = 6,
        Embalagem = 7,
        Enviado = 8,
        RecebendoImagens = 9,
        PendenciaStudio = 10,
        Impresso = 11,
        ControleQualidade = 12,
        MontagemAlmofada = 13,
        Tecnologia = 14,
        Finalizado = 15,
        Impressao = 16,
        AguardandoManipulacao = 17,
        Manipulacao = 18,
        Manipulado = 19,
        EnviandoManipulacao = 20
    }
}
