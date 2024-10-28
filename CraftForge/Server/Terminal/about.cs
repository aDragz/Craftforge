using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Core.Tokens;

namespace CraftForge
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
            //Use okButton as it is selected when you open the window. Using this. does not work.
            okButton.KeyDown += new KeyEventHandler(MainWindow_KeyDown); //Close the Window when the user presses Enter or Escape
        }

        private void about_Load(object sender, EventArgs e)
        {
            loadLabel(); //Load the about label to display data
        }

        private void loadLabel()
        {
            //Grab the version of the application automatically
            string version = Application.ProductVersion.Substring(0, Application.ProductVersion.Length - 2);

            aboutLabel.Text = "CraftForge\n\n" + //Title
                $"Version: {version}\n"; //Displays Version
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
