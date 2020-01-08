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
using System.Reflection;

namespace EzClapsBrowser {
  public partial class Login : Form {
    public Login() {

      InitializeComponent();
    }
    //usernames and passwords to use in the login
    string[] usernames = { "stefano","admin", "moderator","Panteradox" };
    string[] passwords = { "100%Koffie","admin", "bubugamer", "Pa130576" };

    private void btnLogin_Click(object sender, EventArgs e) {
      //the moment you click the button login it checks if your logins are correct 
      //by checking the textboxes to see if the text you put in is the same as the tekst of the string array ( for both username and password ) 
      if (usernames.Contains(txtUsername.Text)
        && passwords.Contains(txtPassword.Text)
        && Array.IndexOf(usernames, txtUsername.Text) ==
        Array.IndexOf(passwords, txtPassword.Text)) {
        //If the login is correct it will hide the login screen and open the browser form
        this.Hide();
        EzClapsBrowser browserForm = new EzClapsBrowser();
        browserForm.ShowDialog();

      } else {
        //otherwise it opens a MessageBox telling you its the wrong login and showing you how to get a login or change your login
        MessageBox.Show("Wrong login, if you wish to reset it or get a login go to my Discord EzClaps Den and contact me. if your not yet in my discord use the Register button to do so.");
        
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
        txtPassword.Select();
      }
    }

    private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      //Sends you to the Register.cs
      Register register = new Register();
      register.Show();
    }

    private void Login_Load(object sender, EventArgs e) {
      Version version = Assembly.GetExecutingAssembly().GetName().Version;
      textBoxVersion.Text = "V" + version;
    }
  }
}