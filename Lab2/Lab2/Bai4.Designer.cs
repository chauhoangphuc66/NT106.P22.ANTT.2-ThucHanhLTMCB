namespace Lab2
{
    partial class frmB4
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
            button1 = new Button();
            button2 = new Button();
            grpb = new GroupBox();
            rtbHocVien = new RichTextBox();
            button3 = new Button();
            grpb.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(27, 25);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(135, 48);
            button1.TabIndex = 0;
            button1.Text = "INPUT FILE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(227, 25);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(135, 48);
            button2.TabIndex = 1;
            button2.Text = "OUTPUT FILE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // grpb
            // 
            grpb.Controls.Add(rtbHocVien);
            grpb.Location = new Point(27, 106);
            grpb.Margin = new Padding(2, 2, 2, 2);
            grpb.Name = "grpb";
            grpb.Padding = new Padding(2, 2, 2, 2);
            grpb.Size = new Size(335, 411);
            grpb.TabIndex = 2;
            grpb.TabStop = false;
            grpb.Text = "Danh sách học viên";
            // 
            // rtbHocVien
            // 
            rtbHocVien.AcceptsTab = true;
            rtbHocVien.Location = new Point(0, 22);
            rtbHocVien.Margin = new Padding(2, 2, 2, 2);
            rtbHocVien.Name = "rtbHocVien";
            rtbHocVien.Size = new Size(336, 390);
            rtbHocVien.TabIndex = 0;
            rtbHocVien.Text = "";
            // 
            // button3
            // 
            button3.Location = new Point(158, 78);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Quay lại";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // frmB4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 562);
            Controls.Add(button3);
            Controls.Add(grpb);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmB4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BÀI 4";
            grpb.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grpb;
        private System.Windows.Forms.RichTextBox rtbHocVien;
        private Button button3;
    }
}