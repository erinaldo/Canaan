using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class ClienteTelefone
    {
        public int IdClienteTelefone { get; set; }
        public int IdCliente { get; set; }
        public int IdTelefone { get; set; }
        public bool IsPrincipal { get; set; }

        //relacionamentos
        public Cliente Cliente { get; set; }
        public Telefone Telefone { get; set; }
    }
}
