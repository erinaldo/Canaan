﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public int IdEmpresa { get; set; }
        public int IdEndereco { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string Logomarca { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaCompra { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Token { get; set; }
        public bool IsBloqueado { get; set; }
        public bool IsAtivo { get; set; }

        //relacionamentos
        public Empresa Empresa { get; set; }
        public Endereco Endereco { get; set; }
    }
}
