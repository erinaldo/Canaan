using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPanel.Telas.Lancamento
{
    public class ListaViewModel
    {
        public int Codigo { get; set; }
        public int Dia { get; set; }
        public decimal Entrada { get; set; }
        public decimal Prazo { get; set; }
        public decimal Vista { get; set; }
        public decimal Faturamento { get; set; }
        public decimal Comissao { get; set; }
        public decimal Fluxo { get; set; }
        public int Fotografado { get; set; }

        public static List<ListaViewModel> Get(List<Dados.lancamentos> lancamentos) 
        {
            var lista = new List<ListaViewModel>();

            foreach (var item in lancamentos)
            {
                var model = new ListaViewModel();
                model.Codigo = item.id_lancamento;
                model.Dia = item.dia.Value;
                model.Entrada = item.venda_entradas.Value;
                model.Prazo = item.venda_prazo.Value;
                model.Vista = item.venda_vista.Value;
                model.Faturamento = item.faturamento.Value;
                model.Comissao = item.fluxo_caixa.Value;
                model.Fotografado = item.fotografados.Value;

                lista.Add(model);
            }

            return lista;
        }
    }
}
