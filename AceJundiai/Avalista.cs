using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceJundiai.Socket
{
    public class Avalista
    {
        public string NomeAvalista { get; set; }
        public string CPFAvalista { get; set; }
        public string RGAvalista { get; set; }
        public string DigitoRG { get; set; }
        public string UFEmissor { get; set; }
        public string OrgaoEmissor { get; set; }
        public string DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }

        public Avalista() { 
            this.NomeAvalista = "" ;
            this.CPFAvalista = "" ;
            this.RGAvalista = "" ;
            this.DigitoRG = "" ;
            this.UFEmissor = "" ;
            this.OrgaoEmissor = "" ;
            this.DataNascimento = "" ;
            this.Endereco = "" ;
            this.Numero = "" ;
            this.Complemento = "" ;
            this.Bairro = "" ;
            this.Cidade = "" ;
            this.UF = "" ;
            this.CEP = "" ;
        }

        public string Serialize() {
            return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}",
                this.NomeAvalista.PadRight(45, ' '),
                this.CPFAvalista.PadRight(11, ' '),
                this.RGAvalista.PadRight(14, ' '),
                this.DigitoRG.PadRight(1, ' '),
                this.UFEmissor.PadRight(2, ' '),
                this.OrgaoEmissor.PadRight(3, ' '),
                this.DataNascimento.PadRight(8, ' '),
                this.Endereco.PadRight(35, ' '),
                this.Numero.PadRight(6, ' '),
                this.Complemento.PadRight(9, ' '),
                this.Bairro.PadRight(35, ' '),
                this.Cidade.PadRight(35, ' '),
                this.UF.PadRight(2, ' '),
                this.CEP.PadRight(8, ' '));
        }
    }
}
