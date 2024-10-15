using Minecraft_Multiplayer_Host.Server.GUI.Console;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Minecraft_Multiplayer_Host.Server.GUI.Applications
{
    public partial class settings : Form
    {

        /*Naming Scheme for the settings
        
        Panel Name: {Type}Panel
        Label Name: {Type}{Panel}Panel (Example: MaximizeConsolePanel)

        Spacing:
        Panel = 160px
        Label = 15px x 80px [H/W]
        TextBox = 20px x 80px [H/W]
        CheckBox = 20px x 20px [H/W]

        */

        private readonly string themeLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\Minecraft-Multiplayer-Host\\Themes\\");

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
                foreach (TabPage tabPage in tabControl1.TabPages)
                {
                    if (tabPage.Text == parentName)
                    {
                        tabControl1.SelectTab(tabPage);
                    }
                }

                return;
            }

            //Change to the child tab
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                if (tabPage.Text == parentName)
                {
                    tabControl1.SelectTab(tabPage);
                }
            }

            //Grab each Label from the tab, and check the name. If it is the name of the child, focus on the label
            foreach (Control control in tabControl1.SelectedTab.Controls)
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
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control is TextBox)
                    {
                        try
                        {
                            TextBox textBox = (TextBox)control;

                            //Try to get the value from the settings file
                            string settingValue = Properties.Settings.Default[control.Name] as String; //Using as String to try to convert, and will be null if it fails

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
            foreach (Form form in Application.OpenForms)
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
            tabControl1.ItemSize = new Size(0, 1); //Hide the tabs
        }

        private void loadSettingsText()
        {
            loadTerminalSettings();
            loadStartupSettings();
        }

        private void loadTerminalSettings()
        {
            //Grab current theme
            string currentTheme = Properties.Settings.Default.Theme;

            bool terminal_startMaximized = Properties.Settings.Default.terminal_startMaximized;
            bool terminal_autoStart = Properties.Settings.Default.terminal_autoStart;

            //Set the current theme textbox
            themeListConsolePanel.Text = currentTheme;

            MaximizeConsolePanel.Checked = terminal_startMaximized;
            AutoStartConsolePanel.Checked = terminal_autoStart;
        }

        private void loadStartupSettings()
        {
            //Grab the startup settings
            bool startMenu_startMaximized = Properties.Settings.Default.startMenu_startMaximized;

            MaximizeStartupPanel.Checked = startMenu_startMaximized;
        }

        private void loadThemesList()
        {
            //Grab all files from location and add to list
            foreach (string file in Directory.GetFiles(themeLocation))
            {
                //Add the file to the list
                themeListConsolePanel.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }

        private void themeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Change the theme
            if (themeListConsolePanel.SelectedItem != null)
            {
                //Change the theme
                Properties.Settings.Default.Theme = themeListConsolePanel.SelectedItem.ToString();
                Properties.Settings.Default.Save();

                //Update the theme
                foreach (Form form in Application.OpenForms)
                {
                    if (form is Terminal)
                    {
                        Terminal terminal = (Terminal)form;
                        Terminal.InitializeThemeStatic(terminal); // Changed to access the static method directly from the class
                    }
                }
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

        private void MaximizeConsolePanel_CheckedChanged(object sender, EventArgs e)
        {
            //Grab the value
            bool startMaximized = MaximizeConsolePanel.Checked;

            //Save the value
            Properties.Settings.Default.terminal_startMaximized = startMaximized;
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
    }
}