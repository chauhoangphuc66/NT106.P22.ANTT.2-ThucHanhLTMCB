namespace Lab1
{
    partial class Bai2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 100);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Số thứ 1: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 153);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Số thứ 2: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 208);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Số thứ 3: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 94);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 151);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(129, 202);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(78, 238);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(118, 54);
            button1.TabIndex = 6;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Bisque;
            button2.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(290, 238);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(118, 54);
            button2.TabIndex = 7;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(501, 238);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(118, 54);
            button3.TabIndex = 8;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(489, 123);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(489, 172);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(110, 23);
            textBox5.TabIndex = 10;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(449, 128);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 11;
            label4.Text = "Max:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(448, 174);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 12;
            label5.Text = "Min: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Unispace", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(104, 36);
            label6.Name = "label6";
            label6.Size = new Size(491, 29);
            label6.TabIndex = 13;
            label6.Text = "Số lớn nhất, nhỏ nhất trong 3 số";
            label6.Click += label6_Click;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Bai2";
            Text = "MaxMin";
            Load += Bai2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
