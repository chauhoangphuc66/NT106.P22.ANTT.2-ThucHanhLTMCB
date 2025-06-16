namespace WhiteboardClient;

partial class Form1
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
        pictureBox1 = new PictureBox();
        lblStatus = new Label();
        lblClients = new Label();
        txtImageUrl = new TextBox();
        btnInsertImage = new Button();
        btnEnd = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        
        // pictureBox1
        pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pictureBox1.Location = new Point(0, 50);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(800, 400);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        pictureBox1.MouseDown += pictureBox1_MouseDown;
        pictureBox1.MouseMove += pictureBox1_MouseMove;
        pictureBox1.MouseUp += pictureBox1_MouseUp;
        
        // lblStatus
        lblStatus.AutoSize = true;
        lblStatus.Location = new Point(12, 450);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(40, 15);
        lblStatus.TabIndex = 1;
        lblStatus.Text = "Status:";
        
        // lblClients
        lblClients.AutoSize = true;
        lblClients.Location = new Point(12, 470);
        lblClients.Name = "lblClients";
        lblClients.Size = new Size(70, 15);
        lblClients.TabIndex = 2;
        lblClients.Text = "Clients: 0";
        
        // txtImageUrl
        txtImageUrl.Location = new Point(400, 12);
        txtImageUrl.Name = "txtImageUrl";
        txtImageUrl.Size = new Size(180, 23);
        txtImageUrl.TabIndex = 4;
        
        // btnInsertImage
        btnInsertImage.Location = new Point(600, 12);
        btnInsertImage.Name = "btnInsertImage";
        btnInsertImage.Size = new Size(75, 23);
        btnInsertImage.TabIndex = 5;
        btnInsertImage.Text = "Insert Image";
        btnInsertImage.UseVisualStyleBackColor = true;
        btnInsertImage.Click += btnInsertImage_Click;
        
        // btnEnd
        btnEnd.Location = new Point(700, 12);
        btnEnd.Name = "btnEnd";
        btnEnd.Size = new Size(75, 23);
        btnEnd.TabIndex = 6;
        btnEnd.Text = "End";
        btnEnd.UseVisualStyleBackColor = true;
        btnEnd.Click += btnEnd_Click;
        
        // Form1
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 500);
        Controls.AddRange(new Control[] { pictureBox1, lblStatus, lblClients, txtImageUrl, btnInsertImage, btnEnd });
        Name = "Form1";
        Text = "Whiteboard Client";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBox1;
    private Label lblStatus;
    private Label lblClients;
    private TextBox txtImageUrl;
    private Button btnInsertImage;
    private Button btnEnd;
}
