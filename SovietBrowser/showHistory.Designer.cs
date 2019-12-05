namespace EzClapsBrowser {
  partial class showHistory {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showHistory));
      this.txtHistory = new System.Windows.Forms.TextBox();
      this.btnClear = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtHistory
      // 
      this.txtHistory.Location = new System.Drawing.Point(13, 13);
      this.txtHistory.Multiline = true;
      this.txtHistory.Name = "txtHistory";
      this.txtHistory.ReadOnly = true;
      this.txtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtHistory.Size = new System.Drawing.Size(702, 1121);
      this.txtHistory.TabIndex = 0;
      // 
      // btnClear
      // 
      this.btnClear.Location = new System.Drawing.Point(12, 1121);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(75, 23);
      this.btnClear.TabIndex = 1;
      this.btnClear.Text = "Clear History";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // showHistory
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(727, 1146);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.txtHistory);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "showHistory";
      this.Text = "History";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtHistory;
    private System.Windows.Forms.Button btnClear;
  }
}