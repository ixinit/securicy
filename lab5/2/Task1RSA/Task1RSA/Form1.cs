using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1RSA
{
    public partial class Form1 : Form
    {        //открытые параметры, используемые для шифрования
        RSAParameters rsaParamsExcludePrivate;

        //секретные и открытые PSA параметры, 
        //используемые для дешифрирования
        RSAParameters rsaParamsIncludePrivate;

        //переменная для передачи шифрованного текста
        byte[] cipherbytes;

        public Form1()
        {
            InitializeComponent();
        }
        private void ClearOutputFields()
        {
            textCiphertext.Text = "";
            textCipherbytes.Text = "";
            textRecoveredPlaintext.Text = "";
        }
        private void GenerateNewRSAParams()
        {
            //установить асимметричный алгоритм RSA
            RSACryptoServiceProvider rsa =
            new RSACryptoServiceProvider();

            //извлечь открытые и секретные параметры RSA
            rsaParamsIncludePrivate =
            rsa.ExportParameters(true);

            //извлечь только открытые  параметры RSA
            rsaParamsExcludePrivate =
            rsa.ExportParameters(false);

            //вывести RSA параметры в шестнадцатеричном виде
            StringBuilder sb = new StringBuilder();
            for (int i = 0;
                 i < rsaParamsIncludePrivate.P.Length; i++)
            {
                sb.Append(String.Format("{0,2:X2} ",
                          rsaParamsIncludePrivate.P[i]));
            }
            textBoxP.Text = sb.ToString();
            sb = new StringBuilder();
            for (int i = 0;
                 i < rsaParamsIncludePrivate.Q.Length; i++)
            {
                sb.Append(String.Format("{0,2:X2} ",
                           rsaParamsIncludePrivate.Q[i]));
            }
            textBoxQ.Text = sb.ToString();
            sb = new StringBuilder();
            for (int i = 0;
                    i < rsaParamsIncludePrivate.Modulus.Length;
                        i++)
            {
                sb.Append(String.Format("{0,2:X2} ",
                            rsaParamsIncludePrivate.Modulus[i]));
            }
            textBoxE.Text = sb.ToString();
            sb = new StringBuilder();
            for (int i = 0;
                     i < rsaParamsIncludePrivate.D.Length; i++)
            {
                sb.Append(String.Format("{0,2:X2} ",
                          rsaParamsIncludePrivate.D[i]));
            }
            textBoxD.Text = sb.ToString();
            buttonEncrypt.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateNewRSAParams();
        }
        private void buttonNewRSAParams_Click(object sender, EventArgs e)
        {
            GenerateNewRSAParams();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            ClearOutputFields();
            //установить асимметричный алгоритм RSA
            RSACryptoServiceProvider rsa =
                  new RSACryptoServiceProvider();
            //извлечь только открытые параметры RSA 
            //для шифрования
            rsa.ImportParameters(rsaParamsExcludePrivate);
            //прочитать открытый текст и зашифровать его
            byte[] plainbytes =
              Encoding.UTF8.GetBytes(textPlaintext.Text);
            //         Encoding.Default.GetBytes(textPlaintext.Text);
            cipherbytes =
               rsa.Encrypt(plainbytes, true);
            //отобразить зашифрованный текст как строку
            textCiphertext.Text =
                Encoding.UTF8.GetString(cipherbytes);
            // отобразить зашифрованный текст как 
            //массив байтов (в 16-ричном виде)
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < cipherbytes.Length; i++)
            {
                sb.Append(String.Format("{0,2:X2} ",
cipherbytes[i]));
            }
            textCipherbytes.Text = sb.ToString();
            //обработка пользовательского интерфейса
            buttonNewRSAParams.Enabled = false;
            buttonEncrypt.Enabled = false;
            buttonDecrypt.Enabled = true;
            textPlaintext.Enabled = false;
            buttonDecrypt.Select();
        }
        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            //установить асимметричный алгоритм RSA
            RSACryptoServiceProvider rsa =
                new RSACryptoServiceProvider();
            //импортировать открытый и секретный ключи
            rsa.ImportParameters(rsaParamsIncludePrivate);
            //прочитать шифрованный текст и дешифрировать его
            byte[] plainbytes = rsa.Decrypt(
                        cipherbytes, true);
            //отобразить полученный открытый текст
            textRecoveredPlaintext.Text =
                   Encoding.UTF8.GetString(plainbytes);
            //работа с интерфейсом пользователя
            buttonNewRSAParams.Enabled = true;
            buttonDecrypt.Enabled = false;
            textPlaintext.Enabled = true;
            buttonEncrypt.Select();
        }
    }

}
