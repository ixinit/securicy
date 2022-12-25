using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1RLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = text_input.Text, str = "", ch = "";
            int i, k, j;
            for (i = 0; i < str1.Length;)
            {
                ch = str1.Substring(i, 1);
                k = 0;
                if (i == str1.Length - 1)
                {
                    str += Convert.ToString(ch);
                    break;
                }
                if (str1.Substring(i + 1, 1) == ch)
                {
                    for (j = i; j < str1.Length; j++)
                    {
                        if (str1.Substring(j, 1) == ch)
                        {
                            k++;
                        }
                        else
                            break;
                    }
                    i = j;
                }
                else
                    i++;
                if (k != 0)
                    str += Convert.ToString(k) + Convert.ToString(ch);
                else
                    str += Convert.ToString(ch);

            }
            text_output.Text = str;
            //text_shifr.Text = str;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str1 = text_shifr.Text, str = "", ch = "", s = "", symb = "";
            int i, k = 0, j;
            for (i = 0; i < str1.Length;)
            {
                ch = str1.Substring(i, 1);
                k = 0;
                s = "";

                if ("0123456789".Contains(ch))
                {
                    for (j = i; j < str1.Length; j++)
                    {
                        if ("0123456789".Contains(str1.Substring(j, 1)))
                        {
                            s += str1.Substring(j, 1);
                        }
                        else
                            break;
                    }
                    symb = str1.Substring(j, 1);
                    i = j + 1;
                }
                else
                    i++;
                if (s.Length != 0)
                {
                    for (j = 0; j < Convert.ToInt32(s); j++)
                        str += symb;
                }
                else
                    str += Convert.ToString(ch);
            }
            text_deshifr.Text = str;
        }
    }
}
