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
            listViewFile.Location = new Point(66, 102);
            listViewFile.Margin = new Padding(2);
            listViewFile.Name = "listViewFile";
            listViewFile.Size = new Size(634, 204);
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
            btnOpen.BackColor = Color.Coral;
            btnOpen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpen.ForeColor = Color.White;
            btnOpen.Location = new Point(122, 20);
            btnOpen.Margin = new Padding(2);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(177, 56);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // button1
            // 
            button1.Location = new Point(736, 283);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Quay lại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(833, 314);
            Controls.Add(button1);
            Controls.Add(btnOpen);
            Controls.Add(listViewFile);
            Margin = new Padding(2);
            Name = "Bai5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task5";
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