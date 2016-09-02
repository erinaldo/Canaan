using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AceJundiai.Socket
{
    public class Comum
    {
        public static string FormataData(DateTime data)
        {
            return string.Format("{0}{1}{2}",
                data.Day.ToString().PadLeft(2, '0'),
                data.Month.ToString().PadLeft(2, '0'),
                data.Year.ToString().PadLeft(4, '0'));
        }

        public static string FormataDocumento(string doc)
        {
            doc = doc.Replace(".", "");
            doc = doc.Replace(",", "");
            doc = doc.Replace("-", "");
            doc = doc.Replace("/", "");

            return doc;
        }

        public static string FormataCep(string doc)
        {
            doc = doc.Replace(".", "");
            doc = doc.Replace("-", "");
            doc = doc.Replace("/", "");

            if (doc.Length > 8)
            {
                doc = doc.Substring(0, 8);
            }
            else {
                doc = doc.PadRight(8, '0');
            }

            return doc;
        }

        public static string FormataValor(decimal valor)
        {
            string s = decimal.Round(valor, 2).ToString();
            s = s.Replace(",", "");
            s = s.Replace(".", "");

            return s;
        }

        public static string FormataDireita(string str, int tam) {
            return str.PadRight(tam, ' ').Substring(0, tam);
        }

        public static string FormataAcentuacao(string str)
        {
            /** Troca os caracteres acentuados por não acentuados **/
            string[] acentos = new string[] { "ç", "Ç", "á", "é", "í", "ó", "ú", "ý", "Á", "É", "Í", "Ó", "Ú", "Ý", "à", "è", "ì", "ò", "ù", "À", "È", "Ì", "Ò", "Ù", "ã", "õ", "ñ", "ä", "ë", "ï", "ö", "ü", "ÿ", "Ä", "Ë", "Ï", "Ö", "Ü", "Ã", "Õ", "Ñ", "â", "ê", "î", "ô", "û", "Â", "Ê", "Î", "Ô", "Û" };
            string[] semAcento = new string[] { "c", "C", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "Y", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U", "a", "o", "n", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "A", "O", "N", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
            for (int i = 0; i < acentos.Length; i++)
            {
                str = str.Replace(acentos[i], semAcento[i]);
            }

            /** Troca os caracteres especiais da string por "" **/
            string[] caracteresEspeciais = { "\\.", ",", "." ,"-", ":", "\\(", "\\)", "ª", "\\|", "\\\\", "°", "[", "]", " " };
            for (int i = 0; i < caracteresEspeciais.Length; i++)
            {
                str = str.Replace(caracteresEspeciais[i], " ");
            }
            /** Troca os espaços no início por "" **/
            //str = str.Replace("^\\s+", " ");
            /** Troca os espaços no início por "" **/
            //str = str.Replace("\\s+$", " ");
            /** Troca os espaços duplicados, tabulações e etc por  " " **/
            //str = str.Replace("\\s+", " ");
            
            return str;
        }

        public static string FormataEmail(string str)
        {
            return str;
        }

        public static void SendEmail(string subject, string body, string emailFrom, string emailTo)
        {
            try
            {
                //configura o email
                MailMessage objMessage = new MailMessage();
                SmtpClient objSmtp = new SmtpClient();
                NetworkCredential objCredencial = new NetworkCredential();

                //configura credenciais
                objCredencial.UserName = "sac@canaanfotos.com.br";
                objCredencial.Password = "email1234";

                //configura mensagem
                objMessage.From = new MailAddress(emailFrom);
                objMessage.To.Add(emailTo);

                //informações das mensagens
                objMessage.Subject = subject;
                objMessage.IsBodyHtml = true;
                objMessage.Body = body;

                //envia a mensagem
                objSmtp.Host = "smtp.canaanfotos.com.br";
                objSmtp.Port = 587;

                objSmtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                objSmtp.EnableSsl = false;

                objSmtp.Credentials = objCredencial;
                objSmtp.Send(objMessage);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
