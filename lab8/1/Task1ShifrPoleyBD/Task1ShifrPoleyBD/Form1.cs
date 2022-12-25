using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1ShifrPoleyBD
{
    public partial class Form1 : Form
    {
        lab8_AESEntities db = new lab8_AESEntities();
        int count;
        public Form1()
        {
            InitializeComponent();
        }
        //Создать и сохранить ключ
        private void button3_Click(object sender, EventArgs e)
        {
            byte[] Key;
            byte[] IV;
            AesCryptoServiceProvider cryptAlgorithm = new AesCryptoServiceProvider();
            //KeySize: Gets or sets the size, in bits, of the secret key  
            cryptAlgorithm.KeySize = 128;
            //Генерация нового начального вектора IV
            cryptAlgorithm.GenerateIV();
            IV = cryptAlgorithm.IV;
            //Генерация нового случайного ключа
            cryptAlgorithm.GenerateKey();
            Key = cryptAlgorithm.Key;
            //Сохранение вектора и ключа в файлах.
            // convert byte array  into  string
            string IV_str = Encoding.Default.GetString(IV);
            string Key_str = Encoding.Default.GetString(Key);
            //Соэхранить в файлах dat
            File.WriteAllText("IV.dat", IV_str);
            File.WriteAllText("Key.dat", Key_str);
            label3.Text = "Ключ успешно создан и сохранен!";
        }

        //Зашифровать и записать в БД 
        private void button1_Click(object sender, EventArgs e)
        {
            Users stud = new Users();//новый экземпляр сущности
            stud.Name = textBox1.Text;
            stud.Name_Bin = EnCryptString(stud.Name);
            db.Users.Add(stud);
            db.SaveChanges();
            count++;
            label1.Text = "Новых записей: " + count.ToString();

        }
        //Прочитать все из БД в таблицу
        private void button2_Click(object sender, EventArgs e)
        {
            var query = db.Users; //LINQ простой
            var list = query.ToList();
            string[] s = new string[query.Count()];
            //Раскодировать
            dataGridView1.Rows.Clear();
            for (int i = 0; i < query.Count(); i++)
            {
                s[i] = DeCryptString(list[i].Name_Bin);
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = i.ToString();
                dataGridView1.Rows[i].Cells[1].Value = list[i].Name;
                dataGridView1.Rows[i].Cells[2].Value = s[i];

            }
        }
        // Процедуры шифрования - расшифрования - AES
        public static Byte[] EnCryptString(string value)
        {
            string Key_str = File.ReadAllText("Key.dat");
            string IV_str = File.ReadAllText("IV.dat");
            AesCryptoServiceProvider dataencrypt = new AesCryptoServiceProvider();
            //Block size : Gets or sets the block size, in bits, of the cryptographic operation.  
            dataencrypt.BlockSize = 128;
            //KeySize: Gets or sets the size, in bits, of the secret key  
            dataencrypt.KeySize = 128;
            //Key: Gets or sets the symmetric key that is used for encryption and decryption.  
            dataencrypt.Key = System.Text.Encoding.Default.GetBytes(Key_str);
            //IV : Gets or sets the initialization vector (IV) for the symmetric algorithm  
            dataencrypt.IV = System.Text.Encoding.Default.GetBytes(IV_str);
            //Padding: Gets or sets the padding mode used in the symmetric algorithm  
            dataencrypt.Padding = PaddingMode.PKCS7;
            //Mode: Gets or sets the mode for operation of the symmetric algorithm  
            dataencrypt.Mode = CipherMode.CBC;
            //Creates a symmetric AES encryptor object using the current key and initialization vector (IV).  
            ICryptoTransform crypto1 = dataencrypt.CreateEncryptor(dataencrypt.Key, dataencrypt.IV);
            //TransformFinalBlock is a special function for transforming the last block or a partial block in the stream.   
            //It returns a new array that contains the remaining transformed bytes. A new array is returned, because the amount of   
            //information returned at the end might be larger than a single block when padding is added.  
            byte[] bytearraytoencrypt = System.Text.Encoding.Default.GetBytes(value);
            byte[] encrypteddata = crypto1.TransformFinalBlock(bytearraytoencrypt, 0, bytearraytoencrypt.Length);
            crypto1.Dispose();
            //return the encrypted data  
            return encrypteddata;

        }
        public static string DeCryptString(Byte[] value)
        {
            string Key_str = File.ReadAllText("Key.dat");
            string IV_str = File.ReadAllText("IV.dat");
            AesCryptoServiceProvider keydecrypt = new AesCryptoServiceProvider();
            keydecrypt.BlockSize = 128;
            keydecrypt.KeySize = 128;
            keydecrypt.Key = System.Text.Encoding.Default.GetBytes(Key_str);
            keydecrypt.IV = System.Text.Encoding.Default.GetBytes(IV_str);
            keydecrypt.Padding = PaddingMode.PKCS7;
            keydecrypt.Mode = CipherMode.CBC;
            ICryptoTransform crypto1 = keydecrypt.CreateDecryptor(keydecrypt.Key, keydecrypt.IV);
            byte[] returnbytearray = crypto1.TransformFinalBlock(value, 0, value.Length);
            crypto1.Dispose();
            return Encoding.Default.GetString(returnbytearray);
        }
    }

}
