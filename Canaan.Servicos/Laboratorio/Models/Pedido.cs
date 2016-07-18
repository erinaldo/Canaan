using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string Categoria { get; set; }
        public string Produto { get; set; }
        public string Tamanho { get; set; }
        public string Detalhes { get; set; }
        public string Observacoes { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataPrevista { get; set; }
        public DateTime DataEntrega { get; set; }
        public string CampoLivre1 { get; set; }
        public string CampoLivre2 { get; set; }
        public string CampoLivre3 { get; set; }
        public string CampoLivre4 { get; set; }
        public string CampoLivre5 { get; set; }
        public bool IsImpresso { get; set; }
        public bool IsEnviado { get; set; }
        public bool IsFaturado { get; set; }

        //relacionamentos
        public Cliente Cliente { get; set; }
    }
}
