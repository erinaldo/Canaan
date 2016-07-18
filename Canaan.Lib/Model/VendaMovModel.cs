using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Canaan.Lib.Model
{
    public class VendaMovModel
    {
        public int IdMov { get; set; }

        public Dados.EnumStatusVenda Status { get; set; }

        public string Usuario { get; set; }

        public int Atendimento { get; set; }

        public DateTime Data { get; set; }
    }
}
