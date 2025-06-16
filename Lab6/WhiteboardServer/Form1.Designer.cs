namespace WhiteboardServer;

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
        lblStatus = new Label();
        lblClients = new Label();
        
        SuspendLayout();
        
        // lblStatus
        lblStatus.AutoSize = true;
        lblStatus.Location = new Point(12, 9);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(79, 15);
        lblStatus.TabIndex = 0;
        lblStatus.Text = "Server Status: ";
        
        // lblClients
        lblClients.AutoSize = true;
        lblClients.Location = new Point(12, 33);
        lblClients.Name = "lblClients";
        lblClients.Size = new Size(107, 15);
        lblClients.TabIndex = 1;
        lblClients.Text = "Connected clients: ";
        
        // Form1
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(384, 161);
        Controls.Add(lblClients);
        Controls.Add(lblStatus);
        Name = "Form1";
        Text = "Whiteboard Server";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblStatus;
    private Label lblClients;
}
