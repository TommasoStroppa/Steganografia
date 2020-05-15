using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace CifraturaDLL
{
    public class Crypto
    {
        private static byte[] _salt = Encoding.ASCII.GetBytes("jasdh7834y8hfeur73rsharks214");

        public static string CifraturaAES(string testoOriginale, string password)
        {
            if (string.IsNullOrEmpty(testoOriginale))
                throw new ArgumentNullException("plain text");
            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("password");

            string testoCifrato = null;
            Rijndael algAES = null;

            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, _salt);

                algAES = new RijndaelManaged();
                algAES.Key = key.GetBytes(algAES.KeySize / 8);
                algAES.IV = key.GetBytes(algAES.BlockSize / 8);

                ICryptoTransform encryptor = algAES.CreateEncryptor(algAES.Key, algAES.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(testoOriginale);
                        }
                    }
                    testoCifrato = Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
            finally
            {
                if (algAES != null)
                    algAES.Clear();
            }
            return testoCifrato;
        }
        public static string DecifraturaAES(string testoCifrato, string password)
        {
            if (string.IsNullOrEmpty(testoCifrato))
                throw new ArgumentNullException("testo cifrato");
            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("password");

            string testoOriginale = null;
            Rijndael algAES = null;

            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, _salt);

                algAES = new RijndaelManaged();
                algAES.Key = key.GetBytes(algAES.KeySize / 8);
                algAES.IV = key.GetBytes(algAES.BlockSize / 8);

                ICryptoTransform decryptor = algAES.CreateDecryptor(algAES.Key, algAES.IV);

                byte[] bytes = Convert.FromBase64String(testoCifrato);

                using (MemoryStream msDecrypt = new MemoryStream(bytes))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            testoOriginale = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            finally
            {
                if (algAES != null)
                    algAES.Clear();
            }
            return testoOriginale;
        }
    }
}
