using Minecraft_Multiplayer_Host.Server.Events;
using Minecraft_Multiplayer_Host.Server.GUI.Console;
using Minecraft_Multiplayer_Host.Server.Themes.Themes;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Minecraft_Multiplayer_Host.Server.GUI.Classes
{
    internal class createConsole
    {
        public Terminal createConsoleInTab(Terminal serverInstance, Process serverProcess, int consoleID, Terminal terminal)
        {

            if (serverInstance.serverTabs.InvokeRequired)
            {
                serverInstance.serverTabs.Invoke(new Action(() => createConsoleInTab(serverInstance, serverProcess, consoleID, terminal)));
                return serverInstance;
            }

            object processLock = new object(); //Create a lock object so the process can be locked (Single threaded)

            RichTextBox console = new RichTextBox();
            console.Dock = DockStyle.Fill;
            console.Name = "console " + consoleID;
            //Set font to consolas
            console.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            console.ReadOnly = true;

            //Set theme to output
            var theme = defaultTheme.ReadSettings();
            console.ForeColor = ColorTranslator.FromHtml(theme.Terminal_Terminal_Colour_Fore);
            console.BackColor = ColorTranslator.FromHtml(theme.Terminal_Terminal_Colour_Back);

            //Create command prompt
            RichTextBox cmd = new RichTextBox();
            cmd.Dock = DockStyle.Bottom;
            cmd.Size = new Size(1244, 30);
            cmd.Location = new Point(3, 552);
            cmd.Name = "cmd " + consoleID;
            cmd.Multiline = false;

            //Set font to consolas
            cmd.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            //Make cmd enter key event
            cmd.KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char) Keys.Enter)
                {
                    enterCommand.runCommand(cmd.Text, serverProcess, serverInstance.serverTabs, consoleID, terminal);
                    cmd.Clear();
                }
            };

            TabPage consoleTab = new TabPage();
            consoleTab.Controls.Add(console);
            consoleTab.Controls.Add(cmd);
            consoleTab.Name = "consoleTab " + consoleID;
            consoleTab.Text = "Console";

            int consoleTabIndex = 0;

            //Grab index of "Console" tab
            for (int i = 0; i < serverInstance.serverTabs.TabPages.Count; i++)
            {
                if (serverInstance.serverTabs.TabPages[i].Text == "Files")
                {
                    consoleTabIndex = i--;
                    break;
                }
            }
            //Add the console tab to the serverTabs
            try
            {
                if (consoleTabIndex == 0)
                    throw new ArgumentOutOfRangeException();

                serverInstance.serverTabs.TabPages.Insert(consoleTabIndex, consoleTab);
            } catch (ArgumentOutOfRangeException)
            {
                serverInstance.serverTabs.TabPages.Add(consoleTab); //At least add to the end of the list
            }

            return serverInstance;
        }
    }
}
