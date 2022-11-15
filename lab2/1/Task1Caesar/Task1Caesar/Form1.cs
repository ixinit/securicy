using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1Caesar
{
    public partial class Form1 : Form
    {
        int key;
        StringBuilder plaintext;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            plaintext = new StringBuilder(tbThatCrypt.Text);
            key = int.Parse(tbKey.Text);
            if (ValidatePlaintext(plaintext))
            {
                while (true) //Проверка корректности ввода ключа
                {
                    if (key >= 0 && key <= 25) //допустимый диапазон
                        break;
                }
                StringBuilder ciphertext =
                  Caeser.Encrypt(plaintext, key);
                tbCrypted.Text = ciphertext.ToString();
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            plaintext = new StringBuilder(tbCrypted.Text);
            key = int.Parse(tbKey.Text);
            if (ValidatePlaintext(plaintext))
            {
                while (true) //Проверка корректности ввода ключа
                {
                    if (key >= 0 && key <= 25) //допустимый диапазон
                        break;
                }
                StringBuilder ciphertext =
                  Caeser.Decrypt(plaintext, key);
                tbDecrypted.Text = ciphertext.ToString();
            }
        }

        static bool ValidatePlaintext(StringBuilder plaintext)
        {
            for (int i = 0; i < plaintext.Length; i++) //Проверка букв в верхнем регистре
            {
                char c = plaintext[i];
                if (!Char.IsUpper(c) && c != ' ')
                {
                    MessageBox.Show("Можно только прописные русские буквы!!!");
                    return false;
                }
            }
            return true;
        }
    }
}
