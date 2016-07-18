using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class Status
    {
        public int IdStatus { get; set; }
        public string Nome { get; set; }
        public bool IsLaboratorio { get; set; }
        public bool IsImpressao { get; set; }
        public bool IsProducao { get; set; }
        public bool IsFinalizado { get; set; }
        public bool IsEnviado { get; set; }
        public bool IsRepeticao { get; set; }
        public bool IsDefault { get; set; }
        public bool IsAtivo { get; set; }
    }
}
