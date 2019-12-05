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
  public partial class Login : Form {
    public Login() {
     
      InitializeComponent();
    }
    string[] usernames = { "admin", "moderator" };
    string[] passwords = { "100%Koffie", "bubugamer" };

   
    private void btnLogin_Click(object sender, EventArgs e) {
     
      if (usernames.Contains(txtUsername.Text)
        && passwords.Contains(txtPassword.Text)
        && Array.IndexOf(usernames, txtUsername.Text) ==
        Array.IndexOf(passwords, txtPassword.Text)) {
        
        this.Hide();
        EzClapsBrowser form = new EzClapsBrowser();
        form.ShowDialog();

      } else {

        MessageBox.Show("Wrong login, if you want to reset it go to my discord and contact me");
      }
    }

    private void txtPassword_TextChanged(object sender, EventArgs e) {
      txtPassword.UseSystemPasswordChar = true;
    }
  }
}


