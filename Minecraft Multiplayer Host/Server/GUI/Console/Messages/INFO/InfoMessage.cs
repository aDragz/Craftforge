using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Multiplayer_Host.Server.GUI.Console.Messages.INFO
{
    internal class InfoMessage
    {
        private int errorCount = 0;

        public InfoMessage()
        {
            errorCount = 0;
        }

        public bool grabInfoMessage(string errorMessage, RichTextBox consoleOutput, RichTextBox secondaryOutput, string location)
        {
            errorCount++;

            if (errorMessage.Contains("You need to agree to the EULA in order to run the server. Go to eula.txt for more info."))
            {
                consoleOutput.Invoke((MethodInvoker)delegate
                {
                    consoleOutput.Clear();
                    consoleOutput.AppendText("[Minecraft-Multiplayer-Host ERROR] You need to agree to the Minecraft EULA in order to run the server. \n");
                    consoleOutput.AppendText("\nError Message: \n");

                    secondaryOutput.AppendText("[Minecraft-Multiplayer-Host ERROR] You need to agree to the Minecraft EULA in order to run the server. \n");
                    secondaryOutput.AppendText("\nError Message: \n");

                    //Open the EULA file
                    System.Diagnostics.Process.Start("notepad.exe", location + "\\eula.txt");
                });
                return true; //Kills the process
            }

            //Will not send regular error message because warnings are not as severe as errors!
            return false; //Unknown error, does not kill process
        }
    }
}
