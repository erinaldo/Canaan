using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class Revestimento
    {
        public int IdRevestimento { get; set; }
        public int IdEmpresa { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }

        //relacionamentos
        public Empresa Empresa { get; set; }
    }
}
