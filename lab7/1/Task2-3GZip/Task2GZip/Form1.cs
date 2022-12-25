using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2GZip
{
    public partial class Form1 : Form
    {
        Byte[] byteArray = new byte[0]; //сжатые данные
        public Form1()
        {
            InitializeComponent();
        }
        public byte[] compress(byte[] input)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (GZipStream deflateStream = new GZipStream(ms, CompressionMode.Compress))
                {
                    deflateStream.Write(input, 0, input.Length); //deflate
                }
                return ms.ToArray();
            }
        }
        public string decompress(byte[] input)
        {
            string str;
            using (MemoryStream stream = new MemoryStream(input))
            using (GZipStream zip = new GZipStream(stream, CompressionMode.Decompress))
            using (StreamReader reader = new StreamReader(zip))
            {
                str = reader.ReadToEnd();
            }
            return str;
        }

        private void compress_btn_Click(object sender, EventArgs e)
        {
            // сжать текст в массив байт
            byteArray = Encoding.UTF8.GetBytes(textBox1.Text);
            byteArray = compress(byteArray);
            //отобразить значение массива байт в 
            //шестнадцатеричном формате
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < byteArray.Length; i++)
            {
                sb.Append(String.Format(
                    "{0,2:X2} ", byteArray[i]));
            }
            textBox2.Text = sb.ToString();
        }

        private void decompress_btn_Click(object sender, EventArgs e)
        {
            //распаковать массив байт в текст
            textBox3.Text = decompress(byteArray);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            const string outputFile = "output.gz";
            const string inputFile = "input.txt";
            string text = File.ReadAllText(inputFile);

            using (FileStream outFile = File.Create(outputFile))
            {
                using (GZipStream zipStream = new GZipStream(outFile, CompressionMode.Compress))
                {
                    using (StreamWriter streamWriter = new StreamWriter(zipStream))
                    {
                        streamWriter.Write(text);
                    }
                }

            }
            MessageBox.Show("Сжатие файла прошло успешно!!");
        }

    }
}
