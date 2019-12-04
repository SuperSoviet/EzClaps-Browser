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
using System.Text;


namespace SovietBrowser {
  public partial class Login : Form {
    public Login() {
      InitializeComponent();
    }
    string[] usernames = { "admin", "moderator" };
    string[] passwords = { "100%Koffie", "bubugamer" };
    List<string> users = new List<string>();
    List<string> pass = new List<string>();

    private void btnLogin_Click(object sender, EventArgs e) {
      if (usernames.Contains(txtUsername.Text)&& passwords.Contains(txtPassword.Text) && Array.IndexOf(usernames, txtUsername.Text) == Array.IndexOf(passwords, txtPassword.Text))
    }
  }
}


