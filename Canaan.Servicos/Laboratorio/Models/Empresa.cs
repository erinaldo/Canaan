using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class Empresa
    {
        public int IdEmpresa { get; set; }
        public int IdEndereco { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string InscEstadual { get; set; }
        public string Email { get; set; }
        public string SmtpEndereco { get; set; }
        public string SmtpUsuario { get; set; }
        public string SmtpSenha { get; set; }
        public int SmtpPorta { get; set; }
        public bool SmtpSSL { get; set; }

        //relacionamentos
        public Endereco Endereco { get; set; }
    }
}
