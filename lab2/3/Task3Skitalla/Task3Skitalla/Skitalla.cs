using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Skitalla
{
    class Skitalla
    {
        int lines = 0;
        public string EncryptText(string s, int diameter_word_length)
        {
            //считаем количество строк
            lines = (s.Length - 1) / diameter_word_length + 1;
            //считаем количество незаполненных ячеек и заполняем пробелами в цикле
            int spaces = lines * diameter_word_length - s.Length;
            for (int l = 0; l < spaces; l++)
                s += " ";
            //создаём буферную матрицу, в которую положим ответ с помощью цикла
            string[,] buffer_array = new string[diameter_word_length, lines];
            //ответ
            string result_text = "";
            int k = 0;
            //заполняем матрицу посимвольно, символы слов записываются в столбики
            for (int i = 0; i < diameter_word_length; i++)
            {
                for (int j = 0; j < lines; j++)
                {
                    buffer_array[i, j] = s.Substring(k, 1);
                    k += 1;
                }
            }
            //переводим матрицу в фразу
            for (int j1 = 0; j1 < lines; j1++)
            {
                for (int i1 = 0; i1 < diameter_word_length; i1++)
                    result_text += buffer_array[i1, j1];
            }
            return result_text;
        }

        public string DecryptText(string s, int diameter_word_length)
        {
            //считаем количество строк
            lines = (s.Length - 1) / diameter_word_length + 1;
            //считаем количество незаполненных ячеек и заполняем пробелами в цикле
            int spaces = lines * diameter_word_length - s.Length;
            for (int l = 0; l < spaces; l++)
                s += " ";
            //заполняем создаём буферную матрицу, в которую положим ответ с помощью цикла
            string[,] buffer_array = new string[diameter_word_length, lines];
            //ответ
            string result_text = "";
            int k = 0;
            //заполняем матрицу посимвольно, символы слов из столбиков записываются в строки
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < diameter_word_length; j++)
                {
                    buffer_array[j, i] = s.Substring(k, 1);
                    k += 1;
                }
            }
            //переводим матрицу в фразу
            for (int j1 = 0; j1 < diameter_word_length; j1++)
            {
                for (int i1 = 0; i1 < lines; i1++)
                    result_text += buffer_array[j1, i1];
            }
            return result_text;
        }

        /*public string Encrypt(string text, int key)
        {
            string temp_str = text;
            for (int i = 0; i < (key - (text.Length % key)); i++)
            {
                temp_str += " ";
            }

            int text_length = temp_str.Length;
            string result = "";

            for (int i = 0; i < text_length/key; i++)
            {
                for(int j = 0; j < key; j++)
                {
                    result += temp_str[j * key+i];
                }
            }

            return result;
        }
        public string Decrypt(string text, int key)
        {
            string temp_str = text;

            int text_length = temp_str.Length;
            string result = "";

            for (int i = 0; i < text_length / key; i++)
            {
                for (int j = 0; j < key; j++)
                {
                    result += temp_str[j * key + i];
                }
            }

            return result;
        }*/
    }
}
