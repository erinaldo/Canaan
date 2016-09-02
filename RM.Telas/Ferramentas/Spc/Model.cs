using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Telas.Ferramentas.Spc
{
    public class ModelFiltro 
    {
        public CPanel.Dados.filiais Filial { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public TipoAcao Tipo { get; set; }
    }

    public class ModelLista
    {
        public bool IsChecked { get; set; }
        public int IdLan { get; set; }
        public int IdMov { get; set; }
        public string CodCliente { get; set; }
        public string ClasseContabil { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataBaixa { get; set; }
        public decimal ValorOriginal { get; set; }
        public decimal ValorBaixado { get; set; }
    }

    public class ModelDetalhe
    {

    }

    public enum TipoAcao
    {
        Registro,
        Reabilitacao
    }
}
