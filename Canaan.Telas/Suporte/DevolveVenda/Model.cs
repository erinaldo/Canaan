using System;
using System.Collections.Generic;
using Canaan.Dados;
using Canaan.Lib;
using Venda = Canaan.Lib.Venda;

namespace Canaan.Telas.Suporte.DevolveVenda
{
    public class Model
    {
        #region PROPRIEDADES

        public int IdPedido { get; set; }
        public int CodReduzido { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public bool IsLiberado { get; set; }
        public bool IsConfirmado { get; set; }
        public EnumStatusVenda Status { get; set; }

        #endregion

        #region METODOS

        public static List<Model> GetByAtendimento(int codReduzido) 
        {
            var lista = new List<Model>();
            var filial = Session.Instance.Contexto.IdFilial;

            var venda = new Venda().GetByCodigoReduzido(codReduzido, filial);

            foreach (var item in venda)
            {
                lista.Add(new Model
                {
                    IdPedido = item.IdPedido,
                    CodReduzido = codReduzido,
                    Data = item.DataEmissao.GetValueOrDefault(),
                    Valor = item.ValorLiquido.GetValueOrDefault(),
                    IsLiberado = item.IsLiberado.GetValueOrDefault(),
                    IsConfirmado = item.IsConfirmado,
                    Status = item.Status
                });
   
            }

            return lista;
        }

        #endregion
    }
}
