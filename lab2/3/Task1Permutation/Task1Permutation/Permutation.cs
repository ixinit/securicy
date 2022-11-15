using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Permutation
{
    static class Permutation
    {
        public static string Encipher(string toCode, string K)
        { // перестановка простая
            //надо проверять, чтобы в исх строке было целое число блоков
            int number, sdvig;
            string newText = "";
            char[] sym = toCode.ToCharArray();
            int Key = Convert.ToInt32(K);
            int Num = -1;// номер блока в строке
            for (int i = 0; i < toCode.Length; i++) //перебор символов кодируемой строки
            {
                number = i % K.Length; //номер очередной цифры ключа
                if (number == 0) Num++; // номер блока
                sdvig = Convert.ToInt32(K[number]) - 48;//цифра в ключе
                int pos = sdvig + Num * K.Length; //поз символа в результ строке
                // символ исх в результат - строку
                if (pos <= toCode.Length) sym[pos - 1] = toCode[i];
            }
            // преобразовать массив символов в строку
            for (int i = 0; i < toCode.Length; i++) newText = newText + sym[i];
            return newText;
        }
        public static string Decipher(string toDecode, string K)
        {
            int number, sdvig;
            string newText = "";
            char[] sym = toDecode.ToCharArray();
            char[] sym_key = K.ToCharArray();
            char[] N = { '1', '2', '3', '4', '5', '6', '7', '8' };
            int Key = Convert.ToInt32(K);
            int Num = -1;// номер блока в строке
            // сформировать новый ключ расшифровки
            for (int i = 0; i < K.Length; i++) //перебор символов ключа
            {
                int cif = (int)(K[i]) - 48;
                sym_key[cif - 1] = N[i];
            }  // новый ключ sym_key создан
            for (int i = 0; i < toDecode.Length; i++) //перебор символов кодируемой строки
            {
                number = i % K.Length; //номер очередной цифры ключа
                if (number == 0) Num++; // номер блока
                sdvig = Convert.ToInt32(sym_key[number]) - 48;//цифра в ключе
                int pos = sdvig + Num * K.Length; //поз символа в результ строке
                // отобранный символ исх в результат - строку
                if (pos <= toDecode.Length) sym[pos - 1] = toDecode[i];
            }
            // преобразовать массив символов в строку
            for (int i = 0; i < toDecode.Length; i++) newText = newText + sym[i];
            return newText;
        }

    }
}
