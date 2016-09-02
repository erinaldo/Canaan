using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AceJundiai.Socket
{
    class Program
    {
        static void Main(string[] args)
        {
            //var msg = ConfiguraMsg();
                       

            //Request request = new Request();
            //var result = request.SendRequest(msg, Enums.Tipo.Consultar);

            //Console.WriteLine(msg);
            //Console.WriteLine(Environment.NewLine);
            //Console.WriteLine(result.Substring(41));
            TesteRegistro();
        }

        private static string ConfiguraMsg()
        {
            var transacao = "REL";
            var versao = "01";
            var codigo = "5963";
            var senha = "003210";
            var documento = "12736822625";
            var reservado = "";

            return string.Format("{0}{1}{2}{3}{4}{5}", transacao, 
                                                       versao, 
                                                       codigo.PadRight(8,' '), 
                                                       senha.PadRight(8,' '), 
                                                       documento.PadRight(20,' '), 
                                                       reservado.PadRight(9,' '));
        }

        private static void TesteRegistro() {
            //cria novo registro
            var reg = new Registro("5963", "003210", "E");

            //configura devedor
            reg.Devedor.Pessoa = "F";
            reg.Devedor.CPF = Comum.FormataDocumento("070.175.666-70");
            reg.Devedor.RG = Comum.FormataDocumento("");
            reg.Devedor.Nome = "CASSIO RICARDO DE SOUZA";
            reg.Devedor.DataNascimento = Comum.FormataData(DateTime.Parse("25/06/1984"));
            reg.Devedor.NomeMae = "";
            reg.Devedor.NomeConjuge = "";
            reg.Devedor.Endereco = "RUA MARIO LAURENTE";
            reg.Devedor.Numero = "25";
            reg.Devedor.Complemento = "";
            reg.Devedor.Bairro = "DONA ODETE";
            reg.Devedor.Cidade = "Lavras";
            reg.Devedor.UF = "MG";
            reg.Devedor.CEP = Comum.FormataDocumento("37.200-000");

            //configura o debito
            reg.Debito.TipoDocumento = "DP";
            reg.Debito.NumeroContrato = "039175";
            reg.Debito.DataCompra = Comum.FormataData(DateTime.Parse("03/08/2013"));
            reg.Debito.DataVencimento = Comum.FormataData(DateTime.Parse("03/08/2013"));
            reg.Debito.ValorDebito = Comum.FormataValor(593.95m);

            var msg = reg.Serialize();

            var req = new Request();
            var result = req.SendRequest(reg.Serialize(), Enums.Tipo.Regitrar);

            var ret = new Registro("", "", "");
            ret.Deserialize(result);
        }
    }
}
