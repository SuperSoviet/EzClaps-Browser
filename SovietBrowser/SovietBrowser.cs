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

namespace SovietBrowser {

  public partial class SovietBrowser : Form {
    private ChromiumWebBrowser _chromiumWebBrowser;
    private string _homePage = "google.nl";

    public SovietBrowser() {
      InitializeComponent();

      if (DesignMode) return;
      InitializeChromium();
    }

    private void InitializeChromium() {
      _chromiumWebBrowser = new ChromiumWebBrowser(_homePage);
      _chromiumWebBrowser.Dock = DockStyle.Fill;
      pnlWebView.Controls.Add(_chromiumWebBrowser);

      txtSearchBar.Text = _homePage;
    }

    private void btnSearch_Click(object sender, EventArgs e) {
      string url = txtSearchBar.Text;
      NavigateToNewPage(url);
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
      if (_chromiumWebBrowser.CanGoBack)
        _chromiumWebBrowser.Back();
    }

    private void btnForward_Click(object sender, EventArgs e) {
      if (_chromiumWebBrowser.CanGoForward)
        _chromiumWebBrowser.Forward();
    }

    private void btnRefresh_Click(object sender, EventArgs e) {
      _chromiumWebBrowser.Reload(true);

    }
  }
}