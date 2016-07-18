using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdGrupo { get; set; }
        public int IdEmpresa { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool IsAtivo { get; set; }

        //relacionamentos
        public Grupo Grupo { get; set; }
        public Empresa Empresa { get; set; }
    }
}
