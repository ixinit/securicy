using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1Permutation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            string a = tbThatCrypt.Text;
            string b = tbKey.Text;
            string s = Permutation.Encipher(a, b);
            tbCrypted.Text = s;

        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            string a = tbCrypted.Text;
            string b = tbKey.Text;
            string s = Permutation.Decipher(a, b);
            tbDecrypted.Text = s;
        }
    }
}
