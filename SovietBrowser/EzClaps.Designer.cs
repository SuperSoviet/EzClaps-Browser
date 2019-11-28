﻿namespace EzClapsBrowser {
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
      this.tabControl = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.btnBack = new System.Windows.Forms.Button();
      this.btnForward = new System.Windows.Forms.Button();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.btnNewTab = new System.Windows.Forms.Button();
      this.btnRemoveTab = new System.Windows.Forms.Button();
      this.PbarDownload = new System.Windows.Forms.ProgressBar();
      this.pnlWebView.SuspendLayout();
      this.tabControl.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtSearchBar
      // 
      this.txtSearchBar.Location = new System.Drawing.Point(480, 3);
      this.txtSearchBar.Margin = new System.Windows.Forms.Padding(2);
      this.txtSearchBar.Name = "txtSearchBar";
      this.txtSearchBar.Size = new System.Drawing.Size(648, 20);
      this.txtSearchBar.TabIndex = 0;
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(1132, 2);
      this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(56, 21);
      this.btnSearch.TabIndex = 1;
      this.btnSearch.Text = "⌕";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // btnHome
      // 
      this.btnHome.Location = new System.Drawing.Point(420, 4);
      this.btnHome.Margin = new System.Windows.Forms.Padding(2);
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
      this.pnlWebView.Controls.Add(this.tabControl);
      this.pnlWebView.Location = new System.Drawing.Point(1, 23);
      this.pnlWebView.Margin = new System.Windows.Forms.Padding(2);
      this.pnlWebView.Name = "pnlWebView";
      this.pnlWebView.Size = new System.Drawing.Size(1570, 1124);
      this.pnlWebView.TabIndex = 3;
      // 
      // tabControl
      // 
      this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl.Controls.Add(this.tabPage1);
      this.tabControl.Location = new System.Drawing.Point(3, 3);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(1564, 1121);
      this.tabControl.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(1556, 1095);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "tabPage1";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // btnBack
      // 
      this.btnBack.Location = new System.Drawing.Point(218, 5);
      this.btnBack.Name = "btnBack";
      this.btnBack.Size = new System.Drawing.Size(41, 19);
      this.btnBack.TabIndex = 4;
      this.btnBack.Text = "←";
      this.btnBack.UseVisualStyleBackColor = true;
      this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
      // 
      // btnForward
      // 
      this.btnForward.Location = new System.Drawing.Point(265, 5);
      this.btnForward.Name = "btnForward";
      this.btnForward.Size = new System.Drawing.Size(41, 19);
      this.btnForward.TabIndex = 5;
      this.btnForward.Text = "→";
      this.btnForward.UseVisualStyleBackColor = true;
      this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
      // 
      // btnRefresh
      // 
      this.btnRefresh.Location = new System.Drawing.Point(334, 4);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(44, 20);
      this.btnRefresh.TabIndex = 6;
      this.btnRefresh.Text = "↺";
      this.btnRefresh.UseVisualStyleBackColor = true;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
      // 
      // btnNewTab
      // 
      this.btnNewTab.Location = new System.Drawing.Point(4, 2);
      this.btnNewTab.Name = "btnNewTab";
      this.btnNewTab.Size = new System.Drawing.Size(36, 23);
      this.btnNewTab.TabIndex = 7;
      this.btnNewTab.Text = "⧉";
      this.btnNewTab.UseVisualStyleBackColor = true;
      this.btnNewTab.Click += new System.EventHandler(this.btnNewTab_Click);
      // 
      // btnRemoveTab
      // 
      this.btnRemoveTab.Location = new System.Drawing.Point(46, 1);
      this.btnRemoveTab.Name = "btnRemoveTab";
      this.btnRemoveTab.Size = new System.Drawing.Size(35, 23);
      this.btnRemoveTab.TabIndex = 8;
      this.btnRemoveTab.Text = "x";
      this.btnRemoveTab.UseVisualStyleBackColor = true;
      this.btnRemoveTab.Click += new System.EventHandler(this.btnRemoveTab_Click);
      // 
      // PbarDownload
      // 
      this.PbarDownload.Location = new System.Drawing.Point(1241, 1);
      this.PbarDownload.Name = "PbarDownload";
      this.PbarDownload.Size = new System.Drawing.Size(100, 23);
      this.PbarDownload.TabIndex = 9;
      // 
      // SovietBrowser
      // 
      this.AcceptButton = this.btnSearch;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1568, 1146);
      this.Controls.Add(this.PbarDownload);
      this.Controls.Add(this.btnRemoveTab);
      this.Controls.Add(this.btnNewTab);
      this.Controls.Add(this.btnRefresh);
      this.Controls.Add(this.btnForward);
      this.Controls.Add(this.btnBack);
      this.Controls.Add(this.pnlWebView);
      this.Controls.Add(this.btnHome);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.txtSearchBar);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "SovietBrowser";
      this.Text = "EzClaps Browser";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SovietBrowser_FormClosing);
      this.pnlWebView.ResumeLayout(false);
      this.tabControl.ResumeLayout(false);
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
    private System.Windows.Forms.Button btnNewTab;
    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.Button btnRemoveTab;
    private System.Windows.Forms.ProgressBar PbarDownload;
  }
}
