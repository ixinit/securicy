using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1DidfieHellman
{
    public partial class Form1 : Form
    {
        public string msg_alisa;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            msg_alisa = tbThatCrypt.Text;
            Alice.My_Main(msg_alisa); // Шифрование и отправка Бобу
                                      //Вывод шифровки
            tbCrypted.Text = Encoding.UTF8.GetString(Alice.encryptedMessage.ToArray());

        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            tbDecrypted.Text = Bob.msg_bob;
        }
    }
}
