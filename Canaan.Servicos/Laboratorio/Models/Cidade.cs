using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class Cidade
    {
        public int IdCidade { get; set; }
        public int IdEstado { get; set; }
        public string Nome { get; set; }

        //relacionamentos
        public Estado Estado { get; set; }
    }
}
