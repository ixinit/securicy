using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Task2RSA
{
    public partial class Form1 : Form
    {
        byte[] publicKey, privateKey;
        const int KEY_SIZE = 2048;

        RSACryptoServiceProvider rsa;
        public Form1()
        {
            InitializeComponent();
            rsa = new RSACryptoServiceProvider(KEY_SIZE);
        }



        private void btnCreatePublicKey_Click(object sender, EventArgs e)
        {

            publicKey = rsa.ExportCspBlob(false);
            //сохраняем ключи в файлах
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SaveFile(publicKey, ofd.FileName);
                tbWherePublicKey.Text = ofd.FileName;
            }


        }

        private void btnCreatePrivateKey_Click(object sender, EventArgs e)
        {

            privateKey = rsa.ExportCspBlob(true);
            //сохраняем ключи в файлах
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SaveFile(privateKey, ofd.FileName);
                tbWherePrivateKey.Text = ofd.FileName;
            }

        }


        string text;
        byte[] data;
        byte[] encrypted;


        private void btnSelectEncodingFile_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                text = File.ReadAllText(ofd.FileName);
                data = Encoding.Unicode.GetBytes(text);
                tbSelectedFileToEncode.Text = ofd.FileName;
                rtbWhatEncode.Text = text;
            }
        }

        private void btnSelectPublicKey_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ReadFile(out publicKey, ofd.FileName);
                tbSelectedPublicKeyToEncode.Text = ofd.FileName;
            }
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            rsa.ImportCspBlob(publicKey);
            encrypted = rsa.Encrypt(data, true);
            //Сохраняем шифровку
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SaveFile(encrypted, ofd.FileName);
            }
        }



        byte[] decrypted;
        private void btnSelectFileToDecode_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ReadFile(out encrypted, ofd.FileName);
                tbSelectedFileToDecode.Text = ofd.FileName;
            }
        }

        private void btnSelectPrivateKey_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ReadFile(out privateKey, ofd.FileName);
                tbSelectedPrivateKey.Text = ofd.FileName;
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            rsa.ImportCspBlob(privateKey);
            decrypted = rsa.Decrypt(encrypted, true);
            string decrypt_data = Encoding.Unicode.GetString(decrypted);
            rtbDecoded.Text = decrypt_data;

        }


        public static void SaveFile(byte[] array, string FileName)
        {
            using (FileStream fstream = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }
        }

        // чтение байт - массива из файла
        public static void ReadFile(out byte[] array, string FileName)
        {
            using (FileStream fstream = File.OpenRead(FileName))
            {
                // преобразуем строку в байты
                array = new byte[fstream.Length];
                // считываем данные в байт-массив
                fstream.Read(array, 0, array.Length);
            }
        }

    }
}
