using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceJundiai.Socket
{
    public class Consulta
    {
        public string Transacao { get; set; }
        public string Versao { get; set; }
        public string Codigo { get; set; }
        public string Senha { get; set; }
        public string Documento { get; set; }
        public string CodRetorno { get; set; }
        public string MensagemErro { get; set; }
        public string CodDevedor { get; set; }
        public string Nome { get; set; }
        public string TipoDocumento { get; set; }
        public string NumContrato { get; set; }
        public string DataVencimento { get; set; }
        public string Valor { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string ContaCorrente { get; set; }
        public string DigContaCorrent { get; set; }
        public string Alinea { get; set; }
        public string CodDivida { get; set; }
        public string DataEntrada { get; set; }
        public string Situacao { get; set; }
        public string Reservado { get; set; }

        public Consulta() {
            this.Transacao = "REL";
            this.Versao = "01";
            this.Codigo = "";
            this.Senha = "";
            this.Documento = "";
            this.CodRetorno = "";
            this.MensagemErro = "";
            this.CodDevedor = "";
            this.Nome = "";
            this.TipoDocumento = "";
            this.NumContrato = "";
            this.DataVencimento = "";
            this.Valor = "";
            this.Banco = "";
            this.Agencia = "";
            this.ContaCorrente = "";
            this.DigContaCorrent = "";
            this.Alinea = "";
            this.CodDivida = "";
            this.DataEntrada = "";
            this.Situacao = "";
            this.Reservado = "";
        }

        public Consulta(string p_Codigo, string p_Senha, string p_Doc)
        {
            this.Transacao = "REL";
            this.Versao = "01";
            this.Codigo = p_Codigo;
            this.Senha = p_Senha;
            this.Documento = p_Doc;
            this.CodRetorno = "";
            this.MensagemErro = "";
            this.CodDevedor = "";
            this.Nome = "";
            this.TipoDocumento = "";
            this.NumContrato = "";
            this.DataVencimento = "";
            this.Valor = "";
            this.Banco = "";
            this.Agencia = "";
            this.ContaCorrente = "";
            this.DigContaCorrent = "";
            this.Alinea = "";
            this.CodDivida = "";
            this.DataEntrada = "";
            this.Situacao = "";
            this.Reservado = "";
        }

        public string Serialize() { 
            return string.Format("{0}{1}{2}{3}{4}{5}",
                this.Transacao.PadRight(3,' '),
                this.Versao.PadRight(2,' '),
                this.Codigo.PadRight(8,' '),
                this.Senha.PadRight(8,' '),
                this.Documento.PadRight(20,' '),
                this.Transacao.PadRight(9,' '));
        }

        public void Deserialize(string msg) {
            this.Transacao = msg.Substring(0, 3).Trim();
            this.Versao = msg.Substring(3, 2).Trim();
            this.Codigo = msg.Substring(5, 8).Trim();
            this.Senha = msg.Substring(13, 8).Trim();
            this.Documento = msg.Substring(21, 20).Trim();
            this.CodRetorno = msg.Substring(41, 2).Trim();
            this.MensagemErro = msg.Substring(43, 79).Trim();
            this.CodDevedor = msg.Substring(122, 10).Trim();
            this.Nome = msg.Substring(132, 45).Trim();
            this.TipoDocumento = msg.Substring(177, 2).Trim();
            this.NumContrato = msg.Substring(179, 20).Trim();
            this.DataVencimento = msg.Substring(199, 8).Trim();
            this.Valor = msg.Substring(207, 12).Trim();
            this.Banco = msg.Substring(219, 3).Trim();
            this.Agencia = msg.Substring(222, 4).Trim();
            this.ContaCorrente = msg.Substring(226, 15).Trim();
            this.DigContaCorrent = msg.Substring(241, 1).Trim();
            this.Alinea = msg.Substring(242, 2).Trim();
            this.CodDivida = msg.Substring(244, 10).Trim();
            this.DataEntrada = msg.Substring(254, 8).Trim();
            this.Situacao = msg.Substring(262, 1).Trim();
            this.Reservado = msg.Substring(263, 7).Trim();
        }
    }
}
