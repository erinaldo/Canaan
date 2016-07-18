using System;
using System.Collections.Generic;

namespace Canaan.Relatorios.Venda.Produtos
{
    public class ModelFiltro
    {        
        public Dados.Produto Produto { get; set; }

        public List<Dados.Produto> Produtos { get; set; }

        public DateTime DataInicial { get; set; }

        public DateTime DataFinal { get; set; }

        /// <summary>
        /// Filtra todos os produtos
        /// </summary>
        public bool Todos { get; set; }

        /// <summary>
        /// Produto Especifico
        /// </summary>
        public bool Especifico { get; set; }

        public TipoRelatorio TipoRelatorio { get; set; }

    }

    public enum TipoRelatorio
    {
        DevolvidasTodas,
        Liberadas,
        Devolvidas,
        Programadas,
        Todas
    }
}
