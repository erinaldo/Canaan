using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Canaan.Lib.Utilitarios
{
    public static class Comum
    {
        public static int CalculaIdade(DateTime dataNascimento)
        {
            int anos = DateTime.Now.Year - dataNascimento.Year;

            if (DateTime.Now.Month < dataNascimento.Month ||
               (DateTime.Now.Month == dataNascimento.Month && DateTime.Now.Day < dataNascimento.Day))

                anos--;

            return anos;
        }

        public static void SendEmail(string[] to, string assunto, string texto, string[] anexos)
        {
            try
            {
                //configura o email
                MailMessage objMessage = new MailMessage();
                SmtpClient objSmtp = new SmtpClient();
                NetworkCredential objCredencial = new NetworkCredential();

                //configura credenciais
                objCredencial.UserName = Properties.Settings.Default.SmtpUser;
                objCredencial.Password = Properties.Settings.Default.SmtpPass;

                //configura mensagem
                objMessage.From = new MailAddress(Properties.Settings.Default.SmtpUser);

                //adiciona destinatarios
                foreach (var contato in to)
                {
                    objMessage.To.Add(contato);
                }

                //adiciona anexos
                foreach (var anexo in anexos)
                {
                    Attachment attachment;
                    attachment = new Attachment(anexo);
                    objMessage.Attachments.Add(attachment);
                }

                //informações das mensagens
                objMessage.Subject = assunto;
                objMessage.IsBodyHtml = true;
                objMessage.Body = texto;

                //envia a mensagem
                objSmtp.Host = Properties.Settings.Default.SmtpHost;
                objSmtp.Port = Properties.Settings.Default.SmtpPort;
                
                objSmtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                objSmtp.EnableSsl = Properties.Settings.Default.SmtpSsl;

                objSmtp.Credentials = objCredencial;
                objSmtp.Send(objMessage);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool CanUpdateVenda(Dados.Venda Venda)
        {
            return true;
            //if (!Venda.IsConfirmado)
            //    return true;

            //switch (Venda.Status)
            //{
            //    case Dados.EnumStatusVenda.AFaturar:
            //        return false;
            //    case Dados.EnumStatusVenda.Faturado:
            //        return false;
            //    case Dados.EnumStatusVenda.Cancelado:
            //        return false;
            //    case Dados.EnumStatusVenda.Programada:
            //        return false;
            //    case Dados.EnumStatusVenda.ParcialmenteQuitado:
            //        return false;
            //    case Dados.EnumStatusVenda.Quitado:
            //        return false;
            //    case Dados.EnumStatusVenda.NaoFinalizado:
            //        return true;
            //    case Dados.EnumStatusVenda.Devolvido:
            //        return true;
            //    default:
            //        return true;
            //}
        }

        public static string FormataTelefone(string phone)
        {
            if(string.IsNullOrEmpty(phone))
                return string.Empty;

            var number = double.MaxValue;
            var result = double.TryParse(phone, out number);

            if (result)
                return string.Format("{0:(##)####-####}", number);
            else
                return phone;
        }     

        public static string RemoveSpecialCharacters(string input)
        {
            Regex r = new Regex("(?:[^a-z0-9 ]|(?<=['\"])s)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
            return r.Replace(input, String.Empty);
        }

        public static string FormataCpf(string cpf)
        {
            if (string.IsNullOrEmpty(cpf))
                return string.Empty;

            cpf = RemoveSpecialCharacters(cpf);

            var number = double.MaxValue;
            var result = double.TryParse(cpf, out number);

            if (result)
                return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
            else
                return cpf;
        }

        public static string FormataCNPJ(string cnpj)
        {
            if (string.IsNullOrEmpty(cnpj))
                return string.Empty;

            var number = double.MaxValue;
            var result = double.TryParse(cnpj, out number);

            if (result)
                return string.Format("{0:(##)####-####}", number);
            else
                return cnpj;
        }

        public static string RemoveEspeciais(string str)
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
                string[] caracteresEspeciais = { "\\.", ",", ".", "-", ":", "\\(", "\\)", "ª", "\\|", "\\\\", "°", "[", "]", " " };
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

        public static string RemoveSpaces(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return string.Empty;
            }

            return str.Replace(" ", string.Empty);
        }
       
        // Um método que verifica se esta conectado
        public static Boolean HasInternet()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            } 
        }
    }
}
