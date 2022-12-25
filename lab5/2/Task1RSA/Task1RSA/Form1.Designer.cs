
namespace Task1RSA
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
            this.buttonNewRSAParams = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textPlaintext = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textCiphertext = new System.Windows.Forms.TextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textRecoveredPlaintext = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textCipherbytes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNewRSAParams
            // 
            this.buttonNewRSAParams.Location = new System.Drawing.Point(62, 13);
            this.buttonNewRSAParams.Name = "buttonNewRSAParams";
            this.buttonNewRSAParams.Size = new System.Drawing.Size(137, 23);
            this.buttonNewRSAParams.TabIndex = 0;
            this.buttonNewRSAParams.Text = "Гененрация ключей";
            this.buttonNewRSAParams.UseVisualStyleBackColor = true;
            this.buttonNewRSAParams.Click += new System.EventHandler(this.buttonNewRSAParams_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Параметры алгоритма RSA";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(62, 92);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(688, 20);
            this.textBoxP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "P";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Q";
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(62, 118);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(688, 20);
            this.textBoxQ.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "E";
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(62, 144);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(688, 20);
            this.textBoxE.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "D";
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(62, 170);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(688, 20);
            this.textBoxD.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Исходный текст";
            // 
            // textPlaintext
            // 
            this.textPlaintext.Location = new System.Drawing.Point(35, 244);
            this.textPlaintext.Name = "textPlaintext";
            this.textPlaintext.Size = new System.Drawing.Size(715, 20);
            this.textPlaintext.TabIndex = 10;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(35, 270);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(137, 23);
            this.buttonEncrypt.TabIndex = 12;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Зашифрованный текст";
            // 
            // textCiphertext
            // 
            this.textCiphertext.Location = new System.Drawing.Point(35, 326);
            this.textCiphertext.Name = "textCiphertext";
            this.textCiphertext.Size = new System.Drawing.Size(715, 20);
            this.textCiphertext.TabIndex = 13;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(35, 421);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(137, 23);
            this.buttonDecrypt.TabIndex = 15;
            this.buttonDecrypt.Text = "Расшифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // textRecoveredPlaintext
            // 
            this.textRecoveredPlaintext.Location = new System.Drawing.Point(35, 466);
            this.textRecoveredPlaintext.Name = "textRecoveredPlaintext";
            this.textRecoveredPlaintext.Size = new System.Drawing.Size(715, 20);
            this.textRecoveredPlaintext.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Зашифрованный текст в вивде массива байт";
            // 
            // textCipherbytes
            // 
            this.textCipherbytes.Location = new System.Drawing.Point(35, 372);
            this.textCipherbytes.Name = "textCipherbytes";
            this.textCipherbytes.Size = new System.Drawing.Size(715, 20);
            this.textCipherbytes.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Дешифрованный текст";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textCipherbytes);
            this.Controls.Add(this.textRecoveredPlaintext);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textCiphertext);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textPlaintext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNewRSAParams);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewRSAParams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPlaintext;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCiphertext;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textRecoveredPlaintext;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textCipherbytes;
        private System.Windows.Forms.Label label9;
    }
}

