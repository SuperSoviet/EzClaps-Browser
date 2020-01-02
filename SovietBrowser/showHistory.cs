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

namespace EzClapsBrowser {
  public partial class showHistory : Form {
    public showHistory() {
      InitializeComponent();
      
      var path = (@"C:\EzClapsBrowser\History.txt");
      //looks if the history.txt file exists
      if (!File.Exists(path)) {
        //path doesn't exist yet so we create one 
        string root = @"C:\EzClapsBrowser";
        //Looks up if the Folder exists 
        if (!Directory.Exists(root)) {
          //doesn't exist so we make one based on the root directory
          Directory.CreateDirectory(root);
          //we also make a new History.txt file ( if the directory doesnt exist then the file wouldnt exist aswel ) 
          File.Create(path);
        }
      } else {
        //if both the directory and History.txt exist or been made then we can enter the folder and read / 
        //write out the file and whats inside
        string content = File.ReadAllText(path);
        txtHistory.Text = content;
      }
    }
    private void btnClear_Click(object sender, EventArgs e) {
      //Takes the path
      string path = @"C:\EzClapsBrowser\History.txt";
      //checks if it exists
      if (File.Exists(path)) {
        //it exists and since we want to clear it we delete the txt file and refresh the page
        //the next time you open history it runs the CreateDirectory and Create History.txt again
        File.Delete(path);
        txtHistory.Clear();
        txtHistory.Refresh();
      }
    }
  }
}


