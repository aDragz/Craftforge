using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CraftForge.Server.GUI.Console.Messages.WARN
{
    internal class WarnMessage
    {
        private int errorCount = 0;

        public WarnMessage()
        {
            errorCount = 0;
        }

        public bool grabWarnMessage(String errorMessage, RichTextBox consoleOutput, RichTextBox secondaryOutput)
        {
            errorCount++;

            //Port is already in use
            if (errorMessage.Contains(" **** FAILED TO BIND TO PORT!"))
            {
                consoleOutput.Invoke((MethodInvoker)delegate
                {
                    consoleOutput.Clear();
                    consoleOutput.AppendText(String.Format("[Minecraft-Multiplayer-Host ERROR] Port {0} is already in use. \n", "25565"));
                    consoleOutput.AppendText("\nError Message: \n");

                    secondaryOutput.AppendText(String.Format("[Minecraft-Multiplayer-Host ERROR] Port {0} is already in use. \n", "25565"));
                    secondaryOutput.AppendText("\nError Message: \n");
                });
                return true; //Kills the process
            }

            //Will not send regular error message because warnings are not as severe as errors!
            return false; //Unknown error, does not kill process
        }
    }
}
