using CraftForge.Server.GUI.Console;
using CraftForge.Server.StartPage.Classes;
using Newtonsoft.Json.Linq;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;
using System.Xml;

namespace CraftForge.Server.GUI.Applications
{
    public partial class settings : Form
    {
        static bool isLoadingSettings = true; // Flag to track loading state
        /*Naming Scheme for the settings
        
        Panel Name: {Type}Panel
        Label Name: {Type}{Panel}Panel (Example: MaximizeConsolePanel)

        Spacing:
        Panel = 160px
        Label = 15px x 80px [H/W]
        TextBox = 20px x 80px [H/W]
        CheckBox = 20px x 20px [H/W]

        */

        private readonly string themeLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\CraftForge\\Themes\\");

        public settings()
        {
            InitializeComponent();
            InitializeSettings();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode currentNode = e.Node;

            string topChildNode = GetTopChildNodeText(currentNode);

            if (e.Node.Parent == null) //Parent is null, so it is a root node
            {
                ChangeTab(e.Node.Text, null, topChildNode);
            }
            else
            {
                while (currentNode.Parent != null)
                {
                    currentNode = currentNode.Parent;
                }
                ChangeTab(currentNode.Text, e.Node.Text, topChildNode);
            }
        }

        private string GetTopChildNodeText(TreeNode currentNode)
        {
            string oldNode = null; //Saves previois node, so it can be used to get the old name before the parent node

            //Loop through the parent nodes until the root node is found
            while (currentNode.Parent != null)
            {
                currentNode = currentNode.Parent;

                //Check if the parent is the root node
                if (currentNode.Parent == null)
                {
                    //Return the old node before it is set, if it is the root node
                    break;
                }

                //Not the root node, so set the old node as the second to top node
                oldNode = currentNode.Text;
            }
            return oldNode;
        }

