using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class PedidoImagem
    {
        public int IdPedidoImagem { get; set; }
        public int IdPedido { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Caminho { get; set; }
        public string Thumbnail { get; set; }
        public string Observacoes { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        //relacionamentos
        public Pedido Pedido { get; set; }
    }
}
