namespace Lab2
{
    partial class Bai3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Read_btn = new Button();
            Write_btn = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Read_btn
            // 
            Read_btn.Location = new Point(122, 47);
            Read_btn.Margin = new Padding(3, 2, 3, 2);
            Read_btn.Name = "Read_btn";
            Read_btn.Size = new Size(141, 106);
            Read_btn.TabIndex = 0;
            Read_btn.Text = "Read";
            Read_btn.UseVisualStyleBackColor = true;
            Read_btn.Click += Read_btn_Click;
            // 
            // Write_btn
            // 
            Write_btn.Location = new Point(404, 47);
            Write_btn.Margin = new Padding(3, 2, 3, 2);
            Write_btn.Name = "Write_btn";
            Write_btn.Size = new Size(152, 106);
            Write_btn.TabIndex = 1;
            Write_btn.Text = "Write";
            Write_btn.UseVisualStyleBackColor = true;
            Write_btn.Click += Write_btn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 166);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 119);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(613, 303);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Quay lại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(Write_btn);
            Controls.Add(Read_btn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Read_btn;
        private Button Write_btn;
        private TextBox textBox1;
        private Button button1;
    }
}