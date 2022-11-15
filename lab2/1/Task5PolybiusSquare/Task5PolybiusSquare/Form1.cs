using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5PolybiusSquare
{
    public partial class Form1 : Form
    {
        PolybiosSquare polybios;
        public Form1()
        {
            InitializeComponent();
            polybios = new PolybiosSquare();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            tbCrypted.Text = polybios.PolybiosEncrypt(tbThatCrypt.Text, tbKey.Text);
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            tbDecrypted.Text = polybios.PolybiosDecrypt(tbCrypted.Text, tbKey.Text);
        }
    }
}
