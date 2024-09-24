using Minecraft_Multiplayer_Host.Server.GUI.Console;
using Minecraft_Multiplayer_Host.Server.Themes.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Multiplayer_Host.Server.GUI.Applications
{
    public partial class settings : Form
    {

        private readonly string themeLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\Minecraft-Multiplayer-Host\\Themes\\");

        public settings()
        {
            InitializeComponent();
            InitializeSettings();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent == null) //Parent is null, so it is a root node
            {
                ChangeTab(e.Node.Text, null);
            }
            else
            {
                TreeNode currentNode = e.Node;

                while (currentNode.Parent != null)
                {
                    currentNode = currentNode.Parent;
                }
                ChangeTab(currentNode.Text, e.Node.Text);
            }
        }

        private void ChangeTab(String parentName, String childName)
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
                if (control is Label)
                {
                    Label label = (Label)control;

                    if (label.Name == childName)
                    {
                        label.Focus();
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
                            String settingValue = Properties.Settings.Default[control.Name] as String; //Using as String to try to convert, and will be null if it fails

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
        }

        private void loadThemesList()
        {
            //Grab all files from location and add to list
            foreach (String file in Directory.GetFiles(themeLocation))
            {
                //Add the file to the list
                themeList.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }

        private void themeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Change the theme
            if (themeList.SelectedItem != null)
            {
                //Change the theme
                Properties.Settings.Default.Theme = themeList.SelectedItem.ToString();
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
    }
}