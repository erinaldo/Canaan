using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib.Model.Envio
{
    public class EnvioModel
    {
        public EnvioModel()
        {
            OrdensEnvio = new List<OrdemServicoEnvioModel>();
        }

        public bool Selecionado { get; set; }

        public int  IdEnvio { get; set; }

        public int IdVenda { get; set; }

        public int IdFilial { get; set; }

        public int IdAtendimento { get; set; }

        public int CodigoReduzido { get; set; }

        public string Cliente { get; set; }

        public string NomeEnvio { get; set; }

        public DateTime ? DataVenda { get; set; }

        public bool ? LibEscrit { get; set; }

        public bool LibGerente { get; set; }

        public Decimal ? Valor { get; set; }

        public Bitmap Icone { get; set; }

        public List<OrdemServicoEnvioModel> OrdensEnvio { get; set; }

    }
}
