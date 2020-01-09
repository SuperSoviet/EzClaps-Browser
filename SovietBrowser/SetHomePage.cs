using System;
using System.IO;
using System.Windows.Forms;

namespace EzClapsBrowser
{
    public partial class SetHomePage : Form
    {
        public SetHomePage()
        {
            InitializeComponent();
            string root = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\EzclapsBrowser";
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\EzclapsBrowser\Home.txt";

            if (!Directory.Exists(root))
            {
                File.Create(path);
            }
            else
            {
                //if both the directory and Home.txt exist or been made then we can enter the folder and read / 
                //write out the file and whats inside
                string content = File.ReadAllText(path);
                txtHomePage.Text = content;
            }
        }

        private void btnSaveHome_Click(object sender, EventArgs e)
        {
            
        }
    }
}