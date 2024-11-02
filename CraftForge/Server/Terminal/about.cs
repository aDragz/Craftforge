using System;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

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
            string website = "https://craftforge.dev"; //Website URL
            string release = "Unknown";

            try
            {

                //Load the configuration file
                XmlDocument configDoc = new XmlDocument();
                string mainLocation = Assembly.GetExecutingAssembly().Location;
                string configLocation = mainLocation.Substring(0, mainLocation.Length - 4).Replace("Craft Forge", "") + "CraftForge Updater.exe.config";

                configDoc.Load(configLocation);

                //Find the userSettings section
                XmlNode userSettingsNode = configDoc.SelectSingleNode("//userSettings/CraftForge_Updater.Properties.Settings");
                if (userSettingsNode != null)
                {
                    XmlNode settingNode = userSettingsNode.SelectSingleNode($"setting[@name='TypeSelected']");
                    if (settingNode != null)
                    {
                        XmlNode valueNode = settingNode.SelectSingleNode("value");
                        if (valueNode != null)
                        {
                            release = valueNode.InnerText;
                        }
                    }
                }
            }
            catch { }

            aboutLabel.Text = "CraftForge\n\n" + //Title
                $"Version: {version}\n" +
                $"Release: {release}\n" +
                $"Website: {website}"; //Displays Version
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
