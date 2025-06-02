namespace LAB5
{
    partial class Bai2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            login_button = new Button();
            email_textbox = new TextBox();
            password_textbox = new TextBox();
            total_textbox = new TextBox();
            recent_textbox = new TextBox();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 2;
            label3.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(190, 98);
            label4.Name = "label4";
            label4.Size = new Size(142, 23);
            label4.TabIndex = 3;
            label4.Text = "Recent message:";
            // 
            // login_button
            // 
            login_button.Location = new Point(474, 21);
            login_button.Name = "login_button";
            login_button.Size = new Size(127, 49);
            login_button.TabIndex = 4;
            login_button.Text = "LOGIN";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // email_textbox
            // 
            email_textbox.Location = new Point(109, 14);
            email_textbox.Name = "email_textbox";
            email_textbox.Size = new Size(311, 27);
            email_textbox.TabIndex = 5;
            // 
            // password_textbox
            // 
            password_textbox.Location = new Point(109, 47);
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(311, 27);
            password_textbox.TabIndex = 6;
            // 
            // total_textbox
            // 
            total_textbox.Location = new Point(80, 91);
            total_textbox.Name = "total_textbox";
            total_textbox.ReadOnly = true;
            total_textbox.Size = new Size(63, 27);
            total_textbox.TabIndex = 7;
            // 
            // recent_textbox
            // 
            recent_textbox.Location = new Point(338, 94);
            recent_textbox.Name = "recent_textbox";
            recent_textbox.ReadOnly = true;
            recent_textbox.Size = new Size(263, 27);
            recent_textbox.TabIndex = 8;
            // 
            // listView1
            // 
            listView1.Location = new Point(27, 155);
            listView1.Name = "listView1";
            listView1.Size = new Size(574, 239);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(613, 406);
            Controls.Add(listView1);
            Controls.Add(recent_textbox);
            Controls.Add(total_textbox);
            Controls.Add(password_textbox);
            Controls.Add(email_textbox);
            Controls.Add(login_button);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button login_button;
        private TextBox email_textbox;
        private TextBox password_textbox;
        private TextBox total_textbox;
        private TextBox recent_textbox;
        private ListView listView1;
    }
}