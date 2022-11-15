
namespace Task1CaeserCrack
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbBrut = new System.Windows.Forms.TextBox();
            this.btnBrute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCrypted = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Зашифрованная строка";
            // 
            // tbBrut
            // 
            this.tbBrut.Location = new System.Drawing.Point(12, 159);
            this.tbBrut.Multiline = true;
            this.tbBrut.Name = "tbBrut";
            this.tbBrut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbBrut.Size = new System.Drawing.Size(561, 279);
            this.tbBrut.TabIndex = 14;
            // 
            // btnBrute
            // 
            this.btnBrute.Location = new System.Drawing.Point(678, 33);
            this.btnBrute.Name = "btnBrute";
            this.btnBrute.Size = new System.Drawing.Size(101, 23);
            this.btnBrute.TabIndex = 12;
            this.btnBrute.Text = "Взломать";
            this.btnBrute.UseVisualStyleBackColor = true;
            this.btnBrute.Click += new System.EventHandler(this.btnBrute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Исходная строка";
            // 
            // tbCrypted
            // 
            this.tbCrypted.Location = new System.Drawing.Point(12, 33);
            this.tbCrypted.Multiline = true;
            this.tbCrypted.Name = "tbCrypted";
            this.tbCrypted.Size = new System.Drawing.Size(561, 91);
            this.tbCrypted.TabIndex = 10;
            this.tbCrypted.Text = "ЫЬФШСЬ ЭЮЬЪЦФ РЧЛ ОУЧЪШМ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBrut);
            this.Controls.Add(this.btnBrute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCrypted);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBrut;
        private System.Windows.Forms.Button btnBrute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCrypted;
    }
}

