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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lblMyDiscord = new System.Windows.Forms.LinkLabel();
      ((System.ComponentModel.ISupportInitialize)(this.pbMyLogo)).BeginInit();
      this.SuspendLayout();
      // 
      // pbMyLogo
      // 
      this.pbMyLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbMyLogo.Image")));
      this.pbMyLogo.Location = new System.Drawing.Point(12, 12);
      this.pbMyLogo.Name = "pbMyLogo";
      this.pbMyLogo.Size = new System.Drawing.Size(76, 73);
      this.pbMyLogo.TabIndex = 0;
      this.pbMyLogo.TabStop = false;
      this.pbMyLogo.Click += new System.EventHandler(this.pbMyLogo_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(94, 69);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(421, 16);
      this.label1.TabIndex = 1;
      this.label1.Text = "Pre-Release Version 0.7 (Version made by : SuperSoviet)";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(95, 35);
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
      // About
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(517, 125);
      this.Controls.Add(this.lblMyDiscord);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pbMyLogo);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximumSize = new System.Drawing.Size(533, 164);
      this.MinimumSize = new System.Drawing.Size(533, 164);
      this.Name = "About";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "About";
      ((System.ComponentModel.ISupportInitialize)(this.pbMyLogo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pbMyLogo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.LinkLabel lblMyDiscord;
  }
}