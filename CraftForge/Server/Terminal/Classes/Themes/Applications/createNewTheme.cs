using CraftForge.Server.GUI.Setup;
using System;
using System.IO;
using System.Windows.Forms;

namespace CraftForge.Server.Classes.Themes.Applications
{
    public partial class CreateNewTheme : Form
    {
        public static string themeName;

        public CreateNewTheme()
        {
            InitializeComponent();
        }

        private void createNewTheme_Load(object sender, EventArgs e)
        {
            this.Text = $"Create New Theme | CraftForge {Startup.release} - v{Startup.applicationVersion}"; //Change this if I change title again (ctrl+f)
            loadThemesList(); //Load the themes for the "copyFromList" ComboBox

            themeNameTxt.Focus();
        }

        private void loadThemesList()
        {
            copyFromList.Items.Clear();

            copyFromList.Text = "(None)";

            //Add "Create new theme"
            copyFromList.Items.Add("(None)");
            copyFromList.Items.Add(""); //Add spacer

            //Check if default theme exists
            if (!File.Exists(customizeTheme.themeLocation + "Default"))
            {
                //Create the default theme
                copyFromList.Items.Add("Default");
                //Add a spacer
                copyFromList.Items.Add("");
            }

            //Grab all files from location and add to list
            foreach (string file in Directory.GetFiles(customizeTheme.themeLocation))
            {
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);

                //Skip the default theme, as it already exists in the list
                if (fileNameWithoutExtension.Equals("default", StringComparison.OrdinalIgnoreCase))
                    continue;

                //Add the file to the list

                //Make the first character Upper Case
                fileNameWithoutExtension = char.ToUpper(fileNameWithoutExtension[0]) + fileNameWithoutExtension.Substring(1);

                copyFromList.Items.Add(fileNameWithoutExtension);
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (themeNameTxt.Text == "" || themeNameTxt.Text.ToLower() == "create a new theme")
            {
                MessageBox.Show("Please enter a valid theme name");
                return;
            }

            //Check to see if the theme already exists
            if (File.Exists($"{customizeTheme.themeLocation}\\{themeNameTxt.Text}.yaml"))
            {
                MessageBox.Show($"Theme already exists ({themeNameTxt.Text}.yaml)");
                DialogResult = DialogResult.Cancel; 
                return;
            }

            //Check to see if the user wants to copy from another theme
            if (copyFromList.Text != "(None)")
            {
                //Check if the file exists
                if (!File.Exists($"{customizeTheme.themeLocation}\\{copyFromList.Text.ToLower()}.yaml"))
                    return; //Return if the file does not exist

                File.Copy($"{customizeTheme.themeLocation}\\{copyFromList.Text.ToLower()}.yaml", $"{customizeTheme.themeLocation}\\{themeNameTxt.Text}.yaml"); //Copy the file to the new name

                DialogResult = DialogResult.OK; //Set result to ok
                themeName = themeNameTxt.Text;
                this.Close();
                return; //Return, else it will continue the code, even if it closes the Window
            }
            else
            {
                //Create a new theme
                DialogResult = DialogResult.OK; //Set result to ok

                themeName = themeNameTxt.Text;
                customizeTheme.createNewTheme(themeNameTxt.Text); //Creates a new theme

                this.Close();
            }
        }
    }
}