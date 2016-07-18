using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Relatorios.ViewModel.Base
{
    public class AtendimentoModel
    {
        public int CodReduzido { get; set; }
        public int IdAtendimento { get; set; }
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string DataRecepcao { get; set; }

        public static List<AtendimentoModel> GetByAtendimento(int codReduzido, int codFilial)
        {
            var result = new Lib.Atendimento().GetByCodigoReduzidoAndFilial(codReduzido, codFilial);

            return CarregaLista(result);
        }

        public static List<AtendimentoModel> GetByNome(string nome, int codFilial)
        {
            var result = new Lib.Atendimento().GetByNomeAndFilial(nome, codFilial);

            return CarregaLista(result);
        }

        private static List<AtendimentoModel> CarregaLista(List<Dados.Atendimento> atendimento)
        {
            try
            {
                var lista = new List<AtendimentoModel>();

                foreach (var item in atendimento)
                {
                    var atend = new AtendimentoModel();
                    atend.CodReduzido = item.CodigoReduzido;
                    atend.IdAtendimento = item.IdAtendimento;
                    atend.IdCliente = item.IdCliFor;
                    atend.Nome = item.CliFor.Nome;
                    atend.DataRecepcao = item.Data.ToShortDateString();

                    lista.Add(atend);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }

    public class ModeloModel
    {
        public int IdModelo { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Nascimento { get; set; }
        public int Idade { get; set; }

        public static List<ModeloModel> GetByAtendimento(int idAtendimento)
        {
            var result = new Lib.Modelo().GetByAtendimento(idAtendimento);

            return CarregaLista(result);
        }

        private static List<ModeloModel> CarregaLista(List<Dados.Modelo> modelo)
        {
            var lista = new List<ModeloModel>();

            foreach (var item in modelo)
            {
                var model = new ModeloModel();
                model.IdModelo = item.IdModelo;
                model.Nome = item.NomeCompleto;
                model.Cpf = item.Cpf;
                model.Nascimento = item.Nascimento.ToShortDateString();
                model.Idade = Lib.Utilitarios.Comum.CalculaIdade(item.Nascimento);

                lista.Add(model);
            }

            return lista;
        }
    }
}
