namespace Lab2
{
    partial class Bai1
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
            components = new System.ComponentModel.Container();
            Read_btn = new Button();
            Write_btn = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Read_btn
            // 
            Read_btn.BackColor = SystemColors.ActiveCaption;
            Read_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Read_btn.Location = new Point(101, 88);
            Read_btn.Name = "Read_btn";
            Read_btn.Size = new Size(208, 107);
            Read_btn.TabIndex = 0;
            Read_btn.Text = "Đọc file";
            Read_btn.UseVisualStyleBackColor = false;
            Read_btn.Click += Read_btn_Click;
            // 
            // Write_btn
            // 
            Write_btn.BackColor = SystemColors.ButtonShadow;
            Write_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Write_btn.Location = new Point(101, 237);
            Write_btn.Name = "Write_btn";
            Write_btn.Size = new Size(208, 107);
            Write_btn.TabIndex = 1;
            Write_btn.Text = "Ghi file";
            Write_btn.UseVisualStyleBackColor = false;
            Write_btn.Click += Write_btn_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(391, 43);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(458, 336);
            textBox1.TabIndex = 3;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 450);
            Controls.Add(textBox1);
            Controls.Add(Write_btn);
            Controls.Add(Read_btn);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Read_btn;
        private Button Write_btn;
        private ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox1;
    }
}