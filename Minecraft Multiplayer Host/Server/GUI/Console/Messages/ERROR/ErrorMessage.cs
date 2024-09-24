using Minecraft_Multiplayer_Host.Server.GUI.Console.Components;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Multiplayer_Host.Server.GUI.Console.Messages.ERROR
{
    internal class ErrorMessage
    {

        private int errorCount = 0;

        public ErrorMessage()
        {
            errorCount = 0;
        }

        public bool grabErrorMessage(string errorMessage, RichTextBox consoleOutput)
        {
            errorCount++;

            if (consoleOutput.IsDisposed) return false;

            if (errorMessage.Contains("Failed to start the minecraft server"))
            {
                consoleOutput.Invoke((MethodInvoker)delegate
                {
                    consoleOutput.Clear();
                    consoleOutput.AppendText(String.Format("[Minecraft-Multiplayer-Host ERROR ({0})] Failed to start server \n", errorCount));
                    consoleOutput.AppendText("\nError Message: \n");
                });
                return true; //Kills the process
            } else if (errorMessage.Contains("Unable to access jarfile"))
            {
                consoleOutput.Invoke((MethodInvoker)delegate
                {
                    consoleOutput.Clear();
                    consoleOutput.AppendText(String.Format("[Minecraft-Multiplayer-Host ERROR ({0})] Unable to access jarfile \n", errorCount));
                });
                return true; //Kills the process
            }

            consoleOutput.Invoke((MethodInvoker)delegate
            {
                consoleOutput.AppendText(String.Format("\n[Minecraft-Multiplayer-Host ERROR ({0})] An Error has Occurred \n", errorCount));
                consoleOutput.AppendText(String.Format("\nError Message: {0}\n", errorMessage));
            });
            return false; //Unknown error, does not kill process
        }
    }
}
