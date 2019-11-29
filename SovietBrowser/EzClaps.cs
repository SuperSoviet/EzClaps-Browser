using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using CefSharp.Example;
using CefSharp.Example.Handlers;
using System.IO;
using SovietBrowser;

namespace EzClapsBrowser {
  public partial class EzClapsBrowser : Form {
    //_chromiumWebBrowser.DownloadHandler = new DownloadHandler(); 
    // need a find a way to use this

    private string _homePage = "google.nl";
    public DownloadHandler DownloadHandler { get; }
    public EzClapsBrowser() {
      InitializeComponent();

      if (DesignMode) return;

      InitializeChromium(tabPage1);
    }
    // " private void inintializeChromium  = Method
    private void InitializeChromium(TabPage anyTabPage) { //(TabPage anyTabPage) =  Arguments

      var browser = new ChromiumWebBrowser(_homePage);
      browser.Dock = DockStyle.Fill;
      anyTabPage.Controls.Add(browser);
      browser.Parent = tabControl.SelectedTab;
      browser.AddressChanged += EzClaps_AddressChanged;
      browser.TitleChanged += EzClaps_TitleChanged;
      browser.DownloadHandler = new DownloadHandler();

    }
    private void btnSearch_Click(object sender, EventArgs e) {
      ChromiumWebBrowser browser = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
      NavigateToNewPage(browser, txtSearchBar.Text);

      using (StreamWriter history = File.AppendText(@"C:\Users\Stefano\AppData\Local\EzClapsBrowser\History.txt")) {
        history.WriteLine(txtSearchBar.Text);
      }
    }

    private void btnHome_Click(object sender, EventArgs e) {
      ChromiumWebBrowser browser = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
      txtSearchBar.Text = _homePage;
      NavigateToNewPage(browser, _homePage);
    }

    private void NavigateToNewPage(ChromiumWebBrowser browser, string url) {
      if (string.IsNullOrWhiteSpace(url)) return;
      // ?. checks if browser is null, and if it isn't it calls the Load() method
      browser?.Load(url);
    }

    private void btnBack_Click(object sender, EventArgs e) {
      ChromiumWebBrowser browser = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
      if (browser != null) {
        if (browser.CanGoBack)
          browser.Back();
      }
    }

    private void btnForward_Click(object sender, EventArgs e) {
      ChromiumWebBrowser browser = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
      if (browser != null) {


        if (browser.CanGoForward)

          browser.Forward();

      }
    }

    private void btnRefresh_Click(object sender, EventArgs e) {
      ChromiumWebBrowser browser = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
      if (browser != null)
        browser.Reload(true);
    }

    private void btnNewTab_Click(object sender, EventArgs e) {
      createNewTab();
    }

    private void EzClaps_AddressChanged(object sender, AddressChangedEventArgs e) {
      this.Invoke(new MethodInvoker(() => {
        txtSearchBar.Text = e.Address;
      }));
    }
    private void EzClaps_TitleChanged(object sender, TitleChangedEventArgs e) {
      this.Invoke(new MethodInvoker(() => {
        tabControl.SelectedTab.Text = e.Title;
      }));
    }

    private void btnRemoveTab_Click(object sender, EventArgs e) {
      if (tabControl.TabPages.Count == 0) {
        return;
      }

      var tabIndex = tabControl.SelectedIndex;

      var tabPage = tabControl.TabPages[tabIndex];


      if (tabPage != null && !tabPage.IsDisposed) {
        tabIndex = 1;
      }


      tabControl.TabPages.Remove(tabPage);

      tabPage.Dispose();




      //*FIXED* TODO: fix bug when you remove the first tab (it will not select the other tab)
      tabControl.SelectedIndex = tabIndex - 1;

      if (tabControl.TabPages.Count == 0) {

      }
    }
    // *Fixed* Create method that you can reuse to create a new browser 
    // and add it to a TabPage
    private void createNewTab() {
      TabPage newTabPage = new TabPage();
      newTabPage.Text = "New tab";
      tabControl.Controls.Add(newTabPage);
      tabControl.SelectTab(tabControl.TabCount - 1);
      InitializeChromium(newTabPage);
    }


    private void SovietBrowser_FormClosing(object sender, FormClosingEventArgs e) {
      Cef.Shutdown();
    }

    private void btnMenu_Click(object sender, EventArgs e) {
      CtxMenu.Show(MousePosition);
    }

    private void ctxAddtab_Click(object sender, EventArgs e) {
      createNewTab();
    }

    private void menuToolStripMenuItem_Click(object sender, EventArgs e) {

      showHistory showhistory = new showHistory();
      showhistory.Show();
    }
  }
}