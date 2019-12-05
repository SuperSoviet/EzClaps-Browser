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


namespace EzClapsBrowser {
  public partial class Register : Form {
    public Register() {
      InitializeComponent();
      InitializeChromium();
    }
    private void InitializeChromium() {
      //create a browser component
      //and provide a start web url
      ChromiumWebBrowser register = new ChromiumWebBrowser("https://discord.gg/XttSV4H");
      //add the browser to the form
      register.Dock = DockStyle.Fill;
      Controls.Add(register);
      // make the browser fill the form
    }
  }
}

