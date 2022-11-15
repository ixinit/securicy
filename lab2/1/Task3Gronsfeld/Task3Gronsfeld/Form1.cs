using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3Gronsfeld
{
    public partial class Form1 : Form
    {
        String key;
        StringBuilder stringBuilder;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            key = tbKey.Text;
            stringBuilder = new StringBuilder(tbThatCrypt.Text);
            tbCrypted.Text = Gronsfeld.Encode(stringBuilder, key).ToString();
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            key = tbKey.Text;
            stringBuilder = new StringBuilder(tbCrypted.Text);
            tbDecrypted.Text = Gronsfeld.Decode(stringBuilder, key).ToString();
        }

       /* private bool parseValues()
        {
            String text;
            if(int.TryParse(tbKey.Text, out key))
            {
                return true;
            }
            return false;
        }*/
    }
}
