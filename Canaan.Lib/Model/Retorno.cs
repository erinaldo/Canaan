using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib.Model
{
    public class Retorno
    {
        public int Codigo { get; set; }
        public string Filial { get; set; }
        public string ContaCaixa { get; set; }
        public DateTime Data { get; set; }
        public string Arquivo { get; set; }
        public int Registros { get; set; }
        public int Erros { get; set; }
        public string Usuario { get; set; }
    }
}