        private void ChangeTab(string parentName, string childName, string topChildName)
        {
            if (childName == null)
            {
                //Change to the parent tab
                foreach (TabPage tabPage in tabPage.TabPages)
                {
                    if (tabPage.Text == parentName)
                    {
                        this.tabPage.SelectTab(tabPage);
                    }
                }

                return;
            }

            //Change to the child tab
            foreach (TabPage tabPage in tabPage.TabPages)
            {
                if (tabPage.Text == parentName)
                {
                    this.tabPage.SelectTab(tabPage);
                }
            }

            //Grab each Label from the tab, and check the name. If it is the name of the child, focus on the label
            foreach (Control control in tabPage.SelectedTab.Controls)
            {
                if (control is Panel panel)
                {
                    //Check panel name
                    if (panel.Name.Replace("Panel", "") == topChildName)
                    {
                        foreach (Control panelControl in panel.Controls)
                        {
                            if (panelControl is Label label)
                            {
                                //Grab the selected tab name
                                string selectedTabName = panel.Name;

                                if (label.Name.Replace(selectedTabName, "") == childName)
                                {
                                    label.Focus();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void InitializeSettings()
        {
            foreach (TabPage tabPage in tabPage.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control is TextBox)
                    {
                        try
                        {
                            TextBox textBox = (TextBox)control;

                            //Try to get the value from the settings file
                            string settingValue = Properties.Settings.Default[control.Name] as string; //Using as String to try to convert, and will be null if it fails

                            if (!string.IsNullOrEmpty(settingValue))
                            {
                                control.Text = settingValue;
                            }
                        }
                        catch (SettingsPropertyNotFoundException)
                        {
                            continue;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Grab each open terminal, and update the theme
            foreach (Form form in global::System.Windows.Forms.Application.OpenForms)
            {
                if (form is Terminal)
                {
                    Terminal terminal = (Terminal)form;
                    Terminal.InitializeThemeStatic(terminal); // Changed to access the static method directly from the class
                }
            }
        }

        private void settings_Load(object sender, EventArgs e)
        {
            //Load themes
            loadThemesList();

            //Load Settings
            loadSettingsText();

            //Tab Control
            tabPage.ItemSize = new Size(0, 1); //Hide the tabs
        }

        private void loadSettingsText()
        {
            loadTerminalSettings();
            loadStartupSettings();
            loadTypeSettings();
        }

        private void loadTerminalSettings()
        {
            //Grab current theme
            string currentTheme = Properties.Settings.Default.Theme;

            bool terminal_autoStart = Properties.Settings.Default.terminal_autoStart;

            bool terminal_autoScroll = Properties.Settings.Default.terminal_autoScroll;

            //Set the current theme textbox
            themeListConsolePanel.Text = currentTheme;

            AutoStartConsolePanel.Checked = terminal_autoStart;

            autoScrollConsolePanel.Checked = terminal_autoScroll;
        }

        private void loadStartupSettings()
        {
            //Grab the startup settings
            bool startMenu_startMaximized = Properties.Settings.Default.startMenu_startMaximized;
            bool displaySystemSpecifications = Properties.Settings.Default.displaySystemSpecifications;

            MaximizeStartupPanel.Checked = startMenu_startMaximized;
            SpecificationsStartupPanel.Checked = displaySystemSpecifications;
        }

        private async void loadTypeSettings()
        {
            isLoadingSettings = true;
            string url = "https://craftforge.dev/api/latest.json";
            using (HttpClient client = new HttpClient())
            {
                //Grab Data
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    JObject json = JObject.Parse(responseBody);
                    JArray versions = (JArray)json["types"];
                    string latestVersion = versions.Last.ToString();

                    TypeListAppPanel.Items.Clear();
                    // Add all builds to the "build" selector
                    foreach (var version in versions)
                    {
                        TypeListAppPanel.Items.Add(version);
                    }

                    //Set the textBox to the current selected setting:
                    //Select CraftForge Update Settings, as that is the updater program for CraftForge
                    string mainLocation = Assembly.GetExecutingAssembly().Location;
                    string configLocation = mainLocation.Substring(0, mainLocation.Length - 4).Replace("Craft Forge", "") + "CraftForge Updater.exe.config";

                    //Load the configuration file
                    XmlDocument configDoc = new XmlDocument();
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
                                TypeListAppPanel.Text = valueNode.InnerText;
                            }
                        }
                    }
                }
                catch { }
            }
            isLoadingSettings = false;

            bool autoUpdate = Properties.Settings.Default.autoUpdate;
            AutoUpdateAppPanel.Checked = autoUpdate;
        }

        private void loadThemesList()
        {
            //Check if default theme exists
            if (!File.Exists(themeLocation + "Default"))
            {
                //Create the default theme
                themeListConsolePanel.Items.Add("Default");
                //Add a spacer
                themeListConsolePanel.Items.Add("");
            }

            //Grab all files from location and add to list
            foreach (string file in Directory.GetFiles(themeLocation))
            {
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);

                //Skip the default theme, as it already exists in the list
                if (fileNameWithoutExtension.Equals("default", StringComparison.OrdinalIgnoreCase))
                    continue;

                //Add the file to the list

                //Make the first character Upper Case
                fileNameWithoutExtension = char.ToUpper(fileNameWithoutExtension[0]) + fileNameWithoutExtension.Substring(1);

                themeListConsolePanel.Items.Add(fileNameWithoutExtension);
            }
        }

        private void themeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Change the theme
            if (!string.IsNullOrEmpty(themeListConsolePanel.SelectedItem.ToString()))
            {
                //Change the theme
                Properties.Settings.Default.Theme = themeListConsolePanel.SelectedItem.ToString();
                Properties.Settings.Default.Save();

                //Update the theme
                foreach (Form form in global::System.Windows.Forms.Application.OpenForms)
                {
                    if (form is Terminal)
                    {
                        Terminal terminal = (Terminal)form;
                        Terminal.InitializeThemeStatic(terminal); // Changed to access the static method directly from the class
                    }
                }
            }
            else
            {
                //Set the text back to the current theme
                themeListConsolePanel.Text = Properties.Settings.Default.Theme;
            }
        }

        private void MaximizeStartupPanel_CheckedChanged(object sender, EventArgs e)
        {
            //Grab the value
            bool startMaximized = MaximizeStartupPanel.Checked;

            //Save the value
            Properties.Settings.Default.startMenu_startMaximized = startMaximized;
            Properties.Settings.Default.Save();
        }

        private void SpecificationsStartupPanel_CheckedChanged(object sender, EventArgs e)
        {
            //Grab the value
            bool specifications = SpecificationsStartupPanel.Checked;

            //Save the value
            Properties.Settings.Default.displaySystemSpecifications = specifications;
            Properties.Settings.Default.Save();
        }

        private void AutoStartConsolePanel_CheckedChanged(object sender, EventArgs e)
        {
            //Grab the value
            bool autoStart = AutoStartConsolePanel.Checked;

            //Save the value
            Properties.Settings.Default.terminal_autoStart = autoStart;
            Properties.Settings.Default.Save();
        }

        private void autoScrollConsolePanel_CheckedChanged(object sender, EventArgs e)
        {
            //Grab the value
            bool autoScroll = autoScrollConsolePanel.Checked;

            //Save the value
            Properties.Settings.Default.terminal_autoScroll = autoScroll;
            Properties.Settings.Default.Save();
        }

        private void TypeListConsolePanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoadingSettings)
            {
                if (!restartApplicationDialog())
                    return;

                //Check if you are an admin
                if (!IsUserAdministrator())
                {
                    // Restart the application with administrative privileges
                    RestartWithAdminPrivileges(TypeListAppPanel.Text);
                    return;
                }

                CraftForgeUpdaterConfig("TypeSelected", TypeListAppPanel.Text); //If stable is selected, it will be updated as stable as an example.
                autoUpdate.checkForUpdates(); //Check for updates after the settings have been updated
            }
        }

        private void AutoUpdateAppPanel_CheckedChanged(object sender, EventArgs e)
        {
            //Grab the value
            bool autoUpdate = AutoUpdateAppPanel.Checked;

            //Save the value
            Properties.Settings.Default.autoUpdate = autoUpdate;
            Properties.Settings.Default.Save();
        }

        public static void CraftForgeUpdaterConfig(string key, string value)
        {
            try
            {
                // Select CraftForge Update Settings, as that is the updater program for CraftForge
                string mainLocation = Assembly.GetExecutingAssembly().Location;
                string configLocation = mainLocation.Substring(0, mainLocation.Length - 4).Replace("Craft Forge", "") + "CraftForge Updater.exe.config";

                // Load the configuration file
                XmlDocument configDoc = new XmlDocument();
                configDoc.Load(configLocation);

                // Find the userSettings section
                XmlNode userSettingsNode = configDoc.SelectSingleNode("//userSettings/CraftForge_Updater.Properties.Settings");

                // Find the setting element
                XmlNode settingNode = userSettingsNode.SelectSingleNode($"setting[@name='{key}']");

                // Update the value
                XmlNode valueNode = settingNode.SelectSingleNode("value");
                if (valueNode != null)
                {
                    valueNode.InnerText = value;
                }

                // Save the changes
                configDoc.Save(configLocation);
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error occurred while trying to update the settings. Please try again later. \n {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool IsUserAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void RestartWithAdminPrivileges(string releaseName)
        {
            MessageBox.Show("This operation requires administrative privileges. Please restart the application as an administrator.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ProcessStartInfo proc = new ProcessStartInfo
            {
                UseShellExecute = true,
                WorkingDirectory = Environment.CurrentDirectory,
                FileName = Application.ExecutablePath,
                Verb = "runas",
                Arguments = $"--admin-restart --settings {releaseName}" // Add a command-line argument
            };

            try
            {
                Process.Start(proc);
                Environment.Exit(0);
            }
            catch
            {
                // The user refused the elevation request
                MessageBox.Show("Cannot update the settings without administrative privileges.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool restartApplicationDialog()
        {
            //Confirm with the user to update, as the Application will restart
            DialogResult restartApplication = MessageBox.Show("Please close any open servers to avoid data loss. The application will restart to apply the changes.", "Restart Required", MessageBoxButtons.OKCancel);

            if (restartApplication == DialogResult.Cancel)
            {
                return false;
            }

            return true;
        }
    }
}