using CraftForge.Server.Classes.Logs;
using CraftForge.Server.GUI.Console;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CraftForge.Server.Classes.Player.Classes
{
    internal class playerRemovePanel
    {
        //string leaveBannedPattern = @"\[Server thread/INFO\]: " + leavePlayerName + @" \(/\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}:\d{1,5}\): lost connection";

        public static async void playerLeft(string data, Terminal terminal, FlowLayoutPanel playerList,
            Process serverProcess, TabControl serverTabs, int consoleID)
        {
            string[] leaveWords = data.Split(' '); //All the words
            int leaveIndex = Array.IndexOf(leaveWords, "lost"); //Gets the index of "lost"
            string leavePlayerName = "";

            //Gets the playerName
            if (leaveIndex != -1 && leaveIndex < leaveWords.Length - 1)
            {
                leavePlayerName = leaveWords[leaveIndex - 1];
            }
            string leaveConsolePattern = @"^\[\d{2}:\d{2}:\d{2} INFO\]: " + leavePlayerName + " lost connection: ";
            if (!Regex.IsMatch(data, leaveConsolePattern))
            {
                //Do not send log, as "Disconnecting" sends the same message
                //createNewLog.sendMessage(terminal, $"[Server] Bad Command! \"{data}\"");
                return;
            }

            //Remove player from list
            // Get the FlowLayoutChart control

            if (playerList != null)
            {
                // Get all the panels in the FlowLayoutChart
                var panels = playerList.Controls.OfType<Panel>().ToList();

                // Iterate through each panel
                foreach (var panel in panels)
                {
                    // Check if the panel name matches the player name
                    if (panel.Name == leavePlayerName)
                    {
                        // Remove the panel from the FlowLayoutChart
                        if (playerList.InvokeRequired)
                        {
                            playerList.Invoke(new Action(() => playerList.Controls.Remove(panel)));
                        }
                        else
                        {
                            playerList.Controls.Remove(panel);
                        }
                        await Task.Delay(1);
                        return;
                    }
                }
            }
        }

        public static async void playerBanned(string data, Terminal terminal, FlowLayoutPanel playerList,
            Process serverProcess, TabControl serverTabs, int consoleID)
        {
            //Replace [Server thread/INFO] with INFO] due to Vanilla vs PaperMC
            data.Replace("] [Server thread/INFO]", "INFO]");

            string[] leaveWords = data.Split(' '); //All the words
            int leaveIndex = Array.IndexOf(leaveWords, "Disconnecting"); //Gets the index of "lost"
            string playerName = "";

            //Gets the playerName
            if (leaveIndex != +1 && leaveIndex < leaveWords.Length + 1)
            {
                playerName = leaveWords[leaveIndex + 1];
            }

            string leaveConsolePattern = @"^\[\d{2}:\d{2}:\d{2} INFO\]: Disconnecting " + playerName + @" \((/\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}):(\d{1,5})\): ";

            if (!Regex.IsMatch(data, leaveConsolePattern))
            {
                createNewLog.sendMessage(terminal, $"[Server] Bad Command! \"{data}\"");
                return;
            }

            //Remove player from list
            // Get the FlowLayoutChart control

            if (playerList != null)
            {
                // Get all the panels in the FlowLayoutChart
                var panels = playerList.Controls.OfType<Panel>().ToList();

                // Iterate through each panel
                foreach (var panel in panels)
                {
                    // Check if the panel name matches the player name
                    if (panel.Name == playerName)
                    {
                        // Remove the panel from the FlowLayoutChart
                        if (playerList.InvokeRequired)
                        {
                            playerList.Invoke(new Action(() => playerList.Controls.Remove(panel)));
                        }
                        else
                        {
                            playerList.Controls.Remove(panel);
                        }
                        await Task.Delay(1);
                        return;
                    }
                }
            }
        }
    }
}
