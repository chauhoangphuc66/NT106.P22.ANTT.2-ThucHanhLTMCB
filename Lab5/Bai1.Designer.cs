namespace LAB5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai1));
            send_button = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            from_textbox = new TextBox();
            to_textbox = new TextBox();
            password_textbox = new TextBox();
            subject_textbox = new TextBox();
            body_richtextbox = new RichTextBox();
            SuspendLayout();
            // 
            // send_button
            // 
            send_button.FlatAppearance.BorderSize = 2;
            send_button.FlatStyle = FlatStyle.Flat;
            send_button.Location = new Point(29, 26);
            send_button.Name = "send_button";
            send_button.Size = new Size(121, 52);
            send_button.TabIndex = 0;
            send_button.Text = "SEND";
            send_button.UseVisualStyleBackColor = true;
            send_button.Click += send_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(198, 26);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(198, 58);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 2;
            label2.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(506, 26);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(29, 129);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 4;
            label4.Text = "Subject:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(29, 166);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 5;
            label5.Text = "Body:";
            // 
            // from_textbox
            // 
            from_textbox.Location = new Point(250, 26);
            from_textbox.Name = "from_textbox";
            from_textbox.Size = new Size(245, 27);
            from_textbox.TabIndex = 6;
            // 
            // to_textbox
            // 
            to_textbox.Location = new Point(250, 59);
            to_textbox.Name = "to_textbox";
            to_textbox.Size = new Size(245, 27);
            to_textbox.TabIndex = 7;
            // 
            // password_textbox
            // 
            password_textbox.Location = new Point(585, 23);
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(171, 27);
            password_textbox.TabIndex = 8;
            // 
            // subject_textbox
            // 
            subject_textbox.Location = new Point(96, 129);
            subject_textbox.Name = "subject_textbox";
            subject_textbox.Size = new Size(660, 27);
            subject_textbox.TabIndex = 9;
            // 
            // body_richtextbox
            // 
            body_richtextbox.Location = new Point(93, 168);
            body_richtextbox.Name = "body_richtextbox";
            body_richtextbox.Size = new Size(663, 270);
            body_richtextbox.TabIndex = 10;
            body_richtextbox.Text = "";
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(body_richtextbox);
            Controls.Add(subject_textbox);
            Controls.Add(password_textbox);
            Controls.Add(to_textbox);
            Controls.Add(from_textbox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(send_button);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button send_button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox from_textbox;
        private TextBox to_textbox;
        private TextBox password_textbox;
        private TextBox subject_textbox;
        private RichTextBox body_richtextbox;
    }
}