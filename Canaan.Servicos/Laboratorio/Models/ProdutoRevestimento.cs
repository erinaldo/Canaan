using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class ProdutoRevestimento
    {
        public int IdProdutoRevestimento { get; set; }
        public int IdProduto { get; set; }
        public int IdRevestimento { get; set; }

        //relacionamentos
        public Produto Produto { get; set; }
        public Revestimento Revestimento { get; set; }
    }
}
