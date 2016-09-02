using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceJundiai.Socket
{
    public class Debito
    {
        public string TipoDocumento { get; set; }
        public string NumeroContrato { get; set; }
        public string DataCompra { get; set; }
        public string DataVencimento { get; set; }
        public string ValorDebito { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string ContaCorrente { get; set; }
        public string DigitoContaCorrente { get; set; }
        public string AlineaCheque { get; set; }
        public string CodRetorno { get; set; }
        public string Diagnostico { get; set; }
        public string CodigoDivida { get; set; }
        public string Reservado { get; set; }

        public Debito() { 
            this.TipoDocumento = "";
            this.NumeroContrato = "";
            this.DataCompra = "";
            this.DataVencimento = "";
            this.ValorDebito = "";
            this.Banco = "";
            this.Agencia = "";
            this.ContaCorrente = "";
            this.DigitoContaCorrente = "";
            this.AlineaCheque = "";
            this.CodRetorno = "";
            this.Diagnostico = "";
            this.CodigoDivida = "";
            this.Reservado = "";
        }

        public string Serialize() {
            return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}",
                this.TipoDocumento.PadRight(2, ' '),
                this.NumeroContrato.PadRight(20, ' '),
                this.DataCompra.PadRight(8, ' '),
                this.DataVencimento.PadRight(8, ' '),
                this.ValorDebito.PadLeft(12, '0'),
                this.Banco.PadRight(3, ' '),
                this.Agencia.PadRight(4, ' '),
                this.ContaCorrente.PadRight(15, ' '),
                this.DigitoContaCorrente.PadRight(1, ' '),
                this.AlineaCheque.PadRight(2, ' '),
                this.CodRetorno.PadRight(2, ' '),
                this.Diagnostico.PadRight(79, ' '),
                this.CodigoDivida.PadRight(10, ' '),
                this.Reservado.PadRight(23, ' '));
        }


        public void Deserialize(string msg) {
            var index = 342;

            this.TipoDocumento = msg.Substring(index, 2).Trim();
            this.NumeroContrato = msg.Substring(index = index + 2, 20).Trim();
            this.DataCompra = msg.Substring(index = index + 20, 8).Trim();
            this.DataVencimento = msg.Substring(index = index + 8, 8).Trim();
            this.ValorDebito = msg.Substring(index = index + 8, 12).Trim();
            this.Banco = msg.Substring(index = index + 12, 3).Trim();
            this.Agencia = msg.Substring(index = index + 3, 4).Trim();
            this.ContaCorrente = msg.Substring(index = index + 4, 15).Trim();
            this.DigitoContaCorrente = msg.Substring(index = index + 15, 1).Trim();
            this.AlineaCheque = msg.Substring(index = index + 1, 2).Trim();
            this.CodRetorno = msg.Substring(index = index + 2, 2).Trim();
            this.Diagnostico = msg.Substring(index = index + 2, 79).Trim();
            this.CodigoDivida = msg.Substring(index = index + 79, 10).Trim();
            this.Reservado = msg.Substring(index = index + 10, 23).Trim();
        }
    }
}
