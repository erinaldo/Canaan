using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class EmpresaTelefone
    {
        public int IdEmpresaTelefone { get; set; }
        public int IdEmpresa { get; set; }
        public int IdTelefone { get; set; }
        public bool IsPrincipal { get; set; }

        //relacionamentos
        public Empresa Empresa { get; set; }
        public Telefone Telefone { get; set; }
    }
}
