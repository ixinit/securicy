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

namespace Task1Imaging
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Исходный файл любого формата, будем преобразовывать его в Jpeg, а затем сжимать
            //   string path = "~/Content/samoilova.png";
            string path = "CH2WZ5.jpg";
            string sFileName = path; // HttpContext.Current.Server.MapPath(path);
            pictureBox1.Load(path);
            // Image1.ImageUrl = path;
            //Ищем кодек для jpeg
            string sMimeType = "image/jpeg";
            System.Drawing.Imaging.ImageCodecInfo[] imagecodecinfo = ImageCodecInfo.GetImageEncoders();
            ImageCodecInfo jpimagecodecinfo = null;
            //Находим кодек для jpeg
            //Можно не только найти, но и посмотреть кодеки для разных форматов
            for (int i = 0; i < imagecodecinfo.Length; i++)
            {
                if (imagecodecinfo[i].MimeType == sMimeType)
                {
                    jpimagecodecinfo = imagecodecinfo[i];
                    break;
                }
            }
            //Создаем параметр encoderparameter, в котором определяем категорию качества сжатия для jpeg (0-100)%
            int p = Int32.Parse(textBox1.Text);
            EncoderParameter encoderparameter = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)p);
            EncoderParameters encoderparameters = new EncoderParameters(1);
            encoderparameters.Param[0] = encoderparameter;
            //Загружаем файл любого формата и преобразуем его в Jpeg
            System.IO.MemoryStream memorystream = new System.IO.MemoryStream();
            System.Drawing.Image image = System.Drawing.Image.FromFile(sFileName);
            image.Save(memorystream, ImageFormat.Jpeg);
            image.Dispose();
            //Помещаем в привычный Bitmap
            Bitmap bitmap = new Bitmap(memorystream);
            memorystream.Flush();
            memorystream = new System.IO.MemoryStream();
            //Вносим сжатие для jpeg и параметра - уровня качества сжатия
            bitmap.Save(memorystream, jpimagecodecinfo, encoderparameters);
            //Выводим сжатый файл на страничку в формате jpg
            byte[] b = memorystream.GetBuffer();
            //     string base64String = Convert.ToBase64String(b, 0, b.Length);
            // Image2.ImageUrl = "data:image/jpeg;base64," + base64String;
            label1.Text = "Размер сжатого изображения (байт):" + (b.Length).ToString();
            Image im = Image.FromStream(memorystream);
            //pictureBox2.Load(base64String);
            pictureBox2.Image = im;
            // сохранение сжатых данных в файле
            path = "CH2WZ5_2.jpg";
            sFileName = path; // HttpContext.Current.Server.MapPath(path);
            FileStream f = new FileStream(sFileName, FileMode.Create, FileAccess.Write);
            for (int i = 0; i < b.Length; i++)
            {
                f.WriteByte(b[i]);
            }
            f.Close();

            MessageBox.Show("Сжатие файла прошло успешно!!");
        }
    }
}
