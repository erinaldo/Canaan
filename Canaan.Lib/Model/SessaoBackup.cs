using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib.Model
{
    public class SessaoBackup
    {
        public bool Selecionado { get; set; }
        public int IdSessao { get; set; }
        public int IdAtendimento { get; set; }
        public int Atendimento { get; set; }
        public DateTime Data { get; set; }
        public int NumSessao { get; set; }
        public TimeSpan Tempo { get; set; }
        public int QuantidadeFotos { get; set; }
        public decimal Tamanho { get; set; }

    }
}
