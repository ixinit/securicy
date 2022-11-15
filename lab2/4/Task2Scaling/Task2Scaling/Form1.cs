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

namespace Task2Scaling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            { // надо подключить System.IO;
                try
                {
                    FileStream fr = new FileStream(@".\Plain.txt", FileMode.Open);
                    BinaryReader f1 = new BinaryReader(fr);
                    FileStream fw = new FileStream(@".\Crypt.txt", FileMode.OpenOrCreate);
                    BinaryWriter f2 = new BinaryWriter(fw);
                    // количество блоков по 32 бита в исходном файле
                    long n = fr.Length / 4;
                    int[] x = new int[n];
                    long i = 0;
                    try
                    {
                        while (true) x[i++] = f1.ReadInt32();
                    }
                    catch (EndOfStreamException) { }
                    foreach (int d in x) f2.Write(d ^ 4132);
                    f1.Close();
                    fr.Close();
                    f2.Close();
                    fw.Close();
                    MessageBox.Show("Кодирование прошло успешно!!");
                }
                catch (FileNotFoundException e1)
                {
                    textBox1.Text += e1.Message + (char)13 + (char)10;
                    textBox1.Text += "Проверьте правильность имени файла";
                    return;

                }
                catch (Exception e1)
                {
                    textBox2.Text += "Ошибка:" + e1.Message;
                }


            }
        }
    }
}
