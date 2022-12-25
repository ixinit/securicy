using System;
using System.Security.Cryptography;
using System.Text;

namespace Task2ECP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Сторона отправителя
                ASCIIEncoding ByteConverter = new ASCIIEncoding();
                string dataString1 = "Цифровая подпись c MD5";
                byte[] originalData1 = ByteConverter.GetBytes(dataString1);
                byte[] signedData;
                RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider();//класс RSA
                RSAParameters Key = RSAalg.ExportParameters(true);//Создаем пару ключей, поэтому true
                signedData = HashAndSignBytes(originalData1, Key);//Хешируем и создаем подпись
                //Сторона получателя
                string dataString2 = "Цифровая подпись c MD5";
                byte[] originalData2 = ByteConverter.GetBytes(dataString2);
                // Верификация подписи
                if (VerifySignedHash(originalData2, signedData, Key))
                {
                    Console.WriteLine("Верификация успешна.");
                }
                else
                {
                    Console.WriteLine("Верификация не прошла! Ищи подделку.");
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The data was not signed or verified");
            }
        }
        // Хеширование и создание подписи закрытым ключом - сторона отправителя
        public static byte[] HashAndSignBytes(byte[] DataToSign, RSAParameters Key)
        {
            try
            {
                RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider();
                RSAalg.ImportParameters(Key);
                return RSAalg.SignData(DataToSign, MD5.Create());
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        //Проверка (верификация) подписи открытым ключом - сторона получателя
        public static bool VerifySignedHash(byte[] DataToVerify, byte[] SignedData, RSAParameters Key)
        {
            try
            {
                RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider();
                RSAalg.ImportParameters(Key);
                return RSAalg.VerifyData(DataToVerify, MD5.Create(), SignedData);
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
