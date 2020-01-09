namespace EzClapsBrowser {
  public partial class EzClapsBrowser {
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
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources =
            new System.ComponentModel.ComponentResourceManager(typeof(EzClapsBrowser));
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
        this.CtxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
        this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.ctxAddtab = new System.Windows.Forms.ToolStripMenuItem();
        this.ctxSwitchTheme = new System.Windows.Forms.ToolStripMenuItem();
        this.ctxDarkTheme = new System.Windows.Forms.ToolStripMenuItem();
        this.aboutEzclapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.btnMenu = new System.Windows.Forms.Button();
        this.cbPrivateTab = new System.Windows.Forms.CheckBox();
        this.ctxSetHomePage = new System.Windows.Forms.ToolStripMenuItem();
        this.pnlWebView.SuspendLayout();
        this.tabControl.SuspendLayout();
        this.CtxMenu.SuspendLayout();
        this.SuspendLayout();
        // 
        // txtSearchBar
        // 
        this.txtSearchBar.Location = new System.Drawing.Point(560, 3);
        this.txtSearchBar.Margin = new System.Windows.Forms.Padding(2);
        this.txtSearchBar.Name = "txtSearchBar";
        this.txtSearchBar.Size = new System.Drawing.Size(755, 23);
        this.txtSearchBar.TabIndex = 0;
        // 
        // btnSearch
        // 
        this.btnSearch.Location = new System.Drawing.Point(1321, 2);
        this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
        this.btnSearch.Name = "btnSearch";
        this.btnSearch.Size = new System.Drawing.Size(65, 24);
        this.btnSearch.TabIndex = 1;
        this.btnSearch.Text = "⌕";
        this.btnSearch.UseVisualStyleBackColor = true;
        this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
        // 
        // btnHome
        // 
        this.btnHome.Location = new System.Drawing.Point(490, 5);
        this.btnHome.Margin = new System.Windows.Forms.Padding(2);
        this.btnHome.Name = "btnHome";
        this.btnHome.Size = new System.Drawing.Size(65, 22);
        this.btnHome.TabIndex = 2;
        this.btnHome.Text = "🏠";
        this.btnHome.UseVisualStyleBackColor = true;
        this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
        // 
        // pnlWebView
        // 
        this.pnlWebView.Anchor =
            ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                     System.Windows.Forms.AnchorStyles.Bottom) |
                                                    System.Windows.Forms.AnchorStyles.Left) |
                                                   System.Windows.Forms.AnchorStyles.Right)));
        this.pnlWebView.Controls.Add(this.tabControl);
        this.pnlWebView.Location = new System.Drawing.Point(1, 27);
        this.pnlWebView.Margin = new System.Windows.Forms.Padding(2);
        this.pnlWebView.Name = "pnlWebView";
        this.pnlWebView.Size = new System.Drawing.Size(1832, 1297);
        this.pnlWebView.TabIndex = 3;
        // 
        // tabControl
        // 
        this.tabControl.Anchor =
            ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                     System.Windows.Forms.AnchorStyles.Bottom) |
                                                    System.Windows.Forms.AnchorStyles.Left) |
                                                   System.Windows.Forms.AnchorStyles.Right)));
        this.tabControl.Controls.Add(this.tabPage1);
        this.tabControl.Location = new System.Drawing.Point(3, 3);
        this.tabControl.Name = "tabControl";
        this.tabControl.SelectedIndex = 0;
        this.tabControl.Size = new System.Drawing.Size(1825, 1293);
        this.tabControl.TabIndex = 0;
        // 
        // tabPage1
        // 
        this.tabPage1.Location = new System.Drawing.Point(4, 24);
        this.tabPage1.Name = "tabPage1";
        this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage1.Size = new System.Drawing.Size(1817, 1265);
        this.tabPage1.TabIndex = 0;
        this.tabPage1.Text = "tabPage1";
        this.tabPage1.UseVisualStyleBackColor = true;
        // 
        // btnBack
        // 
        this.btnBack.Location = new System.Drawing.Point(254, 6);
        this.btnBack.Name = "btnBack";
        this.btnBack.Size = new System.Drawing.Size(48, 22);
        this.btnBack.TabIndex = 4;
        this.btnBack.Text = "←";
        this.btnBack.UseVisualStyleBackColor = true;
        this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
        // 
        // btnForward
        // 
        this.btnForward.Location = new System.Drawing.Point(309, 6);
        this.btnForward.Name = "btnForward";
        this.btnForward.Size = new System.Drawing.Size(48, 22);
        this.btnForward.TabIndex = 5;
        this.btnForward.Text = "→";
        this.btnForward.UseVisualStyleBackColor = true;
        this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
        // 
        // btnRefresh
        // 
        this.btnRefresh.Location = new System.Drawing.Point(390, 5);
        this.btnRefresh.Name = "btnRefresh";
        this.btnRefresh.Size = new System.Drawing.Size(51, 23);
        this.btnRefresh.TabIndex = 6;
        this.btnRefresh.Text = "↺";
        this.btnRefresh.UseVisualStyleBackColor = true;
        this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
        // 
        // btnNewTab
        // 
        this.btnNewTab.Location = new System.Drawing.Point(5, 2);
        this.btnNewTab.Name = "btnNewTab";
        this.btnNewTab.Size = new System.Drawing.Size(42, 27);
        this.btnNewTab.TabIndex = 7;
        this.btnNewTab.Text = "⧉";
        this.btnNewTab.UseVisualStyleBackColor = true;
        this.btnNewTab.Click += new System.EventHandler(this.btnNewTab_Click);
        // 
        // btnRemoveTab
        // 
        this.btnRemoveTab.Location = new System.Drawing.Point(54, 1);
        this.btnRemoveTab.Name = "btnRemoveTab";
        this.btnRemoveTab.Size = new System.Drawing.Size(41, 27);
        this.btnRemoveTab.TabIndex = 8;
        this.btnRemoveTab.Text = "x";
        this.btnRemoveTab.UseVisualStyleBackColor = true;
        this.btnRemoveTab.Click += new System.EventHandler(this.btnRemoveTab_Click);
        // 
        // CtxMenu
        // 
        this.CtxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.menuToolStripMenuItem, this.ctxAddtab, this.ctxSwitchTheme, this.aboutEzclapsToolStripMenuItem,
            this.ctxSetHomePage
        });
        this.CtxMenu.Name = "CtxMenu";
        this.CtxMenu.Size = new System.Drawing.Size(154, 136);
        // 
        // menuToolStripMenuItem
        // 
        this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
        this.menuToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
        this.menuToolStripMenuItem.Text = "History";
        this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
        // 
        // ctxAddtab
        // 
        this.ctxAddtab.Name = "ctxAddtab";
        this.ctxAddtab.Size = new System.Drawing.Size(153, 22);
        this.ctxAddtab.Text = "Add new tab";
        this.ctxAddtab.Click += new System.EventHandler(this.ctxAddtab_Click);
        // 
        // ctxSwitchTheme
        // 
        this.ctxSwitchTheme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ctxDarkTheme});
        this.ctxSwitchTheme.Name = "ctxSwitchTheme";
        this.ctxSwitchTheme.Size = new System.Drawing.Size(153, 22);
        this.ctxSwitchTheme.Text = "Switch Themes";
        // 
        // ctxDarkTheme
        // 
        this.ctxDarkTheme.Name = "ctxDarkTheme";
        this.ctxDarkTheme.Size = new System.Drawing.Size(137, 22);
        this.ctxDarkTheme.Text = "Dark Theme";
        this.ctxDarkTheme.Click += new System.EventHandler(this.ctxDarkTheme_Click);
        // 
        // aboutEzclapsToolStripMenuItem
        // 
        this.aboutEzclapsToolStripMenuItem.Name = "aboutEzclapsToolStripMenuItem";
        this.aboutEzclapsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
        this.aboutEzclapsToolStripMenuItem.Text = "About Ezclaps";
        this.aboutEzclapsToolStripMenuItem.Click += new System.EventHandler(this.aboutEzclapsToolStripMenuItem_Click);
        // 
        // btnMenu
        // 
        this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (10)))),
            ((int) (((byte) (121)))), ((int) (((byte) (26)))));
        this.btnMenu.Location = new System.Drawing.Point(1790, 6);
        this.btnMenu.Name = "btnMenu";
        this.btnMenu.Size = new System.Drawing.Size(40, 23);
        this.btnMenu.TabIndex = 9;
        this.btnMenu.Text = "⭿";
        this.btnMenu.UseVisualStyleBackColor = false;
        this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
        // 
        // cbPrivateTab
        // 
        this.cbPrivateTab.AutoSize = true;
        this.cbPrivateTab.Location = new System.Drawing.Point(1636, 8);
        this.cbPrivateTab.Name = "cbPrivateTab";
        this.cbPrivateTab.Size = new System.Drawing.Size(132, 19);
        this.cbPrivateTab.TabIndex = 10;
        this.cbPrivateTab.Text = "Turn on Private Tabs";
        this.cbPrivateTab.UseVisualStyleBackColor = true;
        this.cbPrivateTab.CheckedChanged += new System.EventHandler(this.cbPrivateTab_CheckedChanged);
        // 
        // ctxSetHomePage
        // 
        this.ctxSetHomePage.Name = "ctxSetHomePage";
        this.ctxSetHomePage.Size = new System.Drawing.Size(153, 22);
        this.ctxSetHomePage.Text = "Set Homepage";
        this.ctxSetHomePage.Click += new System.EventHandler(this.ctxSetHomePage_Click);
        // 
        // EzClapsBrowser
        // 
        this.AcceptButton = this.btnSearch;
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        this.ClientSize = new System.Drawing.Size(1829, 1322);
        this.ContextMenuStrip = this.CtxMenu;
        this.Controls.Add(this.cbPrivateTab);
        this.Controls.Add(this.btnMenu);
        this.Controls.Add(this.btnRemoveTab);
        this.Controls.Add(this.btnNewTab);
        this.Controls.Add(this.btnRefresh);
        this.Controls.Add(this.btnForward);
        this.Controls.Add(this.btnBack);
        this.Controls.Add(this.pnlWebView);
        this.Controls.Add(this.btnHome);
        this.Controls.Add(this.btnSearch);
        this.Controls.Add(this.txtSearchBar);
        this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
        this.Margin = new System.Windows.Forms.Padding(2);
        this.Name = "EzClapsBrowser";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "EzClaps Browser";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EzClapsBrowser_FormClosing);
        this.pnlWebView.ResumeLayout(false);
        this.tabControl.ResumeLayout(false);
        this.CtxMenu.ResumeLayout(false);
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
    private System.Windows.Forms.ContextMenuStrip CtxMenu;
    private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ctxAddtab;
    private System.Windows.Forms.Button btnMenu;
    private System.Windows.Forms.CheckBox cbPrivateTab;
    private System.Windows.Forms.ToolStripMenuItem ctxSwitchTheme;
    private System.Windows.Forms.ToolStripMenuItem ctxDarkTheme;
    private System.Windows.Forms.ToolStripMenuItem aboutEzclapsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ctxSetHomePage;
  }
}

