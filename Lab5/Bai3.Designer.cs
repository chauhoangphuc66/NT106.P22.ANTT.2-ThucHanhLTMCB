namespace LAB5
{
    partial class Bai3
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            from_textbox = new TextBox();
            to_textbox = new TextBox();
            subject_textbox = new TextBox();
            richTextBox1 = new RichTextBox();
            attach_button = new Button();
            send_button = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 18);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 53);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 1;
            label2.Text = "To:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 110);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 3;
            label4.Text = "Subject:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 145);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Body:";
            // 
            // from_textbox
            // 
            from_textbox.Location = new Point(159, 18);
            from_textbox.Name = "from_textbox";
            from_textbox.ReadOnly = true;
            from_textbox.Size = new Size(360, 27);
            from_textbox.TabIndex = 5;
            from_textbox.Text = "23520139@uit.edu.vn";
            from_textbox.WordWrap = false;
            from_textbox.TextChanged += from_textbox_TextChanged;
            // 
            // to_textbox
            // 
            to_textbox.Location = new Point(159, 50);
            to_textbox.Name = "to_textbox";
            to_textbox.Size = new Size(360, 27);
            to_textbox.TabIndex = 6;
            to_textbox.WordWrap = false;
            // 
            // subject_textbox
            // 
            subject_textbox.Location = new Point(107, 107);
            subject_textbox.Name = "subject_textbox";
            subject_textbox.Size = new Size(657, 27);
            subject_textbox.TabIndex = 7;
            subject_textbox.WordWrap = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(107, 145);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(657, 222);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // attach_button
            // 
            attach_button.Location = new Point(566, 20);
            attach_button.Name = "attach_button";
            attach_button.Size = new Size(105, 53);
            attach_button.TabIndex = 9;
            attach_button.Text = "ATTACH FILE";
            attach_button.UseVisualStyleBackColor = true;
            attach_button.Click += attach_button_Click;
            // 
            // send_button
            // 
            send_button.FlatAppearance.BorderColor = Color.Red;
            send_button.FlatAppearance.BorderSize = 2;
            send_button.FlatStyle = FlatStyle.Flat;
            send_button.Location = new Point(677, 20);
            send_button.Name = "send_button";
            send_button.Size = new Size(87, 53);
            send_button.TabIndex = 10;
            send_button.Text = "SEND";
            send_button.UseVisualStyleBackColor = true;
            send_button.Click += send_button_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(107, 385);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(657, 84);
            listBox1.TabIndex = 11;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 489);
            Controls.Add(listBox1);
            Controls.Add(send_button);
            Controls.Add(attach_button);
            Controls.Add(richTextBox1);
            Controls.Add(subject_textbox);
            Controls.Add(to_textbox);
            Controls.Add(from_textbox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox from_textbox;
        private TextBox to_textbox;
        private TextBox subject_textbox;
        private RichTextBox richTextBox1;
        private Button attach_button;
        private Button send_button;
        private ListBox listBox1;
    }
}