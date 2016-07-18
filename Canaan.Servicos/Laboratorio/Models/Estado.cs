using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class Estado
    {
        public int IdEstado { get; set; }
        public int IdPais { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public string DDD { get; set; }

        //relacionamentos
        public Pais Pai { get; set; }
    }
}
