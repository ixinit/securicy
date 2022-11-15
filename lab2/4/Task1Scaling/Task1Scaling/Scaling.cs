using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Scaling
{
    class Scaling
    {
        public static string XorCrypt(string text, int key)
        {
            string newText = "";

            for (int i = 0; i < text.Length; i++)
            {
                // Получаем ASCII-код символа
                int charValue = Convert.ToInt32(text[i]);
                // XOR-им символ
                charValue ^= key;//длина ключа д.б.<=5 цифр

                // Преобразуем результат обратно в строку
                newText += char.ConvertFromUtf32(charValue);
            }

            return newText;
        }

    }
}
