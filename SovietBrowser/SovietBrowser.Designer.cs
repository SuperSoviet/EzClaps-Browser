namespace SovietBrowser {
  partial class SovietBrowser {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SovietBrowser));
      this.txtSearchBar = new System.Windows.Forms.TextBox();
      this.btnSearch = new System.Windows.Forms.Button();
      this.btnHome = new System.Windows.Forms.Button();
      this.pnlWebView = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // txtSearchBar
      // 
      this.txtSearchBar.Location = new System.Drawing.Point(640, 0);
      this.txtSearchBar.Name = "txtSearchBar";
      this.txtSearchBar.Size = new System.Drawing.Size(863, 22);
      this.txtSearchBar.TabIndex = 0;
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(1509, -1);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(75, 23);
      this.btnSearch.TabIndex = 1;
      this.btnSearch.Text = "⌕";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // btnHome
      // 
      this.btnHome.Location = new System.Drawing.Point(559, 0);
      this.btnHome.Name = "btnHome";
      this.btnHome.Size = new System.Drawing.Size(75, 23);
      this.btnHome.TabIndex = 2;
      this.btnHome.Text = "🏠";
      this.btnHome.UseVisualStyleBackColor = true;
      this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
      // 
      // pnlWebView
      // 
      this.pnlWebView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlWebView.Location = new System.Drawing.Point(1, 28);
      this.pnlWebView.Name = "pnlWebView";
      this.pnlWebView.Size = new System.Drawing.Size(2094, 902);
      this.pnlWebView.TabIndex = 3;
      // 
      // SovietBrowser
      // 
      this.AcceptButton = this.btnSearch;
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(2091, 929);
      this.Controls.Add(this.pnlWebView);
      this.Controls.Add(this.btnHome);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.txtSearchBar);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "SovietBrowser";
      this.Text = "SovietBrowser";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtSearchBar;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnHome;
    private System.Windows.Forms.Panel pnlWebView;
  }
}

