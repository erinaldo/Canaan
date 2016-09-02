using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Relatorios.Programadas.Carta
{
    public class Model
    {
        public int CodCmaster { get; set; }
        public string CodRM { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataVencimento { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
    }
}
