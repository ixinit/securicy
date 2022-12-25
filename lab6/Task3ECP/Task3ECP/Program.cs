using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Task3ECP
{
    class Program
    {
        static void Main(string[] args)
        {
            //X509Certificate2 cer = new X509Certificate2();
            Console.WriteLine(Directory.GetCurrentDirectory());
            //cer.Import(@"Adnan.cer");
            X509Certificate2 cer = new X509Certificate2(File.ReadAllBytes(@"Adnan.cer"));
            bool hasPrivateKey = cer.HasPrivateKey;
            string certificate = cer.ToString();
            Console.Write("Наличие в сертификате секретного ключа:");
            Console.WriteLine(hasPrivateKey);
            Console.WriteLine("Данные из сертификата");
            Console.WriteLine(certificate);
            // Get the value PublicKey
            Console.WriteLine("Открытый ключ:");
            byte[] results = cer.GetPublicKey();
            // Display the value to the console.
            foreach (byte b in results)
            {
                Console.Write(b);
            }
            Console.ReadLine();
        }

    }
}
