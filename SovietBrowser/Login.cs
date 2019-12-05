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
    //usernames and passwords to use in the login
    string[] usernames = { "admin", "moderator","Panteradox" };
    string[] passwords = { "100%Koffie", "bubugamer", "Pa130576" };

    private void btnLogin_Click(object sender, EventArgs e) {
      //the moment you click the button login it checks if your logins are correct
      if (usernames.Contains(txtUsername.Text)
        && passwords.Contains(txtPassword.Text)
        && Array.IndexOf(usernames, txtUsername.Text) ==
        Array.IndexOf(passwords, txtPassword.Text)) {
        //If the login is correct it will hide the login screen and open the browser form
        this.Hide();
        EzClapsBrowser form = new EzClapsBrowser();
        form.ShowDialog();

      } else {
        //otherwise it opens a MessageBox telling you its the wrong login
        MessageBox.Show("Wrong login, if you want to reset it go to my Discord EzClaps Den and contact me");
      }
    }
    private void txtPassword_TextChanged(object sender, EventArgs e) {
      // hides your password as you put it in
      txtPassword.UseSystemPasswordChar = true;
    }
    private void txtPassword_KeyDown(object sender, KeyEventArgs e) {
      //you can use enter to use the login button
      if (e.KeyCode == Keys.Enter) {
        btnLogin_Click(this, new EventArgs());
      }
    }

    private void txtUsername_KeyDown(object sender, KeyEventArgs e) {
      //you can use enter to use the login button
      if (e.KeyCode == Keys.Enter) {
        btnLogin_Click(this, new EventArgs());
      }
    }

    private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      Register register = new Register();
      register.Show();
    }
  }
}



