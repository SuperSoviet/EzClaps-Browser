using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SovietBrowser {
  public partial class showHistory : Form {
    public showHistory() {
      InitializeComponent();
      var path = (@"C:\Users\Stefano\AppData\Local\EzClapsBrowser\History.txt");
      if (!File.Exists(path)) {
        string root = @"C:\Users\Stefano\AppData\Local\EzClapsBrowser";
        if (!Directory.Exists(root)) {
          Directory.CreateDirectory(root);
          File.Create(path);
        }
      } else {
        string content = File.ReadAllText(path);
        txtHistory.Text = content;
      }
    }
  }
}


