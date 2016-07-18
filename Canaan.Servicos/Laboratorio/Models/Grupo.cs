using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class Grupo
    {
        public int IdGrupo { get; set; }
        public string Nome { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsGerente { get; set; }
        public bool IsSupervisor { get; set; }
        public bool IsPadrao { get; set; }
    }
}
