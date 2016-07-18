using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Servicos.Laboratorio.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public int IdEmpresa { get; set; }
        public int IdCategoria { get; set; }
        public string Nome { get; set; }
        public string Referencia { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal QuantMinima { get; set; }
        public decimal QuantPadrao { get; set; }
        public bool PermReducao { get; set; }
        public string TipoValor { get; set; }
        public bool IsAlbum { get; set; }
        public bool IsCapaFotografica { get; set; }
        public bool HasCapa { get; set; }
        public bool HasBloco { get; set; }
        public bool HasEmbalagem { get; set; }
        public bool IsAtivo { get; set; }

        //relacionamentos
        public Empresa Empresa { get; set; }
        public ProdutoCategoria ProdutoCategorium { get; set; }
    }
}
