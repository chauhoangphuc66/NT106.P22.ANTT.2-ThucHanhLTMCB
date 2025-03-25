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
            SuspendLayout();
            // 
            // Read_btn
            // 
            Read_btn.Location = new Point(139, 63);
            Read_btn.Name = "Read_btn";
            Read_btn.Size = new Size(161, 141);
            Read_btn.TabIndex = 0;
            Read_btn.Text = "Read";
            Read_btn.UseVisualStyleBackColor = true;
            Read_btn.Click += Read_btn_Click;
            // 
            // Write_btn
            // 
            Write_btn.Location = new Point(462, 63);
            Write_btn.Name = "Write_btn";
            Write_btn.Size = new Size(174, 141);
            Write_btn.TabIndex = 1;
            Write_btn.Text = "Write";
            Write_btn.UseVisualStyleBackColor = true;
            Write_btn.Click += Write_btn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(206, 222);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(336, 157);
            textBox1.TabIndex = 2;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(Write_btn);
            Controls.Add(Read_btn);
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Read_btn;
        private Button Write_btn;
        private TextBox textBox1;
    }
}