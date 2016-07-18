using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib.Model
{
    public class MotivoDevolucaoModel
    {
        public int IdMotivoDevolucao { get; set; }

        public Dados.EnumMotivoDevolucao IdMotivo { get; set; }

        public string Observacao { get; set; }

        public int Quantidade { get; set; }

        public string Motivo { get; set; }
    }
}
