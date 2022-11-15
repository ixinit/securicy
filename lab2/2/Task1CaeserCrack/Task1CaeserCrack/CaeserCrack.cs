using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1CaeserCrack
{
    class CaeserCrack
    {
        public static StringBuilder Decrypt(StringBuilder plaintext,
          int key)
        {
            StringBuilder ciphertext =
              new StringBuilder(plaintext.ToString());
            for (int index = 0; index < plaintext.Length; index++)
            {
                if (plaintext[index] != ' ')
                {
                    int character =
                    (((plaintext[index] - 'А') + Math.Abs(32 - key)) % 32) + 'А';
                    ciphertext[index] = (char)character;
                }
            }
            return ciphertext;
        }
        public static void Brute(TextBox tbInput, TextBox tbOut)
        {
            StringBuilder ciphertext = new StringBuilder(tbInput.Text);
            //Перебор всех возможных вариантов
            for (int testkey = 1; testkey <= 25; testkey++)
            {
                StringBuilder recoveredplaintext = Decrypt(ciphertext, testkey);
                tbOut.Text += recoveredplaintext.ToString();
                tbOut.Text += Environment.NewLine;
            }
        }

    }
}
