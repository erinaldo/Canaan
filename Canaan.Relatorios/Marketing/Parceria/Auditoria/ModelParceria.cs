using System;
using System.Collections.Generic;
using System.Linq;

namespace Canaan.Relatorios.Marketing.Parceria.Auditoria
{
    public class ModelParceria
    {
        public int IdParceria { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime DataRetirada { get; set; }
        public bool Retirada { get; set; }
        public string Contato { get; set; }
        public string Telefone { get; set; }
        public DateTime Previsao { get; set; }
        public string Status { get; set; }


        public static IEnumerable<ModelParceria> ToModel(IEnumerable<Dados.Parceria> parcerias)
        {
            return parcerias.Select(a => new ModelParceria
            {
                IdParceria = a.IdParceria,
                Nome = a.Nome.ToUpper(),
                DataInicio = a.DataInicio.GetValueOrDefault(),
                DataFim = a.DataFim.GetValueOrDefault(),
                DataRetirada = a.DataRetirada.GetValueOrDefault(),
                Contato = !string.IsNullOrEmpty(a.ContatoNome) ? a.ContatoNome.ToUpper() : string.Empty,
                Telefone = Lib.Utilitarios.Comum.FormataTelefone(a.ContatoTel),
                Retirada = a.IsRetirada,
                Previsao = a.DataInicio.Value.AddDays(30),
                Status = DateTime.Today > a.DataInicio.Value.AddDays(30) ? "Vencida" : "Valida"
            });
        }

    }
}