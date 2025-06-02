namespace Lab2
{
    partial class Bai5
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
            listViewFile = new ListView();
            clnName = new ColumnHeader();
            clnSize = new ColumnHeader();
            clnTail = new ColumnHeader();
            clnDate = new ColumnHeader();
            btnOpen = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // listViewFile
            // 
            listViewFile.Columns.AddRange(new ColumnHeader[] { clnName, clnSize, clnTail, clnDate });
            listViewFile.FullRowSelect = true;
            listViewFile.GridLines = true;
            listViewFile.Location = new Point(75, 136);
            listViewFile.Margin = new Padding(2, 3, 2, 3);
            listViewFile.Name = "listViewFile";
            listViewFile.Size = new Size(724, 271);
            listViewFile.TabIndex = 0;
            listViewFile.UseCompatibleStateImageBehavior = false;
            listViewFile.View = View.Details;
            // 
            // clnName
            // 
            clnName.Text = "Tên file";
            clnName.Width = 200;
            // 
            // clnSize
            // 
            clnSize.Text = "Kích thước (byte)";
            clnSize.Width = 180;
            // 
            // clnTail
            // 
            clnTail.Text = "Đuôi mở rộng";
            clnTail.Width = 160;
            // 
            // clnDate
            // 
            clnDate.Text = "Ngày khởi tạo";
            clnDate.Width = 180;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.Snow;
            btnOpen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpen.ForeColor = Color.Black;
            btnOpen.Location = new Point(139, 27);
            btnOpen.Margin = new Padding(2, 3, 2, 3);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(202, 75);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // button1
            // 
            button1.Location = new Point(841, 377);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 2;
            button1.Text = "Quay lại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(952, 419);
            Controls.Add(button1);
            Controls.Add(btnOpen);
            Controls.Add(listViewFile);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Bai5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task5";
            Load += Bai5_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewFile;
        private ColumnHeader clnName;
        private ColumnHeader clnSize;
        private ColumnHeader clnTail;
        private ColumnHeader clnDate;
        private Button btnOpen;
        private Button button1;
    }
}