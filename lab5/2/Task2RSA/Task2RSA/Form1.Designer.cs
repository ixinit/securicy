
namespace Task2RSA
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreatePublicKey = new System.Windows.Forms.Button();
            this.tbWherePublicKey = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tbWherePrivateKey = new System.Windows.Forms.TextBox();
            this.btnCreatePrivateKey = new System.Windows.Forms.Button();
            this.tbSelectedPublicKeyToEncode = new System.Windows.Forms.TextBox();
            this.btnSelectPublicKey = new System.Windows.Forms.Button();
            this.tbSelectedFileToEncode = new System.Windows.Forms.TextBox();
            this.btnSelectEncodingFile = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.rtbWhatEncode = new System.Windows.Forms.RichTextBox();
            this.rtbDecoded = new System.Windows.Forms.RichTextBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.tbSelectedPrivateKey = new System.Windows.Forms.TextBox();
            this.btnSelectPrivateKey = new System.Windows.Forms.Button();
            this.tbSelectedFileToDecode = new System.Windows.Forms.TextBox();
            this.btnSelectFileToDecode = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbWherePrivateKey);
            this.tabPage1.Controls.Add(this.btnCreatePrivateKey);
            this.tabPage1.Controls.Add(this.tbWherePublicKey);
            this.tabPage1.Controls.Add(this.btnCreatePublicKey);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Форма 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtbWhatEncode);
            this.tabPage2.Controls.Add(this.btnEncode);
            this.tabPage2.Controls.Add(this.tbSelectedPublicKeyToEncode);
            this.tabPage2.Controls.Add(this.btnSelectPublicKey);
            this.tabPage2.Controls.Add(this.tbSelectedFileToEncode);
            this.tabPage2.Controls.Add(this.btnSelectEncodingFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Форма 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtbDecoded);
            this.tabPage3.Controls.Add(this.btnDecode);
            this.tabPage3.Controls.Add(this.tbSelectedPrivateKey);
            this.tabPage3.Controls.Add(this.btnSelectPrivateKey);
            this.tabPage3.Controls.Add(this.tbSelectedFileToDecode);
            this.tabPage3.Controls.Add(this.btnSelectFileToDecode);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(789, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Форма 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Файлы созданных ключей";
            // 
            // btnCreatePublicKey
            // 
            this.btnCreatePublicKey.Location = new System.Drawing.Point(468, 60);
            this.btnCreatePublicKey.Name = "btnCreatePublicKey";
            this.btnCreatePublicKey.Size = new System.Drawing.Size(148, 23);
            this.btnCreatePublicKey.TabIndex = 1;
            this.btnCreatePublicKey.Text = "Создать открытый ключ";
            this.btnCreatePublicKey.UseVisualStyleBackColor = true;
            this.btnCreatePublicKey.Click += new System.EventHandler(this.btnCreatePublicKey_Click);
            // 
            // tbWherePublicKey
            // 
            this.tbWherePublicKey.Location = new System.Drawing.Point(67, 62);
            this.tbWherePublicKey.Name = "tbWherePublicKey";
            this.tbWherePublicKey.Size = new System.Drawing.Size(395, 20);
            this.tbWherePublicKey.TabIndex = 2;
            // 
            // tbWherePrivateKey
            // 
            this.tbWherePrivateKey.Location = new System.Drawing.Point(67, 89);
            this.tbWherePrivateKey.Name = "tbWherePrivateKey";
            this.tbWherePrivateKey.Size = new System.Drawing.Size(395, 20);
            this.tbWherePrivateKey.TabIndex = 4;
            // 
            // btnCreatePrivateKey
            // 
            this.btnCreatePrivateKey.Location = new System.Drawing.Point(468, 87);
            this.btnCreatePrivateKey.Name = "btnCreatePrivateKey";
            this.btnCreatePrivateKey.Size = new System.Drawing.Size(148, 23);
            this.btnCreatePrivateKey.TabIndex = 3;
            this.btnCreatePrivateKey.Text = "Создать секретный ключ";
            this.btnCreatePrivateKey.UseVisualStyleBackColor = true;
            this.btnCreatePrivateKey.Click += new System.EventHandler(this.btnCreatePrivateKey_Click);
            // 
            // tbSelectedPublicKeyToEncode
            // 
            this.tbSelectedPublicKeyToEncode.Location = new System.Drawing.Point(26, 65);
            this.tbSelectedPublicKeyToEncode.Name = "tbSelectedPublicKeyToEncode";
            this.tbSelectedPublicKeyToEncode.Size = new System.Drawing.Size(395, 20);
            this.tbSelectedPublicKeyToEncode.TabIndex = 9;
            // 
            // btnSelectPublicKey
            // 
            this.btnSelectPublicKey.Location = new System.Drawing.Point(443, 65);
            this.btnSelectPublicKey.Name = "btnSelectPublicKey";
            this.btnSelectPublicKey.Size = new System.Drawing.Size(167, 23);
            this.btnSelectPublicKey.TabIndex = 8;
            this.btnSelectPublicKey.Text = "Выбирите публичный ключ";
            this.btnSelectPublicKey.UseVisualStyleBackColor = true;
            this.btnSelectPublicKey.Click += new System.EventHandler(this.btnSelectPublicKey_Click);
            // 
            // tbSelectedFileToEncode
            // 
            this.tbSelectedFileToEncode.Location = new System.Drawing.Point(26, 32);
            this.tbSelectedFileToEncode.Name = "tbSelectedFileToEncode";
            this.tbSelectedFileToEncode.Size = new System.Drawing.Size(395, 20);
            this.tbSelectedFileToEncode.TabIndex = 7;
            // 
            // btnSelectEncodingFile
            // 
            this.btnSelectEncodingFile.Location = new System.Drawing.Point(443, 30);
            this.btnSelectEncodingFile.Name = "btnSelectEncodingFile";
            this.btnSelectEncodingFile.Size = new System.Drawing.Size(167, 23);
            this.btnSelectEncodingFile.TabIndex = 6;
            this.btnSelectEncodingFile.Text = "Выбирите файл";
            this.btnSelectEncodingFile.UseVisualStyleBackColor = true;
            this.btnSelectEncodingFile.Click += new System.EventHandler(this.btnSelectEncodingFile_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(36, 276);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(167, 23);
            this.btnEncode.TabIndex = 10;
            this.btnEncode.Text = "Зашифровать";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // rtbWhatEncode
            // 
            this.rtbWhatEncode.Location = new System.Drawing.Point(26, 174);
            this.rtbWhatEncode.Name = "rtbWhatEncode";
            this.rtbWhatEncode.Size = new System.Drawing.Size(584, 96);
            this.rtbWhatEncode.TabIndex = 11;
            this.rtbWhatEncode.Text = "";
            // 
            // rtbDecoded
            // 
            this.rtbDecoded.Location = new System.Drawing.Point(25, 166);
            this.rtbDecoded.Name = "rtbDecoded";
            this.rtbDecoded.Size = new System.Drawing.Size(584, 96);
            this.rtbDecoded.TabIndex = 17;
            this.rtbDecoded.Text = "";
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(35, 268);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(167, 23);
            this.btnDecode.TabIndex = 16;
            this.btnDecode.Text = "Расшифровать";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // tbSelectedPrivateKey
            // 
            this.tbSelectedPrivateKey.Location = new System.Drawing.Point(25, 57);
            this.tbSelectedPrivateKey.Name = "tbSelectedPrivateKey";
            this.tbSelectedPrivateKey.Size = new System.Drawing.Size(395, 20);
            this.tbSelectedPrivateKey.TabIndex = 15;
            // 
            // btnSelectPrivateKey
            // 
            this.btnSelectPrivateKey.Location = new System.Drawing.Point(442, 57);
            this.btnSelectPrivateKey.Name = "btnSelectPrivateKey";
            this.btnSelectPrivateKey.Size = new System.Drawing.Size(167, 23);
            this.btnSelectPrivateKey.TabIndex = 14;
            this.btnSelectPrivateKey.Text = "Выбирите приватный ключ";
            this.btnSelectPrivateKey.UseVisualStyleBackColor = true;
            this.btnSelectPrivateKey.Click += new System.EventHandler(this.btnSelectPrivateKey_Click);
            // 
            // tbSelectedFileToDecode
            // 
            this.tbSelectedFileToDecode.Location = new System.Drawing.Point(25, 24);
            this.tbSelectedFileToDecode.Name = "tbSelectedFileToDecode";
            this.tbSelectedFileToDecode.Size = new System.Drawing.Size(395, 20);
            this.tbSelectedFileToDecode.TabIndex = 13;
            // 
            // btnSelectFileToDecode
            // 
            this.btnSelectFileToDecode.Location = new System.Drawing.Point(442, 22);
            this.btnSelectFileToDecode.Name = "btnSelectFileToDecode";
            this.btnSelectFileToDecode.Size = new System.Drawing.Size(167, 23);
            this.btnSelectFileToDecode.TabIndex = 12;
            this.btnSelectFileToDecode.Text = "Выбирите файл";
            this.btnSelectFileToDecode.UseVisualStyleBackColor = true;
            this.btnSelectFileToDecode.Click += new System.EventHandler(this.btnSelectFileToDecode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbWherePrivateKey;
        private System.Windows.Forms.Button btnCreatePrivateKey;
        private System.Windows.Forms.TextBox tbWherePublicKey;
        private System.Windows.Forms.Button btnCreatePublicKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.RichTextBox rtbWhatEncode;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.TextBox tbSelectedPublicKeyToEncode;
        private System.Windows.Forms.Button btnSelectPublicKey;
        private System.Windows.Forms.TextBox tbSelectedFileToEncode;
        private System.Windows.Forms.Button btnSelectEncodingFile;
        private System.Windows.Forms.RichTextBox rtbDecoded;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.TextBox tbSelectedPrivateKey;
        private System.Windows.Forms.Button btnSelectPrivateKey;
        private System.Windows.Forms.TextBox tbSelectedFileToDecode;
        private System.Windows.Forms.Button btnSelectFileToDecode;
    }
}

