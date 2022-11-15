using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Caesar
{
    static class Caeser
    {
        public static StringBuilder Encrypt(StringBuilder plaintext,
          int key)
        {
            StringBuilder ciphertext =
              new StringBuilder(plaintext.ToString());
            for (int index = 0; index < plaintext.Length; index++)
            {
                if (plaintext[index] != ' ')
                {
                    int character =
                    (((plaintext[index] - 'А') + key) % 32) + 'А';
                    ciphertext[index] = (char)character;
                }
            }
            return ciphertext;
        }
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
                    (((plaintext[index] - 'А') + Math.Abs(32-key)) % 32) + 'А';
                    ciphertext[index] = (char)character;
                }
            }
            return ciphertext;
        }
    }
}
