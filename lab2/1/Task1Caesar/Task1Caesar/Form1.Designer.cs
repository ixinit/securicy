
namespace Task1Caesar
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
            this.tbThatCrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCrypted = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDecrypted = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbThatCrypt
            // 
            this.tbThatCrypt.Location = new System.Drawing.Point(12, 25);
            this.tbThatCrypt.Multiline = true;
            this.tbThatCrypt.Name = "tbThatCrypt";
            this.tbThatCrypt.Size = new System.Drawing.Size(481, 64);
            this.tbThatCrypt.TabIndex = 0;
            this.tbThatCrypt.Text = "ПРИМЕР СТРОКИ ДЛЯ КОДИРОВАНИЯ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Исходная строка";
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(687, 23);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(101, 23);
            this.btnCode.TabIndex = 2;
            this.btnCode.Text = "Кодировать";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(687, 52);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(101, 23);
            this.btnDecode.TabIndex = 3;
            this.btnDecode.Text = "Раскодировать";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Зашифрованная строка";
            // 
            // tbCrypted
            // 
            this.tbCrypted.Location = new System.Drawing.Point(12, 151);
            this.tbCrypted.Multiline = true;
            this.tbCrypted.Name = "tbCrypted";
            this.tbCrypted.Size = new System.Drawing.Size(481, 50);
            this.tbCrypted.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Расшифрованная строка";
            // 
            // tbDecrypted
            // 
            this.tbDecrypted.Location = new System.Drawing.Point(12, 233);
            this.tbDecrypted.Multiline = true;
            this.tbDecrypted.Name = "tbDecrypted";
            this.tbDecrypted.Size = new System.Drawing.Size(481, 50);
            this.tbDecrypted.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Цифровой ключ";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(12, 107);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(116, 20);
            this.tbKey.TabIndex = 8;
            this.tbKey.Text = "2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbThatCrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCrypted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDecrypted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKey;
    }
}

