using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoCifratura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo cifratura di una stringa qualsiasi tramite password");

            Console.Write("Stringa da cifrare:");
            string strEncryprion=Console.ReadLine();

            Console.Write("Passord:");
            string pswd = Console.ReadLine();

            string strEncrypted=CifraturaDLL.Crypto.AESEncryption(strEncryprion, pswd);

            Console.Write("Stringa cifrata:");
            Console.WriteLine(strEncrypted);

            Console.Write("Password:");
            string pswdn = Console.ReadLine();

            try
            {
                string strDecrypted = CifraturaDLL.Crypto.AESDecryption(strEncrypted, pswdn);
                Console.Write("Stringa decifrata:");
                Console.WriteLine(strDecrypted);

                Console.Write("Premi un tasto per continuare...");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("!ERROR!");

                Console.Write("Premi un tasto per continuare...");
                Console.ReadKey();
            }

            
        }
    }
}
