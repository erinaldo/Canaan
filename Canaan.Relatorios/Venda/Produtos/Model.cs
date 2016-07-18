using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Canaan.Relatorios.Venda.Produtos
{
    public class Model
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Total { get; set; }

        public int Quantidade { get; set; }
        public byte[] Logo { get; set; }
    }
}
