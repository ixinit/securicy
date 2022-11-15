using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1CaeserCrack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrute_Click(object sender, EventArgs e)
        {
            CaeserCrack.Brute(tbCrypted, tbBrut);
        }
    }
}
