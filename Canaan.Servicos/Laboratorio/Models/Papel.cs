using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class Papel
    {
        public int IdPapel { get; set; }
        public int IdEmpresa { get; set; }
        public string Nome { get; set; }
        public decimal Desconto { get; set; }
        public decimal Acrescimo { get; set; }
        public bool IsDefault { get; set; }

        //relacionamento
        public Empresa Empresa { get; set; }
    }
}
