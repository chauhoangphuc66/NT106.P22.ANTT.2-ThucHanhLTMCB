namespace Lab1
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            textResult = new TextBox();
            textInput = new TextBox();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(96, 70);
            label1.Name = "label1";
            label1.Size = new Size(332, 31);
            label1.TabIndex = 0;
            label1.Text = "Nhập vào số nguyên từ 0 đến 9";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(96, 272);
            label2.Name = "label2";
            label2.Size = new Size(92, 31);
            label2.TabIndex = 1;
            label2.Text = "Kết quả";
            // 
            // textResult
            // 
            textResult.Location = new Point(96, 323);
            textResult.Name = "textResult";
            textResult.Size = new Size(493, 27);
            textResult.TabIndex = 2;
            textResult.TextChanged += textBox1_TextChanged;
            // 
            // textInput
            // 
            textInput.Location = new Point(434, 74);
            textInput.Name = "textInput";
            textInput.Size = new Size(155, 27);
            textInput.TabIndex = 3;
            textInput.TextChanged += textInput_TextChanged_1;
            // 
            // button3
            // 
            button3.Location = new Point(614, 272);
            button3.Name = "button3";
            button3.Size = new Size(132, 73);
            button3.TabIndex = 6;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(614, 53);
            button1.Name = "button1";
            button1.Size = new Size(132, 73);
            button1.TabIndex = 7;
            button1.Text = "Đọc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(614, 165);
            button2.Name = "button2";
            button2.Size = new Size(132, 73);
            button2.TabIndex = 8;
            button2.Text = "Xoá";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(textInput);
            Controls.Add(textResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textResult;
        private TextBox textInput;
        private Button button3;
        private Button button1;
        private Button button2;
    }
}