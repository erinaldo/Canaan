using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class ProdutoAcessorio
    {
        public int IdProdutoAcessorio { get; set; }
        public int IdProduto { get; set; }
        public int IdAcessorio { get; set; }

        //relacionamentos
        public Produto Produto { get; set; }
        public Acessorio Acessorio { get; set; }
    }
}
