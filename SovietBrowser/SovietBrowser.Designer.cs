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
      this.btnBack = new System.Windows.Forms.Button();
      this.btnForward = new System.Windows.Forms.Button();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtSearchBar
      // 
      this.txtSearchBar.Location = new System.Drawing.Point(480, 0);
      this.txtSearchBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.txtSearchBar.Name = "txtSearchBar";
      this.txtSearchBar.Size = new System.Drawing.Size(648, 20);
      this.txtSearchBar.TabIndex = 0;
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(1132, -1);
      this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(56, 19);
      this.btnSearch.TabIndex = 1;
      this.btnSearch.Text = "⌕";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // btnHome
      // 
      this.btnHome.Location = new System.Drawing.Point(419, 0);
      this.btnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.btnHome.Name = "btnHome";
      this.btnHome.Size = new System.Drawing.Size(56, 19);
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
      this.pnlWebView.Location = new System.Drawing.Point(1, 23);
      this.pnlWebView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.pnlWebView.Name = "pnlWebView";
      this.pnlWebView.Size = new System.Drawing.Size(1570, 1176);
      this.pnlWebView.TabIndex = 3;
      // 
      // btnBack
      // 
      this.btnBack.Location = new System.Drawing.Point(203, 1);
      this.btnBack.Name = "btnBack";
      this.btnBack.Size = new System.Drawing.Size(41, 19);
      this.btnBack.TabIndex = 4;
      this.btnBack.Text = "←";
      this.btnBack.UseVisualStyleBackColor = true;
      this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
      // 
      // btnForward
      // 
      this.btnForward.Location = new System.Drawing.Point(250, 1);
      this.btnForward.Name = "btnForward";
      this.btnForward.Size = new System.Drawing.Size(41, 19);
      this.btnForward.TabIndex = 5;
      this.btnForward.Text = "→";
      this.btnForward.UseVisualStyleBackColor = true;
      this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
      // 
      // btnRefresh
      // 
      this.btnRefresh.Location = new System.Drawing.Point(333, 1);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(44, 20);
      this.btnRefresh.TabIndex = 6;
      this.btnRefresh.Text = "↺";
      this.btnRefresh.UseVisualStyleBackColor = true;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
      // 
      // SovietBrowser
      // 
      this.AcceptButton = this.btnSearch;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1568, 1198);
      this.Controls.Add(this.btnRefresh);
      this.Controls.Add(this.btnForward);
      this.Controls.Add(this.btnBack);
      this.Controls.Add(this.pnlWebView);
      this.Controls.Add(this.btnHome);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.txtSearchBar);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    private System.Windows.Forms.Button btnBack;
    private System.Windows.Forms.Button btnForward;
    private System.Windows.Forms.Button btnRefresh;
  }
}

