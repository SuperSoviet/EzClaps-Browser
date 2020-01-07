namespace EzClapsBrowser {
  partial class About {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
      this.pbMyLogo = new System.Windows.Forms.PictureBox();
      this.lblMyDiscord = new System.Windows.Forms.LinkLabel();
      this.txtBoxVersion = new System.Windows.Forms.TextBox();
      this.txtBrowserName = new System.Windows.Forms.TextBox();
      this.txtCopyRight = new System.Windows.Forms.TextBox();
      this.lblCompany = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pbMyLogo)).BeginInit();
      this.SuspendLayout();
      // 
      // pbMyLogo
      // 
      this.pbMyLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbMyLogo.Image")));
      this.pbMyLogo.Location = new System.Drawing.Point(13, 12);
      this.pbMyLogo.Name = "pbMyLogo";
      this.pbMyLogo.Size = new System.Drawing.Size(76, 71);
      this.pbMyLogo.TabIndex = 0;
      this.pbMyLogo.TabStop = false;
      this.pbMyLogo.Click += new System.EventHandler(this.pbMyLogo_Click);
      // 
      // lblMyDiscord
      // 
      this.lblMyDiscord.AutoSize = true;
      this.lblMyDiscord.Location = new System.Drawing.Point(61, 100);
      this.lblMyDiscord.Name = "lblMyDiscord";
      this.lblMyDiscord.Size = new System.Drawing.Size(58, 13);
      this.lblMyDiscord.TabIndex = 3;
      this.lblMyDiscord.TabStop = true;
      this.lblMyDiscord.Text = "Contact us";
      this.lblMyDiscord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblMyDiscord_LinkClicked);
      // 
      // txtBoxVersion
      // 
      this.txtBoxVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtBoxVersion.ForeColor = System.Drawing.SystemColors.WindowText;
      this.txtBoxVersion.Location = new System.Drawing.Point(94, 55);
      this.txtBoxVersion.Name = "txtBoxVersion";
      this.txtBoxVersion.ReadOnly = true;
      this.txtBoxVersion.Size = new System.Drawing.Size(411, 13);
      this.txtBoxVersion.TabIndex = 5;
      // 
      // txtBrowserName
      // 
      this.txtBrowserName.BackColor = System.Drawing.SystemColors.Control;
      this.txtBrowserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtBrowserName.Location = new System.Drawing.Point(95, 29);
      this.txtBrowserName.Name = "txtBrowserName";
      this.txtBrowserName.ReadOnly = true;
      this.txtBrowserName.Size = new System.Drawing.Size(410, 13);
      this.txtBrowserName.TabIndex = 6;
      // 
      // txtCopyRight
      // 
      this.txtCopyRight.BackColor = System.Drawing.SystemColors.Control;
      this.txtCopyRight.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtCopyRight.Location = new System.Drawing.Point(405, 100);
      this.txtCopyRight.Name = "txtCopyRight";
      this.txtCopyRight.ReadOnly = true;
      this.txtCopyRight.Size = new System.Drawing.Size(100, 13);
      this.txtCopyRight.TabIndex = 7;
      // 
      // lblCompany
      // 
      this.lblCompany.AutoSize = true;
      this.lblCompany.Location = new System.Drawing.Point(7, 83);
      this.lblCompany.Name = "lblCompany";
      this.lblCompany.Size = new System.Drawing.Size(0, 13);
      this.lblCompany.TabIndex = 8;
      // 
      // About
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(517, 125);
      this.Controls.Add(this.lblCompany);
      this.Controls.Add(this.txtCopyRight);
      this.Controls.Add(this.txtBrowserName);
      this.Controls.Add(this.txtBoxVersion);
      this.Controls.Add(this.lblMyDiscord);
      this.Controls.Add(this.pbMyLogo);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximumSize = new System.Drawing.Size(533, 164);
      this.MinimumSize = new System.Drawing.Size(533, 164);
      this.Name = "About";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "About";
      this.Load += new System.EventHandler(this.About_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pbMyLogo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pbMyLogo;
    private System.Windows.Forms.LinkLabel lblMyDiscord;
    private System.Windows.Forms.TextBox txtBoxVersion;
        private System.Windows.Forms.TextBox txtBrowserName;
        private System.Windows.Forms.TextBox txtCopyRight;
        private System.Windows.Forms.Label lblCompany;
    }
}