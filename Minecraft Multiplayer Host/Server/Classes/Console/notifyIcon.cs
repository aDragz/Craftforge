using Minecraft_Multiplayer_Host.Server.Classes.Console.Applications;
using Minecraft_Multiplayer_Host.Server.GUI.Applications;
using Minecraft_Multiplayer_Host.Server.GUI.Console;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Minecraft_Multiplayer_Host.Server.Classes
{
    internal class notifyIcon
    {
        private static NotifyIcon icon;
        private static ContextMenuStrip contextMenu;

        public static Terminal closedWindows;

        public static void InitializeTrayIcon()
        {
            // Create context menu
            contextMenu = new ContextMenuStrip();

            //settings
            var settingsMenuItem = new ToolStripMenuItem("Settings", null, (sender, e) =>
            {
                runSettings.runSettingsApp();
            });

            //exit
            var exitMenuItem = new ToolStripMenuItem("Exit", null, OnExit);
            contextMenu.Items.Add(settingsMenuItem);
            contextMenu.Items.Add(exitMenuItem);

            // Create notify icon
            icon = new NotifyIcon
            {
                Icon = SystemIcons.Application, // Use your own icon here
                Text = "Minecraft Multiplayer Host",
                ContextMenuStrip = contextMenu,
                Visible = true
            };
        }

        private static void OnExit(object sender, EventArgs e)
        {
            icon.Visible = false; // Hide the icon before exiting
            Application.Exit();
        }

        public static void showClosedWindows()
        {
            contextMenu.Items.Clear(); //Clear the context menu to avoid duplicates

            //Display notification
            notifyIcon.icon.BalloonTipText = "Server has been minimized to the tray!";
            notifyIcon.icon.BalloonTipTitle = "Server minimized";
            notifyIcon.icon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.icon.ShowBalloonTip(3);
            List<Terminal> terminals = new List<Terminal>();

            //Add selections
            
            //settings
            var settingsMenuItem = new ToolStripMenuItem("Settings", null, (sender, e) =>
            {
                new settings().Show();
            });

            //exit
            var exitMenuItem = new ToolStripMenuItem("Exit", null, OnExit);
            contextMenu.Items.Add(settingsMenuItem);
            contextMenu.Items.Add(exitMenuItem);

            foreach (Form form in Application.OpenForms)
            {
                if (form is Terminal)
                {
                    //Check if it is visible or not
                    if (!form.Visible)
                    {
                        //Add to recent list in icon
                        var menuItem = new ToolStripMenuItem(form.Text, null, (sender, e) =>
                        {
                            form.Show();

                            // Remove from recent list in icon
                            contextMenu.Items.Remove((ToolStripMenuItem)sender);
                        });
                        contextMenu.Items.Insert(0, menuItem);
                    }
                }
            }
        }
    }
}
