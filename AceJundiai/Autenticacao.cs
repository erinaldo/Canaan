using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceJundiai.Socket
{
    public class Autenticacao
    {
        public string Transacao { get; set; }
        public string Versao { get; set; }
        public string Codigo { get; set; }
        public string Senha { get; set; }
        public string TipoRegistro { get; set; }
        public string TipoAtualizacao { get; set; }

        public Autenticacao(string p_Codigo, string p_Senha, string p_TipoAtualizacao) {
            this.Transacao = "MAN";
            this.Versao = "02";
            this.Codigo = p_Codigo;
            this.Senha = p_Senha;
            this.TipoRegistro = "1";
            this.TipoAtualizacao = p_TipoAtualizacao;
        }

        /// <summary>
        /// Converte o objeto para mensagem de texto
        /// </summary>
        /// <returns>Mensagem de texto</returns>
        public string Serialize() 
        { 
            return string.Format("{0}{1}{2}{3}{4}{5}", 
                              this.Transacao.PadRight(3, ' '),
                              this.Versao.PadRight(2, ' '),
                              this.Codigo.PadRight(8, ' '),
                              this.Senha.PadRight(8, ' '),
                              this.TipoRegistro.PadRight(1, '0'),
                              this.TipoAtualizacao.PadRight(1, ' '));
        }

        /// <summary>
        /// Converte uma mensagem de texto em objeto
        /// </summary>
        /// <param name="msg">Mensagem de 22 posicoes</param>
        public void Deserialize(string msg) {
            var index = 0;

            this.Transacao = msg.Substring(index, 3).Trim();
            this.Versao = msg.Substring(index = index + 3, 2).Trim();
            this.Codigo = msg.Substring(index = index + 2, 8).Trim();
            this.Senha = msg.Substring(index = index + 8, 8).Trim();
            this.TipoRegistro = msg.Substring(index = index + 8, 1).Trim();
            this.TipoAtualizacao = msg.Substring(index = index + 1, 1).Trim();
        }
    }
}
