using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib.Model
{
    public class ProdutoServico
    {
        public int Codigo { get; set; }
        public int IdProduto { get; set; }
        public int IdServico { get; set; }
        public string Servico { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public int Previsao { get; set; }
    }
}

