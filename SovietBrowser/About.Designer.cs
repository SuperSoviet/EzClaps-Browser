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
      this.label2 = new System.Windows.Forms.Label();
      this.lblMyDiscord = new System.Windows.Forms.LinkLabel();
      this.tekstBoxVersion = new System.Windows.Forms.TextBox();
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
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(91, 25);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(134, 16);
      this.label2.TabIndex = 2;
      this.label2.Text = "EzClaps Browser";
      // 
      // lblMyDiscord
      // 
      this.lblMyDiscord.AutoSize = true;
      this.lblMyDiscord.Location = new System.Drawing.Point(27, 100);
      this.lblMyDiscord.Name = "lblMyDiscord";
      this.lblMyDiscord.Size = new System.Drawing.Size(58, 13);
      this.lblMyDiscord.TabIndex = 3;
      this.lblMyDiscord.TabStop = true;
      this.lblMyDiscord.Text = "Contact us";
      this.lblMyDiscord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblMyDiscord_LinkClicked);
      // 
      // tekstBoxVersion
      // 
      this.tekstBoxVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.tekstBoxVersion.ForeColor = System.Drawing.SystemColors.WindowText;
      this.tekstBoxVersion.Location = new System.Drawing.Point(94, 55);
      this.tekstBoxVersion.Name = "tekstBoxVersion";
      this.tekstBoxVersion.ReadOnly = true;
      this.tekstBoxVersion.Size = new System.Drawing.Size(411, 13);
      this.tekstBoxVersion.TabIndex = 5;
      // 
      // About
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(517, 125);
      this.Controls.Add(this.tekstBoxVersion);
      this.Controls.Add(this.lblMyDiscord);
      this.Controls.Add(this.label2);
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
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.LinkLabel lblMyDiscord;
    private System.Windows.Forms.TextBox tekstBoxVersion;
  }
}