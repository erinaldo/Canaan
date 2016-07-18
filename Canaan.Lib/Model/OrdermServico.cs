using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib.Model
{
    public class OrdermServico
    {
        public int Codigo { get; set; }

        [Browsable(false)]
        public int IdVenda { get; set; }

        [Browsable(false)]
        public int IdServico { get; set; }

        public string Servico { get; set; }

        public string Album { get; set; }

        public string Moldura { get; set; }

        public int Fotos { get; set; }

        public Bitmap Status { get; set; }

        public string StatusItem { get; set; }

        [Browsable(false)]
        //Identifica o produto relacionado com esta ordem de servico
        public int IdProduto { get; set; }
    }
}
