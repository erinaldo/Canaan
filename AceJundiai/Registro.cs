using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceJundiai.Socket
{
    public class Registro
    {
        public Autenticacao Autenticacao { get; set; }
        public Devedor Devedor { get; set; }
        public Debito Debito { get; set; }
        public Avalista Avalista { get; set; }

        public Registro()
        {
            this.Autenticacao = new Autenticacao("", "", "");
            this.Devedor = new Devedor();
            this.Debito = new Debito();
            this.Avalista = new Avalista();
        }

        public Registro(string p_Codigo, string p_Senha, string p_TipoAtualizacao) 
        {
            this.Autenticacao = new Autenticacao(p_Codigo, p_Senha, p_TipoAtualizacao);
            this.Devedor = new Devedor();
            this.Debito = new Debito();
            this.Avalista = new Avalista();
        }

        public string Serialize() { 
            var msg = string.Format("{0}{1}{2}{3}",
                this.Autenticacao.Serialize(),
                this.Devedor.Serialize(),
                this.Debito.Serialize(),
                this.Avalista.Serialize());

            return Comum.FormataAcentuacao(msg);
        }

        public void Deserialize(string msg) {
            this.Autenticacao.Deserialize(msg);
            this.Devedor.Deserialize(msg);
            this.Debito.Deserialize(msg);
        }
    }
}
