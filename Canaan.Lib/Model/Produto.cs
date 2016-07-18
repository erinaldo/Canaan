using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib.Model
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Tabela { get; set; }

        public string Valor { get; set; }

        public bool Status { get; set; }

        public int Quantidade { get; set; }

        //Valor que é utilizado para alteração do valor atual da coleção
        public decimal Preco { get; set; }

        [Browsable(false)]
        public Dados.Produto Prod { get; set; }
    }
}
