using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uol.PagSeguro.Constants;
using Uol.PagSeguro.Domain;
using Uol.PagSeguro.Resources;

namespace Canaan.CService.Telas.Integracao.PagSeguro
{
    public class Model
    {
        public string Codigo { get; set; }
        public string Documento { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string DDD { get; set; }
        public string Telefone { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Servico { get; set; }
        public decimal Valor { get; set; }
        public decimal Frete { get; set; }

        public Model()
        {
            this.Codigo = "00000000";
            this.Servico = "Servico de Encadernacao";
        }

        public static Model GetByCodigo(string codigo, short coligada) 
        {
            using (var conn = new RM.Dados.CorporeEntities())
            {
                var result = new Model();
                var clifor = conn.FCFO.FirstOrDefault(a => a.CODCFO == codigo && a.CODCOLIGADA == coligada);

                if(clifor != null)
                {
                    result.Codigo = clifor.CODCFO;
                    result.Documento = RemoveEspeciais(clifor.CGCCFO);
                    result.Nome = clifor.NOME;
                    result.Email = clifor.EMAIL;
                    result.DDD = string.IsNullOrEmpty(clifor.TELEFONE) ? "" : RemoveEspeciais(clifor.TELEFONE).Substring(0, 2);
                    result.Telefone = string.IsNullOrEmpty(clifor.TELEFONE) ? "" : RemoveEspeciais(clifor.TELEFONE).Substring(2).Trim();
                    result.Estado = clifor.CODETD;
                    result.Cidade = clifor.CIDADE;
                    result.Bairro = clifor.BAIRRO;
                    result.Cep = clifor.CEP;
                    result.Endereco = clifor.RUA;
                    result.Numero = clifor.NUMERO;
                    result.Complemento = clifor.COMPLEMENTO;
                    result.Valor = 0;
                    result.Frete = 0;
                }

                return result;
            }
        }

        private static string RemoveEspeciais(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                /** Troca os caracteres acentuados por não acentuados **/
                string[] acentos = new string[] { "ç", "Ç", "á", "é", "í", "ó", "ú", "ý", "Á", "É", "Í", "Ó", "Ú", "Ý", "à", "è", "ì", "ò", "ù", "À", "È", "Ì", "Ò", "Ù", "ã", "õ", "ñ", "ä", "ë", "ï", "ö", "ü", "ÿ", "Ä", "Ë", "Ï", "Ö", "Ü", "Ã", "Õ", "Ñ", "â", "ê", "î", "ô", "û", "Â", "Ê", "Î", "Ô", "Û" };
                string[] semAcento = new string[] { "c", "C", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "Y", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U", "a", "o", "n", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "A", "O", "N", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
                for (int i = 0; i < acentos.Length; i++)
                {
                    str = str.Replace(acentos[i], semAcento[i]);
                }

                /** Troca os caracteres especiais da string por "" **/
                string[] caracteresEspeciais = { "\\.", ",", ".", "-", ":", "\\(", "\\)", "ª", "\\|", "\\\\", "°", "[", "]", " ", "(", ")", "/" };
                for (int i = 0; i < caracteresEspeciais.Length; i++)
                {
                    str = str.Replace(caracteresEspeciais[i], "");
                }
                /** Troca os espaços no início por "" **/
                //str = str.Replace("^\\s+", " ");
                /** Troca os espaços no início por "" **/
                //str = str.Replace("\\s+$", " ");
                /** Troca os espaços duplicados, tabulações e etc por  " " **/
                //str = str.Replace("\\s+", " ");
            }
            else
            {
                str = string.Empty;
            }
            return str;

        }

        public static Uri CriaPagamento(Model venda) 
        {
            //Use global configuration
            PagSeguroConfiguration.UrlXmlConfiguration = "Configuration/PagSeguroConfig.xml";

            bool isSandbox = false;
            EnvironmentConfiguration.ChangeEnvironment(isSandbox);

            //cria o pagamento
            PaymentRequest payment = new PaymentRequest();

            //adiciona itens no pagamento
            payment.Items.Add(new Item(venda.Codigo, venda.Servico, 1, venda.Valor, 0, 0));

            //adiciona dados do cliente
            payment.Sender = new Sender(
                venda.Nome,
                venda.Email,
                new Phone(
                    venda.DDD,
                    venda.Telefone
                )
            );


            //endereço
            payment.Shipping = new Shipping();
            payment.Shipping.ShippingType = ShippingType.NotSpecified;
            payment.Shipping.Cost = venda.Frete;
            payment.Shipping.Address = new Address(
                "BRA",
                venda.Estado,
                venda.Nome,
                venda.Bairro,
                venda.Cep,
                venda.Endereco,
                venda.Numero,
                venda.Complemento
            );

            //docuemtno
            if(venda.Documento.Length == 11)
                payment.Sender.Documents.Add(new SenderDocument(Documents.GetDocumentByType("CPF"), venda.Documento));
            else
                payment.Sender.Documents.Add(new SenderDocument(Documents.GetDocumentByType("CNPJ"), venda.Documento));

            //informacoes finais
            payment.Currency = Currency.Brl;
            payment.Reference = venda.Codigo;

            //creadenciais
            AccountCredentials credentials = PagSeguroConfiguration.Credentials(isSandbox);

            payment.NotificationURL = "http://canaanfotos.com.br";
            payment.RedirectUri = new Uri("http://canaanfotos.com.br");

            Uri paymentRedirectUri = payment.Register(credentials);

            return paymentRedirectUri;
        }


    }
}
