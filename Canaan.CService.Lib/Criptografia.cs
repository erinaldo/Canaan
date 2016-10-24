using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Canaan.CService.Lib
{
    public class Criptografia
    {
        private static byte[] Key = new ASCIIEncoding().GetBytes("cripto@canaan001");
        private static byte[] IV = new ASCIIEncoding().GetBytes("cripto@canaan001");

        public static byte[] Criptografa(byte[] clearData)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();

            alg.Key = Key;
            alg.IV = IV;

            CryptoStream cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write);

            cs.Write(clearData, 0, clearData.Length);
            cs.Close();

            byte[] encryptedData = ms.ToArray();

            return encryptedData;
        }

        public static byte[] Descriptografa(byte[] criptoData)
        {
            MemoryStream ms = new MemoryStream();

            Rijndael alg = Rijndael.Create();

            alg.Key = Key;
            alg.IV = IV;

            CryptoStream cs = new CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write);

            cs.Write(criptoData, 0, criptoData.Length);
            cs.Close();

            byte[] decryptedData = ms.ToArray();

            return decryptedData;
        }

        public static byte[] GetBytes(string filename)
        {
            return File.ReadAllBytes(filename);
        }

        public static Image GetFromBytes(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
