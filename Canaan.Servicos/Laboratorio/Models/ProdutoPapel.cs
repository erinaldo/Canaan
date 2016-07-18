using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class ProdutoPapel
    {
        public int IdProdutoPapel { get; set; }
        public int IdProduto { get; set; }
        public int IdPapel { get; set; }

        //relacionamentos
        public Produto Produto { get; set; }
        public Papel Papel { get; set; }
    }
}
