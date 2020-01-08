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
using ezclapsDownloadHandler;
using System.IO;



namespace EzClapsBrowser {
  public partial class EzClapsBrowser : Form {
    //Homepage
    private string _homePage = "google.nl";
    public DownloadHandler DownloadHandler { get; }
    public EzClapsBrowser() {
    Cef.EnableHighDPISupport();
      if (DesignMode) return;
      InitializeComponent();
      InitializeChromium(tabPage1);
    }
    // " private void inintializeChromium  = Method
    private void InitializeChromium(TabPage anyTabPage) { //(TabPage anyTabPage) =  Arguments

      CefSettings settings = new CefSettings();
      settings.CachePath = @"C:\Program Files(x86)\EzClapsBrowser\cache";
      var browser = new ChromiumWebBrowser(_homePage);
      browser.Dock = DockStyle.Fill;
      browser.DownloadHandler = new DownloadHandler();
      anyTabPage.Controls.Add(browser);
      browser.Parent = tabControl.SelectedTab;
      browser.AddressChanged += EzClaps_AddressChanged;
      browser.TitleChanged += EzClaps_TitleChanged;
      //Creates a new Tab with a browser attached to it also updates the browser tab name and the search bar
      //this class makes you able to download files and save them to where you want them to be placed
    }
    private void btnSearch_Click(object sender, EventArgs e) {
      ChromiumWebBrowser browser = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
      NavigateToNewPage(browser, txtSearchBar.Text);
      // uses a textbar to fill in a url and searches it up for you 
      //causing the browser to update based on what you put in the bar
    }

    private void btnHome_Click(object sender, EventArgs e) {
      ChromiumWebBrowser browser = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
      txtSearchBar.Text = _homePage;
      NavigateToNewPage(browser, _homePage);
      //sends you back to the homepage Google.com

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
        //going back a tab
      }
    }

    private void btnForward_Click(object sender, EventArgs e) {
      ChromiumWebBrowser browser = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
      if (browser != null) {


        if (browser.CanGoForward)

          browser.Forward();
        //going forward in a tab
      }
    }

    private void btnRefresh_Click(object sender, EventArgs e) {
      ChromiumWebBrowser browser = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
      if (browser != null)
        browser.Reload(true);
      //refreshes the web page ( also updates the url so if you refresh it wil be added to the History.txt
      if (browser == null) {
        browser.Reload(false);
      }
    }
    private void btnNewTab_Click(object sender, EventArgs e) {
      createNewTab();
      //creates a new tab with a new browser attached
    }

    private void EzClaps_AddressChanged(object sender, AddressChangedEventArgs e) {
      //updates the adress bar based on the url that has been  put in
      this.Invoke(new MethodInvoker(() => {
        txtSearchBar.Text = e.Address;
        //if the the adressbar is updated in one way or another it wil detect it and send the url to the History.txt file
        // causing the history tab to update 
        //but if the Private tab is active it won't save your browser history 
        if (cbPrivateTab.Checked) {
          return;
        }
        //First checks the location of the history tab then adds the text from the searchbar and adds it in the History.txt
        showHistory showHistory = new showHistory();
        using (StreamWriter History = File.AppendText(@"C:\EzClapsBrowser\History.txt")) {
          History.WriteLine(txtSearchBar.Text);
        }
      }));
    }

    private void EzClaps_TitleChanged(object sender, TitleChangedEventArgs e) {
      this.Invoke(new MethodInvoker(() => {
        tabControl.SelectedTab.Text = e.Title;
      }));
      //updates the title of the tab
    }

    private void btnRemoveTab_Click(object sender, EventArgs e) {
      if (tabControl.TabPages.Count == 0) {
        return;
        //removes a tab when clicked
      }

      var tabIndex = tabControl.SelectedIndex;

      var tabPage = tabControl.TabPages[tabIndex];


      if (tabPage != null && !tabPage.IsDisposed) {
        tabIndex = 1;
      }

      tabControl.TabPages.Remove(tabPage);

      tabPage.Dispose();


      tabControl.SelectedIndex = tabIndex - 1;

      if (tabControl.TabPages.Count == 0) {
        Application.Exit();
      }
    }
    //adds a new tab a gives it a browser using the InitializeChronium(newTabPage) method
    private void createNewTab() {
      TabPage newTabPage = new TabPage();
      newTabPage.Text = "New tab";
      tabControl.Controls.Add(newTabPage);
      tabControl.SelectTab(tabControl.TabCount - 1);
      InitializeChromium(newTabPage);
    }

    //safly lets you shutdown the browser
  
    private void btnMenu_Click(object sender, EventArgs e) {
      CtxMenu.Show(MousePosition);
      //opens the contextbrowser menu and opens it on your mouse position 
    }
    //adds a tab and giving it a brower ( inside a context browser version ) 
    private void ctxAddtab_Click(object sender, EventArgs e) {
      createNewTab();
      //contextmenu version of the add new tab option
    }

    private void menuToolStripMenuItem_Click(object sender, EventArgs e) {
      //opens a winform with your history in it
      showHistory showhistory = new showHistory();
      showhistory.Show();
    }


    private void cbPrivateTab_CheckedChanged(object sender, EventArgs e) {
      //if its on your history won't be saved 
    }

    private void ctxDarkTheme_Click(object sender, EventArgs e) {
      //colors for darkmode ( all greyish colors ) 
      this.BackColor = Color.FromArgb(93, 91, 90);
      CtxMenu.BackColor = Color.FromArgb(105, 105, 105);
      btnBack.BackColor = Color.FromArgb(105, 105, 105);
      btnForward.BackColor = Color.FromArgb(105, 105, 105);
      btnHome.BackColor = Color.FromArgb(105, 105, 105);
      btnNewTab.BackColor = Color.FromArgb(105, 105, 105);
      btnRemoveTab.BackColor = Color.FromArgb(105, 105, 105);
      btnMenu.BackColor = Color.FromArgb(105, 105, 105);
      btnRefresh.BackColor = Color.FromArgb(105, 105, 105);
      txtSearchBar.BackColor = Color.FromArgb(105, 105, 105);
      btnSearch.BackColor = Color.FromArgb(105, 105, 105);
      txtSearchBar.ForeColor = Color.White;
      tabPage1.BackColor = Color.FromArgb(105, 105, 105);

    }

    private void aboutEzclapsToolStripMenuItem_Click(object sender, EventArgs e) {
      //opens the About winform
      About about = new About();
      about.Show();
    }
    private void EzClapsBrowser_FormClosing(object sender, FormClosingEventArgs e) {
      Dispose();
      Application.ExitThread();
    }
  }
}