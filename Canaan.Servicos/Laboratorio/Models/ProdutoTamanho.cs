using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class ProdutoTamanho
    {
        public int IdProdutoTamanho { get; set; }
        public int IdProduto { get; set; }
        public int IdTamanho { get; set; }

        //relacionamentos
        public Produto Produto { get; set; }
        public Tamanho Tamanho { get; set; }
    }
}
