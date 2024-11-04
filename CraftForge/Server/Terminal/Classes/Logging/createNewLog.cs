using CraftForge.Server.GUI.Console;
using System;

namespace CraftForge.Server.Classes.Logs
{
    internal class createNewLog
    {
        //Prefixes:
        //  [Server] - Server related logs
        //  [Settings] - File/Settings related logs
        public static void sendMessage(Terminal terminal, string message)
        {
            //grab date and time
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            string time = DateTime.Now.ToString("HH:mm:ss");


            if (terminal.logsOutput.InvokeRequired)
            {
                terminal.logsOutput.Invoke(new Action(() =>
                {
                    terminal.logsOutput.AppendText($"[{date}\\{time}] {message}\n");
                }));
            }
            else
            {
                terminal.logsOutput.AppendText($"[{date}\\{time}] {message}\n");
            }
        }
    }
}
