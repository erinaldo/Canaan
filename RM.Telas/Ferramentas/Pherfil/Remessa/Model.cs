using System;

namespace RM.Telas.Ferramentas.Pherfil.Remessa
{
    public class ModelVenda 
    {
        public int CodVenda { get; set; }
        public short CodColigada { get; set; }
        public short CodFilial { get; set; }
        public string CodCliente { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
    }

    public class Model
    {
        #region PROPRIEDADES

        public int CodCredor { get; set; }
        public int CodOper 
        {
            get 
            {
                return 10;
            }
        }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime? DataNasc { get; set; }
        public string Rg { get; set; }
        public string EndRua { get; set; }
        public string EndCompl { get; set; }
        public string EndBairro { get; set; }
        public string EndCidade { get; set; }
        public string EndUf { get; set; }
        public string EndCep { get; set; }
        public string Fone1 { get; set; }
        public string Fone2 { get; set; }
        public string TipoContrato 
        { 
            get 
            {
                return "CARNE";
            } 
        }
        public string Filial { get; set; }
        public string Contrato { get; set; }
        public int Lancamento { get; set; }
        public DateTime Vencimento { get; set; }
        public decimal Valor { get; set; }
        public int Plano { get; set; }
        public int Parcela { get; set; }
        public string ParcelaCompl { get; set; }
        public DateTime DataVenda { get; set; }
        public string Moeda 
        { 
            get 
            { 
                return "REAL"; 
            } 
        }
        public string Indice
        {
            get
            {
                return "REAL";
            }
        }
        public string ClasseContabil 
        {
            get 
            {
                return "2.027";
            }
        }

        #endregion
    }
}
