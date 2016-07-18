using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib.Model
{
    public class Servico
    {       
        public int IdServico { get; set; }
        public string Nome { get; set; }
        public int Previsao { get; set; }
        public bool Album { get; set; }
        public bool Moldura { get; set; }
        public bool Voltagem { get; set; }
        public bool Brinde { get; set; }
        public bool Ativo { get; set; }
    }
}
