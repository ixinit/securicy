
namespace Task2AES
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDecrypted = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCrypted = new System.Windows.Forms.TextBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnCode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbThatCrypt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBase = new System.Windows.Forms.TextBox();
            this.btnFileDecode = new System.Windows.Forms.Button();
            this.btnFileCode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Key";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(12, 112);
            this.tbKey.Name = "tbKey";
            this.tbKey.ReadOnly = true;
            this.tbKey.Size = new System.Drawing.Size(224, 20);
            this.tbKey.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Расшифрованная строка";
            // 
            // tbDecrypted
            // 
            this.tbDecrypted.Location = new System.Drawing.Point(12, 238);
            this.tbDecrypted.Multiline = true;
            this.tbDecrypted.Name = "tbDecrypted";
            this.tbDecrypted.Size = new System.Drawing.Size(481, 50);
            this.tbDecrypted.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Зашифрованная строка";
            // 
            // tbCrypted
            // 
            this.tbCrypted.Location = new System.Drawing.Point(12, 156);
            this.tbCrypted.Multiline = true;
            this.tbCrypted.Name = "tbCrypted";
            this.tbCrypted.Size = new System.Drawing.Size(481, 50);
            this.tbCrypted.TabIndex = 14;
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(687, 57);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(101, 23);
            this.btnDecode.TabIndex = 13;
            this.btnDecode.Text = "Раскодировать";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(687, 28);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(101, 23);
            this.btnCode.TabIndex = 12;
            this.btnCode.Text = "Кодировать";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Исходная строка";
            // 
            // tbThatCrypt
            // 
            this.tbThatCrypt.Location = new System.Drawing.Point(12, 30);
            this.tbThatCrypt.Multiline = true;
            this.tbThatCrypt.Name = "tbThatCrypt";
            this.tbThatCrypt.Size = new System.Drawing.Size(481, 64);
            this.tbThatCrypt.TabIndex = 10;
            this.tbThatCrypt.Text = "ПРИМЕР СТРОКИ ДЛЯ КОДИРОВАНИЯ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "IVBase64";
            // 
            // tbBase
            // 
            this.tbBase.Location = new System.Drawing.Point(257, 112);
            this.tbBase.Name = "tbBase";
            this.tbBase.ReadOnly = true;
            this.tbBase.Size = new System.Drawing.Size(236, 20);
            this.tbBase.TabIndex = 20;
            // 
            // btnFileDecode
            // 
            this.btnFileDecode.Location = new System.Drawing.Point(3, 60);
            this.btnFileDecode.Name = "btnFileDecode";
            this.btnFileDecode.Size = new System.Drawing.Size(101, 23);
            this.btnFileDecode.TabIndex = 23;
            this.btnFileDecode.Text = "Раскодировать";
            this.btnFileDecode.UseVisualStyleBackColor = true;
            this.btnFileDecode.Click += new System.EventHandler(this.btnFileDecode_Click);
            // 
            // btnFileCode
            // 
            this.btnFileCode.Location = new System.Drawing.Point(3, 31);
            this.btnFileCode.Name = "btnFileCode";
            this.btnFileCode.Size = new System.Drawing.Size(101, 23);
            this.btnFileCode.TabIndex = 22;
            this.btnFileCode.Text = "Кодировать";
            this.btnFileCode.UseVisualStyleBackColor = true;
            this.btnFileCode.Click += new System.EventHandler(this.btnFileCode_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnFileCode);
            this.panel1.Controls.Add(this.btnFileDecode);
            this.panel1.Location = new System.Drawing.Point(681, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 100);
            this.panel1.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbBase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDecrypted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCrypted);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbThatCrypt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDecrypted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCrypted;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbThatCrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBase;
        private System.Windows.Forms.Button btnFileDecode;
        private System.Windows.Forms.Button btnFileCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

