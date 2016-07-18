using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class Acessorio
    {
        public int IdAcessorio { get; set; }
        public int IdEmpresa { get; set; }
        public string Nome { get; set; }
        public string Grupo { get; set; }

        //relacionamentos
        public Empresa Empresa { get; set; }
    }
}
