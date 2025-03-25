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
            outputBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(44, 12);
            button1.Name = "button1";
            button1.Size = new Size(266, 89);
            button1.TabIndex = 0;
            button1.Text = "ĐỌC FILE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 124);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên file";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 176);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 2;
            label2.Text = "URL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 232);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 3;
            label3.Text = "Số dòng";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 289);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 4;
            label4.Text = "Số từ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 341);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 5;
            label5.Text = "Số ký tự";
            // 
            // fileName
            // 
            fileName.Location = new Point(78, 121);
            fileName.Name = "fileName";
            fileName.Size = new Size(272, 27);
            fileName.TabIndex = 6;
            // 
            // fileURL
            // 
            fileURL.Location = new Point(78, 173);
            fileURL.Name = "fileURL";
            fileURL.Size = new Size(272, 27);
            fileURL.TabIndex = 7;
            // 
            // fileRow
            // 
            fileRow.Location = new Point(78, 229);
            fileRow.Name = "fileRow";
            fileRow.Size = new Size(272, 27);
            fileRow.TabIndex = 8;
            // 
            // fileWord
            // 
            fileWord.Location = new Point(78, 286);
            fileWord.Name = "fileWord";
            fileWord.Size = new Size(272, 27);
            fileWord.TabIndex = 9;
            // 
            // fileChar
            // 
            fileChar.Location = new Point(78, 338);
            fileChar.Name = "fileChar";
            fileChar.Size = new Size(272, 27);
            fileChar.TabIndex = 10;
            // 
            // outputBox
            // 
            outputBox.Location = new Point(356, 12);
            outputBox.Multiline = true;
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(432, 426);
            outputBox.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outputBox);
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
        private TextBox outputBox;
    }
}
