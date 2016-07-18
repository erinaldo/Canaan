using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class Tamanho
    {
        public int IdTamanho { get; set; }
        public int IdEmpresa { get; set; }
        public string Nome { get; set; }
        public decimal Altura { get; set; }
        public decimal Largura { get; set; }
        public bool IsPersonalizado { get; set; }

        //relacionamentos
        public Empresa Empresa { get; set; }
    }
}
