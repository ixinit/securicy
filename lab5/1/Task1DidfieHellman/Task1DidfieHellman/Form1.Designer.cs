
namespace Task1DidfieHellman
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbDecrypted = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCrypted = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbThatCrypt = new System.Windows.Forms.TextBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Сторона Боба (прием)";
            // 
            // tbDecrypted
            // 
            this.tbDecrypted.Location = new System.Drawing.Point(32, 341);
            this.tbDecrypted.Multiline = true;
            this.tbDecrypted.Name = "tbDecrypted";
            this.tbDecrypted.Size = new System.Drawing.Size(481, 50);
            this.tbDecrypted.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Зашифрованная строка";
            // 
            // tbCrypted
            // 
            this.tbCrypted.Location = new System.Drawing.Point(29, 132);
            this.tbCrypted.Multiline = true;
            this.tbCrypted.Name = "tbCrypted";
            this.tbCrypted.Size = new System.Drawing.Size(481, 50);
            this.tbCrypted.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Сторона Алисы (отправка)";
            // 
            // tbThatCrypt
            // 
            this.tbThatCrypt.Location = new System.Drawing.Point(29, 37);
            this.tbThatCrypt.Multiline = true;
            this.tbThatCrypt.Name = "tbThatCrypt";
            this.tbThatCrypt.Size = new System.Drawing.Size(481, 64);
            this.tbThatCrypt.TabIndex = 22;
            this.tbThatCrypt.Text = "ПРИМЕР СТРОКИ ДЛЯ КОДИРОВАНИЯ";
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(32, 397);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(101, 23);
            this.btnDecode.TabIndex = 33;
            this.btnDecode.Text = "Раскодировать";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(29, 188);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(101, 23);
            this.btnCode.TabIndex = 32;
            this.btnCode.Text = "Кодировать";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDecrypted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCrypted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbThatCrypt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDecrypted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCrypted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbThatCrypt;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnCode;
    }
}

