using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1Scaling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            string text = tbThatCrypt.Text;
            int key = Convert.ToInt32(tbKey.Text);
            string encText = Scaling.XorCrypt(text, key);
            tbCrypted.Text = encText;

        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            string text = tbCrypted.Text;
            int key = Convert.ToInt32(tbKey.Text);
            string encText = Scaling.XorCrypt(text, key);
            tbDecrypted.Text = encText;

        }
    }
}
