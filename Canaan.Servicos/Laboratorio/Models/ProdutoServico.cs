using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class ProdutoServico
    {
        public int IdProdutoServico { get; set; }
        public int IdProduto { get; set; }
        public int IdServico { get; set; }

        //relacionamentos
        public Produto Produto { get; set; }
        public Servico Servico { get; set; }
    }
}
