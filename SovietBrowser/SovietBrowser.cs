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
//_chromiumWebBrowser.DownloadHandler = new DownloadHandler(); need a find a way to use this
namespace SovietBrowser {

  public partial class SovietBrowser : Form {
    private ChromiumWebBrowser _chromiumWebBrowser;
    private string _homePage = "google.nl";

    public DownloadHandler DownloadHandler { get; }

    public SovietBrowser() {
      InitializeComponent();
      
      if (DesignMode) return;
      InitializeChromium();
    }

    private void InitializeChromium() {
      _chromiumWebBrowser = new ChromiumWebBrowser(_homePage);
      _chromiumWebBrowser.Dock = DockStyle.Fill;
      tabPage1.Controls.Add(_chromiumWebBrowser);
      _chromiumWebBrowser.Parent = tabControl.SelectedTab;
      _chromiumWebBrowser.AddressChanged += Soviet_AddressChanged;
      _chromiumWebBrowser.TitleChanged += Soviet_TitleChanged;
      txtSearchBar.Text = _homePage;
    }
    
    private void btnSearch_Click(object sender, EventArgs e) {
      ChromiumWebBrowser soviet = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
      if (soviet != null)
        _chromiumWebBrowser.Load(txtSearchBar.Text);
    }

    private void btnHome_Click(object sender, EventArgs e) {
      txtSearchBar.Text = _homePage;
      NavigateToNewPage(_homePage);
    }

    private void NavigateToNewPage(string url) {
      if (string.IsNullOrWhiteSpace(url)) return;
      _chromiumWebBrowser.Load(url);
    }

    private void btnBack_Click(object sender, EventArgs e) {
      ChromiumWebBrowser soviet = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
      if (soviet != null) {
        if (_chromiumWebBrowser.CanGoBack)
          _chromiumWebBrowser.Back();
      }
    }

    private void btnForward_Click(object sender, EventArgs e) {
      ChromiumWebBrowser soviet = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
      if (soviet != null) {


        if (_chromiumWebBrowser.CanGoForward)

          _chromiumWebBrowser.Forward();

      }
    }

    private void btnRefresh_Click(object sender, EventArgs e) {
      ChromiumWebBrowser soviet = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
      if (soviet != null)
        _chromiumWebBrowser.Reload(true);
    }
    private void btnNewTab_Click(object sender, EventArgs e) {
      TabPage tab = new TabPage();
      tab.Text = "New tab";
      tabControl.Controls.Add(tab);
      tabControl.SelectTab(tabControl.TabCount - 1);
      ChromiumWebBrowser _chromiumWebBrowser = new ChromiumWebBrowser("Google.com");
      _chromiumWebBrowser.Parent = tab;
      _chromiumWebBrowser.Dock = DockStyle.Fill;
      txtSearchBar.Text = "google.com";
      _chromiumWebBrowser.AddressChanged += Soviet_AddressChanged;
      _chromiumWebBrowser.TitleChanged += Soviet_TitleChanged;
    }

    private void Soviet_AddressChanged(object sender, AddressChangedEventArgs e) {
      this.Invoke(new MethodInvoker(() => {
        txtSearchBar.Text = e.Address;
      }));
    }
    private void Soviet_TitleChanged(object sender, TitleChangedEventArgs e) {
      this.Invoke(new MethodInvoker(() => {
        tabControl.SelectedTab.Text = e.Title;
      }));
    }

    private void btnRemoveTab_Click(object sender, EventArgs e) {
      if (tabControl.TabPages.Count == 0) {
        return;
      }

      var tabindex = tabControl.SelectedIndex;

      var tabPage = tabControl.TabPages[tabindex];

      
      if (tabPage != null && !tabPage.IsDisposed) {
        tabPage.Dispose();
      }

      tabControl.TabPages.Remove(tabPage);

      tabPage.Dispose();

     tabControl.SelectedIndex = tabindex - 1;

      if (tabControl.TabPages.Count == 0) {
        Dispose();
      } 
    }
  }
}