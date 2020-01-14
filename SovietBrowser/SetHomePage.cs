using System;
using System.IO;
using System.Windows.Forms;

namespace EzClapsBrowser {
  public partial class SetHomePage : Form {
    public SetHomePage() {
      InitializeComponent();

      string root = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\EzclapsBrowser";
      var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\EzclapsBrowser\Home.txt";
      if (!Directory.Exists(root)) {
        File.Create(path);
      } else {
        //if both the directory and Home.txt exist or been made then we can enter the folder and read / 
        //write out the file and whats inside
        string content = File.ReadAllText(path);
        txtHomePage.Text = content;
      }
    }
    //Loads in the path > then what is inside the textfile > puts the text of the file into the textbox of the winform
    private void SetHomePage_Load(object sender, EventArgs e) {
      var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\EzclapsBrowser\Home.txt";
      File.ReadAllText(path);
    }


    private void btnSaveHome_Click(object sender, EventArgs e) {
      //when you press safe it searches for the file location 
      //then it will remove everything in the text file to make sure it is clean 
      //and it doesnt overlap with old text on accident
      //after that it will add the text that you put in the text box and use it as a homepage
      var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\EzclapsBrowser\Home.txt";
      File.WriteAllText(path, "");
      File.WriteAllText(path, txtHomePage.Text);
    }
  }
}