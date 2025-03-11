namespace Lab1
{
    partial class Bai4
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            iNum = new TextBox();
            sInputLabel = new Label();
            sSelect = new Label();
            sTo = new Label();
            bConvert = new Button();
            bReset = new Button();
            groupBox1 = new GroupBox();
            iResult = new TextBox();
            label4 = new Label();
            bThoat = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(248, 153);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(472, 153);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 1;
            // 
            // iNum
            // 
            iNum.Location = new Point(248, 98);
            iNum.Name = "iNum";
            iNum.Size = new Size(375, 27);
            iNum.TabIndex = 2;
            // 
            // sInputLabel
            // 
            sInputLabel.AutoSize = true;
            sInputLabel.Location = new Point(28, 48);
            sInputLabel.Name = "sInputLabel";
            sInputLabel.Size = new Size(93, 20);
            sInputLabel.TabIndex = 3;
            sInputLabel.Text = "Điền một số:";
            // 
            // sSelect
            // 
            sSelect.AutoSize = true;
            sSelect.Location = new Point(75, 100);
            sSelect.Name = "sSelect";
            sSelect.Size = new Size(46, 20);
            sSelect.TabIndex = 4;
            sSelect.Text = "Chọn:";
            // 
            // sTo
            // 
            sTo.AutoSize = true;
            sTo.Location = new Point(417, 153);
            sTo.Name = "sTo";
            sTo.Size = new Size(40, 20);
            sTo.TabIndex = 5;
            sTo.Text = "sang";
            // 
            // bConvert
            // 
            bConvert.Location = new Point(248, 212);
            bConvert.Name = "bConvert";
            bConvert.Size = new Size(166, 51);
            bConvert.TabIndex = 6;
            bConvert.Text = "Convert";
            bConvert.UseVisualStyleBackColor = true;
            bConvert.Click += bConvert_Click;
            // 
            // bReset
            // 
            bReset.Location = new Point(462, 212);
            bReset.Name = "bReset";
            bReset.Size = new Size(161, 51);
            bReset.TabIndex = 7;
            bReset.Text = "Reset";
            bReset.UseVisualStyleBackColor = true;
            bReset.Click += bReset_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(sSelect);
            groupBox1.Controls.Add(sInputLabel);
            groupBox1.Location = new Point(101, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 250);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông số";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // iResult
            // 
            iResult.Location = new Point(248, 326);
            iResult.Name = "iResult";
            iResult.Size = new Size(375, 27);
            iResult.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 329);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 10;
            label4.Text = "Kết quả: ";
            
            // 
            // bThoat
            // 
            bThoat.Location = new Point(535, 377);
            bThoat.Name = "bThoat";
            bThoat.Size = new Size(126, 47);
            bThoat.TabIndex = 11;
            bThoat.Text = "Thoát";
            bThoat.UseVisualStyleBackColor = true;
            bThoat.Click += bThoat_Click;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bThoat);
            Controls.Add(label4);
            Controls.Add(iResult);
            Controls.Add(bReset);
            Controls.Add(bConvert);
            Controls.Add(sTo);
            Controls.Add(iNum);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            Name = "Bai4";
            Text = "Convert HEX,DEC,BIN";
            Load += Bai4_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox iNum;
        private Label sInputLabel;
        private Label sSelect;
        private Label sTo;
        private Button bConvert;
        private Button bReset;
        private GroupBox groupBox1;
        private TextBox iResult;
        private Label label4;
        private Button bThoat;
    }
}