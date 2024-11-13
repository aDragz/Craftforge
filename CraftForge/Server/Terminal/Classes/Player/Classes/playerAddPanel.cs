using CraftForge.Server.Classes.Logs;
using CraftForge.Server.GUI.Console;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CraftForge.Server.Classes.Player.Classes
{
    internal class playerAddPanel
    {
        public static async void playerJoined(string data, Terminal terminal, FlowLayoutPanel playerList, 
            Process serverProcess, TabControl serverTabs, int consoleID)
        {
            string[] joinWords = data.Split(' '); //All the words
            int playerIndex = Array.IndexOf(joinWords, "player"); //Gets the index of "player"
            string joinPlayerName = "";

            string joinConsolePattern = @"^\[\d{2}:\d{2}:\d{2} INFO\]: UUID of player";
            if (!Regex.IsMatch(data, joinConsolePattern))
            {
                createNewLog.sendMessage(terminal, $"[Server] Bad Command! \"{data}\"");
                return;
            }

            //Gets the playerName
            if (playerIndex != -1 && playerIndex < joinWords.Length - 1)
            {
                joinPlayerName = joinWords[playerIndex + 1];
            }

            await playerJoin.addPlayer(playerList, joinPlayerName, serverProcess, serverTabs, consoleID, terminal);
        } 
    }
}
