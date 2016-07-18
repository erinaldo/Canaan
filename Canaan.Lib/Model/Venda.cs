using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib.Model
{
    public class Venda
    {
        public bool Selected { get; set; }
        public int Codigo { get; set; }
        public int Atendimento { get; set; }
        public string Cliente { get; set; }
        public string Preco { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataDevolucao { get; set; }
        public Dados.EnumStatusVenda Status { get; set; }
    }
}
