using Crypter;
using System;
using System.Security.Cryptography;
using System.Text;
using XSystem.Security.Cryptography;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {

            var password = "Alexandru123445";

            var cryptedPassword = CryptMethod.EncryptPlainTextToCipherText(password);
            Console.WriteLine(cryptedPassword);

            var decryptedPassword = CryptMethod.DecryptCipherTextToPlainText(cryptedPassword);
            Console.WriteLine(decryptedPassword);
        }

       
    }

   
}