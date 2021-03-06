//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Canaan.Dados
{
    using System;
    using System.Collections.Generic;
    
    public partial class CliFor
    {
        public CliFor()
        {
            this.Pedido = new HashSet<Pedido>();
            this.CliForReferencia = new HashSet<CliForReferencia>();
            this.Atendimento = new HashSet<Atendimento>();
            this.Lancamento = new HashSet<Lancamento>();
            this.Modelo = new HashSet<Modelo>();
            this.Renegociacao = new HashSet<Renegociacao>();
        }
    
        public int IdCliFor { get; set; }
        public int IdCidade { get; set; }
        public EnumCliForTipo Tipo { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Telefone2 { get; set; }
        public string Telefone3 { get; set; }
        public string Celular { get; set; }
        public string Celular2 { get; set; }
        public string Celular3 { get; set; }
        public string Fax { get; set; }
        public bool IsAtivo { get; set; }
        public string Documento { get; set; }
        public string Nome { get; set; }
        public string OperadoraTelefone { get; set; }
        public string OperadoraTelefone2 { get; set; }
        public string OperadoraTelefone3 { get; set; }
        public string OperadoraCelular { get; set; }
        public string OperadoraCelular2 { get; set; }
        public string OperadoraCelular3 { get; set; }
    
        public virtual Cidade Cidade { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
        public virtual ICollection<CliForReferencia> CliForReferencia { get; set; }
        public virtual ICollection<Atendimento> Atendimento { get; set; }
        public virtual ICollection<Lancamento> Lancamento { get; set; }
        public virtual ICollection<Modelo> Modelo { get; set; }
        public virtual ICollection<Renegociacao> Renegociacao { get; set; }
    }
}
