
namespace Task2GZip
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.compress_btn = new System.Windows.Forms.Button();
            this.decompress_btn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(593, 105);
            this.textBox1.TabIndex = 0;
            // 
            // compress_btn
            // 
            this.compress_btn.Location = new System.Drawing.Point(26, 19);
            this.compress_btn.Name = "compress_btn";
            this.compress_btn.Size = new System.Drawing.Size(75, 23);
            this.compress_btn.TabIndex = 1;
            this.compress_btn.Text = "Упаковать";
            this.compress_btn.UseVisualStyleBackColor = true;
            this.compress_btn.Click += new System.EventHandler(this.compress_btn_Click);
            // 
            // decompress_btn
            // 
            this.decompress_btn.Location = new System.Drawing.Point(26, 315);
            this.decompress_btn.Name = "decompress_btn";
            this.decompress_btn.Size = new System.Drawing.Size(88, 23);
            this.decompress_btn.TabIndex = 3;
            this.decompress_btn.Text = "Распаковать";
            this.decompress_btn.UseVisualStyleBackColor = true;
            this.decompress_btn.Click += new System.EventHandler(this.decompress_btn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 159);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(593, 105);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(26, 344);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(593, 105);
            this.textBox3.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 476);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Упаковать из файла в файл";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 511);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.decompress_btn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.compress_btn);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button compress_btn;
        private System.Windows.Forms.Button decompress_btn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
    }
}

