using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CifraturaDLL;

namespace ConsoleDemoCifratura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo cifratura di una stringa qualsiasi tramite password");

            Console.Write("\nStringa da cifrare:");
            string strEncryprion=Console.ReadLine();

            Console.Write("Password:");
            string pswd = Console.ReadLine();

            string strEncrypted=Crypto.CifraturaAES(strEncryprion, pswd);

            Console.Write("\nStringa cifrata:");
            Console.WriteLine(strEncrypted);

            Console.Write("\nPassword:");
            string pswdn = Console.ReadLine();

            try
            {
                string strDecrypted = Crypto.DecifraturaAES(strEncrypted, pswdn);
                Console.Write("\nStringa decifrata:");
                Console.WriteLine(strDecrypted);

                Console.Write("\nPremi un tasto per continuare...");
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
