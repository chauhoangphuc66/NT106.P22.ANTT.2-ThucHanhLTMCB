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
            label1.Location = new Point(70, 133);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Số thứ 1: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 204);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Số thứ 2: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 277);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 2;
            label3.Text = "Số thứ 3: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(147, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(147, 270);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(89, 317);
            button1.Name = "button1";
            button1.Size = new Size(135, 72);
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
            button2.Location = new Point(332, 317);
            button2.Name = "button2";
            button2.Size = new Size(135, 72);
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
            button3.Location = new Point(573, 317);
            button3.Name = "button3";
            button3.Size = new Size(135, 72);
            button3.TabIndex = 8;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(559, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(559, 229);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(513, 171);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 11;
            label4.Text = "Max:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(512, 232);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 12;
            label5.Text = "Min: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Unispace", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(119, 48);
            label6.Name = "label6";
            label6.Size = new Size(589, 36);
            label6.TabIndex = 13;
            label6.Text = "Số lớn nhất, nhỏ nhất trong 3 số";
            label6.Click += label6_Click;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Bai2";
            Text = "Form4";
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
