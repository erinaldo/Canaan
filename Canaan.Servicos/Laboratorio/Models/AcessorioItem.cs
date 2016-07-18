using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class AcessorioItem
    {
        public int IdItem { get; set; }
        public int IdAcessorio { get; set; }
        public string Nome { get; set; }
        public string Referencia { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public bool IsFotografico { get; set; }
        public bool IsRevestimento { get; set; }

        //relacionamentos
        public Acessorio Acessorio { get; set; }
    }
}
