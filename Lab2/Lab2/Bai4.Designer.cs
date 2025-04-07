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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpb = new System.Windows.Forms.GroupBox();
            this.rtbHocVien = new System.Windows.Forms.RichTextBox();
            this.grpb.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "INPUT FILE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 80);
            this.button2.TabIndex = 1;
            this.button2.Text = "OUTPUT FILE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grpb
            // 
            this.grpb.Controls.Add(this.rtbHocVien);
            this.grpb.Location = new System.Drawing.Point(47, 176);
            this.grpb.Name = "grpb";
            this.grpb.Size = new System.Drawing.Size(575, 685);
            this.grpb.TabIndex = 2;
            this.grpb.TabStop = false;
            this.grpb.Text = "Danh sách học viên";
            // 
            // rtbHocVien
            // 
            this.rtbHocVien.AcceptsTab = true;
            this.rtbHocVien.Location = new System.Drawing.Point(0, 37);
            this.rtbHocVien.Name = "rtbHocVien";
            this.rtbHocVien.Size = new System.Drawing.Size(574, 648);
            this.rtbHocVien.TabIndex = 0;
            this.rtbHocVien.Text = "";
            // 
            // frmB4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 937);
            this.Controls.Add(this.grpb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmB4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÀI 4";
            this.grpb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grpb;
        private System.Windows.Forms.RichTextBox rtbHocVien;
    }
}