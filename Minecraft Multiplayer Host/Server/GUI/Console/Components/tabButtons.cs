using Minecraft_Multiplayer_Host.Properties;
using Minecraft_Multiplayer_Host.Server.Themes.Themes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Multiplayer_Host.Server.GUI.Console.Components
{
    internal class tabButtons
    {
        public static void resetSideBarButtons(Panel serverTabsPanel, TabControl serverTabs)
        {
            if (serverTabsPanel.InvokeRequired)
            {
                serverTabsPanel.Invoke(new Action(() => resetSideBarButtons(serverTabsPanel, serverTabs)));
            }
            else
            {
                serverTabsPanel.Controls.Clear();
                foreach (TabPage tabPage in serverTabs.TabPages)
                {
                    Label tabButton = new Label();

                    tabButton.TextAlign = ContentAlignment.MiddleCenter; //Center the text of the button
                    tabButton.ContextMenuStrip = new ContextMenuStrip(); //Create a context menu strip for the button

                    tabButton.Location = new Point(0, 50 * serverTabs.TabPages.IndexOf(tabPage)); //50 is the height of the button
                    tabButton.Size = new Size(100, 50); //Set the size of the button
                    tabButton.Text = tabPage.Text; //Set the text of the button to the text of the tab
                    tabButton.Name = tabPage.Name; //Set the name of the button to the name of the tab
                    tabButton.Click += (s, ev) => serverTabs.SelectTab(tabPage); //When the button is clicked, select the tab

                    serverTabsPanel.Controls.Add(tabButton); //Add the button to the panel

                    //Check if tab is console tab
                    if (tabPage.Text.Contains("Console"))
                    {
                        //Create new contextMenuStrip to remove the tab if the server is not running
                        ContextMenuStrip removeTabContextMenuStrip = new ContextMenuStrip();
                        removeTabContextMenuStrip.Items.Add("Remove Tab", null, (s, ev) =>
                        {
                            //Check if the server is running from the tab process id
                            String tabName = tabButton.Name;

                            String[] tabNameSplit = tabName.Split(' ');

                            int consoleID = int.Parse(tabNameSplit[1]);

                            //Check if the process is running
                            if (!Terminal.serverProcesses.ContainsKey(consoleID))
                            {
                                serverTabs.TabPages.Remove(tabPage);
                                resetSideBarButtons(serverTabsPanel, serverTabs);
                            }
                            else
                            {
                                MessageBox.Show("Cannot remove tab while server is running.");
                            }
                        });

                        tabButton.ContextMenuStrip = removeTabContextMenuStrip;
                    }

                    //Apply theme, because it resets the colours

                    var theme = defaultTheme.ReadSettings();

                    foreach (Control control in serverTabsPanel.Controls)
                    {
                        if (control is Label)
                        {
                            control.ForeColor = ColorTranslator.FromHtml(theme.Terminal_Label_Colour_Text);
                        }
                    }
                }
            }
        }

    }
}