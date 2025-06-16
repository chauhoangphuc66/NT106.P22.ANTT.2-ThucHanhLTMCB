namespace LAB5
{
    partial class Dashboard
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
            label1 = new Label();
            bai1_button = new Button();
            bai2_button = new Button();
            bai3_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(210, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "LAB5";
            label1.Click += label1_Click;
            // 
            // bai1_button
            // 
            bai1_button.Location = new Point(71, 47);
            bai1_button.Name = "bai1_button";
            bai1_button.Size = new Size(157, 57);
            bai1_button.TabIndex = 1;
            bai1_button.Text = "BÀI 1";
            bai1_button.UseVisualStyleBackColor = true;
            bai1_button.Click += bai1_button_Click;
            // 
            // bai2_button
            // 
            bai2_button.Location = new Point(234, 47);
            bai2_button.Name = "bai2_button";
            bai2_button.Size = new Size(157, 57);
            bai2_button.TabIndex = 2;
            bai2_button.Text = "BÀI 2";
            bai2_button.UseVisualStyleBackColor = true;
            bai2_button.Click += bai2_button_Click;
            // 
            // bai3_button
            // 
            bai3_button.Location = new Point(156, 110);
            bai3_button.Name = "bai3_button";
            bai3_button.Size = new Size(157, 57);
            bai3_button.TabIndex = 3;
            bai3_button.Text = "BÀI 3";
            bai3_button.UseVisualStyleBackColor = true;
            bai3_button.Click += bai3_button_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 245);
            Controls.Add(bai3_button);
            Controls.Add(bai2_button);
            Controls.Add(bai1_button);
            Controls.Add(label1);
            Name = "Dashboard";
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bai1_button;
        private Button bai2_button;
        private Button bai3_button;
    }
}
