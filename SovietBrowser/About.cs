using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


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
      //a secret smile, to make you smile
      MessageBox.Show("^_^");
    }
    private void About_Load(object sender, EventArgs e) {
      //shows Assembly version ( version of the browser ) 
      Version version = Assembly.GetExecutingAssembly().GetName().Version;
      txtBoxVersion.Text = "version: " + version;
      //shows assembly copyright 
      var copyright = ((AssemblyCopyrightAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyCopyrightAttribute), false));
      if (copyright != null) {
        txtCopyRight.Text = copyright.Copyright;
      }
      //shows assembly companyname
      lblCompany.Text = "For more information on " + Application.CompanyName;
      txtBrowserName.Text = AssemblyName.GetAssemblyName(Assembly.GetExecutingAssembly().Location).Name;
    }
  }
}