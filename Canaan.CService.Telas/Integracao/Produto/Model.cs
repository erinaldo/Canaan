using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.CService.Telas.Integracao.Produto
{
    public class Model
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public static List<Model> Get() 
        {
            using (var conn = new RM.Dados.CorporeEntities()) 
            {
                var result = new List<Model>();
                var coligada = Properties.Settings.Default.Coligada;
                var filial = Properties.Settings.Default.Filial;
                var lista = conn.TPRD.Where(a => a.CODCOLIGADA == coligada && a.TIPO == "S" && a.INATIVO == 0 && a.ULTIMONIVEL == 1 && a.PRECO3 > 0);

                foreach (var item in lista)
                {
                    result.Add(new Model
                    {
                        Codigo = item.IDPRD,
                        Nome = item.NOMEFANTASIA,
                        Valor = item.PRECO3.GetValueOrDefault()
                    });
                }

                return result;
            }
        }
    }
}
