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
      this.lblCompany = new System.Windows.Forms.Label();
      this.lblBrowserName = new System.Windows.Forms.Label();
      this.lblCopyRight = new System.Windows.Forms.Label();
      this.lblVersion = new System.Windows.Forms.Label();
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
      // lblCompany
      // 
      this.lblCompany.AutoSize = true;
      this.lblCompany.Location = new System.Drawing.Point(7, 83);
      this.lblCompany.Name = "lblCompany";
      this.lblCompany.Size = new System.Drawing.Size(0, 13);
      this.lblCompany.TabIndex = 8;
      // 
      // lblBrowserName
      // 
      this.lblBrowserName.AutoSize = true;
      this.lblBrowserName.Location = new System.Drawing.Point(96, 40);
      this.lblBrowserName.Name = "lblBrowserName";
      this.lblBrowserName.Size = new System.Drawing.Size(0, 13);
      this.lblBrowserName.TabIndex = 9;
      // 
      // lblCopyRight
      // 
      this.lblCopyRight.AutoSize = true;
      this.lblCopyRight.Location = new System.Drawing.Point(421, 103);
      this.lblCopyRight.Name = "lblCopyRight";
      this.lblCopyRight.Size = new System.Drawing.Size(0, 13);
      this.lblCopyRight.TabIndex = 10;
      // 
      // lblVersion
      // 
      this.lblVersion.AutoSize = true;
      this.lblVersion.Location = new System.Drawing.Point(96, 56);
      this.lblVersion.Name = "lblVersion";
      this.lblVersion.Size = new System.Drawing.Size(0, 13);
      this.lblVersion.TabIndex = 11;
      // 
      // About
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(517, 125);
      this.Controls.Add(this.lblVersion);
      this.Controls.Add(this.lblCopyRight);
      this.Controls.Add(this.lblBrowserName);
      this.Controls.Add(this.lblCompany);
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
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblBrowserName;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.Label lblVersion;
    }
}