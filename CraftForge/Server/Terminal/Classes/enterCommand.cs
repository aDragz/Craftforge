using CraftForge.Server.GUI.Console;
using CraftForge.Server.GUI.Setup;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CraftForge.Server.Events
{
    internal class enterCommand
    {
        public static void runCommand(string command, Process serverProcess, TabControl serverTabs, int consoleID, Terminal terminal)
        {
            //Grab current window
            
            if (string.IsNullOrWhiteSpace(command)) return;

            //Check if the server is running before sending a command
            if (serverProcess == null) return;
            if (serverTabs == null) return;

            try
            {
                if (serverTabs.InvokeRequired)
                {
                    serverTabs.Invoke((MethodInvoker)delegate
                    {
                        serverProcess.StandardInput.WriteLine(command);
                    });
                }
                else
                {
                    serverProcess.StandardInput.WriteLine(command);
                }
            }
            catch (InvalidOperationException e)
            {
                //Check each richTextBox and append the output to the correct one
                if (serverTabs.SelectedTab.Name == "consoleTab " + consoleID)
                {
                    RichTextBox console = (RichTextBox)serverTabs.SelectedTab.Controls
                        .OfType<RichTextBox>()
                        .FirstOrDefault(rtb => rtb.Name == "cmd " + consoleID);

                    RichTextBox secondaryTerminal = (RichTextBox)serverTabs.TabPages[0].Controls
                        .OfType<RichTextBox>()
                        .FirstOrDefault(rtb => rtb.Name == "secondaryTerminal " + consoleID);

                    Terminal.AppendTextToCommandOutput("[CraftForge ERROR] " + e.Message, console, secondaryTerminal, false, terminal);
                }
            }
        }
    }
}
