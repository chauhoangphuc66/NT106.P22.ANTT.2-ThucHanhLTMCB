namespace Lab2
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            fileName = new TextBox();
            fileURL = new TextBox();
            fileRow = new TextBox();
            fileWord = new TextBox();
            fileChar = new TextBox();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(38, 9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(233, 67);
            button1.TabIndex = 0;
            button1.Text = "ĐỌC FILE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 93);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Tên file";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 132);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "URL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 174);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "Số dòng";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 217);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 4;
            label4.Text = "Số từ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 256);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 5;
            label5.Text = "Số ký tự";
            // 
            // fileName
            // 
            fileName.Location = new Point(68, 91);
            fileName.Margin = new Padding(3, 2, 3, 2);
            fileName.Name = "fileName";
            fileName.Size = new Size(238, 23);
            fileName.TabIndex = 6;
            // 
            // fileURL
            // 
            fileURL.Location = new Point(68, 130);
            fileURL.Margin = new Padding(3, 2, 3, 2);
            fileURL.Name = "fileURL";
            fileURL.Size = new Size(238, 23);
            fileURL.TabIndex = 7;
            // 
            // fileRow
            // 
            fileRow.Location = new Point(68, 172);
            fileRow.Margin = new Padding(3, 2, 3, 2);
            fileRow.Name = "fileRow";
            fileRow.Size = new Size(238, 23);
            fileRow.TabIndex = 8;
            // 
            // fileWord
            // 
            fileWord.Location = new Point(68, 214);
            fileWord.Margin = new Padding(3, 2, 3, 2);
            fileWord.Name = "fileWord";
            fileWord.Size = new Size(238, 23);
            fileWord.TabIndex = 9;
            // 
            // fileChar
            // 
            fileChar.Location = new Point(68, 254);
            fileChar.Margin = new Padding(3, 2, 3, 2);
            fileChar.Name = "fileChar";
            fileChar.Size = new Size(238, 23);
            fileChar.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(312, 9);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(388, 309);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(127, 295);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Quay lại";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(fileChar);
            Controls.Add(fileWord);
            Controls.Add(fileRow);
            Controls.Add(fileURL);
            Controls.Add(fileName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox fileName;
        private TextBox fileURL;
        private TextBox fileRow;
        private TextBox fileWord;
        private TextBox fileChar;
        private RichTextBox richTextBox1;
        private Button button2;
    }
}
