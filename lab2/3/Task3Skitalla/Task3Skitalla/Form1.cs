using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3Skitalla
{
    public partial class Form1 : Form
    {
        Skitalla skitalla = new Skitalla();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            tbCrypted.Text = skitalla.EncryptText(tbThatCrypt.Text, int.Parse(tbKey.Text));
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            tbDecrypted.Text = skitalla.DecryptText(tbCrypted.Text, int.Parse(tbKey.Text));
        }
    }
}
