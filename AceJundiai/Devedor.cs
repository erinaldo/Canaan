using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceJundiai.Socket
{
    public class Devedor
    {
        public string Pessoa { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string RG { get; set; }
        public string DigitoRG { get; set; }
        public string UFEmissor { get; set; }
        public string OrgaoEmissor { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string NomeMae { get; set; }
        public string NomeConjuge { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string Email { get; set; }

        public Devedor() { 
            this.Pessoa = "";
            this.CPF = "";
            this.CNPJ = "";
            this.RG = "";
            this.DigitoRG = "";
            this.UFEmissor = "";
            this.OrgaoEmissor = "";
            this.Nome = "";
            this.DataNascimento = "";
            this.NomeMae = "";
            this.NomeConjuge = "";
            this.Endereco = "";
            this.Numero = "";
            this.Complemento = "";
            this.Bairro = "";
            this.Cidade = "";
            this.UF = "";
            this.CEP = "";
            this.Email = "";
        }

        /// <summary>
        /// Converte  o objeto em string
        /// </summary>
        /// <returns>Objeto convertido</returns>
        public string Serialize() {
            return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}",
                          Comum.FormataDireita(this.Pessoa, 1),
                          Comum.FormataDireita(this.CPF, 11),
                          Comum.FormataDireita(this.CNPJ, 14),
                          Comum.FormataDireita(this.RG, 14),
                          Comum.FormataDireita(this.DigitoRG, 1),
                          Comum.FormataDireita(this.UFEmissor, 2),
                          Comum.FormataDireita(this.OrgaoEmissor, 3),
                          Comum.FormataDireita(this.Nome, 45),
                          Comum.FormataDireita(this.DataNascimento, 8),
                          Comum.FormataDireita(this.NomeMae, 45),
                          Comum.FormataDireita(this.NomeConjuge, 45),
                          Comum.FormataDireita(this.Endereco, 35),
                          Comum.FormataDireita(this.Numero, 6),
                          Comum.FormataDireita(this.Complemento, 9).Substring(0, 9),
                          Comum.FormataDireita(this.Bairro, 35),
                          Comum.FormataDireita(this.Cidade, 35),
                          Comum.FormataDireita(this.UF, 2),
                          Comum.FormataDireita(this.CEP, 8));
        }


        /// <summary>
        /// Converte uma string em um objeto
        /// </summary>
        /// <param name="msg">String com dados do devedor</param>
        public void Deserialize(string msg) {
            var index = 23;

            this.Pessoa = msg.Substring(index, 1).Trim();
            this.CPF = msg.Substring(index = index + 1, 11).Trim();
            this.CNPJ = msg.Substring(index = index + 11, 14).Trim();
            this.RG = msg.Substring(index = index + 14, 14).Trim();
            this.DigitoRG = msg.Substring(index = index + 14, 1).Trim();
            this.UFEmissor = msg.Substring(index = index + 1, 2).Trim();
            this.OrgaoEmissor = msg.Substring(index = index + 2, 3).Trim();
            this.Nome = msg.Substring(index = index + 3, 45).Trim();
            this.DataNascimento = msg.Substring(index = index + 45, 8).Trim();
            this.NomeMae = msg.Substring(index = index + 8, 45).Trim();
            this.NomeConjuge = msg.Substring(index = index + 45, 45).Trim();
            this.Endereco = msg.Substring(index = index + 45, 35).Trim();
            this.Numero = msg.Substring(index = index + 35, 6).Trim();
            this.Complemento = msg.Substring(index = index + 6, 9).Trim();
            this.Bairro = msg.Substring(index = index + 9, 35).Trim();
            this.Cidade = msg.Substring(index = index + 35, 35).Trim();
            this.UF = msg.Substring(index = index + 35, 2).Trim();
            this.CEP = msg.Substring(index = index + 2, 8).Trim();
        }
    }
}
