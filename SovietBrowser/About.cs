using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzClapsBrowser {
  public partial class About : Form {
    public About() {
      InitializeComponent();
    }

    private void lblMyDiscord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      //if you press the linklabel you open the Register.cs 
      Register discord = new Register();
      discord.Show();
    }

    private void pbMyLogo_Click(object sender, EventArgs e) {
      MessageBox.Show("^_^");
    }
  }
}
