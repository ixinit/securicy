using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1Stega
{
    public partial class Form1 : Form
    {

        private Bitmap bmp = null;
        private string extractedText = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//Hide
            bmp = (Bitmap)pictureBox1.Image;

            string text = textBox1.Text;

            if (text.Equals(""))
            {
                MessageBox.Show("The text you want to hide can't be empty", "Warning");

                return;
            }

            if (checkBox1.Checked)
            {
                if (textBox2.Text.Length < 6)
                {
                    MessageBox.Show("Please enter a password with at least 6 characters", "Warning");

                    return;
                }
                else
                {
                    text = Crypto.EncryptStringAES(text, textBox2.Text);
                }
            }

            bmp = SteganographyHelper.embedText(text, bmp);

            MessageBox.Show("Your text was hidden in the image successfully!", "Done");

            label1.Text = "Notes: don't forget to save your new image.";
            label1.ForeColor = Color.OrangeRed;
        }

        private void button2_Click(object sender, EventArgs e)
        {//Extract
            bmp = (Bitmap)pictureBox1.Image;

            string extractedText = SteganographyHelper.extractText(bmp);

            if (checkBox1.Checked)
            {
                try
                {
                    extractedText = Crypto.DecryptStringAES(extractedText, textBox2.Text);
                }
                catch
                {
                    MessageBox.Show("Wrong password", "Error");

                    return;
                }
            }

            textBox1.Text = extractedText;
        }

        // МЕНЮ
        private void imageToolStripMenuItem1_Click(object sender, EventArgs e)
        {//открыть изо
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open_dialog.FileName);
            }
        }

        private void textToolStripMenuItem1_Click(object sender, EventArgs e)
        {//открыть текст
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Text Files|*.txt";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(open_dialog.FileName);
            }
        }

        private void imageToolStripMenuItem2_Click(object sender, EventArgs e)
        {//Сохранить изо
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Png Image|*.png|Bitmap Image|*.bmp";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                switch (save_dialog.FilterIndex)
                {
                    case 1:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Png);
                        }
                        break;
                    case 2:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Bmp);
                        }
                        break;
                }

                label1.Text = "Notes:";
                label1.ForeColor = Color.Black;
            }
        }

        private void textToolStripMenuItem2_Click(object sender, EventArgs e)
        {//сохранить текст
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Text Files|*.txt";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save_dialog.FileName, textBox1.Text);
            }
        }
    }

}
