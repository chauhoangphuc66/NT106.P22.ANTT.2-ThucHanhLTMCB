namespace Lab1
{
    partial class Form4
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            sInput = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            bXuat = new Button();
            dAvg = new TextBox();
            dMax = new TextBox();
            iNumDau = new TextBox();
            sHocLuc = new TextBox();
            dMin = new TextBox();
            iNumRot = new TextBox();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(22, 141);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(750, 195);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách môn học và điểm";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 71);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 1;
            label1.Text = "Danh sách điểm:";
            // 
            // sInput
            // 
            sInput.Location = new Point(147, 68);
            sInput.Name = "sInput";
            sInput.Size = new Size(614, 27);
            sInput.TabIndex = 2;
            sInput.TextChanged += sInput_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(245, 24);
            label2.Name = "label2";
            label2.Size = new Size(311, 31);
            label2.TabIndex = 3;
            label2.Text = "PHẦN MỀM QUẢN LÝ ĐIỂM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 354);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 4;
            label3.Text = "Điểm trung bình:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 406);
            label4.Name = "label4";
            label4.Size = new Size(161, 20);
            label4.TabIndex = 5;
            label4.Text = "Môn có điểm cao nhất:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 456);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 6;
            label5.Text = "Số môn đậu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(474, 354);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 7;
            label6.Text = "Xếp loại học lực:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(474, 406);
            label7.Name = "label7";
            label7.Size = new Size(167, 20);
            label7.TabIndex = 8;
            label7.Text = "Môn có điểm thấp nhất:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(474, 456);
            label8.Name = "label8";
            label8.Size = new Size(137, 20);
            label8.TabIndex = 9;
            label8.Text = "Số môn không đậu:";
            // 
            // bXuat
            // 
            bXuat.Location = new Point(667, 106);
            bXuat.Name = "bXuat";
            bXuat.Size = new Size(94, 29);
            bXuat.TabIndex = 10;
            bXuat.Text = "Xuất";
            bXuat.UseVisualStyleBackColor = true;
            bXuat.Click += bXuat_Click;
            // 
            // dAvg
            // 
            dAvg.Location = new Point(158, 354);
            dAvg.Name = "dAvg";
            dAvg.Size = new Size(125, 27);
            dAvg.TabIndex = 11;
            // 
            // dMax
            // 
            dMax.Location = new Point(190, 403);
            dMax.Name = "dMax";
            dMax.Size = new Size(125, 27);
            dMax.TabIndex = 12;
            // 
            // iNumDau
            // 
            iNumDau.Location = new Point(121, 456);
            iNumDau.Name = "iNumDau";
            iNumDau.Size = new Size(125, 27);
            iNumDau.TabIndex = 13;
            // 
            // sHocLuc
            // 
            sHocLuc.Location = new Point(599, 351);
            sHocLuc.Name = "sHocLuc";
            sHocLuc.Size = new Size(125, 27);
            sHocLuc.TabIndex = 14;
            // 
            // dMin
            // 
            dMin.Location = new Point(647, 403);
            dMin.Name = "dMin";
            dMin.Size = new Size(125, 27);
            dMin.TabIndex = 15;
            // 
            // iNumRot
            // 
            iNumRot.Location = new Point(610, 453);
            iNumRot.Name = "iNumRot";
            iNumRot.Size = new Size(125, 27);
            iNumRot.TabIndex = 16;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 579);
            Controls.Add(iNumRot);
            Controls.Add(dMin);
            Controls.Add(sHocLuc);
            Controls.Add(iNumDau);
            Controls.Add(dMax);
            Controls.Add(dAvg);
            Controls.Add(bXuat);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(sInput);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox sInput;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button bXuat;
        private TextBox dAvg;
        private TextBox dMax;
        private TextBox iNumDau;
        private TextBox sHocLuc;
        private TextBox dMin;
        private TextBox iNumRot;
    }
}