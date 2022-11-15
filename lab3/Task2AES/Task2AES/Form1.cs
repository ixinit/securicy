using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2AES
{
    public partial class Form1 : Form
    {
        private AES AES;
        string Key, IVBase64;
        public Form1()
        {
            InitializeComponent();
            AES = new AES();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            (Key, IVBase64) = AES.InitSymmetricEncryptionKeyIV();
            tbCrypted.Text = AES.Encrypt(tbThatCrypt.Text, IVBase64, Key);
            tbKey.Text = Key;
            tbBase.Text = IVBase64;
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            tbDecrypted.Text = AES.Decrypt(tbCrypted.Text, IVBase64, Key);
        }

        private void btnFileCode_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader rd = new StreamReader(ofd.FileName);
                string text = rd.ReadToEnd();
                (Key, IVBase64) = AES.InitSymmetricEncryptionKeyIV();
                string textCrypted = AES.Encrypt(text, IVBase64, Key);
                tbKey.Text = Key;
                tbBase.Text = IVBase64;
                StreamWriter wr = new StreamWriter(ofd.FileName + "cr");
                wr.Write(textCrypted);
                rd.Close();
                wr.Close();
            }
        }

        private void btnFileDecode_Click(object sender, EventArgs e)
        {
            StreamReader rd = new StreamReader(ofd.FileName+"cr");
            string text = rd.ReadToEnd();
            string textCrypted = AES.Decrypt(text, tbBase.Text, tbKey.Text);
            StreamWriter wr = new StreamWriter(ofd.FileName + "dc");
            wr.WriteLine(textCrypted);
            rd.Close();
            wr.Close();
        }
    }
}
