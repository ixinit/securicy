using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4FilesToZip
{
    class Program
    {
        static void Main(string[] args)
        {
            // Эту папку будем сжимать.
            string inputDir = "Test";

            // Выходной файл после сжатия файлов из папки выше.
            string zipPath = "Test.zip";

            // Извлечем файл zip в эту папку.
            string extractPath = "./Test_extr";
            // Упаковываю
            // Создать файл zip с помощью сжатия папки.
            ZipFile.CreateFromDirectory(inputDir, zipPath);
            //Распаковываю
            // Извлечь файл zip в папку.
            ZipFile.ExtractToDirectory(zipPath, extractPath);

            Console.WriteLine("Ура! Сжатие прошло успешно!!!");
            Console.ReadLine();

        }
    }
}
