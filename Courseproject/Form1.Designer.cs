namespace Courseproject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            enResLable = new Label();
            EncryptB = new Button();
            enKeyNameLabel = new Label();
            enOutNameLabel = new Label();
            enFileNameLabel = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            decResLable = new Label();
            DecryptB = new Button();
            decFileNameLabel = new Label();
            decOutNameLabel = new Label();
            decKeyNameLabel = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(enResLable);
            groupBox1.Controls.Add(EncryptB);
            groupBox1.Controls.Add(enKeyNameLabel);
            groupBox1.Controls.Add(enOutNameLabel);
            groupBox1.Controls.Add(enFileNameLabel);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 148);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Шифратор";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 63);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 10;
            label1.Text = "Вихідний файл:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 43);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 9;
            label2.Text = "Зберегти ключ: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 8;
            label3.Text = "Початковий файл:";
            // 
            // enResLable
            // 
            enResLable.AutoSize = true;
            enResLable.Location = new Point(9, 118);
            enResLable.Name = "enResLable";
            enResLable.Size = new Size(50, 20);
            enResLable.TabIndex = 7;
            enResLable.Text = "label7";
            enResLable.Click += enResLable_Click;
            // 
            // EncryptB
            // 
            EncryptB.Location = new Point(6, 86);
            EncryptB.Name = "EncryptB";
            EncryptB.Size = new Size(135, 29);
            EncryptB.TabIndex = 3;
            EncryptB.Text = "Шифрувати";
            EncryptB.UseVisualStyleBackColor = true;
            EncryptB.Click += EncryptB_Click;
            // 
            // enKeyNameLabel
            // 
            enKeyNameLabel.AutoSize = true;
            enKeyNameLabel.Cursor = Cursors.Hand;
            enKeyNameLabel.Location = new Point(147, 63);
            enKeyNameLabel.Name = "enKeyNameLabel";
            enKeyNameLabel.Size = new Size(50, 20);
            enKeyNameLabel.TabIndex = 2;
            enKeyNameLabel.Text = "label3";
            enKeyNameLabel.Click += enKeyNameLabel_Click;
            // 
            // enOutNameLabel
            // 
            enOutNameLabel.AutoSize = true;
            enOutNameLabel.Cursor = Cursors.Hand;
            enOutNameLabel.Location = new Point(147, 43);
            enOutNameLabel.Name = "enOutNameLabel";
            enOutNameLabel.Size = new Size(50, 20);
            enOutNameLabel.TabIndex = 1;
            enOutNameLabel.Text = "label2";
            enOutNameLabel.Click += enOutNameLabel_Click;
            // 
            // enFileNameLabel
            // 
            enFileNameLabel.AutoSize = true;
            enFileNameLabel.Cursor = Cursors.Hand;
            enFileNameLabel.Location = new Point(147, 23);
            enFileNameLabel.Name = "enFileNameLabel";
            enFileNameLabel.Size = new Size(50, 20);
            enFileNameLabel.TabIndex = 0;
            enFileNameLabel.Text = "label1";
            enFileNameLabel.Click += enFileNameLabel_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(decResLable);
            groupBox2.Controls.Add(DecryptB);
            groupBox2.Controls.Add(decFileNameLabel);
            groupBox2.Controls.Add(decOutNameLabel);
            groupBox2.Controls.Add(decKeyNameLabel);
            groupBox2.Location = new Point(12, 166);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 148);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Дешифратор";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 63);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 13;
            label4.Text = "Вихідний файл:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 43);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 12;
            label5.Text = "Ключ: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 23);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 11;
            label6.Text = "Початковий файл:";
            // 
            // decResLable
            // 
            decResLable.AutoSize = true;
            decResLable.Location = new Point(9, 118);
            decResLable.Name = "decResLable";
            decResLable.Size = new Size(50, 20);
            decResLable.TabIndex = 8;
            decResLable.Text = "label8";
            decResLable.Click += decResLable_Click;
            // 
            // DecryptB
            // 
            DecryptB.Location = new Point(6, 86);
            DecryptB.Name = "DecryptB";
            DecryptB.Size = new Size(135, 29);
            DecryptB.TabIndex = 6;
            DecryptB.Text = "Дешифрувати";
            DecryptB.UseVisualStyleBackColor = true;
            DecryptB.Click += DecryptB_Click;
            // 
            // decFileNameLabel
            // 
            decFileNameLabel.AutoSize = true;
            decFileNameLabel.Cursor = Cursors.Hand;
            decFileNameLabel.Location = new Point(147, 23);
            decFileNameLabel.Name = "decFileNameLabel";
            decFileNameLabel.Size = new Size(50, 20);
            decFileNameLabel.TabIndex = 5;
            decFileNameLabel.Text = "label4";
            decFileNameLabel.Click += decFileNameLabel_Click;
            // 
            // decOutNameLabel
            // 
            decOutNameLabel.AutoSize = true;
            decOutNameLabel.Cursor = Cursors.Hand;
            decOutNameLabel.Location = new Point(147, 63);
            decOutNameLabel.Name = "decOutNameLabel";
            decOutNameLabel.Size = new Size(50, 20);
            decOutNameLabel.TabIndex = 4;
            decOutNameLabel.Text = "label5";
            decOutNameLabel.Click += decOutNameLabel_Click;
            // 
            // decKeyNameLabel
            // 
            decKeyNameLabel.AutoSize = true;
            decKeyNameLabel.Cursor = Cursors.Hand;
            decKeyNameLabel.Location = new Point(147, 43);
            decKeyNameLabel.Name = "decKeyNameLabel";
            decKeyNameLabel.Size = new Size(50, 20);
            decKeyNameLabel.TabIndex = 3;
            decKeyNameLabel.Text = "label6";
            decKeyNameLabel.Click += decKeyNameLabel_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 326);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "KCipher-2";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label enKeyNameLabel;
        private Label enOutNameLabel;
        private Label enFileNameLabel;
        private Label decFileNameLabel;
        private Label decOutNameLabel;
        private Label decKeyNameLabel;
        private OpenFileDialog openFileDialog1;
        private Label enResLable;
        private Button EncryptB;
        private Label decResLable;
        private Button DecryptB;
        private SaveFileDialog saveFileDialog1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
